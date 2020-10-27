using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using VisionWindow.Shape;
using static VisionWindow.Controller;
using System.Collections.Generic;
using System.Collections;
using System;

namespace VisionWindow.ROI
{
    public abstract class ShapeBase
    {
        protected abstract ShapeNode[] NodeArry { get; }//代表形状周边的节点 每个形状的节点都不同 当形状被选中时出现节点

        public Pen DrawPen { get; set; } = new Pen(Color.LimeGreen, 1f);
    

        public abstract Region Region { get;}

        public float ExcludeRegion(Region region)
        {
            Region.Exclude(region);
            float area = 0f;
            foreach (RectangleF item in Region.GetRegionScans(new Matrix()))
            {
                area += item.Width * item.Height;
            }
            return area;
        }

        /// <summary>
        /// 是否可以被选中
        /// </summary>
        public bool EnableSelect { get; set; } = true;

        /// <summary>
        /// 是否选中 选中情况下显示节点 有且只有一个可以被选中
        /// </summary>
        public bool IsSelect { get; set; } = false;

        /// <summary>
        /// 是否包含鼠标的当前位置 如果包含 则线加粗
        /// </summary>
        public bool IsContain { get; set; } = false;

        protected float Zoom { get; set; }

        protected PointF Screen { get; set; }

        /// <summary>
        /// 可以改变大小
        /// </summary>
        public bool EnableResize { get; set; } = false;

        /// <summary>
        /// 执行移动ROI
        /// </summary>
        /// <param name="mousePos"></param>
        public abstract void ExecuteMoveROI(PointF mousePos);


        public abstract void ExecuteResizeROI(PointF mousePos);

        public virtual void Draw(Graphics g, float zoom, PointF screen)//画ROI
        {
            Zoom = zoom;
            Screen = screen;
            DrawPen.Width = IsContain ? 2.5f : 1f;
        }

        /// <summary>
        /// 鼠标在形状内部
        /// </summary>
        /// <param name="mousePos"></param>
        /// <returns></returns>
        public abstract bool MouseInGraphics(PointF mousePos);

        /// <summary>
        /// 鼠标在形状上方
        /// </summary>
        /// <param name="mousePos"></param>
        /// <returns></returns>
        public abstract bool MouseOverGraphics(PointF mousePos);

        /// <summary>
        /// 获得该形状的所有节点的矩形集合
        /// </summary>
        public abstract RectangleF[] GetAllNodeRectangles { get;}

        /// <summary>
        /// 对鼠标信息进行判断
        /// </summary>
        /// <param name="mousePos">鼠标的位置</param>
        /// <param name="mouseMode">鼠标模式</param>
        /// <returns></returns>
        public bool ExecuteShapeBaseSelectCantains(PointF mousePos, MouseMode mouseMode)
        {
            bool state = MouseInGraphics(mousePos) || MouseOverGraphics(mousePos);//鼠标位置是否处于图形内部或图形上方
            switch (mouseMode)
            {
                case MouseMode.MouseLeftDown:
                    IsSelect = state;
                    break;
                case MouseMode.MouseMove:
                    IsContain = state; 
                    break;
            }
            return state;
        }

        /// <summary>
        /// 执行选择节点
        /// </summary>
        /// <param name="MousePos">鼠标位置</param>
        /// <param name="cursor">鼠标图像</param>
        public abstract Cursor ExecuteSelectNode(PointF MousePos,Cursor cursor);

        protected  PointF PBToImage(PointF MousePos)//PB坐标系转化为图像坐标系
        {
            return new PointF((MousePos.X - Screen.X) / Zoom, (MousePos.Y - Screen.Y) / Zoom);
        }

        protected PointF ImageToPB(PointF imagePos)//图像坐标系转换为PB坐标系
        {
            return new PointF(imagePos.X * Zoom + Screen.X, imagePos.Y * Zoom + Screen.Y);
        }

        protected PointF[] ImageToPB(PointF[] pointFs)
        {
            List<PointF> ret = new List<PointF>();
            foreach (PointF item in pointFs)
            {
                ret.Add(ImageToPB(item));
            }
            return ret.ToArray();
        }
    }
}
