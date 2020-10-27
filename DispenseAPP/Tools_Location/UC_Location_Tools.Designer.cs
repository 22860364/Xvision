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
            this.lbl_GrayValueBasedMatch = new System.Windows.Forms.Label();
            this.lbl_ContourMatch = new System.Windows.Forms.Label();
            this.lbl_FindCircle = new System.Windows.Forms.Label();
            this.lbl_FindLine = new System.Windows.Forms.Label();
            this.lbl_ROIRevise = new System.Windows.Forms.Label();
            this.lbl_CreateROI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_GrayValueBasedMatch
            // 
            this.lbl_GrayValueBasedMatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GrayValueBasedMatch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_GrayValueBasedMatch.Image = ((System.Drawing.Image)(resources.GetObject("lbl_GrayValueBasedMatch.Image")));
            this.lbl_GrayValueBasedMatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_GrayValueBasedMatch.Location = new System.Drawing.Point(0, 96);
            this.lbl_GrayValueBasedMatch.Name = "lbl_GrayValueBasedMatch";
            this.lbl_GrayValueBasedMatch.Size = new System.Drawing.Size(330, 32);
            this.lbl_GrayValueBasedMatch.TabIndex = 4;
            this.lbl_GrayValueBasedMatch.Text = "          模板匹配（基于灰度值）";
            this.lbl_GrayValueBasedMatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_GrayValueBasedMatch.Click += new System.EventHandler(this.lbl_GrayValueBasedMatch_Click);
            // 
            // lbl_ContourMatch
            // 
            this.lbl_ContourMatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ContourMatch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ContourMatch.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ContourMatch.Image")));
            this.lbl_ContourMatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ContourMatch.Location = new System.Drawing.Point(0, 64);
            this.lbl_ContourMatch.Name = "lbl_ContourMatch";
            this.lbl_ContourMatch.Size = new System.Drawing.Size(330, 32);
            this.lbl_ContourMatch.TabIndex = 3;
            this.lbl_ContourMatch.Text = "          模板匹配（基于形状）";
            this.lbl_ContourMatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ContourMatch.Click += new System.EventHandler(this.lbl_ContourMatch_Click);
            // 
            // lbl_FindCircle
            // 
            this.lbl_FindCircle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FindCircle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_FindCircle.Image = ((System.Drawing.Image)(resources.GetObject("lbl_FindCircle.Image")));
            this.lbl_FindCircle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_FindCircle.Location = new System.Drawing.Point(0, 32);
            this.lbl_FindCircle.Name = "lbl_FindCircle";
            this.lbl_FindCircle.Size = new System.Drawing.Size(330, 32);
            this.lbl_FindCircle.TabIndex = 2;
            this.lbl_FindCircle.Text = "          找圆";
            this.lbl_FindCircle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_FindCircle.Click += new System.EventHandler(this.lbl_FindCircle_Click);
            // 
            // lbl_FindLine
            // 
            this.lbl_FindLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FindLine.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_FindLine.Image = ((System.Drawing.Image)(resources.GetObject("lbl_FindLine.Image")));
            this.lbl_FindLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_FindLine.Location = new System.Drawing.Point(0, 0);
            this.lbl_FindLine.Name = "lbl_FindLine";
            this.lbl_FindLine.Size = new System.Drawing.Size(330, 32);
            this.lbl_FindLine.TabIndex = 1;
            this.lbl_FindLine.Text = "          找直线";
            this.lbl_FindLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_FindLine.Click += new System.EventHandler(this.lbl_FindLine_Click);
            // 
            // lbl_ROIRevise
            // 
            this.lbl_ROIRevise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ROIRevise.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ROIRevise.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ROIRevise.Image")));
            this.lbl_ROIRevise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ROIRevise.Location = new System.Drawing.Point(0, 128);
            this.lbl_ROIRevise.Name = "lbl_ROIRevise";
            this.lbl_ROIRevise.Size = new System.Drawing.Size(330, 32);
            this.lbl_ROIRevise.TabIndex = 5;
            this.lbl_ROIRevise.Text = "          校正ROI";
            this.lbl_ROIRevise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ROIRevise.Click += new System.EventHandler(this.Lbl_ROICalib_Click);
            // 
            // lbl_CreateROI
            // 
            this.lbl_CreateROI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CreateROI.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_CreateROI.Image = ((System.Drawing.Image)(resources.GetObject("lbl_CreateROI.Image")));
            this.lbl_CreateROI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_CreateROI.Location = new System.Drawing.Point(0, 160);
            this.lbl_CreateROI.Name = "lbl_CreateROI";
            this.lbl_CreateROI.Size = new System.Drawing.Size(330, 32);
            this.lbl_CreateROI.TabIndex = 6;
            this.lbl_CreateROI.Text = "          创建ROI";
            this.lbl_CreateROI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_CreateROI.Click += new System.EventHandler(this.Lbl_CreateROI_Click);
            // 
            // UC_Location_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_CreateROI);
            this.Controls.Add(this.lbl_ROIRevise);
            this.Controls.Add(this.lbl_GrayValueBasedMatch);
            this.Controls.Add(this.lbl_ContourMatch);
            this.Controls.Add(this.lbl_FindCircle);
            this.Controls.Add(this.lbl_FindLine);
            this.Name = "UC_Location_Tools";
            this.Size = new System.Drawing.Size(330, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_FindLine;
        private System.Windows.Forms.Label lbl_FindCircle;
        private System.Windows.Forms.Label lbl_ContourMatch;
        private System.Windows.Forms.Label lbl_GrayValueBasedMatch;
        private System.Windows.Forms.Label lbl_ROIRevise;
        private System.Windows.Forms.Label lbl_CreateROI;
    }
}
