using DispenseAPP.AboutData;
using DispenseAPP.CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DispenseAPP.AboutMotionCard.ConfigMotionCard
{
    public partial class FrmLimitSet : FormM//不可以添加或删除 只有当配置了轴之后 才可以配置限位 目前只有正运动需要配置
    {
        private List<ConfigLimit> limitConfigList;
        private List<ConfigLimit> limitConfigCloneList = new List<ConfigLimit>();
        private NumericUpDown numPort;
        private ComboBox comAxisName;
        private ComboBox comLogicLevel;
        private string[] axisNameArray;
        private int _currentIndex;
        private bool IsEditState;
        private List<int> copyList = new List<int>();
        private bool IsCopy;

        public FrmLimitSet(List<ConfigLimit> LimitConfigList,List<ConfigAxis> configAxisList)
        {
            InitializeComponent();
            DG_Limit.AutoGenerateColumns = false;//不自动创建列
            limitConfigList = LimitConfigList;
            foreach (ConfigLimit item in limitConfigList)
            {
                limitConfigCloneList.Add((ConfigLimit)item.Clone());
            }
            axisNameArray = new string[configAxisList.Count];
            for (int i = 0; i < configAxisList.Count; i++)
            {
                axisNameArray[i] = configAxisList[i].AxisName;
            }
            DG_Limit.DataSource = new BindingList<ConfigLimit>(limitConfigCloneList);
            InitialControl();
        }

        private void InitialControl()//初始化控件
        {
            numPort = new NumericUpDown
            {
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("微软雅黑", 9),
                Maximum = 1000000,
                Minimum = -1,
                DecimalPlaces = 0,//小数位数
                AutoSize = false,
                Visible = false,
            };
            comAxisName = new ComboBox();//轴名称
            comAxisName.Items.AddRange(axisNameArray);
            comAxisName.DropDownStyle = ComboBoxStyle.DropDownList;
            comAxisName.FlatStyle = FlatStyle.Popup;
            comAxisName.Visible = false;
            comAxisName.Font = new Font("微软雅黑", 8);
            comAxisName.SelectedIndexChanged += ComAxisName_SelectedIndexChanged;
            comLogicLevel = new ComboBox();//端口逻辑电平
            comLogicLevel.Items.AddRange(new string[] { "低电平", "高电平" });
            comLogicLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            comLogicLevel.FlatStyle = FlatStyle.Popup;
            comLogicLevel.Visible = false;
            comLogicLevel.Font = new Font("微软雅黑", 8);
            comLogicLevel.SelectedIndexChanged += ComLogicLevel_SelectedIndexChanged;
            DG_Limit.Controls.AddRange(new Control[] { numPort, comAxisName, comLogicLevel });
            DG_Limit.TopLeftHeaderCell.Value = "行号";
        }

        private void ComLogicLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            DG_Limit.EndEdit();//结束编辑
        }

        private void ComAxisName_SelectedIndexChanged(object sender, System.EventArgs e)//下拉框所以发生变化时
        {
            DG_Limit.EndEdit();//结束编辑
        }


        private void DG_Limit_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Point location = new Point(DG_Limit.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).X, DG_Limit.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Y);
                Size size = DG_Limit.CurrentCell.Size;
                switch (e.ColumnIndex)
                {
                    case 0:
                        comAxisName.Location = location;
                        comAxisName.Size = size;
                        comAxisName.Visible = true;
                        string value = DG_Limit[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString();
                        if (value != "")
                        {
                            comAxisName.SelectedIndex = comAxisName.Items.IndexOf(value);
                        }
                        else
                        {
                            comAxisName.SelectedIndex = 0;
                        }
                        comAxisName.Focus();
                        break;
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        numPort.Location = location;
                        numPort.Size = size;
                        numPort.Visible = true;
                        numPort.Value = Convert.ToDecimal(DG_Limit[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString());
                        numPort.Focus();
                        break;
                    default:
                        comLogicLevel.Location = location;
                        comLogicLevel.Size = size;
                        comLogicLevel.Visible = true;
                        string level = DG_Limit[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString();
                        if (level != "")
                        {
                            comLogicLevel.SelectedIndex = comLogicLevel.Items.IndexOf(level);
                        }
                        else
                        {
                            comLogicLevel.SelectedIndex = 0;
                        }
                        comLogicLevel.Focus();
                        break;
                }
            }
        }

        private void DG_Limit_CellEndEdit(object sender, DataGridViewCellEventArgs e)//结束编辑
        {
            if (comAxisName.Visible) { DG_Limit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = comAxisName.Text; comAxisName.Visible = false; }
            else if (numPort.Visible) { DG_Limit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = numPort.Value;numPort.Visible = false; }
            else if (comLogicLevel.Visible) { DG_Limit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = comLogicLevel.Text; comLogicLevel.Visible = false; }
            IsEditState = false;
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            limitConfigList.Clear();
            foreach (ConfigLimit item in limitConfigCloneList)
            {
                limitConfigList.Add((ConfigLimit)item.Clone());
            }
            Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DG_Limit_MouseDown(object sender, MouseEventArgs e)
        {
            _currentIndex = DG_Limit.HitTest(e.X, e.Y).RowIndex;
            if(e.Button == MouseButtons.Right && IsEditState == false)
            {
                if (_currentIndex >= 0)
                {
                    foreach (ToolStripItem item in CM_Operation.Items)
                    {
                        if (item.Text != "撤销" && item.Text != "重做")//这两个的状态有事件决定
                        {
                            item.Enabled = true;
                            if (item.Text == "粘贴" && copyList.Count == 0)//需要判断复制的集合中有没有项
                            {
                                item.Enabled = false;
                            }
                        }
                    }
                }
                else
                {
                    foreach (ToolStripItem item in CM_Operation.Items)
                    {
                        if (item.Text != "撤销" && item.Text != "重做")//这两个的状态有事件决定
                        {
                            if (item.Text == "添加")
                            {
                                item.Enabled = true;
                            }
                            else
                            {
                                item.Enabled = false;
                            }
                        }
                    }
                }
                CM_Operation.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void Tsmi_Add_Click(object sender, EventArgs e)//添加
        {
            ConfigLimit configLimit = new ConfigLimit();
            limitConfigCloneList.Add(configLimit);
            DG_Limit.DataSource = new BindingList<ConfigLimit>(limitConfigCloneList);
            DG_Limit.CurrentCell = DG_Limit[0, limitConfigCloneList.FindIndex(c => c == configLimit)];
        }

        private void Tsmi_Insert_Click(object sender, EventArgs e)//插入
        {
            ConfigLimit configLimit = new ConfigLimit();
            limitConfigCloneList.Insert(_currentIndex,configLimit);
            DG_Limit.DataSource = new BindingList<ConfigLimit>(limitConfigCloneList);
            DG_Limit.CurrentCell = DG_Limit[0, limitConfigCloneList.FindIndex(c => c == configLimit)];
        }

        private void Tsmi_Del_Click(object sender, EventArgs e)//删除
        {
            foreach (DataGridViewRow item in DG_Limit.SelectedRows) //删除多行
            {
                limitConfigCloneList.RemoveAt(item.Index);
                if (copyList.Count > 0 && copyList.Contains(item.Index))
                {
                    copyList.Clear();
                }
            }
            DG_Limit.DataSource = new BindingList<ConfigLimit>(limitConfigCloneList);
        }

        private void Tsmi_Cut_Click(object sender, EventArgs e)//剪切
        {
            CutCopyMethod();
            IsCopy = false;
        }

        private void Tsmi_Copy_Click(object sender, EventArgs e)//复制
        {
            CutCopyMethod();
            IsCopy = true;
        }

        private void CutCopyMethod()
        {
            copyList.Clear();//清除集合中的索引
            foreach (DataGridViewRow item in DG_Limit.SelectedRows)//选择的行集合
            {
                copyList.Add(item.Index);
            }
            copyList.Sort();
            DG_Limit.Invalidate();
        }

        private void Tsmi_Past_Click(object sender, EventArgs e)//粘贴
        {
            List<ConfigLimit> copy = new List<ConfigLimit>();
            for (int i = 0; i < copyList.Count; i++)
            {
                if (IsCopy)
                {
                    copy.Add((ConfigLimit)limitConfigCloneList[copyList[i]].Clone());//当复制需要浅复制
                }
                else
                {
                    copy.Add(limitConfigCloneList[copyList[i]]);//直接复制引用
                }
            }
            limitConfigCloneList.RemoveRange(_currentIndex, DG_Limit.Rows.Count - copyList.Count);//删除需要粘贴的位置
            limitConfigCloneList.InsertRange(_currentIndex, copy);
            if (IsCopy == false)//剪切
            {
                for (int i = copyList.Count - 1; i >= 0; i--)
                {
                    limitConfigCloneList.RemoveAt(i);
                }
                copyList.Clear();
            }
            DG_Limit.DataSource = new BindingList<ConfigLimit>(limitConfigCloneList);
            DG_Limit.Invalidate();//重绘
        }

        private void Tsmi_Undo_Click(object sender, EventArgs e)//撤销
        {

        }

        private void Tsmi_Redo_Click(object sender, EventArgs e)//重做
        {

        }

        private void DG_Limit_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)//执行行级绘制触发的事件
        {
            Rectangle rct = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,DG_Limit.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),DG_Limit.RowHeadersDefaultCellStyle.Font, rct, DG_Limit.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
            if (copyList.Contains(e.RowIndex))//绘制虚线代表选中的复制行
            {
                using (Pen gridLinePen = new Pen(Color.Green, 2))
                {
                    gridLinePen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                    e.Graphics.DrawRectangle(gridLinePen, new Rectangle(e.RowBounds.X, e.RowBounds.Y, e.RowBounds.Width, e.RowBounds.Height - 1));
                }
            }
        }

        private void DG_Limit_KeyDown(object sender, KeyEventArgs e)//首次按下某个键后发生
        {
            if (e.KeyCode == Keys.Escape && copyList.Count > 0)
            {
                copyList.Clear();
                DG_Limit.Invalidate();
            }
        }
    }
}
