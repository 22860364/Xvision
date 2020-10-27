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
            this.Lbl_AutoCalib = new System.Windows.Forms.Label();
            this.Lbl_TransformCoordinateSystem = new System.Windows.Forms.Label();
            this.Lbl_UseCalib = new System.Windows.Forms.Label();
            this.Lbl_ExportImage = new System.Windows.Forms.Label();
            this.Lbl_CacheImage = new System.Windows.Forms.Label();
            this.Lbl_ImportImage = new System.Windows.Forms.Label();
            this.Lbl_AcqImage = new System.Windows.Forms.Label();
            this.Lbl_AcqSet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_AutoCalib
            // 
            this.Lbl_AutoCalib.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_AutoCalib.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_AutoCalib.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_AutoCalib.Image")));
            this.Lbl_AutoCalib.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_AutoCalib.Location = new System.Drawing.Point(0, 224);
            this.Lbl_AutoCalib.Name = "Lbl_AutoCalib";
            this.Lbl_AutoCalib.Size = new System.Drawing.Size(330, 32);
            this.Lbl_AutoCalib.TabIndex = 7;
            this.Lbl_AutoCalib.Text = "          自动标定";
            this.Lbl_AutoCalib.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_AutoCalib.Click += new System.EventHandler(this.Lbl_AutoCalib_Click);
            // 
            // Lbl_TransformCoordinateSystem
            // 
            this.Lbl_TransformCoordinateSystem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_TransformCoordinateSystem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_TransformCoordinateSystem.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_TransformCoordinateSystem.Image")));
            this.Lbl_TransformCoordinateSystem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_TransformCoordinateSystem.Location = new System.Drawing.Point(0, 192);
            this.Lbl_TransformCoordinateSystem.Name = "Lbl_TransformCoordinateSystem";
            this.Lbl_TransformCoordinateSystem.Size = new System.Drawing.Size(330, 32);
            this.Lbl_TransformCoordinateSystem.TabIndex = 6;
            this.Lbl_TransformCoordinateSystem.Text = "          坐标系转换";
            this.Lbl_TransformCoordinateSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_TransformCoordinateSystem.Click += new System.EventHandler(this.Lbl_TransformCoordinateSystem_Click);
            // 
            // Lbl_UseCalib
            // 
            this.Lbl_UseCalib.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_UseCalib.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_UseCalib.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_UseCalib.Image")));
            this.Lbl_UseCalib.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_UseCalib.Location = new System.Drawing.Point(0, 160);
            this.Lbl_UseCalib.Name = "Lbl_UseCalib";
            this.Lbl_UseCalib.Size = new System.Drawing.Size(330, 32);
            this.Lbl_UseCalib.TabIndex = 5;
            this.Lbl_UseCalib.Text = "          应用标定信息";
            this.Lbl_UseCalib.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_UseCalib.Click += new System.EventHandler(this.Lbl_UseCalib_Click);
            // 
            // Lbl_ExportImage
            // 
            this.Lbl_ExportImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_ExportImage.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_ExportImage.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_ExportImage.Image")));
            this.Lbl_ExportImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_ExportImage.Location = new System.Drawing.Point(0, 128);
            this.Lbl_ExportImage.Name = "Lbl_ExportImage";
            this.Lbl_ExportImage.Size = new System.Drawing.Size(330, 32);
            this.Lbl_ExportImage.TabIndex = 4;
            this.Lbl_ExportImage.Text = "          导出图像";
            this.Lbl_ExportImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_ExportImage.Click += new System.EventHandler(this.Lbl_ExportImage_Click);
            // 
            // Lbl_CacheImage
            // 
            this.Lbl_CacheImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_CacheImage.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_CacheImage.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_CacheImage.Image")));
            this.Lbl_CacheImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_CacheImage.Location = new System.Drawing.Point(0, 96);
            this.Lbl_CacheImage.Name = "Lbl_CacheImage";
            this.Lbl_CacheImage.Size = new System.Drawing.Size(330, 32);
            this.Lbl_CacheImage.TabIndex = 3;
            this.Lbl_CacheImage.Text = "          图像缓存：从图像缓存区读取图像";
            this.Lbl_CacheImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_CacheImage.Click += new System.EventHandler(this.Lbl_CacheImage_Click);
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
            this.Controls.Add(this.Lbl_AutoCalib);
            this.Controls.Add(this.Lbl_TransformCoordinateSystem);
            this.Controls.Add(this.Lbl_UseCalib);
            this.Controls.Add(this.Lbl_ExportImage);
            this.Controls.Add(this.Lbl_CacheImage);
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
        private System.Windows.Forms.Label Lbl_CacheImage;
        private System.Windows.Forms.Label Lbl_ExportImage;
        private System.Windows.Forms.Label Lbl_UseCalib;
        private System.Windows.Forms.Label Lbl_TransformCoordinateSystem;
        private System.Windows.Forms.Label Lbl_AutoCalib;
    }
}
