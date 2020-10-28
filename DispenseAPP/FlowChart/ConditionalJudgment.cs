using System;

namespace DispenseAPP.FlowChart
{
    /// <summary>
    /// 条件判断类
    /// </summary>
    [Serializable]
    public class ConditionalJudgment:ICloneable 
    {
        /// <summary>
        /// 端口号
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// 测量算子名
        /// </summary>
        public string MeasureBlockName { get; set; }

        /// <summary>
        /// 测量值
        /// </summary>
        public string MeasureValue { get; set; }

        /// <summary>
        /// 测量结果
        /// </summary>
        public string MeasureResult { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
