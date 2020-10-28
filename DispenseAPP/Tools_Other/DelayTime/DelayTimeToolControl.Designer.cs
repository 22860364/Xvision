namespace DispenseAPP.Tools_Other.DelayTime
{
    partial class DelayTimeToolControl
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
            this.lbl_Millisecond = new System.Windows.Forms.Label();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.lbl_Delay = new System.Windows.Forms.Label();
            this.tpBasic.SuspendLayout();
            this.pnlBasic.SuspendLayout();
            this.TcTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBasic
            // 
            this.pnlBasic.Controls.Add(this.lbl_Millisecond);
            this.pnlBasic.Controls.Add(this.nudTime);
            this.pnlBasic.Controls.Add(this.lbl_Delay);
            this.pnlBasic.Controls.SetChildIndex(this.txtName, 0);
            this.pnlBasic.Controls.SetChildIndex(this.lbl_Delay, 0);
            this.pnlBasic.Controls.SetChildIndex(this.nudTime, 0);
            this.pnlBasic.Controls.SetChildIndex(this.lbl_Millisecond, 0);
            // 
            // lbl_Millisecond
            // 
            this.lbl_Millisecond.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Millisecond.AutoSize = true;
            this.lbl_Millisecond.Location = new System.Drawing.Point(196, 52);
            this.lbl_Millisecond.Name = "lbl_Millisecond";
            this.lbl_Millisecond.Size = new System.Drawing.Size(32, 17);
            this.lbl_Millisecond.TabIndex = 16;
            this.lbl_Millisecond.Text = "毫秒";
            this.lbl_Millisecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudTime
            // 
            this.nudTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudTime.Location = new System.Drawing.Point(72, 50);
            this.nudTime.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(118, 23);
            this.nudTime.TabIndex = 15;
            // 
            // lbl_Delay
            // 
            this.lbl_Delay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Delay.AutoSize = true;
            this.lbl_Delay.Location = new System.Drawing.Point(13, 52);
            this.lbl_Delay.Name = "lbl_Delay";
            this.lbl_Delay.Size = new System.Drawing.Size(32, 17);
            this.lbl_Delay.TabIndex = 14;
            this.lbl_Delay.Text = "延时";
            this.lbl_Delay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DelayTimeToolControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "DelayTimeToolControl";
            this.tpBasic.ResumeLayout(false);
            this.pnlBasic.ResumeLayout(false);
            this.pnlBasic.PerformLayout();
            this.TcTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Millisecond;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.Label lbl_Delay;
    }
}
