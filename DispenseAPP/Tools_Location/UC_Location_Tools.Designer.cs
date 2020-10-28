namespace DispenseAPP.Tools_Location
{
    partial class UC_Location_Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Location_Tools));
            this.lbl_ContourMatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ContourMatch
            // 
            this.lbl_ContourMatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ContourMatch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ContourMatch.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ContourMatch.Image")));
            this.lbl_ContourMatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ContourMatch.Location = new System.Drawing.Point(0, 0);
            this.lbl_ContourMatch.Name = "lbl_ContourMatch";
            this.lbl_ContourMatch.Size = new System.Drawing.Size(330, 32);
            this.lbl_ContourMatch.TabIndex = 3;
            this.lbl_ContourMatch.Text = "          模板匹配（基于形状）";
            this.lbl_ContourMatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ContourMatch.Click += new System.EventHandler(this.Lbl_ContourMatch_Click);
            // 
            // UC_Location_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_ContourMatch);
            this.Name = "UC_Location_Tools";
            this.Size = new System.Drawing.Size(330, 400);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_ContourMatch;
    }
}
