using System;
using System.Windows.Forms;
using DispenseAPP.Tools_CommunControl.TCP;
using DispenseAPP.Tools_CommunControl.PLC;
using DispenseAPP.Tools_CommunControl.Serial;

namespace DispenseAPP.Tools_CommunControl
{
    public partial class UC_Commun_Tools : UserControl
    {
        public event ClickToolsDelegate ClickToolsEvent;

        public UC_Commun_Tools()
        {
            InitializeComponent();
        }

        private void Lbl_TCPIP_Click(object sender, EventArgs e)
        {
            ClickToolsEvent(ToolsNameEnum.TCP_IP, new TCP_IP_Class());
        }

        private void Lbl_PLC_Click(object sender, EventArgs e)
        {
            ClickToolsEvent(ToolsNameEnum.PLC, new PLC_CommunClass());
        }

        private void Lbl_Serial_Click(object sender, EventArgs e)
        {
            ClickToolsEvent(ToolsNameEnum.Serial, new SerialClass());
        }
    }
}
