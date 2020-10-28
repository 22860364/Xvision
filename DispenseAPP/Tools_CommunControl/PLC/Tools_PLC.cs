using DispenseAPP.AboutData;
using DispenseAPP.静态类;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_CommunControl.PLC
{
    public partial class Tools_PLC : UserControl, IEvent
    {
        private PLC_CommunClass _plc_CommunClass;
        public event ClickOKButtonDelegate _clickOKButton;
        public event ClickCancelDelegate _clickCancelButton;
        private List<string> list = new List<string>();

        public Tools_PLC(PLC_CommunClass plc_CommunClass)
        {
            InitializeComponent();
            _plc_CommunClass = plc_CommunClass;
            Txt_Name.Text = _plc_CommunClass.BlockName;
            InitialCommun(true);
            Cmb_Mode.SelectedIndex = Cmb_Mode.Items.IndexOf(_plc_CommunClass.Mode);
            Cmb_Memory.SelectedIndex = Cmb_Memory.Items.IndexOf(_plc_CommunClass.Memory);
            Cmb_Type.SelectedIndex = Cmb_Type.Items.IndexOf(_plc_CommunClass.Type);
            DG_SendData.TopLeftHeaderCell.Value = "索引";
        }

        public void InitialCommun(bool state)//初始化通讯
        {           
            if (QsAscDict.Count > 0)
            {
                Cmb_Connect.Items.Clear();
                foreach (string item in QsAscDict.Keys)//遍历添加的PLC通讯
                {
                    Cmb_Connect.Items.Add(item);
                }
                if (_plc_CommunClass.Connect != "" && QsAscDict.ContainsKey(_plc_CommunClass.Connect))
                {
                    Cmb_Connect.SelectedIndex = Cmb_Connect.Items.IndexOf(_plc_CommunClass.Connect);
                }
                else if (_plc_CommunClass.Connect != "" && !QsAscDict.ContainsKey(_plc_CommunClass.Connect))
                {
                    if(state)
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
                SetControlEnableState(true);
            }
            else
            {
                SetControlEnableState(false);
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            _clickCancelButton();
        }

        private void Cmb_Mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Cmb_Mode.SelectedItem.ToString())//根据不同的模式 高级设置对应不同的界面
            {
                case "读取位状态":
                case "设置位状态为True":
                case "设置位状态为False":
                    SetControlVisible(false);
                    break;
                case "批量读取数据":
                    SetControlVisible(true);
                    Gb_SendData.Visible = false;
                    break;
                case "批量写入数据":
                    SetControlVisible(true);
                    Set_DG_SendData_Control();
                    break;
            }
        }

        private void SetControlVisible(bool state)
        {
            Lbl_Count.Visible = state;
            Lbl_Type.Visible = state;
            Cmb_Type.Visible = state;
            Gb_SendData.Visible = state;
            Num_Count.Visible = state;
        }

        private void Set_DG_SendData_Control()//设置写入数据控件
        {
            DG_SendData.Columns.Clear();
            switch (Cmb_Memory.Text)
            {
                case "MR"://状态寄存器                    
                    DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn
                    {
                        SortMode = DataGridViewColumnSortMode.NotSortable,
                        HeaderText = "选择发送数据"
                    };
                    DG_SendData.Columns.Add(dataGridViewCheckBoxColumn);
                    break;
                case "DR"://数据寄存器
                    DataGridViewComboBoxColumn dataGridViewComboBoxColumn = new DataGridViewComboBoxColumn
                    {
                        DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                        FlatStyle = FlatStyle.Flat,
                        DataSource = AnalysisDataClass.QueryReferenceVar("NPN[]P[]"),
                        SortMode = DataGridViewColumnSortMode.NotSortable,
                        HeaderText = "选择发送数据"
                    };
                    dataGridViewComboBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DG_SendData.Columns.Add(dataGridViewComboBoxColumn);
                    break;
            }
            DG_SendData.RowCount = (int)Num_Count.Value;
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (QueryDifferenceName.ToolClickOK(Txt_Name.Text, _plc_CommunClass.SelectedNormalBlock, _plc_CommunClass.BlockName) == true)
            {
                if(Cmb_Mode.Text == "批量写入数据" && QueryDG() == false)
                {
                    MessageBox.Show("发送的数据不能为空，请选择要发送的数据！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    _plc_CommunClass.BlockName = Txt_Name.Text;
                    _plc_CommunClass.Connect = Cmb_Connect.Text;//在控件上加了限定 如果为空 则无法点击OK按钮
                    _plc_CommunClass.Mode = Cmb_Mode.Text;
                    _plc_CommunClass.Memory = Cmb_Memory.Text;
                    _plc_CommunClass.Address = (int)Num_Address.Value;
                    _plc_CommunClass.Count = (ushort)Num_Count.Value;
                    _plc_CommunClass.Type = Cmb_Type.Text;
                    if(Cmb_Mode.Text == "批量写入数据")
                    {
                        _plc_CommunClass.SendToData = WriteDG();
                    }
                    _clickOKButton(_plc_CommunClass);
                }           
            }
        }

        private string WriteDG()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < DG_SendData.Rows.Count; i++)
            {
                if(i == DG_SendData.Rows.Count -1)
                {
                    sb.Append(DG_SendData.Rows[i].Cells[0].EditedFormattedValue.ToString());
                }
                else
                {
                    sb.Append(DG_SendData.Rows[i].Cells[0].EditedFormattedValue.ToString() +",");
                }
            }
            return sb.ToString();
        }

        private bool QueryDG()
        {
            for (int i = 0; i < DG_SendData.Rows.Count; i++)//遍历
            {
                if(DG_SendData.Rows[i].Cells[0].Value.ToString() == "")
                {
                    return false;
                }
            }
            return true;
        }

        private void Btn_Set_Click(object sender, EventArgs e)//配置通讯
        {
            FrmConfigCommun frmConfigCommun = new FrmConfigCommun("三菱Q系列PLC");
            frmConfigCommun.ShowDialog();
            InitialCommun(false);
        }

        private void SetControlEnableState(bool b)//设置控件的使能状态
        {
            Cmb_Mode.Enabled = b;
            Panel_Data.Enabled = b;
            Btn_OK.Enabled = b;
        }

        private void Cmb_Connect_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetControlEnableState(true);
        }

        private void Num_Count_ValueChanged(object sender, EventArgs e)//当发送的数量改变时 只有在批量处理数据的情况下有效
        {
            DG_SendData.RowCount = (int)Num_Count.Value;
        }

        private void DG_SendData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rct = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, DG_SendData.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), DG_SendData.RowHeadersDefaultCellStyle.Font, rct, DG_SendData.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

        private void Cmb_Memory_SelectedIndexChanged(object sender, EventArgs e)//当内存区域改变后 对应的DG需要改变
        {
            Set_DG_SendData_Control();
        }
    }
}
