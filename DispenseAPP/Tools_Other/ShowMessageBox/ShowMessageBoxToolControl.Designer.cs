namespace DispenseAPP.Tools_Other.ShowMessageBox
{
    partial class ShowMessageBoxToolControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.chkDisplaySecondButton = new System.Windows.Forms.CheckBox();
            this.tpBasic.SuspendLayout();
            this.pnlBasic.SuspendLayout();
            this.TcTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBasic
            // 
            this.pnlBasic.Controls.Add(this.chkDisplaySecondButton);
            this.pnlBasic.Controls.Add(this.txtText);
            this.pnlBasic.Controls.Add(this.label3);
            this.pnlBasic.Controls.Add(this.txtCaption);
            this.pnlBasic.Controls.Add(this.label2);
            this.pnlBasic.Controls.SetChildIndex(this.txtName, 0);
            this.pnlBasic.Controls.SetChildIndex(this.label2, 0);
            this.pnlBasic.Controls.SetChildIndex(this.txtCaption, 0);
            this.pnlBasic.Controls.SetChildIndex(this.label3, 0);
            this.pnlBasic.Controls.SetChildIndex(this.txtText, 0);
            this.pnlBasic.Controls.SetChildIndex(this.chkDisplaySecondButton, 0);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "标题";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCaption
            // 
            this.txtCaption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCaption.Location = new System.Drawing.Point(72, 56);
            this.txtCaption.Multiline = true;
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(198, 24);
            this.txtCaption.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "文本";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtText
            // 
            this.txtText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtText.Location = new System.Drawing.Point(72, 98);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(222, 66);
            this.txtText.TabIndex = 19;
            // 
            // chkDisplaySecondButton
            // 
            this.chkDisplaySecondButton.AutoSize = true;
            this.chkDisplaySecondButton.Location = new System.Drawing.Point(72, 188);
            this.chkDisplaySecondButton.Name = "chkDisplaySecondButton";
            this.chkDisplaySecondButton.Size = new System.Drawing.Size(111, 21);
            this.chkDisplaySecondButton.TabIndex = 28;
            this.chkDisplaySecondButton.Text = "显示第二个按钮";
            this.chkDisplaySecondButton.UseVisualStyleBackColor = true;
            // 
            // ShowMessageBoxToolControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "ShowMessageBoxToolControl";
            this.tpBasic.ResumeLayout(false);
            this.pnlBasic.ResumeLayout(false);
            this.pnlBasic.PerformLayout();
            this.TcTool.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.CheckBox chkDisplaySecondButton;
    }
}
