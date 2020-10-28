using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDILibrary
{
    public enum DrawType //类型
    {
        Rectangle,
        Rectangle2,
        Circle,
        Null,
        RectPoint,
    }

    public abstract class Element//实体类
    {
        public Element(Rectangle rectangle)
        {
            _rectangle = rectangle;
        }

        protected PointF[] _shapeOfCollection;//图形的点集

        public List< RectanglePoint>  _rectanglPointList = new List<RectanglePoint>();//正方形点

        public RectangleF _rectangle;

        private int _radius = 2;

        public abstract void Draw(Graphics g);

        public abstract void ChangePosition();

        public abstract void DrawRectanglePoint(Graphics g);

        public abstract void ChangeSize(RectanglePointType RectangleType,PointF point);

        public abstract bool IsOver(int x, int y);

        protected RectangleF GenRectangleFromCenter(PointF center, float radius)//根据中心得到矩形
        {
            return new RectangleF(center.X - radius, center.Y - radius, radius * 2, radius * 2);
        }
    }
}
