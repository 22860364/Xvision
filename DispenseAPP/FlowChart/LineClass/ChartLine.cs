using System.Drawing;
using System;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

namespace DispenseAPP
{
    [Serializable]
    public class ChartLine
    {
        public ChartLine()
        {
            subLineList.Add(firstLine);
            subLineList.Add(secondLine);
            subLineList.Add(thirdLine);
            subLineList.Add(startLine);
            subLineList.Add(endLine);
        }

        public bool IsOver { get; set; }//是否在直线上方 

        public Element StartBlock { get; set; }//起始的算子块 

        public Element EndBlock { get; set; }//结束的算子块 

        public ArrowClass StartArrow { get; set; }//起始箭头

        public ArrowClass EndArrow { get; set; }//结束箭头

        PointF[] point = new PointF[] { };//连接线的集合        

        public int FirstOffset { get; set; }//从开始算第一个偏移

        public int SecondOffset { get; set; }//第二个偏移

        public int ThirdOffset { get; set; }//第三个偏移

        private LineParent startLine = new StartLine();

        private LineParent firstLine = new FirstLine();

        private LineParent secondLine = new SecondLine();

        private LineParent thirdLine = new ThirdLine();

        private LineParent endLine = new EndLine();

        public List<LineParent> subLineList = new List<LineParent>();//存储直线的集合

        /// <summary>
        /// 画直线
        /// </summary>
        public void DrawLine(Graphics g)
        {
            Pen pen = new Pen(Color.Blue);//画连接线的笔
            int tail = 3;//Y方向小尾巴
            float distance = (StartArrow.LinePosition.Y + tail) - (EndArrow.LinePosition.Y - tail);
            float tempNode = ((StartArrow.LinePosition.X - EndArrow.LinePosition.X) / 2);//中间节点X            
            startLine.StartPosition = StartArrow.LinePosition;
             firstLine.StartPosition = new PointF(StartArrow.LinePosition.X, StartArrow.LinePosition.Y + tail + FirstOffset);
            startLine.EndPosition = new PointF(StartArrow.LinePosition.X, StartArrow.LinePosition.Y + tail + FirstOffset);
            secondLine.StartPosition =  new PointF(StartArrow.LinePosition.X - tempNode + SecondOffset, StartArrow.LinePosition.Y + tail + FirstOffset);
            firstLine.EndPosition = new PointF(StartArrow.LinePosition.X - tempNode + SecondOffset, StartArrow.LinePosition.Y + tail + FirstOffset);
            thirdLine.StartPosition = new PointF(StartArrow.LinePosition.X - tempNode + SecondOffset, StartArrow.LinePosition.Y + tail - distance + ThirdOffset);
            secondLine.EndPosition = new PointF(StartArrow.LinePosition.X - tempNode + SecondOffset, StartArrow.LinePosition.Y + tail - distance + ThirdOffset);
            endLine.StartPosition = new PointF(EndArrow.LinePosition.X, EndArrow.LinePosition.Y - tail + ThirdOffset);
            thirdLine.EndPosition = new PointF(EndArrow.LinePosition.X, EndArrow.LinePosition.Y - tail + ThirdOffset);
            endLine.EndPosition = EndArrow.LinePosition;
            if (IsOver == false)
            {
                pen.Width = 1;
            }
            else
            {
                pen.Width = 1.6f;
            }
            foreach (var item in subLineList)
            {
                item.DrawLine(g, pen);
            }
        }

        /// <summary>
        /// 当前鼠标是否在该线集合中
        /// </summary>
        public bool IsOverFun(int x,int y)
        {
            for (int i = 0; i < subLineList.Count; i++)
            {
                if( !(subLineList[i] is StartLine) && !(subLineList[i] is EndLine))
                {
                    if (subLineList[i].IsOver(x, y) == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
