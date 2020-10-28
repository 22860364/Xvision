using DispenseAPP.AboutMotionCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP.CommandClass
{
    public class CommandInvertOrder : Command//倒序命令
    {
        private readonly List<ValueClass> _invertOrderValueList;

        public CommandInvertOrder(List<ValueClass> invertOrderValueList)
        {
            _invertOrderValueList = invertOrderValueList;
        }

        public override void Excute()
        {
            for (int i = _invertOrderValueList.Count-1; i >= 0; i--)//遍历所有选择的行
            {
                int index = _invertOrderValueList.Count-1 - i;
                for (int j = 0; j < DG_Motion.ColumnCount; j++)
                {
                    DG_Motion.Rows[index].Cells[j].Value = _invertOrderValueList[i].Value.Split(',')[j];
                }
            }
        }

        public override void Undo()
        {
            for (int i = _invertOrderValueList.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < DG_Motion.ColumnCount; j++)
                {
                    DG_Motion.Rows[i].Cells[j].Value = _invertOrderValueList[i].Value.Split(',')[j];
                }
            }
        }
    }
}
