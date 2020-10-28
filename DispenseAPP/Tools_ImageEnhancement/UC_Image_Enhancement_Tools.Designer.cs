namespace DispenseAPP.Tools_ImageEnhancement
{
    partial class UC_Image_Enhancement_Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Image_Enhancement_Tools));
            this.Lbl_RotateShiftImage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_RotateShiftImage
            // 
            this.Lbl_RotateShiftImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_RotateShiftImage.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_RotateShiftImage.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_RotateShiftImage.Image")));
            this.Lbl_RotateShiftImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_RotateShiftImage.Location = new System.Drawing.Point(3, 0);
            this.Lbl_RotateShiftImage.Name = "Lbl_RotateShiftImage";
            this.Lbl_RotateShiftImage.Size = new System.Drawing.Size(327, 32);
            this.Lbl_RotateShiftImage.TabIndex = 11;
            this.Lbl_RotateShiftImage.Text = "          旋转平移图像";
            this.Lbl_RotateShiftImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_RotateShiftImage.Click += new System.EventHandler(this.Lbl_RotateShiftImage_Click);
            // 
            // UC_Image_Enhancement_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Lbl_RotateShiftImage);
            this.Name = "UC_Image_Enhancement_Tools";
            this.Size = new System.Drawing.Size(330, 513);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Lbl_RotateShiftImage;
    }
}
