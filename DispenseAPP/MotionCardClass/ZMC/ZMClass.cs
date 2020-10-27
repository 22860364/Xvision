using System;
using cszmcaux;
using DispenseAPP.AboutData;
using DispenseAPP.AboutMotionCard.ConfigCardClass;
using DispenseAPP.接口;
using static DispenseAPP.CommonClass;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DispenseAPP
{
    public class ZMClass : IMotionCard
    {
        private IntPtr _handle = IntPtr.Zero;

        private enum LimitedType//特殊IO类型
        {
            PEL,
            ORG,
            MEL,
            Alaram,
        }

        public ZMClass(MCDataClass motionCardDataClass) : base(motionCardDataClass)
        {
            ReadTimer = new System.Threading.Timer(new TimerCallback(ReadIOAxisState), null, 0, 100);
        }

        public override bool InitialMotionCard(out string errorMessage)// 初始化运动控制卡
        {
            errorMessage = "";
            if (McDataClass.CardConfig != null && McDataClass.CardConfig is IPAddressClass configZMotionCardClass)
            {
                if (configZMotionCardClass.IPAddress == "")
                {
                    errorMessage = "未配置运动控制卡";
                    return false;
                }
                if (zmcaux.ZAux_OpenEth(configZMotionCardClass.IPAddress, out _handle) != 0)
                {
                    errorMessage = "打开控制器失败,请检查硬件配置和IP地址!";
                    return false;
                }
                for (int i = 0; i < McDataClass.AxisConfigList.Count; i++)
                {
                    short axisID = McDataClass.AxisConfigList[i].AxisID;//轴号
                    string axisName = McDataClass.AxisConfigList[i].AxisName;//轴名称
                    if (zmcaux.ZAux_Direct_SetAtype(_handle, axisID, 1) != 0)//设置轴类型为：脉冲方向方式的步进或伺服
                    {
                        errorMessage = "设置【" + axisName + "】轴类型失败！";
                        return false;
                    }
                    if (zmcaux.ZAux_Direct_SetInvertStep(_handle, axisID, 0) != 0) //设置脉冲模式：脉冲+方向模式（默认）
                    {
                        errorMessage = "设置【" + axisName + "】脉冲模式失败！";
                        return false;
                    }
                    if (zmcaux.ZAux_Direct_SetUnits(_handle, axisID, McDataClass.AxisConfigList[i].Pulse * 1.0f / McDataClass.AxisConfigList[i].Pitch) != 0)//设置脉冲当量
                    {
                        errorMessage = "设置【" + axisName + "】脉冲当量失败！";
                        return false;
                    }
                    int index = McDataClass.LimitConfigList.FindIndex(c => c.AxisName == axisName);
                    if (index != -1)
                    {
                        if (SetSpecialIn(LimitedType.PEL, axisID, McDataClass.LimitConfigList[index].PELPort, McDataClass.LimitConfigList[index].PELLevel) != 0)
                        {
                            errorMessage = "设置【" + axisName + "】正限位端口失败！";
                            return false;
                        }
                        if (SetSpecialIn(LimitedType.ORG, axisID, McDataClass.LimitConfigList[index].ORGPort, McDataClass.LimitConfigList[index].ORGLevel) != 0)
                        {
                            errorMessage = "设置【" + axisName + "】原点端口失败！";
                            return false;
                        }
                        if (SetSpecialIn(LimitedType.MEL, axisID, McDataClass.LimitConfigList[index].MELPort, McDataClass.LimitConfigList[index].MELLevel) != 0)
                        {
                            errorMessage = "设置【" + axisName + "】负限位端口失败！";
                            return false;
                        }
                        if (SetSpecialIn(LimitedType.Alaram, axisID, McDataClass.LimitConfigList[index].AlarmPort, McDataClass.LimitConfigList[index].AlarmLevel) != 0)
                        {
                            errorMessage = "设置【" + axisName + "】报警端口失败！";
                            return false;
                        }
                    }
                    else
                    {
                        errorMessage = "【" + axisName + "】未配置特殊IO端口！";
                        return false;
                    }
                    AxisStateClass axisStateStruct = new AxisStateClass
                    {
                        AxisID = axisID,
                        AxisName = axisName,
                    };
                    AxisStateList.Add(axisStateStruct);
                }
                CardConnectState = true;
                StartCheck = true;
                return true;
            }
            return false;
        }

        private int SetSpecialIn(LimitedType limitedType, int AxisID, int Port, string levelLogic)//特殊IO配置  这个函数需要测试逻辑
        {
            int ret = 0;
            switch (limitedType)
            {
                case LimitedType.PEL:
                    ret = zmcaux.ZAux_Direct_SetFwdIn(_handle, AxisID, Port);
                    break;
                case LimitedType.ORG:
                    ret = zmcaux.ZAux_Direct_SetDatumIn(_handle, AxisID, Port);
                    break;
                case LimitedType.MEL:
                    ret = zmcaux.ZAux_Direct_SetRevIn(_handle, AxisID, Port);
                    break;
                case LimitedType.Alaram:
                    ret = zmcaux.ZAux_Direct_SetAlmIn(_handle, AxisID, Port);
                    break;
            }
            if (ret != 0) { return ret; }
            if (levelLogic == "高电平")
            {
                ret = zmcaux.ZAux_Direct_SetInvertIn(_handle, Port, 1);//反转该端口为高电平有效 0——常开 1——常闭
            }
            else if (levelLogic == "低电平")
            {
                ret = zmcaux.ZAux_Direct_SetInvertIn(_handle, Port, 0);
            }
            return ret;
        }

        public override bool CloseMotionCard(out string errorMessage)//关闭运动控制卡
        {
            errorMessage = "";
            if (_handle != IntPtr.Zero)
            {
                StartCheck = false;
                Thread.Sleep(50);
                ReadTimer.Dispose();
                if (zmcaux.ZAux_Close(_handle) != 0)
                {
                    return false;
                }
            }
            return true;
        }

        protected override void ReadIOAxisState(object state)//读取IO信号 轴状态  如果当控制器异常时怎么处理
        {
            int value = 0;
            if (StartCheck)
            {
                for (int i = 0; i < AxisStateList.Count; i++)
                {
                    int axisID = AxisStateList[i].AxisID;
                    string axisName = McDataClass.AxisConfigList.Find(c => c.AxisID == axisID).AxisName;
                    int port = McDataClass.LimitConfigList.Find(c => c.AxisName == axisName).ORGPort;
                    if (ExecuteCommand("?AXISSTATUS(" + axisID + ")", out string retValue))//执行成功
                    {
                        value = Convert.ToInt32(retValue);//读取轴的状态
                        AxisStateList[i].PEl = GetBitValue(value, 4);
                        AxisStateList[i].MEL = GetBitValue(value, 5);
                        AxisStateList[i].SoftPEL = GetBitValue(value, 9);
                        AxisStateList[i].SoftMEL = GetBitValue(value, 10);
                        AxisStateList[i].Alarm = GetBitValue(value, 22);
                        if (ReadDI(port, out bool orgState, out string error))
                        {
                            AxisStateList[i].ORG = orgState;
                        }
                    }
                    if (ExecuteCommand("?MPOS(" + axisID + ")", out string position))
                    {
                        AxisStateList[i].AxisPosition = Convert.ToSingle(position);
                    }
                    if (ExecuteCommand("?IDLE(" + axisID + ")", out string retState))
                    {
                        if (Convert.ToInt32(retState) == -1)//-1表示轴运动完成
                        {
                            AxisStateList[i].MotionFinsh = true;
                        }
                        else
                        {
                            AxisStateList[i].MotionFinsh = false;
                        }
                    }
                }
            }
        }

        private static bool GetBitValue(int value, int index)
        {
            var val = 1 << index;
            return (value & val) == val;
        }

        private bool ExecuteCommand(string command, out string value)//执行命令
        {
            int ret = -1;
            value = "";
            byte[] psResponse = new byte[125];
            uint uiResponseLength = 1024;
            if (_handle != IntPtr.Zero)
            {
                ret = zmcaux.ZAux_Execute(_handle, command, psResponse, uiResponseLength);//执行命令并应答
                if (psResponse[0] != '\0')
                {
                    value = System.Text.Encoding.ASCII.GetString(psResponse).Replace("\0", "").Replace("\n", "");
                }
            }
            if (ret != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override bool JOG(int axisID, float speed, float acc, float dec, JOGMotionDir dir, out string error)
        {
            error = "";
            if (zmcaux.ZAux_Direct_SetLspeed(_handle, axisID, speed / 10) != 0)
            {
                error = "设置起始速度异常！";
                return false;
            }
            if (zmcaux.ZAux_Direct_SetSpeed(_handle, axisID, speed) != 0)
            {
                error = "设置速度异常！";
                return false;
            }
            if (zmcaux.ZAux_Direct_SetAccel(_handle, axisID, acc) != 0)
            {
                error = "设置加速度异常！";
                return false;
            }
            if (zmcaux.ZAux_Direct_SetDecel(_handle, axisID, acc) != 0)
            {
                error = "设置减速度异常！";
                return false;
            }
            if (zmcaux.ZAux_Direct_SetSramp(_handle, axisID, 0) != 0)//如果设置为0 则使用减速度的值
            {
                error = "设置S曲线时间异常！";
                return false;
            }
            if (zmcaux.ZAux_Direct_Singl_Vmove(_handle, axisID, (int)dir) != 0)
            {
                error = "启动连续运动异常！";
                return false;
            }
            return true;
        }

        public override bool PTP(int axisID, float speed, float acc, float dec, MotionMode motionMode, float position, out string error)
        {
            error = "";
            if (zmcaux.ZAux_Direct_SetLspeed(_handle, axisID, speed / 10) != 0)
            {
                error = "设置起始速度异常！";
                return false;
            }
            if (zmcaux.ZAux_Direct_SetSpeed(_handle, axisID, speed) != 0)
            {
                error = "设置速度异常！";
                return false;
            }
            if (zmcaux.ZAux_Direct_SetAccel(_handle, axisID, acc) != 0)
            {
                error = "设置加速度异常！";
                return false;
            }
            if (zmcaux.ZAux_Direct_SetDecel(_handle, axisID, acc) != 0)
            {
                error = "设置减速度异常！";
                return false;
            }
            if (zmcaux.ZAux_Direct_SetSramp(_handle, axisID, 0) != 0)//如果设置为0 则使用减速度的值
            {
                error = "设置S曲线时间异常！";
                return false;
            }
            if (motionMode == MotionMode.Absolute)//绝对运动
            {
                if (zmcaux.ZAux_Direct_Singl_MoveAbs(_handle, axisID, position) != 0)
                {
                    error = "启动点位运动异常！";
                    return false;
                }
            }
            else//相对运动
            {
                if (zmcaux.ZAux_Direct_Singl_Move(_handle, axisID, position) != 0)
                {
                    error = "启动点位运动异常！";
                    return false;
                }
            }
            return true;
        }

        public override bool StopMotion(int axisID, out string error)
        {
            error = "";
            if (zmcaux.ZAux_Direct_Singl_Cancel(_handle, axisID, 2) != 0)
            {
                error = "取消轴运动异常!";
                return false;
            }
            return true;
        }

        public override bool Home(out string error)
        {
            error = "";
            AxisIndexList1.Clear();
            AxisIndexList2.Clear();
            AxisIndexList3.Clear();
            AxisIndexList4.Clear();
            AxisIndexList5.Clear();
            for (int i = 0; i < McDataClass.AxisConfigList.Count; i++)
            {
                switch (McDataClass.AxisConfigList[i].ResetOrder)
                {
                    case 1:
                        AxisIndexList1.Add(i);
                        break;
                    case 2:
                        AxisIndexList2.Add(i);
                        break;
                    case 3:
                        AxisIndexList3.Add(i);
                        break;
                    case 4:
                        AxisIndexList4.Add(i);
                        break;
                    case 5:
                        AxisIndexList5.Add(i);
                        break;
                }
            }
            List<int> intList = null; ;
            for (int i = 1; i <= 5; i++)
            {
                switch (i)
                {
                    case 1:
                        intList = AxisIndexList1;//重新指向地址
                        break;
                    case 2:
                        intList = AxisIndexList2;
                        break;
                    case 3:
                        intList = AxisIndexList3;
                        break;
                    case 4:
                        intList = AxisIndexList4;
                        break;
                    case 5:
                        intList = AxisIndexList5;
                        break;
                }
                if (intList != null && intList.Count > 0)
                {
                    int index;
                    for (int j = 0; j < intList.Count; j++)
                    {
                        index = intList[j];
                        if (SetHomeParam(index) == false)
                        {
                            error = "设置回零参数异常！";
                            return false;
                        }
                    }
                    while (true)
                    {
                        bool allFinsh = true;
                        Application.DoEvents();
                        for (int t = 0; t < intList.Count; t++)
                        {
                            allFinsh = AxisStateList[t].MotionFinsh && allFinsh;
                        }
                        if (allFinsh == true)
                        {
                            break;
                        }
                    }
                }
            }
            return true;
        }

        private bool SetHomeParam(int index)//设置回零参数
        {
            int axisID = McDataClass.AxisConfigList[index].AxisID;
            float speed = McDataClass.AxisConfigList[index].ResetSpeed;
            float againSpeed = McDataClass.AxisConfigList[index].AgainResetSpeed;
            float acc = McDataClass.AxisConfigList[index].AccDec;
            int mode = McDataClass.AxisConfigList[index].ResetDir == "正方向" ? 3 : 4;
            if (zmcaux.ZAux_Direct_SetLspeed(_handle, axisID, speed / 10) != 0)
            {
                return false;
            }
            if (zmcaux.ZAux_Direct_SetSpeed(_handle, axisID, speed) != 0)
            {
                return false;
            }
            if (zmcaux.ZAux_Direct_SetAccel(_handle, axisID, acc) != 0)
            {
                return false;
            }
            if (zmcaux.ZAux_Direct_SetDecel(_handle, axisID, acc) != 0)
            {
                return false;
            }
            if (zmcaux.ZAux_Direct_SetCreep(_handle, axisID, againSpeed) != 0)
            {
                return false;
            }
            if (zmcaux.ZAux_Direct_Singl_Datum(_handle, axisID, mode) != 0)
            {
                return false;
            }
            Thread.Sleep(1000);
            return true;
        }

        public override bool ReadDI(int index, out bool state, out string error)
        {
            error = null;
            state = false;
            if (ExecuteCommand("?IN(" + index + ")", out string value))
            {
                if (value == "1")
                {
                    state = true;
                }
                else
                {
                    state = false;
                }
                return true;
            }
            return false;
        }

        public override bool ReadDO(int index, out bool state, out string error)
        {
            error = null;
            state = false;
            if (ExecuteCommand("?READ_OP(" + index + ")", out string value))
            {
                if (value == "1")
                {
                    state = true;
                }
                else
                {
                    state = false;
                }
                return true;
            }
            return false;
        }

        public override bool SetDO(int index, OutStateEnum state, out string error)//设置完输出后
        {
            error = "";
            uint pivalue = 0;
            for (int i = 0; i < 2; i++)
            {
                if (zmcaux.ZAux_Direct_SetOp(_handle, index, (uint)state) != 0)
                {
                    error = "设置端口[" + index.ToString() + "]异常！";
                    return false;
                }
                Thread.Sleep(2);
                if (zmcaux.ZAux_Direct_GetOp(_handle, index, ref pivalue) != 0)
                {
                    error = "读取端口[" + index.ToString() + "]异常！";
                    return false;
                }
                if ((uint)state == pivalue)
                {
                    return true;
                }
            }
            return false;
        }

        public override bool ReadAD(int index, out string value)
        {
            if (ExecuteCommand("?AIN(" + index + ")", out string retValue))
            {
                value = retValue;
                return true;
            }
            value = "";
            return false;
        }

        public override bool SetSoftLimit(int axisID, bool PELEnable, float PELValue, bool MELEnable, float MELValue)
        {
            if(!PELEnable)
            {
                PELValue = float.MaxValue;
            }
            if(!MELEnable)
            {
                MELValue = float.MinValue;
            }
            if(PELValue > MELValue)
            {
                if (zmcaux.ZAux_Direct_SetFsLimit(_handle, axisID, PELValue) ==0 && zmcaux.ZAux_Direct_SetRsLimit (_handle, axisID, MELValue) == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
