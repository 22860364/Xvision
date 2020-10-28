namespace DispenseAPP
{
    public class EditCommand : Command
    {
        private readonly int _index;
        private string _newValue;
        private readonly string _oldValue;

        public EditCommand(int index,string oldValue,string newValue)
        {
            _index = index;
            _newValue = newValue;
            _oldValue = oldValue;
        }

        public override void Excute()
        {
            string[] valueArray = _newValue.Split(',');
            for (int i = 0; i < valueArray.Length ; i++)
            {
                DG_Motion.Rows[_index].Cells[i].Value = valueArray[i];
            }
        }

        public override void Undo()
        {
            string[] valueArray = _oldValue.Split(',');
            for (int i = 0; i < valueArray.Length; i++)
            {
                DG_Motion.Rows[_index].Cells[i].Value = valueArray[i];
            }
            DG_Motion.CurrentCell = DG_Motion[0, _index];
        }
    }
}
