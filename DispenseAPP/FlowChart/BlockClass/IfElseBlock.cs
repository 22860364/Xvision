using DispenseAPP.FlowChart;
using System;
using System.Drawing;
using System.Threading;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    [Serializable]
    public class IfElseBlock : Element
    {
        public IfElseBlock(Rectangle rectangleRegion, ProjectParamClass projectParam) : base(rectangleRegion, projectParam)
        {
            _shapeOfCollection = new PointF[4];
            for (int i = 0; i < _arrowCount; i++)
            {
                ArrowClass arrowClass;
                if (i == 0)
                {
                    arrowClass = new ArrowClass(ArrowEnum.input);
                }
                else
                {
                    arrowClass = new ArrowClass(ArrowEnum.ouput);
                }
                arrowClass.PortID = i;
                _arrowList.Add(arrowClass);
            }
            ChangePosition();
        }

        public override void ChangePosition()
        {
            //画图形
            _shapeOfCollection[0] = new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2), _rectangleRegion.Y);//上方
            _shapeOfCollection[2] = new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2), _rectangleRegion.Y + _rectangleRegion.Height);//下方
            _shapeOfCollection[3] = new PointF(_rectangleRegion.X, _rectangleRegion.Y + (_rectangleRegion.Height / 2));//左方
            _shapeOfCollection[1] = new PointF(_rectangleRegion.X + _rectangleRegion.Width, _rectangleRegion.Y + (_rectangleRegion.Height / 2));//右方
            //画箭头
            _arrowList[0]._arrowPoint = new PointF[] { new PointF(_shapeOfCollection[0].X - (arrowLengthOfSide / 2), _shapeOfCollection[0].Y - arrowHighWidth), new PointF(_shapeOfCollection[0].X, _shapeOfCollection[0].Y), new PointF(_shapeOfCollection[0].X + (arrowLengthOfSide / 2), _shapeOfCollection[0].Y - arrowHighWidth) };//画上箭头
            _arrowList[0]._arrowPosition = _shapeOfCollection[0];
            _arrowList[1]._arrowPoint = new PointF[] { new PointF(_shapeOfCollection[2].X - (arrowLengthOfSide / 2), _shapeOfCollection[2].Y), new PointF(_shapeOfCollection[2].X + (arrowLengthOfSide / 2), _shapeOfCollection[2].Y), new PointF(_shapeOfCollection[2].X, _shapeOfCollection[2].Y + arrowHighWidth) };//画下箭头
            _arrowList[1]._arrowPosition = _shapeOfCollection[2];
            _arrowList[2]._arrowPoint = new PointF[] { new PointF(_shapeOfCollection[3].X, _shapeOfCollection[3].Y - (arrowLengthOfSide / 2)), new PointF(_shapeOfCollection[3].X, _shapeOfCollection[3].Y + (arrowLengthOfSide / 2)), new PointF(_shapeOfCollection[3].X - arrowHighWidth, _shapeOfCollection[3].Y) };//画左箭头
            _arrowList[2]._arrowPosition = _shapeOfCollection[3];
            _arrowList[3]._arrowPoint = new PointF[] { new PointF(_shapeOfCollection[1].X, _shapeOfCollection[1].Y - (arrowLengthOfSide / 2)), new PointF(_shapeOfCollection[1].X, _shapeOfCollection[1].Y + (arrowLengthOfSide / 2)), new PointF(_shapeOfCollection[1].X + arrowHighWidth, _shapeOfCollection[1].Y) };//画右箭头
            _arrowList[3]._arrowPosition = _shapeOfCollection[1];
            //画名称
            fontRectangle = _rectangleRegion;
            //确定直线的起点
            _arrowList[0].LinePosition = _shapeOfCollection[0];
            _arrowList[1].LinePosition = _shapeOfCollection[2];
            _arrowList[2].LinePosition = _shapeOfCollection[3];
            _arrowList[3].LinePosition = _shapeOfCollection[1];
        }

        public override void Execute(Thread thread)
        {
            ChartLine chartLine = null;
            IfSwitchJudgeClass _ifSwitchJudgeClass = _arrowList.Find(c => c.PortID == 1)._ifSwitchJudgeClass;
            if (_ifSwitchJudgeClass != null && _ifSwitchJudgeClass.BlockName != null && _ifSwitchJudgeClass.MeasureValue != null)//首先不为null
            {
                Element element = _projectParam._flowChartList.Find(s => s.Name == _ifSwitchJudgeClass.BlockName);//找到普通算子块
                if (element != null)
                {
                    NormalBlock normalBlock = element as NormalBlock;
                    ITools itools = normalBlock.ToolsList.Find(c => c.BlockName == _ifSwitchJudgeClass.MeasureValue.Split('-')[0]);//找到对应的算子块
                   string str = itools.GetType().GetProperty(_ifSwitchJudgeClass.MeasureValue.Split('-')[1]).GetValue(itools, null).ToString();
                    if (str == _ifSwitchJudgeClass.MeasureResult)
                    {
                        chartLine = _projectParam._chartLineList.Find(s => s.StartBlock.Equals(this) && s.StartArrow.Equals(_arrowList[1]));
                    }
                    else
                    {
                        chartLine = _projectParam._chartLineList.Find(s => s.StartBlock.Equals(this) && (s.StartArrow.Equals(this._arrowList[2]) || (s.StartArrow.Equals(_arrowList[3]))));
                    }
                }
            }
            if (chartLine != null)
            {
                chartLine.EndBlock.Execute(thread);
            }
        }//方法结束
    }
}
