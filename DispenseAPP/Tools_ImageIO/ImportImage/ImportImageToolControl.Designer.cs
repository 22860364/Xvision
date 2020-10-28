namespace DispenseAPP.Tools_ImageIO.ImportImage
{
    partial class ImportImageToolControl
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
            this.btnPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.chkCycleLoad = new System.Windows.Forms.CheckBox();
            this.tpBasic.SuspendLayout();
            this.pnlBasic.SuspendLayout();
            this.TcTool.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBasic
            // 
            this.pnlBasic.Controls.Add(this.chkCycleLoad);
            this.pnlBasic.Controls.Add(this.groupBox1);
            this.pnlBasic.Controls.SetChildIndex(this.txtName, 0);
            this.pnlBasic.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnlBasic.Controls.SetChildIndex(this.chkCycleLoad, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPath);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Location = new System.Drawing.Point(10, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 80);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像路径";
            // 
            // btnPath
            // 
            this.btnPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPath.Location = new System.Drawing.Point(234, 19);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(44, 56);
            this.btnPath.TabIndex = 16;
            this.btnPath.Text = "路 径";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.BtnPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.White;
            this.txtPath.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtPath.Location = new System.Drawing.Point(3, 19);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPath.Size = new System.Drawing.Size(226, 58);
            this.txtPath.TabIndex = 6;
            // 
            // chkCycleLoad
            // 
            this.chkCycleLoad.AutoSize = true;
            this.chkCycleLoad.Checked = true;
            this.chkCycleLoad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCycleLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkCycleLoad.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkCycleLoad.Location = new System.Drawing.Point(13, 138);
            this.chkCycleLoad.Name = "chkCycleLoad";
            this.chkCycleLoad.Size = new System.Drawing.Size(81, 24);
            this.chkCycleLoad.TabIndex = 14;
            this.chkCycleLoad.Text = "循环加载";
            this.chkCycleLoad.UseVisualStyleBackColor = true;
            // 
            // ImportImageToolControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ImportImageToolControl";
            this.tpBasic.ResumeLayout(false);
            this.pnlBasic.ResumeLayout(false);
            this.pnlBasic.PerformLayout();
            this.TcTool.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.CheckBox chkCycleLoad;
    }
}
