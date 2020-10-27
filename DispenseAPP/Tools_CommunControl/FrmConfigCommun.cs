using DispenseAPP.CustomControl;
using DispenseAPP.Tools_CommunControl.PLC;
using DispenseAPP.Tools_CommunControl.Serial;
using DispenseAPP.Tools_CommunControl.TCP;
using System;

namespace DispenseAPP.Tools_CommunControl
{
    public partial class FrmConfigCommun : FormM
    {
        private UC_TCPSet set_TCP;
        private UC_PLCSet plcEnt_Set;
        private UC_SerialSet serialSet;
        public event Action ClickOKEvent;
        public event Action ClickCancelEvent;

        public FrmConfigCommun(string type)
        {
            InitializeComponent();
            set_TCP = new UC_TCPSet(this);
            plcEnt_Set = new UC_PLCSet(this);
            serialSet = new UC_SerialSet(this);
            Lb_CommunType.SelectedIndex = Lb_CommunType.Items.IndexOf(type);
            ChangeCoommunUC(Lb_CommunType.SelectedItem.ToString());
        }

        private void ChangeCoommunUC(string type)
        {
            switch (type)
            {
                case "TCP/IP":
                    ControlClass.AddControlToPanel(set_TCP, Panel_Commun);
                    break;
                case "串口":
                    ControlClass.AddControlToPanel(serialSet, Panel_Commun);
                    break;
                case "Modbus":
                    break;
                case "三菱Q系列PLC":
                    ControlClass.AddControlToPanel(plcEnt_Set, Panel_Commun);
                    break;
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)//单击确定按钮 所有的操作都是有效的 通知所有Panel中的用户控件 相当于该类是事件的发布者 而在Panel中的用户控件时事件的订阅者
        {
            if(ClickOKEvent != null)
            {
                ClickOKEvent.Invoke();
            }
            Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)//之前所有的操作都是无效的
        {
            if(ClickCancelEvent != null)
            {
                ClickCancelEvent.Invoke();
            }
            Close();
        }

        private void Lb_CommunType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Lb_CommunType.SelectedItem !=null)
            {
                ChangeCoommunUC(Lb_CommunType.SelectedItem.ToString());
            }
        }
    }
}
