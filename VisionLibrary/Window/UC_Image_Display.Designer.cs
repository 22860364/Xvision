namespace DispenseAPP.WindowControl
{
    partial class UC_Image_Display
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
            this.HWindow = new HalconDotNet.HWindowControl();
            this.SuspendLayout();
            // 
            // HWindow
            // 
            this.HWindow.BackColor = System.Drawing.SystemColors.Control;
            this.HWindow.BorderColor = System.Drawing.SystemColors.Control;
            this.HWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HWindow.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.HWindow.Location = new System.Drawing.Point(0, 0);
            this.HWindow.Name = "HWindow";
            this.HWindow.Size = new System.Drawing.Size(440, 360);
            this.HWindow.TabIndex = 0;
            this.HWindow.WindowSize = new System.Drawing.Size(440, 360);
            // 
            // UC_Image_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.HWindow);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UC_Image_Display";
            this.Size = new System.Drawing.Size(440, 360);
            this.ResumeLayout(false);

        }

        #endregion

        private HalconDotNet.HWindowControl HWindow;
    }
}
