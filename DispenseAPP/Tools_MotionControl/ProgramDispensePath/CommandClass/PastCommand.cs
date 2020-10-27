using DispenseAPP.AboutMotionCard;
using System.Collections.Generic;

namespace DispenseAPP
{
    public class PastCommand : Command
    {
        private readonly List<ValueClass> _copyCutValueClassList;
        private readonly List<ValueClass> _pastBeforeValueClassList;
        public PastCommand(List<ValueClass> CopyCutValueClass, List<ValueClass> pastBeforeValueClassList)
        {
            _copyCutValueClassList = CopyCutValueClass;
            _pastBeforeValueClassList = pastBeforeValueClassList;
        }

        public override void Excute()
        {
            for (int i = _pastBeforeValueClassList.Count - 1; i >= 0; i--)
            {
                DG_Motion.Rows.RemoveAt(_pastBeforeValueClassList[i].RowIndex);
            }
            int index = _pastBeforeValueClassList[0].RowIndex;
            DG_Motion.ClearSelection();
            for (int i = 0; i < _copyCutValueClassList.Count; i++)
            {
                index += i;
                DG_Motion.Rows.Insert(index, _copyCutValueClassList[i].Value.Split(','));
                DG_Motion.Rows[index].Selected = true;
            }
        }

        public override void Undo()
        {
            int index = _pastBeforeValueClassList[0].RowIndex+ _copyCutValueClassList.Count-1;
            for (int i = 0; i < _copyCutValueClassList.Count; i++)
            {
                index -= i;
                DG_Motion.Rows.RemoveAt(index);
            }
            DG_Motion.ClearSelection();
            for (int i = 0; i < _pastBeforeValueClassList.Count; i++)
            {
                DG_Motion.Rows.Insert(_pastBeforeValueClassList[i].RowIndex, _pastBeforeValueClassList[i].Value.Split(','));
                DG_Motion.Rows[_pastBeforeValueClassList[i].RowIndex].Selected = true;
            }
        }
    }
}
