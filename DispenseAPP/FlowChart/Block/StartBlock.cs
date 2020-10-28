using System.Drawing;
using System;

namespace DispenseAPP
{
    [Serializable]
    public class StartBlock : BlockItem
    {
        public override int ArrowCount { get => 1; set { } }

        public StartBlock(Rectangle rectangleRegion,string customName,string systemName) : base(rectangleRegion,customName, systemName)
        {
            ArrowList.Add(new Arrow(ArrowEnum.ouput,0));
        }

        /// <summary>
        /// 用于序列化
        /// </summary>
        public StartBlock(){}

        protected override void ChangeArrowPosition()
        {
            if (ArrowList.Count == 0)
            {
                return;
            }
            ArrowList[0].Position = new PointF[] { new PointF(Region.X + (Region.Width / 2) - arrowLengthOfSide / 2, Region.Y + Region.Height), new PointF(Region.X + (Region.Width / 2) + arrowLengthOfSide / 2, Region.Y + Region.Height), new PointF(Region.X + (Region.Width / 2), Region.Y + Region.Height + arrowHighWidth) };//画下箭头
            ArrowList[0].LinePosition = new PointF(Region.X + (Region.Width / 2), Region.Y + Region.Height);
        }

        public override BlockItem Execute()
        {
            return null;
        }

        /// <summary>
        /// 画选择阴影  开始算子块不画选择阴影
        /// </summary>
        /// <param name="g"></param>
        public override void DrawSelectedRectangle(Graphics g)
        {
        }
    }
}
