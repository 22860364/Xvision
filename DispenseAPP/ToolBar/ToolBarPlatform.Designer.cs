namespace DispenseAPP.ToolBar
{
    partial class ToolBarPlatform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBarPlatform));
            this.tsrFunction = new System.Windows.Forms.ToolStrip();
            this.Tsbtn_配置窗口 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Tsbtn_变量设置 = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_实时变量 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsrFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsrFunction
            // 
            this.tsrFunction.AutoSize = false;
            this.tsrFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tsrFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsrFunction.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsrFunction.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsrFunction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsbtn_配置窗口,
            this.toolStripSeparator3,
            this.Tsbtn_变量设置,
            this.Tsbtn_实时变量,
            this.toolStripLabel2,
            this.toolStripSeparator4});
            this.tsrFunction.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsrFunction.Location = new System.Drawing.Point(0, 0);
            this.tsrFunction.Name = "tsrFunction";
            this.tsrFunction.Size = new System.Drawing.Size(1000, 70);
            this.tsrFunction.TabIndex = 6;
            this.tsrFunction.Text = "功能";
            // 
            // Tsbtn_配置窗口
            // 
            this.Tsbtn_配置窗口.AutoSize = false;
            this.Tsbtn_配置窗口.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Tsbtn_配置窗口.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsbtn_配置窗口.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_配置窗口.Image")));
            this.Tsbtn_配置窗口.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_配置窗口.Name = "Tsbtn_配置窗口";
            this.Tsbtn_配置窗口.Size = new System.Drawing.Size(52, 50);
            this.Tsbtn_配置窗口.Text = "配置窗口";
            this.Tsbtn_配置窗口.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tsbtn_配置窗口.Click += new System.EventHandler(this.Tsmi_配置窗口_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 70);
            // 
            // Tsbtn_变量设置
            // 
            this.Tsbtn_变量设置.AutoSize = false;
            this.Tsbtn_变量设置.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsbtn_变量设置.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_变量设置.Image")));
            this.Tsbtn_变量设置.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_变量设置.Name = "Tsbtn_变量设置";
            this.Tsbtn_变量设置.Size = new System.Drawing.Size(52, 50);
            this.Tsbtn_变量设置.Text = "变量设置";
            this.Tsbtn_变量设置.Click += new System.EventHandler(this.Tsbtn_变量设置_Click);
            // 
            // Tsbtn_实时变量
            // 
            this.Tsbtn_实时变量.AutoSize = false;
            this.Tsbtn_实时变量.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsbtn_实时变量.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_实时变量.Image")));
            this.Tsbtn_实时变量.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_实时变量.Name = "Tsbtn_实时变量";
            this.Tsbtn_实时变量.Size = new System.Drawing.Size(52, 50);
            this.Tsbtn_实时变量.Text = "实时变量";
            this.Tsbtn_实时变量.Click += new System.EventHandler(this.Tsbtn_实时变量_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(-104, 53, 0, 2);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(104, 17);
            this.toolStripLabel2.Text = "变量";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 70);
            // 
            // ToolBarPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tsrFunction);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "ToolBarPlatform";
            this.Size = new System.Drawing.Size(1000, 70);
            this.tsrFunction.ResumeLayout(false);
            this.tsrFunction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsrFunction;
        private System.Windows.Forms.ToolStripButton Tsbtn_配置窗口;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Tsbtn_变量设置;
        private System.Windows.Forms.ToolStripButton Tsbtn_实时变量;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}
