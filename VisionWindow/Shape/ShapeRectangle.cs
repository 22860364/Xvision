using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using VisionWindow.Shape;
using System.Collections.Generic;
using System;

namespace VisionWindow.ROI
{
    /// <summary>
    /// 矩形
    /// </summary>
    public class ShapeRectangle : ShapeBase
    {
        protected ResizeType sizeType;

        /// <summary>
        /// 表示矩形的坐标数据
        /// </summary>
        protected readonly PointF[] shapeCollection = new PointF[4];

        protected override ShapeNode[] NodeArry => new ShapeNode[]//图像坐标系坐标
        {
           new ShapeNode(shapeCollection[0]),//左上
           new ShapeNode(new PointF((shapeCollection[0].X + shapeCollection[1].X) / 2, (shapeCollection[0].Y + shapeCollection[1].Y) / 2)),//上中
           new ShapeNode(shapeCollection[1]),//右上
           new ShapeNode(new PointF((shapeCollection[0].X + shapeCollection[3].X) / 2, (shapeCollection[0].Y + shapeCollection[3].Y) / 2)),//左中
           new ShapeNode(new PointF((shapeCollection[1].X + shapeCollection[2].X) / 2, (shapeCollection[1].Y + shapeCollection[2].Y) / 2)),//右中
           new ShapeNode(shapeCollection[3]),//左下
           new ShapeNode(new PointF((shapeCollection[2].X + shapeCollection[3].X) / 2, (shapeCollection[2].Y + shapeCollection[3].Y) / 2)),//下中
           new ShapeNode(shapeCollection[2]),//右下
         };

        public override Region Region
        {
            get
            {
                GraphicsPath graphicsPath = new GraphicsPath();
                graphicsPath.AddPolygon(shapeCollection);
                return new Region(graphicsPath);
            }
        }

        /// <summary>
        /// 以指定的位置、大小、颜色来初始化ShapeRectangle
        /// </summary>
        /// <param name="position"></param>
        /// <param name="color"></param>
        public ShapeRectangle(PointF[] position, Color color)
        {
            for (int i = 0; i < position.Length; i++)//设置Rectangle坐标
            {
                shapeCollection[i] = position[i];
            }
            DrawPen.Color = color;//设置画笔颜色
        }

        protected enum ResizeType
        {
            LeftTop,//左上
            LeftMid,//左中
            LeftBottom,//左下
            MidTop,//中上
            MidBottom,//中下
            RightTop,//右上
            RightMid,//右中
            RightBottom,//右下
            Top,//角度
        }

        public override void Draw(Graphics g, float zoom, PointF screen)
        {
            base.Draw(g, zoom, screen);
            g.DrawPolygon(DrawPen, ImageToPB(shapeCollection));//画多边形
            if (IsSelect)//如果当前被选中 则画节点
            {
                foreach (ShapeNode item in NodeArry)
                {
                    item.Draw(g, Zoom, Screen, Color.FromArgb(byte.MaxValue - DrawPen.Color.R, byte.MaxValue - DrawPen.Color.G, byte.MaxValue - DrawPen.Color.B));
                }
            }
        }

        protected virtual void ComputerROIPosition()//计算多边形的位置
        {
            shapeCollection[1] = new PointF(shapeCollection[2].X, shapeCollection[0].Y);
            shapeCollection[3] = new PointF(shapeCollection[0].X, shapeCollection[2].Y);
        }

        public override Cursor ExecuteSelectNode(PointF mousePos, Cursor cursor)
        {
            EnableResize = false;
            if (NodeArry[0].IsContains(PBToImage(mousePos)))
            {
                cursor = GetCornerCursor(NodeArry[0].Center);
                sizeType = ResizeType.LeftTop;
                EnableResize = true;
            }
            else if (NodeArry[1].IsContains(PBToImage(mousePos)))
            {
                sizeType = ResizeType.MidTop;
                cursor = Cursors.SizeNS;
                EnableResize = true;
            }
            else if (NodeArry[2].IsContains(PBToImage(mousePos)))
            {
                sizeType = ResizeType.RightTop;
                cursor = GetCornerCursor(PBToImage(NodeArry[2].Center));
                EnableResize = true;
            }
            else if (NodeArry[3].IsContains(PBToImage(mousePos)))
            {
                sizeType = ResizeType.LeftMid;
                cursor = Cursors.SizeWE;
                EnableResize = true;
            }
            else if (NodeArry[4].IsContains(PBToImage(mousePos)))
            {
                sizeType = ResizeType.RightMid;
                cursor = Cursors.SizeWE;
                EnableResize = true;
            }
            else if (NodeArry[5].IsContains(PBToImage(mousePos)))
            {
                sizeType = ResizeType.LeftBottom;
                cursor = GetCornerCursor(PBToImage(NodeArry[5].Center));
                EnableResize = true;
            }
            else if (NodeArry[6].IsContains(PBToImage(mousePos)))
            {
                sizeType = ResizeType.MidBottom;
                cursor = Cursors.SizeNS;
                EnableResize = true;
            }
            else if (NodeArry[7].IsContains(PBToImage(mousePos)))
            {
                sizeType = ResizeType.RightBottom;
                cursor = GetCornerCursor(PBToImage(NodeArry[7].Center));
                EnableResize = true;
            }
            return cursor;
        }

