using DispenseAPP.AboutMotionCard.ConfigCardClass;
using System.Collections.Generic;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DispenseAPP.AboutData
{
    [Serializable]
    public class MCDataClass:ICloneable //运动控制卡配置相关的数据  每一个运动控制卡都会包含这些属性
    {
        public string Name { get; set; }
        public ushort HomeOrder { get; set; }

        public List<ConfigAxis> AxisConfigList = new List<ConfigAxis>();//轴参数

        public List<ConfigLimit> LimitConfigList = new List<ConfigLimit>();//限位参数

        public IConfigCardable CardConfig;//卡参数

        public List<ConfigDI> DIConfigList = new List<ConfigDI>();//输入信号配置List

        public List<ConfigDO> DOConfigList = new List<ConfigDO>();//输出信号配置List

        public object Clone()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Position = 0;
            return formatter.Deserialize(stream) as MCDataClass;
        }
    }

    [Serializable]
    public class ConfigAxis:ICloneable
    {
        public short AxisID { get; set; } = 0;//轴号

        public string AxisName { get; set; } = "";//轴名称

        public int Pitch { get; set; } = 10;//螺距

        public int Pulse { get; set; } = 10000;//电机转每圈发送的脉冲数

        public float AccDec { get; set; } = 1000f;//加减速

        public float ResetSpeed { get; set; } = 30f;//复位速度

        public string ResetDir { get; set; } = "正方向";//复位方向

        public int ResetOrder { get; set; } = 1;//复位顺序

        public float AgainResetSpeed { get; set; } = 5f;//再次复位速度

        public string PosIcon { get; set; } = "";//正方向图标

        public string NegIcon { get; set; } = "";//负方向图标

        public bool SoftPEL { get; set; } = false;//正软限位

        public bool SoftMEL { get; set; } = false;//负软限位

        public float SoftPELValue { get; set; } = 0;//正软限位值

        public float SoftMELValue { get; set; } = 0;//负软限位值

        public object Clone()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Position = 0;
            return formatter.Deserialize(stream) as ConfigAxis;
        }
    }

    [Serializable]
    public class ConfigLimit:ICloneable
    {
        public string AxisName { get; set; } = "";//轴名称

        public int PELPort { get; set; } = 1;//正限位端口

        public int ORGPort { get; set; } = 1;//原点端口

        public int MELPort { get; set; } = 1;//负限位端口

        public int AlarmPort { get; set; } = 1;//报警端口

        public string PELLevel { get; set; } = "高电平";//正限位电平

        public string ORGLevel { get; set; } = "高电平";//原点电平

        public string MELLevel { get; set; } = "高电平";//负限位电平

        public string AlarmLevel { get; set; } = "高电平";//报警电平

        public object Clone()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Position = 0;
            return formatter.Deserialize(stream) as ConfigLimit;
        }
    }

    [Serializable]
    public class ConfigDI:ICloneable
    {
        public string Name { get; set; }//名称

        public int Port { get; set; }//端口

        public string Mode { get; set; }//模式（常开和常闭）

        public object Clone()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Position = 0;
            return formatter.Deserialize(stream) as ConfigDI;
        }
    }

    [Serializable]
    public class ConfigDO:ICloneable
    {
        public string Name { get; set; }//名称

        public int Port { get; set; }//端口

        public string Mode { get; set; }//模式（常开和常闭）

        public object Clone()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Position = 0;
            return formatter.Deserialize(stream) as ConfigDO;
        }
    }

    [Serializable]
    public class DispensePath : ICloneable
    {
        public string Command { get; set; } = "";//命令 

        public string Speed { get; set; }//速度

        public string Other { get; set; }//其它

        public string[] Position { get; set; }//位置

        public string Param { get; set; }//参数

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
