using DispenseAPP.AboutData;
using DispenseAPP.CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace DispenseAPP
{
    public partial class FrmAxisSet : FormM
    {
        private List<ConfigAxis> ConfigAxisCloneList = new List<ConfigAxis>();//克隆的List
        private List<ConfigAxis> ConfigAxisList ;//传入的List
        private NumericUpDown numInterger;//整数类型
        private NumericUpDown numDouble;//小数类型
        private ComboBox comboBox;//复位方向
        private NumericUpDown numReset;//复位顺序
        private List<int> copyList = new List<int>();//存放复制的索引
        private int _currentIndex;//鼠标点击右键的行索引
        private bool IsEditState = false;//是否处于编辑状态
        private bool IsCopy = true;//当前是复制

        public FrmAxisSet(List<ConfigAxis> configAxisList)
        {
            InitializeComponent();
            DG_Axis.AutoGenerateColumns = false;
            ConfigAxisList = configAxisList;//这句话很关键 坑 写的时候思路有问题
            foreach (ConfigAxis item in ConfigAxisList)
            {
                ConfigAxisCloneList.Add((ConfigAxis)item.Clone());
            }
            DG_Axis.DataSource = new BindingList<ConfigAxis>(ConfigAxisCloneList);
            InitialControl();
        }

        private void InitialControl()//初始化控件
        {
            numInterger = new NumericUpDown
            {
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("微软雅黑", 9),
                Maximum = 1000000,
                Minimum = 0,
                DecimalPlaces = 0,//小数位数
                AutoSize = false,
                Visible = false,
            };
            numDouble = new NumericUpDown
            {
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("微软雅黑", 9),
                Maximum = 100000,
                Minimum = 0,
                DecimalPlaces = 4,
                AutoSize = false,
                Visible = false,
            };
            comboBox = new ComboBox();
            comboBox.Items.AddRange(new string[] { "正方向", "负方向" });
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FlatStyle = FlatStyle.Popup;
            comboBox.Visible = false;
            comboBox.Font = new Font("微软雅黑", 8);
            comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            numReset = new NumericUpDown
            {
                Maximum = 5,
                Minimum = 0,
                DecimalPlaces = 0,
                AutoSize = false,
                Visible = false,
                Font = new Font("微软雅黑", 9),
            };
            DG_Axis.Controls.AddRange(new Control[] { numInterger, numDouble, comboBox, numReset });
            DG_Axis.TopLeftHeaderCell.Value = "行号";
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)//索引发生变化
        {
            DG_Axis.EndEdit();
        }

        private void Tsmi_Add_Click(object sender, EventArgs e)//在最后一行添加
        {
            ConfigAxis configAxis = new ConfigAxis();
            ConfigAxisCloneList.Add(configAxis);
            DG_Axis.DataSource = new BindingList<ConfigAxis>(ConfigAxisCloneList);
            DG_Axis.CurrentCell = DG_Axis[0, ConfigAxisCloneList.FindIndex(c => c == configAxis)];
        }

        private void Tsmi_Insert_Click(object sender, EventArgs e)//插入 在选中行之前一行插入
        {
            ConfigAxis configAxis = new ConfigAxis();
            ConfigAxisCloneList.Insert(_currentIndex, configAxis);
            DG_Axis.DataSource = new BindingList<ConfigAxis>(ConfigAxisCloneList);
            DG_Axis.CurrentCell = DG_Axis[0, ConfigAxisCloneList.FindIndex(c => c == configAxis)];
        }

        private void Tsmi_Del_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in DG_Axis.SelectedRows) //删除多行
            {
                ConfigAxisCloneList.RemoveAt(item.Index);
                if(copyList.Count >0 && copyList.Contains(item.Index))
                {
                    copyList.Clear();
                }
            }
            DG_Axis.DataSource = new BindingList<ConfigAxis>(ConfigAxisCloneList);
        }

        private void Tsmi_Past_Click(object sender, EventArgs e)//粘贴  可能是单行也可能是多行
        {
            List<ConfigAxis> copy = new List<ConfigAxis>(); 
            for (int i = 0; i < copyList.Count; i++)
            {
                if(IsCopy)
                {
                    copy.Add((ConfigAxis)ConfigAxisCloneList[copyList[i]].Clone());//当复制需要浅复制
                }
                else
                {
                    copy.Add(ConfigAxisCloneList[copyList[i]]);//直接复制引用
                }
            }
            ConfigAxisCloneList.RemoveRange(_currentIndex, DG_Axis.Rows.Count - copyList.Count);//删除需要粘贴的位置
            ConfigAxisCloneList.InsertRange(_currentIndex, copy);
            if (IsCopy == false)//剪切
            {
                for (int i = copyList.Count - 1; i >= 0; i--)
                {
                    ConfigAxisCloneList.RemoveAt(i);
                }           
                copyList.Clear();
            }
            DG_Axis.DataSource = new BindingList<ConfigAxis>(ConfigAxisCloneList);
            DG_Axis.Invalidate();//重绘
        }

        private void Tsmi_Copy_Click(object sender, EventArgs e)//复制 可能是单行也可能是多行  
        {
            CutCopyMethod();
            IsCopy = true;
        }

        private void CutCopyMethod()
        {
            copyList.Clear();//清除集合中的索引
            foreach (DataGridViewRow item in DG_Axis.SelectedRows)//选择的行集合
            {
                copyList.Add(item.Index);
            }
            copyList.Sort();
            DG_Axis.Invalidate();
        }

        private void Tsmi_Cut_Click(object sender, EventArgs e)//剪切
        {
            CutCopyMethod();
            IsCopy = false;
        }

        private void Tsmi_Undo_Click(object sender, EventArgs e)//撤销
        {
        }

        private void Tsmi_Redo_Click(object sender, EventArgs e)//重做
        {
        }

        private void DG_Axis_MouseDown(object sender, MouseEventArgs e)
        {
            _currentIndex = DG_Axis.HitTest(e.X, e.Y).RowIndex;
            if (e.Button == MouseButtons.Right && IsEditState == false)
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

        private void Btn_OK_Click(object sender, EventArgs e)//刚才的操作生效
        {
            ConfigAxisList.Clear();
            foreach (ConfigAxis item in ConfigAxisCloneList)
            {
                ConfigAxisList.Add((ConfigAxis)item.Clone());
            }
            Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)//操作不生效  不需要操作
        {
            Close();
        }

        private void DG_Axis_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (copyList.Count >0 && copyList.Contains(e.RowIndex))
                {
                    copyList.Clear();
                    DG_Axis.Invalidate();
                }
                IsEditState = true;
                Point location = new Point(DG_Axis.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).X, DG_Axis.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Y);
                Size size = DG_Axis.CurrentCell.Size;
                switch (e.ColumnIndex)//根据列来显示对应的控件
                {
                    case 0:
                    case 2:
                    case 3:
                        numInterger.Location = location;
                        numInterger.Size = size;
                        numInterger.Visible = true;
                        numInterger.Value = Convert.ToDecimal(DG_Axis[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString());
                        numInterger.Focus();
                        break;
                    case 6:
                        comboBox.Location = location;
                        comboBox.Size = size;
                        comboBox.Visible = true;
                        comboBox.SelectedIndex = comboBox.Items.IndexOf(DG_Axis[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString());
                        comboBox.Focus();
                        break;
                    case 7:
                        numReset.Location = location;
                        numReset.Size = size;
                        numReset.Visible = true;
                        numReset.Value = Convert.ToDecimal(DG_Axis[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString());
                        numReset.Focus();
                        break;
                    case 4:
                    case 5:
                    case 8:
                    case 11:
                    case 12:
                        numDouble.Location = location;
                        numDouble.Size = size;
                        numDouble.Visible = true;
                        numDouble.Value = Convert.ToDecimal(DG_Axis[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString());
                        numDouble.Focus();
                        break;
                }
            }
        }

        private void DG_Axis_CellEndEdit(object sender, DataGridViewCellEventArgs e)//停止编辑
        {
            if (numInterger.Visible) { DG_Axis[e.ColumnIndex, e.RowIndex].Value = numInterger.Value; numInterger.Visible = false; }
            else if (numReset.Visible) { DG_Axis[e.ColumnIndex, e.RowIndex].Value = numReset.Value; numReset.Visible = false; }
            else if (comboBox.Visible) { DG_Axis[e.ColumnIndex, e.RowIndex].Value = comboBox.Text; comboBox.Visible = false; }
            else if (numDouble.Visible) { DG_Axis[e.ColumnIndex, e.RowIndex].Value = numDouble.Value; numDouble.Visible = false; }
            IsEditState = false;
        }

        private void DG_Axis_MouseClick(object sender, MouseEventArgs e)
        {
            int columnIndex = DG_Axis.HitTest(e.X, e.Y).ColumnIndex;
            if(columnIndex != 9 && columnIndex != 10)
            {
                DG_Axis.EndEdit();
            }
        }

        private void DG_Axis_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)//显示行号
        {
            Rectangle rct = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, DG_Axis.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), DG_Axis.RowHeadersDefaultCellStyle.Font, rct, DG_Axis.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
            if(copyList.Contains(e.RowIndex))//绘制虚线代表选中的复制行
            {
                using (Pen gridLinePen = new Pen(Color.Green,2))
                {
                    gridLinePen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                    e.Graphics.DrawRectangle(gridLinePen, new Rectangle(e.RowBounds.X,e.RowBounds.Y,e.RowBounds.Width,e.RowBounds.Height-1));
                }
            }
        }

        private void DG_Axis_KeyDown(object sender, KeyEventArgs e)//首次按下某个键时发生
        {
            if(e.KeyCode == Keys.Escape && copyList.Count >0)
            {
                copyList.Clear();
                DG_Axis.Invalidate();
            }
        }
    }
}
