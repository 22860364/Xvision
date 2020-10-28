using DispenseAPP.CustomControl;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataGridViewNumericUpDownElements;
using DispenseAPP.AboutData;

namespace DispenseAPP.Tools_Other.VarSet
{
    public partial class FrmEditVars : FormM
    {
        public FrmEditVars(SetVarClass currentVars)
        {
            InitializeComponent();
            DG_EditVars.TopLeftHeaderCell.Value = "索引";
            _currentVars = currentVars;
            InitialControl(_currentVars.Type);
            int start = _currentVars.Operation.IndexOf('[');
            int end = _currentVars.Operation.IndexOf(']');
            if (end - start > 1)
            {
                num_ArraySize.Value = Convert.ToDecimal(_currentVars.Operation.Substring(start + 1, end - start - 1));//确定数组大小
                char c1, c2;
                if (_currentVars.Type == "P[]")
                {
                    c1 = '(';
                    c2 = ')';
                }
                else
                {
                    c1 = '{';
                    c2 = '}';
                }
                int[] startIndex = AnalysisDataClass.GetCharAllIndex(_currentVars.Operation, c1).ToArray();
                int[] endIndex = AnalysisDataClass.GetCharAllIndex(_currentVars.Operation, c2).ToArray();//得到所有的括号的索引     
                for (int i = 0; i < (int)num_ArraySize.Value; i++)//先遍历行
                {
                    for (int j = 0; j < DG_EditVars.Columns.Count; j++)//再遍历列
                    {
                        if (_currentVars.Type == "P[]")
                        {
                            string[] substring = _currentVars.Operation.Substring(startIndex[i] + 1, endIndex[i] - startIndex[i] - 1).Split(',');
                            DG_EditVars.Rows[i].Cells[j].Value = substring[j];
                        }
                        else
                        {
                            string[] substring = _currentVars.Operation.Substring(startIndex[j] + 1, endIndex[j] - startIndex[j] - 1).Split(',');
                            DG_EditVars.Rows[i].Cells[j].Value = substring[i];
                        }
                    }
                }
            }
        }

        private SetVarClass _currentVars;

        private void InitialControl(string type)
        {
            DG_EditVars.Columns.Clear();
            switch (type)
            {
                case "N[]":
                    DataGridViewNumericUpDownColumn numCol = new DataGridViewNumericUpDownColumn();
                    numCol.HeaderText = "数值";
                    numCol.DecimalPlaces = 8;
                    numCol.Maximum = 100000000;
                    numCol.Minimum = -100000000;
                    numCol.Increment = 1;
                    DG_EditVars.Columns.Add(numCol);
                    break;
                case "S[]":
                    DataGridViewTextBoxColumn textCol = new DataGridViewTextBoxColumn();
                    textCol.HeaderText = "字符串";
                    DG_EditVars.Columns.Add(textCol);
                    break;
                case "B[]":
                    DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                    checkBoxColumn.HeaderText = "布尔值";
                    checkBoxColumn.TrueValue = true;
                    checkBoxColumn.FalseValue = false;
                    DG_EditVars.Columns.Add(checkBoxColumn);
                    break;
                case "P[]":
                    DataGridViewNumericUpDownColumn numColX = new DataGridViewNumericUpDownColumn
                    {
                        HeaderText = "X",
                        DecimalPlaces = 4,
                        Minimum = -100000,
                        Maximum = 100000
                    };
                    DG_EditVars.Columns.Add(numColX);
                    DataGridViewNumericUpDownColumn numColY = new DataGridViewNumericUpDownColumn
                    {
                        HeaderText = "Y",
                        DecimalPlaces = 4,
                        Minimum = -100000,
                        Maximum = 100000
                    };
                    DG_EditVars.Columns.Add(numColY);
                    break;
            }
        }

        private void DG_EditVars_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)//执行绘制行时触发
        {
            Rectangle rct = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, DG_EditVars.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex).ToString(), DG_EditVars.RowHeadersDefaultCellStyle.Font, rct, DG_EditVars.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

        private void num_ArraySize_ValueChanged(object sender, EventArgs e)//当数组的大小发生改变时
        {
            int deleteRowCount = Math.Abs(DG_EditVars.Rows.Count - (int)num_ArraySize.Value);
            if (num_ArraySize.Value > DG_EditVars.Rows.Count)
            {
                for (int i = 0; i < deleteRowCount; i++)
                {
                    int index = DG_EditVars.Rows.Add();
                    DG_EditVars.CurrentCell = DG_EditVars[0, index];
                    if (_currentVars.Type == "P[]" || _currentVars.Type == "N[]")
                    {
                        for (int j = 0; j < DG_EditVars.ColumnCount; j++)
                        {
                            DG_EditVars.Rows[index].Cells[j].Value = 0.0000;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < deleteRowCount; i++)
                {
                    DG_EditVars.Rows.RemoveAt(DG_EditVars.Rows.Count - 1);
                }
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)//点击确定按钮 将数组的所有值传回去
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < DG_EditVars.Rows.Count; i++)//再遍历行
            {
                for (int j = 0; j < DG_EditVars.Columns.Count; j++)//先遍历列
                {
                    if (i == DG_EditVars.Rows.Count - 1)//最后一行 不加逗号
                    {
                        if (j == DG_EditVars.Columns.Count - 1)//最后一列
                        {
                            if (_currentVars.Type == "P[]")
                            {
                                sb.Append(DG_EditVars.Rows[i].Cells[j].Value.ToString() + ")");
                            }
                            else
                            {
                                sb.Append(DG_EditVars.Rows[i].Cells[j].EditedFormattedValue.ToString());
                            }
                        }
                        else//其他列
                        {
                            if (_currentVars.Type == "P[]")
                            {
                                sb.Append("(" + DG_EditVars.Rows[i].Cells[j].Value.ToString() + ",");
                            }
                            else
                            {
                                sb.Append(DG_EditVars.Rows[i].Cells[j].EditedFormattedValue.ToString());
                            }
                        }
                    }
                    else//其他行要加逗号
                    {
                        if (j == DG_EditVars.Columns.Count - 1)//最后一列
                        {
                            if (_currentVars.Type == "P[]")
                            {
                                sb.Append(DG_EditVars.Rows[i].Cells[j].Value.ToString() + "),");
                            }
                            else
                            {
                                sb.Append(DG_EditVars.Rows[i].Cells[j].EditedFormattedValue.ToString() + ",");
                            }
                        }
                        else//其他列
                        {
                            if (_currentVars.Type == "P[]")
                            {
                                sb.Append("(" + DG_EditVars.Rows[i].Cells[j].Value.ToString() + ",");
                            }
                            else
                            {
                                sb.Append(DG_EditVars.Rows[i].Cells[j].EditedFormattedValue.ToString() + ",");
                            }
                        }
                    }
                }
            }
            _currentVars.Operation = "Set To [" + DG_EditVars.Rows.Count.ToString() + "]{" + sb.ToString() + "}";
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
