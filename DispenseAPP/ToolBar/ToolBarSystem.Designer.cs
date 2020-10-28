namespace DispenseAPP.ToolBar
{
    partial class ToolBarSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBarSystem));
            this.tsbtnSet = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsrSystem = new System.Windows.Forms.ToolStrip();
            this.tsrSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsbtnSet
            // 
            this.tsbtnSet.AutoSize = false;
            this.tsbtnSet.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSet.Image")));
            this.tsbtnSet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSet.Name = "tsbtnSet";
            this.tsbtnSet.Size = new System.Drawing.Size(52, 52);
            this.tsbtnSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnSet.Click += new System.EventHandler(this.TsbtnSet_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(-52, 52, 0, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(52, 17);
            this.toolStripLabel1.Text = "设置";
            // 
            // tsrSystem
            // 
            this.tsrSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tsrSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsrSystem.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsrSystem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSet,
            this.toolStripLabel1});
            this.tsrSystem.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsrSystem.Location = new System.Drawing.Point(0, 0);
            this.tsrSystem.Name = "tsrSystem";
            this.tsrSystem.Size = new System.Drawing.Size(1020, 70);
            this.tsrSystem.TabIndex = 0;
            // 
            // ToolBarSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tsrSystem);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "ToolBarSystem";
            this.Size = new System.Drawing.Size(1020, 70);
            this.tsrSystem.ResumeLayout(false);
            this.tsrSystem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbtnSet;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip tsrSystem;
    }
}
