namespace DispenseAPP
{
    partial class FrmAxisSet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAxisSet));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_Axis = new System.Windows.Forms.DataGridView();
            this.CM_Operation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tsmi_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Past = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Column_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_AxisName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Pitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Pulse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Acc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ResetSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ResetDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ResetOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_AgainResetSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SoftPEL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Col_SoftMEL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Col_SoftPELValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SoftMELValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Axis)).BeginInit();
            this.CM_Operation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.Location = new System.Drawing.Point(3, 1);
            this.lbl_ProjectName.Size = new System.Drawing.Size(79, 20);
            this.lbl_ProjectName.Text = "轴参数设置";
            // 
            // DG_Axis
            // 
            this.DG_Axis.AllowUserToAddRows = false;
            this.DG_Axis.AllowUserToDeleteRows = false;
            this.DG_Axis.AllowUserToResizeColumns = false;
            this.DG_Axis.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DG_Axis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_Axis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_Axis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Axis.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Axis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_Axis.ColumnHeadersHeight = 40;
            this.DG_Axis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_Axis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_No,
            this.Col_AxisName,
            this.Col_Pitch,
            this.Col_Pulse,
            this.Col_Acc,
            this.Col_ResetSpeed,
            this.Col_ResetDir,
            this.Col_ResetOrder,
            this.Col_AgainResetSpeed,
            this.Col_SoftPEL,
            this.Col_SoftMEL,
            this.Col_SoftPELValue,
            this.Col_SoftMELValue});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_Axis.DefaultCellStyle = dataGridViewCellStyle11;
            this.DG_Axis.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_Axis.Location = new System.Drawing.Point(1, 31);
            this.DG_Axis.Name = "DG_Axis";
            this.DG_Axis.RowHeadersVisible = false;
            this.DG_Axis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DG_Axis.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DG_Axis.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DG_Axis.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.DG_Axis.RowTemplate.Height = 23;
            this.DG_Axis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Axis.Size = new System.Drawing.Size(793, 315);
            this.DG_Axis.TabIndex = 1;
            this.DG_Axis.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DG_Axis_CellBeginEdit);
            this.DG_Axis.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Axis_CellEndEdit);
            this.DG_Axis.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DG_Axis_RowPostPaint);
            this.DG_Axis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DG_Axis_KeyDown);
            this.DG_Axis.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DG_Axis_MouseClick);
            this.DG_Axis.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DG_Axis_MouseDown);
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
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(734, 350);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(60, 28);
            this.Btn_Cancel.TabIndex = 35;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(668, 350);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(60, 28);
            this.Btn_OK.TabIndex = 34;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(4, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "注：添加轴、修改[螺距][每圈脉冲数]重启软件生效！";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column_No
            // 
            this.Column_No.DataPropertyName = "AxisID";
            this.Column_No.HeaderText = "轴号";
            this.Column_No.Name = "Column_No";
            this.Column_No.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_AxisName
            // 
            this.Col_AxisName.DataPropertyName = "AxisName";
            this.Col_AxisName.HeaderText = "轴名称";
            this.Col_AxisName.Name = "Col_AxisName";
            this.Col_AxisName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_Pitch
            // 
            this.Col_Pitch.DataPropertyName = "Pitch";
            this.Col_Pitch.HeaderText = "螺距";
            this.Col_Pitch.Name = "Col_Pitch";
            this.Col_Pitch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_Pulse
            // 
            this.Col_Pulse.DataPropertyName = "Pulse";
            this.Col_Pulse.HeaderText = "脉冲数";
            this.Col_Pulse.Name = "Col_Pulse";
            this.Col_Pulse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_Acc
            // 
            this.Col_Acc.DataPropertyName = "AccDec";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_Acc.DefaultCellStyle = dataGridViewCellStyle3;
            this.Col_Acc.HeaderText = "加减速";
            this.Col_Acc.Name = "Col_Acc";
            this.Col_Acc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_ResetSpeed
            // 
            this.Col_ResetSpeed.DataPropertyName = "ResetSpeed";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_ResetSpeed.DefaultCellStyle = dataGridViewCellStyle4;
            this.Col_ResetSpeed.HeaderText = "复位速度";
            this.Col_ResetSpeed.Name = "Col_ResetSpeed";
            this.Col_ResetSpeed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_ResetDir
            // 
            this.Col_ResetDir.DataPropertyName = "ResetDir";
            this.Col_ResetDir.HeaderText = "复位方向";
            this.Col_ResetDir.Name = "Col_ResetDir";
            this.Col_ResetDir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_ResetDir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_ResetOrder
            // 
            this.Col_ResetOrder.DataPropertyName = "ResetOrder";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Col_ResetOrder.DefaultCellStyle = dataGridViewCellStyle5;
            this.Col_ResetOrder.HeaderText = "复位顺序";
            this.Col_ResetOrder.Name = "Col_ResetOrder";
            this.Col_ResetOrder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_ResetOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_AgainResetSpeed
            // 
            this.Col_AgainResetSpeed.DataPropertyName = "AgainResetSpeed";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Col_AgainResetSpeed.DefaultCellStyle = dataGridViewCellStyle6;
            this.Col_AgainResetSpeed.HeaderText = "再次复位速度";
            this.Col_AgainResetSpeed.Name = "Col_AgainResetSpeed";
            this.Col_AgainResetSpeed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_SoftPEL
            // 
            this.Col_SoftPEL.DataPropertyName = "SoftPEL";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.NullValue = false;
            this.Col_SoftPEL.DefaultCellStyle = dataGridViewCellStyle7;
            this.Col_SoftPEL.HeaderText = "正软限位";
            this.Col_SoftPEL.Name = "Col_SoftPEL";
            this.Col_SoftPEL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Col_SoftMEL
            // 
            this.Col_SoftMEL.DataPropertyName = "SoftMEL";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.NullValue = false;
            this.Col_SoftMEL.DefaultCellStyle = dataGridViewCellStyle8;
            this.Col_SoftMEL.HeaderText = "负软限位";
            this.Col_SoftMEL.Name = "Col_SoftMEL";
            this.Col_SoftMEL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Col_SoftPELValue
            // 
            this.Col_SoftPELValue.DataPropertyName = "SoftPELValue";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Col_SoftPELValue.DefaultCellStyle = dataGridViewCellStyle9;
            this.Col_SoftPELValue.HeaderText = "正软限位值";
            this.Col_SoftPELValue.Name = "Col_SoftPELValue";
            this.Col_SoftPELValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_SoftMELValue
            // 
            this.Col_SoftMELValue.DataPropertyName = "SoftMELValue";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Col_SoftMELValue.DefaultCellStyle = dataGridViewCellStyle10;
            this.Col_SoftMELValue.HeaderText = "负软限位值";
            this.Col_SoftMELValue.Name = "Col_SoftMELValue";
            // 
            // FrmAxisSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(795, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.DG_Axis);
            this.MaxVisible = false;
            this.Name = "FrmAxisSet";
            this.Text = "轴参数设置";
            this.TitleVisiable = false;
            this.Controls.SetChildIndex(this.DG_Axis, 0);
            this.Controls.SetChildIndex(this.Btn_OK, 0);
            this.Controls.SetChildIndex(this.Btn_Cancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Axis)).EndInit();
            this.CM_Operation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Axis;
        private System.Windows.Forms.ContextMenuStrip CM_Operation;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Add;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Del;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Copy;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Past;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Insert;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Undo;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Redo;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Cut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_AxisName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Pitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Pulse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Acc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ResetSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ResetDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ResetOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_AgainResetSpeed;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_SoftPEL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_SoftMEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_SoftPELValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_SoftMELValue;
    }
}