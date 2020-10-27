using DispenseAPP.接口;
using gts;
using System;
using static DispenseAPP.CommonClass;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using DispenseAPP.AboutData;
using DispenseAPP.AboutMotionCard.ConfigCardClass.GTS;

namespace DispenseAPP
{
    public class GTSClass : IMotionCard
    {
        Dictionary<short, double> UnitDic = new Dictionary<short, double>();//轴号和脉冲当量的键值对集合

        private short CardNum { get; set; }

        public GTSClass(MCDataClass motionCardDataClass) : base(motionCardDataClass)
        {
            ReadTimer = new Timer(new TimerCallback(ReadIOAxisState), null, 0, 100);
        }

        public override bool InitialMotionCard(out string errorMessage)//初始化
        {
            errorMessage = null;
            if (McDataClass.CardConfig is ConfigFileIDClass gtsConfigClass)
            {
                CardNum = gtsConfigClass.CardID;
                if (gtsConfigClass.ConfigFilePath == "")
                {
                    errorMessage = "[卡." + McDataClass.Name + "]未配置,请先配置！";
                    return false;
                }
                if (mc.GT_Open(CardNum, 0, 1) != 0)
                {
                    errorMessage = "打开[卡." + McDataClass.Name + "]失败！";
                    return false;
                }
                if (mc.GT_Reset(CardNum) != 0)
                {
                    errorMessage = "复位[卡." + McDataClass.Name + "]失败！";
                    return false;
                }
                if (File.Exists(gtsConfigClass.ConfigFilePath) == true)
                {
                    if (mc.GT_LoadConfig(CardNum, gtsConfigClass.ConfigFilePath) != 0)
                    {
                        errorMessage = "加载[卡." + McDataClass.Name + "]配置文件失败！";
                        return false;
                    }
                }
                else
                {
                    errorMessage = "[卡." + McDataClass.Name + "]配置文件不存在,请检查！";
                    return false;
                }
                if (mc.GT_ClrSts(CardNum, 1, 8) != 0)//最多支持8轴 
                {
                    errorMessage = "[卡." + McDataClass.Name + "]清除各轴状态失败！";
                    return false;
                }
                for (int i = 0; i < McDataClass.AxisConfigList.Count; i++)
                {
                    short axisID = McDataClass.AxisConfigList[i].AxisID;
                    string axisName = McDataClass.AxisConfigList[i].AxisName;
                    if (mc.GT_GetSts(CardNum, (short)(axisID + 1), out int pSts, 1, out uint pClock) != 0)//读取轴状态
                    {
                        errorMessage = "读取[卡." + McDataClass.Name + "][轴." + axisName + "]轴状态失败！";
                        return false;
                    }
                    else
                    {
                        if (((pSts >> 8) & 1) == 1)//IO急停触发标志  ???是否需要读取
                        {
                            errorMessage = "[卡." + McDataClass.Name + "][轴." + axisName + "]急停信号触发！";
                            return false;
                        }
                        if (((pSts >> 1) & 1) == 1)//驱动器报警标志
                        {
                            errorMessage = "[卡." + McDataClass.Name + "][轴." + axisName + "]报警信号触发！";
                            return false;
                        }
                        if (mc.GT_AxisOn(CardNum, (short)(axisID + 1)) != 0)
                        {
                            errorMessage = "[卡." + McDataClass.Name + "][轴." + axisName + "]打开使能失败！";
                            return false;
                        }
                        if (mc.GT_SetAxisBand(CardNum, (short)(axisID + 1), 20, 5) != 0)//设置轴到位误差带
                        {
                            errorMessage = "设置到位误差带失败！";
                            return false;
                        }
                        UnitDic.Add(axisID, McDataClass.AxisConfigList[i].Pulse / McDataClass.AxisConfigList[i].Pitch);//设置单位距离（mm）发送的脉冲数
                    }
                }
                return true;
            }
            return false;
        }

        public override bool CloseMotionCard(out string errorMessage)//关闭运动控制卡
        {
            errorMessage = null;
            for (int i = 0; i < McDataClass.AxisConfigList.Count; i++)
            {
                short axisID = McDataClass.AxisConfigList[i].AxisID;
                string axisName = McDataClass.AxisConfigList[i].AxisName;
                if (mc.GT_AxisOff(CardNum, (short)(axisID + 1)) != 0)
                {
                    errorMessage = "[卡." + McDataClass.Name + "][轴." + axisName + "]关闭使能失败！";
                }
            }
            if (mc.GT_Close(CardNum) != 0)
            {
                return false;
            }
            return true;
        }

