using System.Text;
using static DispenseAPP.CommonClass;
using System.IO.Ports;

namespace DispenseAPP.Tools_CommunControl.Serial
{
    public class SerialClass : ITools
    {
        #region 基本

        public string Connect { get; set; } = "";//连接

        public bool SetTimeOut { get; set; } = false;//启用超时限制

        public int TimeOutNum { get; set; } = 5000;//超时时间

        public bool ClearBuffer { get; set; } = false;//清空缓存
        #endregion

        #region 数据
        [Reference(true)]
        public string DataString { get; set; } = "";

        public bool IsSend { get; set; } = false;//是否是发送数据

        public string SendText { get; set; }//发送的文本
        #endregion

        #region 格式
        public string Format { get; set; } = "字符串";//格式

        public string ByteOrder { get; set; } = "低字节序";//字节顺序

        public string LineFeedMode { get; set; } = "Windows";//换行模式

        public string String_CharEncoding { get; set; } = "ASCII";//字符编码

        public int NumericalWidth { get; set; } = 0;//数值宽度

        public int NumericalPrecision { get; set; } = 0;//数值精度

        public string NumType { get; set; } = "Int16";//数据类型

        public string Boolean_True { get; set; } = "TRUE";

        public string Boolean_False { get; set; } = "FALSE";
        #endregion

        public override void Execute(UC_Image imageWindow)
        {
            if(SerialDict.ContainsKey(Connect))//首先判断连接是否存在
            {
                if(SerialDict[Connect].IsOpen)//需要判断串口是否有打开
                {                
                    if (IsSend)//发送数据
                    {
                        if (SetTimeOut)
                        {

                        }
                        if(ClearBuffer)//写入数据前清除缓存区
                        {
                            SerialDict[Connect].DiscardOutBuffer();//丢弃传输缓存区的数据
                        }
                        byte[] sendBuffer = null;
                        if (String_CharEncoding == "ASCII")
                        {
                            sendBuffer = Encoding.ASCII.GetBytes(SendText);
                        }
                        else 
                        {
                            sendBuffer = Encoding.UTF8.GetBytes(SendText);
                        }
                        SerialDict[Connect].Write(sendBuffer, 0, sendBuffer.Length);
                    }
                    else
                    {
                        SerialDict[Connect].DataReceived += SerialClass_DataReceived;
                        if (SetTimeOut)
                        {

                        }
                        if (ClearBuffer)
                        {
                            SerialDict[Connect].DiscardInBuffer();//丢弃接受缓存区的数据
                        }
                        if (String_CharEncoding == "ASCII")
                        {

                        }
                        else
                        {
                        }
                    }
                }
                else
                {
                    ExecuteState = ExecuteStateEnum.NG;
                    StepState = false;
                    ExecuteResult = "串口未打开";
                }
            }
            else
            {
                ExecuteState = ExecuteStateEnum.NG;
                StepState = false;
                ExecuteResult = "未找到串口对象";
            }
        }

        private void SerialClass_DataReceived(object sender, SerialDataReceivedEventArgs e)//串口接受数据的方法 如果串口一直发数据该方法会一直触发
        {
            int n = SerialDict[Connect].BytesToRead;//获取接受缓存区中数据的字节数

        }
    }
}
