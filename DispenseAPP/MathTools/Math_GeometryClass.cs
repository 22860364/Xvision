using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DispenseAPP.MathTools
{
    public class Math_GeometryClass//几何类
    {
        public static bool IsVisible(RectangleF rectangleF, PointF point1, PointF point2)//判断直线和矩形是否有交集
        {       
            if(rectangleF.Contains(point1) || rectangleF.Contains(point2))//首先判断直线的两个端点是否在矩形内部
            {
                return true;
            }
            if(rectangleF.Contains(point1.X,point2.Y) || rectangleF.Contains(point2.X,point1.Y))
            {
                return true;
            }
            return false;
        }

        public static bool IsVisible(RectangleF rect1, RectangleF rect2)//判断矩形和矩形是否有交集
        {
            GraphicsPath myPath12 = new GraphicsPath();
            myPath12.AddRectangle(rect1);
            Region myregion12 = new Region(myPath12);
            return myregion12.IsVisible(rect2);           
        }

        public static double GetTwoPointDistance(PointF pt1,PointF pt2)//获得两点之间的距离
        {
            return Math.Sqrt(Math.Pow(pt1.X - pt2.X, 2) + Math.Pow(pt1.Y - pt2.Y, 2));
        }

        public static void GetCircleCenterRadiusFromThreePoint(PointF pt1, PointF pt2, PointF pt3, out double x,out double y, out double r)//根据三点求出圆心和半径
        {
           x = ((Math.Pow(pt1.X, 2) + Math.Pow(pt1.Y, 2)) * (pt2.Y - pt3.Y) + (Math.Pow(pt2.X, 2) + Math.Pow(pt2.Y, 2)) * (pt3.Y - pt1.Y) + (Math.Pow(pt3.X, 2) + Math.Pow(pt3.Y, 2)) * (pt1.Y - pt2.Y)) / (2*(pt1.X * (pt2.Y - pt3.Y) - pt1.Y * (pt2.X - pt3.X) + pt2.X * pt3.Y - pt3.X * pt2.Y));
            y = ((Math.Pow(pt1.X, 2) + Math.Pow(pt1.Y, 2)) * (pt3.X - pt2.X) + (Math.Pow(pt2.X, 2) + Math.Pow(pt2.Y, 2)) * (pt1.X - pt3.X) + (Math.Pow(pt3.X, 2) + Math.Pow(pt3.Y, 2)) * (pt2.X - pt1.X)) / (2 * (pt1.X * (pt2.Y - pt3.Y) - pt1.Y * (pt2.X - pt3.X) + pt2.X * pt3.Y - pt3.X * pt2.Y));
            r = Math.Sqrt(Math.Pow(x - pt1.X, 2) + Math.Pow(y - pt1.Y, 2));
        }

        //public static void GetArcParam(PointF pt1, PointF pt2, PointF pt3,out double startAngle,out double sweepAngle)
        //{

        //}

        //public static double GetTriangleArea(PointF pointA, PointF pointB, PointF pointC)//通过向量的方式获得三角形面积
        //{      
        //}
    }
}
