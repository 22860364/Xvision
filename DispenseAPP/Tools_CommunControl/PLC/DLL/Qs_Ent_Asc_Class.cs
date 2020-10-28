using EntQsPlc_Asc;

namespace DispenseAPP.Tools_CommunControl.PLC.DLL
{
    public class Qs_Ent_Asc_Class
    {
        PlcClient PlcClient = new PlcClient();

        private int handle = 0;//通信句柄

        public bool ConnectState { get; set; }//当前连接状态 

        public bool Start(string pcIP,string plcIP, ushort plcPort)//连接PLC
        {
            short ret = PlcClient.EntLink(pcIP, 0, plcIP, plcPort, "QEPA69C5WUOOTIQQ190305MCTCPV34", ref handle, 2000, false);
            if (ret == 0)
            {
                ConnectState = true;
                return true;
            }
            else
            {
                ConnectState = false;
                return false;
            }
        }

        public bool Close()//断开PLC
        {
            ConnectState = false;
            short ret = PlcClient.DeLink(handle);
            if (ret == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Bit_Test(int address,ref bool state)//读取位状态
        {
            if(ConnectState)
            {
                short ret = PlcClient.Bit_Test(handle, PlcClient.PlcMemory.MR, address,0,ref state);
                return ret;
            }
            return -1;
        }

        public int Bit_Set(int address)//设置位状态为True
        {
            if(ConnectState)
            {
                short ret = PlcClient.Bit_Set(handle, PlcClient.PlcMemory.MR, address, 0);
            }
            return -1;
        }

        public int BitReset(int address)//设置位状态为False
        {
            if(ConnectState)
            {
                short ret = PlcClient.Bit_Reset(handle, PlcClient.PlcMemory.MR, address, 0);
            }
            return -1;
        }

        public int CmdRead(PlcClient.PlcMemory plcMemory,PlcClient.DataType dataType,int address,ushort count,ref object[] redata)//批量读取数据
        {
            if(ConnectState)
            {
                short ret = PlcClient.CmdRead(handle, plcMemory, dataType, address, count, ref redata);
            }
            return -1;
        }

        public int CmdWrite(PlcClient.PlcMemory plcMemory, PlcClient.DataType dataType, int address, ushort count, ref object[] redata)//批量写入数据
        {
            if(ConnectState)
            {
                short ret = PlcClient.CmdWrite(handle, plcMemory, dataType, address, count, ref redata);
            }
            return -1;
        }

        public static string ErrorQuery(int ret)//查询返回值的错误代码 0 表示执行成功
        {
            string errorString = "";
            switch (ret)
            {
                case 1:
                    errorString= "IP地址或端口参数错误";
                    break;
                case 2:
                    errorString = "网络连接错误";
                    break;
                case 3:
                    errorString = "连接参数错误导致连接失败";
                    break;
                case 4:
                    errorString = "PLC握手连接异常";
                    break;
                case 5:
                    errorString = "PLC握手无响应";
                    break;
                case 6:
                    errorString = "PLC握手响应错误";
                    break;
                case 10:
                    errorString = "读数据超过最大数据量限制";
                    break;
                case 11:
                    errorString = "度数据时数据发送异常";
                    break;
                case 12:
                    errorString = "读数据时PLC响应超时";
                    break;
                case 13:
                    errorString = "读数据PLC返回格式错误";
                    break;
                case 14:
                    errorString = "读数据PLC返回数据错误";
                    break;
                case 15:
                    errorString = "读数据PLC返回数据校验错误";
                    break;
                case 18:
                    errorString = "PLC的网络句柄解析错误";
                    break;
                case 19:
                    errorString = "PLC的网咯句柄数据错误";
                    break;
                case 20:
                    errorString = "写数据超过最大数据量限制";
                    break;
                case 21:
                    errorString = "写数据时数据发送异常";
                    break;
                case 22:
                    errorString = "写数据PLC响应超时";
                    break;
                case 23:
                    errorString = "写数据PLC返回格式错误";
                    break;
                case 24:
                    errorString = "写数据PLC返回数据错误";
                    break;
                case 25:
                    errorString = "写数据PLC返回数据校验错误";
                    break;
                case 28:
                    errorString = "PLC的网络句柄解析错误";
                    break;
                case 29:
                    errorString = "PLC的网络句柄数据错误";
                    break;
                case 31:
                    errorString = "数据转换时源数据处理错误";
                    break;
                case 32:
                    errorString = "数据转换时目标数据处理错误";
                    break;
                case 41:
                    errorString = "位操作函数的参数错误";
                    break;
                case 70:
                    errorString = "PLC内存区域的功能受限制";
                    break;
                case 80:
                    errorString = "PC系统中无网卡";
                    break;
                case 81:
                    errorString = "PC的IP地址格式错误";
                    break;
                case 82:
                    errorString = "PLC的IP地址格式错误";
                    break;
                case 83:
                    errorString = "PING命令返回错误";
                    break;
                case 99:
                    errorString = "连接序列号错误或测试次数超过试用限制";
                    break;
            }
            return errorString;
        }
    }
}
