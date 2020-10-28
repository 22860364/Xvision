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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_ImageWorkFlow = new System.Windows.Forms.Panel();
            this.CM_Operation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tsmi_Execute = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Forbidden = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Past = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.DG_Edit = new System.Windows.Forms.DataGridView();
            this.BlockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExecuteState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExecuteResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExecuteTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ts_Tools = new System.Windows.Forms.ToolStrip();
            this.Tsbtn_Image_IO = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_ImageEnhancement = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_MotionControl = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_Location = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_Measure = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_ImageDetectionAndAnalysis = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_BarcodeRecognition = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_CommunControl = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_Other = new System.Windows.Forms.ToolStripButton();
            this.Panel_Tools = new System.Windows.Forms.Panel();
            this.CM_Operation.SuspendLayout();
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
            this.Panel_ImageWorkFlow.Location = new System.Drawing.Point(1, 0);
            this.Panel_ImageWorkFlow.Name = "Panel_ImageWorkFlow";
            this.Panel_ImageWorkFlow.Size = new System.Drawing.Size(708, 600);
            this.Panel_ImageWorkFlow.TabIndex = 0;
            this.Panel_ImageWorkFlow.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Panel_ImageWorkFlow_ControlAdded);
            // 
            // CM_Operation
            // 
            this.CM_Operation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.CM_Operation.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CM_Operation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_Execute,
            this.Tsmi_Delete,
            this.Tsmi_Edit,
            this.Tsmi_Forbidden,
            this.Tsmi_Copy,
            this.Tsmi_Past,
            this.Tsmi_Cut});
            this.CM_Operation.Name = "CM_Edit";
            this.CM_Operation.Size = new System.Drawing.Size(149, 172);
            // 
            // Tsmi_Execute
            // 
            this.Tsmi_Execute.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_Execute.Image")));
            this.Tsmi_Execute.Name = "Tsmi_Execute";
            this.Tsmi_Execute.Size = new System.Drawing.Size(148, 24);
            this.Tsmi_Execute.Text = "执行此工具";
            this.Tsmi_Execute.Click += new System.EventHandler(this.Tsmi_Execute_Click);
            // 
            // Tsmi_Delete
            // 
            this.Tsmi_Delete.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_Delete.Image")));
            this.Tsmi_Delete.Name = "Tsmi_Delete";
            this.Tsmi_Delete.Size = new System.Drawing.Size(148, 24);
            this.Tsmi_Delete.Text = "删除";
            this.Tsmi_Delete.Click += new System.EventHandler(this.Tsmi_Delete_Click);
            // 
            // Tsmi_Edit
            // 
            this.Tsmi_Edit.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_Edit.Image")));
            this.Tsmi_Edit.Name = "Tsmi_Edit";
            this.Tsmi_Edit.Size = new System.Drawing.Size(148, 24);
            this.Tsmi_Edit.Text = "编辑";
            this.Tsmi_Edit.Click += new System.EventHandler(this.Tsmi_Edit_Click);
            // 
            // Tsmi_Forbidden
            // 
            this.Tsmi_Forbidden.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_Forbidden.Image")));
            this.Tsmi_Forbidden.Name = "Tsmi_Forbidden";
            this.Tsmi_Forbidden.Size = new System.Drawing.Size(148, 24);
            this.Tsmi_Forbidden.Text = "禁用";
            this.Tsmi_Forbidden.Click += new System.EventHandler(this.Tsmi_Forbidden_Click);
            // 
            // Tsmi_Copy
            // 
            this.Tsmi_Copy.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_Copy.Image")));
            this.Tsmi_Copy.Name = "Tsmi_Copy";
            this.Tsmi_Copy.Size = new System.Drawing.Size(148, 24);
            this.Tsmi_Copy.Text = "复制";
            this.Tsmi_Copy.Click += new System.EventHandler(this.Tsmi_Copy_Click);
            // 
            // Tsmi_Past
            // 
            this.Tsmi_Past.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_Past.Image")));
            this.Tsmi_Past.Name = "Tsmi_Past";
            this.Tsmi_Past.Size = new System.Drawing.Size(148, 24);
            this.Tsmi_Past.Text = "粘贴";
            this.Tsmi_Past.Click += new System.EventHandler(this.Tsmi_Past_Click);
            // 
            // Tsmi_Cut
            // 
            this.Tsmi_Cut.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_Cut.Image")));
            this.Tsmi_Cut.Name = "Tsmi_Cut";
            this.Tsmi_Cut.Size = new System.Drawing.Size(148, 24);
            this.Tsmi_Cut.Text = "剪切";
            this.Tsmi_Cut.Click += new System.EventHandler(this.Tsmi_Cut_Click);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun-ExtB", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Edit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_Edit.ColumnHeadersHeight = 25;
            this.DG_Edit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_Edit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BlockName,
            this.ExecuteState,
            this.ExecuteResult,
            this.ExecuteTime});
            this.DG_Edit.GridColor = System.Drawing.Color.Black;
            this.DG_Edit.Location = new System.Drawing.Point(712, 0);
            this.DG_Edit.MultiSelect = false;
            this.DG_Edit.Name = "DG_Edit";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("SimSun-ExtB", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Edit.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DG_Edit.RowHeadersVisible = false;
            this.DG_Edit.RowHeadersWidth = 28;
            this.DG_Edit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DG_Edit.RowTemplate.Height = 30;
            this.DG_Edit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Edit.Size = new System.Drawing.Size(328, 250);
            this.DG_Edit.TabIndex = 28;
            this.DG_Edit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DG_Edit_MouseDown);
            // 
            // BlockName
            // 
            this.BlockName.DataPropertyName = "BlockName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BlockName.DefaultCellStyle = dataGridViewCellStyle3;
            this.BlockName.HeaderText = "算子名";
            this.BlockName.Name = "BlockName";
            this.BlockName.ReadOnly = true;
            this.BlockName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ExecuteState
            // 
            this.ExecuteState.DataPropertyName = "ExecuteState";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExecuteState.DefaultCellStyle = dataGridViewCellStyle4;
            this.ExecuteState.HeaderText = "状态";
            this.ExecuteState.Name = "ExecuteState";
            this.ExecuteState.ReadOnly = true;
            this.ExecuteState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ExecuteResult
            // 
            this.ExecuteResult.DataPropertyName = "ExecuteResult";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExecuteResult.DefaultCellStyle = dataGridViewCellStyle5;
            this.ExecuteResult.HeaderText = "结果";
            this.ExecuteResult.Name = "ExecuteResult";
            this.ExecuteResult.ReadOnly = true;
            this.ExecuteResult.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ExecuteTime
            // 
            this.ExecuteTime.DataPropertyName = "ExecuteTime";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExecuteTime.DefaultCellStyle = dataGridViewCellStyle6;
            this.ExecuteTime.HeaderText = "时间(ms)";
            this.ExecuteTime.Name = "ExecuteTime";
            this.ExecuteTime.ReadOnly = true;
            this.ExecuteTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ts_Tools
            // 
            this.ts_Tools.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ts_Tools.AutoSize = false;
            this.ts_Tools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ts_Tools.CanOverflow = false;
            this.ts_Tools.Dock = System.Windows.Forms.DockStyle.None;
            this.ts_Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_Tools.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ts_Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsbtn_Image_IO,
            this.Tsbtn_ImageEnhancement,
            this.Tsbtn_MotionControl,
            this.Tsbtn_Location,
            this.Tsbtn_Measure,
            this.Tsbtn_ImageDetectionAndAnalysis,
            this.Tsbtn_BarcodeRecognition,
            this.Tsbtn_CommunControl,
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
            // Tsbtn_ImageEnhancement
            // 
            this.Tsbtn_ImageEnhancement.AutoSize = false;
            this.Tsbtn_ImageEnhancement.CheckOnClick = true;
            this.Tsbtn_ImageEnhancement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsbtn_ImageEnhancement.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_ImageEnhancement.Image")));
            this.Tsbtn_ImageEnhancement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_ImageEnhancement.Name = "Tsbtn_ImageEnhancement";
            this.Tsbtn_ImageEnhancement.Size = new System.Drawing.Size(35, 32);
            this.Tsbtn_ImageEnhancement.Text = "图像增强";
            this.Tsbtn_ImageEnhancement.Click += new System.EventHandler(this.Tsbtn_ImageEnhancement_Click);
            // 
            // Tsbtn_MotionControl
            // 
            this.Tsbtn_MotionControl.AutoSize = false;
            this.Tsbtn_MotionControl.CheckOnClick = true;
            this.Tsbtn_MotionControl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsbtn_MotionControl.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_MotionControl.Image")));
            this.Tsbtn_MotionControl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_MotionControl.Name = "Tsbtn_MotionControl";
            this.Tsbtn_MotionControl.Size = new System.Drawing.Size(35, 32);
            this.Tsbtn_MotionControl.Text = "运动控制";
            this.Tsbtn_MotionControl.Click += new System.EventHandler(this.Tsbtn_MotionControl_Click);
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
            // Tsbtn_BarcodeRecognition
            // 
            this.Tsbtn_BarcodeRecognition.AutoSize = false;
            this.Tsbtn_BarcodeRecognition.CheckOnClick = true;
            this.Tsbtn_BarcodeRecognition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsbtn_BarcodeRecognition.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_BarcodeRecognition.Image")));
            this.Tsbtn_BarcodeRecognition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_BarcodeRecognition.Name = "Tsbtn_BarcodeRecognition";
            this.Tsbtn_BarcodeRecognition.Size = new System.Drawing.Size(35, 32);
            this.Tsbtn_BarcodeRecognition.Text = "条码识别";
            this.Tsbtn_BarcodeRecognition.Click += new System.EventHandler(this.Tsbtn_BarcodeRecognition_Click);
            // 
            // Tsbtn_CommunControl
            // 
            this.Tsbtn_CommunControl.AutoSize = false;
            this.Tsbtn_CommunControl.CheckOnClick = true;
            this.Tsbtn_CommunControl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsbtn_CommunControl.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_CommunControl.Image")));
            this.Tsbtn_CommunControl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_CommunControl.Name = "Tsbtn_CommunControl";
            this.Tsbtn_CommunControl.Size = new System.Drawing.Size(35, 32);
            this.Tsbtn_CommunControl.Text = "通讯控制";
            this.Tsbtn_CommunControl.Click += new System.EventHandler(this.Tsbtn_CommunControl_Click);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEdit";
            this.Text = "FrmWorkFlow";
            this.CM_Operation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Edit)).EndInit();
            this.ts_Tools.ResumeLayout(false);
            this.ts_Tools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel Panel_ImageWorkFlow;
        private System.Windows.Forms.ContextMenuStrip CM_Operation;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Delete;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Edit;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Forbidden;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Copy;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Past;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Cut;
        private System.Windows.Forms.DataGridView DG_Edit;
        private System.Windows.Forms.ToolStrip ts_Tools;
        private System.Windows.Forms.ToolStripButton Tsbtn_Image_IO;
        private System.Windows.Forms.ToolStripButton Tsbtn_ImageEnhancement;
        private System.Windows.Forms.ToolStripButton Tsbtn_Location;
        private System.Windows.Forms.ToolStripButton Tsbtn_Measure;
        private System.Windows.Forms.ToolStripButton Tsbtn_ImageDetectionAndAnalysis;
        private System.Windows.Forms.ToolStripButton Tsbtn_BarcodeRecognition;
        private System.Windows.Forms.ToolStripButton Tsbtn_CommunControl;
        private System.Windows.Forms.ToolStripButton Tsbtn_Other;
        private System.Windows.Forms.Panel Panel_Tools;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Execute;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExecuteState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExecuteResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExecuteTime;
        private System.Windows.Forms.ToolStripButton Tsbtn_MotionControl;
    }
}