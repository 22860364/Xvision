using System;
using System.Drawing;
using System.Xml.Serialization;

namespace DispenseAPP
{
    [XmlInclude(typeof(StartLine))]
    [XmlInclude(typeof(FirstLine))]
    [XmlInclude(typeof(SecondLine))]
    [XmlInclude(typeof(ThirdLine))]
    [XmlInclude(typeof(EndLine))]
    [Serializable]
    public abstract class LineBase
    {
        /// <summary>
        /// 该直线是否被选中
        /// </summary>
        [XmlIgnore]
        public bool IsDrag { get; set; }

        PointF startPosition;
        /// <summary>
        /// 直线起始点
        /// </summary>
        public PointF LineStartPosition
        {
            get => startPosition;
            set
            {
                startPosition.X = value.X < Canva.PictureBoxLocation.X + 5 ? Canva.PictureBoxLocation.X + 5 : value.X;
                startPosition.Y = value.Y < Canva.PictureBoxLocation.Y + 5 ? Canva.PictureBoxLocation.Y + 5 : value.Y;
            }
        }

        PointF endPosition;
        /// <summary>
        /// 直线结束点
        /// </summary>
        public PointF LineEndPosition
        {
            get => endPosition;
            set
            {
                endPosition.X = value.X < Canva.PictureBoxLocation.X + 5 ? Canva.PictureBoxLocation.X + 5 : value.X;
                endPosition.Y = value.Y < Canva.PictureBoxLocation.Y + 5 ? Canva.PictureBoxLocation.Y + 5 : value.Y;
            }
        }

        /// <summary>
        /// 鼠标位置是否在该直线上
        /// </summary>
        public bool IsOver(int x, int y)
        {
            double cross = (LineEndPosition.X - LineStartPosition.X) * (x - LineStartPosition.X) + (LineEndPosition.Y - LineStartPosition.Y) * (y - LineStartPosition.Y);
            if (cross <= 0)
            {
                return false;
            }
            double d = (LineEndPosition.X - LineStartPosition.X) * (LineEndPosition.X - LineStartPosition.X) + (LineEndPosition.Y - LineStartPosition.Y) * (LineEndPosition.Y - LineStartPosition.Y);
            if (cross >= d)
            {
                return false;
            }
            double r = cross / d;
            double px = LineStartPosition.X + (LineEndPosition.X - LineStartPosition.X) * r;
            double py = LineStartPosition.Y + (LineEndPosition.Y - LineStartPosition.Y) * r;
            return Math.Sqrt((x - px) * (x - px) + (py - y) * (py - y)) <= 2;
        }

        /// <summary>
        /// 画直线
        /// </summary>
        /// <param name="g"></param>
        /// <param name="pen">画笔</param>
        public void DrawLine(Graphics g, Pen pen)
        {
            g.DrawLine(pen, LineStartPosition, LineEndPosition);
        }
    }
}