        protected override void ReadIOAxisState(object data)
        {
            if (StartCheck)
            {
                for (int i = 0; i < AxisStateList.Count; i++)
                {
                    int axisID = AxisStateList[i].AxisID;
                    string axisName = McDataClass.AxisConfigList.Find(c => c.AxisID == axisID).AxisName;
                    if (mc.GT_GetSts(CardNum, (short)(axisID + 1), out int pSts, 1, out uint pClock) == 0)//读取轴状态成功
                    {
                        if (((pSts >> 1) & 1) == 1) { AxisStateList[i].Alarm = true; } else { AxisStateList[i].Alarm = false; }
                        if (((pSts >> 5) & 1) == 1) { AxisStateList[i].PEl = true; } else { AxisStateList[i].PEl = false; }
                        if (((pSts >> 6) & 1) == 1) { AxisStateList[i].MEL = true; } else { AxisStateList[i].MEL = false; }
                        if (((pSts >> 11) & 1) == 1) { AxisStateList[i].MotionFinsh = true; } else { AxisStateList[i].MotionFinsh = false; }//点击到位标志
                    }
                    if (mc.GT_GetDi(CardNum, mc.MC_HOME, out int pValue) == 0)
                    {
                        if (((pValue >> axisID) & 1) == 1) { AxisStateList[i].ORG = true; }
                        else { AxisStateList[i].ORG = false; }
                    }
                    if (mc.GT_GetEncPos(CardNum, (short)(axisID + 1), out double position, 1, out pClock) == 0)
                    {
                        AxisStateList[i].AxisPosition = Convert.ToSingle(position / UnitDic[(short)axisID]);
                    }
                }
            }
        }

        public override bool ReadDI(int index, out bool state, out string error)
        {
            error = null;
            state = false;
            if (mc.GT_GetDi(CardNum, mc.MC_GPI, out int pValue) != 0)//读取通用输入信号
            {
                error = "读取端口[" + (index + 1).ToString() + "]异常！";
                return false;
            }
            if (pValue == 1)//高电平
            {
                state = true;
            }
            else
            {
                state = false;
            }
            return true;
        }

        public override bool ReadDO(int index, out bool state, out string error)
        {
            error = null;
            state = false;
            if (mc.GT_GetDo(CardNum, mc.MC_GPO, out int pValue) != 0)//读取通用输出信号
            {
                error = "读取端口[" + (index + 1).ToString() + "]异常！";
                return false;
            }
            if (pValue == 1)//高电平
            {
                state = true;
            }
            else
            {
                state = false;
            }
            return true;
        }

        public override bool SetDO(int index, OutStateEnum state, out string error)
        {
            error = null;
            for (int i = 0; i < 2; i++)//循环10次
            {
                if (mc.GT_SetDoBit(CardNum, mc.MC_GPO, (short)(index + 1), (short)state) != 0)
                {
                    error = "设置端口[" + (index + 1).ToString() + "]异常！";
                    return false;
                }
                Thread.Sleep(2);
                if (mc.GT_GetDo(CardNum, mc.MC_GPO, out int pValue) != 0)
                {
                    error = "读取端口[" + (index + 1).ToString() + "]异常！";
                    return false;
                }
                if (pValue == (int)state)
                {
                    return true;
                }
            }
            return false;
        }

        public override bool ReadAD(int index, out string value)//通道从0开始计算
        {
            if (mc.GT_GetAdc(CardNum, (short)(index + 1), out double pValue, 1, out uint pLock) == 0)
            {
                value = pValue.ToString();
                return true;
            }
            value = null;
            return false;
        }

        public override bool StopMotion(int axisID, out string error)
        {
            error = null;
            if (mc.GT_Stop(CardNum, 1 << (axisID), 1 << (axisID)) != 0)
            {
                error = "急停指定轴失败！";
                return false;
            }
            return true;
        }

        public override bool JOG(int axisID, float speed, float acc, float dec, JOGMotionDir dir, out string error)
        {
            error = null;
            short _axisID = (short)(axisID + 1);

            if (mc.GT_ClrSts(CardNum, _axisID, 8) != 0)
            {
                error = "清除轴状态失败！";
                return false;
            }
            if (mc.GT_PrfJog(CardNum, _axisID) != 0)
            {
                error = "设置轴为JOG运动模式失败！";
                return false;
            }
            mc.TJogPrm _JOGPrm;
            _JOGPrm.acc = acc; //加速度 单位:pulse/ms²
            _JOGPrm.dec = dec; //减速度 单位:pulse/ms²  这里需要统一换算为mm/s²
            _JOGPrm.smooth = 0.9;//平滑系数 取值范围：[0,1) 平滑系数的数值越大，加速度越平稳  
            if (mc.GT_SetJogPrm(CardNum, _axisID, ref _JOGPrm) != 0)
            {
                error = "设置JOG运动模式运动参数失败！";
                return false;
            }
            if (dir == JOGMotionDir.Negative)
            {
                speed *= -1;
            }
            if (mc.GT_SetVel(CardNum, _axisID, speed * UnitDic[(short)axisID] / 1000d) != 0)//单位：pulse/ms
            {
                error = "设置JOG运动模式目标速度失败！";
                return false;
            }
            if (mc.GT_Update(CardNum, 1 << (_axisID - 1)) != 0)
            {
                error = "启动JOG运动失败！";
                return false;
            }
            return true;
        }

