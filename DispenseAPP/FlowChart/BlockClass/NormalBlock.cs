using DispenseAPP;
using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    [Serializable]
    public class NormalBlock : Element
    {
        public NormalBlock(Rectangle rectangleRegion, ProjectParamClass projectParam) : base(rectangleRegion, projectParam)
        {
            _shapeOfCollection = new PointF[4];
            ChangePosition();
            _arrowList.Add(_arrowClassUp);
            _arrowList.Add(_arrowClassDown);
        }

        private ArrowClass _arrowClassUp = new ArrowClass(ArrowEnum.input);//上箭头

        private ArrowClass _arrowClassDown = new ArrowClass(ArrowEnum.ouput);//下箭头

        public List<ITools> ToolsList = new List<ITools>();//存放工具的集合

        public string WindowIndex { get; set; }//窗口索引

        public override void Draw(string name, Graphics g)
        {
            if (_normalBolockIsSelected == true)
            {
                if (this.IsStartBlock == true)
                {
                    g.FillRectangle(Brushes.LightGreen, _rectangleRegion.X, _rectangleRegion.Y, _rectangleRegion.Width + 1, _rectangleRegion.Height + 1);
                }
                else
                {
                    g.FillRectangle(Brushes.CadetBlue, _rectangleRegion.X, _rectangleRegion.Y, _rectangleRegion.Width + 1, _rectangleRegion.Height + 1);
                }
            }
            base.Draw(name, g);
        }

        public override void ChangePosition()
        {
            //画箭头
            _arrowClassUp._arrowPoint = new PointF[] { new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2) - arrowLengthOfSide / 2, _rectangleRegion.Y - arrowHighWidth), new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2) + arrowLengthOfSide / 2, _rectangleRegion.Y - arrowHighWidth), new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2), _rectangleRegion.Y) };
            _arrowClassUp._arrowPosition = new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2), _rectangleRegion.Y);
            _arrowClassDown._arrowPoint = new PointF[] { new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2) - arrowLengthOfSide / 2, _rectangleRegion.Y + _rectangleRegion.Height), new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2) + arrowLengthOfSide / 2, _rectangleRegion.Y + _rectangleRegion.Height), new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2), _rectangleRegion.Y + _rectangleRegion.Height + arrowHighWidth) };
            _arrowClassDown._arrowPosition = new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2), _rectangleRegion.Y + _rectangleRegion.Height);
            //画图形
            _shapeOfCollection[0] = new PointF(_rectangleRegion.X, _rectangleRegion.Y);
            _shapeOfCollection[1] = new PointF(_rectangleRegion.X + _rectangleRegion.Width, _rectangleRegion.Y);
            _shapeOfCollection[2] = new PointF(_rectangleRegion.X + _rectangleRegion.Width, _rectangleRegion.Y + _rectangleRegion.Height);
            _shapeOfCollection[3] = new PointF(_rectangleRegion.X, _rectangleRegion.Y + _rectangleRegion.Height);
            //画名称
            fontRectangle = _rectangleRegion;
            //确定直线的终点
            _arrowClassUp.LinePosition = new PointF(_rectangleRegion.X + _rectangleRegion.Width / 2, _rectangleRegion.Y);
            //确定直线的起点
            _arrowClassDown.LinePosition = new PointF(_rectangleRegion.X + _rectangleRegion.Width / 2, _rectangleRegion.Y + _rectangleRegion.Height);
        }

        public override void Execute(Thread thread)
        {
            foreach (ITools item in ToolsList)//执行每个工具
            {
                if(WindowIndex != "不显示")
                {
                    item.ComputerExecuteTime(WindowIndexDic[Convert.ToInt32(WindowIndex)]);
                }
                else
                {
                    item.ComputerExecuteTime(null);
                }
            }
            ChartLine chartLine = _projectParam._chartLineList.Find(s => s.StartBlock.Equals(this));
            if (chartLine != null)
            {
                chartLine.EndBlock.Execute(thread);
            }            
        }
    }
}
