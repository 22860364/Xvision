namespace DispenseAPP.AboutMotionCard.ConfigMotionCard
{
    partial class FrmLimitSet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLimitSet));
            this.DG_Limit = new System.Windows.Forms.DataGridView();
            this.Col_AxisName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PELPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ORGPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_MELPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_AlarmPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PELLevelLogic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ORGLevelLogic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_MELLevelLogic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_AlarmLevelLogci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.CM_Operation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tsmi_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Past = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Redo = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Limit)).BeginInit();
            this.CM_Operation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.Location = new System.Drawing.Point(3, 1);
            this.lbl_ProjectName.Size = new System.Drawing.Size(93, 20);
            this.lbl_ProjectName.Text = "限位信号设置";
            // 
            // DG_Limit
            // 
            this.DG_Limit.AllowUserToAddRows = false;
            this.DG_Limit.AllowUserToDeleteRows = false;
            this.DG_Limit.AllowUserToResizeColumns = false;
            this.DG_Limit.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DG_Limit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_Limit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_Limit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Limit.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Limit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_Limit.ColumnHeadersHeight = 30;
            this.DG_Limit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_Limit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_AxisName,
            this.Col_PELPort,
            this.Col_ORGPort,
            this.Col_MELPort,
            this.Col_AlarmPort,
            this.Col_PELLevelLogic,
            this.Col_ORGLevelLogic,
            this.Col_MELLevelLogic,
            this.Col_AlarmLevelLogci});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_Limit.DefaultCellStyle = dataGridViewCellStyle12;
            this.DG_Limit.GridColor = System.Drawing.Color.Black;
            this.DG_Limit.Location = new System.Drawing.Point(1, 30);
            this.DG_Limit.Name = "DG_Limit";
            this.DG_Limit.RowHeadersWidth = 35;
            this.DG_Limit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DG_Limit.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.DG_Limit.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DG_Limit.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_Limit.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DG_Limit.RowTemplate.Height = 23;
            this.DG_Limit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Limit.Size = new System.Drawing.Size(714, 302);
            this.DG_Limit.TabIndex = 2;
            this.DG_Limit.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DG_Limit_CellBeginEdit);
            this.DG_Limit.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Limit_CellEndEdit);
            this.DG_Limit.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DG_Limit_RowPostPaint);
            this.DG_Limit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DG_Limit_KeyDown);
            this.DG_Limit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DG_Limit_MouseDown);
            // 
            // Col_AxisName
            // 
            this.Col_AxisName.DataPropertyName = "AxisName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Col_AxisName.DefaultCellStyle = dataGridViewCellStyle3;
            this.Col_AxisName.HeaderText = "轴名称";
            this.Col_AxisName.Name = "Col_AxisName";
            this.Col_AxisName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col_AxisName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_PELPort
            // 
            this.Col_PELPort.DataPropertyName = "PELPort";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_PELPort.DefaultCellStyle = dataGridViewCellStyle4;
            this.Col_PELPort.HeaderText = "正限位端口";
            this.Col_PELPort.Name = "Col_PELPort";
            this.Col_PELPort.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col_PELPort.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_ORGPort
            // 
            this.Col_ORGPort.DataPropertyName = "ORGPort";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_ORGPort.DefaultCellStyle = dataGridViewCellStyle5;
            this.Col_ORGPort.HeaderText = "原点端口";
            this.Col_ORGPort.Name = "Col_ORGPort";
            this.Col_ORGPort.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col_ORGPort.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_MELPort
            // 
            this.Col_MELPort.DataPropertyName = "MELPort";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_MELPort.DefaultCellStyle = dataGridViewCellStyle6;
            this.Col_MELPort.HeaderText = "负限位端口";
            this.Col_MELPort.Name = "Col_MELPort";
            this.Col_MELPort.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col_MELPort.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_AlarmPort
            // 
            this.Col_AlarmPort.DataPropertyName = "AlarmPort";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_AlarmPort.DefaultCellStyle = dataGridViewCellStyle7;
            this.Col_AlarmPort.HeaderText = "报警端口";
            this.Col_AlarmPort.Name = "Col_AlarmPort";
            this.Col_AlarmPort.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col_AlarmPort.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_PELLevelLogic
            // 
            this.Col_PELLevelLogic.DataPropertyName = "PELLevel";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_PELLevelLogic.DefaultCellStyle = dataGridViewCellStyle8;
            this.Col_PELLevelLogic.HeaderText = "正限位电平";
            this.Col_PELLevelLogic.Name = "Col_PELLevelLogic";
            this.Col_PELLevelLogic.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col_PELLevelLogic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_ORGLevelLogic
            // 
            this.Col_ORGLevelLogic.DataPropertyName = "ORGLevel";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_ORGLevelLogic.DefaultCellStyle = dataGridViewCellStyle9;
            this.Col_ORGLevelLogic.HeaderText = "原点电平";
            this.Col_ORGLevelLogic.Name = "Col_ORGLevelLogic";
            this.Col_ORGLevelLogic.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col_ORGLevelLogic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_MELLevelLogic
            // 
            this.Col_MELLevelLogic.DataPropertyName = "MELLevel";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_MELLevelLogic.DefaultCellStyle = dataGridViewCellStyle10;
            this.Col_MELLevelLogic.HeaderText = "负限位电平";
            this.Col_MELLevelLogic.Name = "Col_MELLevelLogic";
            this.Col_MELLevelLogic.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col_MELLevelLogic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_AlarmLevelLogci
            // 
            this.Col_AlarmLevelLogci.DataPropertyName = "AlarmLevel";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_AlarmLevelLogci.DefaultCellStyle = dataGridViewCellStyle11;
            this.Col_AlarmLevelLogci.HeaderText = "报警电平";
            this.Col_AlarmLevelLogci.Name = "Col_AlarmLevelLogci";
            this.Col_AlarmLevelLogci.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col_AlarmLevelLogci.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(655, 339);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(60, 28);
            this.Btn_Cancel.TabIndex = 22;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(589, 339);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(60, 28);
            this.Btn_OK.TabIndex = 21;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // CM_Operation
            // 
            this.CM_Operation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.CM_Operation.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CM_Operation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_Add,
            this.Tsmi_Insert,
            this.Tsmi_Del,
            this.Tsmi_Cut,
            this.Tsmi_Copy,
            this.Tsmi_Past,
            this.Tsmi_Undo,
            this.Tsmi_Redo});
            this.CM_Operation.Name = "CM_Operation";
            this.CM_Operation.Size = new System.Drawing.Size(101, 180);
            // 
            // Tsmi_Add
            // 
            this.Tsmi_Add.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_Add.Image")));
            this.Tsmi_Add.Name = "Tsmi_Add";
            this.Tsmi_Add.Size = new System.Drawing.Size(100, 22);
            this.Tsmi_Add.Text = "添加";
            this.Tsmi_Add.Click += new System.EventHandler(this.Tsmi_Add_Click);
            // 
            // Tsmi_Insert
            // 
            this.Tsmi_Insert.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_Insert.Image")));
            this.Tsmi_Insert.Name = "Tsmi_Insert";
            this.Tsmi_Insert.Size = new System.Drawing.Size(100, 22);
            this.Tsmi_Insert.Text = "插入";
            this.Tsmi_Insert.Click += new System.EventHandler(this.Tsmi_Insert_Click);
            // 
            // Tsmi_Del
            // 
            this.Tsmi_Del.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_Del.Image")));
            this.Tsmi_Del.Name = "Tsmi_Del";
            this.Tsmi_Del.Size = new System.Drawing.Size(100, 22);
            this.Tsmi_Del.Text = "删除";
            this.Tsmi_Del.Click += new System.EventHandler(this.Tsmi_Del_Click);
            // 
            // Tsmi_Cut
            // 
            this.Tsmi_Cut.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_Cut.Image")));
            this.Tsmi_Cut.Name = "Tsmi_Cut";
            this.Tsmi_Cut.Size = new System.Drawing.Size(100, 22);
            this.Tsmi_Cut.Text = "剪切";
            this.Tsmi_Cut.Click += new System.EventHandler(this.Tsmi_Cut_Click);
            // 
            // Tsmi_Copy
            // 
            this.Tsmi_Copy.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_Copy.Image")));
            this.Tsmi_Copy.Name = "Tsmi_Copy";
            this.Tsmi_Copy.Size = new System.Drawing.Size(100, 22);
            this.Tsmi_Copy.Text = "复制";
            this.Tsmi_Copy.Click += new System.EventHandler(this.Tsmi_Copy_Click);
            // 
            // Tsmi_Past
            // 
            this.Tsmi_Past.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_Past.Image")));
            this.Tsmi_Past.Name = "Tsmi_Past";
            this.Tsmi_Past.Size = new System.Drawing.Size(100, 22);
            this.Tsmi_Past.Text = "粘贴";
            this.Tsmi_Past.Click += new System.EventHandler(this.Tsmi_Past_Click);
            // 
            // Tsmi_Undo
            // 
            this.Tsmi_Undo.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_Undo.Image")));
            this.Tsmi_Undo.Name = "Tsmi_Undo";
            this.Tsmi_Undo.Size = new System.Drawing.Size(100, 22);
            this.Tsmi_Undo.Text = "撤销";
            this.Tsmi_Undo.Click += new System.EventHandler(this.Tsmi_Undo_Click);
            // 
            // Tsmi_Redo
            // 
            this.Tsmi_Redo.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_Redo.Image")));
            this.Tsmi_Redo.Name = "Tsmi_Redo";
            this.Tsmi_Redo.Size = new System.Drawing.Size(100, 22);
            this.Tsmi_Redo.Text = "重做";
            this.Tsmi_Redo.Click += new System.EventHandler(this.Tsmi_Redo_Click);
            // 
            // FrmLimitSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(716, 371);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.DG_Limit);
            this.MaxVisible = false;
            this.Name = "FrmLimitSet";
            this.Text = "限位信号设置";
            this.TitleVisiable = false;
            this.Controls.SetChildIndex(this.DG_Limit, 0);
            this.Controls.SetChildIndex(this.Btn_OK, 0);
            this.Controls.SetChildIndex(this.Btn_Cancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Limit)).EndInit();
            this.CM_Operation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Limit;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.ContextMenuStrip CM_Operation;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Add;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Insert;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Del;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Cut;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Copy;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Past;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Undo;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Redo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_AxisName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PELPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ORGPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MELPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_AlarmPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PELLevelLogic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ORGLevelLogic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MELLevelLogic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_AlarmLevelLogci;
    }
}