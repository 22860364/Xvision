using System.Collections.Generic;

namespace DispenseAPP.FlowChart.Block
{
    public class BlockItems : List<BlockItem>
    {
        /// <summary>
        /// 根据系统名称获得当前的Block
        /// </summary>
        /// <param name="name">名称</param>
        /// <returns></returns>
        public BlockItem this[NameType nameType, string name]
        {
            get
            {
                if (nameType == NameType.CustomName)
                {
                    return Find(c => c.CustomName == name);
                }
                else
                {
                    return Find(c => c.SystemName == name);
                }
            }
        }

        /// <summary>
        /// 获得所有的普通算子块
        /// </summary>
        /// <returns></returns>
        public List<BlockItem> GetAllOperator()
        {
            return FindAll(c => c is OperatorBlock);
        }
    }
}
