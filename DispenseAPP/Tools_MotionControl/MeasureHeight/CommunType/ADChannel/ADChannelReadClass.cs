using static DispenseAPP.CommonClass;
using System.Collections.Generic;
using System;
using System.Linq;

namespace DispenseAPP.Tools_MotionControl.MeasureHeight.Commun.ADChannel
{
    public class ADChannelReadClass : GetHeightValueClass
    {
        public override bool ReadHeightValue(out float value)//读取高度值
        {
            value = 0;
            if (MotionCardDict.ContainsKey(SelectCard) && MotionCardDict[SelectCard].CardConnectState)
            {
                List<float> heightList = new List<float>();
                for (int i = 0; i < ReadTimes; i++)//读取次数
                {
                    if (MotionCardDict[SelectCard].ReadAD(Channel, out string retValue))
                    {
                        heightList.Add(Convert.ToSingle(retValue));
                    }
                    else
                    {
                        return false;
                    }
                }
                heightList.Remove(heightList.Max());
                heightList.Remove(heightList.Min());//去掉一个最大值和最小值
                value = heightList.Average();//返回平均值
            }
            else
            {
                return false;
            }
            return true;
        }

        public string SelectCard { get; set; } = "";

        public ushort Channel { get; set; } = 0;//通道

        public ushort ReadTimes { get; set; } = 1;//读取次数

        public bool UseLimitVoltage { get; set; } = false;//限制电压

        public float LowVoltage { get; set; } = 0f;//低电压

        public float HeightVoltage { get; set; } = 1f;//高电压
    }
}
