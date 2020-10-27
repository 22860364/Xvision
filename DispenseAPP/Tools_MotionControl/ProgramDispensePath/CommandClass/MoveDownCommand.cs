namespace DispenseAPP
{
    public class MoveDownCommand : Command //选中的单行或多行与下一行交换
    {
        private readonly int _downBeforeIndex;
        private readonly int _downLaterIndex;
        private readonly string _value;

        public MoveDownCommand(int dowmBeforeIndex, int downLaterIndex, string value)
        {
            _downBeforeIndex = dowmBeforeIndex;
            _downLaterIndex = downLaterIndex;
            _value = value; 
        }

        public override void Excute() //删除下面的那行 然后再插入
        {
            DG_Motion.Rows.RemoveAt(_downBeforeIndex);
            DG_Motion.Rows.Insert(_downLaterIndex, _value.Split(','));
        }

        public override void Undo()
        {
            DG_Motion.Rows.RemoveAt(_downLaterIndex);
            DG_Motion.Rows.Insert(_downBeforeIndex, _value.Split(','));
        }
    }
}
