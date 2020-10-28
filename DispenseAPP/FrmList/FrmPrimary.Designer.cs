namespace DispenseAPP
{
    partial class FrmPrimary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrimary));
            this.panel_FrmEditRun = new System.Windows.Forms.Panel();
            this.MS = new System.Windows.Forms.MenuStrip();
            this.tsmiProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiParam = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ss_State = new System.Windows.Forms.StatusStrip();
            this.Timer_Disp = new System.Windows.Forms.Timer(this.components);
            this.pnlTool = new System.Windows.Forms.Panel();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.Lbl_User = new System.Windows.Forms.Label();
            this.Lbl_Min = new System.Windows.Forms.Label();
            this.Lbl_Max = new System.Windows.Forms.Label();
            this.Lbl_Close = new System.Windows.Forms.Label();
            this.Ts_FastAccess = new System.Windows.Forms.ToolStrip();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtnNewFile = new System.Windows.Forms.ToolStripButton();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.CM_User = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tsmi_操作员 = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_管理员 = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_程序员 = new System.Windows.Forms.ToolStripMenuItem();
            this.MS.SuspendLayout();
            this.panel_Title.SuspendLayout();
            this.Ts_FastAccess.SuspendLayout();
            this.CM_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_FrmEditRun
            // 
            this.panel_FrmEditRun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_FrmEditRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.panel_FrmEditRun.Location = new System.Drawing.Point(2, 194);
            this.panel_FrmEditRun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_FrmEditRun.Name = "panel_FrmEditRun";
            this.panel_FrmEditRun.Size = new System.Drawing.Size(1788, 896);
            this.panel_FrmEditRun.TabIndex = 3;
            // 
            // MS
            // 
            this.MS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MS.AutoSize = false;
            this.MS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.MS.Dock = System.Windows.Forms.DockStyle.None;
            this.MS.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MS.GripMargin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.MS.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProduct,
            this.tsmiConfig,
            this.tsmiParam,
            this.tsmiSystem});
            this.MS.Location = new System.Drawing.Point(0, 39);
            this.MS.Name = "MS";
            this.MS.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MS.Size = new System.Drawing.Size(1791, 52);
            this.MS.TabIndex = 5;
            this.MS.Text = "menuStrip1";
            // 
            // tsmiProduct
            // 
            this.tsmiProduct.ForeColor = System.Drawing.Color.White;
            this.tsmiProduct.Name = "tsmiProduct";
            this.tsmiProduct.Size = new System.Drawing.Size(66, 49);
            this.tsmiProduct.Text = "生产";
            this.tsmiProduct.Click += new System.EventHandler(this.Tsmi_Click);
            // 
            // tsmiConfig
            // 
            this.tsmiConfig.ForeColor = System.Drawing.Color.White;
            this.tsmiConfig.Name = "tsmiConfig";
            this.tsmiConfig.Size = new System.Drawing.Size(66, 49);
            this.tsmiConfig.Text = "配置";
            this.tsmiConfig.Click += new System.EventHandler(this.Tsmi_Click);
            // 
            // tsmiParam
            // 
            this.tsmiParam.ForeColor = System.Drawing.Color.White;
            this.tsmiParam.Name = "tsmiParam";
            this.tsmiParam.Size = new System.Drawing.Size(66, 49);
            this.tsmiParam.Text = "参数";
            this.tsmiParam.Click += new System.EventHandler(this.Tsmi_Click);
            // 
            // tsmiSystem
            // 
            this.tsmiSystem.ForeColor = System.Drawing.Color.White;
            this.tsmiSystem.Name = "tsmiSystem";
            this.tsmiSystem.Size = new System.Drawing.Size(66, 49);
            this.tsmiSystem.Text = "系统";
            this.tsmiSystem.Click += new System.EventHandler(this.Tsmi_Click);
            // 
            // Ss_State
            // 
            this.Ss_State.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Ss_State.Location = new System.Drawing.Point(0, 1103);
            this.Ss_State.Name = "Ss_State";
            this.Ss_State.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.Ss_State.Size = new System.Drawing.Size(1791, 22);
            this.Ss_State.TabIndex = 7;
            this.Ss_State.Text = "statusStrip1";
            // 
            // Timer_Disp
            // 
            this.Timer_Disp.Interval = 200;
            this.Timer_Disp.Tick += new System.EventHandler(this.Timer_Disp_Tick);
            // 
            // pnlTool
            // 
            this.pnlTool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pnlTool.Location = new System.Drawing.Point(2, 88);
            this.pnlTool.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(1788, 105);
            this.pnlTool.TabIndex = 8;
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.panel_Title.Controls.Add(this.Lbl_User);
            this.panel_Title.Controls.Add(this.Lbl_Min);
            this.panel_Title.Controls.Add(this.Lbl_Max);
            this.panel_Title.Controls.Add(this.Lbl_Close);
            this.panel_Title.Controls.Add(this.Ts_FastAccess);
            this.panel_Title.Controls.Add(this.Lbl_Title);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1791, 44);
            this.panel_Title.TabIndex = 9;
            this.panel_Title.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Max_MouseDoubleClick);
            this.panel_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            this.panel_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            // 
            // Lbl_User
            // 
            this.Lbl_User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_User.AutoSize = true;
            this.Lbl_User.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_User.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_User.ForeColor = System.Drawing.Color.White;
            this.Lbl_User.Location = new System.Drawing.Point(1407, 6);
            this.Lbl_User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_User.Name = "Lbl_User";
            this.Lbl_User.Size = new System.Drawing.Size(201, 28);
            this.Lbl_User.TabIndex = 10;
            this.Lbl_User.Text = "当前用户：未登录▼";
            this.Lbl_User.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lbl_User_MouseDown);
            // 
            // Lbl_Min
            // 
            this.Lbl_Min.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Min.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Min.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_Min.Image")));
            this.Lbl_Min.Location = new System.Drawing.Point(1616, 0);
            this.Lbl_Min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Min.Name = "Lbl_Min";
            this.Lbl_Min.Size = new System.Drawing.Size(52, 40);
            this.Lbl_Min.TabIndex = 9;
            this.Lbl_Min.Click += new System.EventHandler(this.Lbl_Min_Click);
            this.Lbl_Min.MouseEnter += new System.EventHandler(this.Lbl_Min_MouseEnter);
            this.Lbl_Min.MouseLeave += new System.EventHandler(this.Lbl_Min_MouseLeave);
            // 
            // Lbl_Max
            // 
            this.Lbl_Max.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Max.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Max.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_Max.Image")));
            this.Lbl_Max.Location = new System.Drawing.Point(1677, 0);
            this.Lbl_Max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Max.Name = "Lbl_Max";
            this.Lbl_Max.Size = new System.Drawing.Size(52, 40);
            this.Lbl_Max.TabIndex = 8;
            this.Lbl_Max.Click += new System.EventHandler(this.Lbl_Max_Click);
            this.Lbl_Max.MouseEnter += new System.EventHandler(this.Lbl_Max_MouseEnter);
            this.Lbl_Max.MouseLeave += new System.EventHandler(this.Lbl_Max_MouseLeave);
            // 
            // Lbl_Close
            // 
            this.Lbl_Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Close.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Close.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_Close.Image")));
            this.Lbl_Close.Location = new System.Drawing.Point(1738, -2);
            this.Lbl_Close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Close.Name = "Lbl_Close";
            this.Lbl_Close.Size = new System.Drawing.Size(52, 40);
            this.Lbl_Close.TabIndex = 7;
            this.Lbl_Close.Click += new System.EventHandler(this.Lbl_Close_Click);
            this.Lbl_Close.MouseEnter += new System.EventHandler(this.Lbl_Close_MouseEnter);
            this.Lbl_Close.MouseLeave += new System.EventHandler(this.Lbl_Close_MouseLeave);
            // 
            // Ts_FastAccess
            // 
            this.Ts_FastAccess.AutoSize = false;
            this.Ts_FastAccess.BackColor = System.Drawing.Color.Transparent;
            this.Ts_FastAccess.Dock = System.Windows.Forms.DockStyle.None;
            this.Ts_FastAccess.GripMargin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.Ts_FastAccess.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Ts_FastAccess.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Ts_FastAccess.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSave,
            this.tsbtnNewFile});
            this.Ts_FastAccess.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.Ts_FastAccess.Location = new System.Drawing.Point(0, 0);
            this.Ts_FastAccess.Name = "Ts_FastAccess";
            this.Ts_FastAccess.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.Ts_FastAccess.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Ts_FastAccess.Size = new System.Drawing.Size(136, 44);
            this.Ts_FastAccess.TabIndex = 6;
            this.Ts_FastAccess.Text = "toolStrip1";
            this.Ts_FastAccess.Paint += new System.Windows.Forms.PaintEventHandler(this.Ts_FastAccess_Paint);
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.AutoSize = false;
            this.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(32, 29);
            this.tsbtnSave.Text = "保存";
            this.tsbtnSave.Click += new System.EventHandler(this.Tsbtn_Save_Click);
            this.tsbtnSave.MouseEnter += new System.EventHandler(this.Tsbtn_FastSet_MouseEnter);
            this.tsbtnSave.MouseLeave += new System.EventHandler(this.Tsbtn_FastSet_MouseLeave);
            // 
            // tsbtnNewFile
            // 
            this.tsbtnNewFile.AutoSize = false;
            this.tsbtnNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNewFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNewFile.Image")));
            this.tsbtnNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNewFile.Name = "tsbtnNewFile";
            this.tsbtnNewFile.Size = new System.Drawing.Size(32, 29);
            this.tsbtnNewFile.Text = "新建";
            this.tsbtnNewFile.Click += new System.EventHandler(this.Tsbtn_NewFile_Click);
            this.tsbtnNewFile.MouseEnter += new System.EventHandler(this.Tsbtn_FastSet_MouseEnter);
            this.tsbtnNewFile.MouseLeave += new System.EventHandler(this.Tsbtn_FastSet_MouseLeave);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.Lbl_Title.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Title.ForeColor = System.Drawing.Color.White;
            this.Lbl_Title.Location = new System.Drawing.Point(828, 6);
            this.Lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(54, 28);
            this.Lbl_Title.TabIndex = 4;
            this.Lbl_Title.Text = "视觉";
            this.Lbl_Title.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Max_MouseDoubleClick);
            this.Lbl_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            this.Lbl_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            // 
            // CM_User
            // 
            this.CM_User.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CM_User.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CM_User.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_操作员,
            this.Tsmi_管理员,
            this.Tsmi_程序员});
            this.CM_User.Name = "CM_User";
            this.CM_User.Size = new System.Drawing.Size(156, 100);
            // 
            // Tsmi_操作员
            // 
            this.Tsmi_操作员.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tsmi_操作员.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_操作员.Image")));
            this.Tsmi_操作员.Name = "Tsmi_操作员";
            this.Tsmi_操作员.Size = new System.Drawing.Size(155, 32);
            this.Tsmi_操作员.Text = "操作员";
            this.Tsmi_操作员.Click += new System.EventHandler(this.Tsmi_操作员_Click);
            // 
            // Tsmi_管理员
            // 
            this.Tsmi_管理员.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_管理员.Image")));
            this.Tsmi_管理员.Name = "Tsmi_管理员";
            this.Tsmi_管理员.Size = new System.Drawing.Size(155, 32);
            this.Tsmi_管理员.Text = "管理员";
            this.Tsmi_管理员.Click += new System.EventHandler(this.Tsmi_管理员_Click);
            // 
            // Tsmi_程序员
            // 
            this.Tsmi_程序员.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_程序员.Image")));
            this.Tsmi_程序员.Name = "Tsmi_程序员";
            this.Tsmi_程序员.Size = new System.Drawing.Size(155, 32);
            this.Tsmi_程序员.Text = "程序员";
            this.Tsmi_程序员.Click += new System.EventHandler(this.Tsmi_程序员_Click);
            // 
            // FrmPrimary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1791, 1125);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.pnlTool);
            this.Controls.Add(this.Ss_State);
            this.Controls.Add(this.MS);
            this.Controls.Add(this.panel_FrmEditRun);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "FrmPrimary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "视觉点胶机";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrimary_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrimary_Load);
            this.Shown += new System.EventHandler(this.FrmPrimary_Shown);
            this.Resize += new System.EventHandler(this.FrmPrimary_Resize);
            this.MS.ResumeLayout(false);
            this.MS.PerformLayout();
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.Ts_FastAccess.ResumeLayout(false);
            this.Ts_FastAccess.PerformLayout();
            this.CM_User.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_FrmEditRun;
        private System.Windows.Forms.MenuStrip MS;
        private System.Windows.Forms.StatusStrip Ss_State;
        private System.Windows.Forms.Timer Timer_Disp;
        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.ToolStripMenuItem tsmiProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmiConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmiParam;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystem;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.ToolStrip Ts_FastAccess;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        protected System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.ToolStripButton tsbtnNewFile;
        private System.Windows.Forms.Label Lbl_Close;
        private System.Windows.Forms.Label Lbl_Min;
        private System.Windows.Forms.Label Lbl_Max;
        protected System.Windows.Forms.Label Lbl_User;
        private System.Windows.Forms.ContextMenuStrip CM_User;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_操作员;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_管理员;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_程序员;
    }
}