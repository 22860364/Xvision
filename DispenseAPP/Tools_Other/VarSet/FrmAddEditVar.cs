using DispenseAPP.AboutData;
using DispenseAPP.CustomControl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Documents;
using System.Windows.Forms;

namespace DispenseAPP.OtherTools.VariableSetTools
{
    public partial class FrmAddEditVar : FormM
    {
        private VarCollectionClass _varStruct;
        public FrmAddEditVar(VarCollectionClass varCollection)
        {
            InitializeComponent();
            InitialDynamicControl();//初始化动态控件
            _varStruct = varCollection;
            txt_Name.Text = _varStruct.VarName;
            cmb_Type.SelectedItem = _varStruct.VarType;
            txt_Remark.Text = _varStruct.VarRemark;
            switch (cmb_Type.SelectedItem.ToString())
            {
                case "N":
                    num_Value.Visible = true;
                    num_Value.Value = Convert.ToDecimal(_varStruct.VarValue);
                    break;
                case "S":
                    txt_Value.Enabled = true;
                    txt_Value.Visible = true;
                    txt_Value.Text = _varStruct.VarValue.ToString();
                    break;
                case "B":
                    rbtn_False.Visible = true;
                    rbtn_True.Visible = true;
                    switch (Convert.ToBoolean(_varStruct.VarValue))
                    {
                        case true:
                            rbtn_True.Checked = true;
                            break;
                        case false:
                            rbtn_False.Checked = false;
                            break;
                    }
                    break;
                case "P":
                    lbl_X.Visible = true;
                    lbl_Y.Visible = true;
                    num_X.Visible = true;
                    num_Y.Visible = true;
                    num_X.Value = ((Point)_varStruct.VarValue).X;
                    num_Y.Value = ((Point)_varStruct.VarValue).Y;
                    break;
                case "N[]":
                case "S[]":
                case "B[]":
                case "P[]":
                    txt_Value.Visible = true;
                    txt_Value.Text = "[]";
                    txt_Value.Enabled = false;
                    break;
            }
            if(FrmVarList.EditState == true)
            {
                cmb_Type.Enabled = false;
            }
        }

        public event EditConfirmDelegate _clickOKEvent;


        //N类型的变量
        private NumericUpDown num_Value = new NumericUpDown();
        //S类型的变量
        private TextBox txt_Value = new TextBox();
        //B类型变量
        private RadioButton rbtn_True = new RadioButton();
        private RadioButton rbtn_False = new RadioButton();
        //P类型的变量
        private Label lbl_X = new Label();
        private Label lbl_Y = new Label();
        private NumericUpDown num_X = new NumericUpDown();
        private NumericUpDown num_Y = new NumericUpDown();
        private List<Control> dynamicList = new List<Control>();

        private void InitialDynamicControl()
        {
            //P类型的变量
            lbl_X.Location = new Point(75, 126);
            lbl_X.Size = new Size(28, 17);
            lbl_X.Text = "X:";
            lbl_X.Visible = false;
            Controls.Add(lbl_X);
            dynamicList.Add(lbl_X);
            lbl_Y.Location = new Point(202, 126);
            lbl_Y.Size = new Size(27, 17);
            lbl_Y.Text = "Y:";
            lbl_Y.Visible = false;
            Controls.Add(lbl_Y);
            dynamicList.Add(lbl_Y);
            num_X.DecimalPlaces = 4;
            num_X.Location = new Point(108, 124);
            num_X.Minimum = -100000;
            num_X.Maximum = 100000;
            num_X.Size = new Size(87, 23);
            num_X.Visible = false;
            Controls.Add(num_X);
            dynamicList.Add(num_X);
            num_Y.DecimalPlaces = 4;
            num_Y.Location = new Point(235, 124);
            num_Y.Size = new Size(87, 23);
            num_Y.Minimum = -100000;
            num_Y.Maximum = 100000;
            num_Y.Visible = false;
            dynamicList.Add(num_X);
            Controls.Add(num_Y);
            //N类型的变量
            num_Value.DecimalPlaces = 8;
            num_Value.Location = new Point(83, 121);
            num_Value.Size = new Size(149, 25);
            num_Value.Minimum = -1000000000;
            num_Value.Maximum = 1000000000;
            num_Value.Visible = false;
            Controls.Add(num_Value);
            dynamicList.Add(num_Value);
            //B类型的变量
            rbtn_True.Location = new Point(83, 124);
            rbtn_True.Size = new Size(52, 21);
            rbtn_True.Text = "True";
            rbtn_True.UseVisualStyleBackColor = true;
            rbtn_True.Visible = false;
            Controls.Add(rbtn_True);
            dynamicList.Add(rbtn_True);
            rbtn_False.Location = new Point(202, 126);
            rbtn_False.Size = new Size(55, 21);
            rbtn_False.Text = "False";
            rbtn_False.UseVisualStyleBackColor = true;
            rbtn_False.Visible = false;
            Controls.Add(rbtn_False);
            dynamicList.Add(rbtn_False);
            //S类型的变量
            txt_Value.Location = new Point(83, 123);
            txt_Value.Size = new Size(208, 23);
            txt_Value.Visible = false;
            Controls.Add(txt_Value);
            dynamicList.Add(txt_Value);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            _varStruct.VarType = cmb_Type.SelectedItem.ToString();//变量类型
            _varStruct.VarRemark = txt_Remark.Text;//变量备注                 
            switch (cmb_Type.SelectedItem.ToString())
            {
                case "N":
                    _varStruct.VarValue = num_Value.Value;
                    break;
                case "S":
                    _varStruct.VarValue = txt_Value.Text.Trim();
                    break;
                case "B":
                    if (rbtn_True.Checked == true)
                    {
                        _varStruct.VarValue = true;
                    }
                    else
                    {
                        _varStruct.VarValue = false;
                    }
                    break;
                case "P":
                    _varStruct.VarValue = new PointF((float)num_X.Value, (float)num_Y.Value);
                    break;
                case "N[]":
                    _varStruct.VarValue = new List<decimal>();
                    break;
                case "S[]":
                    _varStruct.VarValue = new List<string>();
                    break;
                case "B[]":
                    _varStruct.VarValue = new List<bool>();
                    break;
                case "P[]":
                    _varStruct.VarValue = new List<PointF>();
                    break;
            }
            _clickOKEvent(_varStruct);
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmb_Type_SelectedIndexChanged(object sender, EventArgs e)//当combobox的索引发生变化时
        {
            foreach (Control item in dynamicList)
            {
                item.Visible = false;
            }
            switch (cmb_Type.SelectedItem.ToString())
            {
                case "N":
                    num_Value.Visible = true;
                    break;
                case "S":
                    txt_Value.Text = null;
                    txt_Value.Enabled = true;
                    txt_Value.Visible = true;
                    break;
                case "B":
                    rbtn_False.Visible = true;
                    rbtn_True.Checked = true;
                    rbtn_True.Visible = true;
                    break;
                case "P":
                    lbl_X.Visible = true;
                    lbl_Y.Visible = true;
                    num_X.Visible = true;
                    num_Y.Visible = true;
                    break;
                case "N[]":
                case "S[]":
                case "B[]":
                case "P[]":
                    txt_Value.Visible = true;
                    txt_Value.Text = "[]";
                    txt_Value.Enabled = false;
                    break;
            }
        }
    }
}
