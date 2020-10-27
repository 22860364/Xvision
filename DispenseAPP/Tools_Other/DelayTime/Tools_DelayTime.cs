using System.Windows.Forms;
using DispenseAPP.Tools_Other.DelayTime;

namespace DispenseAPP.Tools_Other
{
    public partial class Tools_DelayTime : UserControl,IEvent 
    {
        private DelayTimeClass _delayTimeClass;
        public event ClickOKButtonDelegate _clickOKButton;
        public event ClickCancelDelegate _clickCancelButton;
     
        public Tools_DelayTime(DelayTimeClass delayTimeClass)
        {
            InitializeComponent();
            _delayTimeClass = delayTimeClass;
            txt_Name.Text = _delayTimeClass.BlockName;
            num_Time.Value = _delayTimeClass.Time;
        }

        private void btn_OK_Click(object sender, System.EventArgs e)
        {
            _delayTimeClass.BlockName = txt_Name.Text;
            _delayTimeClass.Time = (int)num_Time.Value;
            _clickOKButton(_delayTimeClass);
        }

        private void btn_Cancel_Click(object sender, System.EventArgs e)
        {
            _clickCancelButton();
        }
    }
}
