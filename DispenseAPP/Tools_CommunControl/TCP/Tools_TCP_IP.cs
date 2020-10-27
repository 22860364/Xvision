using DispenseAPP.AboutData;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_CommunControl.TCP
{
    public partial class Tools_TCP_IP : UserControl, IEvent
    {
        public event ClickCancelDelegate _clickCancelButton;
        public event ClickOKButtonDelegate _clickOKButton;
        private TCP_IP_Class _TCPIPClass;

        public Tools_TCP_IP(TCP_IP_Class TCPIPClass)
        {
            InitializeComponent();
            _TCPIPClass = TCPIPClass;
            InitialControlDefaultValue();
            InitialReferenceData();
            InitialCommun(true);
        }

        private void InitialControlDefaultValue()//初始化控件默认值
        {
            //基本
            txt_Name.Text = _TCPIPClass.BlockName;
            cb_EnableTiemOut.Checked = _TCPIPClass.SetTimeOut;
            num_TimeOut.Value = _TCPIPClass.TimeOutNum;
            cb_KeepConnect.Checked = _TCPIPClass.KeepConnect;
            cb_ClearCache.Checked = _TCPIPClass.ClearBuffer;
            //数据
            if (_TCPIPClass.IsSend == true)
            {
                rb_Send.Checked = true;
            }
            else
            {
                rb_Receive.Checked = true;
            }
            cmb_SelectedData.SelectedItem = "数据筛选";
            txt_ToBeSend.Text = _TCPIPClass.SendText;
            //格式
            cmb_Format.SelectedItem = _TCPIPClass.Format;
            cmb_ByteOrder.SelectedItem = _TCPIPClass.ByteOrder;
            cmb_LineFeedMode.SelectedItem = _TCPIPClass.LineFeedMode;
            cmb_CharEncoding.SelectedItem = _TCPIPClass.String_CharEncoding;
            num_Width.Value = _TCPIPClass.NumericalWidth;
            num_Precision.Value = _TCPIPClass.NumericalPrecision;
            cmb_NumType.SelectedItem = _TCPIPClass.NumType;
            txt_True.Text = _TCPIPClass.Boolean_True;
            txt_False.Text = _TCPIPClass.Boolean_False;
        }

        private void InitialReferenceData()
        {         
            List<ITools> tools = _TCPIPClass.SelectedNormalBlock.ToolsList.GetRange(0, FrmEdit._currentRowIndex + 1);//通过索引得到当前工具之前的所有工具   
            List<string> receiveList = new List<string>();
            receiveList.AddRange(AnalysisDataClass.QueryReferenceTools(tools));
            receiveList.AddRange(AnalysisDataClass.QueryReferenceVar());
            receiveList.Sort();
            foreach (string item in receiveList)
            {
                lb_Reference.Items.Add(item);
            }           
        }

        private void Btn_Set_Click(object sender, EventArgs e)//配置打开通讯设置窗体
        {
            FrmConfigCommun frmConfigCommun = new FrmConfigCommun("TCP/IP");
            frmConfigCommun.ShowDialog();
            InitialCommun(false);
        }

        private void InitialCommun(bool state)//更新配置下拉框
        {
            if(ServerDict.Count >0 )
            {
                Cmb_Connect.Items.Clear();
                foreach (var item in ServerDict.Keys)
                {
                    Cmb_Connect.Items.Add(item);
                }
                if (_TCPIPClass.Connect != "" && ServerDict.ContainsKey(_TCPIPClass.Connect))
                {
                    Cmb_Connect.SelectedIndex = Cmb_Connect.Items.IndexOf(_TCPIPClass.Connect);
                }
                else if(_TCPIPClass.Connect != "" && !ServerDict.ContainsKey(_TCPIPClass.Connect))
                {
                    if (state)
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
                    Cmb_Connect.SelectedIndex = 0;//默认第一个选项
                }
                SetControlEnableState(true);
            }
            else
            {
                SetControlEnableState(false);
            }             
        }

        private void SetControlEnableState(bool b)
        {
            Cmb_Connect.Enabled = b;
            cb_EnableTiemOut.Enabled = b;
            num_TimeOut.Enabled = b;
            rb_Receive.Enabled = b;
            rb_Send.Enabled = b;
            lb_Reference.Enabled = b;
            txt_ToBeSend.Enabled = b;
            cmb_SelectedData.Enabled = b;
            txt_SelectedData.Enabled = b;
        }

        private void Rb_Receive_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Receive.Checked == true)
            {
                SetControlEnable(false);
            }
            else
            {
                SetControlEnable(true);
            }
        }

        private void SetControlEnable(bool b)
        {
            cmb_SelectedData.Enabled = true;
            txt_SelectedData.Enabled = true;
            txt_ToBeSend.Enabled = true;
            lb_Reference.Enabled = true;
        }

        private void Rb_Send_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Send.Checked == false)
            {
                SetControlEnable(false);
            }
            else
            {
                SetControlEnable(true);
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            _TCPIPClass.Connect = Cmb_Connect.SelectedItem.ToString();
            _TCPIPClass.BlockName = txt_Name.Text;
            _TCPIPClass.SetTimeOut = cb_EnableTiemOut.Checked;
            _TCPIPClass.TimeOutNum = Convert.ToInt32(num_TimeOut.Value);
            _TCPIPClass.KeepConnect = cb_KeepConnect.Checked;
            _TCPIPClass.ClearBuffer = cb_ClearCache.Checked;
            if (rb_Receive.Checked)
            {
                _TCPIPClass.IsSend = false;
            }
            else
            {
                _TCPIPClass.IsSend = true;
            }
            _TCPIPClass.SendText = txt_ToBeSend.Text;
            _TCPIPClass.Format = cmb_Format.SelectedItem.ToString();
            _TCPIPClass.ByteOrder = cmb_ByteOrder.SelectedItem.ToString();
            _TCPIPClass.LineFeedMode = cmb_LineFeedMode.SelectedItem.ToString();
            _TCPIPClass.String_CharEncoding = cmb_CharEncoding.SelectedItem.ToString();
            _TCPIPClass.NumericalWidth = Convert.ToInt32(num_Width.Value);
            _TCPIPClass.NumericalPrecision = Convert.ToInt32(num_Precision.Value);
            _TCPIPClass.NumType = cmb_NumType.SelectedItem.ToString();
            _TCPIPClass.Boolean_True = txt_True.Text;
            _TCPIPClass.Boolean_False = txt_False.Text;
            _clickOKButton(_TCPIPClass);
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            _clickCancelButton();
        }

        private void Lb_Reference_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lb_Reference.SelectedItem.ToString() != null && lb_Reference.SelectedItem.ToString() != "")
            {
                txt_ToBeSend.AppendText("<" + lb_Reference.SelectedItem.ToString() + ">");
            }
        }
    }
}
