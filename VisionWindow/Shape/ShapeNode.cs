using System.Drawing;

namespace VisionWindow.Shape
{
    public class ShapeNode
    {
        public ShapeNode(PointF center)
        {
            Center = center;
        }

        /// <summary>
        /// 节点中心坐标
        /// </summary>
        public PointF Center { get; set; }

        /// <summary>
        /// 节点半径
        /// </summary>
        float NodeRadius { get; set; } = 3.5f;
        float Zoom;
        PointF Screen;
        public RectangleF RectF => new RectangleF(ImageToPB(Center).X - NodeRadius, ImageToPB(Center).Y - NodeRadius, NodeRadius * 2, NodeRadius * 2);

        internal void Draw(Graphics g, float zoom, PointF screen, Color color)
        {
            Zoom = zoom;
            Screen = screen;
            g.FillRectangle(new SolidBrush(color), RectF);
        }

        internal bool IsContains(PointF mousePos)
        {
            return new RectangleF(Center.X - NodeRadius * 3, Center.Y - NodeRadius * 3, NodeRadius * 5, NodeRadius * 5).Contains(mousePos);
        }

        internal PointF ImageToPB(PointF imagePos)//图像坐标系转换为PB坐标系
        {
            return new PointF(imagePos.X * Zoom + Screen.X, imagePos.Y * Zoom + Screen.Y);
        }
    }
}
