using System;
using System.Drawing;

namespace DispenseAPP
{
    [Serializable]
    public abstract class LineParent
    {
        public bool IsDrag { get; set; }//该直线是否被选中

        protected PointF _startPosition;
        public PointF StartPosition//直线起始点
        {
            get
            {
                return _startPosition;
            }
            set
            {
                if(value.X < CanvaClass.PictureBoxLocation.X +5)
                {
                    _startPosition.X = CanvaClass.PictureBoxLocation.X +5;
                }
                else
                {
                    _startPosition.X = value.X;
                }
                if(value.Y < CanvaClass.PictureBoxLocation.Y +5)
                {
                    _startPosition.Y = CanvaClass.PictureBoxLocation.Y+5;
                }
                else
                {
                    _startPosition.Y = value.Y;
                }
            }             
        }

        private PointF _endPosition;
        public PointF EndPosition//直线结束点
        {
            get
            {
                return _endPosition;
            }
            set
            {
                if(value.X < CanvaClass.PictureBoxLocation.X +5)
                {
                    _endPosition.X = CanvaClass.PictureBoxLocation.X + 5;
                }
                else
                {
                    _endPosition.X = value.X;
                }
                if(value.Y < CanvaClass.PictureBoxLocation.Y +5)
                {
                    _endPosition.Y = CanvaClass.PictureBoxLocation.Y + 5;
                }
                else
                {
                    _endPosition.Y = value.Y;
                }
            }
        }

        /// <summary>
        /// 鼠标位置是否在该直线上
        /// </summary>
        public bool IsOver(int x, int y)
        {
            double cross = (EndPosition.X - StartPosition.X) * (x - StartPosition.X) + (EndPosition.Y - StartPosition.Y) * (y - StartPosition.Y);
            if(cross <= 0)
            {
                return false;
            }
            double d = (EndPosition.X - StartPosition.X) * (EndPosition.X - StartPosition.X) + (EndPosition.Y - StartPosition.Y) * (EndPosition.Y - StartPosition.Y);
            if(cross >= d)
            {
                return false;
            }
            double r = cross / d;
            double px = StartPosition.X + (EndPosition.X - StartPosition.X) * r;
            double py = StartPosition.Y + (EndPosition.Y - StartPosition.Y) * r;
            return Math.Sqrt((x - px) * (x - px) + (py - y) * (py - y)) <= 2;
        }

        public void DrawLine(Graphics g,Pen pen)
        {
            g.DrawLine(pen, StartPosition, EndPosition);
        }
    }
}
