namespace DispenseAPP.Tools_CommunControl.Serial
{
    partial class Tools_Serial
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
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.tabControl_FindLine = new System.Windows.Forms.TabControl();
            this.tabPage_Base = new System.Windows.Forms.TabPage();
            this.panel_Basic = new System.Windows.Forms.Panel();
            this.Cb_ClearCache = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Num_TimeOut = new System.Windows.Forms.NumericUpDown();
            this.Cb_EnableTiemOut = new System.Windows.Forms.CheckBox();
            this.Cmb_Connect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Set = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_Data = new System.Windows.Forms.TabPage();
            this.Panel_Data = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ToBeSend = new System.Windows.Forms.TextBox();
            this.lb_Reference = new System.Windows.Forms.ListBox();
            this.txt_SelectedData = new System.Windows.Forms.TextBox();
            this.cmb_SelectedData = new System.Windows.Forms.ComboBox();
            this.rb_Send = new System.Windows.Forms.RadioButton();
            this.rb_Receive = new System.Windows.Forms.RadioButton();
            this.tabPage_Format = new System.Windows.Forms.TabPage();
            this.panel_Format = new System.Windows.Forms.Panel();
            this.gb_Boolean = new System.Windows.Forms.GroupBox();
            this.txt_False = new System.Windows.Forms.TextBox();
            this.txt_True = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gb_Value = new System.Windows.Forms.GroupBox();
            this.cmb_NumType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.num_Precision = new System.Windows.Forms.NumericUpDown();
            this.num_Width = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gb_String = new System.Windows.Forms.GroupBox();
            this.cmb_CharEncoding = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gb_Base = new System.Windows.Forms.GroupBox();
            this.cmb_LineFeedMode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_ByteOrder = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_Format = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl_FindLine.SuspendLayout();
            this.tabPage_Base.SuspendLayout();
            this.panel_Basic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_TimeOut)).BeginInit();
            this.tabPage_Data.SuspendLayout();
            this.Panel_Data.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_Format.SuspendLayout();
            this.panel_Format.SuspendLayout();
            this.gb_Boolean.SuspendLayout();
            this.gb_Value.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Precision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Width)).BeginInit();
            this.gb_String.SuspendLayout();
            this.gb_Base.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(248, 434);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.Btn_Cancel.TabIndex = 8;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(151, 434);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 28);
            this.Btn_OK.TabIndex = 7;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // tabControl_FindLine
            // 
            this.tabControl_FindLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabControl_FindLine.Controls.Add(this.tabPage_Base);
            this.tabControl_FindLine.Controls.Add(this.tabPage_Data);
            this.tabControl_FindLine.Controls.Add(this.tabPage_Format);
            this.tabControl_FindLine.ItemSize = new System.Drawing.Size(65, 18);
            this.tabControl_FindLine.Location = new System.Drawing.Point(0, 3);
            this.tabControl_FindLine.Multiline = true;
            this.tabControl_FindLine.Name = "tabControl_FindLine";
            this.tabControl_FindLine.SelectedIndex = 0;
            this.tabControl_FindLine.Size = new System.Drawing.Size(330, 427);
            this.tabControl_FindLine.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_FindLine.TabIndex = 6;
            // 
            // tabPage_Base
            // 
            this.tabPage_Base.Controls.Add(this.panel_Basic);
            this.tabPage_Base.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage_Base.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Base.Name = "tabPage_Base";
            this.tabPage_Base.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Base.Size = new System.Drawing.Size(322, 401);
            this.tabPage_Base.TabIndex = 0;
            this.tabPage_Base.Text = "基本";
            this.tabPage_Base.UseVisualStyleBackColor = true;
            // 
            // panel_Basic
            // 
            this.panel_Basic.AutoScroll = true;
            this.panel_Basic.AutoScrollMinSize = new System.Drawing.Size(0, 205);
            this.panel_Basic.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Basic.Controls.Add(this.Cb_ClearCache);
            this.panel_Basic.Controls.Add(this.label3);
            this.panel_Basic.Controls.Add(this.Num_TimeOut);
            this.panel_Basic.Controls.Add(this.Cb_EnableTiemOut);
            this.panel_Basic.Controls.Add(this.Cmb_Connect);
            this.panel_Basic.Controls.Add(this.label2);
            this.panel_Basic.Controls.Add(this.Btn_Set);
            this.panel_Basic.Controls.Add(this.txt_Name);
            this.panel_Basic.Controls.Add(this.label1);
            this.panel_Basic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Basic.Location = new System.Drawing.Point(3, 3);
            this.panel_Basic.Name = "panel_Basic";
            this.panel_Basic.Size = new System.Drawing.Size(316, 395);
            this.panel_Basic.TabIndex = 0;
            // 
            // Cb_ClearCache
            // 
            this.Cb_ClearCache.AutoSize = true;
            this.Cb_ClearCache.Location = new System.Drawing.Point(6, 148);
            this.Cb_ClearCache.Name = "Cb_ClearCache";
            this.Cb_ClearCache.Size = new System.Drawing.Size(75, 21);
            this.Cb_ClearCache.TabIndex = 15;
            this.Cb_ClearCache.Text = "清空缓存";
            this.Cb_ClearCache.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(241, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "MS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Num_TimeOut
            // 
            this.Num_TimeOut.Location = new System.Drawing.Point(101, 108);
            this.Num_TimeOut.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.Num_TimeOut.Name = "Num_TimeOut";
            this.Num_TimeOut.Size = new System.Drawing.Size(131, 23);
            this.Num_TimeOut.TabIndex = 12;
            this.Num_TimeOut.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // Cb_EnableTiemOut
            // 
            this.Cb_EnableTiemOut.AutoSize = true;
            this.Cb_EnableTiemOut.Location = new System.Drawing.Point(6, 109);
            this.Cb_EnableTiemOut.Name = "Cb_EnableTiemOut";
            this.Cb_EnableTiemOut.Size = new System.Drawing.Size(87, 21);
            this.Cb_EnableTiemOut.TabIndex = 11;
            this.Cb_EnableTiemOut.Text = "超时限制：";
            this.Cb_EnableTiemOut.UseVisualStyleBackColor = true;
            // 
            // Cmb_Connect
            // 
            this.Cmb_Connect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_Connect.FormattingEnabled = true;
            this.Cmb_Connect.Location = new System.Drawing.Point(54, 62);
            this.Cmb_Connect.Name = "Cmb_Connect";
            this.Cmb_Connect.Size = new System.Drawing.Size(184, 25);
            this.Cmb_Connect.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "连接：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Set
            // 
            this.Btn_Set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Set.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Set.Location = new System.Drawing.Point(244, 61);
            this.Btn_Set.Name = "Btn_Set";
            this.Btn_Set.Size = new System.Drawing.Size(46, 26);
            this.Btn_Set.TabIndex = 8;
            this.Btn_Set.Text = "配置";
            this.Btn_Set.UseVisualStyleBackColor = true;
            this.Btn_Set.Click += new System.EventHandler(this.Btn_Set_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Name.Location = new System.Drawing.Point(68, 20);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(222, 23);
            this.txt_Name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "算子名：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage_Data
            // 
            this.tabPage_Data.Controls.Add(this.Panel_Data);
            this.tabPage_Data.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Data.Name = "tabPage_Data";
            this.tabPage_Data.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Data.Size = new System.Drawing.Size(322, 401);
            this.tabPage_Data.TabIndex = 1;
            this.tabPage_Data.Text = "数据";
            this.tabPage_Data.UseVisualStyleBackColor = true;
            // 
            // Panel_Data
            // 
            this.Panel_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Panel_Data.AutoScroll = true;
            this.Panel_Data.AutoScrollMinSize = new System.Drawing.Size(0, 260);
            this.Panel_Data.BackColor = System.Drawing.SystemColors.Control;
            this.Panel_Data.Controls.Add(this.groupBox1);
            this.Panel_Data.Controls.Add(this.lb_Reference);
            this.Panel_Data.Controls.Add(this.txt_SelectedData);
            this.Panel_Data.Controls.Add(this.cmb_SelectedData);
            this.Panel_Data.Controls.Add(this.rb_Send);
            this.Panel_Data.Controls.Add(this.rb_Receive);
            this.Panel_Data.Location = new System.Drawing.Point(4, 3);
            this.Panel_Data.Name = "Panel_Data";
            this.Panel_Data.Size = new System.Drawing.Size(314, 395);
            this.Panel_Data.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ToBeSend);
            this.groupBox1.Location = new System.Drawing.Point(13, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 106);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "待发送数据";
            // 
            // txt_ToBeSend
            // 
            this.txt_ToBeSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ToBeSend.Location = new System.Drawing.Point(3, 17);
            this.txt_ToBeSend.Multiline = true;
            this.txt_ToBeSend.Name = "txt_ToBeSend";
            this.txt_ToBeSend.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_ToBeSend.Size = new System.Drawing.Size(270, 86);
            this.txt_ToBeSend.TabIndex = 15;
            // 
            // lb_Reference
            // 
            this.lb_Reference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Reference.FormattingEnabled = true;
            this.lb_Reference.ItemHeight = 12;
            this.lb_Reference.Location = new System.Drawing.Point(13, 82);
            this.lb_Reference.Name = "lb_Reference";
            this.lb_Reference.Size = new System.Drawing.Size(276, 74);
            this.lb_Reference.TabIndex = 16;
            // 
            // txt_SelectedData
            // 
            this.txt_SelectedData.Location = new System.Drawing.Point(142, 41);
            this.txt_SelectedData.Multiline = true;
            this.txt_SelectedData.Name = "txt_SelectedData";
            this.txt_SelectedData.Size = new System.Drawing.Size(147, 25);
            this.txt_SelectedData.TabIndex = 12;
            // 
            // cmb_SelectedData
            // 
            this.cmb_SelectedData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SelectedData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_SelectedData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_SelectedData.FormattingEnabled = true;
            this.cmb_SelectedData.Items.AddRange(new object[] {
            "数据筛选",
            "数据筛选（正则）"});
            this.cmb_SelectedData.Location = new System.Drawing.Point(13, 41);
            this.cmb_SelectedData.Name = "cmb_SelectedData";
            this.cmb_SelectedData.Size = new System.Drawing.Size(123, 25);
            this.cmb_SelectedData.TabIndex = 11;
            // 
            // rb_Send
            // 
            this.rb_Send.AutoSize = true;
            this.rb_Send.Location = new System.Drawing.Point(130, 14);
            this.rb_Send.Name = "rb_Send";
            this.rb_Send.Size = new System.Drawing.Size(47, 16);
            this.rb_Send.TabIndex = 1;
            this.rb_Send.TabStop = true;
            this.rb_Send.Text = "发送";
            this.rb_Send.UseVisualStyleBackColor = true;
            // 
            // rb_Receive
            // 
            this.rb_Receive.AutoSize = true;
            this.rb_Receive.Checked = true;
            this.rb_Receive.Location = new System.Drawing.Point(13, 14);
            this.rb_Receive.Name = "rb_Receive";
            this.rb_Receive.Size = new System.Drawing.Size(47, 16);
            this.rb_Receive.TabIndex = 0;
            this.rb_Receive.TabStop = true;
            this.rb_Receive.Text = "接受";
            this.rb_Receive.UseVisualStyleBackColor = true;
            // 
            // tabPage_Format
            // 
            this.tabPage_Format.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Format.Controls.Add(this.panel_Format);
            this.tabPage_Format.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Format.Name = "tabPage_Format";
            this.tabPage_Format.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Format.Size = new System.Drawing.Size(322, 401);
            this.tabPage_Format.TabIndex = 2;
            this.tabPage_Format.Text = "格式";
            // 
            // panel_Format
            // 
            this.panel_Format.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel_Format.AutoScroll = true;
            this.panel_Format.AutoScrollMinSize = new System.Drawing.Size(0, 260);
            this.panel_Format.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Format.Controls.Add(this.gb_Boolean);
            this.panel_Format.Controls.Add(this.gb_Value);
            this.panel_Format.Controls.Add(this.gb_String);
            this.panel_Format.Controls.Add(this.gb_Base);
            this.panel_Format.Location = new System.Drawing.Point(4, 3);
            this.panel_Format.Name = "panel_Format";
            this.panel_Format.Size = new System.Drawing.Size(314, 395);
            this.panel_Format.TabIndex = 1;
            // 
            // gb_Boolean
            // 
            this.gb_Boolean.Controls.Add(this.txt_False);
            this.gb_Boolean.Controls.Add(this.txt_True);
            this.gb_Boolean.Controls.Add(this.label13);
            this.gb_Boolean.Controls.Add(this.label12);
            this.gb_Boolean.Location = new System.Drawing.Point(12, 301);
            this.gb_Boolean.Name = "gb_Boolean";
            this.gb_Boolean.Size = new System.Drawing.Size(267, 85);
            this.gb_Boolean.TabIndex = 20;
            this.gb_Boolean.TabStop = false;
            this.gb_Boolean.Text = "布尔值";
            // 
            // txt_False
            // 
            this.txt_False.Location = new System.Drawing.Point(81, 50);
            this.txt_False.Multiline = true;
            this.txt_False.Name = "txt_False";
            this.txt_False.Size = new System.Drawing.Size(161, 25);
            this.txt_False.TabIndex = 15;
            // 
            // txt_True
            // 
            this.txt_True.Location = new System.Drawing.Point(81, 19);
            this.txt_True.Multiline = true;
            this.txt_True.Name = "txt_True";
            this.txt_True.Size = new System.Drawing.Size(161, 25);
            this.txt_True.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 26);
            this.label13.TabIndex = 13;
            this.label13.Text = "为假：";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 26);
            this.label12.TabIndex = 12;
            this.label12.Text = "为真：";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gb_Value
            // 
            this.gb_Value.Controls.Add(this.cmb_NumType);
            this.gb_Value.Controls.Add(this.label11);
            this.gb_Value.Controls.Add(this.num_Precision);
            this.gb_Value.Controls.Add(this.num_Width);
            this.gb_Value.Controls.Add(this.label10);
            this.gb_Value.Controls.Add(this.label9);
            this.gb_Value.Location = new System.Drawing.Point(12, 177);
            this.gb_Value.Name = "gb_Value";
            this.gb_Value.Size = new System.Drawing.Size(267, 118);
            this.gb_Value.TabIndex = 19;
            this.gb_Value.TabStop = false;
            this.gb_Value.Text = "数值";
            // 
            // cmb_NumType
            // 
            this.cmb_NumType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_NumType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_NumType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_NumType.FormattingEnabled = true;
            this.cmb_NumType.Items.AddRange(new object[] {
            "Int16",
            "Int32",
            "Int64",
            "Float",
            "Double"});
            this.cmb_NumType.Location = new System.Drawing.Point(81, 83);
            this.cmb_NumType.Name = "cmb_NumType";
            this.cmb_NumType.Size = new System.Drawing.Size(161, 25);
            this.cmb_NumType.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 26);
            this.label11.TabIndex = 22;
            this.label11.Text = "类型：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_Precision
            // 
            this.num_Precision.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_Precision.Location = new System.Drawing.Point(81, 54);
            this.num_Precision.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_Precision.Name = "num_Precision";
            this.num_Precision.Size = new System.Drawing.Size(120, 23);
            this.num_Precision.TabIndex = 21;
            // 
            // num_Width
            // 
            this.num_Width.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_Width.Location = new System.Drawing.Point(81, 25);
            this.num_Width.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_Width.Name = "num_Width";
            this.num_Width.Size = new System.Drawing.Size(120, 23);
            this.num_Width.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 26);
            this.label10.TabIndex = 19;
            this.label10.Text = "精度：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 26);
            this.label9.TabIndex = 17;
            this.label9.Text = "宽度：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gb_String
            // 
            this.gb_String.Controls.Add(this.cmb_CharEncoding);
            this.gb_String.Controls.Add(this.label8);
            this.gb_String.Location = new System.Drawing.Point(12, 121);
            this.gb_String.Name = "gb_String";
            this.gb_String.Size = new System.Drawing.Size(267, 50);
            this.gb_String.TabIndex = 1;
            this.gb_String.TabStop = false;
            this.gb_String.Text = "字符串";
            // 
            // cmb_CharEncoding
            // 
            this.cmb_CharEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CharEncoding.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_CharEncoding.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_CharEncoding.FormattingEnabled = true;
            this.cmb_CharEncoding.Items.AddRange(new object[] {
            "ASCII",
            "UTF-8"});
            this.cmb_CharEncoding.Location = new System.Drawing.Point(81, 19);
            this.cmb_CharEncoding.Name = "cmb_CharEncoding";
            this.cmb_CharEncoding.Size = new System.Drawing.Size(161, 25);
            this.cmb_CharEncoding.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 26);
            this.label8.TabIndex = 17;
            this.label8.Text = "字符编码：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gb_Base
            // 
            this.gb_Base.Controls.Add(this.cmb_LineFeedMode);
            this.gb_Base.Controls.Add(this.label7);
            this.gb_Base.Controls.Add(this.cmb_ByteOrder);
            this.gb_Base.Controls.Add(this.label6);
            this.gb_Base.Controls.Add(this.cmb_Format);
            this.gb_Base.Controls.Add(this.label5);
            this.gb_Base.Location = new System.Drawing.Point(12, 3);
            this.gb_Base.Name = "gb_Base";
            this.gb_Base.Size = new System.Drawing.Size(267, 112);
            this.gb_Base.TabIndex = 0;
            this.gb_Base.TabStop = false;
            this.gb_Base.Text = "基本";
            // 
            // cmb_LineFeedMode
            // 
            this.cmb_LineFeedMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_LineFeedMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_LineFeedMode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_LineFeedMode.FormattingEnabled = true;
            this.cmb_LineFeedMode.Items.AddRange(new object[] {
            "Windows",
            "Linux",
            "Mac"});
            this.cmb_LineFeedMode.Location = new System.Drawing.Point(81, 80);
            this.cmb_LineFeedMode.Name = "cmb_LineFeedMode";
            this.cmb_LineFeedMode.Size = new System.Drawing.Size(161, 25);
            this.cmb_LineFeedMode.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "换行模式：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_ByteOrder
            // 
            this.cmb_ByteOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ByteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_ByteOrder.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_ByteOrder.FormattingEnabled = true;
            this.cmb_ByteOrder.Items.AddRange(new object[] {
            "低字节序",
            "高字节序"});
            this.cmb_ByteOrder.Location = new System.Drawing.Point(81, 49);
            this.cmb_ByteOrder.Name = "cmb_ByteOrder";
            this.cmb_ByteOrder.Size = new System.Drawing.Size(161, 25);
            this.cmb_ByteOrder.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "字节序：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Format
            // 
            this.cmb_Format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Format.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_Format.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Format.FormattingEnabled = true;
            this.cmb_Format.Items.AddRange(new object[] {
            "内存数据",
            "字符串"});
            this.cmb_Format.Location = new System.Drawing.Point(81, 18);
            this.cmb_Format.Name = "cmb_Format";
            this.cmb_Format.Size = new System.Drawing.Size(161, 25);
            this.cmb_Format.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "格式：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tools_Serial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.tabControl_FindLine);
            this.Name = "Tools_Serial";
            this.Size = new System.Drawing.Size(330, 464);
            this.tabControl_FindLine.ResumeLayout(false);
            this.tabPage_Base.ResumeLayout(false);
            this.panel_Basic.ResumeLayout(false);
            this.panel_Basic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_TimeOut)).EndInit();
            this.tabPage_Data.ResumeLayout(false);
            this.Panel_Data.ResumeLayout(false);
            this.Panel_Data.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_Format.ResumeLayout(false);
            this.panel_Format.ResumeLayout(false);
            this.gb_Boolean.ResumeLayout(false);
            this.gb_Boolean.PerformLayout();
            this.gb_Value.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Precision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Width)).EndInit();
            this.gb_String.ResumeLayout(false);
            this.gb_Base.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.TabControl tabControl_FindLine;
        private System.Windows.Forms.TabPage tabPage_Base;
        private System.Windows.Forms.Panel panel_Basic;
        private System.Windows.Forms.CheckBox Cb_ClearCache;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Num_TimeOut;
        private System.Windows.Forms.CheckBox Cb_EnableTiemOut;
        private System.Windows.Forms.ComboBox Cmb_Connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Set;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_Data;
        private System.Windows.Forms.Panel Panel_Data;
        private System.Windows.Forms.ListBox lb_Reference;
        private System.Windows.Forms.TextBox txt_ToBeSend;
        private System.Windows.Forms.TextBox txt_SelectedData;
        private System.Windows.Forms.ComboBox cmb_SelectedData;
        private System.Windows.Forms.RadioButton rb_Send;
        private System.Windows.Forms.RadioButton rb_Receive;
        private System.Windows.Forms.TabPage tabPage_Format;
        private System.Windows.Forms.Panel panel_Format;
        private System.Windows.Forms.GroupBox gb_Boolean;
        private System.Windows.Forms.TextBox txt_False;
        private System.Windows.Forms.TextBox txt_True;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gb_Value;
        private System.Windows.Forms.ComboBox cmb_NumType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown num_Precision;
        private System.Windows.Forms.NumericUpDown num_Width;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gb_String;
        private System.Windows.Forms.ComboBox cmb_CharEncoding;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gb_Base;
        private System.Windows.Forms.ComboBox cmb_LineFeedMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_ByteOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_Format;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
