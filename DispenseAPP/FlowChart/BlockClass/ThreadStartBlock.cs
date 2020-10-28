using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    [Serializable]
    class ThreadStartBlock:Element 
    {
        public ThreadStartBlock(Rectangle rectangleRegion,ProjectParamClass projectParam) : base(rectangleRegion,projectParam)
        {
            _shapeOfCollection = new PointF[5];
            for (int i = 0; i < _arrowCount; i++)
            {
                ArrowClass arrowClass;                
                if (i == 0)
                {
                    arrowClass = new ArrowClass(ArrowEnum.input);
                }
                else
                {
                    arrowClass = new ArrowClass(ArrowEnum.ouput);
                }
                _arrowList.Add(arrowClass);
            }
            ChangePosition();
        }

        public override void ChangePosition()
        {
            //画图像
            _shapeOfCollection[0] = new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2), _rectangleRegion.Y);//上方
            _shapeOfCollection[1] = new PointF(_rectangleRegion.X, _rectangleRegion.Y + (_rectangleRegion.Height / 2));//左中
            _shapeOfCollection[2] = new PointF(_rectangleRegion.X, _rectangleRegion.Y + _rectangleRegion.Height);//左下
            _shapeOfCollection[4] = new PointF(_rectangleRegion.X + _rectangleRegion.Width, _rectangleRegion.Y + (_rectangleRegion.Height / 2));//右中
            _shapeOfCollection[3] = new PointF(_rectangleRegion.X + _rectangleRegion.Width, _rectangleRegion.Y + _rectangleRegion.Height);//右下
            //画名称
            fontRectangle = new RectangleF(_rectangleRegion.X, (_rectangleRegion.Y + _rectangleRegion.Height / 2), _rectangleRegion.Width, _rectangleRegion.Height / 2);
            width = (_rectangleRegion.Width - (distanceOfEdge * 2) - (arrowLengthOfSide * (_arrowCount - 1))) / (_arrowCount - 2);//计算间距
            //画箭头
            for (int i = 0; i < _arrowCount; i++)
            {
                if (i == 0)
                {
                    _arrowList[i]._arrowPoint = new PointF[] { new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2) - (arrowLengthOfSide / 2), _rectangleRegion.Y - arrowHighWidth), new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2) + (arrowLengthOfSide / 2), _rectangleRegion.Y - arrowHighWidth), new PointF(_rectangleRegion.X + _rectangleRegion.Width / 2, _rectangleRegion.Y) };
                    _arrowList[i].LinePosition = new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2), _rectangleRegion.Y);
                }
                else
                {
                    int index = i - 1;
                    _arrowList[i]._arrowPoint = new PointF[] { new PointF(_rectangleRegion.X  + distanceOfEdge + index * arrowLengthOfSide + index * width, _rectangleRegion.Y + _rectangleRegion.Height), new PointF(_rectangleRegion.X  + distanceOfEdge + (index * arrowLengthOfSide) + (index * width) + arrowLengthOfSide, _rectangleRegion.Y + _rectangleRegion.Height), new PointF(_rectangleRegion.X + distanceOfEdge + (index * arrowLengthOfSide) + (index * width) + (arrowLengthOfSide / 2), _rectangleRegion.Y + _rectangleRegion.Height + arrowHighWidth) };
                    _arrowList[i].LinePosition = new PointF(_rectangleRegion.X  + distanceOfEdge + (index * arrowLengthOfSide) + (index * width) + (arrowLengthOfSide / 2), _rectangleRegion.Y + _rectangleRegion.Height);
                }
            }
        }

        public override void Execute(Thread thread)//线程开始执行的方法 线程的下一个还可以有线程  每个线程块只能有10个线程
        {
             List<ArrowClass> arrowList =  _arrowList.FindAll(c => c._connectElement != null && c.ArrowType == ArrowEnum.ouput);//获得所有连接了线的箭头
            if(arrowList.Count >0)
            {
                for (int i = 0; i < arrowList.Count; i++)//遍历所有带有连接线的箭头
                {
                    Element element = _projectParam._chartLineList.Find(t => t.StartArrow == arrowList[i]).EndBlock;
                    if (i == arrowList.Count -1)
                    {
                        element.Execute(thread);
                    }
                    else
                    {
                        Thread itemThread = null;
                        itemThread = new Thread(new ThreadStart(() => element.Execute(itemThread)))
                        {
                            IsBackground = true
                        };
                        RunThreadList.Add(itemThread);
                        itemThread.Start();
                    }
                }
            }      
        }
    }
}
