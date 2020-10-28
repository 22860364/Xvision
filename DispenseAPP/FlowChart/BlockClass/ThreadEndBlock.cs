using System;
using System.Drawing;
using System.Threading;

namespace DispenseAPP
{
    [Serializable]
    class ThreadEndBlock:Element 
    {
        public ThreadEndBlock( Rectangle rectangleRegion,ProjectParamClass projectParam) : base(rectangleRegion,projectParam)
        {
            _shapeOfCollection = new PointF[5];
            for (int i = 0; i < _arrowCount; i++)
            {
                ArrowClass arrowClass;
                if (i == 0) { arrowClass = new ArrowClass(ArrowEnum.ouput); }
                else { arrowClass = new ArrowClass(ArrowEnum.input); }
                _arrowList.Add(arrowClass);
            }
            
            ChangePosition();
        }

        public override void ChangePosition()
        {
            //画图像
            _shapeOfCollection[0] = new PointF(_rectangleRegion.X, _rectangleRegion.Y);//左上
            _shapeOfCollection[1] = new PointF(_rectangleRegion.X, _rectangleRegion.Y + (_rectangleRegion.Height / 2));//左中
            _shapeOfCollection[2] = new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2), _rectangleRegion.Y + _rectangleRegion.Height);//下
            _shapeOfCollection[4] = new PointF(_rectangleRegion.X + _rectangleRegion.Width, _rectangleRegion.Y);//右上
            _shapeOfCollection[3] = new PointF(_rectangleRegion.X + _rectangleRegion.Width, _rectangleRegion.Y + (_rectangleRegion.Height / 2));//右中
            //画名称
            fontRectangle = new RectangleF(_rectangleRegion.X, _rectangleRegion.Y, _rectangleRegion.Width, _rectangleRegion.Height / 2);
            width = (_rectangleRegion.Width - (distanceOfEdge * 2) - (arrowLengthOfSide * (_arrowCount - 1))) / (_arrowCount - 2);//计算间距
            //画箭头
            for (int i = 0; i < _arrowCount; i++)
            {
                if (i == 0)
                {
                    _arrowList[i]._arrowPoint = new PointF[] { new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2) - (arrowLengthOfSide / 2), _rectangleRegion.Y + _rectangleRegion.Height), new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2) + (arrowLengthOfSide / 2), _rectangleRegion.Y + _rectangleRegion.Height), new PointF(_rectangleRegion.X + _rectangleRegion.Width / 2, _rectangleRegion.Y+ _rectangleRegion.Height+ arrowHighWidth) };
                    _arrowList[i].LinePosition = new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2), _rectangleRegion.Y + _rectangleRegion.Height);
                }
                else
                {
                    int index = i - 1;
                    _arrowList[i]._arrowPoint = new PointF[] { new PointF(_rectangleRegion.X + distanceOfEdge + index * arrowLengthOfSide + index * width, _rectangleRegion.Y - arrowHighWidth), new PointF(_rectangleRegion.X + distanceOfEdge + (index * arrowLengthOfSide) + (index * width) + arrowLengthOfSide, _rectangleRegion.Y - arrowHighWidth), new PointF(_rectangleRegion.X + distanceOfEdge + (index * arrowLengthOfSide) + (index * width) + (arrowLengthOfSide / 2), _rectangleRegion.Y) };
                    _arrowList[i].LinePosition = new PointF(_rectangleRegion.X + distanceOfEdge + (index * arrowLengthOfSide) + (index * width) + (arrowLengthOfSide / 2), _rectangleRegion.Y);
                }
            }
        }

        public readonly static object _padLock = new object();//防止多线程同时访问

        public override void Execute(Thread thread)//停止这个箭头向上所对应的线程 有两种方法 ：1 向上查找法 2 向下传递法
        {
            lock(_padLock)
            {
                if (thread.ThreadState == ThreadState.Running && thread.ThreadState != ThreadState.Stopped)
                {
                    thread.Abort();
                }
            }
        }
    }
}
