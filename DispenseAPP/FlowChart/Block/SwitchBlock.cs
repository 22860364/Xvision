using System;
using System.Collections.Generic;
using System.Drawing;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    [Serializable]
    public class SwitchBlock : BlockItem
    {
        public SwitchBlock(Rectangle rectangleRegion,string name,string systemName) : base(rectangleRegion,name,systemName)
        {
            for (int i = 0; i < ArrowCount; i++)
            {
                Arrow arrowClass = i == 0 ? new Arrow(ArrowEnum.input,i) : new Arrow(ArrowEnum.ouput,i);
                ArrowList.Add(arrowClass);
            }
        }

        /// <summary>
        /// 用于序列化
        /// </summary>
        public SwitchBlock(){}

        public override PointF[] ShapePosition => new PointF[]
        {
            new PointF(Region.X, Region.Y + Region.Height / 2),//左中
            new PointF(Region.X + arrowLengthOfSide, Region.Y),//左上
            new PointF(Region.X + Region.Width - arrowLengthOfSide, Region.Y),//右上
            new PointF(Region.X + Region.Width, Region.Y + Region.Height / 2),//右中
            new PointF(Region.X + Region.Width - arrowLengthOfSide, Region.Y + Region.Height),//右下
            new PointF(Region.X + arrowLengthOfSide, Region.Y + Region.Height),//左下
        };

        int arrowCount = 4;

        public override int ArrowCount { get => arrowCount; set => arrowCount = value; }

        public override float Width => (Region.Width - (arrowLengthOfSide * 2) - (distanceOfEdge * 2) - (arrowLengthOfSide * (ArrowCount - 1))) / (ArrowCount - 2);

        protected override void ChangeArrowPosition()
        {
            for (int i = 0; i < ArrowList.Count; i++)
            {
                if (i == 0)
                {
                    ArrowList[i].Position = new PointF[] { new PointF(Region.X + (Region.Width / 2) - (arrowLengthOfSide / 2), Region.Y - arrowHighWidth), new PointF(Region.X + (Region.Width / 2) + (arrowLengthOfSide / 2), Region.Y - arrowHighWidth), new PointF(Region.X + Region.Width / 2, Region.Y) };
                    ArrowList[i].LinePosition = new PointF(Region.X + (Region.Width / 2), Region.Y);
                }
                else
                {
                    int index = i - 1;
                    ArrowList[i].Position = new PointF[] { new PointF(Region.X + arrowLengthOfSide + distanceOfEdge + index * arrowLengthOfSide + index * Width, Region.Y + Region.Height), new PointF(Region.X + arrowLengthOfSide + distanceOfEdge + (index * arrowLengthOfSide) + (index * Width) + arrowLengthOfSide, Region.Y + Region.Height), new PointF(Region.X + arrowLengthOfSide + distanceOfEdge + (index * arrowLengthOfSide) + (index * Width) + (arrowLengthOfSide / 2), Region.Y + Region.Height + arrowLengthOfSide) };
                    ArrowList[i].LinePosition = new PointF(Region.X + arrowLengthOfSide + distanceOfEdge + (index * arrowLengthOfSide) + (index * Width) + (arrowLengthOfSide / 2), Region.Y + Region.Height);
                }
            }
        }

        public override BlockItem Execute()
        {
            LineItem chartLine = null;
            List<Arrow> arrowList = ArrowList.FindAll(i => i.Port > 0 && i.Port < ArrowList.Count - 1 && i.ConditionalJudgmentInstance != null);//找到所有的端口
            foreach (Arrow item in arrowList)//遍历所有端口 如果集合为0 则自动停止
            {
                if(item.ConditionalJudgmentInstance.MeasureBlockName != null &&  item.ConditionalJudgmentInstance.MeasureValue != null)//算子块不为空并且测量值不为空
                {
                    BlockItem element = StaticPublicData.BlockItems[NameType.CustomName,item.ConditionalJudgmentInstance.MeasureBlockName];//找到算子块
                    if(element != null)
                    {
                        OperatorBlock normalBlock = element as OperatorBlock;
                        IToolable itools = normalBlock.ToolList.Find(c => c.StepCustomName == item.ConditionalJudgmentInstance.MeasureValue.Split('-')[0]);
                        bool b = Convert.ToBoolean(itools.GetType().GetProperty(item.ConditionalJudgmentInstance.MeasureValue.Split('-')[1]));
                        if(b.ToString() == item.ConditionalJudgmentInstance.MeasureResult)
                        {
                            chartLine = StaticPublicData.LineItems.Find(c => c.StartArrow == item);
                            break;
                        }                     
                    }
                }
            }
            if(chartLine != null)
            {
                return chartLine.EndBlock;
            }
            else
            {
                return null;
            }
        }
    }
}
