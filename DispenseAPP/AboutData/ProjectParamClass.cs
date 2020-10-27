using DispenseAPP.AboutData;
using DispenseAPP.Tools_Location.ProgramDispensePath.DisplayImagePath;
using System;
using System.Collections.Generic;

namespace DispenseAPP
{
    [Serializable]
    public class ProjectParamClass
    {
        public List<Element> _flowChartList = new List<Element>();// 流程图集合

        public List<ChartLine> _chartLineList = new List<ChartLine>();// 连线集合

        public dynamic Vars = new VarClass();//动态添加变量类

        public int windowCount = 1;//窗口数量

        public List<TCPDataClass> _tcpList = new List<TCPDataClass>();//存放TCP的数据

        public List<PLCDataClass> _plcList = new List<PLCDataClass>();//存放PLC通讯参数

        public List<SerialDataClass> _serialList = new List<SerialDataClass>();//存放串口通讯参数 
    }
}
