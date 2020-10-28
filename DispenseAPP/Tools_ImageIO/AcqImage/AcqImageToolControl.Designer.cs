namespace DispenseAPP.Tools_ImageIO.AcqImage
{
    partial class AcqImageToolControl
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
            this.btnStopAcq = new System.Windows.Forms.Button();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnContinueAcq = new System.Windows.Forms.Button();
            this.btnSingleAcq = new System.Windows.Forms.Button();
            this.pnlBasic.SuspendLayout();
            this.tpBasic.SuspendLayout();
            this.TcTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBasic
            // 
            this.pnlBasic.Controls.Add(this.btnStopAcq);
            this.pnlBasic.Controls.Add(this.cmbCamera);
            this.pnlBasic.Controls.Add(this.label2);
            this.pnlBasic.Controls.Add(this.btnContinueAcq);
            this.pnlBasic.Controls.Add(this.btnSingleAcq);
            this.pnlBasic.Controls.SetChildIndex(this.btnSingleAcq, 0);
            this.pnlBasic.Controls.SetChildIndex(this.btnContinueAcq, 0);
            this.pnlBasic.Controls.SetChildIndex(this.label2, 0);
            this.pnlBasic.Controls.SetChildIndex(this.cmbCamera, 0);
            this.pnlBasic.Controls.SetChildIndex(this.btnStopAcq, 0);
            // 
            // btnStopAcq
            // 
            this.btnStopAcq.Enabled = false;
            this.btnStopAcq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopAcq.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStopAcq.Location = new System.Drawing.Point(219, 92);
            this.btnStopAcq.Name = "btnStopAcq";
            this.btnStopAcq.Size = new System.Drawing.Size(75, 28);
            this.btnStopAcq.TabIndex = 17;
            this.btnStopAcq.Text = "停止采集";
            this.btnStopAcq.UseVisualStyleBackColor = true;
            this.btnStopAcq.Click += new System.EventHandler(this.BtnStopAcq_Click);
            // 
            // cmbCamera
            // 
            this.cmbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Location = new System.Drawing.Point(72, 47);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(190, 25);
            this.cmbCamera.TabIndex = 16;
            this.cmbCamera.SelectedIndexChanged += new System.EventHandler(this.CmbCamera_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "相机";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnContinueAcq
            // 
            this.btnContinueAcq.Enabled = false;
            this.btnContinueAcq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinueAcq.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnContinueAcq.Location = new System.Drawing.Point(118, 92);
            this.btnContinueAcq.Name = "btnContinueAcq";
            this.btnContinueAcq.Size = new System.Drawing.Size(75, 28);
            this.btnContinueAcq.TabIndex = 14;
            this.btnContinueAcq.Text = "连续采集";
            this.btnContinueAcq.UseVisualStyleBackColor = true;
            this.btnContinueAcq.Click += new System.EventHandler(this.BtnContinueAcq_Click);
            // 
            // btnSingleAcq
            // 
            this.btnSingleAcq.Enabled = false;
            this.btnSingleAcq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingleAcq.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSingleAcq.Location = new System.Drawing.Point(16, 92);
            this.btnSingleAcq.Name = "btnSingleAcq";
            this.btnSingleAcq.Size = new System.Drawing.Size(75, 28);
            this.btnSingleAcq.TabIndex = 13;
            this.btnSingleAcq.Text = "单帧采集";
            this.btnSingleAcq.UseVisualStyleBackColor = true;
            this.btnSingleAcq.Click += new System.EventHandler(this.BtnSingleAcq_Click);
            // 
            // ToolAcqImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ToolAcqImage";
            this.pnlBasic.ResumeLayout(false);
            this.pnlBasic.PerformLayout();
            this.tpBasic.ResumeLayout(false);
            this.TcTool.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStopAcq;
        private System.Windows.Forms.ComboBox cmbCamera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnContinueAcq;
        private System.Windows.Forms.Button btnSingleAcq;
    }
}
