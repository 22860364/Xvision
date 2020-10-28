using DispenseAPP.FlowChart.BlockClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    [Serializable]
    public class MultiThreadStartBlock : BlockItem
    {
        public MultiThreadStartBlock(Rectangle rectangleRegion,string customName,string systemName) : base(rectangleRegion,customName,systemName)
        {
            for (int i = 0; i < ArrowCount; i++)
            {
                Arrow arrowClass = i == 0 ? new Arrow(ArrowEnum.input,i) : new Arrow(ArrowEnum.ouput,i);
                ArrowList.Add(arrowClass);
            }
        }

        /// <summary>
        /// 用于序列化
        /// </summary>
        public MultiThreadStartBlock() {}

        public override PointF[] ShapePosition => new PointF[]
        {
            new PointF(Region.X + (Region.Width / 2), Region.Y),//上方
            new PointF(Region.X, Region.Y + (Region.Height / 2)),//左中
            new PointF(Region.X, Region.Y + Region.Height),//左下
            new PointF(Region.X + Region.Width, Region.Y + Region.Height),//右下
            new PointF(Region.X + Region.Width, Region.Y + (Region.Height / 2)),//右中
        };

        public override RectangleF FontRectangleF => new RectangleF(Region.X, Region.Y + Region.Height / 2, Region.Width, Region.Height / 2);

        int arrowCount = 4;
        public override int ArrowCount { get => arrowCount; set => arrowCount = value; }

        public override float Width { get => (Region.Width - (distanceOfEdge * 2) - (arrowLengthOfSide * (ArrowCount - 1))) / (ArrowCount - 2); }

        protected override void ChangeArrowPosition()
        {
            for (int i = 0; i < ArrowList.Count; i++)
            {
                if (i == 0)
                {
                    ArrowList[i].Position = new PointF[] { new PointF(Region.X + (Region.Width / 2) - (arrowLengthOfSide / 2), Region.Y - arrowHighWidth), new PointF(Region.X + (Region.Width / 2) + (arrowLengthOfSide / 2), Region.Y - arrowHighWidth), new PointF(Region.X + Region.Width / 2, Region.Y) };
                    ArrowList[i].LinePosition = new PointF(Region.X + (Region.Width / 2), Region.Y);
                }
                else
                {
                    int index = i - 1;
                    ArrowList[i].Position = new PointF[] { new PointF(Region.X + distanceOfEdge + index * arrowLengthOfSide + index * Width, Region.Y + Region.Height), new PointF(Region.X + distanceOfEdge + (index * arrowLengthOfSide) + (index * Width) + arrowLengthOfSide, Region.Y + Region.Height), new PointF(Region.X + distanceOfEdge + (index * arrowLengthOfSide) + (index * Width) + (arrowLengthOfSide / 2), Region.Y + Region.Height + arrowHighWidth) };
                    ArrowList[i].LinePosition = new PointF(Region.X + distanceOfEdge + (index * arrowLengthOfSide) + (index * Width) + (arrowLengthOfSide / 2), Region.Y + Region.Height);
                }
            }
        }

        public override BlockItem Execute()//线程开始执行的方法 线程的下一个还可以有线程  每个线程块只能有10个线程
        {
            List<Arrow> arrowList = ArrowList.FindAll(c => c.ConnectBlock != null && c.Type == ArrowEnum.ouput);//获得所有连接了线的箭头
            BlockItem element = null;
            for (int i = 0; i < arrowList.Count; i++)//遍历所有带有连接线的箭头
            {
                element = StaticPublicData.LineItems[LineArrowType.StartArrow,arrowList[i]].EndBlock;
                if (i != arrowList.Count - 1)
                {
                    ThreadExecute threadExecute = new ThreadExecute();
                    Thread itemThread = new Thread(new ParameterizedThreadStart(threadExecute.Execute))
                    {
                        IsBackground = true
                    };
                    threadExecute.CurrentThread = itemThread;
                    FrmPrimary.BThreadList.Add(itemThread);
                    itemThread.Start(element);
                }
            }
            return element;
        }
    }
}
