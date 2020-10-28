namespace DispenseAPP.Tools_Image_IO
{
    partial class UC_Image_IO_Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Image_IO_Tools));
            this.Lbl_ImportImage = new System.Windows.Forms.Label();
            this.Lbl_AcqImage = new System.Windows.Forms.Label();
            this.Lbl_AcqSet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_ImportImage
            // 
            this.Lbl_ImportImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_ImportImage.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_ImportImage.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_ImportImage.Image")));
            this.Lbl_ImportImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_ImportImage.Location = new System.Drawing.Point(0, 64);
            this.Lbl_ImportImage.Name = "Lbl_ImportImage";
            this.Lbl_ImportImage.Size = new System.Drawing.Size(330, 32);
            this.Lbl_ImportImage.TabIndex = 2;
            this.Lbl_ImportImage.Text = "          导入图像：从文件读入图像";
            this.Lbl_ImportImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_ImportImage.Click += new System.EventHandler(this.Lbl_ImportImage_Click);
            // 
            // Lbl_AcqImage
            // 
            this.Lbl_AcqImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_AcqImage.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_AcqImage.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_AcqImage.Image")));
            this.Lbl_AcqImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_AcqImage.Location = new System.Drawing.Point(0, 32);
            this.Lbl_AcqImage.Name = "Lbl_AcqImage";
            this.Lbl_AcqImage.Size = new System.Drawing.Size(330, 32);
            this.Lbl_AcqImage.TabIndex = 1;
            this.Lbl_AcqImage.Text = "          图像采集：从相机采集图像";
            this.Lbl_AcqImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_AcqImage.Click += new System.EventHandler(this.Lbl_AcqImage_Click);
            // 
            // Lbl_AcqSet
            // 
            this.Lbl_AcqSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_AcqSet.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_AcqSet.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_AcqSet.Image")));
            this.Lbl_AcqSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_AcqSet.Location = new System.Drawing.Point(0, 0);
            this.Lbl_AcqSet.Name = "Lbl_AcqSet";
            this.Lbl_AcqSet.Size = new System.Drawing.Size(330, 32);
            this.Lbl_AcqSet.TabIndex = 0;
            this.Lbl_AcqSet.Text = "          采集设置";
            this.Lbl_AcqSet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_AcqSet.Click += new System.EventHandler(this.Lbl_AcqSet_Click);
            // 
            // UC_Image_IO_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Lbl_ImportImage);
            this.Controls.Add(this.Lbl_AcqImage);
            this.Controls.Add(this.Lbl_AcqSet);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UC_Image_IO_Tools";
            this.Size = new System.Drawing.Size(330, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_AcqSet;
        private System.Windows.Forms.Label Lbl_AcqImage;
        private System.Windows.Forms.Label Lbl_ImportImage;
    }
}
