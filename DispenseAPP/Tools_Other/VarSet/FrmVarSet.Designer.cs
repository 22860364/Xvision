namespace DispenseAPP.OtherTools.VariableSetTools
{
    partial class FrmVariableSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_Var = new System.Windows.Forms.DataGridView();
            this.Col_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_VariableSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_OPeration = new System.Windows.Forms.GroupBox();
            this.cmb_MeasureValue = new System.Windows.Forms.ComboBox();
            this.rbtn_Decrement = new System.Windows.Forms.RadioButton();
            this.rbtn_Increment = new System.Windows.Forms.RadioButton();
            this.rbtn_Invalid = new System.Windows.Forms.RadioButton();
            this.rbtn_Constant = new System.Windows.Forms.RadioButton();
            this.rbtn_SetInitialValue = new System.Windows.Forms.RadioButton();
            this.rbtn_SetMeasureValue = new System.Windows.Forms.RadioButton();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.btn_VariableList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Var)).BeginInit();
            this.gb_OPeration.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(65, 20);
            this.lbl_Title.Text = "变量设置";
            // 
            // DG_Var
            // 
            this.DG_Var.AllowUserToAddRows = false;
            this.DG_Var.AllowUserToDeleteRows = false;
            this.DG_Var.AllowUserToResizeColumns = false;
            this.DG_Var.AllowUserToResizeRows = false;
            this.DG_Var.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Var.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Var.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_Var.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_Var.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Type,
            this.Col_VariableSet,
            this.Col_Operator});
            this.DG_Var.Location = new System.Drawing.Point(1, 30);
            this.DG_Var.Name = "DG_Var";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Var.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_Var.RowHeadersVisible = false;
            this.DG_Var.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DG_Var.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DG_Var.RowTemplate.Height = 23;
            this.DG_Var.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Var.Size = new System.Drawing.Size(582, 268);
            this.DG_Var.TabIndex = 0;
            this.DG_Var.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Var_CellClick);
            // 
            // Col_Type
            // 
            this.Col_Type.DataPropertyName = "Type";
            this.Col_Type.FillWeight = 20F;
            this.Col_Type.HeaderText = "类型";
            this.Col_Type.Name = "Col_Type";
            this.Col_Type.ReadOnly = true;
            this.Col_Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_VariableSet
            // 
            this.Col_VariableSet.DataPropertyName = "VarName";
            this.Col_VariableSet.FillWeight = 40F;
            this.Col_VariableSet.HeaderText = "变量名称";
            this.Col_VariableSet.Name = "Col_VariableSet";
            this.Col_VariableSet.ReadOnly = true;
            this.Col_VariableSet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_VariableSet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_Operator
            // 
            this.Col_Operator.DataPropertyName = "Operation";
            this.Col_Operator.HeaderText = "操作";
            this.Col_Operator.Name = "Col_Operator";
            this.Col_Operator.ReadOnly = true;
            // 
            // gb_OPeration
            // 
            this.gb_OPeration.Controls.Add(this.cmb_MeasureValue);
            this.gb_OPeration.Controls.Add(this.rbtn_Decrement);
            this.gb_OPeration.Controls.Add(this.rbtn_Increment);
            this.gb_OPeration.Controls.Add(this.rbtn_Invalid);
            this.gb_OPeration.Controls.Add(this.rbtn_Constant);
            this.gb_OPeration.Controls.Add(this.rbtn_SetInitialValue);
            this.gb_OPeration.Controls.Add(this.rbtn_SetMeasureValue);
            this.gb_OPeration.Location = new System.Drawing.Point(1, 304);
            this.gb_OPeration.Name = "gb_OPeration";
            this.gb_OPeration.Size = new System.Drawing.Size(480, 211);
            this.gb_OPeration.TabIndex = 1;
            this.gb_OPeration.TabStop = false;
            this.gb_OPeration.Text = "操作";
            // 
            // cmb_MeasureValue
            // 
            this.cmb_MeasureValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MeasureValue.Enabled = false;
            this.cmb_MeasureValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_MeasureValue.FormattingEnabled = true;
            this.cmb_MeasureValue.Location = new System.Drawing.Point(113, 21);
            this.cmb_MeasureValue.Name = "cmb_MeasureValue";
            this.cmb_MeasureValue.Size = new System.Drawing.Size(356, 25);
            this.cmb_MeasureValue.TabIndex = 17;
            this.cmb_MeasureValue.DropDown += new System.EventHandler(this.Cmb_MeasureValue_DropDown);
            // 
            // rbtn_Decrement
            // 
            this.rbtn_Decrement.AutoSize = true;
            this.rbtn_Decrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_Decrement.Location = new System.Drawing.Point(7, 188);
            this.rbtn_Decrement.Name = "rbtn_Decrement";
            this.rbtn_Decrement.Size = new System.Drawing.Size(49, 21);
            this.rbtn_Decrement.TabIndex = 11;
            this.rbtn_Decrement.Text = "自减";
            this.rbtn_Decrement.UseVisualStyleBackColor = true;
            this.rbtn_Decrement.CheckedChanged += new System.EventHandler(this.Rbtn_Decrement_CheckedChanged);
            // 
            // rbtn_Increment
            // 
            this.rbtn_Increment.AutoSize = true;
            this.rbtn_Increment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_Increment.Location = new System.Drawing.Point(7, 155);
            this.rbtn_Increment.Name = "rbtn_Increment";
            this.rbtn_Increment.Size = new System.Drawing.Size(49, 21);
            this.rbtn_Increment.TabIndex = 10;
            this.rbtn_Increment.Text = "自增";
            this.rbtn_Increment.UseVisualStyleBackColor = true;
            this.rbtn_Increment.CheckedChanged += new System.EventHandler(this.Rbtn_Increment_CheckedChanged);
            // 
            // rbtn_Invalid
            // 
            this.rbtn_Invalid.AutoSize = true;
            this.rbtn_Invalid.Checked = true;
            this.rbtn_Invalid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_Invalid.Location = new System.Drawing.Point(7, 124);
            this.rbtn_Invalid.Name = "rbtn_Invalid";
            this.rbtn_Invalid.Size = new System.Drawing.Size(37, 21);
            this.rbtn_Invalid.TabIndex = 9;
            this.rbtn_Invalid.TabStop = true;
            this.rbtn_Invalid.Text = "无";
            this.rbtn_Invalid.UseVisualStyleBackColor = true;
            this.rbtn_Invalid.CheckedChanged += new System.EventHandler(this.Rbtn_Invalid_CheckedChanged);
            // 
            // rbtn_Constant
            // 
            this.rbtn_Constant.AutoSize = true;
            this.rbtn_Constant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_Constant.Location = new System.Drawing.Point(7, 89);
            this.rbtn_Constant.Name = "rbtn_Constant";
            this.rbtn_Constant.Size = new System.Drawing.Size(73, 21);
            this.rbtn_Constant.TabIndex = 8;
            this.rbtn_Constant.Text = "设为常量";
            this.rbtn_Constant.UseVisualStyleBackColor = true;
            this.rbtn_Constant.CheckedChanged += new System.EventHandler(this.Rbtn_Constant_CheckedChanged);
            // 
            // rbtn_SetInitialValue
            // 
            this.rbtn_SetInitialValue.AutoSize = true;
            this.rbtn_SetInitialValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_SetInitialValue.Location = new System.Drawing.Point(7, 54);
            this.rbtn_SetInitialValue.Name = "rbtn_SetInitialValue";
            this.rbtn_SetInitialValue.Size = new System.Drawing.Size(85, 21);
            this.rbtn_SetInitialValue.TabIndex = 7;
            this.rbtn_SetInitialValue.Text = "设为初始值";
            this.rbtn_SetInitialValue.UseVisualStyleBackColor = true;
            this.rbtn_SetInitialValue.CheckedChanged += new System.EventHandler(this.Rbtn_SetInitialValue_CheckedChanged);
            // 
            // rbtn_SetMeasureValue
            // 
            this.rbtn_SetMeasureValue.AutoSize = true;
            this.rbtn_SetMeasureValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_SetMeasureValue.Location = new System.Drawing.Point(7, 22);
            this.rbtn_SetMeasureValue.Name = "rbtn_SetMeasureValue";
            this.rbtn_SetMeasureValue.Size = new System.Drawing.Size(85, 21);
            this.rbtn_SetMeasureValue.TabIndex = 6;
            this.rbtn_SetMeasureValue.Text = "设为测量值";
            this.rbtn_SetMeasureValue.UseVisualStyleBackColor = true;
            this.rbtn_SetMeasureValue.CheckedChanged += new System.EventHandler(this.Rbtn_SetMeasureValue_CheckedChanged);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(496, 452);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(80, 32);
            this.Btn_Cancel.TabIndex = 16;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(496, 386);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(80, 32);
            this.Btn_OK.TabIndex = 15;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // btn_VariableList
            // 
            this.btn_VariableList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VariableList.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_VariableList.Location = new System.Drawing.Point(496, 319);
            this.btn_VariableList.Name = "btn_VariableList";
            this.btn_VariableList.Size = new System.Drawing.Size(80, 32);
            this.btn_VariableList.TabIndex = 14;
            this.btn_VariableList.Text = "变量列表";
            this.btn_VariableList.UseVisualStyleBackColor = true;
            this.btn_VariableList.Click += new System.EventHandler(this.Btn_VariableList_Click);
            // 
            // FrmVarSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(584, 517);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.btn_VariableList);
            this.Controls.Add(this.gb_OPeration);
            this.Controls.Add(this.DG_Var);
            this.Name = "FrmVarSet";
            this.Text = "变量设置";
            this.Controls.SetChildIndex(this.DG_Var, 0);
            this.Controls.SetChildIndex(this.gb_OPeration, 0);
            this.Controls.SetChildIndex(this.btn_VariableList, 0);
            this.Controls.SetChildIndex(this.Btn_OK, 0);
            this.Controls.SetChildIndex(this.Btn_Cancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Var)).EndInit();
            this.gb_OPeration.ResumeLayout(false);
            this.gb_OPeration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Var;
        private System.Windows.Forms.GroupBox gb_OPeration;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button btn_VariableList;
        private System.Windows.Forms.RadioButton rbtn_Decrement;
        private System.Windows.Forms.RadioButton rbtn_Increment;
        private System.Windows.Forms.RadioButton rbtn_Invalid;
        private System.Windows.Forms.RadioButton rbtn_Constant;
        private System.Windows.Forms.RadioButton rbtn_SetInitialValue;
        private System.Windows.Forms.RadioButton rbtn_SetMeasureValue;
        private System.Windows.Forms.ComboBox cmb_MeasureValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_VariableSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Operator;
    }
}