namespace DispenseAPP.Tools_CommunControl.PLC
{
    partial class Tools_PLC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.tabControl_FindLine = new System.Windows.Forms.TabControl();
            this.tab_Basic = new System.Windows.Forms.TabPage();
            this.Panel_Basic = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Mode = new System.Windows.Forms.ComboBox();
            this.Cmb_Connect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Set = new System.Windows.Forms.Button();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_BlockName = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Panel_Data = new System.Windows.Forms.Panel();
            this.Gb_SendData = new System.Windows.Forms.GroupBox();
            this.DG_SendData = new System.Windows.Forms.DataGridView();
            this.Cmb_Type = new System.Windows.Forms.ComboBox();
            this.Lbl_Type = new System.Windows.Forms.Label();
            this.Num_Count = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Count = new System.Windows.Forms.Label();
            this.Num_Address = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Address = new System.Windows.Forms.Label();
            this.Cmb_Memory = new System.Windows.Forms.ComboBox();
            this.Lbl_Memory = new System.Windows.Forms.Label();
            this.tabControl_FindLine.SuspendLayout();
            this.tab_Basic.SuspendLayout();
            this.Panel_Basic.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Panel_Data.SuspendLayout();
            this.Gb_SendData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_SendData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Address)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(248, 375);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.Btn_Cancel.TabIndex = 20;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(145, 375);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 28);
            this.Btn_OK.TabIndex = 19;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // tabControl_FindLine
            // 
            this.tabControl_FindLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_FindLine.Controls.Add(this.tab_Basic);
            this.tabControl_FindLine.Controls.Add(this.tabPage1);
            this.tabControl_FindLine.ItemSize = new System.Drawing.Size(65, 18);
            this.tabControl_FindLine.Location = new System.Drawing.Point(0, 2);
            this.tabControl_FindLine.Multiline = true;
            this.tabControl_FindLine.Name = "tabControl_FindLine";
            this.tabControl_FindLine.SelectedIndex = 0;
            this.tabControl_FindLine.Size = new System.Drawing.Size(330, 367);
            this.tabControl_FindLine.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_FindLine.TabIndex = 18;
            // 
            // tab_Basic
            // 
            this.tab_Basic.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Basic.Controls.Add(this.Panel_Basic);
            this.tab_Basic.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab_Basic.Location = new System.Drawing.Point(4, 22);
            this.tab_Basic.Name = "tab_Basic";
            this.tab_Basic.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Basic.Size = new System.Drawing.Size(322, 341);
            this.tab_Basic.TabIndex = 0;
            this.tab_Basic.Text = "基本";
            // 
            // Panel_Basic
            // 
            this.Panel_Basic.Controls.Add(this.label1);
            this.Panel_Basic.Controls.Add(this.Cmb_Mode);
            this.Panel_Basic.Controls.Add(this.Cmb_Connect);
            this.Panel_Basic.Controls.Add(this.label2);
            this.Panel_Basic.Controls.Add(this.Btn_Set);
            this.Panel_Basic.Controls.Add(this.Txt_Name);
            this.Panel_Basic.Controls.Add(this.lbl_BlockName);
            this.Panel_Basic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Basic.Location = new System.Drawing.Point(3, 3);
            this.Panel_Basic.Name = "Panel_Basic";
            this.Panel_Basic.Size = new System.Drawing.Size(316, 335);
            this.Panel_Basic.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "模式：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cmb_Mode
            // 
            this.Cmb_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Mode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_Mode.FormattingEnabled = true;
            this.Cmb_Mode.Items.AddRange(new object[] {
            "读取位状态",
            "设置位状态为True",
            "设置位状态为False",
            "批量读取数据",
            "批量写入数据"});
            this.Cmb_Mode.Location = new System.Drawing.Point(66, 95);
            this.Cmb_Mode.Name = "Cmb_Mode";
            this.Cmb_Mode.Size = new System.Drawing.Size(161, 25);
            this.Cmb_Mode.TabIndex = 19;
            this.Cmb_Mode.SelectedIndexChanged += new System.EventHandler(this.Cmb_Mode_SelectedIndexChanged);
            // 
            // Cmb_Connect
            // 
            this.Cmb_Connect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_Connect.FormattingEnabled = true;
            this.Cmb_Connect.Location = new System.Drawing.Point(66, 47);
            this.Cmb_Connect.Name = "Cmb_Connect";
            this.Cmb_Connect.Size = new System.Drawing.Size(161, 25);
            this.Cmb_Connect.TabIndex = 18;
            this.Cmb_Connect.SelectedIndexChanged += new System.EventHandler(this.Cmb_Connect_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "连接：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Set
            // 
            this.Btn_Set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Set.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Set.Location = new System.Drawing.Point(233, 47);
            this.Btn_Set.Name = "Btn_Set";
            this.Btn_Set.Size = new System.Drawing.Size(46, 24);
            this.Btn_Set.TabIndex = 16;
            this.Btn_Set.Text = "配置";
            this.Btn_Set.UseVisualStyleBackColor = true;
            this.Btn_Set.Click += new System.EventHandler(this.Btn_Set_Click);
            // 
            // Txt_Name
            // 
            this.Txt_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_Name.Location = new System.Drawing.Point(66, 9);
            this.Txt_Name.Multiline = true;
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(213, 24);
            this.Txt_Name.TabIndex = 15;
            // 
            // lbl_BlockName
            // 
            this.lbl_BlockName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_BlockName.Location = new System.Drawing.Point(6, 9);
            this.lbl_BlockName.Name = "lbl_BlockName";
            this.lbl_BlockName.Size = new System.Drawing.Size(63, 24);
            this.lbl_BlockName.TabIndex = 14;
            this.lbl_BlockName.Text = "算子名：";
            this.lbl_BlockName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.Panel_Data);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(322, 341);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "数据";
            // 
            // Panel_Data
            // 
            this.Panel_Data.AutoScroll = true;
            this.Panel_Data.Controls.Add(this.Gb_SendData);
            this.Panel_Data.Controls.Add(this.Cmb_Type);
            this.Panel_Data.Controls.Add(this.Lbl_Type);
            this.Panel_Data.Controls.Add(this.Num_Count);
            this.Panel_Data.Controls.Add(this.Lbl_Count);
            this.Panel_Data.Controls.Add(this.Num_Address);
            this.Panel_Data.Controls.Add(this.Lbl_Address);
            this.Panel_Data.Controls.Add(this.Cmb_Memory);
            this.Panel_Data.Controls.Add(this.Lbl_Memory);
            this.Panel_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Data.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Panel_Data.Location = new System.Drawing.Point(3, 3);
            this.Panel_Data.Name = "Panel_Data";
            this.Panel_Data.Size = new System.Drawing.Size(316, 335);
            this.Panel_Data.TabIndex = 0;
            // 
            // Gb_SendData
            // 
            this.Gb_SendData.Controls.Add(this.DG_SendData);
            this.Gb_SendData.Location = new System.Drawing.Point(11, 152);
            this.Gb_SendData.Name = "Gb_SendData";
            this.Gb_SendData.Size = new System.Drawing.Size(278, 180);
            this.Gb_SendData.TabIndex = 30;
            this.Gb_SendData.TabStop = false;
            this.Gb_SendData.Text = "数据发送区";
            // 
            // DG_SendData
            // 
            this.DG_SendData.AllowUserToAddRows = false;
            this.DG_SendData.AllowUserToDeleteRows = false;
            this.DG_SendData.AllowUserToResizeColumns = false;
            this.DG_SendData.AllowUserToResizeRows = false;
            this.DG_SendData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_SendData.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_SendData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_SendData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_SendData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_SendData.Location = new System.Drawing.Point(3, 19);
            this.DG_SendData.MultiSelect = false;
            this.DG_SendData.Name = "DG_SendData";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_SendData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_SendData.RowHeadersWidth = 27;
            this.DG_SendData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DG_SendData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DG_SendData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DG_SendData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DG_SendData.RowTemplate.Height = 23;
            this.DG_SendData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_SendData.Size = new System.Drawing.Size(272, 158);
            this.DG_SendData.TabIndex = 29;
            this.DG_SendData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DG_SendData_RowPostPaint);
            // 
            // Cmb_Type
            // 
            this.Cmb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_Type.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cmb_Type.FormattingEnabled = true;
            this.Cmb_Type.Items.AddRange(new object[] {
            "DINT32"});
            this.Cmb_Type.Location = new System.Drawing.Point(85, 121);
            this.Cmb_Type.Name = "Cmb_Type";
            this.Cmb_Type.Size = new System.Drawing.Size(120, 25);
            this.Cmb_Type.TabIndex = 28;
            // 
            // Lbl_Type
            // 
            this.Lbl_Type.Location = new System.Drawing.Point(8, 120);
            this.Lbl_Type.Name = "Lbl_Type";
            this.Lbl_Type.Size = new System.Drawing.Size(71, 26);
            this.Lbl_Type.TabIndex = 27;
            this.Lbl_Type.Text = "类型：";
            this.Lbl_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Num_Count
            // 
            this.Num_Count.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Num_Count.Location = new System.Drawing.Point(85, 88);
            this.Num_Count.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Num_Count.Name = "Num_Count";
            this.Num_Count.Size = new System.Drawing.Size(120, 23);
            this.Num_Count.TabIndex = 26;
            this.Num_Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_Count.ValueChanged += new System.EventHandler(this.Num_Count_ValueChanged);
            // 
            // Lbl_Count
            // 
            this.Lbl_Count.Location = new System.Drawing.Point(8, 85);
            this.Lbl_Count.Name = "Lbl_Count";
            this.Lbl_Count.Size = new System.Drawing.Size(71, 26);
            this.Lbl_Count.TabIndex = 25;
            this.Lbl_Count.Text = "数量：";
            this.Lbl_Count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Num_Address
            // 
            this.Num_Address.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Num_Address.Location = new System.Drawing.Point(85, 50);
            this.Num_Address.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Num_Address.Name = "Num_Address";
            this.Num_Address.Size = new System.Drawing.Size(120, 23);
            this.Num_Address.TabIndex = 24;
            this.Num_Address.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // Lbl_Address
            // 
            this.Lbl_Address.Location = new System.Drawing.Point(8, 47);
            this.Lbl_Address.Name = "Lbl_Address";
            this.Lbl_Address.Size = new System.Drawing.Size(71, 26);
            this.Lbl_Address.TabIndex = 23;
            this.Lbl_Address.Text = "地址：";
            this.Lbl_Address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cmb_Memory
            // 
            this.Cmb_Memory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Memory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_Memory.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cmb_Memory.FormattingEnabled = true;
            this.Cmb_Memory.Items.AddRange(new object[] {
            "MR",
            "DR"});
            this.Cmb_Memory.Location = new System.Drawing.Point(85, 10);
            this.Cmb_Memory.Name = "Cmb_Memory";
            this.Cmb_Memory.Size = new System.Drawing.Size(120, 25);
            this.Cmb_Memory.TabIndex = 22;
            this.Cmb_Memory.SelectedIndexChanged += new System.EventHandler(this.Cmb_Memory_SelectedIndexChanged);
            // 
            // Lbl_Memory
            // 
            this.Lbl_Memory.Location = new System.Drawing.Point(8, 10);
            this.Lbl_Memory.Name = "Lbl_Memory";
            this.Lbl_Memory.Size = new System.Drawing.Size(71, 26);
            this.Lbl_Memory.TabIndex = 21;
            this.Lbl_Memory.Text = "数据区域：";
            this.Lbl_Memory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tools_PLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.tabControl_FindLine);
            this.Name = "Tools_PLC";
            this.Size = new System.Drawing.Size(330, 404);
            this.tabControl_FindLine.ResumeLayout(false);
            this.tab_Basic.ResumeLayout(false);
            this.Panel_Basic.ResumeLayout(false);
            this.Panel_Basic.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.Panel_Data.ResumeLayout(false);
            this.Gb_SendData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_SendData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Address)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.TabControl tabControl_FindLine;
        private System.Windows.Forms.TabPage tab_Basic;
        private System.Windows.Forms.Panel Panel_Basic;
        private System.Windows.Forms.ComboBox Cmb_Connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Set;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label lbl_BlockName;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox Cmb_Mode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_Data;
        private System.Windows.Forms.ComboBox Cmb_Memory;
        private System.Windows.Forms.Label Lbl_Memory;
        private System.Windows.Forms.Label Lbl_Address;
        private System.Windows.Forms.NumericUpDown Num_Address;
        private System.Windows.Forms.Label Lbl_Count;
        private System.Windows.Forms.NumericUpDown Num_Count;
        private System.Windows.Forms.Label Lbl_Type;
        private System.Windows.Forms.ComboBox Cmb_Type;
        private System.Windows.Forms.GroupBox Gb_SendData;
        private System.Windows.Forms.DataGridView DG_SendData;
    }
}
