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
            this.num_MaxContour = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.num_MinContour = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.num_Smooth = new System.Windows.Forms.NumericUpDown();
            this.lbl_Smooth = new System.Windows.Forms.Label();
            this.num_HightThreshold = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.num_LowThreshold = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_NumLevels = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DG_MatchingNum = new System.Windows.Forms.DataGridView();
            this.col_Row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Angle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UC_Image_Template = new DispenseAPP.WindowControl.UC_Image_Display();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.gb_Find = new System.Windows.Forms.GroupBox();
            this.num_MinScore = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.num_OverLap = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.num_MatchingNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.num_AngleExtent = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.num_StartAngle = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Matching = new System.Windows.Forms.Button();
            this.panel_Image = new System.Windows.Forms.Panel();
            this.UC_Image = new DispenseAPP.UC_Image();
            this.panel_Param.SuspendLayout();
            this.gb_Create.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MaxContour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MinContour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Smooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_HightThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_LowThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_MatchingNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gb_Find.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MinScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_OverLap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MatchingNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_AngleExtent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_StartAngle)).BeginInit();
            this.panel_Image.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.Location = new System.Drawing.Point(3, 1);
            this.lbl_ProjectName.Size = new System.Drawing.Size(65, 20);
            this.lbl_ProjectName.Text = "轮廓匹配";
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
            this.gb_Create.Controls.Add(this.num_MaxContour);
            this.gb_Create.Controls.Add(this.label7);
            this.gb_Create.Controls.Add(this.num_MinContour);
            this.gb_Create.Controls.Add(this.label5);
            this.gb_Create.Controls.Add(this.num_Smooth);
            this.gb_Create.Controls.Add(this.lbl_Smooth);
            this.gb_Create.Controls.Add(this.num_HightThreshold);
            this.gb_Create.Controls.Add(this.label1);
            this.gb_Create.Controls.Add(this.num_LowThreshold);
            this.gb_Create.Controls.Add(this.label9);
            this.gb_Create.Controls.Add(this.cmb_NumLevels);
            this.gb_Create.Controls.Add(this.label2);
            this.gb_Create.Location = new System.Drawing.Point(4, 204);
            this.gb_Create.Name = "gb_Create";
            this.gb_Create.Size = new System.Drawing.Size(299, 136);
            this.gb_Create.TabIndex = 1;
            this.gb_Create.TabStop = false;
            this.gb_Create.Text = "创建参数列表";
            // 
            // num_MaxContour
            // 
            this.num_MaxContour.Location = new System.Drawing.Point(72, 98);
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
            this.num_MaxContour.ValueChanged += new System.EventHandler(this.num_MaxContour_ValueChanged);
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(6, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 57;
            this.label7.Text = "最长轮廓";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_MinContour
            // 
            this.num_MinContour.Location = new System.Drawing.Point(227, 56);
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
            this.num_MinContour.ValueChanged += new System.EventHandler(this.num_MinContour_ValueChanged);
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(146, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 55;
            this.label5.Text = "最短轮廓";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_Smooth
            // 
            this.num_Smooth.Location = new System.Drawing.Point(75, 55);
            this.num_Smooth.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.num_Smooth.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.num_Smooth.Name = "num_Smooth";
            this.num_Smooth.Size = new System.Drawing.Size(65, 23);
            this.num_Smooth.TabIndex = 54;
            this.num_Smooth.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lbl_Smooth
            // 
            this.lbl_Smooth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Smooth.Location = new System.Drawing.Point(9, 56);
            this.lbl_Smooth.Name = "lbl_Smooth";
            this.lbl_Smooth.Size = new System.Drawing.Size(60, 24);
            this.lbl_Smooth.TabIndex = 53;
            this.lbl_Smooth.Text = "滤波系数";
            this.lbl_Smooth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_HightThreshold
            // 
            this.num_HightThreshold.Location = new System.Drawing.Point(227, 17);
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
            this.num_HightThreshold.ValueChanged += new System.EventHandler(this.num_HightThreshold_ValueChanged);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(146, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "高阈值";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_LowThreshold
            // 
            this.num_LowThreshold.Location = new System.Drawing.Point(75, 16);
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
            this.num_LowThreshold.ValueChanged += new System.EventHandler(this.num_LowThreshold_ValueChanged);
            // 
            // label9
            // 
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(9, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 24);
            this.label9.TabIndex = 49;
            this.label9.Text = "低阈值";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_NumLevels
            // 
            this.cmb_NumLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_NumLevels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_NumLevels.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_NumLevels.FormattingEnabled = true;
            this.cmb_NumLevels.Items.AddRange(new object[] {
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
            this.cmb_NumLevels.Location = new System.Drawing.Point(225, 95);
            this.cmb_NumLevels.Name = "cmb_NumLevels";
            this.cmb_NumLevels.Size = new System.Drawing.Size(67, 25);
            this.cmb_NumLevels.TabIndex = 27;
            this.cmb_NumLevels.SelectedIndexChanged += new System.EventHandler(this.cmb_NumLevels_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(146, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "金字塔层数";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.DG_MatchingNum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Row,
            this.col_Column,
            this.col_Angle,
            this.col_Score});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_MatchingNum.DefaultCellStyle = dataGridViewCellStyle2;
            this.DG_MatchingNum.GridColor = System.Drawing.Color.Black;
            this.DG_MatchingNum.Location = new System.Drawing.Point(4, 480);
            this.DG_MatchingNum.Name = "DG_MatchingNum";
            this.DG_MatchingNum.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DG_MatchingNum.RowHeadersWidth = 25;
            this.DG_MatchingNum.RowTemplate.Height = 23;
            this.DG_MatchingNum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_MatchingNum.Size = new System.Drawing.Size(298, 156);
            this.DG_MatchingNum.TabIndex = 45;
            this.DG_MatchingNum.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DG_MatchingNum_RowPostPaint);
            // 
            // col_Row
            // 
            this.col_Row.HeaderText = "横坐标";
            this.col_Row.Name = "col_Row";
            this.col_Row.ReadOnly = true;
            // 
            // col_Column
            // 
            this.col_Column.HeaderText = "纵坐标";
            this.col_Column.Name = "col_Column";
            this.col_Column.ReadOnly = true;
            // 
            // col_Angle
            // 
            this.col_Angle.HeaderText = "角度";
            this.col_Angle.Name = "col_Angle";
            this.col_Angle.ReadOnly = true;
            // 
            // col_Score
            // 
            this.col_Score.HeaderText = "分数";
            this.col_Score.Name = "col_Score";
            this.col_Score.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UC_Image_Template);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.btn_Edit);
            this.groupBox2.Controls.Add(this.btn_Load);
            this.groupBox2.Controls.Add(this.btn_New);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 195);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作模板";
            // 
            // UC_Image_Template
            // 
            this.UC_Image_Template.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UC_Image_Template.Location = new System.Drawing.Point(64, 22);
            this.UC_Image_Template.Name = "UC_Image_Template";
            this.UC_Image_Template.Size = new System.Drawing.Size(228, 166);
            this.UC_Image_Template.TabIndex = 13;
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
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Edit.Location = new System.Drawing.Point(6, 114);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(52, 28);
            this.btn_Edit.TabIndex = 11;
            this.btn_Edit.Text = "编辑";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
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
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_New.Location = new System.Drawing.Point(6, 22);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(52, 28);
            this.btn_New.TabIndex = 9;
            this.btn_New.Text = "新建";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // gb_Find
            // 
            this.gb_Find.Controls.Add(this.num_MinScore);
            this.gb_Find.Controls.Add(this.label10);
            this.gb_Find.Controls.Add(this.num_OverLap);
            this.gb_Find.Controls.Add(this.label11);
            this.gb_Find.Controls.Add(this.num_MatchingNum);
            this.gb_Find.Controls.Add(this.label6);
            this.gb_Find.Controls.Add(this.num_AngleExtent);
            this.gb_Find.Controls.Add(this.label4);
            this.gb_Find.Controls.Add(this.num_StartAngle);
            this.gb_Find.Controls.Add(this.label3);
            this.gb_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_Find.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gb_Find.Location = new System.Drawing.Point(3, 343);
            this.gb_Find.Name = "gb_Find";
            this.gb_Find.Size = new System.Drawing.Size(299, 131);
            this.gb_Find.TabIndex = 4;
            this.gb_Find.TabStop = false;
            this.gb_Find.Text = "查找参数列表";
            // 
            // num_MinScore
            // 
            this.num_MinScore.Location = new System.Drawing.Point(75, 57);
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
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(9, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 24);
            this.label10.TabIndex = 38;
            this.label10.Text = "最小分数";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_OverLap
            // 
            this.num_OverLap.Location = new System.Drawing.Point(75, 95);
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
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Location = new System.Drawing.Point(9, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 24);
            this.label11.TabIndex = 36;
            this.label11.Text = "重合度(%)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_MatchingNum
            // 
            this.num_MatchingNum.Location = new System.Drawing.Point(227, 56);
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
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(147, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 34;
            this.label6.Text = "匹配个数";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_AngleExtent
            // 
            this.num_AngleExtent.Location = new System.Drawing.Point(224, 21);
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
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(147, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 30;
            this.label4.Text = "角度范围(°)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(1032, 680);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(936, 681);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 28);
            this.btn_OK.TabIndex = 8;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Matching
            // 
            this.btn_Matching.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Matching.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Matching.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Matching.Location = new System.Drawing.Point(780, 681);
            this.btn_Matching.Name = "btn_Matching";
            this.btn_Matching.Size = new System.Drawing.Size(75, 28);
            this.btn_Matching.TabIndex = 10;
            this.btn_Matching.Text = "匹配";
            this.btn_Matching.UseVisualStyleBackColor = true;
            this.btn_Matching.Click += new System.EventHandler(this.btn_Matching_Click);
            // 
            // panel_Image
            // 
            this.panel_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Image.AutoScroll = true;
            this.panel_Image.Controls.Add(this.UC_Image);
            this.panel_Image.Location = new System.Drawing.Point(1, 32);
            this.panel_Image.Name = "panel_Image";
            this.panel_Image.Size = new System.Drawing.Size(767, 680);
            this.panel_Image.TabIndex = 6;
            // 
            // UC_Image
            // 
            this.UC_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_Image.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UC_Image.Location = new System.Drawing.Point(0, 0);
            this.UC_Image.Name = "UC_Image";
            this.UC_Image.Size = new System.Drawing.Size(767, 680);
            this.UC_Image.TabIndex = 0;
            // 
            // FrmContourMathing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1111, 712);
            this.Controls.Add(this.btn_Matching);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.panel_Param);
            this.Controls.Add(this.panel_Image);
            this.Name = "FrmContourMathing";
            this.Text = "轮廓匹配";
            this.TitleVisiable = false;
            this.Load += new System.EventHandler(this.FrmContourMathing_Load);
            this.Controls.SetChildIndex(this.panel_Image, 0);
            this.Controls.SetChildIndex(this.panel_Param, 0);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.btn_Matching, 0);
            this.panel_Param.ResumeLayout(false);
            this.gb_Create.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_MaxContour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MinContour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Smooth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_HightThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_LowThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_MatchingNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gb_Find.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_MinScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_OverLap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MatchingNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_AngleExtent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_StartAngle)).EndInit();
            this.panel_Image.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Param;
        private System.Windows.Forms.GroupBox gb_Find;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_NumLevels;
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
        private System.Windows.Forms.Button btn_Matching;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Row;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Angle;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Score;
        private System.Windows.Forms.Panel panel_Image;
        private UC_Image UC_Image;
        private WindowControl.UC_Image_Display UC_Image_Template;
        private System.Windows.Forms.GroupBox gb_Create;
        private System.Windows.Forms.NumericUpDown num_MaxContour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown num_MinContour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_Smooth;
        private System.Windows.Forms.Label lbl_Smooth;
        private System.Windows.Forms.NumericUpDown num_HightThreshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_LowThreshold;
        private System.Windows.Forms.Label label9;
    }
}