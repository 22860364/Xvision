using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDILibrary
{
    public class DrawRectangle2 : Element //画旋转矩形
    {
        public DrawRectangle2(Rectangle rectangle) : base(rectangle)
        {
            _shapeOfCollection = new PointF[4];//四边形
            for (int i = 0; i < 9; i++)
            {
                RectanglePoint _rectanglPoint = new RectanglePoint((RectanglePointType)i);//根据不同的索引值 对应不同的点
                _rectanglPointList.Add(_rectanglPoint);
            }
            ChangePosition();
        }

        public override void ChangePosition()
        {
            _shapeOfCollection[0] = new PointF(_rectangle.X, _rectangle.Y);//左上
            _shapeOfCollection[1] = new PointF(_rectangle.X + _rectangle.Width, _rectangle.Y);//右上
            _shapeOfCollection[2] = new PointF(_rectangle.X + _rectangle.Width, _rectangle.Y + _rectangle.Height);//右下
            _shapeOfCollection[3] = new PointF(_rectangle.X, _rectangle.Y + _rectangle.Height);//左下
            _rectanglPointList[0].RectanglePos = new RectangleF(_shapeOfCollection[0].X - RectanglePoint.LengthSide / 2, _shapeOfCollection[0].Y - RectanglePoint.LengthSide / 2, RectanglePoint.LengthSide, RectanglePoint.LengthSide);//左上
            _rectanglPointList[1].RectanglePos = new RectangleF(_rectangle.X - RectanglePoint.LengthSide / 2, _rectangle.Y + (_rectangle.Height / 2) - (RectanglePoint.LengthSide / 2), RectanglePoint.LengthSide, RectanglePoint.LengthSide);//左中
            _rectanglPointList[2].RectanglePos = new RectangleF(_shapeOfCollection[3].X - RectanglePoint.LengthSide / 2, _shapeOfCollection[3].Y - RectanglePoint.LengthSide / 2, RectanglePoint.LengthSide, RectanglePoint.LengthSide);//左下
            _rectanglPointList[3].RectanglePos = new RectangleF(_rectangle.X + _rectangle.Width / 2 - RectanglePoint.LengthSide / 2, _rectangle.Y - RectanglePoint.LengthSide / 2, RectanglePoint.LengthSide, RectanglePoint.LengthSide);//中上
            _rectanglPointList[4].RectanglePos = new RectangleF(_rectangle.X + _rectangle.Width / 2 - RectanglePoint.LengthSide / 2, _rectangle.Y + _rectangle.Height - RectanglePoint.LengthSide / 2, RectanglePoint.LengthSide, RectanglePoint.LengthSide);//中下
            _rectanglPointList[5].RectanglePos = new RectangleF(_shapeOfCollection[1].X - RectanglePoint.LengthSide / 2, _shapeOfCollection[1].Y - RectanglePoint.LengthSide / 2, RectanglePoint.LengthSide, RectanglePoint.LengthSide);//右上
            _rectanglPointList[6].RectanglePos = new RectangleF(_rectangle.X + _rectangle.Width - RectanglePoint.LengthSide / 2, _rectangle.Y + _rectangle.Height / 2 - RectanglePoint.LengthSide / 2, RectanglePoint.LengthSide, RectanglePoint.LengthSide);//右中
            _rectanglPointList[7].RectanglePos = new RectangleF(_shapeOfCollection[2].X - RectanglePoint.LengthSide / 2, _shapeOfCollection[2].Y - RectanglePoint.LengthSide / 2, RectanglePoint.LengthSide, RectanglePoint.LengthSide);//右下         
            _rectanglPointList[8].RectanglePos = new RectangleF(_rectangle.X + _rectangle.Width / 2 - RectanglePoint.LengthSide / 2, _rectangle.Y - 30, RectanglePoint.LengthSide, RectanglePoint.LengthSide);//  
        }

        public override void ChangeSize(RectanglePointType RectangleType, PointF point)
        {
            switch (RectangleType)
            {
                case RectanglePointType.LeftTop:
                    _rectangle.X += point.X;
                    _rectangle.Y += point.Y;
                    _rectangle.Width -= point.X;
                    _rectangle.Height -= point.Y;
                    break;
                case RectanglePointType.LeftMid:
                    _rectangle.X += point.X;
                    _rectangle.Width -= point.X;
                    break;
                case RectanglePointType.LeftBottom://改变 x height
                    _rectangle.X += point.X;
                    _rectangle.Height += point.Y;
                    _rectangle.Width -= point.X;
                    break;
                case RectanglePointType.MidTop:
                    _rectangle.Y += point.Y;
                    _rectangle.Height -= point.Y;
                    break;
                case RectanglePointType.MidBottom:
                    _rectangle.Height += point.Y;
                    break;
                case RectanglePointType.RightTop:
                    _rectangle.Y += point.Y;
                    _rectangle.Width += point.X;
                    _rectangle.Height -= point.Y;
                    break;
                case RectanglePointType.RightMid:
                    _rectangle.Width += point.X;
                    break;
                case RectanglePointType.RightBottom:
                    _rectangle.Width += point.X;
                    _rectangle.Height += point.Y;
                    break;
                case RectanglePointType.Top://旋转
                    break;
            }
        }

        public override void Draw(Graphics g)
        {
            g.DrawPolygon(Pens.Blue, _shapeOfCollection);
        }

        public override void DrawRectanglePoint(Graphics g)
        {
            foreach (RectanglePoint item in _rectanglPointList)
            {
                g.FillEllipse(Brushes.White, item.RectanglePos);
                g.DrawEllipse(Pens.Black, item.RectanglePos);
            }
            g.DrawLine(Pens.Blue, _rectangle.X + _rectangle.Width / 2, _rectangle.Y - RectanglePoint.LengthSide/2, _rectangle.X + _rectangle.Width / 2, _rectangle.Y - 30 + RectanglePoint.LengthSide );
        }

        public override bool IsOver(int x, int y)
        {
            GraphicsPath myPath12 = new GraphicsPath();
            myPath12.AddPolygon(_shapeOfCollection);
            Region myregion12 = new Region(myPath12);
            return myregion12.IsVisible(x, y);
        }
    }
}
