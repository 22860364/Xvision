namespace DispenseAPP.Tools_ScreenCheck
{
    partial class UC_ScreenCheck_Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ScreenCheck_Tools));
            this.Lbl_DustFilter = new System.Windows.Forms.Label();
            this.Lbl_BadParameterSetting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_DustFilter
            // 
            this.Lbl_DustFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_DustFilter.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_DustFilter.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_DustFilter.Image")));
            this.Lbl_DustFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_DustFilter.Location = new System.Drawing.Point(0, 0);
            this.Lbl_DustFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_DustFilter.Name = "Lbl_DustFilter";
            this.Lbl_DustFilter.Size = new System.Drawing.Size(412, 40);
            this.Lbl_DustFilter.TabIndex = 2;
            this.Lbl_DustFilter.Text = "          灰尘过滤";
            this.Lbl_DustFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_DustFilter.Click += new System.EventHandler(this.Lbl_DustFilter_Click);
            // 
            // Lbl_BadParameterSetting
            // 
            this.Lbl_BadParameterSetting.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_BadParameterSetting.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_BadParameterSetting.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_BadParameterSetting.Image")));
            this.Lbl_BadParameterSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_BadParameterSetting.Location = new System.Drawing.Point(0, 40);
            this.Lbl_BadParameterSetting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_BadParameterSetting.Name = "Lbl_BadParameterSetting";
            this.Lbl_BadParameterSetting.Size = new System.Drawing.Size(412, 40);
            this.Lbl_BadParameterSetting.TabIndex = 3;
            this.Lbl_BadParameterSetting.Text = "          不良点参数设置";
            this.Lbl_BadParameterSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_BadParameterSetting.Click += new System.EventHandler(this.Lbl_BadParameterSetting_Click);
            // 
            // UC_ScreenCheck_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Lbl_BadParameterSetting);
            this.Controls.Add(this.Lbl_DustFilter);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ScreenCheck_Tools";
            this.Size = new System.Drawing.Size(412, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_DustFilter;
        private System.Windows.Forms.Label Lbl_BadParameterSetting;
    }
}
