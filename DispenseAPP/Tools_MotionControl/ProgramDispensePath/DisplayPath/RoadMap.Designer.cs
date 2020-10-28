namespace GDI_
{
    partial class DrawMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawMap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tsmi_ImageAdaptive = new System.Windows.Forms.ToolStripButton();
            this.Tsmi_ArrayAdaptive = new System.Windows.Forms.ToolStripButton();
            this.Tsmi_ShowGrid = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_ShowPoint = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_ShowCoordinate = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_MoreSet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Tslb_X_Pos = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.Tslb_Y_Pos = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 394);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_ImageAdaptive,
            this.Tsmi_ArrayAdaptive,
            this.Tsmi_ShowGrid,
            this.Tsbtn_ShowPoint,
            this.Tsbtn_ShowCoordinate,
            this.Tsbtn_MoreSet,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.Tslb_X_Pos,
            this.toolStripLabel4,
            this.Tslb_Y_Pos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(556, 20);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Tsmi_ImageAdaptive
            // 
            this.Tsmi_ImageAdaptive.AutoSize = false;
            this.Tsmi_ImageAdaptive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsmi_ImageAdaptive.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_ImageAdaptive.Image")));
            this.Tsmi_ImageAdaptive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tsmi_ImageAdaptive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsmi_ImageAdaptive.Name = "Tsmi_ImageAdaptive";
            this.Tsmi_ImageAdaptive.Size = new System.Drawing.Size(25, 20);
            this.Tsmi_ImageAdaptive.Text = "图像自适应";
            this.Tsmi_ImageAdaptive.Click += new System.EventHandler(this.Tsmi_ImageAdaptive_Click);
            // 
            // Tsmi_ArrayAdaptive
            // 
            this.Tsmi_ArrayAdaptive.AutoSize = false;
            this.Tsmi_ArrayAdaptive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsmi_ArrayAdaptive.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_ArrayAdaptive.Image")));
            this.Tsmi_ArrayAdaptive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tsmi_ArrayAdaptive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsmi_ArrayAdaptive.Name = "Tsmi_ArrayAdaptive";
            this.Tsmi_ArrayAdaptive.Size = new System.Drawing.Size(25, 20);
            this.Tsmi_ArrayAdaptive.Text = "阵列自适应";
            this.Tsmi_ArrayAdaptive.Click += new System.EventHandler(this.Tsmi_ArrayAdaptive_Click);
            // 
            // Tsmi_ShowGrid
            // 
            this.Tsmi_ShowGrid.AutoSize = false;
            this.Tsmi_ShowGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsmi_ShowGrid.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_ShowGrid.Image")));
            this.Tsmi_ShowGrid.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tsmi_ShowGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsmi_ShowGrid.Name = "Tsmi_ShowGrid";
            this.Tsmi_ShowGrid.Size = new System.Drawing.Size(25, 20);
            this.Tsmi_ShowGrid.Text = "显示网格";
            this.Tsmi_ShowGrid.Click += new System.EventHandler(this.Tsmi_ShowGrid_Click);
            // 
            // Tsbtn_ShowPoint
            // 
            this.Tsbtn_ShowPoint.AutoSize = false;
            this.Tsbtn_ShowPoint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsbtn_ShowPoint.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_ShowPoint.Image")));
            this.Tsbtn_ShowPoint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tsbtn_ShowPoint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_ShowPoint.Name = "Tsbtn_ShowPoint";
            this.Tsbtn_ShowPoint.Size = new System.Drawing.Size(25, 20);
            this.Tsbtn_ShowPoint.Text = "显示坐标点";
            this.Tsbtn_ShowPoint.Click += new System.EventHandler(this.Tsbtn_ShowPoint_Click);
            // 
            // Tsbtn_ShowCoordinate
            // 
            this.Tsbtn_ShowCoordinate.AutoSize = false;
            this.Tsbtn_ShowCoordinate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsbtn_ShowCoordinate.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_ShowCoordinate.Image")));
            this.Tsbtn_ShowCoordinate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tsbtn_ShowCoordinate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_ShowCoordinate.Name = "Tsbtn_ShowCoordinate";
            this.Tsbtn_ShowCoordinate.Size = new System.Drawing.Size(25, 20);
            this.Tsbtn_ShowCoordinate.Text = "显示坐标系";
            this.Tsbtn_ShowCoordinate.Click += new System.EventHandler(this.Tsbtn_ShowCoordinate_Click);
            // 
            // Tsbtn_MoreSet
            // 
            this.Tsbtn_MoreSet.AutoSize = false;
            this.Tsbtn_MoreSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsbtn_MoreSet.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_MoreSet.Image")));
            this.Tsbtn_MoreSet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tsbtn_MoreSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_MoreSet.Name = "Tsbtn_MoreSet";
            this.Tsbtn_MoreSet.Size = new System.Drawing.Size(25, 20);
            this.Tsbtn_MoreSet.Text = "设置画布参数";
            this.Tsbtn_MoreSet.Click += new System.EventHandler(this.Tsbtn_MoreSet_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 20);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(28, 20);
            this.toolStripLabel1.Text = "X：";
            // 
            // Tslb_X_Pos
            // 
            this.Tslb_X_Pos.AutoSize = false;
            this.Tslb_X_Pos.Name = "Tslb_X_Pos";
            this.Tslb_X_Pos.Size = new System.Drawing.Size(40, 20);
            this.Tslb_X_Pos.Text = "0";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.AutoSize = false;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(28, 20);
            this.toolStripLabel4.Text = "Y：";
            // 
            // Tslb_Y_Pos
            // 
            this.Tslb_Y_Pos.AutoSize = false;
            this.Tslb_Y_Pos.Name = "Tslb_Y_Pos";
            this.Tslb_Y_Pos.Size = new System.Drawing.Size(40, 20);
            this.Tslb_Y_Pos.Text = "0";
            // 
            // DrawMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DrawMap";
            this.Size = new System.Drawing.Size(556, 415);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Tsmi_ImageAdaptive;
        private System.Windows.Forms.ToolStripButton Tsmi_ArrayAdaptive;
        private System.Windows.Forms.ToolStripButton Tsmi_ShowGrid;
        private System.Windows.Forms.ToolStripButton Tsbtn_ShowPoint;
        private System.Windows.Forms.ToolStripButton Tsbtn_ShowCoordinate;
        private System.Windows.Forms.ToolStripButton Tsbtn_MoreSet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel Tslb_X_Pos;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel Tslb_Y_Pos;
    }
}
