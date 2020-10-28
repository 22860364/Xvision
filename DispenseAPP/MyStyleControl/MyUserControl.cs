using System.Windows.Forms;
using System;

namespace DispenseAPP.MyStyleControl
{
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
        }

        public event Action<IToolable> ClickOKEvent;

        public event Action ClickCancelEvent;


        protected virtual void ClickOk(IToolable tools)
        {
            ClickOKEvent?.Invoke(tools);
        }

        protected virtual void ClickCancel()
        {
            ClickCancelEvent?.Invoke();
        }

        public virtual object GetStepResult()
        {
            return null;
        }

        public virtual bool ExecuteCheck()
        {
            return true;//如果返回为真 则表示检查通过
        }

        public virtual void GetResult()
        {

        }
    }
}
