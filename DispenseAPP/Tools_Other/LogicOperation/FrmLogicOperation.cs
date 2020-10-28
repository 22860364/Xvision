using DispenseAPP.CustomControl;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DispenseAPP.Tools_Other.LogicOperation
{
    public partial class FrmLogicOperation : FormM
    {
        private Dictionary<string, List<BlockNameValue>> referenceData = new Dictionary<string, List<BlockNameValue>>();
        private LogicOperationToolEntity _logicOperationClass = new LogicOperationToolEntity();

        public FrmLogicOperation(LogicOperationToolEntity logicOperationClass)
        {
            InitializeComponent();
            _logicOperationClass = logicOperationClass;
            InitialHelper.LogicOperationInitialReference(_logicOperationClass.SelectedOperatorBlock.ToolList, Lb_BlockName, referenceData,_logicOperationClass.SelectedOperatorBlock.LastIndex);
            Txt_Code.Text = _logicOperationClass.Expression;
        }

        private void FrmLogicOperation_Load(object sender, EventArgs e)
        {
            SetCursor();
        }

        private void SetCursor()//设置光标
        {
            Txt_Code.Focus();//设置输入焦点
            Txt_Code.Select(Txt_Code.TextLength, 0);//光标定位到文本最后
            Txt_Code.ScrollToCaret();//滚动到光标处
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            _logicOperationClass.executor = null;
            _logicOperationClass.Expression = Txt_Code.Text.Trim();
            _logicOperationClass.ComputerExecuteTime();
            Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_One_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText("1");
            SetCursor();
        }

        private void Btn_Two_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText("2");
            SetCursor();
        }

        private void Btn_Three_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText("3");
            SetCursor();
        }

        private void Btn_Four_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText("4");
            SetCursor();
        }

        private void Btn_Five_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText("5");
            SetCursor();
        }

        private void Btn_Six_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText("6");
            SetCursor();
        }

        private void Btn_Seven_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText("7");
            SetCursor();
        }

        private void Btn_Eight_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText("8");
            SetCursor();
        }

        private void Btn_Nine_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText("9");
            SetCursor();
        }

        private void Btn_Zero_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText("0");
            SetCursor();
        }

        private void Btn_RadixPoint_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText(".");
            SetCursor();
        }

        private void Btn_Greater_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText(" >");
            SetCursor();
        }

        private void Btn_GreateOrEqual_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText(" >=");
            SetCursor();
        }

        private void Btn_LessThan_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText(" <");
            SetCursor();
        }

        private void Btn_LessThanOrEqual_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText(" <=");
            SetCursor();
        }

        private void Btn_Equal_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText(" ==");
            SetCursor();
        }

        private void Btn_NotEqual_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText(" !=");
            SetCursor();
        }

        private void Btn_LeftParentheses_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText("(");
            SetCursor();
        }

        private void Btn_RightParentheses_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText(")");
            SetCursor();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText(" +");
            SetCursor();
        }

        private void Btn_Subtract_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText(" -");
            SetCursor();
        }

        private void Btn_Multiply_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText(" *");
            SetCursor();
        }

        private void Btn_Divide_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText(" /");
            SetCursor();
        }

        private void Btn_And_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText(" &&");
            SetCursor();
        }

        private void Btn_Or_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText(" ||");
            SetCursor();
        }

        private void Btn_True_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText(" true");
            SetCursor();
        }

        private void Btn_False_Click(object sender, EventArgs e)
        {
            Txt_Code.AppendText(" false");
            SetCursor();
        }

        private void Btn_Calculate_Click(object sender, EventArgs e)//执行计算 在这里不解析 然后在实例那里解析
        {
            _logicOperationClass.executor = null;
            _logicOperationClass.Execute1(Txt_Code.Text.Trim(), out object result);
            txt_Result.Text = result.ToString();
        }

        private void Lb_BlockName_SelectedIndexChanged(object sender, EventArgs e)//当选择的算子名变化时发生
        {
            if (Lb_BlockName.SelectedItem != null)
            {
                DG_Name_Value.DataSource = referenceData[Lb_BlockName.SelectedItem.ToString()];
                for (int i = 0; i < DG_Name_Value.Columns.Count; i++)
                {
                    DG_Name_Value.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    DG_Name_Value.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                DG_Name_Value.Columns[0].FillWeight = 35;
                DG_Name_Value.Columns[1].FillWeight = 70;
                DG_Name_Value.Columns[2].FillWeight = 100;
            }
        }

        private void DG_Name_Value_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//双击单元格时 将单前单元格的内容添加到文本框中
        {
            Txt_Code.AppendText("{" + Lb_BlockName.SelectedItem.ToString() + "." + DG_Name_Value.Rows[e.RowIndex].Cells[1].Value.ToString() + "}");
            Txt_Code.Focus();
            Txt_Code.Select(Txt_Code.TextLength, 0);//光标定位到文本最后
            Txt_Code.ScrollToCaret();
        }
    }
}
