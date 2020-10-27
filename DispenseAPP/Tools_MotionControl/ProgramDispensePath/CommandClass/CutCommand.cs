using DispenseAPP.AboutMotionCard;
using System.Collections.Generic;

namespace DispenseAPP
{
    public class CutCommand :Command //剪切命令
    {
        private readonly List<ValueClass> _cutValueClassList;
        public CutCommand(List<ValueClass> CutValueClassList)
        {
            _cutValueClassList = CutValueClassList;
        }

        public override void Excute()
        {
            for(int i = _cutValueClassList.Count - 1; i >= 0; i--)
            {
                DG_Motion.Rows.RemoveAt(_cutValueClassList[i].RowIndex);
            }
        }

        public override void Undo()
        {
            for (int i = 0; i < _cutValueClassList.Count; i++)
            {
                DG_Motion.Rows.Insert(_cutValueClassList[i].RowIndex, _cutValueClassList[i].Value.Split(','));
                DG_Motion.Rows[_cutValueClassList[i].RowIndex].Selected = true;
            }
        }
    }
}
