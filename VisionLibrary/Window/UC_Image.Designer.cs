namespace DispenseAPP
{
    partial class UC_Image
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
            this.HWindow.BackColor = System.Drawing.Color.Black;
            this.HWindow.BorderColor = System.Drawing.Color.Black;
            this.HWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HWindow.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.HWindow.Location = new System.Drawing.Point(0, 0);
            this.HWindow.Name = "HWindow";
            this.HWindow.Size = new System.Drawing.Size(500, 400);
            this.HWindow.TabIndex = 30;
            this.HWindow.WindowSize = new System.Drawing.Size(500, 400);
            this.HWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.HWindow_Paint);
            // 
            // UC_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.HWindow);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UC_Image";
            this.Size = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private HalconDotNet.HWindowControl HWindow;
    }
}
