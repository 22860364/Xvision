using csLTDMC;
using DispenseAPP.AboutData;
using DispenseAPP.AboutMotionCard.ConfigCardClass.GTS;
using DispenseAPP.接口;
using System;
using System.IO;
using System.Threading;

namespace DispenseAPP.MotionCardClass.DMC
{
    public class DMCClass : IMotionCard
    {
        private ushort CardID { get; set; }

        public DMCClass(MCDataClass mcDataClass) : base(mcDataClass)
        {
            ReadTimer = new Timer(new TimerCallback(ReadIOAxisState), null, 0, 200);
        }

        public override bool InitialMotionCard(out string errorMessage)
        {
            errorMessage = "";
            if (McDataClass.CardConfig is ConfigFileIDClass configFileIDClass)
            {
                if (configFileIDClass.ConfigFilePath == "")
                {
                    errorMessage = "[卡." + McDataClass.Name + "]未配置,请先配置！";
                    return false;
                }
                if (LTDMC.dmc_board_init() <= 0)//初始化控制卡 分配资源
                {
                    errorMessage = "[卡." + McDataClass.Name + "]初始化失败！";
                    return false;
                }
                ushort cardNum = 0;
                uint[] cardTypeList = new uint[8];
                ushort[] cardIDList = new ushort[8];//获得的卡号从小到大排序
                if(LTDMC.dmc_get_CardInfList(ref cardNum, cardTypeList,cardIDList) != 0)
                {
                    errorMessage = "[卡." + McDataClass.Name + "]获取卡ID失败！";
                    return false;
                }
                if (File.Exists(configFileIDClass.ConfigFilePath) == true)
                {
                    if (LTDMC.dmc_download_configfile(CardID, configFileIDClass.ConfigFilePath) != 0)
                    {
                        errorMessage = "[卡." + McDataClass.Name + "]加载配置文件失败！";
                        return false;
                    }
                }
                else
                {
                    errorMessage = "[卡." + McDataClass.Name + "]配置文件不存在,请检查！";
                    return false;
                }
                return true;
            }
            return false;
        }

        public override bool CloseMotionCard(out string errorMessage)//关闭卡
        {
            errorMessage = "";
            if(LTDMC.dmc_board_close_onecard(CardID) != 0)//关闭单卡
            {
                errorMessage = "[卡." + McDataClass.Name + "]关闭失败！";
                return false;
            }
            return true;
        }

        public override bool Home(out string errorMessage)
        {
            throw new NotImplementedException();
        }

        public override bool JOG(int axisID, float speed, float acc, float dec, CommonClass.JOGMotionDir dir, out string errorMessage)
        {
            throw new NotImplementedException();
        }

        public override bool PTP(int axisID, float speed, float acc, float dec, CommonClass.MotionMode motionMode, float position, out string errorMessage)
        {
            throw new NotImplementedException();
        }

        public override bool StopMotion(int axisID, out string errorMessage)
        {
            throw new NotImplementedException();
        }

        protected override void ReadIOAxisState(object data)
        {

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
