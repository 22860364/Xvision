using System.Drawing;
using System;
using System.Threading;

namespace DispenseAPP
{
    [Serializable]
    public class StartBlock : Element
    {
        public StartBlock(Rectangle rectangleRegion,ProjectParamClass projectParam) : base(rectangleRegion,projectParam)
        {
            _shapeOfCollection = new PointF[4];       
            ChangePosition();
            _arrowList.Add(arrowClass);
        }

        private ArrowClass arrowClass = new ArrowClass(ArrowEnum.ouput);

        public override void ChangePosition()
        {
            //画图形
            _shapeOfCollection[0] = new PointF(_rectangleRegion.X, _rectangleRegion.Y);
            _shapeOfCollection[1] = new PointF(_rectangleRegion.X + _rectangleRegion.Width, _rectangleRegion.Y);
            _shapeOfCollection[2] = new PointF(_rectangleRegion.X + _rectangleRegion.Width, _rectangleRegion.Y + _rectangleRegion.Height);
            _shapeOfCollection[3] = new PointF(_rectangleRegion.X, _rectangleRegion.Y + _rectangleRegion.Height);
            //画箭头
            arrowClass._arrowPoint = new PointF[] { new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2) - arrowLengthOfSide / 2 , _rectangleRegion.Y + _rectangleRegion.Height), new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2) + arrowLengthOfSide / 2 , _rectangleRegion.Y + _rectangleRegion.Height ), new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2), _rectangleRegion.Y + _rectangleRegion.Height + arrowHighWidth) };
            arrowClass._arrowPosition = new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2), _rectangleRegion.Y + _rectangleRegion.Height);
            fontRectangle = _rectangleRegion;
            //确定直线的起点
            arrowClass.LinePosition = new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2), _rectangleRegion.Y + _rectangleRegion.Height);
        }

        public override void Execute(Thread thread)
        {
            ChartLine chartLine = _projectParam._chartLineList.Find(s => s.StartBlock.Equals(this));
            if(chartLine != null)
            {
                chartLine.EndBlock.Execute(thread);
            }
        }
    }
}
