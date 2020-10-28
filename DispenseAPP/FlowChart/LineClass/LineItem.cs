using System.Drawing;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    [Serializable]
    public class LineItem
    {
        public void AddSubLines()
        {
            SubLineList.Add(new FirstLine());
            SubLineList.Add(new SecondLine());
            SubLineList.Add(new ThirdLine());
            SubLineList.Add(new StartLine());
            SubLineList.Add(new EndLine());
        }

        /// <summary>
        /// 是否在直线上方
        /// </summary>
        [XmlIgnore]
        public bool IsOver { get; set; }

        /// <summary>
        /// 起始算子块对象
        /// </summary>
        [XmlIgnore]
        public BlockItem StartBlock
        {
            get => StaticPublicData.BlockItems[NameType.SystemName,StartBlockName];
        }

        /// <summary>
        /// 结束算子块对象
        /// </summary>
        [XmlIgnore]
        public BlockItem EndBlock
        {
            get => StaticPublicData.BlockItems[NameType.SystemName,EndBlockName];
        }

        /// <summary>
        /// 开始算子块名称
        /// </summary>
        public string StartBlockName { get; set; } = null;

        /// <summary>
        /// 该直线起始端连接的箭头的端口
        /// </summary>
        public int StartBlockPort { get; set; }

        /// <summary>
        /// 结束算子块名称
        /// </summary>
        public string EndBlockName { get; set; } = null;

        /// <summary>
        /// 该直线末端连接的箭头端口
        /// </summary>
        public int EndBlockPort { get; set; }

        /// <summary>
        /// 起始箭头
        /// </summary>
        [XmlIgnore]
        public Arrow StartArrow
        {
            get
            {
                return GetArrowObject(StartBlockName, StartBlockPort);
            }
        }

        /// <summary>
        /// 结束箭头
        /// </summary>
        [XmlIgnore]
        public Arrow EndArrow
        {
            get
            {
                return GetArrowObject(EndBlockName, EndBlockPort);
            }
        }

        Arrow GetArrowObject(string blockName, int blockPort)
        {
            BlockItem block = StaticPublicData.BlockItems[NameType.SystemName, blockName];
            if (block == null)
            {
                return null;
            }
            return block.ArrowList.Find(c => c.Port == blockPort);
        }

        /// <summary>
        /// 第一个偏移
        /// </summary>
        public int FirstOffset { get; set; }

        /// <summary>
        /// 第二个偏移
        /// </summary>
        public int SecondOffset { get; set; }

        /// <summary>
        /// 第三个偏移
        /// </summary>
        public int ThirdOffset { get; set; }

        /// <summary>
        /// 存储直线的集合
        /// </summary>
        [XmlArray("LineArray"), XmlArrayItem("LineItem")]
        public List<LineBase> SubLineList { get; set; } = new List<LineBase>();

        /// <summary>
        /// 画笔
        /// </summary>
        [XmlIgnore]
        Pen DrawPen { get; set; } = new Pen(Color.Blue);

        /// <summary>
        /// 画直线
        /// </summary>
        public void DrawLine(Graphics g)
        {
            int tail = 3;//Y方向小尾巴
            float distance = (StartArrow.LinePosition.Y + tail) - (EndArrow.LinePosition.Y - tail);//计算中间三条直线的平均高度
            float tempNode = ((StartArrow.LinePosition.X - EndArrow.LinePosition.X) / 2);//计算起始箭头的X和结束箭头的X的X方向的差值        
            SubLineList[3].LineStartPosition = StartArrow.LinePosition;
            SubLineList[3].LineEndPosition = new PointF(StartArrow.LinePosition.X, StartArrow.LinePosition.Y + tail + FirstOffset);
            SubLineList[0].LineStartPosition = new PointF(StartArrow.LinePosition.X, StartArrow.LinePosition.Y + tail + FirstOffset);
            SubLineList[0].LineEndPosition = new PointF(StartArrow.LinePosition.X - tempNode + SecondOffset, StartArrow.LinePosition.Y + tail + FirstOffset);
            SubLineList[1].LineStartPosition = new PointF(StartArrow.LinePosition.X - tempNode + SecondOffset, StartArrow.LinePosition.Y + tail + FirstOffset);
            SubLineList[1].LineEndPosition = new PointF(StartArrow.LinePosition.X - tempNode + SecondOffset, StartArrow.LinePosition.Y + tail - distance + ThirdOffset);
            SubLineList[2].LineStartPosition = new PointF(StartArrow.LinePosition.X - tempNode + SecondOffset, StartArrow.LinePosition.Y + tail - distance + ThirdOffset);
            SubLineList[2].LineEndPosition = new PointF(EndArrow.LinePosition.X, EndArrow.LinePosition.Y - tail + ThirdOffset);
            SubLineList[4].LineStartPosition = new PointF(EndArrow.LinePosition.X, EndArrow.LinePosition.Y - tail + ThirdOffset);
            SubLineList[4].LineEndPosition = EndArrow.LinePosition;
            DrawPen.Width = IsOver == false ? 1f : 1.6f;
            foreach (LineBase item in SubLineList)
            {
                item.DrawLine(g, DrawPen);
            }
        }

        /// <summary>
        /// 当前鼠标是否在该线集合中
        /// </summary>
        public bool IsOverFun(int x, int y)
        {
            for (int i = 0; i < SubLineList.Count; i++)
            {
                if (!(SubLineList[i] is StartLine) && !(SubLineList[i] is EndLine))
                {
                    if (SubLineList[i].IsOver(x, y) == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
