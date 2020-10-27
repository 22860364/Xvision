using System;
using System.Text;
using static DispenseAPP.CommonClass;
using DispenseAPP.AboutData;

namespace DispenseAPP.Tools_CommunControl.TCP
{
    [Serializable]
    [UnAbleManualExecute]
    public class TCP_IP_Class :ITools
    {
        #region 基本
        public string Connect { get; set; }//连接

        public int TimeOutNum { get; set; } = 5000;//超时时间

        public bool SetTimeOut { get; set; } = false;//是否设置超时

        public bool KeepConnect { get; set; } = false;//保持连接

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

        public TCP_IP_Class()
        {
            ToolsKitName = ToolsKitNameEnum.Commun;
            ToolsName = ToolsNameEnum.TCP_IP;
        }

        public override void Execute(UC_Image imageWindow)//执行：读取缓存区的数据 
        {
            if (ServerDict.ContainsKey(Connect))
            {
                if (IsSend)//发送数据
                {
                    int index = SelectedNormalBlock.ToolsList.FindIndex(c => c == this);
                    string value = AnalysisDataClass.AnalysisBracketsData(SendText, SelectedNormalBlock.ToolsList.GetRange(0,index));
                    ServerDict[Connect].Send(Encoding.Default.GetBytes(value));
                    ExecuteResult = "Send" + value;
                }
                else//接受数据
                {
                    DataString = "";
                    if (ServerDict[Connect].IsReceiveData == true)
                    {
                        DataString = Encoding.Default.GetString(ServerDict[Connect].ReveiveDataBuffer, 0, ServerDict[Connect].Length);
                        ServerDict[Connect].IsReceiveData = false;
                    }
                    ExecuteResult = "Receive:" + DataString;
                }
                ExecuteState = ExecuteStateEnum.OK;
                StepState = true;
            }
            else
            {
                ExecuteState = ExecuteStateEnum.NG;
                StepState = false;
                ExecuteResult = "未找到通讯对象";
            }
        }
    }
}
