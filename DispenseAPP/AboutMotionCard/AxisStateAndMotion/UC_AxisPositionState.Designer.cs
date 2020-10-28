namespace DispenseAPP
{
    partial class UC_AxisPositionState
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_Position = new System.Windows.Forms.DataGridView();
            this.Col_AxisName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_AxisPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PEL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Col_ORG = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Col_MEL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Col_Alarm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Timer_Read = new System.Windows.Forms.Timer(this.components);
            this.CM_Operation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tsmi_SetPosIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_SetNegIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.Rbtn_FixedLength = new System.Windows.Forms.RadioButton();
            this.Num_Speed = new System.Windows.Forms.NumericUpDown();
            this.Rbtn_Continue = new System.Windows.Forms.RadioButton();
            this.lbl_Speed = new System.Windows.Forms.Label();
            this.Num_Distance = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Distance = new System.Windows.Forms.Label();
            this.Btn_Neg = new System.Windows.Forms.Button();
            this.Btn_Pos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Position)).BeginInit();
            this.CM_Operation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Distance)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_Position
            // 
            this.DG_Position.AllowUserToAddRows = false;
            this.DG_Position.AllowUserToDeleteRows = false;
            this.DG_Position.AllowUserToResizeColumns = false;
            this.DG_Position.AllowUserToResizeRows = false;
            this.DG_Position.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DG_Position.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Position.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Position.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_Position.ColumnHeadersHeight = 22;
            this.DG_Position.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_Position.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_AxisName,
            this.Col_AxisPosition,
            this.Col_PEL,
            this.Col_ORG,
            this.Col_MEL,
            this.Col_Alarm});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_Position.DefaultCellStyle = dataGridViewCellStyle8;
            this.DG_Position.GridColor = System.Drawing.Color.Black;
            this.DG_Position.Location = new System.Drawing.Point(3, 55);
            this.DG_Position.MultiSelect = false;
            this.DG_Position.Name = "DG_Position";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Position.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DG_Position.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DG_Position.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DG_Position.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DG_Position.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DG_Position.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.DG_Position.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DG_Position.RowTemplate.Height = 24;
            this.DG_Position.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Position.ShowCellErrors = false;
            this.DG_Position.ShowEditingIcon = false;
            this.DG_Position.ShowRowErrors = false;
            this.DG_Position.Size = new System.Drawing.Size(420, 119);
            this.DG_Position.TabIndex = 23;
            this.DG_Position.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DG_Position_MouseDown);
            // 
            // Col_AxisName
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.Col_AxisName.DefaultCellStyle = dataGridViewCellStyle2;
            this.Col_AxisName.FillWeight = 60F;
            this.Col_AxisName.HeaderText = "轴名称";
            this.Col_AxisName.Name = "Col_AxisName";
            this.Col_AxisName.ReadOnly = true;
            this.Col_AxisName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col_AxisName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_AxisPosition
            // 
            this.Col_AxisPosition.DataPropertyName = "AxisPosition";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.Col_AxisPosition.DefaultCellStyle = dataGridViewCellStyle3;
            this.Col_AxisPosition.FillWeight = 45F;
            this.Col_AxisPosition.HeaderText = "坐标";
            this.Col_AxisPosition.Name = "Col_AxisPosition";
            this.Col_AxisPosition.ReadOnly = true;
            this.Col_AxisPosition.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col_AxisPosition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_PEL
            // 
            this.Col_PEL.DataPropertyName = "PEL";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.NullValue = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.Col_PEL.DefaultCellStyle = dataGridViewCellStyle4;
            this.Col_PEL.FillWeight = 35F;
            this.Col_PEL.HeaderText = "正限位";
            this.Col_PEL.Name = "Col_PEL";
            this.Col_PEL.ReadOnly = true;
            this.Col_PEL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Col_ORG
            // 
            this.Col_ORG.DataPropertyName = "ORG";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.NullValue = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.Col_ORG.DefaultCellStyle = dataGridViewCellStyle5;
            this.Col_ORG.FillWeight = 30F;
            this.Col_ORG.HeaderText = "原点";
            this.Col_ORG.Name = "Col_ORG";
            this.Col_ORG.ReadOnly = true;
            this.Col_ORG.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Col_MEL
            // 
            this.Col_MEL.DataPropertyName = "MEL";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.NullValue = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.Col_MEL.DefaultCellStyle = dataGridViewCellStyle6;
            this.Col_MEL.FillWeight = 35F;
            this.Col_MEL.HeaderText = "负限位";
            this.Col_MEL.Name = "Col_MEL";
            this.Col_MEL.ReadOnly = true;
            this.Col_MEL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Col_Alarm
            // 
            this.Col_Alarm.DataPropertyName = "Alarm";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.NullValue = false;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.Col_Alarm.DefaultCellStyle = dataGridViewCellStyle7;
            this.Col_Alarm.FillWeight = 30F;
            this.Col_Alarm.HeaderText = "报警";
            this.Col_Alarm.Name = "Col_Alarm";
            this.Col_Alarm.ReadOnly = true;
            this.Col_Alarm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Timer_Read
            // 
            this.Timer_Read.Tick += new System.EventHandler(this.Timer_Read_Tick);
            // 
            // CM_Operation
            // 
            this.CM_Operation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.CM_Operation.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CM_Operation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_SetPosIcon,
            this.Tsmi_SetNegIcon});
            this.CM_Operation.Name = "CM_Operation";
            this.CM_Operation.Size = new System.Drawing.Size(209, 48);
            // 
            // Tsmi_SetPosIcon
            // 
            this.Tsmi_SetPosIcon.Name = "Tsmi_SetPosIcon";
            this.Tsmi_SetPosIcon.Size = new System.Drawing.Size(208, 22);
            this.Tsmi_SetPosIcon.Text = "设置该轴正方向运动图标";
            this.Tsmi_SetPosIcon.Click += new System.EventHandler(this.Tsmi_SetPosIcon_Click);
            // 
            // Tsmi_SetNegIcon
            // 
            this.Tsmi_SetNegIcon.Name = "Tsmi_SetNegIcon";
            this.Tsmi_SetNegIcon.Size = new System.Drawing.Size(208, 22);
            this.Tsmi_SetNegIcon.Text = "设置该轴负方向运动图标";
            this.Tsmi_SetNegIcon.Click += new System.EventHandler(this.Tsmi_SetNegIcon_Click);
            // 
            // Rbtn_FixedLength
            // 
            this.Rbtn_FixedLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rbtn_FixedLength.Location = new System.Drawing.Point(3, 25);
            this.Rbtn_FixedLength.Name = "Rbtn_FixedLength";
            this.Rbtn_FixedLength.Size = new System.Drawing.Size(76, 22);
            this.Rbtn_FixedLength.TabIndex = 67;
            this.Rbtn_FixedLength.Text = "定长运动";
            this.Rbtn_FixedLength.UseVisualStyleBackColor = true;
            this.Rbtn_FixedLength.CheckedChanged += new System.EventHandler(this.Rbtn_FixedLength_CheckedChanged);
            // 
            // Num_Speed
            // 
            this.Num_Speed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num_Speed.DecimalPlaces = 3;
            this.Num_Speed.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Num_Speed.Location = new System.Drawing.Point(127, 2);
            this.Num_Speed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Num_Speed.Name = "Num_Speed";
            this.Num_Speed.Size = new System.Drawing.Size(85, 23);
            this.Num_Speed.TabIndex = 73;
            this.Num_Speed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Rbtn_Continue
            // 
            this.Rbtn_Continue.Checked = true;
            this.Rbtn_Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rbtn_Continue.Location = new System.Drawing.Point(3, 3);
            this.Rbtn_Continue.Name = "Rbtn_Continue";
            this.Rbtn_Continue.Size = new System.Drawing.Size(76, 22);
            this.Rbtn_Continue.TabIndex = 66;
            this.Rbtn_Continue.TabStop = true;
            this.Rbtn_Continue.Text = "连续运动";
            this.Rbtn_Continue.UseVisualStyleBackColor = true;
            this.Rbtn_Continue.CheckedChanged += new System.EventHandler(this.Rbtn_Continue_CheckedChanged);
            // 
            // lbl_Speed
            // 
            this.lbl_Speed.Location = new System.Drawing.Point(84, 3);
            this.lbl_Speed.Name = "lbl_Speed";
            this.lbl_Speed.Size = new System.Drawing.Size(37, 20);
            this.lbl_Speed.TabIndex = 72;
            this.lbl_Speed.Text = "速度:";
            this.lbl_Speed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Num_Distance
            // 
            this.Num_Distance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num_Distance.DecimalPlaces = 3;
            this.Num_Distance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Num_Distance.Location = new System.Drawing.Point(127, 27);
            this.Num_Distance.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Num_Distance.Name = "Num_Distance";
            this.Num_Distance.Size = new System.Drawing.Size(85, 23);
            this.Num_Distance.TabIndex = 71;
            this.Num_Distance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Lbl_Distance
            // 
            this.Lbl_Distance.Location = new System.Drawing.Point(84, 27);
            this.Lbl_Distance.Name = "Lbl_Distance";
            this.Lbl_Distance.Size = new System.Drawing.Size(37, 20);
            this.Lbl_Distance.TabIndex = 70;
            this.Lbl_Distance.Text = "距离:";
            this.Lbl_Distance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Neg
            // 
            this.Btn_Neg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Neg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Neg.Location = new System.Drawing.Point(326, 3);
            this.Btn_Neg.Name = "Btn_Neg";
            this.Btn_Neg.Size = new System.Drawing.Size(97, 47);
            this.Btn_Neg.TabIndex = 69;
            this.Btn_Neg.Text = "负方向";
            this.Btn_Neg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Neg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Neg.UseVisualStyleBackColor = true;
            this.Btn_Neg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Neg_MouseDown);
            this.Btn_Neg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Neg_MouseUp);
            // 
            // Btn_Pos
            // 
            this.Btn_Pos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Pos.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Pos.Location = new System.Drawing.Point(218, 2);
            this.Btn_Pos.Name = "Btn_Pos";
            this.Btn_Pos.Size = new System.Drawing.Size(97, 47);
            this.Btn_Pos.TabIndex = 68;
            this.Btn_Pos.Text = "正方向";
            this.Btn_Pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Pos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Pos.UseVisualStyleBackColor = true;
            this.Btn_Pos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Pos_MouseDown);
            this.Btn_Pos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Pos_MouseUp);
            // 
            // UC_AxisPositionState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Rbtn_FixedLength);
            this.Controls.Add(this.Num_Speed);
            this.Controls.Add(this.Rbtn_Continue);
            this.Controls.Add(this.lbl_Speed);
            this.Controls.Add(this.Num_Distance);
            this.Controls.Add(this.Lbl_Distance);
            this.Controls.Add(this.Btn_Neg);
            this.Controls.Add(this.Btn_Pos);
            this.Controls.Add(this.DG_Position);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UC_AxisPositionState";
            this.Size = new System.Drawing.Size(425, 177);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Position)).EndInit();
            this.CM_Operation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Num_Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Distance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Position;
        private System.Windows.Forms.Timer Timer_Read;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_AxisName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_AxisPosition;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_PEL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_ORG;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_MEL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_Alarm;
        private System.Windows.Forms.ContextMenuStrip CM_Operation;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_SetPosIcon;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_SetNegIcon;
        private System.Windows.Forms.RadioButton Rbtn_FixedLength;
        private System.Windows.Forms.NumericUpDown Num_Speed;
        private System.Windows.Forms.RadioButton Rbtn_Continue;
        private System.Windows.Forms.Label lbl_Speed;
        private System.Windows.Forms.NumericUpDown Num_Distance;
        private System.Windows.Forms.Label Lbl_Distance;
        private System.Windows.Forms.Button Btn_Neg;
        private System.Windows.Forms.Button Btn_Pos;
    }
}
