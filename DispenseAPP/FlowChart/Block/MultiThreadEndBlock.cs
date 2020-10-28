using System;
using System.Drawing;

namespace DispenseAPP
{
    /// <summary>
    /// 多线程结束块
    /// </summary>
    [Serializable]
    public class MultiThreadEndBlock:BlockItem 
    {
        public MultiThreadEndBlock(Rectangle rectangleRegion,string customName,string systemName) : base(rectangleRegion,customName,systemName)
        {
            for (int i = 0; i < ArrowCount; i++)
            {
                Arrow arrowClass = i == 0 ? new Arrow(ArrowEnum.ouput, i) : new Arrow(ArrowEnum.input, i);
                ArrowList.Add(arrowClass);
            }          
        }

        /// <summary>
        /// 用于序列化
        /// </summary>
        public MultiThreadEndBlock()
        {

        }

        public override RectangleF FontRectangleF => new RectangleF(Region.X, Region.Y, Region.Width, Region.Height / 2);

        public override PointF[] ShapePosition => new PointF[]
        {
            new PointF(Region.X, Region.Y),//左上
            new PointF(Region.X, Region.Y + (Region.Height / 2)),//左中
            new PointF(Region.X + (Region.Width / 2), Region.Y + Region.Height),//下
            new PointF(Region.X + Region.Width, Region.Y + (Region.Height / 2)),//右中
            new PointF(Region.X + Region.Width, Region.Y),//右上
        };

        int arrowCount = 4;
        public override int ArrowCount { get => arrowCount; set => arrowCount = value; }

        public override float Width => (Region.Width - (distanceOfEdge * 2) - (arrowLengthOfSide * (ArrowCount - 1))) / (ArrowCount - 2);

        protected override void ChangeArrowPosition()
        {
            //画箭头
            for (int i = 0; i < ArrowList.Count; i++)
            {
                if (i == 0)
                {
                    ArrowList[i].Position = new PointF[] { new PointF(Region.X + (Region.Width / 2) - (arrowLengthOfSide / 2), Region.Y + Region.Height), new PointF(Region.X + (Region.Width / 2) + (arrowLengthOfSide / 2), Region.Y + Region.Height), new PointF(Region.X + Region.Width / 2, Region.Y+ Region.Height+ arrowHighWidth) };
                    ArrowList[i].LinePosition = new PointF(Region.X + (Region.Width / 2), Region.Y + Region.Height);
                }
                else
                {
                    int index = i - 1;
                    ArrowList[i].Position = new PointF[] { new PointF(Region.X + distanceOfEdge + index * arrowLengthOfSide + index * Width, Region.Y - arrowHighWidth), new PointF(Region.X + distanceOfEdge + (index * arrowLengthOfSide) + (index * Width) + arrowLengthOfSide, Region.Y - arrowHighWidth), new PointF(Region.X + distanceOfEdge + (index * arrowLengthOfSide) + (index * Width) + (arrowLengthOfSide / 2), Region.Y) };
                    ArrowList[i].LinePosition = new PointF(Region.X + distanceOfEdge + (index * arrowLengthOfSide) + (index * Width) + (arrowLengthOfSide / 2), Region.Y);
                }
            }
        }

        public override BlockItem Execute()//停止这个箭头向上所对应的线程 有两种方法 ：1 向上查找法 2 向下传递法
        {
            return null;
        }
    }
}
