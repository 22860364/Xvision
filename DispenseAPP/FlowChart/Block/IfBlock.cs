using DispenseAPP.FlowChart;
using System;
using System.Drawing;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    [Serializable]
    public class IfBlock : BlockItem
    {
        public IfBlock(Rectangle rectangleRegion, string customName,string systemName) : base(rectangleRegion, customName, systemName)
        {
            for (int i = 0; i < ArrowCount; i++)
            {
                Arrow arrowClass = i == 0 ? new Arrow(ArrowEnum.input, i) : new Arrow(ArrowEnum.ouput, i);
                ArrowList.Add(arrowClass);
            }
        }

        /// <summary>
        /// 用于序列化
        /// </summary>
        public IfBlock() { }

        public override PointF[] ShapePosition => new PointF[]
        {
            new PointF(Region.X + (Region.Width / 2), Region.Y),//上方
            new PointF(Region.X + Region.Width, Region.Y + (Region.Height / 2)),//右方
            new PointF(Region.X + (Region.Width / 2), Region.Y + Region.Height),//下方
            new PointF(Region.X, Region.Y + (Region.Height / 2)),//左方
        };

        int arrowCount = 4;
        public override int ArrowCount { get => arrowCount; set => arrowCount = value; }

        protected override void ChangeArrowPosition()
        {
            if (ArrowList.Count == 0)
            {
                return;
            }
            //画箭头
            ArrowList[0].Position = new PointF[] { new PointF(ShapePosition[0].X - (arrowLengthOfSide / 2), ShapePosition[0].Y - arrowHighWidth), new PointF(ShapePosition[0].X, ShapePosition[0].Y), new PointF(ShapePosition[0].X + (arrowLengthOfSide / 2), ShapePosition[0].Y - arrowHighWidth) };//画上箭头
            ArrowList[1].Position = new PointF[] { new PointF(ShapePosition[2].X - (arrowLengthOfSide / 2), ShapePosition[2].Y), new PointF(ShapePosition[2].X + (arrowLengthOfSide / 2), ShapePosition[2].Y), new PointF(ShapePosition[2].X, ShapePosition[2].Y + arrowHighWidth) };//画下箭头
            ArrowList[2].Position = new PointF[] { new PointF(ShapePosition[3].X, ShapePosition[3].Y - (arrowLengthOfSide / 2)), new PointF(ShapePosition[3].X, ShapePosition[3].Y + (arrowLengthOfSide / 2)), new PointF(ShapePosition[3].X - arrowHighWidth, ShapePosition[3].Y) };//画左箭头
            ArrowList[3].Position = new PointF[] { new PointF(ShapePosition[1].X, ShapePosition[1].Y - (arrowLengthOfSide / 2)), new PointF(ShapePosition[1].X, ShapePosition[1].Y + (arrowLengthOfSide / 2)), new PointF(ShapePosition[1].X + arrowHighWidth, ShapePosition[1].Y) };//画右箭头
            //确定直线的起点
            ArrowList[0].LinePosition = ShapePosition[0];
            ArrowList[1].LinePosition = ShapePosition[2];
            ArrowList[2].LinePosition = ShapePosition[3];
            ArrowList[3].LinePosition = ShapePosition[1];
        }


        public override BlockItem Execute()
        {
            LineItem chartLine = null;
            ConditionalJudgment _ifSwitchJudgeClass = ArrowList.Find(c => c.Port == 1).ConditionalJudgmentInstance;
            if (_ifSwitchJudgeClass != null && _ifSwitchJudgeClass.MeasureBlockName != null && _ifSwitchJudgeClass.MeasureValue != null)//首先不为null
            {
                BlockItem element = StaticPublicData.BlockItems[NameType.CustomName,_ifSwitchJudgeClass.MeasureBlockName];//找到普通算子块
                if (element != null)
                {
                    OperatorBlock normalBlock = element as OperatorBlock;
                    string str = null;
                    if (_ifSwitchJudgeClass.MeasureValue.Contains("-"))
                    {
                        IToolable itools = normalBlock.ToolList.Find(c => c.StepCustomName == _ifSwitchJudgeClass.MeasureValue.Split('-')[0]);//找到对应的算子块  这里需要考虑工具没有找到的情况  假设用户改了算子的名称
                        str = itools.GetType().GetProperty(_ifSwitchJudgeClass.MeasureValue.Split('-')[1]).GetValue(itools, null).ToString();
                    }
                    else
                    {
                        str = normalBlock.ExecuteState.ToString();
                    }
                    if (str == _ifSwitchJudgeClass.MeasureResult)
                    {
                        chartLine = StaticPublicData.LineItems.Find(s => s.StartBlock.Equals(this) && s.StartArrow.Equals(ArrowList[1]));
                    }
                    else
                    {
                        chartLine = StaticPublicData.LineItems.Find(s => s.StartBlock.Equals(this) && (s.StartArrow.Equals(ArrowList[2]) || s.StartArrow.Equals(ArrowList[3])));
                    }
                }
            }
            if (chartLine != null)
            {
                if (StaticPublicData.LineItems.Find(s => s.EndBlock.Equals(this)).StartBlock is OperatorBlock normalBlock && normalBlock != null)//找到该条件算子块的上一个算子块
                {
                    normalBlock.VisibleMessage = false;
                    if (chartLine.EndBlock.Equals(normalBlock))//条件算子块的从左侧或右侧又回到了条件算子块的上一个普通算子块
                    {
                        normalBlock.VisibleMessage = true;
                    }
                    else if (chartLine.EndBlock is OperatorBlock normal && normal != null && FindStartBlockChartLine(normal, out LineItem _chartline) && _chartline.EndBlock != null && _chartline.EndBlock.Equals(normalBlock))
                    {
                        normal.VisibleMessage = true;
                        normalBlock.VisibleMessage = true;
                    }
                }
                return chartLine.EndBlock;
            }
            else
            {
                return null;
            }
        }//方法结束
    }
}
