using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    /// <summary>
    /// 提供用于存储算子的容器
    /// </summary>
    [Serializable]
    public class OperatorBlock : BlockItem
    {
        /// <summary>
        /// 使用RectangleF结构体初始化Operator类的新实例。
        /// </summary>
        /// <param name="rectangleRegion">表示Operator对象的位置和大小</param>
        public OperatorBlock(Rectangle rectangleRegion, string name,string systemName) : base(rectangleRegion, name, systemName)
        {
            ArrowList.Add(new Arrow(ArrowEnum.input, 0));
            ArrowList.Add(new Arrow(ArrowEnum.ouput, 1));
        }

        /// <summary>
        /// 用于序列化
        /// </summary>
        public OperatorBlock() { }

        /// <summary>
        /// 当前算子块存储工具集合
        /// </summary>
        [XmlArray("ToolList"), XmlArrayItem("ToolItem")]
        public List<IToolable> ToolList { get; set; } = new List<IToolable>();

        /// <summary>
        /// 表示该普通算子块的执行状态 所有工具的步状态相与
        /// </summary>
        public bool ExecuteState { get; set; } = true;

        /// <summary>
        /// 图像窗口索引
        /// </summary>
        public string ImageWindowIndex { get; set; } = "0";

        /// <summary>
        /// 消息窗口索引
        /// </summary>
        public string MessageWindowIndex { get; set; } = "0";

        /// <summary>
        /// 显示消息
        /// </summary>
        public bool VisibleMessage { get; set; } = false;

        /// <summary>
        /// 箭头个数
        /// </summary>
        public override int ArrowCount { get => 2; set { } }

        public override void Draw(Graphics g, OperatorBlock operatorBlock)
        {
            if (operatorBlock != null && operatorBlock.Equals(this))
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(43, 87, 154)), Region.X, Region.Y, Region.Width + 1, Region.Height + 1);
            }
            base.Draw(g, operatorBlock);
        }

        protected override void ChangeArrowPosition()
        {
            if (ArrowList.Count == 0)
            {
                return;
            }
            //画箭头
            ArrowList[0].Position = new PointF[] { new PointF(Region.X + (Region.Width / 2) - arrowLengthOfSide / 2, Region.Y - arrowHighWidth), new PointF(Region.X + (Region.Width / 2) + arrowLengthOfSide / 2, Region.Y - arrowHighWidth), new PointF(Region.X + (Region.Width / 2), Region.Y) };
            ArrowList[1].Position = new PointF[] { new PointF(Region.X + (Region.Width / 2) - arrowLengthOfSide / 2, Region.Y + Region.Height), new PointF(Region.X + (Region.Width / 2) + arrowLengthOfSide / 2, Region.Y + Region.Height), new PointF(Region.X + (Region.Width / 2), Region.Y + Region.Height + arrowHighWidth) };
            //确定直线的终点
            ArrowList[0].LinePosition = new PointF(Region.X + Region.Width / 2, Region.Y);
            //确定直线的起点
            ArrowList[1].LinePosition = new PointF(Region.X + Region.Width / 2, Region.Y + Region.Height);
        }

        public override BlockItem Execute()
        {
            bool state = true;
            foreach (IToolable item in ToolList)//执行每个工具
            {
                item.ComputerExecuteTime();
                state &= item.StepState;
            }
            ExecuteState = state;
            LineItem chartLine = StaticPublicData.LineItems[LineBlockType.StartBlock,this];
            if (chartLine != null)
            {
                return chartLine.EndBlock;
            }
            else
            {
                return null;
            }
        }
    }
}
