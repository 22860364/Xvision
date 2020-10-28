using DispenseAPP.FlowChart;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    [Serializable]
    public class SwitchBlock : Element
    {
        public SwitchBlock(Rectangle rectangleRegion, ProjectParamClass projectParam) : base(rectangleRegion, projectParam)
        {
            _shapeOfCollection = new PointF[6];
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
            _shapeOfCollection[0] = new PointF(_rectangleRegion.X, _rectangleRegion.Y + _rectangleRegion.Height / 2);//左中
            _shapeOfCollection[1] = new PointF(_rectangleRegion.X + arrowLengthOfSide, _rectangleRegion.Y);//左上
            _shapeOfCollection[2] = new PointF(_rectangleRegion.X + _rectangleRegion.Width - arrowLengthOfSide, _rectangleRegion.Y);//右上
            _shapeOfCollection[3] = new PointF(_rectangleRegion.X + _rectangleRegion.Width, _rectangleRegion.Y + _rectangleRegion.Height / 2);//右中
            _shapeOfCollection[4] = new PointF(_rectangleRegion.X + _rectangleRegion.Width - arrowLengthOfSide, _rectangleRegion.Y + _rectangleRegion.Height);//右下
            _shapeOfCollection[5] = new PointF(_rectangleRegion.X + arrowLengthOfSide, _rectangleRegion.Y + _rectangleRegion.Height);//左下
            //画名称
            fontRectangle = _rectangleRegion;
            width = (_rectangleRegion.Width - (arrowLengthOfSide * 2) - (distanceOfEdge * 2) - (arrowLengthOfSide * (_arrowCount - 1))) / (_arrowCount - 2);//计算间距
            for (int i = 0; i < _arrowList.Count; i++)
            {
                if (i == 0)
                {
                    _arrowList[i]._arrowPoint = new PointF[] { new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2) - (arrowLengthOfSide / 2), _rectangleRegion.Y - arrowHighWidth), new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2) + (arrowLengthOfSide / 2), _rectangleRegion.Y - arrowHighWidth), new PointF(_rectangleRegion.X + _rectangleRegion.Width / 2, _rectangleRegion.Y) };
                    _arrowList[i].LinePosition = new PointF(_rectangleRegion.X + (_rectangleRegion.Width / 2), _rectangleRegion.Y);
                }
                else
                {
                    int index = i - 1;
                    _arrowList[i]._arrowPoint = new PointF[] { new PointF(_rectangleRegion.X + arrowLengthOfSide + distanceOfEdge + index * arrowLengthOfSide + index * width, _rectangleRegion.Y + _rectangleRegion.Height), new PointF(_rectangleRegion.X + arrowLengthOfSide + distanceOfEdge + (index * arrowLengthOfSide) + (index * width) + arrowLengthOfSide, _rectangleRegion.Y + _rectangleRegion.Height), new PointF(_rectangleRegion.X + arrowLengthOfSide + distanceOfEdge + (index * arrowLengthOfSide) + (index * width) + (arrowLengthOfSide / 2), _rectangleRegion.Y + _rectangleRegion.Height + arrowLengthOfSide) };
                    _arrowList[i].LinePosition = new PointF(_rectangleRegion.X + arrowLengthOfSide + distanceOfEdge + (index * arrowLengthOfSide) + (index * width) + (arrowLengthOfSide / 2), _rectangleRegion.Y + _rectangleRegion.Height);
                }
            }
        }

        public override void Execute(Thread thread)
        {
            ChartLine chartLine = null;
            List<ArrowClass> arrowList = _arrowList.FindAll(i => i.PortID > 0 && i.PortID < _arrowList.Count - 1 && i._ifSwitchJudgeClass != null);//找到所有的端口
            foreach (ArrowClass item in arrowList)//遍历所有端口 如果集合为0 则自动停止
            {
                if(item._ifSwitchJudgeClass.BlockName != null &&  item._ifSwitchJudgeClass.MeasureValue != null)//算子块不为空并且测量值不为空
                {
                    Element element = _projectParam._flowChartList.Find(s => s.Name == item._ifSwitchJudgeClass.BlockName);//找到算子块
                    if(element != null)
                    {
                        NormalBlock normalBlock = element as NormalBlock;
                        ITools itools = normalBlock.ToolsList.Find(c => c.BlockName == item._ifSwitchJudgeClass.MeasureValue.Split('-')[0]);
                        bool b = Convert.ToBoolean(itools.GetType().GetProperty(item._ifSwitchJudgeClass.MeasureValue.Split('-')[1]));
                        if(b.ToString() == item._ifSwitchJudgeClass.MeasureResult)
                        {
                            chartLine = _projectParam._chartLineList.Find(c => c.StartArrow == item);
                            break;
                        }                     
                    }
                }
            }
            if(chartLine != null)
            {
                chartLine.EndBlock.Execute(thread);
            }
        }
    }
}
