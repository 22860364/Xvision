using DispenseAPP.AboutMotionCard;
using System.Collections.Generic;

namespace DispenseAPP
{
    public class DelCommand : Command
    {
        private readonly List<ValueClass> _deleteValueClassList;
        public DelCommand(List<ValueClass> deleteValueClassList)
        {
            _deleteValueClassList = deleteValueClassList;
        }

        public override void Excute()
        {
            for (int i = _deleteValueClassList.Count - 1; i >= 0; i--)
            {
                DG_Motion.Rows.RemoveAt(_deleteValueClassList[i].RowIndex);
            }
        }

        public override void Undo()
        {
            for (int i = 0; i < _deleteValueClassList.Count; i++)
            {
                DG_Motion.Rows.Insert(_deleteValueClassList[i].RowIndex, _deleteValueClassList[i].Value.Split(','));
                DG_Motion.Rows[_deleteValueClassList[i].RowIndex].Selected = true;
            }
        }
    }
}
