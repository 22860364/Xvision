namespace DispenseAPP.ToolBar
{
    partial class ToolBarProduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBarProduction));
            this.tsrProduction = new System.Windows.Forms.ToolStrip();
            this.tsbtnStart = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_Stop = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_Reset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.Tslbl_Yield = new System.Windows.Forms.ToolStripLabel();
            this.Tsbtn_SetZero = new System.Windows.Forms.ToolStripButton();
            this.Tslbl_DispenseTime = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Tsbtn_Frm_Run = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_Frm_FlowChart = new System.Windows.Forms.ToolStripButton();
            this.Tslbl_SwitchFrm = new System.Windows.Forms.ToolStripLabel();
            this.Tss_SwitchForm = new System.Windows.Forms.ToolStripSeparator();
            this.Tsrbtn_AllToRun = new DispenseAPP.MyStyleToolStripItem.ToolStripRadioButton();
            this.Tscb_EnableRubble = new DispenseAPP.ToolBar.ToolStripCheckBox();
            this.tsbtn_Platform1 = new DispenseAPP.MyStyleToolStripItem.ToolStripRadioButton();
            this.tsbtn_Platform2 = new DispenseAPP.MyStyleToolStripItem.ToolStripRadioButton();
            this.Tscb_CCDObserveMode = new DispenseAPP.ToolBar.ToolStripCheckBox();
            this.Tscb_AutoPhoto = new DispenseAPP.ToolBar.ToolStripCheckBox();
            this.tsrProduction.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsrProduction
            // 
            this.tsrProduction.AutoSize = false;
            this.tsrProduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tsrProduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsrProduction.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsrProduction.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsrProduction.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsrProduction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnStart,
            this.Tsbtn_Stop,
            this.Tsbtn_Reset,
            this.toolStripSeparator1,
            this.Tsrbtn_AllToRun,
            this.Tscb_EnableRubble,
            this.tsbtn_Platform1,
            this.tsbtn_Platform2,
            this.Tscb_CCDObserveMode,
            this.toolStripLabel1,
            this.Tscb_AutoPhoto,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.toolStripLabel4,
            this.Tslbl_Yield,
            this.Tsbtn_SetZero,
            this.Tslbl_DispenseTime,
            this.toolStripLabel6,
            this.toolStripSeparator3,
            this.Tsbtn_Frm_Run,
            this.Tsbtn_Frm_FlowChart,
            this.Tslbl_SwitchFrm,
            this.Tss_SwitchForm});
            this.tsrProduction.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsrProduction.Location = new System.Drawing.Point(0, 0);
            this.tsrProduction.Name = "tsrProduction";
            this.tsrProduction.Size = new System.Drawing.Size(1020, 70);
            this.tsrProduction.TabIndex = 24;
            this.tsrProduction.Text = "toolStrip1";
            // 
            // tsbtnStart
            // 
            this.tsbtnStart.AutoSize = false;
            this.tsbtnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tsbtnStart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbtnStart.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStart.Image")));
            this.tsbtnStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbtnStart.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.tsbtnStart.Name = "tsbtnStart";
            this.tsbtnStart.Size = new System.Drawing.Size(52, 52);
            this.tsbtnStart.Text = "启动";
            this.tsbtnStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnStart.Click += new System.EventHandler(this.Tbtn_Start_Click);
            // 
            // Tsbtn_Stop
            // 
            this.Tsbtn_Stop.AutoSize = false;
            this.Tsbtn_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Tsbtn_Stop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tsbtn_Stop.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_Stop.Image")));
            this.Tsbtn_Stop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tsbtn_Stop.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.Tsbtn_Stop.Name = "Tsbtn_Stop";
            this.Tsbtn_Stop.Size = new System.Drawing.Size(52, 52);
            this.Tsbtn_Stop.Text = "停止";
            this.Tsbtn_Stop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Tsbtn_Stop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tsbtn_Stop.Click += new System.EventHandler(this.Tsbtn_Stop_Click);
            // 
            // Tsbtn_Reset
            // 
            this.Tsbtn_Reset.AutoSize = false;
            this.Tsbtn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Tsbtn_Reset.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tsbtn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_Reset.Image")));
            this.Tsbtn_Reset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tsbtn_Reset.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.Tsbtn_Reset.Name = "Tsbtn_Reset";
            this.Tsbtn_Reset.Size = new System.Drawing.Size(52, 52);
            this.Tsbtn_Reset.Text = "复位";
            this.Tsbtn_Reset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Tsbtn_Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tsbtn_Reset.Click += new System.EventHandler(this.Tsbtn_Reset_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(-170, 52, 0, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(250, 17);
            this.toolStripLabel1.Text = "启动设置";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(68, 17);
            this.toolStripLabel2.Text = "生产数量：";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Margin = new System.Windows.Forms.Padding(-68, 28, 0, 0);
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(68, 17);
            this.toolStripLabel4.Text = "点胶时间：";
            // 
            // Tslbl_Yield
            // 
            this.Tslbl_Yield.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Tslbl_Yield.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.Tslbl_Yield.Name = "Tslbl_Yield";
            this.Tslbl_Yield.Size = new System.Drawing.Size(15, 17);
            this.Tslbl_Yield.Text = "0";
            // 
            // Tsbtn_SetZero
            // 
            this.Tsbtn_SetZero.AutoSize = false;
            this.Tsbtn_SetZero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsbtn_SetZero.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_SetZero.Image")));
            this.Tsbtn_SetZero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_SetZero.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.Tsbtn_SetZero.Name = "Tsbtn_SetZero";
            this.Tsbtn_SetZero.Size = new System.Drawing.Size(55, 21);
            this.Tsbtn_SetZero.Text = "置零";
            this.Tsbtn_SetZero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tsbtn_SetZero.Click += new System.EventHandler(this.TsBtn_SetZero_Click);
            // 
            // Tslbl_DispenseTime
            // 
            this.Tslbl_DispenseTime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Tslbl_DispenseTime.Margin = new System.Windows.Forms.Padding(-70, 28, 0, 2);
            this.Tslbl_DispenseTime.Name = "Tslbl_DispenseTime";
            this.Tslbl_DispenseTime.Size = new System.Drawing.Size(74, 17);
            this.Tslbl_DispenseTime.Text = "00：00：00";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.AutoSize = false;
            this.toolStripLabel6.Margin = new System.Windows.Forms.Padding(-142, 52, 0, 0);
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(142, 17);
            this.toolStripLabel6.Text = "生产信息";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 70);
            // 
            // Tsbtn_Frm_Run
            // 
            this.Tsbtn_Frm_Run.AutoSize = false;
            this.Tsbtn_Frm_Run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Tsbtn_Frm_Run.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tsbtn_Frm_Run.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_Frm_Run.Image")));
            this.Tsbtn_Frm_Run.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tsbtn_Frm_Run.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.Tsbtn_Frm_Run.Name = "Tsbtn_Frm_Run";
            this.Tsbtn_Frm_Run.Size = new System.Drawing.Size(58, 52);
            this.Tsbtn_Frm_Run.Text = "运行界面";
            this.Tsbtn_Frm_Run.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Tsbtn_Frm_Run.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tsbtn_Frm_Run.Click += new System.EventHandler(this.Tsbtn_Frm_Run_Click);
            // 
            // Tsbtn_Frm_FlowChart
            // 
            this.Tsbtn_Frm_FlowChart.AutoSize = false;
            this.Tsbtn_Frm_FlowChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Tsbtn_Frm_FlowChart.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_Frm_FlowChart.Image")));
            this.Tsbtn_Frm_FlowChart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tsbtn_Frm_FlowChart.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.Tsbtn_Frm_FlowChart.Name = "Tsbtn_Frm_FlowChart";
            this.Tsbtn_Frm_FlowChart.Size = new System.Drawing.Size(58, 52);
            this.Tsbtn_Frm_FlowChart.Text = "流程界面";
            this.Tsbtn_Frm_FlowChart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Tsbtn_Frm_FlowChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tsbtn_Frm_FlowChart.Click += new System.EventHandler(this.Tsbtn_Frm_FlowChart_Click);
            // 
            // Tslbl_SwitchFrm
            // 
            this.Tslbl_SwitchFrm.AutoSize = false;
            this.Tslbl_SwitchFrm.Margin = new System.Windows.Forms.Padding(-116, 53, 0, 2);
            this.Tslbl_SwitchFrm.Name = "Tslbl_SwitchFrm";
            this.Tslbl_SwitchFrm.Size = new System.Drawing.Size(116, 17);
            this.Tslbl_SwitchFrm.Text = "切换界面";
            // 
            // Tss_SwitchForm
            // 
            this.Tss_SwitchForm.AutoSize = false;
            this.Tss_SwitchForm.Name = "Tss_SwitchForm";
            this.Tss_SwitchForm.Size = new System.Drawing.Size(6, 70);
            // 
            // Tsrbtn_AllToRun
            // 
            this.Tsrbtn_AllToRun.HasCheck = true;
            this.Tsrbtn_AllToRun.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.Tsrbtn_AllToRun.Name = "Tsrbtn_AllToRun";
            this.Tsrbtn_AllToRun.Size = new System.Drawing.Size(49, 21);
            this.Tsrbtn_AllToRun.Text = "联动";
            // 
            // Tscb_EnableRubble
            // 
            this.Tscb_EnableRubble.HasChecked = false;
            this.Tscb_EnableRubble.Margin = new System.Windows.Forms.Padding(-50, 28, 0, 0);
            this.Tscb_EnableRubble.Name = "Tscb_EnableRubble";
            this.Tscb_EnableRubble.Size = new System.Drawing.Size(73, 21);
            this.Tscb_EnableRubble.Text = "启用胶阀";
            this.Tscb_EnableRubble.Click += new System.EventHandler(this.Tscb_EnableRubble_Click);
            // 
            // tsbtn_Platform1
            // 
            this.tsbtn_Platform1.HasCheck = false;
            this.tsbtn_Platform1.Margin = new System.Windows.Forms.Padding(-10, 1, 0, 2);
            this.tsbtn_Platform1.Name = "tsbtn_Platform1";
            this.tsbtn_Platform1.Size = new System.Drawing.Size(64, 21);
            this.tsbtn_Platform1.Text = "平台[1]";
            // 
            // tsbtn_Platform2
            // 
            this.tsbtn_Platform2.HasCheck = false;
            this.tsbtn_Platform2.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.tsbtn_Platform2.Name = "tsbtn_Platform2";
            this.tsbtn_Platform2.Size = new System.Drawing.Size(64, 21);
            this.tsbtn_Platform2.Text = "平台[2]";
            // 
            // Tscb_CCDObserveMode
            // 
            this.Tscb_CCDObserveMode.AutoSize = false;
            this.Tscb_CCDObserveMode.HasChecked = false;
            this.Tscb_CCDObserveMode.Margin = new System.Windows.Forms.Padding(-125, 28, 0, 2);
            this.Tscb_CCDObserveMode.Name = "Tscb_CCDObserveMode";
            this.Tscb_CCDObserveMode.Size = new System.Drawing.Size(90, 21);
            this.Tscb_CCDObserveMode.Text = "CCD观察模式";
            this.Tscb_CCDObserveMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tscb_CCDObserveMode.Click += new System.EventHandler(this.Tscb_CCDObserveMode_Click);
            // 
            // Tscb_AutoPhoto
            // 
            this.Tscb_AutoPhoto.AutoSize = false;
            this.Tscb_AutoPhoto.HasChecked = false;
            this.Tscb_AutoPhoto.Margin = new System.Windows.Forms.Padding(-75, 28, 0, 2);
            this.Tscb_AutoPhoto.Name = "Tscb_AutoPhoto";
            this.Tscb_AutoPhoto.Size = new System.Drawing.Size(80, 21);
            this.Tscb_AutoPhoto.Text = "自动拍照";
            this.Tscb_AutoPhoto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Tscb_AutoPhoto.Click += new System.EventHandler(this.Tscb_AutoPhoto_Click);
            // 
            // ToolBarProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.tsrProduction);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "ToolBarProduction";
            this.Size = new System.Drawing.Size(1020, 70);
            this.tsrProduction.ResumeLayout(false);
            this.tsrProduction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsrProduction;
        private System.Windows.Forms.ToolStripButton tsbtnStart;
        private System.Windows.Forms.ToolStripButton Tsbtn_Stop;
        private System.Windows.Forms.ToolStripButton Tsbtn_Reset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel Tslbl_Yield;
        private System.Windows.Forms.ToolStripButton Tsbtn_SetZero;
        private System.Windows.Forms.ToolStripLabel Tslbl_DispenseTime;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Tsbtn_Frm_Run;
        private System.Windows.Forms.ToolStripButton Tsbtn_Frm_FlowChart;
        private System.Windows.Forms.ToolStripLabel Tslbl_SwitchFrm;
        private System.Windows.Forms.ToolStripSeparator Tss_SwitchForm;
        private MyStyleToolStripItem.ToolStripRadioButton Tsrbtn_AllToRun;
        private MyStyleToolStripItem.ToolStripRadioButton tsbtn_Platform1;
        private ToolStripCheckBox Tscb_EnableRubble;
        private MyStyleToolStripItem.ToolStripRadioButton tsbtn_Platform2;
        private ToolStripCheckBox Tscb_CCDObserveMode;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private ToolStripCheckBox Tscb_AutoPhoto;
    }
}
