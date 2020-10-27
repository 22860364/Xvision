namespace DispenseAPP
{
    partial class FrmIOSet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIOSet));
            this.DG_DI = new System.Windows.Forms.DataGridView();
            this.Col_DI_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_DI_Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_DI_Mode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Col_DI_State = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DG_DO = new System.Windows.Forms.DataGridView();
            this.Col_DO_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_DO_Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_DO_Mode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColulmnDOState = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Gb_Input = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CM_Operation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tsmi_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_AutoSetPort = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_ImportExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer_ReadIO = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DG_DI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_DO)).BeginInit();
            this.Gb_Input.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.CM_Operation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.Location = new System.Drawing.Point(3, 1);
            this.lbl_ProjectName.Size = new System.Drawing.Size(52, 20);
            this.lbl_ProjectName.Text = "IO设置";
            // 
            // DG_DI
            // 
            this.DG_DI.AllowUserToAddRows = false;
            this.DG_DI.AllowUserToDeleteRows = false;
            this.DG_DI.AllowUserToResizeColumns = false;
            this.DG_DI.AllowUserToResizeRows = false;
            this.DG_DI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_DI.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_DI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_DI.ColumnHeadersHeight = 22;
            this.DG_DI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_DI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_DI_Name,
            this.Col_DI_Port,
            this.Col_DI_Mode,
            this.Col_DI_State});
            this.DG_DI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_DI.GridColor = System.Drawing.Color.Black;
            this.DG_DI.Location = new System.Drawing.Point(3, 19);
            this.DG_DI.MultiSelect = false;
            this.DG_DI.Name = "DG_DI";
            this.DG_DI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DG_DI.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_DI.RowTemplate.Height = 23;
            this.DG_DI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_DI.Size = new System.Drawing.Size(568, 241);
            this.DG_DI.TabIndex = 24;
            this.DG_DI.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DG_DI_CellBeginEdit);
            this.DG_DI.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_DI_CellEndEdit);
            this.DG_DI.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DG_DI_RowPostPaint);
            this.DG_DI.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DG_DI_MouseClick);
            this.DG_DI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DG_DI_MouseDown);
            // 
            // Col_DI_Name
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.Col_DI_Name.DefaultCellStyle = dataGridViewCellStyle2;
            this.Col_DI_Name.HeaderText = "名称";
            this.Col_DI_Name.Name = "Col_DI_Name";
            this.Col_DI_Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col_DI_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_DI_Port
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.Col_DI_Port.DefaultCellStyle = dataGridViewCellStyle3;
            this.Col_DI_Port.FillWeight = 50F;
            this.Col_DI_Port.HeaderText = "端口";
            this.Col_DI_Port.Name = "Col_DI_Port";
            this.Col_DI_Port.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col_DI_Port.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_DI_Mode
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.Col_DI_Mode.DefaultCellStyle = dataGridViewCellStyle4;
            this.Col_DI_Mode.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Col_DI_Mode.FillWeight = 50F;
            this.Col_DI_Mode.HeaderText = "模式";
            this.Col_DI_Mode.Items.AddRange(new object[] {
            "常开",
            "常闭"});
            this.Col_DI_Mode.Name = "Col_DI_Mode";
            this.Col_DI_Mode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Col_DI_State
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.NullValue = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.Col_DI_State.DefaultCellStyle = dataGridViewCellStyle5;
            this.Col_DI_State.FillWeight = 50F;
            this.Col_DI_State.HeaderText = "状态";
            this.Col_DI_State.Name = "Col_DI_State";
            this.Col_DI_State.ReadOnly = true;
            this.Col_DI_State.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DG_DO
            // 
            this.DG_DO.AllowUserToAddRows = false;
            this.DG_DO.AllowUserToDeleteRows = false;
            this.DG_DO.AllowUserToResizeColumns = false;
            this.DG_DO.AllowUserToResizeRows = false;
            this.DG_DO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_DO.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_DO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DG_DO.ColumnHeadersHeight = 22;
            this.DG_DO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_DO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_DO_Name,
            this.Col_DO_Port,
            this.Col_DO_Mode,
            this.ColulmnDOState});
            this.DG_DO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_DO.Location = new System.Drawing.Point(3, 19);
            this.DG_DO.MultiSelect = false;
            this.DG_DO.Name = "DG_DO";
            this.DG_DO.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DG_DO.RowTemplate.Height = 23;
            this.DG_DO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_DO.Size = new System.Drawing.Size(565, 221);
            this.DG_DO.TabIndex = 28;
            this.DG_DO.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DG_DO_CellBeginEdit);
            this.DG_DO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_DO_CellContentClick);
            this.DG_DO.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_DO_CellEndEdit);
            this.DG_DO.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DG_DO_RowPostPaint);
            this.DG_DO.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DG_DO_MouseClick);
            this.DG_DO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DG_DO_MouseDown);
            // 
            // Col_DO_Name
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.Col_DO_Name.DefaultCellStyle = dataGridViewCellStyle8;
            this.Col_DO_Name.HeaderText = "名称";
            this.Col_DO_Name.Name = "Col_DO_Name";
            this.Col_DO_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_DO_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_DO_Port
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.Col_DO_Port.DefaultCellStyle = dataGridViewCellStyle9;
            this.Col_DO_Port.FillWeight = 50F;
            this.Col_DO_Port.HeaderText = "端口";
            this.Col_DO_Port.Name = "Col_DO_Port";
            this.Col_DO_Port.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_DO_Port.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_DO_Mode
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.Col_DO_Mode.DefaultCellStyle = dataGridViewCellStyle10;
            this.Col_DO_Mode.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Col_DO_Mode.FillWeight = 50F;
            this.Col_DO_Mode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Col_DO_Mode.HeaderText = "模式";
            this.Col_DO_Mode.Items.AddRange(new object[] {
            "常开",
            "常闭"});
            this.Col_DO_Mode.Name = "Col_DO_Mode";
            this.Col_DO_Mode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColulmnDOState
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.NullValue = false;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.ColulmnDOState.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColulmnDOState.FillWeight = 50F;
            this.ColulmnDOState.HeaderText = "状态";
            this.ColulmnDOState.Name = "ColulmnDOState";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(513, 547);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(60, 28);
            this.Btn_Cancel.TabIndex = 33;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(447, 547);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(60, 28);
            this.Btn_OK.TabIndex = 32;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Gb_Input
            // 
            this.Gb_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gb_Input.Controls.Add(this.DG_DI);
            this.Gb_Input.Location = new System.Drawing.Point(4, 32);
            this.Gb_Input.Name = "Gb_Input";
            this.Gb_Input.Size = new System.Drawing.Size(574, 263);
            this.Gb_Input.TabIndex = 34;
            this.Gb_Input.TabStop = false;
            this.Gb_Input.Text = "输入信号";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DG_DO);
            this.groupBox1.Location = new System.Drawing.Point(4, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 243);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输出信号";
            // 
            // CM_Operation
            // 
            this.CM_Operation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.CM_Operation.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CM_Operation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_Add,
            this.Tsmi_Del,
            this.Tsmi_AutoSetPort,
            this.Tsmi_ImportExcel});
            this.CM_Operation.Name = "CM_Operation";
            this.CM_Operation.Size = new System.Drawing.Size(149, 92);
            // 
            // Tsmi_Add
            // 
            this.Tsmi_Add.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_Add.Image")));
            this.Tsmi_Add.Name = "Tsmi_Add";
            this.Tsmi_Add.Size = new System.Drawing.Size(148, 22);
            this.Tsmi_Add.Text = "添加";
            this.Tsmi_Add.Click += new System.EventHandler(this.Tsmi_Add_Click);
            // 
            // Tsmi_Del
            // 
            this.Tsmi_Del.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_Del.Image")));
            this.Tsmi_Del.Name = "Tsmi_Del";
            this.Tsmi_Del.Size = new System.Drawing.Size(148, 22);
            this.Tsmi_Del.Text = "删除";
            this.Tsmi_Del.Click += new System.EventHandler(this.Tsmi_Del_Click);
            // 
            // Tsmi_AutoSetPort
            // 
            this.Tsmi_AutoSetPort.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_AutoSetPort.Image")));
            this.Tsmi_AutoSetPort.Name = "Tsmi_AutoSetPort";
            this.Tsmi_AutoSetPort.Size = new System.Drawing.Size(148, 22);
            this.Tsmi_AutoSetPort.Text = "自动设置端口";
            // 
            // Tsmi_ImportExcel
            // 
            this.Tsmi_ImportExcel.Image = ((System.Drawing.Image)(resources.GetObject("Tsmi_ImportExcel.Image")));
            this.Tsmi_ImportExcel.Name = "Tsmi_ImportExcel";
            this.Tsmi_ImportExcel.Size = new System.Drawing.Size(148, 22);
            this.Tsmi_ImportExcel.Text = "导入Excel";
            // 
            // Timer_ReadIO
            // 
            this.Timer_ReadIO.Tick += new System.EventHandler(this.Timer_ReadIO_Tick);
            // 
            // FrmIOSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(579, 579);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gb_Input);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.MaxVisible = false;
            this.Name = "FrmIOSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IO设置";
            this.TitleVisiable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIOSet_FormClosing);
            this.Controls.SetChildIndex(this.Btn_OK, 0);
            this.Controls.SetChildIndex(this.Btn_Cancel, 0);
            this.Controls.SetChildIndex(this.Gb_Input, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DG_DI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_DO)).EndInit();
            this.Gb_Input.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.CM_Operation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DG_DI;
        private System.Windows.Forms.DataGridView DG_DO;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.GroupBox Gb_Input;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip CM_Operation;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Add;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Del;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_AutoSetPort;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_ImportExcel;
        private System.Windows.Forms.Timer Timer_ReadIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DI_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DI_Port;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col_DI_Mode;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_DI_State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DO_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DO_Port;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col_DO_Mode;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColulmnDOState;
    }
}