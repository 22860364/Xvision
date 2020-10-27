using DispenseAPP.AboutData;
using DispenseAPP.Tools_CommunControl.PLC.DLL;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_CommunControl.PLC
{
    public partial class UC_PLCSet : UserControl
    {
        private List<PLCDataClass> plc_CommunDataList = new List<PLCDataClass>();
        public UC_PLCSet(FrmConfigCommun frmConfigCommun)
        {
            InitializeComponent();
            GetLocalIPAddress();
            frmConfigCommun.ClickOKEvent += ClickOKButton;
            frmConfigCommun.ClickCancelEvent += ClickCancelButton;
            foreach (string item in QsAscDict.Keys)//遍历连接的PLC
            {
                AddListViewItem(item, QsAscDict[item].ConnectState);
            }
        }

        public void GetLocalIPAddress()//获得本机所有网卡的IP地址
        {
            NetworkInterface[] NetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface NetworkIntf in NetworkInterfaces)
            {
                IPInterfaceProperties IPInterfaceProperties = NetworkIntf.GetIPProperties();
                UnicastIPAddressInformationCollection UnicastIPAddressInformationCollection = IPInterfaceProperties.UnicastAddresses;
                foreach (UnicastIPAddressInformation UnicastIPAddressInformation in UnicastIPAddressInformationCollection)
                {
                    if (UnicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        Cmb_LocalIP.Items.Add(UnicastIPAddressInformation.Address.ToString());
                        Cmb_RemoteIP.Items.Add(UnicastIPAddressInformation.Address.ToString());
                    }
                }
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)//添加
        {
            if (Cmb_RemoteIP.Text != "" && Cmb_LocalIP.Text != "")
            {
                string name = "PLC:" + Cmb_RemoteIP.Text + ":" + Num_RemotePort.Value;
                PLCDataClass plc_CommunDataClass = new PLCDataClass(Cmb_LocalIP.Text, Cmb_RemoteIP.Text, (ushort)Num_RemotePort.Value);
                plc_CommunDataList.Add(plc_CommunDataClass);//添加到项目参数中 下次程序启动可以直接连接
                Qs_Ent_Asc_Class qs_Ent_Asc_Class = new Qs_Ent_Asc_Class();
                if (qs_Ent_Asc_Class.Start(Cmb_LocalIP.Text, Cmb_RemoteIP.Text, (ushort)Num_RemotePort.Value) == true)//连接成功 添加到ListView
                {
                    AddListViewItem(name, true);
                }
                else
                {
                    AddListViewItem(name, false);
                }
            }
            else
            {
                MessageBox.Show("IP地址不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)//删除
        {
            if (Lv_PLC.SelectedItems != null && Lv_PLC.SelectedItems.Count > 0)
            {
                //首先 需要从ListView中将该项清除
                Lv_PLC.Items.Remove(Lv_PLC.FindItemWithText(Lv_PLC.SelectedItems[0].Text));
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)//刷新
        {

        }

        private void AddListViewItem(string name, bool state)
        {
            ListViewItem listViewItem = new ListViewItem
            {
                Text = name
            };
            if (state == true)
            {
                listViewItem.ImageIndex = 0;//成功
            }
            else
            {
                listViewItem.ImageIndex = 1;//失败
            }
            Lv_PLC.Items.Add(listViewItem);
            listViewItem.Selected = true;//设定选中         
        }

        public void ClickOKButton()//点击确定按钮 进入窗体后的所有操作为有效
        {

        }

        public void ClickCancelButton()//点击取消按钮 进入窗体后的所有操作为无效
        {

        }
    }
}
