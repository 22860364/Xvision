using DispenseAPP.XMLSerializer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Xml.Serialization;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    /// <summary>
    /// 算子块类型
    /// </summary>
    public enum BlockType
    {
        /// <summary>
        /// 开始算子块
        /// </summary>
        StartBlock,
        /// <summary>
        /// 普通算子块
        /// </summary>
        NormalBlock,
        /// <summary>
        /// 单条件判断算子块
        /// </summary>
        IfElseBlock,
        /// <summary>
        /// 多条件判断算子块
        /// </summary>
        SwitchBlock,
        /// <summary>
        /// 线程开始算子块
        /// </summary>
        ThreadStartBlock,
        /// <summary>
        /// 线程结束算子块
        /// </summary>
        ThreadStopBlock,
    }

    /// <summary>
    /// 提供用于创建算子块的抽象基类 包括了算子块共有的属性和方法
    /// </summary>
    [XmlInclude(typeof(OperatorBlock))]
    [XmlInclude(typeof(IfBlock))]
    [XmlInclude(typeof(StartBlock))]
    [XmlInclude(typeof(SwitchBlock))]
    [XmlInclude(typeof(MultiThreadEndBlock))]
    [XmlInclude(typeof(MultiThreadStartBlock))]
    [Serializable]
    public abstract class BlockItem
    {
        /// <summary>
        /// 用指定的矩形区域来实例化算子块
        /// </summary>
        /// <param name="rectangleRegion"></param>
        public BlockItem(Rectangle rectangleRegion,string customName,string systemName)
        {
            Region = rectangleRegion;
            CustomName = customName;
            SystemName = systemName;
        }

        /// <summary>
        /// 用于序列化
        /// </summary>
        public BlockItem()
        {

        }

        protected RectangleF region;
        /// <summary>
        /// 所在矩形区域
        /// </summary>
        [XmlIgnore]
        public RectangleF Region
        {
            get => region;
            set
            {
                region = value;
                ChangeArrowPosition();
            }
        }

        /// <summary>
        /// 该算子块的矩形区域（XML保存）
        /// </summary>
        [XmlElement("BlockRegion")]
        public XMLRectangleF BlockXMLRectangleF
        {
            get
            {
                return new XMLRectangleF(Region.X, Region.Y, Region.Width, Region.Height);
            }
            set
            {
                Region = XMLRectangleF.FormXMLRectangleF(value);
            }
        }

        /// <summary>
        /// 是否被拖动选中
        /// </summary>
        [XmlIgnore]
        public bool IsDrag { get; set; }

        /// <summary>
        /// 鼠标是否在当前块上方
        /// </summary>
        [XmlIgnore]
        public bool IsOver { get; set; }

        /// <summary>
        /// 自定义名称
        /// </summary>
        public virtual string CustomName { get; set; }

        /// <summary>
        /// 系统名称（不变化的）
        /// </summary>
        public string SystemName { get; set;}

        /// <summary>
        /// 显示字体的矩形框
        /// </summary>
        [XmlIgnore]
        public virtual RectangleF FontRectangleF => Region;

        /// <summary>
        /// 画算子块的点集合
        /// </summary>
        [XmlArray("ShapePositionArray"), XmlArrayItem("ShapePositionItem")]
        public virtual PointF[] ShapePosition => new PointF[]
        {
            new PointF(Region.X, Region.Y),
            new PointF(Region.X + Region.Width, Region.Y),
            new PointF(Region.X + Region.Width, Region.Y + Region.Height),
            new PointF(Region.X, Region.Y + Region.Height)
        };

        /// <summary>
        /// 等边三角形箭头的边长
        /// </summary>
        [XmlIgnore]
        public const int arrowLengthOfSide = 16;

        /// <summary>
        /// 等边三角形箭头的高
        /// </summary>
        [XmlIgnore]
        public const float arrowHighWidth = 13.85f;

        /// <summary>
        /// 箭头集合
        /// </summary>
        [XmlArray("ArrowList"), XmlArrayItem("ArrowItem")]
        public List<Arrow> ArrowList { get; set; } = new List<Arrow>();

        /// <summary>
        /// 箭头个数
        /// </summary>
        public abstract int ArrowCount { get; set;} 
 
        /// <summary>
        /// 箭头距离矩形区域边缘的宽度
        /// </summary>
        [XmlIgnore]
        protected const int distanceOfEdge = 5;

        /// <summary>
        /// 间距
        /// </summary>
        [XmlIgnore]
        public virtual float Width { get;}

        /// <summary>
        /// 输出端口数量
        /// </summary>
        public int OutputPortCount { get; set; } = 3;

        /// <summary>
        /// 该算子块是否在运行中
        /// </summary>
        [XmlIgnore]
        public bool IsRunning { get; set; } = false;

        public int LastIndex { get; set; } = -1;

        protected abstract void ChangeArrowPosition();

        public abstract BlockItem Execute();//声明抽象方法 每个算子块都要实现 来决定每个算子块负责不同的工作

        /// <summary>
        /// 画算子块以及算子块的Text
        /// </summary>
        /// <param name="text"></param>
        /// <param name="g"></param>
        public virtual void Draw(Graphics g,OperatorBlock operatorBlock)
        {
            ChangeArrowPosition();
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,//水平对齐方式
                LineAlignment = StringAlignment.Center//垂直对齐方式 
            };//文本布局
            g.DrawString(CustomName, new Font("微软雅黑", 10.5F, FontStyle.Regular), operatorBlock != null && operatorBlock.Equals(this)?Brushes.White:Brushes.Black, FontRectangleF, sf);
            g.DrawPolygon(Pens.Black, ShapePosition);
            if(IsOver)//如果当前鼠标在算子块上方 则画箭头
            {
                foreach (Arrow item in ArrowList)
                {
                    item.DrawArrow(g);
                }
            }
            foreach (Arrow item in ArrowList)//填充箭头
            {
                item.FillArrow(g);
            }
        }

        public virtual void AddPort()//添加端口
        {
            region.Width += Width + arrowLengthOfSide;
            OutputPortCount += 1;
            ArrowCount += 1;
            ArrowList.Add(new Arrow(ArrowEnum.ouput,ArrowCount -1));
        }

        public virtual void DeletePort()//删除端口
        {
            if (OutputPortCount > 3)
            {
                region.Width -= Width + arrowLengthOfSide;
                OutputPortCount -= 1;
                ArrowCount -= 1;
                ArrowList.RemoveAt(ArrowList.Count - 1);
            }
        }

        /// <summary>
        /// 画选择阴影
        /// </summary>
        public virtual void DrawSelectedRectangle(Graphics g)
        {
            g.FillRectangle(Brushes.LimeGreen, Region.X - arrowLengthOfSide, Region.Y - arrowHighWidth, Region.Width + (arrowHighWidth * 2), Region.Height + (arrowHighWidth * 2));
        }

        /// <summary>
        /// 鼠标位于算子块上方
        /// </summary>
        /// <param name="x">鼠标X坐标</param>
        /// <param name="y">鼠标Y坐标</param>
        /// <returns>位于上方返回true 否则返回false</returns>
        public bool MousetheAbove(int x, int y)
        {
            GraphicsPath myPath12 = new GraphicsPath();
            myPath12.AddPolygon(ShapePosition);
            Region myregion12 = new Region(myPath12);
            return myregion12.IsVisible(x, y);
        }

        /// <summary>
        /// 当前算子块是否被选择矩形选中
        /// </summary>
        /// <param name="_rect">选择矩形的实体对象</param>
        /// <returns>被选中返回true 否则返回false</returns>
        public bool IsSelectedBySelectRectangle(Rectangle _rect)
        {
            GraphicsPath myPath12 = new GraphicsPath();
            myPath12.AddPolygon(ShapePosition);
            Region myregion12 = new Region(myPath12);
            return myregion12.IsVisible(_rect);
        }

        /// <summary>
        /// 克隆
        /// </summary>
        /// <returns></returns>
        public virtual BlockItem Clone()
        {
            return ExecuteClone(this);
        }
    }
}
