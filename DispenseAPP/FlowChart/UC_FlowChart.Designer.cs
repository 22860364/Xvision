namespace DispenseAPP
{
    partial class UC_FlowChart
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_FlowChart));
            this.PictureBox_FlowChart = new System.Windows.Forms.PictureBox();
            this.CM_Add = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_创建普通算子块 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_创建单条件算子块 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_创建多条件算子块 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_创建线程开始算子块 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_创建线程结束算子块 = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_Set = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_设置名称 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_删除算子 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_添加连接端口 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_删除连接端口 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_设为开始算子 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_设为运行一次 = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_Selected = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_复制 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_粘贴 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_删除所有 = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_Delete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_删除直线 = new System.Windows.Forms.ToolStripMenuItem();
            this.Panle_FlowChart = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_FlowChart)).BeginInit();
            this.CM_Add.SuspendLayout();
            this.CM_Set.SuspendLayout();
            this.CM_Selected.SuspendLayout();
            this.CM_Delete.SuspendLayout();
            this.Panle_FlowChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox_FlowChart
            // 
            this.PictureBox_FlowChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox_FlowChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox_FlowChart.Location = new System.Drawing.Point(0, 0);
            this.PictureBox_FlowChart.Name = "PictureBox_FlowChart";
            this.PictureBox_FlowChart.Size = new System.Drawing.Size(882, 681);
            this.PictureBox_FlowChart.TabIndex = 1;
            this.PictureBox_FlowChart.TabStop = false;
            this.PictureBox_FlowChart.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_FlowChart_Paint);
            this.PictureBox_FlowChart.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_FlowChart_MouseDoubleClick);
            this.PictureBox_FlowChart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_FlowChart_MouseDown);
            this.PictureBox_FlowChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_FlowChart_MouseMove);
            this.PictureBox_FlowChart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_FlowChart_MouseUp);
            this.PictureBox_FlowChart.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PictureBox_FlowChart_PreviewKeyDown);
            // 
            // CM_Add
            // 
            this.CM_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.CM_Add.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CM_Add.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_创建普通算子块,
            this.tsmi_创建单条件算子块,
            this.tsmi_创建多条件算子块,
            this.tsmi_创建线程开始算子块,
            this.tsmi_创建线程结束算子块});
            this.CM_Add.Name = "CM_FlowChart";
            this.CM_Add.Size = new System.Drawing.Size(205, 146);
            // 
            // tsmi_创建普通算子块
            // 
            this.tsmi_创建普通算子块.Name = "tsmi_创建普通算子块";
            this.tsmi_创建普通算子块.Size = new System.Drawing.Size(204, 24);
            this.tsmi_创建普通算子块.Text = "创建普通算子块";
            this.tsmi_创建普通算子块.Click += new System.EventHandler(this.创建普通算子块ToolStripMenuItem_Click);
            // 
            // tsmi_创建单条件算子块
            // 
            this.tsmi_创建单条件算子块.Name = "tsmi_创建单条件算子块";
            this.tsmi_创建单条件算子块.Size = new System.Drawing.Size(204, 24);
            this.tsmi_创建单条件算子块.Text = "创建单条件算子块";
            this.tsmi_创建单条件算子块.Click += new System.EventHandler(this.创建单条件算子块ToolStripMenuItem_Click);
            // 
            // tsmi_创建多条件算子块
            // 
            this.tsmi_创建多条件算子块.Name = "tsmi_创建多条件算子块";
            this.tsmi_创建多条件算子块.Size = new System.Drawing.Size(204, 24);
            this.tsmi_创建多条件算子块.Text = "创建多条件算子块";
            this.tsmi_创建多条件算子块.Click += new System.EventHandler(this.创建多条件算子块ToolStripMenuItem_Click);
            // 
            // tsmi_创建线程开始算子块
            // 
            this.tsmi_创建线程开始算子块.Name = "tsmi_创建线程开始算子块";
            this.tsmi_创建线程开始算子块.Size = new System.Drawing.Size(204, 24);
            this.tsmi_创建线程开始算子块.Text = "创建线程开始算子块";
            this.tsmi_创建线程开始算子块.Click += new System.EventHandler(this.创建开始线程算子块ToolStripMenuItem_Click);
            // 
            // tsmi_创建线程结束算子块
            // 
            this.tsmi_创建线程结束算子块.Name = "tsmi_创建线程结束算子块";
            this.tsmi_创建线程结束算子块.Size = new System.Drawing.Size(204, 24);
            this.tsmi_创建线程结束算子块.Text = "创建线程结束算子块";
            this.tsmi_创建线程结束算子块.Click += new System.EventHandler(this.创建结束线程算子块ToolStripMenuItem_Click);
            // 
            // CM_Set
            // 
            this.CM_Set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.CM_Set.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CM_Set.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_设置名称,
            this.tsmi_删除算子,
            this.tsmi_添加连接端口,
            this.tsmi_删除连接端口,
            this.tsmi_设为开始算子,
            this.tsmi_设为运行一次});
            this.CM_Set.Name = "CM_Set";
            this.CM_Set.Size = new System.Drawing.Size(163, 148);
            // 
            // tsmi_设置名称
            // 
            this.tsmi_设置名称.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_设置名称.Image")));
            this.tsmi_设置名称.Name = "tsmi_设置名称";
            this.tsmi_设置名称.Size = new System.Drawing.Size(162, 24);
            this.tsmi_设置名称.Text = "设置名称";
            this.tsmi_设置名称.Click += new System.EventHandler(this.设置名称ToolStripMenuItem_Click);
            // 
            // tsmi_删除算子
            // 
            this.tsmi_删除算子.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_删除算子.Image")));
            this.tsmi_删除算子.Name = "tsmi_删除算子";
            this.tsmi_删除算子.Size = new System.Drawing.Size(162, 24);
            this.tsmi_删除算子.Text = "删除算子";
            this.tsmi_删除算子.Click += new System.EventHandler(this.删除算子ToolStripMenuItem_Click);
            // 
            // tsmi_添加连接端口
            // 
            this.tsmi_添加连接端口.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_添加连接端口.Image")));
            this.tsmi_添加连接端口.Name = "tsmi_添加连接端口";
            this.tsmi_添加连接端口.Size = new System.Drawing.Size(162, 24);
            this.tsmi_添加连接端口.Text = "添加连接端口";
            this.tsmi_添加连接端口.Click += new System.EventHandler(this.添加连接端口ToolStripMenuItem_Click);
            // 
            // tsmi_删除连接端口
            // 
            this.tsmi_删除连接端口.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_删除连接端口.Image")));
            this.tsmi_删除连接端口.Name = "tsmi_删除连接端口";
            this.tsmi_删除连接端口.Size = new System.Drawing.Size(162, 24);
            this.tsmi_删除连接端口.Text = "删除连接端口";
            this.tsmi_删除连接端口.Click += new System.EventHandler(this.删除连接端口ToolStripMenuItem_Click);
            // 
            // tsmi_设为开始算子
            // 
            this.tsmi_设为开始算子.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_设为开始算子.Image")));
            this.tsmi_设为开始算子.Name = "tsmi_设为开始算子";
            this.tsmi_设为开始算子.Size = new System.Drawing.Size(162, 24);
            this.tsmi_设为开始算子.Text = "设为开始算子";
            this.tsmi_设为开始算子.Click += new System.EventHandler(this.设为开始算子ToolStripMenuItem_Click);
            // 
            // tsmi_设为运行一次
            // 
            this.tsmi_设为运行一次.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_设为运行一次.Image")));
            this.tsmi_设为运行一次.Name = "tsmi_设为运行一次";
            this.tsmi_设为运行一次.Size = new System.Drawing.Size(162, 24);
            this.tsmi_设为运行一次.Text = "设为运行一次";
            this.tsmi_设为运行一次.Click += new System.EventHandler(this.设为运行一次ToolStripMenuItem_Click);
            // 
            // CM_Selected
            // 
            this.CM_Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.CM_Selected.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CM_Selected.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_复制,
            this.tsmi_粘贴,
            this.tsmi_删除所有});
            this.CM_Selected.Name = "CM_Selected";
            this.CM_Selected.Size = new System.Drawing.Size(135, 76);
            // 
            // tsmi_复制
            // 
            this.tsmi_复制.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_复制.Image")));
            this.tsmi_复制.Name = "tsmi_复制";
            this.tsmi_复制.Size = new System.Drawing.Size(134, 24);
            this.tsmi_复制.Text = "复制";
            this.tsmi_复制.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // tsmi_粘贴
            // 
            this.tsmi_粘贴.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_粘贴.Image")));
            this.tsmi_粘贴.Name = "tsmi_粘贴";
            this.tsmi_粘贴.Size = new System.Drawing.Size(134, 24);
            this.tsmi_粘贴.Text = "粘贴";
            this.tsmi_粘贴.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // tsmi_删除所有
            // 
            this.tsmi_删除所有.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_删除所有.Image")));
            this.tsmi_删除所有.Name = "tsmi_删除所有";
            this.tsmi_删除所有.Size = new System.Drawing.Size(134, 24);
            this.tsmi_删除所有.Text = "删除所有";
            this.tsmi_删除所有.Click += new System.EventHandler(this.删除所有ToolStripMenuItem_Click);
            // 
            // CM_Delete
            // 
            this.CM_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.CM_Delete.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CM_Delete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_删除直线});
            this.CM_Delete.Name = "CM_Delete";
            this.CM_Delete.Size = new System.Drawing.Size(135, 28);
            // 
            // tsmi_删除直线
            // 
            this.tsmi_删除直线.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_删除直线.Image")));
            this.tsmi_删除直线.Name = "tsmi_删除直线";
            this.tsmi_删除直线.Size = new System.Drawing.Size(134, 24);
            this.tsmi_删除直线.Text = "删除直线";
            this.tsmi_删除直线.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // Panle_FlowChart
            // 
            this.Panle_FlowChart.AutoScroll = true;
            this.Panle_FlowChart.Controls.Add(this.PictureBox_FlowChart);
            this.Panle_FlowChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panle_FlowChart.Location = new System.Drawing.Point(0, 0);
            this.Panle_FlowChart.Name = "Panle_FlowChart";
            this.Panle_FlowChart.Size = new System.Drawing.Size(882, 681);
            this.Panle_FlowChart.TabIndex = 4;
            this.Panle_FlowChart.Resize += new System.EventHandler(this.Panle_FlowChart_Resize);
            // 
            // UC_FlowChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Panle_FlowChart);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UC_FlowChart";
            this.Size = new System.Drawing.Size(882, 681);
            this.Load += new System.EventHandler(this.UC_FlowChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_FlowChart)).EndInit();
            this.CM_Add.ResumeLayout(false);
            this.CM_Set.ResumeLayout(false);
            this.CM_Selected.ResumeLayout(false);
            this.CM_Delete.ResumeLayout(false);
            this.Panle_FlowChart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_FlowChart;
        private System.Windows.Forms.ContextMenuStrip CM_Add;
        private System.Windows.Forms.ToolStripMenuItem tsmi_创建普通算子块;
        private System.Windows.Forms.ToolStripMenuItem tsmi_创建单条件算子块;
        private System.Windows.Forms.ToolStripMenuItem tsmi_创建多条件算子块;
        private System.Windows.Forms.ToolStripMenuItem tsmi_创建线程开始算子块;
        private System.Windows.Forms.ToolStripMenuItem tsmi_创建线程结束算子块;
        private System.Windows.Forms.ContextMenuStrip CM_Set;
        private System.Windows.Forms.ToolStripMenuItem tsmi_设置名称;
        private System.Windows.Forms.ToolStripMenuItem tsmi_删除算子;
        private System.Windows.Forms.ToolStripMenuItem tsmi_添加连接端口;
        private System.Windows.Forms.ToolStripMenuItem tsmi_删除连接端口;
        private System.Windows.Forms.ToolStripMenuItem tsmi_设为开始算子;
        private System.Windows.Forms.ToolStripMenuItem tsmi_设为运行一次;
        private System.Windows.Forms.ContextMenuStrip CM_Selected;
        private System.Windows.Forms.ToolStripMenuItem tsmi_复制;
        private System.Windows.Forms.ToolStripMenuItem tsmi_粘贴;
        private System.Windows.Forms.ToolStripMenuItem tsmi_删除所有;
        private System.Windows.Forms.ContextMenuStrip CM_Delete;
        private System.Windows.Forms.ToolStripMenuItem tsmi_删除直线;
        private System.Windows.Forms.Panel Panle_FlowChart;
    }
}
