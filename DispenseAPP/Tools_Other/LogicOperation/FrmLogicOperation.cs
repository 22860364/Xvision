using DispenseAPP.CustomControl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace DispenseAPP.Tools_Other.LogicOperation
{
    public partial class FrmLogicOperation : FormM
    {
        private Dictionary<string, List<BlockNameValue>> referenceData = new Dictionary<string, List<BlockNameValue>>();

        private LogicOperationClass _logicOperationClass = new LogicOperationClass();

        public FrmLogicOperation(LogicOperationClass logicOperationClass)
        {
            InitializeComponent();
            _logicOperationClass = logicOperationClass;
            InitialReference();
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

        private void InitialReference()//初始化变量引用
        {
            List<ITools> toolsList = _logicOperationClass.SelectedNormalBlock.ToolsList.GetRange(0, FrmEdit._currentRowIndex+ 1);
            if (toolsList != null)
            {
                foreach (var item in toolsList)//遍历当前普通算子块中的工具
                {
                    Lb_BlockName.Items.Add(item.BlockName);
                    List<BlockNameValue> blockList = new List<BlockNameValue>();
                    foreach (PropertyInfo items in item.GetType().GetProperties())//获得当前遍历到的工具的所有的属性
                    {
                        if (items.IsDefined(typeof(ReferenceAttribute), true))
                        {
                            if (item.StepState == true || (item.StepState == false && (items.GetCustomAttribute(typeof(ReferenceAttribute)) as ReferenceAttribute).ExecuteState == true))//进入if的条件是 执行结果为true 或者 执行结果为false && 标记的特性为true 
                            {
                                object obj = items.GetValue(item, null);
                                if (obj is Array)//当前数据为数组
                                {
                                    double[] d = obj as double[];
                                    if (obj is PointF[] pointF)
                                    {
                                        for (int i = 0; i < pointF.Length; i++)
                                        {
                                            BlockNameValue PointFNameValueX = new BlockNameValue
                                            {
                                                Name = items.Name + "[" + i.ToString() + "].X",
                                                Type = "N",
                                                Value = pointF[i].X.ToString("f3")
                                            };
                                            blockList.Add(PointFNameValueX);
                                            BlockNameValue PointFNameValueY = new BlockNameValue
                                            {
                                                Name = items.Name + "[" + i.ToString() + "].Y",
                                                Type = "N",
                                                Value = pointF[i].Y.ToString("f3")
                                            };
                                            blockList.Add(PointFNameValueY);
                                        }
                                    }
                                    else if (d != null)
                                    {
                                        for (int i = 0; i < d.Length; i++)
                                        {
                                            BlockNameValue PointFNameValueD = new BlockNameValue
                                            {
                                                Name = items.Name + "[" + i.ToString() + "]",
                                                Type = "N",
                                                Value = d[i].ToString("f3")
                                            };
                                            blockList.Add(PointFNameValueD);
                                        }
                                    }
                                }
                                else
                                {
                                    BlockNameValue blockNameVlaue = new BlockNameValue
                                    {
                                        Name = items.Name,
                                        Value = items.GetValue(item).ToString()
                                    };
                                    switch (items.PropertyType.ToString())
                                    {
                                        case "System.Int32":
                                        case "System.Int16":
                                            blockNameVlaue.Type = "N";
                                            break;
                                        case "System.String":
                                            blockNameVlaue.Type = "S";
                                            break;
                                        case "System.Boolean":
                                            blockNameVlaue.Type = "B";
                                            break;
                                    }
                                    blockList.Add(blockNameVlaue);
                                }
                            }
                        }
                    }
                    referenceData.Add(item.BlockName, blockList);
                }
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            _logicOperationClass.Expression = Txt_Code.Text.Trim();
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
            txt_Result.Text = _logicOperationClass.AnalysisExpress(Txt_Code.Text.Trim()).ToString();
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

    public class BlockNameValue
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}
