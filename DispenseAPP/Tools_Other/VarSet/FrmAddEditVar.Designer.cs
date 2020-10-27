namespace DispenseAPP.OtherTools.VariableSetTools
{
    partial class FrmAddEditVar
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.lbl_Value = new System.Windows.Forms.Label();
            this.lbl_Remark = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.txt_Remark = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.Location = new System.Drawing.Point(3, 1);
            this.lbl_ProjectName.Size = new System.Drawing.Size(74, 21);
            this.lbl_ProjectName.Text = "增加变量";
            // 
            // lbl_Name
            // 
            this.lbl_Name.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Name.Location = new System.Drawing.Point(14, 32);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(61, 26);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "名称";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Type
            // 
            this.lbl_Type.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Type.Location = new System.Drawing.Point(14, 75);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(61, 26);
            this.lbl_Type.TabIndex = 1;
            this.lbl_Type.Text = "类型";
            this.lbl_Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Value
            // 
            this.lbl_Value.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Value.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Value.Location = new System.Drawing.Point(14, 121);
            this.lbl_Value.Name = "lbl_Value";
            this.lbl_Value.Size = new System.Drawing.Size(61, 26);
            this.lbl_Value.TabIndex = 2;
            this.lbl_Value.Text = "值";
            this.lbl_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Remark
            // 
            this.lbl_Remark.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Remark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Remark.Location = new System.Drawing.Point(14, 164);
            this.lbl_Remark.Name = "lbl_Remark";
            this.lbl_Remark.Size = new System.Drawing.Size(61, 26);
            this.lbl_Remark.TabIndex = 3;
            this.lbl_Remark.Text = "备注";
            this.lbl_Remark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Name.Location = new System.Drawing.Point(83, 32);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(208, 26);
            this.txt_Name.TabIndex = 4;
            // 
            // cmb_Type
            // 
            this.cmb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Type.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Items.AddRange(new object[] {
            "N",
            "S",
            "B",
            "P",
            "N[]",
            "S[]",
            "B[]",
            "P[]"});
            this.cmb_Type.Location = new System.Drawing.Point(83, 77);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(74, 25);
            this.cmb_Type.TabIndex = 5;
            this.cmb_Type.SelectedIndexChanged += new System.EventHandler(this.cmb_Type_SelectedIndexChanged);
            // 
            // txt_Remark
            // 
            this.txt_Remark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Remark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Remark.Location = new System.Drawing.Point(83, 164);
            this.txt_Remark.Multiline = true;
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(208, 26);
            this.txt_Remark.TabIndex = 6;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(228, 211);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(77, 29);
            this.btn_Cancel.TabIndex = 43;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(97, 211);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(77, 29);
            this.btn_OK.TabIndex = 42;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // FrmAddEditVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(335, 249);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_Remark);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Remark);
            this.Controls.Add(this.lbl_Value);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.cmb_Type);
            this.MaxVisible = false;
            this.Name = "FrmAddEditVar";
            this.Text = "增加变量";
            this.TitleVisiable = false;
            this.Controls.SetChildIndex(this.cmb_Type, 0);
            this.Controls.SetChildIndex(this.lbl_Name, 0);
            this.Controls.SetChildIndex(this.lbl_Type, 0);
            this.Controls.SetChildIndex(this.lbl_Value, 0);
            this.Controls.SetChildIndex(this.lbl_Remark, 0);
            this.Controls.SetChildIndex(this.txt_Name, 0);
            this.Controls.SetChildIndex(this.txt_Remark, 0);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_Value;
        private System.Windows.Forms.Label lbl_Remark;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.TextBox txt_Remark;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
    }
}