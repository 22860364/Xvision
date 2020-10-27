using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace DispenseAPP
{
    public enum ElementType// 元素类型
    {
        StartBlock,
        NormalBlock,
        IfElseBlock,
        SwitchBlock,
        ThreadStartBlock,
        ThreadStopBlock,
    }

    [Serializable]
    public abstract class Element
    {
        public Element(Rectangle rectangleRegion,ProjectParamClass projectParam)
        {
            _rectangleRegion = rectangleRegion;
            arrowHighWidth = Convert.ToInt32(Math.Sqrt(Math.Pow(arrowLengthOfSide, 2) - Math.Pow(arrowLengthOfSide / 2, 2)));
            _projectParam = projectParam;
        }

        public RectangleF _rectangleRegion;//元素的矩形区域

        protected bool _normalBolockIsSelected;//是否被选中
        public bool NormalIsSelected
        {
            get { return _normalBolockIsSelected; }
            set { _normalBolockIsSelected = value; }
        }

        [NonSerialized]
        protected bool _isDragSelected;//是否移动选中
        public bool IsDragSelected
        {
            get { return _isDragSelected; }
            set { _isDragSelected = value; }
        }

        [NonSerialized]
        protected bool _isOver;//是否在上方
        public bool IsOver
        {
            get { return _isOver; }
            set { _isOver = value; }
        }

        protected string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        protected ProjectParamClass _projectParam;

        protected RectangleF fontRectangle;

        protected PointF[] _shapeOfCollection;

        protected int arrowLengthOfSide = 16;//等边三角形边长

        protected float arrowHighWidth;//等边三角形的高

        public List<ArrowClass> _arrowList = new List<ArrowClass>();//箭头集合

        [NonSerialized]
        protected int _arrowCount = 4;//箭头个数

        [NonSerialized]
        protected int distanceOfEdge = 5;//与边缘间距


        protected float width;

        [NonSerialized]
        public int portCount = 3;//默认输出端口数量为3

        public bool IsStartBlock { get; set; }//会否是开始算子  开始算子的颜色是绿色 并且开始算子唯一

        public virtual void Draw(string text, Graphics g)
        {
            StringFormat sf = new StringFormat();//文本布局
            sf.Alignment = StringAlignment.Center;//水平对齐方式
            sf.LineAlignment = StringAlignment.Center;//垂直对齐方式 
            g.DrawString(text, new Font("微软雅黑", 10.5F, FontStyle.Regular), Brushes.Black, fontRectangle, sf);
            g.DrawPolygon(Pens.Black, _shapeOfCollection);
        }

        /// <summary>
        /// 画箭头
        /// </summary>
        public virtual void DrawArrow(Graphics g)
        {
            foreach (var item in _arrowList)
            {
                item.DrawArrow(g);
            }
        }

        public virtual void AddPort()//添加端口
        {
            _rectangleRegion.Width += width+ arrowLengthOfSide;
            portCount += 1;
            _arrowCount += 1;
            _arrowList.Add(new ArrowClass(ArrowEnum.ouput));
            ChangePosition();
        }

        public virtual void DeletePort()//删除端口
        {
            if(portCount > 3)
            {
                _rectangleRegion.Width -= width+ arrowLengthOfSide;
                portCount -= 1;
                _arrowCount -= 1;
                _arrowList.RemoveAt(_arrowList.Count - 1);

                ChangePosition();
            }

        }

        /// <summary>
        /// 画选择阴影
        /// </summary>
        public virtual void DrawSelectedRectangle(Graphics g)
        {
            g.FillRectangle(Brushes.LightGoldenrodYellow, _rectangleRegion.X - arrowLengthOfSide, _rectangleRegion.Y - arrowHighWidth, _rectangleRegion.Width + (arrowHighWidth * 2), _rectangleRegion.Height + (arrowHighWidth * 2));
        }

        public bool IsIn(int x, int y)//查询鼠标是否在上方
        {
            GraphicsPath myPath12 = new GraphicsPath();
            myPath12.AddPolygon(_shapeOfCollection);
            Region myregion12 = new Region(myPath12);
            return myregion12.IsVisible(x, y);
        }

        public bool QueryIsChecked(Rectangle _rect)//查询是否被选择矩形选中
        {
            GraphicsPath myPath12 = new GraphicsPath();
            myPath12.AddPolygon(_shapeOfCollection);
            Region myregion12 = new Region(myPath12);
            return myregion12.IsVisible(_rect);
        }

        public virtual Element Clone()//克隆
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Position = 0;
            return formatter.Deserialize(stream) as Element;
        }

        public abstract void ChangePosition();

        public abstract void Execute(Thread thread);//声明抽象方法 每个算子块都要实现 来决定每个算子块负责不同的工作
    }
}
