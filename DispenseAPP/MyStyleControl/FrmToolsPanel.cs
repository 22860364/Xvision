using DispenseAPP.CustomControl;
using System;

namespace DispenseAPP.MyStyleControl
{
    public partial class FrmToolsPanel : FormM  //在这个界面中需要接受到工具控件的点击事件
    {
        public event Action<IToolable> ClickOKEvent;

        public FrmToolsPanel(MyUserControl myControl,string text)
        {
            InitializeComponent();
            ControlClass.AddControlToPanel(myControl, Panel_Tools);
            myControl.ClickOKEvent += Control_ClickOKEvent;
            myControl.ClickCancelEvent += MyControl_ClickCancelEvent;
            Text = text;
        }

        private void MyControl_ClickCancelEvent()//点击取消
        {
            Close();
        }

        private void Control_ClickOKEvent(IToolable toolsParam)//点击确定
        {
            ClickOKEvent(toolsParam);
            Close();
        }
    }
}