        public override bool PTP(int axisID, float speed, float acc, float dec, MotionMode motionMode, float position, out string error)
        {
            error = null;
            short _axisID = (short)(axisID + 1);
            if (mc.GT_ClrSts(CardNum, _axisID, 8) != 0)
            {
                error = "清除轴状态失败！";
                return false;
            }
            if (mc.GT_PrfTrap(CardNum, _axisID) != 0)
            {
                error = "设置轴为点位运动模式失败！";
                return false;
            }
            mc.TTrapPrm _TrapPrm;
            _TrapPrm.acc = acc;
            _TrapPrm.dec = dec;
            _TrapPrm.velStart = 0;//起跳速度。单位：pulse/ms。默认值为 0。
            _TrapPrm.smoothTime = 25;//平滑时间。取值范围：[0, 50]，单位 ms。平滑时间的数值越大，加减速过程越平稳 重点：平滑时间是指加速度的变化时间  可以理解为T型速度曲线向S型速度曲线的转换 如果为0 则表示为T型速度曲线 
            if (mc.GT_SetTrapPrm(CardNum, _axisID, ref _TrapPrm) != 0)
            {
                error = "设置点位模式运动参数失败！";
                return false;
            }
            if (mc.GT_SetVel(CardNum, _axisID, speed) != 0)
            {
                error = "设置点位运动模式目标速度失败！";
                return false;
            }
            if (motionMode == MotionMode.Absolute)
            {
                if (mc.GT_SetPos(CardNum, _axisID, Convert.ToInt32(position * UnitDic[(short)axisID])) != 0)
                {
                    error = "设置点位运动模式目标位置失败！";
                    return false;
                }
            }
            else if (motionMode == MotionMode.Relaitve)
            {
                if (mc.GT_GetPos(CardNum, _axisID, out int _currentPosition) != 0)//单位：pulse
                {
                    error = "读取点位运动模式目标位置失败！";
                    return false;
                }
                if (mc.GT_SetPos(CardNum, _axisID, _currentPosition + Convert.ToInt32(position * UnitDic[(short)axisID])) != 0)
                {
                    error = "设置点位运动模式目标位置失败！";
                    return false;
                }
            }
            if (mc.GT_Update(CardNum, 1 << (_axisID - 1)) != 0)
            {
                error = "启动点位运动失败！";
                return false;
            }
            return true;
        }

        public override bool Home(out string errorMessage)
        {
            errorMessage = null;
            Dictionary<int, List<ConfigAxis>> homeOrderList = new Dictionary<int, List<ConfigAxis>>();
            for (int i = 1; i <= 5; i++)
            {
                List<ConfigAxis> configAxisList = McDataClass.AxisConfigList.FindAll(c => c.ResetOrder == i);
                if (configAxisList != null)
                {
                    homeOrderList.Add(i, configAxisList);
                }
            }
            foreach (List<ConfigAxis> item in homeOrderList.Values)
            {
                foreach (ConfigAxis items in item)
                {
                    ExecuteSingleAxisHome(McDataClass.AxisConfigList.FindIndex(c => c == items));//每个轴的回零都使用异步编程 进行下一下级别的回零的条件是上一级别的所有轴回零全部完成
                }
            }
            return false;
        }

