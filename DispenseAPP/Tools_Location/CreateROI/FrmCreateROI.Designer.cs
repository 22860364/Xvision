namespace DispenseAPP.Tools_Location.CreateROI
{
    partial class FrmCreateROI
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
            this.uC_Image1 = new DispenseAPP.UC_Image();
            this.cmb_ROIType = new System.Windows.Forms.ComboBox();
            this.lbl_ROIType = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.gb_OriginalROI = new System.Windows.Forms.GroupBox();
            this.txt_Original5 = new System.Windows.Forms.TextBox();
            this.lbl_Original5 = new System.Windows.Forms.Label();
            this.txt_Original4 = new System.Windows.Forms.TextBox();
            this.lbl_Original4 = new System.Windows.Forms.Label();
            this.txt_Original3 = new System.Windows.Forms.TextBox();
            this.lbl_Original3 = new System.Windows.Forms.Label();
            this.txt_Original2 = new System.Windows.Forms.TextBox();
            this.lbl_Original2 = new System.Windows.Forms.Label();
            this.txt_Original1 = new System.Windows.Forms.TextBox();
            this.lbl_Original1 = new System.Windows.Forms.Label();
            this.gb_ROIReviseLate = new System.Windows.Forms.GroupBox();
            this.txt_Revise5 = new System.Windows.Forms.TextBox();
            this.lbl_Revise5 = new System.Windows.Forms.Label();
            this.txt_Revise4 = new System.Windows.Forms.TextBox();
            this.lbl_Revise4 = new System.Windows.Forms.Label();
            this.txt_Revise3 = new System.Windows.Forms.TextBox();
            this.lbl_Revise3 = new System.Windows.Forms.Label();
            this.txt_Revise2 = new System.Windows.Forms.TextBox();
            this.lbl_Revise2 = new System.Windows.Forms.Label();
            this.txt_Revise1 = new System.Windows.Forms.TextBox();
            this.lbl_Revise1 = new System.Windows.Forms.Label();
            this.gb_OriginalROI.SuspendLayout();
            this.gb_ROIReviseLate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.Location = new System.Drawing.Point(3, 1);
            this.lbl_ProjectName.Size = new System.Drawing.Size(61, 20);
            this.lbl_ProjectName.Text = "创建ROI";
            // 
            // uC_Image1
            // 
            this.uC_Image1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Image1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uC_Image1.Location = new System.Drawing.Point(4, 32);
            this.uC_Image1.Name = "uC_Image1";
            this.uC_Image1.Size = new System.Drawing.Size(592, 591);
            this.uC_Image1.TabIndex = 1;
            // 
            // cmb_ROIType
            // 
            this.cmb_ROIType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_ROIType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ROIType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_ROIType.FormattingEnabled = true;
            this.cmb_ROIType.Items.AddRange(new object[] {
            "线段",
            "圆",
            "椭圆",
            "平行矩形",
            "旋转矩形"});
            this.cmb_ROIType.Location = new System.Drawing.Point(663, 34);
            this.cmb_ROIType.Name = "cmb_ROIType";
            this.cmb_ROIType.Size = new System.Drawing.Size(161, 25);
            this.cmb_ROIType.TabIndex = 17;
            this.cmb_ROIType.SelectedIndexChanged += new System.EventHandler(this.cmb_ROIType_SelectedIndexChanged);
            // 
            // lbl_ROIType
            // 
            this.lbl_ROIType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ROIType.Location = new System.Drawing.Point(602, 34);
            this.lbl_ROIType.Name = "lbl_ROIType";
            this.lbl_ROIType.Size = new System.Drawing.Size(55, 23);
            this.lbl_ROIType.TabIndex = 18;
            this.lbl_ROIType.Text = "ROI类型";
            this.lbl_ROIType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(749, 595);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(602, 595);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 28);
            this.btn_OK.TabIndex = 19;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // gb_OriginalROI
            // 
            this.gb_OriginalROI.Controls.Add(this.txt_Original5);
            this.gb_OriginalROI.Controls.Add(this.lbl_Original5);
            this.gb_OriginalROI.Controls.Add(this.txt_Original4);
            this.gb_OriginalROI.Controls.Add(this.lbl_Original4);
            this.gb_OriginalROI.Controls.Add(this.txt_Original3);
            this.gb_OriginalROI.Controls.Add(this.lbl_Original3);
            this.gb_OriginalROI.Controls.Add(this.txt_Original2);
            this.gb_OriginalROI.Controls.Add(this.lbl_Original2);
            this.gb_OriginalROI.Controls.Add(this.txt_Original1);
            this.gb_OriginalROI.Controls.Add(this.lbl_Original1);
            this.gb_OriginalROI.Location = new System.Drawing.Point(605, 65);
            this.gb_OriginalROI.Name = "gb_OriginalROI";
            this.gb_OriginalROI.Size = new System.Drawing.Size(219, 173);
            this.gb_OriginalROI.TabIndex = 21;
            this.gb_OriginalROI.TabStop = false;
            this.gb_OriginalROI.Text = "原ROI";
            // 
            // txt_Original5
            // 
            this.txt_Original5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Original5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Original5.Location = new System.Drawing.Point(83, 144);
            this.txt_Original5.Multiline = true;
            this.txt_Original5.Name = "txt_Original5";
            this.txt_Original5.ReadOnly = true;
            this.txt_Original5.Size = new System.Drawing.Size(130, 23);
            this.txt_Original5.TabIndex = 27;
            // 
            // lbl_Original5
            // 
            this.lbl_Original5.Location = new System.Drawing.Point(6, 144);
            this.lbl_Original5.Name = "lbl_Original5";
            this.lbl_Original5.Size = new System.Drawing.Size(68, 23);
            this.lbl_Original5.TabIndex = 26;
            this.lbl_Original5.Text = "ROI校正：";
            this.lbl_Original5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Original4
            // 
            this.txt_Original4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Original4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Original4.Location = new System.Drawing.Point(83, 113);
            this.txt_Original4.Multiline = true;
            this.txt_Original4.Name = "txt_Original4";
            this.txt_Original4.ReadOnly = true;
            this.txt_Original4.Size = new System.Drawing.Size(130, 23);
            this.txt_Original4.TabIndex = 25;
            // 
            // lbl_Original4
            // 
            this.lbl_Original4.Location = new System.Drawing.Point(6, 113);
            this.lbl_Original4.Name = "lbl_Original4";
            this.lbl_Original4.Size = new System.Drawing.Size(68, 23);
            this.lbl_Original4.TabIndex = 24;
            this.lbl_Original4.Text = "ROI校正：";
            this.lbl_Original4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Original3
            // 
            this.txt_Original3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Original3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Original3.Location = new System.Drawing.Point(83, 82);
            this.txt_Original3.Multiline = true;
            this.txt_Original3.Name = "txt_Original3";
            this.txt_Original3.ReadOnly = true;
            this.txt_Original3.Size = new System.Drawing.Size(130, 23);
            this.txt_Original3.TabIndex = 23;
            // 
            // lbl_Original3
            // 
            this.lbl_Original3.Location = new System.Drawing.Point(6, 82);
            this.lbl_Original3.Name = "lbl_Original3";
            this.lbl_Original3.Size = new System.Drawing.Size(68, 23);
            this.lbl_Original3.TabIndex = 22;
            this.lbl_Original3.Text = "ROI校正：";
            this.lbl_Original3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Original2
            // 
            this.txt_Original2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Original2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Original2.Location = new System.Drawing.Point(83, 49);
            this.txt_Original2.Multiline = true;
            this.txt_Original2.Name = "txt_Original2";
            this.txt_Original2.ReadOnly = true;
            this.txt_Original2.Size = new System.Drawing.Size(130, 23);
            this.txt_Original2.TabIndex = 21;
            // 
            // lbl_Original2
            // 
            this.lbl_Original2.Location = new System.Drawing.Point(4, 51);
            this.lbl_Original2.Name = "lbl_Original2";
            this.lbl_Original2.Size = new System.Drawing.Size(68, 23);
            this.lbl_Original2.TabIndex = 20;
            this.lbl_Original2.Text = "ROI校正：";
            this.lbl_Original2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Original1
            // 
            this.txt_Original1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Original1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Original1.Location = new System.Drawing.Point(83, 20);
            this.txt_Original1.Multiline = true;
            this.txt_Original1.Name = "txt_Original1";
            this.txt_Original1.ReadOnly = true;
            this.txt_Original1.Size = new System.Drawing.Size(130, 23);
            this.txt_Original1.TabIndex = 19;
            // 
            // lbl_Original1
            // 
            this.lbl_Original1.Location = new System.Drawing.Point(4, 20);
            this.lbl_Original1.Name = "lbl_Original1";
            this.lbl_Original1.Size = new System.Drawing.Size(68, 23);
            this.lbl_Original1.TabIndex = 18;
            this.lbl_Original1.Text = "ROI校正：";
            this.lbl_Original1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gb_ROIReviseLate
            // 
            this.gb_ROIReviseLate.Controls.Add(this.txt_Revise5);
            this.gb_ROIReviseLate.Controls.Add(this.lbl_Revise5);
            this.gb_ROIReviseLate.Controls.Add(this.txt_Revise4);
            this.gb_ROIReviseLate.Controls.Add(this.lbl_Revise4);
            this.gb_ROIReviseLate.Controls.Add(this.txt_Revise3);
            this.gb_ROIReviseLate.Controls.Add(this.lbl_Revise3);
            this.gb_ROIReviseLate.Controls.Add(this.txt_Revise2);
            this.gb_ROIReviseLate.Controls.Add(this.lbl_Revise2);
            this.gb_ROIReviseLate.Controls.Add(this.txt_Revise1);
            this.gb_ROIReviseLate.Controls.Add(this.lbl_Revise1);
            this.gb_ROIReviseLate.Location = new System.Drawing.Point(605, 244);
            this.gb_ROIReviseLate.Name = "gb_ROIReviseLate";
            this.gb_ROIReviseLate.Size = new System.Drawing.Size(219, 173);
            this.gb_ROIReviseLate.TabIndex = 22;
            this.gb_ROIReviseLate.TabStop = false;
            this.gb_ROIReviseLate.Text = "校正后ROI";
            // 
            // txt_Revise5
            // 
            this.txt_Revise5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Revise5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Revise5.Location = new System.Drawing.Point(83, 144);
            this.txt_Revise5.Multiline = true;
            this.txt_Revise5.Name = "txt_Revise5";
            this.txt_Revise5.ReadOnly = true;
            this.txt_Revise5.Size = new System.Drawing.Size(130, 23);
            this.txt_Revise5.TabIndex = 27;
            // 
            // lbl_Revise5
            // 
            this.lbl_Revise5.Location = new System.Drawing.Point(6, 144);
            this.lbl_Revise5.Name = "lbl_Revise5";
            this.lbl_Revise5.Size = new System.Drawing.Size(68, 23);
            this.lbl_Revise5.TabIndex = 26;
            this.lbl_Revise5.Text = "ROI校正：";
            this.lbl_Revise5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Revise4
            // 
            this.txt_Revise4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Revise4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Revise4.Location = new System.Drawing.Point(83, 111);
            this.txt_Revise4.Multiline = true;
            this.txt_Revise4.Name = "txt_Revise4";
            this.txt_Revise4.ReadOnly = true;
            this.txt_Revise4.Size = new System.Drawing.Size(130, 23);
            this.txt_Revise4.TabIndex = 25;
            // 
            // lbl_Revise4
            // 
            this.lbl_Revise4.Location = new System.Drawing.Point(6, 113);
            this.lbl_Revise4.Name = "lbl_Revise4";
            this.lbl_Revise4.Size = new System.Drawing.Size(68, 23);
            this.lbl_Revise4.TabIndex = 24;
            this.lbl_Revise4.Text = "ROI校正：";
            this.lbl_Revise4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Revise3
            // 
            this.txt_Revise3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Revise3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Revise3.Location = new System.Drawing.Point(83, 82);
            this.txt_Revise3.Multiline = true;
            this.txt_Revise3.Name = "txt_Revise3";
            this.txt_Revise3.ReadOnly = true;
            this.txt_Revise3.Size = new System.Drawing.Size(130, 23);
            this.txt_Revise3.TabIndex = 23;
            // 
            // lbl_Revise3
            // 
            this.lbl_Revise3.Location = new System.Drawing.Point(6, 82);
            this.lbl_Revise3.Name = "lbl_Revise3";
            this.lbl_Revise3.Size = new System.Drawing.Size(68, 23);
            this.lbl_Revise3.TabIndex = 22;
            this.lbl_Revise3.Text = "ROI校正：";
            this.lbl_Revise3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Revise2
            // 
            this.txt_Revise2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Revise2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Revise2.Location = new System.Drawing.Point(83, 49);
            this.txt_Revise2.Multiline = true;
            this.txt_Revise2.Name = "txt_Revise2";
            this.txt_Revise2.ReadOnly = true;
            this.txt_Revise2.Size = new System.Drawing.Size(130, 23);
            this.txt_Revise2.TabIndex = 21;
            // 
            // lbl_Revise2
            // 
            this.lbl_Revise2.Location = new System.Drawing.Point(4, 51);
            this.lbl_Revise2.Name = "lbl_Revise2";
            this.lbl_Revise2.Size = new System.Drawing.Size(68, 23);
            this.lbl_Revise2.TabIndex = 20;
            this.lbl_Revise2.Text = "ROI校正：";
            this.lbl_Revise2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Revise1
            // 
            this.txt_Revise1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Revise1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Revise1.Location = new System.Drawing.Point(83, 20);
            this.txt_Revise1.Multiline = true;
            this.txt_Revise1.Name = "txt_Revise1";
            this.txt_Revise1.ReadOnly = true;
            this.txt_Revise1.Size = new System.Drawing.Size(130, 23);
            this.txt_Revise1.TabIndex = 19;
            // 
            // lbl_Revise1
            // 
            this.lbl_Revise1.Location = new System.Drawing.Point(4, 20);
            this.lbl_Revise1.Name = "lbl_Revise1";
            this.lbl_Revise1.Size = new System.Drawing.Size(68, 23);
            this.lbl_Revise1.TabIndex = 18;
            this.lbl_Revise1.Text = "ROI校正：";
            this.lbl_Revise1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmCreateROI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 627);
            this.Controls.Add(this.gb_ROIReviseLate);
            this.Controls.Add(this.gb_OriginalROI);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lbl_ROIType);
            this.Controls.Add(this.cmb_ROIType);
            this.Controls.Add(this.uC_Image1);
            this.DoubleBuffered = true;
            this.MaxVisible = false;
            this.Name = "FrmCreateROI";
            this.Text = "创建ROI";
            this.TitleVisiable = false;
            this.Load += new System.EventHandler(this.FrmCreateROI_Load);
            this.Controls.SetChildIndex(this.uC_Image1, 0);
            this.Controls.SetChildIndex(this.cmb_ROIType, 0);
            this.Controls.SetChildIndex(this.lbl_ROIType, 0);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.gb_OriginalROI, 0);
            this.Controls.SetChildIndex(this.gb_ROIReviseLate, 0);
            this.gb_OriginalROI.ResumeLayout(false);
            this.gb_OriginalROI.PerformLayout();
            this.gb_ROIReviseLate.ResumeLayout(false);
            this.gb_ROIReviseLate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Image uC_Image1;
        private System.Windows.Forms.ComboBox cmb_ROIType;
        private System.Windows.Forms.Label lbl_ROIType;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.GroupBox gb_OriginalROI;
        private System.Windows.Forms.Label lbl_Original1;
        private System.Windows.Forms.TextBox txt_Original1;
        private System.Windows.Forms.TextBox txt_Original5;
        private System.Windows.Forms.Label lbl_Original5;
        private System.Windows.Forms.TextBox txt_Original4;
        private System.Windows.Forms.Label lbl_Original4;
        private System.Windows.Forms.TextBox txt_Original3;
        private System.Windows.Forms.Label lbl_Original3;
        private System.Windows.Forms.TextBox txt_Original2;
        private System.Windows.Forms.Label lbl_Original2;
        private System.Windows.Forms.GroupBox gb_ROIReviseLate;
        private System.Windows.Forms.TextBox txt_Revise5;
        private System.Windows.Forms.Label lbl_Revise5;
        private System.Windows.Forms.TextBox txt_Revise4;
        private System.Windows.Forms.Label lbl_Revise4;
        private System.Windows.Forms.TextBox txt_Revise3;
        private System.Windows.Forms.Label lbl_Revise3;
        private System.Windows.Forms.TextBox txt_Revise2;
        private System.Windows.Forms.Label lbl_Revise2;
        private System.Windows.Forms.TextBox txt_Revise1;
        private System.Windows.Forms.Label lbl_Revise1;
    }
}