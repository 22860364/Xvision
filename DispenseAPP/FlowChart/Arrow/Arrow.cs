using System.Drawing;
using System.Drawing.Drawing2D;
using System;
using DispenseAPP.FlowChart;
using static DispenseAPP.CommonClass;
using System.Xml.Serialization;

namespace DispenseAPP
{
    public enum ArrowEnum { input, ouput };//箭头枚举

    /// <summary>
    /// 箭头类 箭头有两种类型 输入箭头 只能接受直线  输出箭头 只能向输入箭头连接直线
    /// </summary>
    [Serializable]
    public class Arrow : ICloneable
    {
        /// <summary>
        /// 用于序列化该类 
        /// </summary>
        public Arrow()
        {
        }

        /// <summary>
        /// 使用箭头类型初始化箭头
        /// </summary>
        /// <param name="arrowType">箭头类型</param>
        public Arrow(ArrowEnum arrowType, int port)
        {
            Type = arrowType;
            Port = port;
        }

        [XmlElement("ConditionalJudgment")]
        public ConditionalJudgment ConditionalJudgmentInstance { get; set; } = null;

        /// <summary>
        /// 连接的算子块实例
        /// </summary>
        [XmlIgnore]
        public BlockItem ConnectBlock
        {
            get
            {
                if (ConnectBlockName == null)
                {
                    return null;
                }
                return StaticPublicData.BlockItems[NameType.SystemName,ConnectBlockName];
            }
        }

        /// <summary>
        /// 该箭头连接的算子块的名称
        /// </summary>
        public string ConnectBlockName { get; set; } = null;

        /// <summary>
        /// 端口号
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// 端口类型
        /// </summary>
        public ArrowEnum Type { get; set; }

        /// <summary>
        /// 鼠标在箭头上方
        /// </summary>
        [XmlIgnore]
        public bool InAbove { get; set; } = false;

        /// <summary>
        /// 直线的位置
        /// </summary>
        public PointF LinePosition { get; set; }

        /// <summary>
        /// 箭头的位置数据
        /// </summary>
        [XmlIgnore]
        public PointF[] Position = new PointF[3];

        /// <summary>
        /// 使用Graphics对象画箭头
        /// </summary>
        /// <param name="g">Graphics对象</param>
        public void DrawArrow(Graphics g)
        {
            g.DrawPolygon(Pens.Black, Position);
        }

        /// <summary>
        /// 当鼠标在该箭头上方时,使用Graphics对象填充箭头
        /// </summary>
        /// <param name="g">Graphics对象</param>
        public void FillArrow(Graphics g)
        {
            if (InAbove)
            {
                g.FillPolygon(Brushes.Blue, Position);
            }
        }

        /// <summary>
        /// 是否在箭头上方
        /// </summary>
        public bool IsOver(int x, int y)
        {
            GraphicsPath myPath12 = new GraphicsPath();
            myPath12.AddPolygon(Position);
            Region myregion12 = new Region(myPath12);
            InAbove = myregion12.IsVisible(x, y);
            return InAbove;
        }

        /// <summary>
        /// 执行克隆
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return ExecuteClone(this);
        }
    }
}
