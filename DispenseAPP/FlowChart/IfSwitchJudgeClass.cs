using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP.FlowChart
{
    [Serializable]
    public class IfSwitchJudgeClass:ICloneable 
    {
        public int Port { get; set; }//端口号

        public string BlockName { get; set; }//算子名

        public string MeasureValue { get; set; }//测量值

        public string MeasureResult { get; set; }//测量结果

        public ArrowClass _arrowClas;//当前的箭头类型

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
