namespace DispenseAPP
{
    partial class FrmIfSwitchPort
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.cmb_BlockName = new System.Windows.Forms.ComboBox();
            this.cmb_MeasureValue = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtn_True = new System.Windows.Forms.RadioButton();
            this.rbtn_False = new System.Windows.Forms.RadioButton();
            this.rbtn_Invalid = new System.Windows.Forms.RadioButton();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.Location = new System.Drawing.Point(3, 1);
            this.lbl_ProjectName.Size = new System.Drawing.Size(65, 20);
            this.lbl_ProjectName.Text = "流程控制";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "算子块名";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "测量值";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Port
            // 
            this.txt_Port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Port.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Port.Location = new System.Drawing.Point(86, 41);
            this.txt_Port.Multiline = true;
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.ReadOnly = true;
            this.txt_Port.Size = new System.Drawing.Size(197, 23);
            this.txt_Port.TabIndex = 4;
            this.txt_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmb_BlockName
            // 
            this.cmb_BlockName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_BlockName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_BlockName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_BlockName.FormattingEnabled = true;
            this.cmb_BlockName.Location = new System.Drawing.Point(86, 84);
            this.cmb_BlockName.Name = "cmb_BlockName";
            this.cmb_BlockName.Size = new System.Drawing.Size(197, 25);
            this.cmb_BlockName.TabIndex = 5;
            this.cmb_BlockName.DropDown += new System.EventHandler(this.cmb_BlockName_DropDown);
            this.cmb_BlockName.SelectedIndexChanged += new System.EventHandler(this.cmb_BlockName_SelectedIndexChanged);
            // 
            // cmb_MeasureValue
            // 
            this.cmb_MeasureValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MeasureValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_MeasureValue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_MeasureValue.FormattingEnabled = true;
            this.cmb_MeasureValue.Location = new System.Drawing.Point(86, 129);
            this.cmb_MeasureValue.Name = "cmb_MeasureValue";
            this.cmb_MeasureValue.Size = new System.Drawing.Size(197, 25);
            this.cmb_MeasureValue.TabIndex = 6;
            this.cmb_MeasureValue.DropDown += new System.EventHandler(this.cmb_MeasureValue_DropDown);
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(19, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "为";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbtn_True
            // 
            this.rbtn_True.AutoSize = true;
            this.rbtn_True.Checked = true;
            this.rbtn_True.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtn_True.Location = new System.Drawing.Point(86, 176);
            this.rbtn_True.Name = "rbtn_True";
            this.rbtn_True.Size = new System.Drawing.Size(56, 21);
            this.rbtn_True.TabIndex = 8;
            this.rbtn_True.TabStop = true;
            this.rbtn_True.Text = " True";
            this.rbtn_True.UseVisualStyleBackColor = true;
            // 
            // rbtn_False
            // 
            this.rbtn_False.AutoSize = true;
            this.rbtn_False.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtn_False.Location = new System.Drawing.Point(86, 209);
            this.rbtn_False.Name = "rbtn_False";
            this.rbtn_False.Size = new System.Drawing.Size(59, 21);
            this.rbtn_False.TabIndex = 9;
            this.rbtn_False.TabStop = true;
            this.rbtn_False.Text = " False";
            this.rbtn_False.UseVisualStyleBackColor = true;
            // 
            // rbtn_Invalid
            // 
            this.rbtn_Invalid.AutoSize = true;
            this.rbtn_Invalid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtn_Invalid.Location = new System.Drawing.Point(86, 242);
            this.rbtn_Invalid.Name = "rbtn_Invalid";
            this.rbtn_Invalid.Size = new System.Drawing.Size(68, 21);
            this.rbtn_Invalid.TabIndex = 10;
            this.rbtn_Invalid.TabStop = true;
            this.rbtn_Invalid.Text = " Invaild";
            this.rbtn_Invalid.UseVisualStyleBackColor = true;
            // 
            // btn_Ok
            // 
            this.btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ok.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Ok.Location = new System.Drawing.Point(230, 186);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 31);
            this.btn_Ok.TabIndex = 11;
            this.btn_Ok.Text = "确定";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(230, 237);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 31);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // FrmIfSwitchPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(328, 279);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.rbtn_Invalid);
            this.Controls.Add(this.rbtn_False);
            this.Controls.Add(this.rbtn_True);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_BlockName);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_MeasureValue);
            this.MaxVisible = false;
            this.Name = "FrmIfSwitchPort";
            this.Text = "流程控制";
            this.TitleVisiable = false;
            this.Controls.SetChildIndex(this.cmb_MeasureValue, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txt_Port, 0);
            this.Controls.SetChildIndex(this.cmb_BlockName, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.rbtn_True, 0);
            this.Controls.SetChildIndex(this.rbtn_False, 0);
            this.Controls.SetChildIndex(this.rbtn_Invalid, 0);
            this.Controls.SetChildIndex(this.btn_Ok, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.ComboBox cmb_BlockName;
        private System.Windows.Forms.ComboBox cmb_MeasureValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtn_True;
        private System.Windows.Forms.RadioButton rbtn_False;
        private System.Windows.Forms.RadioButton rbtn_Invalid;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
    }
}