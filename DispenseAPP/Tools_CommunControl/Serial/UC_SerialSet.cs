using System;
using System.Windows.Forms;
using System.IO.Ports;
using static DispenseAPP.CommonClass;
using DispenseAPP.AboutData;
using System.Collections.Generic;

namespace DispenseAPP.Tools_CommunControl.Serial
{
    public partial class UC_SerialSet : UserControl
    {
        private SerialDataClass currentSerialDataClass = null;
        private List<SerialDataClass> serialDataClassList = new List<SerialDataClass>();
        public UC_SerialSet(FrmConfigCommun frmConfigCommun)
        {
            InitializeComponent();
            string[] PortNames = SerialPort.GetPortNames();
            foreach (string item in PortNames)
            {
                SerialDataClass serialDataClass = null;
                if (StaticProjectParamClass._serialList.FindIndex(c => c.PortName == item) == -1) //代表集合中没有串口的参数
                {
                    serialDataClass = new SerialDataClass
                    {
                        PortName = item
                    };
                    StaticProjectParamClass._serialList.Add(serialDataClass);
                }
                if (!SerialDict.ContainsKey(item))//不包含键则创建对象
                {
                    SerialPort serialPort = new SerialPort(item, serialDataClass.BaudRate, (Parity)Enum.Parse(typeof(Parity), serialDataClass.Parity), serialDataClass.DataBits, (StopBits)Enum.Parse(typeof(StopBits), serialDataClass.StopBits))
                    {
                        Handshake = (Handshake)Enum.Parse(typeof(Handshake), serialDataClass.HandShakeControl)
                    };
                    SerialDict.Add(item, serialPort);
                }
            }
            if (PortNames != null)
            {
                gb_SerialSet.Enabled = true;
                Cmb_PortName.Items.AddRange(PortNames);//向控件中添加串口名称
                foreach (SerialDataClass item in StaticProjectParamClass._serialList)
                {
                    serialDataClassList.Add((SerialDataClass)item.Clone());
                }
                Cmb_PortName.SelectedIndex = 0;//默认为第一个串口
            }
            else
            {
                gb_SerialSet.Enabled = false;
            }
            frmConfigCommun.ClickOKEvent += ClickOKButton;//注册点击确定按钮事件
            frmConfigCommun.ClickCancelEvent += ClickCancelButton;//注册点击取消按钮事件
        }

        public void ClickOKButton()//点击确定按钮 所有操作生效  将串口对象添加到键值对集合中
        {
            StaticProjectParamClass._serialList.Clear();
            foreach (SerialDataClass item in serialDataClassList)
            {
                StaticProjectParamClass._serialList.Add((SerialDataClass)item.Clone());
                SerialDict[item.PortName].BaudRate = item.BaudRate;
                SerialDict[item.PortName].Parity = (Parity)Enum.Parse(typeof(Parity), item.Parity);
                SerialDict[item.PortName].DataBits = item.DataBits;
                SerialDict[item.PortName].StopBits = (StopBits)Enum.Parse(typeof(StopBits), item.StopBits);
                SerialDict[item.PortName].Handshake = (Handshake)Enum.Parse(typeof(Handshake), item.HandShakeControl);
                SetSerialOpenClose(SerialDict[item.PortName], item.State);
            }
        }

        private void SetSerialOpenClose(SerialPort serialPort, bool state)
        {
            if (state)
            {
                if (serialPort.IsOpen == false)
                {
                    serialPort.Open();
                }
            }
            else
            {
                if (serialPort.IsOpen == true)
                {
                    serialPort.Close();
                }
            }
        }

        public void ClickCancelButton()//点击取消按钮 所有操作都取消
        {
            foreach (SerialDataClass item in StaticProjectParamClass._serialList)
            {
                if (SerialDict.ContainsKey(item.PortName))
                {
                    SetSerialOpenClose(SerialDict[item.PortName], item.State);
                }
            }
        }

        private void Cb_Enable_CheckedChanged(object sender, EventArgs e)//启用状态的改变
        {
            if (Cb_Enable.Checked)//如果COM口的状态设置为True 则Open 如果设置为false 先不关闭 点击确定或取消再关闭
            {
                if (SerialDict[Cmb_PortName.Text].IsOpen) //如果串口已经打开了 则弹出对话框 并将状态改变
                {
                    MessageBox.Show("串口连接失败，请确认此串口是否被占用！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    Cb_Enable.Checked = false;
                }
                else//只有当该串口没有打开的情况下才打开
                {
                    SerialDict[Cmb_PortName.Text].Open();
                }
            }
            currentSerialDataClass.State = Cb_Enable.Checked;
        }

        private void Cmb_PortName_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSerialDataClass = serialDataClassList.Find(c => c.PortName == Cmb_PortName.Text);
            if (currentSerialDataClass != null)
            {
                Cb_Enable.Checked = currentSerialDataClass.State;
                Cmb_BaudRate.SelectedIndex = Cmb_BaudRate.Items.IndexOf(currentSerialDataClass.BaudRate.ToString());
                Cmb_HandShake.SelectedIndex = Cmb_HandShake.Items.IndexOf(currentSerialDataClass.HandShakeControl);
                Cmb_StopBits.SelectedIndex = Cmb_StopBits.Items.IndexOf(currentSerialDataClass.StopBits);
                Cmb_Parity.SelectedIndex = Cmb_Parity.Items.IndexOf(currentSerialDataClass.Parity);
                Cmb_DataBit.SelectedIndex = Cmb_DataBit.Items.IndexOf(currentSerialDataClass.DataBits.ToString());
            }
        }

        private void Cmb_BaudRate_SelectedIndexChanged(object sender, EventArgs e)//波特率
        {
            currentSerialDataClass.BaudRate = Convert.ToInt32(Cmb_BaudRate.Text.Trim());
        }

        private void Cmb_HandShake_SelectedIndexChanged(object sender, EventArgs e)//握手协议控制
        {
            currentSerialDataClass.HandShakeControl = Cmb_HandShake.Text;
        }

        private void Cmb_StopBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSerialDataClass.StopBits = Cmb_StopBits.Text;
        }

        private void Cmb_Parity_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSerialDataClass.Parity = Cmb_Parity.Text;
        }

        private void Cmb_DataBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSerialDataClass.Parity = Cmb_DataBit.Text;
        }
    }
}
