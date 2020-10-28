using DispenseAPP.AboutData;
using DispenseAPP.CustomControl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    public partial class FrmIOSet : FormM
    {
        private List<ConfigDI> ConfigDIListClone = new List<ConfigDI>();
        private List<ConfigDO> ConfigDOListClone = new List<ConfigDO>();
        private List<ConfigDI> ConfigDIList;
        private List<ConfigDO> ConfigDOList;
        private int currentIndex;
        private CurrentDataGridView currentDG = CurrentDataGridView.DI;
        private string CardName { get; set; }//卡名称
        private NumericUpDown Num_Port;
        private bool IsEditState;
        private bool IsInitial = true;
        private enum CurrentDataGridView//当前操作的控件
        {
            DI,
            DO,
        }

        public FrmIOSet(List<ConfigDI> configDIList, List<ConfigDO> configDOList, string cardName)
        {
            InitializeComponent();
            DG_DI.TopLeftHeaderCell.Value = "行号";
            DG_DO.TopLeftHeaderCell.Value = "行号";
            foreach (ConfigDI item in configDIList)
            {
                ConfigDIListClone.Add((ConfigDI)item.Clone());
            }
            foreach (ConfigDO item in configDOList)
            {
                ConfigDOListClone.Add((ConfigDO)item.Clone());
            }
            ConfigDIList = configDIList;
            ConfigDOList = configDOList;
            CardName = cardName;
            InitialControl();
            Timer_ReadIO.Start();
        }

        private void InitialControl()//初始化控件
        {
            Num_Port = new NumericUpDown
            {
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("微软雅黑", 9),
                Maximum = 1000000,
                Minimum = 0,
                DecimalPlaces = 0,//小数位数
                AutoSize = false,
                Visible = false,
            };
        }

        private void DG_DI_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rct = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, DG_DI.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), DG_DI.RowHeadersDefaultCellStyle.Font, rct, DG_DI.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

        private void DG_DO_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rct = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, DG_DO.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), DG_DO.RowHeadersDefaultCellStyle.Font, rct, DG_DO.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

        private void DG_DI_MouseDown(object sender, MouseEventArgs e)//按下鼠标按钮时发生
        {
            currentIndex = DG_DI.HitTest(e.X, e.Y).RowIndex;
            currentDG = CurrentDataGridView.DI;
            if (e.Button == MouseButtons.Right)
            {
                if (currentIndex >= 0)
                {
                    foreach (ToolStripItem item in CM_Operation.Items)
                    {
                        item.Enabled = true;
                    }
                }
                else
                {
                    foreach (ToolStripItem item in CM_Operation.Items)
                    {
                        if (item.Text == "添加" || item.Text == "导入Excel")
                        {
                            item.Enabled = true;
                        }
                        else
                        {
                            item.Enabled = false;
                        }
                    }
                }
                CM_Operation.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void DG_DO_MouseDown(object sender, MouseEventArgs e)//按下鼠标按钮时发生
        {
            currentIndex = DG_DI.HitTest(e.X, e.Y).RowIndex;
            currentDG = CurrentDataGridView.DO;
            if (e.Button == MouseButtons.Right)
            {
                if (currentIndex >= 0)
                {
                    foreach (ToolStripItem item in CM_Operation.Items)
                    {
                        item.Enabled = true;
                    }
                }
                else
                {
                    foreach (ToolStripItem item in CM_Operation.Items)
                    {
                        if (item.Text == "添加" || item.Text == "导入Excel")
                        {
                            item.Enabled = true;
                        }
                        else
                        {
                            item.Enabled = false;
                        }
                    }
                }
                CM_Operation.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void Tsmi_Add_Click(object sender, EventArgs e)//添加输入信号
        {
            if (currentDG == CurrentDataGridView.DI)
            {
                Add(DG_DI);
            }
            else
            {
                Add(DG_DO);
            }
        }

        private void Add(DataGridView dg)
        {
            int index = dg.Rows.Add();
            dg.Rows[index].Cells[2].Value = "常开";
            dg.Rows[index].Cells[1].Value = "0";
            dg.CurrentCell = dg[0, index];
        }

        private void Tsmi_Del_Click(object sender, EventArgs e)
        {
            if (currentDG == CurrentDataGridView.DI)
            {
                Del(DG_DI);
            }
            else
            {
                Del(DG_DO);
            }
        }

        private void Del(DataGridView dg)
        {
            foreach (DataGridViewRow item in dg.SelectedRows)
            {
                dg.Rows.Remove(item);
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            ConfigDIList.Clear();
            ConfigDOList.Clear();
            foreach (ConfigDI item in ConfigDIListClone)
            {
                ConfigDIList.Add((ConfigDI)item.Clone());
            }
            foreach (ConfigDO item in ConfigDOListClone)
            {
                ConfigDOList.Add((ConfigDO)item.Clone());
            }
            Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Timer_ReadIO_Tick(object sender, EventArgs e)
        {
            if (CardName != null &&  MotionCardDict.ContainsKey(CardName) && MotionCardDict[CardName].CardConnectState == true)
            {
                foreach (DataGridViewRow item in DG_DI.Rows)//遍历DI中的行
                {
                    string port = item.Cells[1].EditedFormattedValue.ToString();
                    if(MotionCardDict[CardName].ReadDI(Convert.ToInt32(port),out bool state,out string error))//读取成功才赋值
                    {
                        item.Cells[3].Value = state;
                    }
                }
                if (IsInitial)//只是进入时读取一次DO
                {
                    foreach (DataGridViewRow item in DG_DO.Rows)
                    {
                        string port = item.Cells[1].EditedFormattedValue.ToString();
                        if(MotionCardDict[CardName].ReadDO(Convert.ToInt32(port),out bool state,out string error))//读取成功才赋值
                        {
                            item.Cells[3].Value = state;
                        }
                    }
                    IsInitial = false;
                }
            }
        }

        private void DG_DI_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            BeginEdit(e, DG_DI);
        }

        private void BeginEdit(DataGridViewCellCancelEventArgs e, DataGridView dg)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Point location = new Point(dg.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).X, dg.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Y);
                Size size = dg.CurrentCell.Size;
                if (e.ColumnIndex == 1)
                {
                    IsEditState = true;
                    dg.Controls.Add(Num_Port);
                    Num_Port.Location = location;
                    Num_Port.Size = size;
                    Num_Port.Visible = true;
                    Num_Port.Value = Convert.ToDecimal(dg[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString());
                    Num_Port.Focus();
                }
            }
        }

        private void DG_DI_MouseClick(object sender, MouseEventArgs e)
        {
            if (IsEditState)
            {
                DG_DI.EndEdit();
            }
        }

        private void DG_DI_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Num_Port.Visible) { DG_DI[e.ColumnIndex, e.RowIndex].Value = Num_Port.Value; Num_Port.Visible = false; IsEditState = false; }
        }

        private void DG_DO_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Num_Port.Visible) { DG_DO[e.ColumnIndex, e.RowIndex].Value = Num_Port.Value; Num_Port.Visible = false; IsEditState = false; }
        }

        private void DG_DO_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            BeginEdit(e, DG_DO);
        }

        private void DG_DO_MouseClick(object sender, MouseEventArgs e)
        {
            if (IsEditState)
            {
                DG_DI.EndEdit();
            }
        }

        private void DG_DO_CellContentClick(object sender, DataGridViewCellEventArgs e)//单击单元格的内容时发生
        {
            if (e.ColumnIndex == DG_DI.ColumnCount - 1)//如果是最后一列
            {
                string port = DG_DO.Rows[e.RowIndex].Cells[1].EditedFormattedValue.ToString();
                if (MotionCardDict.ContainsKey(CardName) && MotionCardDict[CardName].CardConnectState == true && port != "")
                {
                    bool state = Convert.ToBoolean(DG_DO.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString());
                    OutStateEnum outState;
                    if (state) { outState = OutStateEnum.ON; }
                    else { outState = OutStateEnum.OFF; }
                    if(MotionCardDict[CardName].SetDO(Convert.ToInt32(port), outState, out string error)!= true)
                    {
                        MessageBox.Show(error, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }             
                }
            }
        }

        private void FrmIOSet_FormClosing(object sender, FormClosingEventArgs e)
        {
            Timer_ReadIO.Stop();
        }
    }
}
