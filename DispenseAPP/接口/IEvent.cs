namespace DispenseAPP
{
    public interface IEvent
    {
        event ClickOKButtonDelegate _clickOKButton;

        event ClickCancelDelegate _clickCancelButton;
    }
}