        private void ExecuteSingleAxisHome(int index)//执行单轴回零 在List中的索引
        {
            int stateIndex = AxisStateList.FindIndex(c => c.AxisID == McDataClass.AxisConfigList[index].AxisID);
            short axisID = McDataClass.AxisConfigList[index].AxisID;
            JOGMotionDir dir = McDataClass.AxisConfigList[index].ResetDir == "正方向" ? JOGMotionDir.Positive : JOGMotionDir.Negative;
            if ((dir == JOGMotionDir.Positive && !AxisStateList[stateIndex].PEl) || (dir == JOGMotionDir.Negative && !AxisStateList[stateIndex].MEL))
            {
                JOG(axisID, McDataClass.AxisConfigList[index].ResetSpeed, McDataClass.AxisConfigList[index].AccDec, McDataClass.AxisConfigList[index].AccDec, dir, out string error);
            }
            do
            {
                if (mc.GT_GetSts(CardNum, (short)(axisID + 1), out int pSts, 1, out uint pClock) == 0)
                {
                    if ((dir == JOGMotionDir.Positive && ((pSts >> 5) & 1) == 1) || (dir == JOGMotionDir.Negative && ((pSts >> 6) & 1) == 1))
                    {
                        mc.GT_Stop(CardNum, 1 << axisID, 0);//平滑停止
                        break;
                    }
                }
                if (mc.GT_GetDi(CardNum, mc.MC_HOME, out int pValue) == 0)
                {
                    if (((pValue >> axisID) & 1) == 1)
                    {
                        mc.GT_Stop(CardNum, 1 << axisID, 0);//平滑停止
                        break;
                    }
                }
                Thread.Sleep(2);
            } while (true);
            Thread.Sleep(200);//平滑停止后需要加延时
            if ((dir == JOGMotionDir.Positive && !AxisStateList[stateIndex].MEL) || (dir == JOGMotionDir.Negative && !AxisStateList[stateIndex].PEl))
            {
                JOGMotionDir dirDir = McDataClass.AxisConfigList[index].ResetDir == "负方向" ? JOGMotionDir.Positive : JOGMotionDir.Negative;
                JOG(axisID, McDataClass.AxisConfigList[index].ResetSpeed, McDataClass.AxisConfigList[index].AccDec, McDataClass.AxisConfigList[index].AccDec, dirDir, out string error);
            }
            do//这里需要加一个判断 当回零方向为正方向 但是却碰到了负限位 或者 回零方向为负方向 但是碰到了正限位 这种情况下是需要报错的
            {
                if (mc.GT_GetDi(CardNum, mc.MC_HOME, out int pValue) == 0)
                {
                    if (((pValue >> axisID) & 1) == 1)
                    {
                        break;
                    }
                }
                Thread.Sleep(2);
            } while (true);//碰到原点开关
            do
            {
                if (mc.GT_GetDi(CardNum, mc.MC_HOME, out int pValue) == 0)
                {
                    if (((pValue >> axisID) & 1) == 0)
                    {
                        break;
                    }
                }
                Thread.Sleep(2);
            } while (true);//碰不到原点开关
            mc.GT_Stop(CardNum, 1 << axisID, 0);//平滑停止
            Thread.Sleep(200);
            mc.GT_SetCaptureMode(CardNum, (short)(axisID + 1), mc.CAPTURE_HOME);
            if ((dir == JOGMotionDir.Positive && !AxisStateList[stateIndex].PEl) || (dir == JOGMotionDir.Negative && !AxisStateList[stateIndex].MEL))
            {
                JOG(axisID, McDataClass.AxisConfigList[index].AgainResetSpeed, McDataClass.AxisConfigList[index].AccDec, McDataClass.AxisConfigList[index].AccDec, dir, out string error);
            }
            do
            {
                mc.GT_GetCaptureStatus(CardNum, (short)(axisID + 1), out short pStatus, out int pValue, 1, out uint pClock);
                if (pStatus == 1)
                {
                    mc.GT_Stop(CardNum, 1 << axisID, 0);//平滑停止
                    break;
                }
            } while (true);
            Thread.Sleep(200);
            mc.GT_ClrSts(CardNum, (short)(axisID + 1), 1);//清除报警
            mc.GT_PrfTrap(CardNum, (short)(axisID + 1));//设置轴为Trap模式
            mc.TTrapPrm _TrapPrm;
            _TrapPrm.acc = McDataClass.AxisConfigList[index].AccDec; //单位：pulse/ms²
            _TrapPrm.dec = McDataClass.AxisConfigList[index].AccDec; //单位：pulse/ms²
            _TrapPrm.velStart = 0;//起跳速度。单位：pulse/ms。默认值为 0。
            _TrapPrm.smoothTime = 25;//平滑时间。取值范围：[0, 50]，单位 ms。平滑时间的数值越大，加减速过程越平稳
            mc.GT_SetTrapPrm(CardNum, (short)(axisID + 1), ref _TrapPrm);
            mc.GT_SetVel(CardNum, (short)(axisID + 1), McDataClass.AxisConfigList[index].AgainResetSpeed); //单位：pulse/ms
            mc.GT_SetPos(CardNum, (short)(axisID + 1), 0);
        }

        public override bool SetSoftLimit(int axisID, bool PELEnable, float PELValue, bool MELEnable, float MELValue)
        {
            int positive, negitive;
            if (!PELEnable)
            {
                positive = int.MaxValue;
            }
            else
            {
                positive = Convert.ToInt32(PELValue * UnitDic[(short)axisID]);
            }
            if (!MELEnable)
            {
                negitive = int.MinValue;
            }
            else
            {
                negitive = Convert.ToInt32(MELValue * UnitDic[(short)axisID]);
            }
            if (positive > negitive)
            {
                if (mc.GT_SetSoftLimit(CardNum, (short)(axisID + 1), positive, negitive) == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
