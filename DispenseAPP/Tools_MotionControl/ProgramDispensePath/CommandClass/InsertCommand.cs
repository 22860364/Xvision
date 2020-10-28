using System.Collections.Generic;
using System.Windows.Forms;

namespace DispenseAPP
{
    public class InsertCommand : Command
    {
        private readonly string _value;
        private readonly int _index;
        private readonly List<int> selectIndexList = new List<int>();
        public InsertCommand(string value, int index)
        {
            _value = value;
            _index = index;
            foreach (DataGridViewRow item in DG_Motion.SelectedRows)
            {
                selectIndexList.Add(item.Index);
            }
        }

        public override void Excute()
        {
            DG_Motion.Rows.Insert(_index, _value.Split(','));
            DG_Motion.ClearSelection();
            DG_Motion.Rows[_index].Selected = true;
        }

        public override void Undo()
        {
            DG_Motion.Rows.RemoveAt(_index);
            DG_Motion.ClearSelection();
            for (int i = 0; i < selectIndexList.Count; i++)
            {
                DG_Motion.Rows[selectIndexList[i]].Selected = true;
            }
        }
    }
}
