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
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.txt_Remark = new System.Windows.Forms.TextBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(65, 20);
            this.lbl_Title.Text = "增加变量";
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
            // Txt_Name
            // 
            this.Txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_Name.Location = new System.Drawing.Point(83, 32);
            this.Txt_Name.Multiline = true;
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(208, 26);
            this.Txt_Name.TabIndex = 4;
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
            this.cmb_Type.SelectedIndexChanged += new System.EventHandler(this.Cmb_Type_SelectedIndexChanged);
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
            // Btn_Cancel
            // 
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(214, 211);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(77, 29);
            this.Btn_Cancel.TabIndex = 43;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(83, 211);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(77, 29);
            this.Btn_OK.TabIndex = 42;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // FrmAddEditVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(324, 249);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.txt_Remark);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.lbl_Remark);
            this.Controls.Add(this.lbl_Value);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.cmb_Type);
            this.Name = "FrmAddEditVar";
            this.Text = "增加变量";
            this.Controls.SetChildIndex(this.cmb_Type, 0);
            this.Controls.SetChildIndex(this.lbl_Name, 0);
            this.Controls.SetChildIndex(this.lbl_Type, 0);
            this.Controls.SetChildIndex(this.lbl_Value, 0);
            this.Controls.SetChildIndex(this.lbl_Remark, 0);
            this.Controls.SetChildIndex(this.Txt_Name, 0);
            this.Controls.SetChildIndex(this.txt_Remark, 0);
            this.Controls.SetChildIndex(this.Btn_OK, 0);
            this.Controls.SetChildIndex(this.Btn_Cancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_Value;
        private System.Windows.Forms.Label lbl_Remark;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.TextBox txt_Remark;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
    }
}