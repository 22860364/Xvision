namespace DispenseAPP
{
    public class MoveUpCommand : Command//选中的单行或多行与上一行交换
    {
        private readonly int _upBeforeIndex;
        private readonly int _upLaterIndex;
        private readonly string _value;

        public MoveUpCommand(int dowmBeforeIndex, int downLaterIndex, string value)
        {
            _upBeforeIndex = dowmBeforeIndex;
            _upLaterIndex = downLaterIndex;
            _value = value;
        }

        public override void Excute()
        {
            DG_Motion.Rows.RemoveAt(_upBeforeIndex);
            DG_Motion.Rows.Insert(_upLaterIndex, _value.Split(','));
        }

        public override void Undo()
        {
            DG_Motion.Rows.RemoveAt(_upLaterIndex);
            DG_Motion.Rows.Insert(_upBeforeIndex, _value.Split(','));
        }
    }
}
