using DispenseAPP.CustomControl;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace DispenseAPP.AboutMotionCard.ConfigCardClass.ZMotion
{
    public partial class FrmConfigIPAddress : FormM
    {
        private IPAddressClass _zmotionConfig;

        public FrmConfigIPAddress(ref IPAddressClass zmotionConfig)
        {
            InitializeComponent();
            GetLocalIPAddress();
            if (zmotionConfig != null)
            {
                Cmb_IPAddress.SelectedItem = zmotionConfig.IPAddress;
                _zmotionConfig = zmotionConfig;
            }
            else
            {
                zmotionConfig = new IPAddressClass();
                _zmotionConfig = zmotionConfig;
            }
        }

        private void GetLocalIPAddress()//获得本机所有网卡的IP地址
        {
            NetworkInterface[] NetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();//获得本地计算机上网络接口的对象
            foreach (NetworkInterface NetworkIntf in NetworkInterfaces)
            {
                IPInterfaceProperties IPInterfaceProperties = NetworkIntf.GetIPProperties();
                UnicastIPAddressInformationCollection UnicastIPAddressInformationCollection = IPInterfaceProperties.UnicastAddresses;
                foreach (UnicastIPAddressInformation UnicastIPAddressInformation in UnicastIPAddressInformationCollection)
                {
                    if (UnicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        Cmb_IPAddress.Items.Add(UnicastIPAddressInformation.Address.ToString());
                    }
                }
            }
        }

        private void Btn_OK_Click(object sender, System.EventArgs e)
        {
            _zmotionConfig.IPAddress = Cmb_IPAddress.SelectedItem.ToString();
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void Btn_Cancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
