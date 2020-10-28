using System.Windows.Forms;

namespace DispenseAPP.Tools_MotionControl.CalibNeedle
{
    public partial class Tools_CalibNeedle : UserControl,IEvent
    {
        public Tools_CalibNeedle()
        {
            InitializeComponent();
        }

        public event ClickCancelDelegate _clickCancelButton;
        public event ClickOKButtonDelegate _clickOKButton;

        private void btn_OK_Click(object sender, System.EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, System.EventArgs e)
        {
            _clickCancelButton();
        }
    }
}
