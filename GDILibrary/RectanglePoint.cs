using System.Drawing;
using System.Drawing.Drawing2D;

namespace GDILibrary
{
    public enum RectanglePointType//矩形点类型
    {
        LeftTop,//左上
        LeftMid,//左中
        LeftBottom,//左下
        MidTop,//中上
        MidBottom,//中下
        RightTop,//右上
        RightMid,//右中
        RightBottom,//右下
        Top,//代表角度的
    }

    public class RectanglePoint //正方形点
    {
        public RectangleF RectanglePos { get; set; }

        public RectanglePointType RectangleType { get; set; }

        public static int LengthSide = 6;//矩形点的边长

        public RectanglePoint(RectanglePointType Type)
        {
            RectangleType = Type;
        }

        public bool IsInRectanglePoint(int x, int y)//判断当前鼠标坐标是否在圆点范围内
        {
            GraphicsPath myPath12 = new GraphicsPath();
            myPath12.AddEllipse(RectanglePos);
            Region myregion12 = new Region(myPath12);
            return myregion12.IsVisible(x, y);
        }
    }
}
