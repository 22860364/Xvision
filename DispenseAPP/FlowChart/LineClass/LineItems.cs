using System.Collections.Generic;

namespace DispenseAPP.FlowChart.LineClass
{
    public class LineItems:List<LineItem>
    {
        public LineItem this[LineBlockType blockType, BlockItem blockItem]
        {
            get
            {
                if(blockType == LineBlockType.StartBlock)
                {
                    return Find(c => c.StartBlock.Equals(blockItem));
                }
                else
                {
                    return Find(c => c.EndBlock.Equals(blockItem));
                }
            }
        }

        public LineItem this[LineArrowType arrowType, Arrow arrow]
        {
            get
            {
                if(arrowType == LineArrowType.StartArrow)
                {
                    return Find(c => c.StartArrow.Equals(arrow));
                }
                else
                {
                    return Find(c => c.EndArrow.Equals(arrow));
                }
            }
        }
    }
}
