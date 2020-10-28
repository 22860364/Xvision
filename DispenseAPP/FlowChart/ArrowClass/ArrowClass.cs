using System.Drawing;
using System.Drawing.Drawing2D;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using DispenseAPP.FlowChart;
using System.Threading;

namespace DispenseAPP
{
    public enum ArrowEnum { input, ouput };//箭头枚举

    /// <summary>
    /// 箭头类
    /// </summary>
    [Serializable]
    public class ArrowClass : ICloneable
    {

        public IfSwitchJudgeClass _ifSwitchJudgeClass = new IfSwitchJudgeClass();

        public ArrowClass(ArrowEnum arrowType)
        {
            ArrowType = arrowType;
        }

        public PointF _arrowPosition = new PointF();

        public Element _connectElement = null;

        public int PortID { get; set; }

        public ArrowEnum ArrowType { get; set; } //箭头类型

        [NonSerialized]
        private bool _isOVer;
        public bool IsOver//箭头是否被选中  决定了该箭头是否会被填充
        {
            get { return _isOVer; }
            set { _isOVer = value; }
        }

        public PointF LinePosition { get; set; }

        public void DrawArrow(Graphics g)
        {
            g.DrawPolygon(Pens.Black, _arrowPoint);
        }

        public void FillArrow(Graphics g)
        {
            g.FillPolygon(Brushes.Blue, _arrowPoint);
        }

        public PointF[] _arrowPoint = new PointF[3];//箭头数组

        /// <summary>
        /// 是否在箭头上方
        /// </summary>
        public bool isOver(int x, int y)
        {
            GraphicsPath myPath12 = new GraphicsPath();
            myPath12.AddPolygon(_arrowPoint);
            Region myregion12 = new Region(myPath12);
            return myregion12.IsVisible(x, y);
        }

        public object Clone()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Position = 0;
            return formatter.Deserialize(stream) as Element;
        }
    }
}
