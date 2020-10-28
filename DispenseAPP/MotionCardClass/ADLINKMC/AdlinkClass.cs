using DispenseAPP.AboutData;
using DispenseAPP.接口;
using System;
using System.Threading;
using APS168_W32;
using DispenseAPP.AboutMotionCard.ConfigCardClass.GTS;
using System.IO;

namespace DispenseAPP.MotionCardClass.ADLINK
{
    public class AdlinkClass : IMotionCard
    {
        private int CardID { get; set; }
        public AdlinkClass(MCDataClass mcDataClass) : base(mcDataClass)
        {
            ReadTimer = new Timer(new TimerCallback(ReadIOAxisState), null, 0, 200);
        }

        public override bool InitialMotionCard(out string errorMessage)
        {
            errorMessage = "";
            if (McDataClass.CardConfig is ConfigFileIDClass configFileIDClass)
            {
                CardID = configFileIDClass.CardID;
                if(configFileIDClass.ConfigFilePath == "")
                {
                    errorMessage = "[卡." + McDataClass.Name + "]未配置,请先配置！";
                    return false;
                }
                int boardID = 0;
                //如果存在多张卡，这个位置可能会返回【卡已经初始化】的错误！
                if (APS168.APS_initial(ref boardID, 1) != 0)//参数1：卡ID信息 参数2：模式 0:系统分配 1：按拨码开关 
                {
                    errorMessage = "初始化[卡." + McDataClass.Name + "]失败！";
                    return false;
                }
                if (File.Exists(configFileIDClass.ConfigFilePath) == true)
                {
                    if (APS168.APS_load_param_from_file(configFileIDClass.ConfigFilePath) != 0)
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
                for (int i = 0; i < McDataClass.AxisConfigList.Count; i++)
                {
                    short axisID = McDataClass.AxisConfigList[i].AxisID;
                    string axisName = McDataClass.AxisConfigList[i].AxisName;
                    if(APS168.APS_set_servo_on(axisID,1)!=0)//开启使能
                    {
                        errorMessage = "[卡." + McDataClass.Name + "][轴." + axisName + "]设置使能失败！";
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public override bool CloseMotionCard(out string errorMessage)//关闭
        {
            errorMessage = "";
            if (APS168.APS_close()!=0)
            {
                return false;
            }
            return true;
        }

        protected override void ReadIOAxisState(object data)
        {

        }



        public override bool Home(out string error)
        {
            throw new NotImplementedException();
        }



        public override bool JOG(int axisID, float speed, float acc, float dec, CommonClass.JOGMotionDir dir, out string error)
        {
            throw new NotImplementedException();
        }

        public override bool PTP(int axisID, float speed, float acc, float dec, CommonClass.MotionMode motionMode, float position, out string error)
        {
            throw new NotImplementedException();
        }

        public override bool StopMotion(int axisID, out string error)
        {
            throw new NotImplementedException();
        }

        public override bool SetDO(int index, CommonClass.OutStateEnum state, out string error)
        {
            throw new NotImplementedException();
        }

        public override bool ReadAD(int index, out string value)
        {
            throw new NotImplementedException();
        }

        public override bool ReadDI(int index, out bool state, out string error)
        {
            throw new NotImplementedException();
        }

        public override bool ReadDO(int index, out bool state, out string error)
        {
            throw new NotImplementedException();
        }

        public override bool SetSoftLimit(int axisID, bool PELEnable, float PELValue, bool MELEnable, float MELValue)
        {
            throw new NotImplementedException();
        }
    }
}
