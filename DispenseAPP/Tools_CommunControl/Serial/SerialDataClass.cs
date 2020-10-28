using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP.AboutData
{
    [Serializable]
    public class SerialDataClass:ICloneable//串口通讯数据
    {
        public string PortName { get; set; }//端口名称

        public bool State { get; set; } = false;//状态

        public int BaudRate { get; set; } = 9600;//波特率

        public string HandShakeControl { get; set; } = "None";//握手协议控制

        public string StopBits { get; set; } = "1";//停止位 

        public string Parity { get; set; } = "None";//奇偶校验

        public int DataBits { get; set; } = 8;//数据位

        public object Clone()//微软提供的浅复制  该类中都是值类型 所以浅复制就可以了
        {
            return MemberwiseClone();
        }
    }
}
