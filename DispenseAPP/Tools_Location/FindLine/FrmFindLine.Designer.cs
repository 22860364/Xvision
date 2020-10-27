namespace DispenseAPP.Tools_Location.FindLine
{
    partial class FrmFindLine
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.panel_Image = new System.Windows.Forms.Panel();
            this.uC_Image = new DispenseAPP.UC_Image();
            this.panel_Param = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PointAngle = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Point2Y = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Point1Y = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Point2X = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Point1X = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.num_EdgeWidth = new System.Windows.Forms.NumericUpDown();
            this.num_PointNum = new System.Windows.Forms.NumericUpDown();
            this.num_EdgeThresold = new System.Windows.Forms.NumericUpDown();
            this.cmb_EdgeType = new System.Windows.Forms.ComboBox();
            this.cmb_EdgePolar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_Image.SuspendLayout();
            this.panel_Param.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_EdgeWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PointNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EdgeThresold)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.Location = new System.Drawing.Point(3, 1);
            this.lbl_ProjectName.Size = new System.Drawing.Size(65, 20);
            this.lbl_ProjectName.Text = "直线检测";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(879, 505);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(731, 505);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 28);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // panel_Image
            // 
            this.panel_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Image.AutoScroll = true;
            this.panel_Image.Controls.Add(this.uC_Image);
            this.panel_Image.Location = new System.Drawing.Point(1, 26);
            this.panel_Image.Name = "panel_Image";
            this.panel_Image.Size = new System.Drawing.Size(692, 512);
            this.panel_Image.TabIndex = 5;
            // 
            // uC_Image
            // 
            this.uC_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Image.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uC_Image.Location = new System.Drawing.Point(0, 0);
            this.uC_Image.Name = "uC_Image";
            this.uC_Image.Size = new System.Drawing.Size(692, 512);
            this.uC_Image.TabIndex = 0;
            // 
            // panel_Param
            // 
            this.panel_Param.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Param.AutoScroll = true;
            this.panel_Param.Controls.Add(this.groupBox2);
            this.panel_Param.Controls.Add(this.groupBox1);
            this.panel_Param.Location = new System.Drawing.Point(700, 30);
            this.panel_Param.Name = "panel_Param";
            this.panel_Param.Size = new System.Drawing.Size(299, 383);
            this.panel_Param.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_PointAngle);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_Point2Y);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_Point1Y);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_Point2X);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_Point1X);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(4, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 151);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "结果";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(140, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "(与水平轴之间的角度)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_PointAngle
            // 
            this.txt_PointAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PointAngle.Location = new System.Drawing.Point(68, 117);
            this.txt_PointAngle.Multiline = true;
            this.txt_PointAngle.Name = "txt_PointAngle";
            this.txt_PointAngle.ReadOnly = true;
            this.txt_PointAngle.Size = new System.Drawing.Size(66, 21);
            this.txt_PointAngle.TabIndex = 18;
            this.txt_PointAngle.Text = "0";
            // 
            // label14
            // 
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Location = new System.Drawing.Point(6, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 24);
            this.label14.TabIndex = 17;
            this.label14.Text = "角度";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Point2Y
            // 
            this.txt_Point2Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Point2Y.Location = new System.Drawing.Point(214, 74);
            this.txt_Point2Y.Multiline = true;
            this.txt_Point2Y.Name = "txt_Point2Y";
            this.txt_Point2Y.ReadOnly = true;
            this.txt_Point2Y.Size = new System.Drawing.Size(66, 21);
            this.txt_Point2Y.TabIndex = 16;
            this.txt_Point2Y.Text = "0";
            // 
            // label12
            // 
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Location = new System.Drawing.Point(152, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 24);
            this.label12.TabIndex = 15;
            this.label12.Text = "第二点Y";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Point1Y
            // 
            this.txt_Point1Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Point1Y.Location = new System.Drawing.Point(214, 34);
            this.txt_Point1Y.Multiline = true;
            this.txt_Point1Y.Name = "txt_Point1Y";
            this.txt_Point1Y.ReadOnly = true;
            this.txt_Point1Y.Size = new System.Drawing.Size(66, 21);
            this.txt_Point1Y.TabIndex = 14;
            this.txt_Point1Y.Text = "0";
            // 
            // label13
            // 
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Location = new System.Drawing.Point(152, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 24);
            this.label13.TabIndex = 13;
            this.label13.Text = "第一点Y";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Point2X
            // 
            this.txt_Point2X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Point2X.Location = new System.Drawing.Point(68, 74);
            this.txt_Point2X.Multiline = true;
            this.txt_Point2X.Name = "txt_Point2X";
            this.txt_Point2X.ReadOnly = true;
            this.txt_Point2X.Size = new System.Drawing.Size(66, 21);
            this.txt_Point2X.TabIndex = 12;
            this.txt_Point2X.Text = "0";
            // 
            // label11
            // 
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Location = new System.Drawing.Point(6, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "第二点X";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Point1X
            // 
            this.txt_Point1X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Point1X.Location = new System.Drawing.Point(68, 34);
            this.txt_Point1X.Multiline = true;
            this.txt_Point1X.Name = "txt_Point1X";
            this.txt_Point1X.ReadOnly = true;
            this.txt_Point1X.Size = new System.Drawing.Size(66, 21);
            this.txt_Point1X.TabIndex = 10;
            this.txt_Point1X.Text = "0";
            // 
            // label10
            // 
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(6, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "第一点X";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.num_EdgeWidth);
            this.groupBox1.Controls.Add(this.num_PointNum);
            this.groupBox1.Controls.Add(this.num_EdgeThresold);
            this.groupBox1.Controls.Add(this.cmb_EdgeType);
            this.groupBox1.Controls.Add(this.cmb_EdgePolar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 214);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数列表";
            // 
            // label15
            // 
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Location = new System.Drawing.Point(190, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 23);
            this.label15.TabIndex = 18;
            this.label15.Text = "(pixel)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_EdgeWidth
            // 
            this.num_EdgeWidth.Location = new System.Drawing.Point(100, 179);
            this.num_EdgeWidth.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.num_EdgeWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_EdgeWidth.Name = "num_EdgeWidth";
            this.num_EdgeWidth.Size = new System.Drawing.Size(79, 23);
            this.num_EdgeWidth.TabIndex = 14;
            this.num_EdgeWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_EdgeWidth.ValueChanged += new System.EventHandler(this.num_EdgeWidth_ValueChanged);
            // 
            // num_PointNum
            // 
            this.num_PointNum.Location = new System.Drawing.Point(100, 139);
            this.num_PointNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_PointNum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_PointNum.Name = "num_PointNum";
            this.num_PointNum.Size = new System.Drawing.Size(79, 23);
            this.num_PointNum.TabIndex = 13;
            this.num_PointNum.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.num_PointNum.ValueChanged += new System.EventHandler(this.num_PointNum_ValueChanged);
            // 
            // num_EdgeThresold
            // 
            this.num_EdgeThresold.Location = new System.Drawing.Point(100, 99);
            this.num_EdgeThresold.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.num_EdgeThresold.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_EdgeThresold.Name = "num_EdgeThresold";
            this.num_EdgeThresold.Size = new System.Drawing.Size(79, 23);
            this.num_EdgeThresold.TabIndex = 12;
            this.num_EdgeThresold.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.num_EdgeThresold.ValueChanged += new System.EventHandler(this.num_EdgeThresold_ValueChanged);
            // 
            // cmb_EdgeType
            // 
            this.cmb_EdgeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_EdgeType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_EdgeType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_EdgeType.FormattingEnabled = true;
            this.cmb_EdgeType.Items.AddRange(new object[] {
            "第一条边缘",
            "最后一条边缘",
            "所有边缘"});
            this.cmb_EdgeType.Location = new System.Drawing.Point(81, 60);
            this.cmb_EdgeType.Name = "cmb_EdgeType";
            this.cmb_EdgeType.Size = new System.Drawing.Size(169, 25);
            this.cmb_EdgeType.TabIndex = 11;
            this.cmb_EdgeType.SelectedIndexChanged += new System.EventHandler(this.cmb_EdgeType_SelectedIndexChanged);
            // 
            // cmb_EdgePolar
            // 
            this.cmb_EdgePolar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_EdgePolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_EdgePolar.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_EdgePolar.FormattingEnabled = true;
            this.cmb_EdgePolar.Items.AddRange(new object[] {
            "从黑到白",
            "从白到黑",
            "所有"});
            this.cmb_EdgePolar.Location = new System.Drawing.Point(81, 20);
            this.cmb_EdgePolar.Name = "cmb_EdgePolar";
            this.cmb_EdgePolar.Size = new System.Drawing.Size(169, 25);
            this.cmb_EdgePolar.TabIndex = 10;
            this.cmb_EdgePolar.SelectedIndexChanged += new System.EventHandler(this.cmb_EdgePolar_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(6, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "边缘宽度：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(6, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "搜索点个数：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "边缘强度：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "边缘类型：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "边缘极性：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmFindLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1000, 537);
            this.Controls.Add(this.panel_Param);
            this.Controls.Add(this.panel_Image);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFindLine";
            this.Text = "直线检测";
            this.TitleVisiable = false;
            this.Load += new System.EventHandler(this.FrmFindLine_Load);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.panel_Image, 0);
            this.Controls.SetChildIndex(this.panel_Param, 0);
            this.panel_Image.ResumeLayout(false);
            this.panel_Param.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_EdgeWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PointNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EdgeThresold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Panel panel_Image;
        private UC_Image uC_Image;
        private System.Windows.Forms.Panel panel_Param;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_PointAngle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Point2Y;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Point1Y;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Point2X;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Point1X;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown num_EdgeWidth;
        private System.Windows.Forms.NumericUpDown num_PointNum;
        private System.Windows.Forms.NumericUpDown num_EdgeThresold;
        private System.Windows.Forms.ComboBox cmb_EdgeType;
        private System.Windows.Forms.ComboBox cmb_EdgePolar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}