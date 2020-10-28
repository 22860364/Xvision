using DispenseAPP.AboutData;
using DispenseAPP.CustomControl;
using DispenseAPP.Tools_Other.VarSet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.OtherTools.VariableSetTools
{
    public enum ExecuteOperationEnum
    {
        SetMeasurement,//设为测量值
        SetInitialValue,//设为初始值
        SetConstant,//设置常量
        Invalid,//无
        Increment,//自增
        Decrement,//自减
    }

    public partial class FrmVariableSet : FormM
    {
        private Button btn_Edit = new Button();//编辑按钮

        private NumericUpDown num_Value = new NumericUpDown();//更改数值

        private TextBox txt_Value = new TextBox();//更改文本

        private CheckBox ck_Value = new CheckBox();//更改布尔

        private Label lbl_X = new Label();
        private Label lbl_Y = new Label();

        private NumericUpDown num_X = new NumericUpDown();
        private NumericUpDown num_Y = new NumericUpDown();//更改Point

        private VarSetToolEntity _varSetClass;

        int row_Index = 0;

        List<Control> _currentDispControl = new List<Control>();

        SetVarClass _currentVar = null;//获得当前选择的变量类型 

        public FrmVariableSet( VarSetToolEntity varSetClass)
        {
            InitializeComponent();
            DG_Var.AutoGenerateColumns = false;
            _varSetClass = varSetClass;
            InitialEditButton();
        }

        private void InitialEditButton()
        {            
            //编辑按钮  当选择的类型为数组时
            btn_Edit.FlatStyle = FlatStyle.Flat;
            btn_Edit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btn_Edit.Location = new System.Drawing.Point(113, 87);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new System.Drawing.Size(76, 25);
            btn_Edit.Text = "编辑";
            btn_Edit.Click += Btn_Edit_Click;
            btn_Edit.Visible = false;
            gb_OPeration.Controls.Add(btn_Edit);
            //当选择的类型为decimal时
            num_Value.Location = new System.Drawing.Point(113, 87);
            num_Value.Size = new System.Drawing.Size(129, 23);
            num_Value.DecimalPlaces = 8;
            num_Value.Maximum = 1000000000;
            num_Value.Minimum = -1000000000;
            num_Value.Visible = false;
            num_Value.ValueChanged += Num_Value_ValueChanged;
            gb_OPeration.Controls.Add(num_Value);
            //当选择的为string时
            txt_Value.Location = new System.Drawing.Point(113, 89);
            txt_Value.Multiline = true;
            txt_Value.Size = new System.Drawing.Size(315, 25);
            txt_Value.Visible = false;
            txt_Value.TextChanged += Txt_Value_TextChanged;
            gb_OPeration.Controls.Add(txt_Value);
            //当选择的为Poiint
            lbl_X.Location = new System.Drawing.Point(109, 91);
            lbl_X.Size = new System.Drawing.Size(28, 19);
            lbl_X.Text = "X：";
            lbl_X.Visible = false;
            gb_OPeration.Controls.Add(lbl_X);
            lbl_Y.Location = new System.Drawing.Point(291, 91);
            lbl_Y.Size = new System.Drawing.Size(28, 17);
            lbl_Y.Text = "Y：";
            lbl_Y.Visible = false;
            gb_OPeration.Controls.Add(lbl_Y);
            num_X.Location = new System.Drawing.Point(140, 89);
            num_X.Size = new System.Drawing.Size(120, 23);
            num_X.Maximum = 10000;
            num_X.Minimum = -1000;
            num_X.DecimalPlaces = 4;
            num_X.ValueChanged += Num_X_ValueChanged;
            num_X.Visible = false;
            gb_OPeration.Controls.Add(num_X);
            num_Y.Location = new System.Drawing.Point(320, 89);
            num_Y.Size = new System.Drawing.Size(120, 23);
            num_Y.Maximum = 10000;
            num_Y.Minimum = -1000;
            num_Y.DecimalPlaces = 4;
            num_Y.Visible = false;
            num_Y.ValueChanged += Num_Y_ValueChanged;
            gb_OPeration.Controls.Add(num_Y);
            ck_Value.AutoSize = true;
            ck_Value.FlatStyle = FlatStyle.Flat;
            ck_Value.Location = new System.Drawing.Point(113, 89);
            ck_Value.Size = new System.Drawing.Size(50, 21);
            ck_Value.Text = "True";
            ck_Value.Visible = false;
            ck_Value.CheckedChanged += Ck_Value_CheckedChanged;
            gb_OPeration.Controls.Add(ck_Value);
            foreach (VarCollectionClass item in StaticPublicData.VariableData.varList)
            {
                if (_varSetClass.setVarList.Find(c => c.VarName == item.VarName) == null)
                {
                    SetVarClass setVar = new SetVarClass
                    {
                        Type = item.VarType,
                        VarName = item.VarName,
                        ExecuteOper = ExecuteOperationEnum.Invalid
                    };
                    _varSetClass.setVarList.Add(setVar);
                }
            }
            DG_Var.DataSource = new BindingList<SetVarClass>(_varSetClass.setVarList);
            if (_varSetClass.setVarList.Count == 0)
            {
                gb_OPeration.Enabled = false;
                DG_Var.Enabled = false;
            }
            else
            {
                DG_Var_CellClick(DG_Var, new DataGridViewCellEventArgs(0, 0));
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)//单击编辑事件 弹出数组对话框
        {
            FrmEditVars frmEditVars = new FrmEditVars(_currentVar);
            frmEditVars.ShowDialog();
            DG_Var.UpdateCellValue(2, row_Index);
        }

        private void Ck_Value_CheckedChanged(object sender, EventArgs e)//复选框发生变化
        {
            _currentVar.Operation = "Set To " + ck_Value.Checked.ToString();
            DG_Var.UpdateCellValue(2, row_Index);
        }

        private void Num_Y_ValueChanged(object sender, EventArgs e)//Y发生变化
        {
            _currentVar.Operation = "Set To (" + num_X.Value.ToString() + "," + num_Y.Value.ToString() + ")";
            DG_Var.UpdateCellValue(2, row_Index);
        }

        private void Num_X_ValueChanged(object sender, EventArgs e)//X发生变化
        {
            _currentVar.Operation = "Set To (" + num_X.Value.ToString() +"," + num_Y.Value.ToString() + ")";
            DG_Var.UpdateCellValue(2, row_Index);
        }

        private void Txt_Value_TextChanged(object sender, EventArgs e)//当文本控件的值发生变化时发生
        {
            _currentVar.Operation = "Set To " + txt_Value.Text.Trim();
            DG_Var.UpdateCellValue(2, row_Index);
        }

        private void Num_Value_ValueChanged(object sender, EventArgs e)//当数值控件的值发生变化时发生
        {
            _currentVar.Operation = "Set To " + num_Value.Value;
            DG_Var.UpdateCellValue(2, row_Index);
        }

        private void ChangeVarOperationState(ExecuteOperationEnum operation)
        {
            switch (operation)
            {
                case ExecuteOperationEnum.SetMeasurement:
                    rbtn_SetMeasureValue.Checked = true;
                    break;
                case ExecuteOperationEnum.SetInitialValue:
                    rbtn_SetInitialValue.Checked = true;
                    break;
                case ExecuteOperationEnum.SetConstant:
                    rbtn_Constant.Checked = true;
                    break;
                case ExecuteOperationEnum.Invalid:
                    rbtn_Invalid.Checked = true;
                    break;
                case ExecuteOperationEnum.Increment:
                    rbtn_Increment.Checked = true;
                    break;
                case ExecuteOperationEnum.Decrement:
                    rbtn_Decrement.Checked = true;
                    break;
            }
            DG_Var.UpdateCellValue(2, row_Index);
        }

        private void Btn_VariableList_Click(object sender, EventArgs e)//变量列表
        {
            FrmVarList frmVarList = new FrmVarList();
            frmVarList.ClickOkEvent += FrmVarList_clickOkEvent;
            frmVarList.ShowDialog();
        }

        private void FrmVarList_clickOkEvent()
        {
            var v = DG_Var.DataSource as BindingList<SetVarClass>;
            foreach (VarCollectionClass item in StaticPublicData.VariableData.varList)
            {
                if (_varSetClass.setVarList.Find(c => c.VarName == item.VarName) == null)
                {
                    SetVarClass setVar = new SetVarClass
                    {
                        Type = item.VarType,
                        VarName = item.VarName,
                        ExecuteOper = ExecuteOperationEnum.Invalid
                    };
                    v.Add(setVar);
                }
            }
            if (_varSetClass.setVarList.Count > 0)
            {
                gb_OPeration.Enabled = true;
                DG_Var.Enabled = true;
            }
            DG_Var_CellClick(DG_Var, new DataGridViewCellEventArgs(0, 0));
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DG_Var_CellClick(object sender, DataGridViewCellEventArgs e)//当选定不同的变量是切换不同的操作状态
        {
            if (e.RowIndex >= 0)
            {
                row_Index = e.RowIndex;
                _currentVar = _varSetClass.setVarList.Find(c => c.VarName == DG_Var.Rows[e.RowIndex].Cells[1].Value.ToString());
                if (_currentVar.Type == "N")//如果是整型 则可以自增和自减
                {
                    rbtn_Increment.Enabled = true;
                    rbtn_Decrement.Enabled = true;
                }
                else
                {
                    rbtn_Increment.Enabled = false;
                    rbtn_Decrement.Enabled = false;
                }
                foreach (Control item in _currentDispControl)//首先将控件集中的控件都不显示 
                {
                    item.Visible = false;
                }
                _currentDispControl.Clear();//然后清除
                switch (_currentVar.Type)//当选择类型的时候 将设为常量对应的控件显示出来
                {
                    case "N":
                        _currentDispControl.Add(num_Value);
                        if (_currentVar.ExecuteOper == ExecuteOperationEnum.SetConstant && _currentVar.Operation != null)
                        {
                            num_Value.Value = Convert.ToDecimal(_currentVar.Operation.Split(' ')[2]);
                        }
                        break;
                    case "S":
                        _currentDispControl.Add(txt_Value);
                        if (_currentVar.ExecuteOper == ExecuteOperationEnum.SetConstant && _currentVar.Operation != null)
                        {
                            txt_Value.Text = _currentVar.Operation.Split(' ')[2];
                        }
                        break;
                    case "B":
                        _currentDispControl.Add(ck_Value);
                        if (_currentVar.ExecuteOper == ExecuteOperationEnum.SetConstant && _currentVar.Operation != null)
                        {
                            ck_Value.Checked = Convert.ToBoolean(_currentVar.Operation.Split(' ')[2]);
                        }
                        break;
                    case "P":
                        _currentDispControl.Add(lbl_X);
                        _currentDispControl.Add(lbl_Y);
                        _currentDispControl.Add(num_X);
                        _currentDispControl.Add(num_Y);
                        if (_currentVar.ExecuteOper == ExecuteOperationEnum.SetConstant && _currentVar.Operation != null)
                        {
                            num_X.Value = Convert.ToDecimal(_currentVar.Operation.Split(' ')[2].Split(',')[0].Substring(1));
                            int index = _currentVar.Operation.Split(' ')[2].Split(',')[1].IndexOf(')');
                            num_X.Value = Convert.ToDecimal(_currentVar.Operation.Split(' ')[2].Split(',')[1].Substring(0, index));
                        }
                        break;
                    default:
                        _currentDispControl.Add(btn_Edit);
                        break;
                }
                foreach (Control item in _currentDispControl)//然后显示
                {
                    item.Visible = true;
                    if(_currentVar.ExecuteOper == ExecuteOperationEnum.SetConstant)
                    {
                        item.Enabled = true;
                    }
                    else
                    {
                        item.Enabled = false;
                    }       
                }
                if (_currentVar != null)
                {
                    ExecuteOperationEnum executeEnum = _currentVar.ExecuteOper;//根据对应的操作显示不同的rbtn 
                    ChangeVarOperationState(executeEnum);
                }
            }
        }

        private void Rbtn_SetMeasureValue_CheckedChanged(object sender, EventArgs e)//设为测量值
        {
            if (rbtn_SetMeasureValue.Checked == true)
            {
                _currentVar.ExecuteOper = ExecuteOperationEnum.SetMeasurement; //当点击【设置为测量值】时 设置当前变量的操作和操作类型
                if (cmb_MeasureValue.Items.Count == 0)
                {
                    _currentVar.Operation = "Set To Invaild Measurement";
                }
                else
                {
                    _currentVar.Operation = "Set To " + cmb_MeasureValue.SelectedItem.ToString();
                }
                DG_Var.UpdateCellValue(2, row_Index);
                cmb_MeasureValue.Enabled = true;
            }
            else
            {
                cmb_MeasureValue.Enabled = false;
            }
        }

        private void Rbtn_SetInitialValue_CheckedChanged(object sender, EventArgs e)//设为初始值
        {
            if (rbtn_SetInitialValue.Checked == true)
            {
                _currentVar.ExecuteOper = ExecuteOperationEnum.SetInitialValue;
                _currentVar.Operation = "Set To Initial Value";
                DG_Var.UpdateCellValue(2, row_Index);
            }
        }

        private void Rbtn_Constant_CheckedChanged(object sender, EventArgs e)//设为常量
        {
            if (rbtn_Constant.Checked == true)//选中状态
            {
                foreach (Control item in _currentDispControl)
                {
                    item.Enabled = true;
                }
                _currentVar.ExecuteOper = ExecuteOperationEnum.SetConstant;
                switch (_currentVar.Type)
                {
                    case "N":
                        _currentVar.Operation = "Set To " + num_Value.Value;
                        break;
                    case "S":
                        _currentVar.Operation = "Set To " + txt_Value.Text;
                        break;
                    case "B":
                        _currentVar.Operation = "Set To " + ck_Value.Checked;
                        break;
                    case "P":
                        _currentVar.Operation = "Set To (" + num_X.Value + "," + num_Y.Value + ")";
                        break;
                    case "N[]":
                    case "S[]":
                    case "B[]":
                    case "P[]":
                        if (_currentVar.Operation == null)
                        {
                            _currentVar.Operation = "Set To []";
                        }
                        break;
                };
                DG_Var.UpdateCellValue(2, row_Index);
            }
            else
            {
                foreach (Control item in _currentDispControl)
                {
                    item.Enabled = false;
                }
            }         
        }

        private void Rbtn_Invalid_CheckedChanged(object sender, EventArgs e)//无操作
        {
            if(rbtn_Invalid.Checked == true)
            {
                _currentVar.ExecuteOper = ExecuteOperationEnum.Invalid;
                _currentVar.Operation = null;
                DG_Var.UpdateCellValue(2, row_Index);
            }
        }

        private void Rbtn_Increment_CheckedChanged(object sender, EventArgs e)//自增
        {
            if(rbtn_Increment.Checked == true)
            {
                _currentVar.ExecuteOper = ExecuteOperationEnum.Increment;
                _currentVar.Operation = null;
                DG_Var.UpdateCellValue(2, row_Index);
            }
        }

        private void Rbtn_Decrement_CheckedChanged(object sender, EventArgs e)//自减
        {
            if(rbtn_Decrement.Checked == true)
            {
                _currentVar.ExecuteOper = ExecuteOperationEnum.Decrement;
                _currentVar.Operation = null;
                DG_Var.UpdateCellValue(2, row_Index);
            }
        }

        private void Cmb_MeasureValue_DropDown(object sender, EventArgs e)
        {
            if (cmb_MeasureValue.Items.Count == 0)
            {
                cmb_MeasureValue.DropDownHeight = 1;
            }
        }
    }
}
