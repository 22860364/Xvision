namespace DispenseAPP.Tools_Location.ContourMatchin
{
    partial class FrmContourMathing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Param = new System.Windows.Forms.Panel();
            this.gb_Create = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.num_MaxContour = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.num_MinContour = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.num_HightThreshold = new System.Windows.Forms.NumericUpDown();
            this.num_LowThreshold = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.DG_MatchingNum = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Pb_TempImage = new System.Windows.Forms.PictureBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.Btn_New = new System.Windows.Forms.Button();
            this.gb_Find = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.num_MinScore = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.num_OverLap = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.num_MatchingNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.num_AngleExtent = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNumLevels = new System.Windows.Forms.ComboBox();
            this.num_StartAngle = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Matching = new System.Windows.Forms.Button();
            this.uC_MyWindow1 = new DispenseAPP.MyStyleControl.UC_CameraWindow();
            this.panel_Param.SuspendLayout();
            this.gb_Create.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MaxContour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MinContour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_HightThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_LowThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_MatchingNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_TempImage)).BeginInit();
            this.gb_Find.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MinScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_OverLap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MatchingNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_AngleExtent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_StartAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(65, 20);
            this.lbl_Title.Text = "轮廓匹配";
            // 
            // panel_Param
            // 
            this.panel_Param.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Param.AutoScroll = true;
            this.panel_Param.Controls.Add(this.gb_Create);
            this.panel_Param.Controls.Add(this.DG_MatchingNum);
            this.panel_Param.Controls.Add(this.groupBox2);
            this.panel_Param.Controls.Add(this.gb_Find);
            this.panel_Param.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel_Param.Location = new System.Drawing.Point(776, 32);
            this.panel_Param.Name = "panel_Param";
            this.panel_Param.Size = new System.Drawing.Size(330, 642);
            this.panel_Param.TabIndex = 7;
            // 
            // gb_Create
            // 
            this.gb_Create.Controls.Add(this.label8);
            this.gb_Create.Controls.Add(this.num_MaxContour);
            this.gb_Create.Controls.Add(this.label7);
            this.gb_Create.Controls.Add(this.num_MinContour);
            this.gb_Create.Controls.Add(this.label5);
            this.gb_Create.Controls.Add(this.num_HightThreshold);
            this.gb_Create.Controls.Add(this.num_LowThreshold);
            this.gb_Create.Controls.Add(this.label9);
            this.gb_Create.Location = new System.Drawing.Point(4, 213);
            this.gb_Create.Name = "gb_Create";
            this.gb_Create.Size = new System.Drawing.Size(318, 97);
            this.gb_Create.TabIndex = 1;
            this.gb_Create.TabStop = false;
            this.gb_Create.Text = "创建参数列表";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(161, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 59;
            this.label8.Text = "高阈值";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_MaxContour
            // 
            this.num_MaxContour.Location = new System.Drawing.Point(75, 58);
            this.num_MaxContour.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_MaxContour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_MaxContour.Name = "num_MaxContour";
            this.num_MaxContour.Size = new System.Drawing.Size(65, 23);
            this.num_MaxContour.TabIndex = 58;
            this.num_MaxContour.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_MaxContour.ValueChanged += new System.EventHandler(this.Num_MaxContour_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(8, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "最长轮廓";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_MinContour
            // 
            this.num_MinContour.Location = new System.Drawing.Point(231, 58);
            this.num_MinContour.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_MinContour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_MinContour.Name = "num_MinContour";
            this.num_MinContour.Size = new System.Drawing.Size(65, 23);
            this.num_MinContour.TabIndex = 56;
            this.num_MinContour.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_MinContour.ValueChanged += new System.EventHandler(this.Num_MinContour_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(161, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "最短轮廓";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_HightThreshold
            // 
            this.num_HightThreshold.Location = new System.Drawing.Point(231, 23);
            this.num_HightThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_HightThreshold.Name = "num_HightThreshold";
            this.num_HightThreshold.Size = new System.Drawing.Size(65, 23);
            this.num_HightThreshold.TabIndex = 52;
            this.num_HightThreshold.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.num_HightThreshold.ValueChanged += new System.EventHandler(this.Num_HightThreshold_ValueChanged);
            // 
            // num_LowThreshold
            // 
            this.num_LowThreshold.Location = new System.Drawing.Point(74, 22);
            this.num_LowThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_LowThreshold.Name = "num_LowThreshold";
            this.num_LowThreshold.Size = new System.Drawing.Size(65, 23);
            this.num_LowThreshold.TabIndex = 50;
            this.num_LowThreshold.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_LowThreshold.ValueChanged += new System.EventHandler(this.Num_LowThreshold_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(8, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 49;
            this.label9.Text = "低阈值";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DG_MatchingNum
            // 
            this.DG_MatchingNum.AllowUserToAddRows = false;
            this.DG_MatchingNum.AllowUserToDeleteRows = false;
            this.DG_MatchingNum.AllowUserToResizeColumns = false;
            this.DG_MatchingNum.AllowUserToResizeRows = false;
            this.DG_MatchingNum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_MatchingNum.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_MatchingNum.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_MatchingNum.DefaultCellStyle = dataGridViewCellStyle2;
            this.DG_MatchingNum.GridColor = System.Drawing.Color.Black;
            this.DG_MatchingNum.Location = new System.Drawing.Point(4, 456);
            this.DG_MatchingNum.Name = "DG_MatchingNum";
            this.DG_MatchingNum.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DG_MatchingNum.RowHeadersWidth = 25;
            this.DG_MatchingNum.RowTemplate.Height = 23;
            this.DG_MatchingNum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_MatchingNum.Size = new System.Drawing.Size(318, 183);
            this.DG_MatchingNum.TabIndex = 45;
            this.DG_MatchingNum.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DG_MatchingNum_RowPostPaint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Pb_TempImage);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.Btn_Edit);
            this.groupBox2.Controls.Add(this.btn_Load);
            this.groupBox2.Controls.Add(this.Btn_New);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 195);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作模板";
            // 
            // Pb_TempImage
            // 
            this.Pb_TempImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Pb_TempImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pb_TempImage.Location = new System.Drawing.Point(64, 19);
            this.Pb_TempImage.Name = "Pb_TempImage";
            this.Pb_TempImage.Size = new System.Drawing.Size(254, 173);
            this.Pb_TempImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_TempImage.TabIndex = 13;
            this.Pb_TempImage.TabStop = false;
            this.Pb_TempImage.Paint += new System.Windows.Forms.PaintEventHandler(this.Pb_TempImage_Paint);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Save.Location = new System.Drawing.Point(6, 160);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(52, 28);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Edit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Edit.Location = new System.Drawing.Point(6, 114);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(52, 28);
            this.Btn_Edit.TabIndex = 11;
            this.Btn_Edit.Text = "编辑";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Load.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Load.Location = new System.Drawing.Point(6, 68);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(52, 28);
            this.btn_Load.TabIndex = 10;
            this.btn_Load.Text = "加载";
            this.btn_Load.UseVisualStyleBackColor = true;
            // 
            // Btn_New
            // 
            this.Btn_New.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_New.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_New.Location = new System.Drawing.Point(6, 22);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(52, 28);
            this.Btn_New.TabIndex = 9;
            this.Btn_New.Text = "新建";
            this.Btn_New.UseVisualStyleBackColor = true;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // gb_Find
            // 
            this.gb_Find.Controls.Add(this.label13);
            this.gb_Find.Controls.Add(this.label12);
            this.gb_Find.Controls.Add(this.num_MinScore);
            this.gb_Find.Controls.Add(this.label10);
            this.gb_Find.Controls.Add(this.num_OverLap);
            this.gb_Find.Controls.Add(this.label11);
            this.gb_Find.Controls.Add(this.num_MatchingNum);
            this.gb_Find.Controls.Add(this.label6);
            this.gb_Find.Controls.Add(this.num_AngleExtent);
            this.gb_Find.Controls.Add(this.label4);
            this.gb_Find.Controls.Add(this.cmbNumLevels);
            this.gb_Find.Controls.Add(this.num_StartAngle);
            this.gb_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_Find.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gb_Find.Location = new System.Drawing.Point(4, 316);
            this.gb_Find.Name = "gb_Find";
            this.gb_Find.Size = new System.Drawing.Size(318, 134);
            this.gb_Find.TabIndex = 4;
            this.gb_Find.TabStop = false;
            this.gb_Find.Text = "查找参数列表";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Location = new System.Drawing.Point(153, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 41;
            this.label13.Text = "金字塔层数";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Location = new System.Drawing.Point(9, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 40;
            this.label12.Text = "起始角度";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_MinScore
            // 
            this.num_MinScore.Location = new System.Drawing.Point(75, 54);
            this.num_MinScore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_MinScore.Name = "num_MinScore";
            this.num_MinScore.Size = new System.Drawing.Size(65, 23);
            this.num_MinScore.TabIndex = 39;
            this.num_MinScore.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(9, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "最小分数";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_OverLap
            // 
            this.num_OverLap.Location = new System.Drawing.Point(74, 95);
            this.num_OverLap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_OverLap.Name = "num_OverLap";
            this.num_OverLap.Size = new System.Drawing.Size(65, 23);
            this.num_OverLap.TabIndex = 37;
            this.num_OverLap.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Location = new System.Drawing.Point(8, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "重合度(%)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_MatchingNum
            // 
            this.num_MatchingNum.Location = new System.Drawing.Point(227, 54);
            this.num_MatchingNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_MatchingNum.Name = "num_MatchingNum";
            this.num_MatchingNum.Size = new System.Drawing.Size(65, 23);
            this.num_MatchingNum.TabIndex = 35;
            this.num_MatchingNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(161, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "匹配个数";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_AngleExtent
            // 
            this.num_AngleExtent.Location = new System.Drawing.Point(227, 21);
            this.num_AngleExtent.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.num_AngleExtent.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.num_AngleExtent.Name = "num_AngleExtent";
            this.num_AngleExtent.Size = new System.Drawing.Size(65, 23);
            this.num_AngleExtent.TabIndex = 31;
            this.num_AngleExtent.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(161, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "角度范围";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbNumLevels
            // 
            this.cmbNumLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumLevels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNumLevels.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbNumLevels.FormattingEnabled = true;
            this.cmbNumLevels.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "自动"});
            this.cmbNumLevels.Location = new System.Drawing.Point(228, 92);
            this.cmbNumLevels.Name = "cmbNumLevels";
            this.cmbNumLevels.Size = new System.Drawing.Size(79, 25);
            this.cmbNumLevels.TabIndex = 27;
            this.cmbNumLevels.SelectedIndexChanged += new System.EventHandler(this.Cmb_NumLevels_SelectedIndexChanged);
            // 
            // num_StartAngle
            // 
            this.num_StartAngle.Location = new System.Drawing.Point(75, 21);
            this.num_StartAngle.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.num_StartAngle.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.num_StartAngle.Name = "num_StartAngle";
            this.num_StartAngle.Size = new System.Drawing.Size(65, 23);
            this.num_StartAngle.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(161, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "高阈值";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(147, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "金字塔层数";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(4, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "起始角度(°)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(1032, 680);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.Btn_Cancel.TabIndex = 9;
            this.Btn_Cancel.Text = "取 消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(936, 681);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 28);
            this.Btn_OK.TabIndex = 8;
            this.Btn_OK.Text = "确 定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Btn_Matching
            // 
            this.Btn_Matching.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Matching.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Matching.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Matching.Location = new System.Drawing.Point(780, 681);
            this.Btn_Matching.Name = "Btn_Matching";
            this.Btn_Matching.Size = new System.Drawing.Size(75, 28);
            this.Btn_Matching.TabIndex = 10;
            this.Btn_Matching.Text = "匹 配";
            this.Btn_Matching.UseVisualStyleBackColor = true;
            this.Btn_Matching.Click += new System.EventHandler(this.Btn_Matching_Click);
            // 
            // uC_MyWindow1
            // 
            this.uC_MyWindow1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_MyWindow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.uC_MyWindow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_MyWindow1.DispAvailableCamera = true;
            this.uC_MyWindow1.DispContinueAcq = true;
            this.uC_MyWindow1.DispDrawRectangle = true;
            this.uC_MyWindow1.DispDrawRectangle2 = false;
            this.uC_MyWindow1.DispImageAdaption = true;
            this.uC_MyWindow1.DispSingleAcq = true;
            this.uC_MyWindow1.Location = new System.Drawing.Point(1, 31);
            this.uC_MyWindow1.Name = "uC_MyWindow1";
            this.uC_MyWindow1.Size = new System.Drawing.Size(772, 680);
            this.uC_MyWindow1.TabIndex = 11;
            // 
            // FrmContourMathing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1111, 712);
            this.Controls.Add(this.uC_MyWindow1);
            this.Controls.Add(this.Btn_Matching);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.panel_Param);
            this.Name = "FrmContourMathing";
            this.Text = "轮廓匹配";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmContourMathing_FormClosing);
            this.Controls.SetChildIndex(this.panel_Param, 0);
            this.Controls.SetChildIndex(this.Btn_OK, 0);
            this.Controls.SetChildIndex(this.Btn_Cancel, 0);
            this.Controls.SetChildIndex(this.Btn_Matching, 0);
            this.Controls.SetChildIndex(this.uC_MyWindow1, 0);
            this.panel_Param.ResumeLayout(false);
            this.gb_Create.ResumeLayout(false);
            this.gb_Create.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MaxContour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MinContour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_HightThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_LowThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_MatchingNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_TempImage)).EndInit();
            this.gb_Find.ResumeLayout(false);
            this.gb_Find.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MinScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_OverLap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MatchingNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_AngleExtent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_StartAngle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Param;
        private System.Windows.Forms.GroupBox gb_Find;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button Btn_New;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNumLevels;
        private System.Windows.Forms.NumericUpDown num_AngleExtent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_StartAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_MatchingNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_MinScore;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown num_OverLap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DG_MatchingNum;
        private System.Windows.Forms.Button Btn_Matching;
        private System.Windows.Forms.GroupBox gb_Create;
        private System.Windows.Forms.NumericUpDown num_MaxContour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown num_MinContour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_HightThreshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_LowThreshold;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox Pb_TempImage;
        private MyStyleControl.UC_CameraWindow uC_MyWindow1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}