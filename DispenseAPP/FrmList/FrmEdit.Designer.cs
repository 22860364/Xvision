namespace DispenseAPP
{
    partial class FrmEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_ImageWorkFlow = new System.Windows.Forms.Panel();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiExecute = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiForbidden = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPast = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.DG_Edit = new System.Windows.Forms.DataGridView();
            this.ColStepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColState = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ts_Tools = new System.Windows.Forms.ToolStrip();
            this.Tsbtn_Image_IO = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_Location = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_Measure = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_ImageDetectionAndAnalysis = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_Other = new System.Windows.Forms.ToolStripButton();
            this.Panel_Tools = new System.Windows.Forms.Panel();
            this.BGWrok = new System.ComponentModel.BackgroundWorker();
            this.cms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Edit)).BeginInit();
            this.ts_Tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_ImageWorkFlow
            // 
            this.Panel_ImageWorkFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_ImageWorkFlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_ImageWorkFlow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Panel_ImageWorkFlow.Location = new System.Drawing.Point(-1, 0);
            this.Panel_ImageWorkFlow.Name = "Panel_ImageWorkFlow";
            this.Panel_ImageWorkFlow.Size = new System.Drawing.Size(710, 600);
            this.Panel_ImageWorkFlow.TabIndex = 0;
            // 
            // cms
            // 
            this.cms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.cms.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExecute,
            this.tsmiDelete,
            this.tsmiEdit,
            this.tsmiForbidden,
            this.tsmiCopy,
            this.tsmiPast,
            this.tsmiCut,
            this.tsmiMoveUp,
            this.tsmiMoveDown});
            this.cms.Name = "CM_Edit";
            this.cms.Size = new System.Drawing.Size(149, 220);
            // 
            // tsmiExecute
            // 
            this.tsmiExecute.Image = ((System.Drawing.Image)(resources.GetObject("tsmiExecute.Image")));
            this.tsmiExecute.Name = "tsmiExecute";
            this.tsmiExecute.Size = new System.Drawing.Size(148, 24);
            this.tsmiExecute.Text = "执行此工具";
            this.tsmiExecute.Click += new System.EventHandler(this.Tsmi_Execute_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDelete.Image")));
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(148, 24);
            this.tsmiDelete.Text = "删除";
            this.tsmiDelete.Click += new System.EventHandler(this.Tsmi_Delete_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEdit.Image")));
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(148, 24);
            this.tsmiEdit.Text = "编辑";
            this.tsmiEdit.Click += new System.EventHandler(this.Tsmi_Edit_Click);
            // 
            // tsmiForbidden
            // 
            this.tsmiForbidden.Image = global::DispenseAPP.Properties.Resources.禁用;
            this.tsmiForbidden.Name = "tsmiForbidden";
            this.tsmiForbidden.Size = new System.Drawing.Size(148, 24);
            this.tsmiForbidden.Text = "禁用";
            this.tsmiForbidden.Click += new System.EventHandler(this.Tsmi_Forbidden_Click);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCopy.Image")));
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(148, 24);
            this.tsmiCopy.Text = "复制";
            this.tsmiCopy.Click += new System.EventHandler(this.Tsmi_Copy_Click);
            // 
            // tsmiPast
            // 
            this.tsmiPast.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPast.Image")));
            this.tsmiPast.Name = "tsmiPast";
            this.tsmiPast.Size = new System.Drawing.Size(148, 24);
            this.tsmiPast.Text = "粘贴";
            this.tsmiPast.Click += new System.EventHandler(this.TsmiPast_Click);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCut.Image")));
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.Size = new System.Drawing.Size(148, 24);
            this.tsmiCut.Text = "剪切";
            this.tsmiCut.Click += new System.EventHandler(this.TsmiCut_Click);
            // 
            // tsmiMoveUp
            // 
            this.tsmiMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMoveUp.Image")));
            this.tsmiMoveUp.Name = "tsmiMoveUp";
            this.tsmiMoveUp.Size = new System.Drawing.Size(148, 24);
            this.tsmiMoveUp.Text = "上移";
            this.tsmiMoveUp.Click += new System.EventHandler(this.Tsmi_MoveUp_Click);
            // 
            // tsmiMoveDown
            // 
            this.tsmiMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMoveDown.Image")));
            this.tsmiMoveDown.Name = "tsmiMoveDown";
            this.tsmiMoveDown.Size = new System.Drawing.Size(148, 24);
            this.tsmiMoveDown.Text = "下移";
            this.tsmiMoveDown.Click += new System.EventHandler(this.Tsmi_MoveDown_Click);
            // 
            // DG_Edit
            // 
            this.DG_Edit.AllowUserToAddRows = false;
            this.DG_Edit.AllowUserToDeleteRows = false;
            this.DG_Edit.AllowUserToResizeColumns = false;
            this.DG_Edit.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            this.DG_Edit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_Edit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Edit.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Edit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_Edit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_Edit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStepName,
            this.ColState,
            this.ColResult,
            this.ColTime});
            this.DG_Edit.GridColor = System.Drawing.Color.Black;
            this.DG_Edit.Location = new System.Drawing.Point(712, 0);
            this.DG_Edit.Name = "DG_Edit";
            this.DG_Edit.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Edit.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DG_Edit.RowHeadersVisible = false;
            this.DG_Edit.RowHeadersWidth = 28;
            this.DG_Edit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.DG_Edit.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_Edit.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DG_Edit.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LimeGreen;
            this.DG_Edit.RowTemplate.Height = 28;
            this.DG_Edit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Edit.Size = new System.Drawing.Size(328, 250);
            this.DG_Edit.TabIndex = 28;
            this.DG_Edit.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Edit_CellDoubleClick);
            this.DG_Edit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DG_Edit_MouseDown);
            // 
            // ColStepName
            // 
            this.ColStepName.DataPropertyName = "StepCustomName";
            this.ColStepName.HeaderText = "算子名";
            this.ColStepName.Name = "ColStepName";
            this.ColStepName.ReadOnly = true;
            this.ColStepName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColState
            // 
            this.ColState.DataPropertyName = "StepState";
            this.ColState.FillWeight = 35F;
            this.ColState.HeaderText = "状态";
            this.ColState.Name = "ColState";
            this.ColState.ReadOnly = true;
            // 
            // ColResult
            // 
            this.ColResult.DataPropertyName = "ExecutionResult";
            this.ColResult.HeaderText = "结果";
            this.ColResult.Name = "ColResult";
            this.ColResult.ReadOnly = true;
            this.ColResult.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColTime
            // 
            this.ColTime.DataPropertyName = "ExecutionTime";
            this.ColTime.FillWeight = 35F;
            this.ColTime.HeaderText = "时间";
            this.ColTime.Name = "ColTime";
            this.ColTime.ReadOnly = true;
            this.ColTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ts_Tools
            // 
            this.ts_Tools.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ts_Tools.AutoSize = false;
            this.ts_Tools.BackColor = System.Drawing.Color.White;
            this.ts_Tools.CanOverflow = false;
            this.ts_Tools.Dock = System.Windows.Forms.DockStyle.None;
            this.ts_Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_Tools.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ts_Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsbtn_Image_IO,
            this.Tsbtn_Location,
            this.Tsbtn_Measure,
            this.Tsbtn_ImageDetectionAndAnalysis,
            this.Tsbtn_Other});
            this.ts_Tools.Location = new System.Drawing.Point(712, 253);
            this.ts_Tools.MaximumSize = new System.Drawing.Size(325, 35);
            this.ts_Tools.MinimumSize = new System.Drawing.Size(325, 35);
            this.ts_Tools.Name = "ts_Tools";
            this.ts_Tools.Size = new System.Drawing.Size(325, 35);
            this.ts_Tools.TabIndex = 29;
            this.ts_Tools.Text = "toolStrip1";
            // 
            // Tsbtn_Image_IO
            // 
            this.Tsbtn_Image_IO.AutoSize = false;
            this.Tsbtn_Image_IO.CheckOnClick = true;
            this.Tsbtn_Image_IO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsbtn_Image_IO.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_Image_IO.Image")));
            this.Tsbtn_Image_IO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_Image_IO.Name = "Tsbtn_Image_IO";
            this.Tsbtn_Image_IO.Size = new System.Drawing.Size(35, 32);
            this.Tsbtn_Image_IO.Text = "图像输入输出";
            this.Tsbtn_Image_IO.Click += new System.EventHandler(this.Tsbtn_Image_IO_Click);
            // 
            // Tsbtn_Location
            // 
            this.Tsbtn_Location.AutoSize = false;
            this.Tsbtn_Location.CheckOnClick = true;
            this.Tsbtn_Location.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsbtn_Location.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_Location.Image")));
            this.Tsbtn_Location.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_Location.Name = "Tsbtn_Location";
            this.Tsbtn_Location.Size = new System.Drawing.Size(35, 32);
            this.Tsbtn_Location.Text = "定位";
            this.Tsbtn_Location.Click += new System.EventHandler(this.Tsbtn_Location_Click);
            // 
            // Tsbtn_Measure
            // 
            this.Tsbtn_Measure.AutoSize = false;
            this.Tsbtn_Measure.CheckOnClick = true;
            this.Tsbtn_Measure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsbtn_Measure.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_Measure.Image")));
            this.Tsbtn_Measure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_Measure.Name = "Tsbtn_Measure";
            this.Tsbtn_Measure.Size = new System.Drawing.Size(35, 32);
            this.Tsbtn_Measure.Text = "测量";
            this.Tsbtn_Measure.Click += new System.EventHandler(this.Tsbtn_Measure_Click);
            // 
            // Tsbtn_ImageDetectionAndAnalysis
            // 
            this.Tsbtn_ImageDetectionAndAnalysis.AutoSize = false;
            this.Tsbtn_ImageDetectionAndAnalysis.CheckOnClick = true;
            this.Tsbtn_ImageDetectionAndAnalysis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsbtn_ImageDetectionAndAnalysis.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_ImageDetectionAndAnalysis.Image")));
            this.Tsbtn_ImageDetectionAndAnalysis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_ImageDetectionAndAnalysis.Name = "Tsbtn_ImageDetectionAndAnalysis";
            this.Tsbtn_ImageDetectionAndAnalysis.Size = new System.Drawing.Size(35, 32);
            this.Tsbtn_ImageDetectionAndAnalysis.Text = "检测分析";
            this.Tsbtn_ImageDetectionAndAnalysis.Click += new System.EventHandler(this.Tsbtn_ImageDetectionAndAnalysis_Click);
            // 
            // Tsbtn_Other
            // 
            this.Tsbtn_Other.AutoSize = false;
            this.Tsbtn_Other.CheckOnClick = true;
            this.Tsbtn_Other.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsbtn_Other.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_Other.Image")));
            this.Tsbtn_Other.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_Other.Name = "Tsbtn_Other";
            this.Tsbtn_Other.Size = new System.Drawing.Size(35, 32);
            this.Tsbtn_Other.Text = "其它工具";
            this.Tsbtn_Other.Click += new System.EventHandler(this.Tsbtn_Other_Click);
            // 
            // Panel_Tools
            // 
            this.Panel_Tools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Tools.AutoSize = true;
            this.Panel_Tools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Tools.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Panel_Tools.Location = new System.Drawing.Point(712, 291);
            this.Panel_Tools.Name = "Panel_Tools";
            this.Panel_Tools.Size = new System.Drawing.Size(328, 309);
            this.Panel_Tools.TabIndex = 1;
            // 
            // BGWrok
            // 
            this.BGWrok.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWrok_DoWork);
            this.BGWrok.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWrok_RunWorkerCompleted);
            // 
            // FrmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.ts_Tools);
            this.Controls.Add(this.DG_Edit);
            this.Controls.Add(this.Panel_Tools);
            this.Controls.Add(this.Panel_ImageWorkFlow);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEdit";
            this.Text = "FrmWorkFlow";
            this.cms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Edit)).EndInit();
            this.ts_Tools.ResumeLayout(false);
            this.ts_Tools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel Panel_ImageWorkFlow;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiForbidden;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPast;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.DataGridView DG_Edit;
        private System.Windows.Forms.ToolStrip ts_Tools;
        private System.Windows.Forms.ToolStripButton Tsbtn_Image_IO;
        private System.Windows.Forms.ToolStripButton Tsbtn_Location;
        private System.Windows.Forms.ToolStripButton Tsbtn_Measure;
        private System.Windows.Forms.ToolStripButton Tsbtn_ImageDetectionAndAnalysis;
        private System.Windows.Forms.ToolStripButton Tsbtn_Other;
        private System.Windows.Forms.Panel Panel_Tools;
        private System.Windows.Forms.ToolStripMenuItem tsmiExecute;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveUp;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveDown;
        private System.ComponentModel.BackgroundWorker BGWrok;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStepName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
    }
}