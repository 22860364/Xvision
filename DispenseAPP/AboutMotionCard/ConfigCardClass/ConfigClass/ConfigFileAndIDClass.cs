using System;

namespace DispenseAPP.AboutMotionCard.ConfigCardClass.GTS
{
    [Serializable]
    public class ConfigFileIDClass:IConfigCardable
    {
        public string ConfigFilePath { get; set; } = "";//配置文件路径

        public short CardID { get; set; }//卡号
    }
}
