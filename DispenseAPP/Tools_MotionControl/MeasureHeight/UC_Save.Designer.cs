namespace DispenseAPP.Tools_MotionControl.MeasureHeight
{
    partial class UC_Save
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Path = new System.Windows.Forms.TextBox();
            this.Btn_Path = new System.Windows.Forms.Button();
            this.Btn_SubPathReference = new System.Windows.Forms.Button();
            this.Cb_SubPath = new System.Windows.Forms.CheckBox();
            this.Txt_SubPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_FileName = new System.Windows.Forms.TextBox();
            this.Btn_FileNameReference = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_Path);
            this.groupBox1.Controls.Add(this.Btn_Path);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 70);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "路径";
            // 
            // Txt_Path
            // 
            this.Txt_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Path.Dock = System.Windows.Forms.DockStyle.Left;
            this.Txt_Path.Location = new System.Drawing.Point(3, 19);
            this.Txt_Path.Multiline = true;
            this.Txt_Path.Name = "Txt_Path";
            this.Txt_Path.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Path.Size = new System.Drawing.Size(213, 48);
            this.Txt_Path.TabIndex = 4;
            // 
            // Btn_Path
            // 
            this.Btn_Path.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Path.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Path.Location = new System.Drawing.Point(222, 30);
            this.Btn_Path.Name = "Btn_Path";
            this.Btn_Path.Size = new System.Drawing.Size(42, 28);
            this.Btn_Path.TabIndex = 16;
            this.Btn_Path.Text = "路径";
            this.Btn_Path.UseVisualStyleBackColor = true;
            this.Btn_Path.Click += new System.EventHandler(this.Btn_Path_Click);
            // 
            // Btn_SubPathReference
            // 
            this.Btn_SubPathReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SubPathReference.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_SubPathReference.Location = new System.Drawing.Point(225, 115);
            this.Btn_SubPathReference.Name = "Btn_SubPathReference";
            this.Btn_SubPathReference.Size = new System.Drawing.Size(42, 28);
            this.Btn_SubPathReference.TabIndex = 21;
            this.Btn_SubPathReference.Text = "引用";
            this.Btn_SubPathReference.UseVisualStyleBackColor = true;
            // 
            // Cb_SubPath
            // 
            this.Cb_SubPath.Checked = true;
            this.Cb_SubPath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_SubPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cb_SubPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cb_SubPath.Location = new System.Drawing.Point(3, 76);
            this.Cb_SubPath.Name = "Cb_SubPath";
            this.Cb_SubPath.Size = new System.Drawing.Size(72, 24);
            this.Cb_SubPath.TabIndex = 20;
            this.Cb_SubPath.Text = "子路径";
            this.Cb_SubPath.UseVisualStyleBackColor = true;
            // 
            // Txt_SubPath
            // 
            this.Txt_SubPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_SubPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_SubPath.Location = new System.Drawing.Point(6, 106);
            this.Txt_SubPath.Multiline = true;
            this.Txt_SubPath.Name = "Txt_SubPath";
            this.Txt_SubPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_SubPath.Size = new System.Drawing.Size(213, 44);
            this.Txt_SubPath.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_FileName);
            this.groupBox2.Controls.Add(this.Btn_FileNameReference);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(3, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 70);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件名";
            // 
            // Txt_FileName
            // 
            this.Txt_FileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_FileName.Dock = System.Windows.Forms.DockStyle.Left;
            this.Txt_FileName.Location = new System.Drawing.Point(3, 19);
            this.Txt_FileName.Multiline = true;
            this.Txt_FileName.Name = "Txt_FileName";
            this.Txt_FileName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_FileName.Size = new System.Drawing.Size(210, 48);
            this.Txt_FileName.TabIndex = 6;
            // 
            // Btn_FileNameReference
            // 
            this.Btn_FileNameReference.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_FileNameReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FileNameReference.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_FileNameReference.Location = new System.Drawing.Point(219, 28);
            this.Btn_FileNameReference.Name = "Btn_FileNameReference";
            this.Btn_FileNameReference.Size = new System.Drawing.Size(42, 28);
            this.Btn_FileNameReference.TabIndex = 11;
            this.Btn_FileNameReference.Text = "引用";
            this.Btn_FileNameReference.UseVisualStyleBackColor = true;
            // 
            // UC_Save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Btn_SubPathReference);
            this.Controls.Add(this.Cb_SubPath);
            this.Controls.Add(this.Txt_SubPath);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Save";
            this.Size = new System.Drawing.Size(276, 228);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_Path;
        private System.Windows.Forms.Button Btn_Path;
        private System.Windows.Forms.Button Btn_SubPathReference;
        private System.Windows.Forms.CheckBox Cb_SubPath;
        private System.Windows.Forms.TextBox Txt_SubPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_FileName;
        private System.Windows.Forms.Button Btn_FileNameReference;
    }
}
