using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_CommunControl.Serial
{
    public partial class Tools_Serial : UserControl, IEvent
    {
        private SerialClass _serialClass;
        public event ClickOKButtonDelegate _clickOKButton;
        public event ClickCancelDelegate _clickCancelButton;

        public Tools_Serial(SerialClass serialClass)
        {
            InitializeComponent();
            _serialClass = serialClass;
            txt_Name.Text = _serialClass.BlockName;
            InitialCommun(true);
        }

        private void InitialCommun(bool state)//初始化通讯
        {
            if (SerialDict.Count > 0)
            {
                Cmb_Connect.Items.Clear();
                foreach (string item in SerialDict.Keys)//遍历添加的PLC通讯
                {
                    Cmb_Connect.Items.Add(item);
                }
                if (_serialClass.Connect != "" && SerialDict.ContainsKey(_serialClass.Connect))
                {
                    Cmb_Connect.SelectedIndex = Cmb_Connect.Items.IndexOf(_serialClass.Connect);
                }
                else if (_serialClass.Connect != "" && !SerialDict.ContainsKey(_serialClass.Connect))
                {
                    if(state == true)
                    {
                        Cmb_Connect.Items.Add("???");
                        Cmb_Connect.SelectedIndex = Cmb_Connect.Items.IndexOf("???");
                    }
                    else
                    {
                        Cmb_Connect.SelectedIndex = 0;
                    }
                }
                else
                {
                    Cmb_Connect.SelectedIndex = 0;
                }
                SetControlEnable(true);
            }
            else//设置页面的使能状态
            {
                SetControlEnable(false);
            }
        }

        private void SetControlEnable(bool state)//设置控件的使能状态
        {
            Cb_ClearCache.Enabled = state;
            Cb_EnableTiemOut.Enabled = state;
            Num_TimeOut.Enabled = state;
            Panel_Data.Enabled = state;
        }

        private void Btn_OK_Click(object sender, System.EventArgs e)
        {
            _clickOKButton(_serialClass);
        }

        private void Btn_Cancel_Click(object sender, System.EventArgs e)
        {
            _clickCancelButton();
        }

        private void Btn_Set_Click(object sender, System.EventArgs e)
        {
            FrmConfigCommun frmConfigCommun = new FrmConfigCommun("串口");
            frmConfigCommun.ShowDialog();
            InitialCommun(false);
        }
    }
}
