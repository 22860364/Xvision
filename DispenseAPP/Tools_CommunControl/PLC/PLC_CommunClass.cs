using System;
using static DispenseAPP.CommonClass;
using EntQsPlc_Asc;
using DispenseAPP.Tools_CommunControl.PLC.DLL;
using DispenseAPP.AboutData;
using System.Text;

namespace DispenseAPP.Tools_CommunControl.PLC
{
    public class PLC_CommunClass : ITools
    {
        public PLC_CommunClass()
        {
            ToolsKitName = ToolsKitNameEnum.Commun;
            ToolsName = ToolsNameEnum.PLC;
        }

        public string Mode { get; set; } = "读取位状态";

        public string Memory { get; set; } = "MR";

        public string Type { get; set; } = "DINT32";

        public string Connect { get; set; } = "";

        public int Address { get; set; } = 5000;

        public ushort Count { get; set; } = 1;

        public string SendToData { get; set; } = "";

        [NonSerialized]
        public bool[] State;

        [NonSerialized]
        public double[] Data;

        public override void Execute(UC_Image imageWindow)
        {
            if (QsAscDict.ContainsKey(Connect))//首先判断键值对集合中是否存在当前连接的对象
            {
                int ret;
                object[] obj = new object[Count];
                switch (Mode)
                {
                    case "读取位状态":
                        State = new bool[1];
                        ret = QsAscDict[Connect].Bit_Test(Address, ref State[0]);
                        if (ret != 0)
                        {
                            SetNG(ret);
                        }
                        else
                        {
                            SetOK("读取状态为:" + State[0].ToString());
                        }
                        break;
                    case "设置位状态为True":
                        ret = QsAscDict[Connect].Bit_Set(Address);
                        if (ret != 0)
                        {
                            SetNG(ret);
                        }
                        else
                        {
                            SetOK("设置状态为：True");
                        }
                        break;
                    case "设置位状态为False":
                        ret = QsAscDict[Connect].BitReset(Address);
                        if (ret != 0)
                        {
                            SetNG(ret);
                        }
                        else
                        {
                            SetOK("设置状态为：False");
                        }
                        break;
                    case "批量读取数据":
                        ret = QsAscDict[Connect].CmdRead((PlcClient.PlcMemory)Enum.Parse(typeof(PlcClient.PlcMemory), Memory), (PlcClient.DataType)Enum.Parse(typeof(PlcClient.DataType), Type), Address, Count, ref obj);
                        if (ret != 0)//失败
                        {
                            SetNG(ret);
                        }
                        else//成功
                        {
                            string retValue = "";
                            switch (Memory)
                            {
                                case "MR"://这里需要打断点 当批量读取的时候PLC的返回是什么
                                    State = new bool[obj.Length];
                                    for (int i = 0; i < obj.Length; i++)
                                    {
                                        State[i] = Convert.ToBoolean(obj[i]);//进行强制转换
                                        if (i == obj.Length - 1)//数组中的最后一个元素
                                        {
                                            retValue += State[i].ToString();
                                        }
                                        else
                                        {
                                            retValue += State[i].ToString() + ",";
                                        }
                                    }
                                    SetOK("读取结果为：" + retValue);
                                    break;
                                case "DR":
                                    Data = new double[Count];
                                    for (int i = 0; i < obj.Length; i++)
                                    {
                                        Data[i] = Convert.ToDouble(obj[i]);//进行强制转换
                                        if (i == obj.Length - 1)//数组中的最后一个元素
                                        {
                                            retValue += Data[i].ToString();
                                        }
                                        else
                                        {
                                            retValue += Data[i].ToString() + ",";
                                        }
                                    }
                                    SetOK("读取结果为：" + retValue);
                                    break;
                            }
                        }
                        break;
                    case "批量写入数据"://这里需要解析数据 
                        if (SendToData != "")
                        {
                            string[] strArray = SendToData.Split(',');
                            int index = SelectedNormalBlock.ToolsList.FindIndex(c => c == this);
                            StringBuilder sb = new StringBuilder();
                            for (int i = 0; i < strArray.Length; i++)
                            {
                                obj[i] = AnalysisDataClass.GetPropertyValue(strArray[i], SelectedNormalBlock.ToolsList.GetRange(0, index));
                                if(i == strArray.Length -1)
                                {
                                    sb.Append(obj[i].ToString());
                                }
                                else
                                {
                                    sb.Append(obj[i].ToString()+",");
                                }
                            }
                            ret = QsAscDict[Connect].CmdWrite((PlcClient.PlcMemory)Enum.Parse(typeof(PlcClient.PlcMemory), Memory), (PlcClient.DataType)Enum.Parse(typeof(PlcClient.DataType), Type), Address, Count, ref obj);
                            if (ret != 0)
                            {
                                SetNG(ret);
                            }
                            else
                            {
                                SetOK("写入的数据为:" + sb.ToString());
                            }
                        }
                        else //批量写入的数据为空
                        {

                        }
                        break;
                }
            }
            else //对象不在键值对集合中
            {
                ExecuteResult = "None";
                ExecuteState = ExecuteStateEnum.NG;
                StepState = false;
            }
        }

        public void SetOK(string value)//设置成功
        {
            ExecuteResult = value;
            ExecuteState = ExecuteStateEnum.OK;
            StepState = true;
        }

        public void SetNG(int ret)//设置失败
        {
            ExecuteResult = Qs_Ent_Asc_Class.ErrorQuery(ret);
            ExecuteState = ExecuteStateEnum.OK;
            StepState = true;
        }
    }
}