        public Cursor GetCornerCursor(PointF pointF)
        {
            PointF rectangleCenter = new PointF((shapeCollection[0].X + shapeCollection[2].X) / 2, (shapeCollection[0].Y + shapeCollection[2].Y) / 2);
            if ((pointF.X < rectangleCenter.X && pointF.Y < rectangleCenter.Y) || (pointF.X >= rectangleCenter.X && pointF.Y >= rectangleCenter.Y))
            {
                return Cursors.SizeNWSE;
            }
            else
            {
                return Cursors.SizeNESW;
            }
        }

        public override void ExecuteMoveROI(PointF mousePos)
        {
            for (int i = 0; i < shapeCollection.Length; i++)
            {
                shapeCollection[i].X += mousePos.X;
                shapeCollection[i].Y += mousePos.Y;
            }
        }

        public override void ExecuteResizeROI(PointF mousePos)
        {
            float x = mousePos.X;
            float y = mousePos.Y;
            switch (sizeType)
            {
                case ResizeType.LeftTop:
                    shapeCollection[0].X += x;
                    shapeCollection[0].Y += y;
                    break;
                case ResizeType.MidTop:
                    shapeCollection[0].Y += y;
                    break;
                case ResizeType.RightTop:
                    shapeCollection[0].Y += y;
                    shapeCollection[2].X += x;
                    break;
                case ResizeType.LeftMid:
                    shapeCollection[0].X += x;
                    break;
                case ResizeType.RightMid:
                    shapeCollection[2].X += x;
                    break;
                case ResizeType.LeftBottom:
                    shapeCollection[0].X += x;
                    shapeCollection[2].Y += y;
                    break;
                case ResizeType.MidBottom:
                    shapeCollection[2].Y += y;
                    break;
                case ResizeType.RightBottom:
                    shapeCollection[2].X += x;
                    shapeCollection[2].Y += y;
                    break;
            }
            ComputerROIPosition();
        }

        #region 位置判断
        /// <summary>
        /// 鼠标在图形上
        /// </summary>
        /// <param name="mousePos">鼠标坐标（控件坐标系）</param>
        /// <returns></returns>
        public override bool MouseOverGraphics(PointF mousePos)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddRectangle(new RectangleF(shapeCollection[0].X, shapeCollection[0].Y - 10, Math.Abs(shapeCollection[1].X - shapeCollection[0].X), 10 * 2));
            graphicsPath.AddRectangle(new RectangleF(shapeCollection[1].X - 10,shapeCollection[1].Y,10*2,Math.Abs(shapeCollection[2].Y - shapeCollection[1].Y)));
            graphicsPath.AddRectangle(new RectangleF(shapeCollection[3].X, shapeCollection[3].Y - 10, Math.Abs(shapeCollection[3].X - shapeCollection[2].X), 10 * 2));
            graphicsPath.AddRectangle(new RectangleF(shapeCollection[1].X - 10, shapeCollection[1].Y, 10 * 2, Math.Abs(shapeCollection[1].Y - shapeCollection[3].Y)));
            Region region = new Region(graphicsPath);
            return region.IsVisible(PBToImage(mousePos).X, PBToImage(mousePos).Y);
        }

        /// <summary>
        /// 鼠标在图形里
        /// </summary>
        /// <param name="mousePos">鼠标坐标（控件坐标系）</param>
        /// <returns></returns>
        public override bool MouseInGraphics(PointF mousePos)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddPolygon(shapeCollection);
            Region region = new Region(graphicsPath);
            return region.IsVisible(PBToImage(mousePos).X, PBToImage(mousePos).Y);
        }

        /// <summary>
        /// 当前图形的所有节点的矩形集合
        /// </summary>
        public override RectangleF[] GetAllNodeRectangles 
        {
            get
            {
                List<RectangleF> rectangles = new List<RectangleF>();
                foreach (ShapeNode item in NodeArry)
                {
                    rectangles.Add(item.RectF);
                }
                return rectangles.ToArray();
            }          
        }
        #endregion
    }
}
