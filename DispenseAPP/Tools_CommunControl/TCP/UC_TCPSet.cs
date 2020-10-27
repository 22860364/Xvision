using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using static DispenseAPP.CommonClass;
using System.Collections.Generic;
using System.Net;

namespace DispenseAPP.Tools_CommunControl.TCP
{
    public partial class UC_TCPSet : UserControl
    {
        public UC_TCPSet( FrmConfigCommun frmConfigCommun)
        {
            InitializeComponent();
            GetLocalIPAddress();
            lv_TCP_IP.SmallImageList = imageList1;
            foreach (var item in ServerDict.Keys)//遍历服务器和客户端的键值对集合 将开启的服务器和客户端添加进去
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item;
                if(ServerDict[item].Success)
                {
                    listViewItem.ImageIndex = 0;
                }
                else
                {
                    listViewItem.ImageIndex = 1;
                }
                lv_TCP_IP.Items.Add(listViewItem);
            }
            frmConfigCommun.ClickOKEvent += ClickOKButton;
        }

        private List<string> _addList = new List<string>();// 如果点击了添加 但是最后并没有点击确定 则将添加的全部删除 

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
                        cmb_IP.Items.Add(UnicastIPAddressInformation.Address.ToString());
                    }
                }
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)//添加 这里为什么允许客户端添加不同IP的同一端口的原因是：和不同的电脑连接
        {
            string name = null;
            if (rbtn_Serve.Checked == true)//服务器
            {
                name = "Server:" + num_PortNum.Value.ToString();
                if (!ServerDict.ContainsKey(name))//如果不存在 则添加服务器 
                {
                    AnsyncSocketTCPServer server = new AnsyncSocketTCPServer(new IPEndPoint(IPAddress.Parse(cmb_IP.SelectedItem.ToString()), Convert.ToInt32(num_PortNum.Value)));
                    server.Start();
                    ServerDict.Add(name, server);
                    AddListViewItem(name);
                    _addList.Add(name);
                }
            }
            else if (rbtn_Client.Checked == true)//客户端
            {

            }
        }

        private void AddListViewItem(string name)
        {
            ListViewItem listViewItem = new ListViewItem
            {
                Text = name
            };
            if (ServerDict[name].Success == true)
            {
                listViewItem.ImageIndex = 0;//成功
            }
            else
            {
                listViewItem.ImageIndex = 1;//失败
            }
            lv_TCP_IP.Items.Add(listViewItem);
        }

        private void Btn_Delete_Click(object sender, EventArgs e)//只是临时删除 当最后点击确定按钮后 才真正删除
        {
            if (lv_TCP_IP.SelectedItems.Count > 0)
            {
                string name = lv_TCP_IP.SelectedItems[0].Text;
                switch (name.Split(':')[0])
                {
                    case "Server":
                        if (ServerDict.ContainsKey(name))
                        {
                            lv_TCP_IP.Items.Remove(lv_TCP_IP.FindItemWithText(name));//从控件中删除
                            if (_addList.Contains(name))
                            {
                                _addList.Remove(name);
                            }
                        }
                        break;
                    case "Client":
                        break;
                }
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)//刷新
        {
            foreach (ListViewItem item in lv_TCP_IP.Items)
            {
                switch (item.Text.Split(':')[0])
                {
                    case "Server":
                        if (ServerDict[item.Text].Success)
                        {
                            item.ImageIndex = 0;
                        }
                        else
                        {
                            item.ImageIndex = 1;
                        }
                        break;
                    case "Client":
                        break;
                }
            }
        }

        public void ClickOKButton()//点击确定按钮 遍历当前控件的item项 不存在的则删除 
        {
            foreach (var item in ServerDict.Keys)
            {
                if (!lv_TCP_IP.Items.Contains(lv_TCP_IP.FindItemWithText(item)))
                {
                    ServerDict[item].Stop();
                    ServerDict.Remove(item);
                }
            }
        }

        public void ClickCancelButton()//点击取消按钮 保持进入窗口的状态  将进入窗口的所有操作都取消
        {
            foreach (var item in _addList)
            {
                if (ServerDict.ContainsKey(item))
                {
                    ServerDict[item].Stop();
                    ServerDict.Remove(item);
                }
            }
        }
    }
}
