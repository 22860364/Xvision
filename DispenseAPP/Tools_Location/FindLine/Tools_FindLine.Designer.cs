namespace DispenseAPP.Tools_Location
{
    partial class Tools_FindLine
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
            this.tabControl_FindLine = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel_Basic = new System.Windows.Forms.Panel();
            this.btn_Set = new System.Windows.Forms.Button();
            this.cmb_ReviseROI = new System.Windows.Forms.ComboBox();
            this.cmb_ROI = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_Limit = new System.Windows.Forms.TabPage();
            this.Panel_Limit = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_CurrentAngle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num_AngleRange = new System.Windows.Forms.NumericUpDown();
            this.num_StartAngle = new System.Windows.Forms.NumericUpDown();
            this.cb_AngleRange = new System.Windows.Forms.CheckBox();
            this.cb_StartAngle = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_HaveCalib = new System.Windows.Forms.RadioButton();
            this.rbtn_NoCalib = new System.Windows.Forms.RadioButton();
            this.tabPage_Output = new System.Windows.Forms.TabPage();
            this.cb_DispResult = new System.Windows.Forms.CheckBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.findLineClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl_FindLine.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel_Basic.SuspendLayout();
            this.tabPage_Limit.SuspendLayout();
            this.Panel_Limit.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_AngleRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_StartAngle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage_Output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findLineClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_FindLine
            // 
            this.tabControl_FindLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabControl_FindLine.Controls.Add(this.tabPage1);
            this.tabControl_FindLine.Controls.Add(this.tabPage_Limit);
            this.tabControl_FindLine.Controls.Add(this.tabPage_Output);
            this.tabControl_FindLine.ItemSize = new System.Drawing.Size(65, 18);
            this.tabControl_FindLine.Location = new System.Drawing.Point(0, 0);
            this.tabControl_FindLine.Multiline = true;
            this.tabControl_FindLine.Name = "tabControl_FindLine";
            this.tabControl_FindLine.SelectedIndex = 0;
            this.tabControl_FindLine.Size = new System.Drawing.Size(330, 363);
            this.tabControl_FindLine.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_FindLine.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel_Basic);
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(322, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel_Basic
            // 
            this.panel_Basic.AutoScroll = true;
            this.panel_Basic.AutoScrollMinSize = new System.Drawing.Size(0, 205);
            this.panel_Basic.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Basic.Controls.Add(this.btn_Set);
            this.panel_Basic.Controls.Add(this.cmb_ReviseROI);
            this.panel_Basic.Controls.Add(this.cmb_ROI);
            this.panel_Basic.Controls.Add(this.label3);
            this.panel_Basic.Controls.Add(this.label2);
            this.panel_Basic.Controls.Add(this.txt_Name);
            this.panel_Basic.Controls.Add(this.label1);
            this.panel_Basic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Basic.Location = new System.Drawing.Point(3, 3);
            this.panel_Basic.Name = "panel_Basic";
            this.panel_Basic.Size = new System.Drawing.Size(316, 331);
            this.panel_Basic.TabIndex = 0;
            // 
            // btn_Set
            // 
            this.btn_Set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Set.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Set.Location = new System.Drawing.Point(78, 152);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(75, 28);
            this.btn_Set.TabIndex = 8;
            this.btn_Set.Text = "设置";
            this.btn_Set.UseVisualStyleBackColor = true;
            this.btn_Set.Click += new System.EventHandler(this.btn_Set_Click);
            // 
            // cmb_ReviseROI
            // 
            this.cmb_ReviseROI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ReviseROI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_ReviseROI.FormattingEnabled = true;
            this.cmb_ReviseROI.Items.AddRange(new object[] {
            "不使用"});
            this.cmb_ReviseROI.Location = new System.Drawing.Point(78, 103);
            this.cmb_ReviseROI.Name = "cmb_ReviseROI";
            this.cmb_ReviseROI.Size = new System.Drawing.Size(161, 25);
            this.cmb_ReviseROI.TabIndex = 7;
            // 
            // cmb_ROI
            // 
            this.cmb_ROI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ROI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_ROI.FormattingEnabled = true;
            this.cmb_ROI.Items.AddRange(new object[] {
            "常量"});
            this.cmb_ROI.Location = new System.Drawing.Point(78, 60);
            this.cmb_ROI.Name = "cmb_ROI";
            this.cmb_ROI.Size = new System.Drawing.Size(161, 25);
            this.cmb_ROI.TabIndex = 6;
            this.cmb_ROI.SelectedIndexChanged += new System.EventHandler(this.cmb_ROI_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "ROI校正：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "ROI：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Name.Location = new System.Drawing.Point(63, 19);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(213, 23);
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
            // tabPage_Limit
            // 
            this.tabPage_Limit.Controls.Add(this.Panel_Limit);
            this.tabPage_Limit.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Limit.Name = "tabPage_Limit";
            this.tabPage_Limit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Limit.Size = new System.Drawing.Size(322, 337);
            this.tabPage_Limit.TabIndex = 1;
            this.tabPage_Limit.Text = "限制";
            this.tabPage_Limit.UseVisualStyleBackColor = true;
            // 
            // Panel_Limit
            // 
            this.Panel_Limit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Panel_Limit.AutoScroll = true;
            this.Panel_Limit.AutoScrollMinSize = new System.Drawing.Size(0, 260);
            this.Panel_Limit.BackColor = System.Drawing.SystemColors.Control;
            this.Panel_Limit.Controls.Add(this.groupBox2);
            this.Panel_Limit.Controls.Add(this.groupBox1);
            this.Panel_Limit.Location = new System.Drawing.Point(4, 3);
            this.Panel_Limit.Name = "Panel_Limit";
            this.Panel_Limit.Size = new System.Drawing.Size(314, 331);
            this.Panel_Limit.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_CurrentAngle);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.num_AngleRange);
            this.groupBox2.Controls.Add(this.num_StartAngle);
            this.groupBox2.Controls.Add(this.cb_AngleRange);
            this.groupBox2.Controls.Add(this.cb_StartAngle);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(16, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "角度";
            // 
            // lbl_CurrentAngle
            // 
            this.lbl_CurrentAngle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_CurrentAngle.Location = new System.Drawing.Point(119, 110);
            this.lbl_CurrentAngle.Name = "lbl_CurrentAngle";
            this.lbl_CurrentAngle.Size = new System.Drawing.Size(137, 27);
            this.lbl_CurrentAngle.TabIndex = 5;
            this.lbl_CurrentAngle.Text = "Null";
            this.lbl_CurrentAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "当前角度：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_AngleRange
            // 
            this.num_AngleRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_AngleRange.Enabled = false;
            this.num_AngleRange.Location = new System.Drawing.Point(119, 68);
            this.num_AngleRange.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_AngleRange.Name = "num_AngleRange";
            this.num_AngleRange.Size = new System.Drawing.Size(137, 23);
            this.num_AngleRange.TabIndex = 3;
            // 
            // num_StartAngle
            // 
            this.num_StartAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_StartAngle.Enabled = false;
            this.num_StartAngle.Location = new System.Drawing.Point(119, 32);
            this.num_StartAngle.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_StartAngle.Name = "num_StartAngle";
            this.num_StartAngle.Size = new System.Drawing.Size(137, 23);
            this.num_StartAngle.TabIndex = 2;
            // 
            // cb_AngleRange
            // 
            this.cb_AngleRange.AutoSize = true;
            this.cb_AngleRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_AngleRange.Location = new System.Drawing.Point(16, 71);
            this.cb_AngleRange.Name = "cb_AngleRange";
            this.cb_AngleRange.Size = new System.Drawing.Size(72, 21);
            this.cb_AngleRange.TabIndex = 1;
            this.cb_AngleRange.Text = "角度范围";
            this.cb_AngleRange.UseVisualStyleBackColor = true;
            this.cb_AngleRange.CheckedChanged += new System.EventHandler(this.cb_EndAngle_CheckedChanged);
            // 
            // cb_StartAngle
            // 
            this.cb_StartAngle.AutoSize = true;
            this.cb_StartAngle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_StartAngle.Location = new System.Drawing.Point(16, 32);
            this.cb_StartAngle.Name = "cb_StartAngle";
            this.cb_StartAngle.Size = new System.Drawing.Size(72, 21);
            this.cb_StartAngle.TabIndex = 0;
            this.cb_StartAngle.Text = "起始角度";
            this.cb_StartAngle.UseVisualStyleBackColor = true;
            this.cb_StartAngle.CheckedChanged += new System.EventHandler(this.cb_StartAngle_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_HaveCalib);
            this.groupBox1.Controls.Add(this.rbtn_NoCalib);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "结果类型";
            // 
            // rbtn_HaveCalib
            // 
            this.rbtn_HaveCalib.AutoSize = true;
            this.rbtn_HaveCalib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_HaveCalib.Location = new System.Drawing.Point(178, 22);
            this.rbtn_HaveCalib.Name = "rbtn_HaveCalib";
            this.rbtn_HaveCalib.Size = new System.Drawing.Size(61, 21);
            this.rbtn_HaveCalib.TabIndex = 1;
            this.rbtn_HaveCalib.TabStop = true;
            this.rbtn_HaveCalib.Text = "已标定";
            this.rbtn_HaveCalib.UseVisualStyleBackColor = true;
            // 
            // rbtn_NoCalib
            // 
            this.rbtn_NoCalib.AutoSize = true;
            this.rbtn_NoCalib.Checked = true;
            this.rbtn_NoCalib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_NoCalib.Location = new System.Drawing.Point(16, 22);
            this.rbtn_NoCalib.Name = "rbtn_NoCalib";
            this.rbtn_NoCalib.Size = new System.Drawing.Size(61, 21);
            this.rbtn_NoCalib.TabIndex = 0;
            this.rbtn_NoCalib.TabStop = true;
            this.rbtn_NoCalib.Text = "未标定";
            this.rbtn_NoCalib.UseVisualStyleBackColor = true;
            // 
            // tabPage_Output
            // 
            this.tabPage_Output.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Output.Controls.Add(this.cb_DispResult);
            this.tabPage_Output.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Output.Name = "tabPage_Output";
            this.tabPage_Output.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Output.Size = new System.Drawing.Size(322, 337);
            this.tabPage_Output.TabIndex = 2;
            this.tabPage_Output.Text = "输出";
            // 
            // cb_DispResult
            // 
            this.cb_DispResult.Checked = true;
            this.cb_DispResult.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_DispResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_DispResult.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_DispResult.Location = new System.Drawing.Point(15, 16);
            this.cb_DispResult.Name = "cb_DispResult";
            this.cb_DispResult.Size = new System.Drawing.Size(117, 24);
            this.cb_DispResult.TabIndex = 0;
            this.cb_DispResult.Text = " 显示结果";
            this.cb_DispResult.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(167, 369);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 28);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(248, 369);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Tools_FindLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tabControl_FindLine);
            this.Name = "Tools_FindLine";
            this.Size = new System.Drawing.Size(330, 400);
            this.tabControl_FindLine.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel_Basic.ResumeLayout(false);
            this.panel_Basic.PerformLayout();
            this.tabPage_Limit.ResumeLayout(false);
            this.Panel_Limit.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_AngleRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_StartAngle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_Output.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.findLineClassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_FindLine;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage_Limit;
        private System.Windows.Forms.Panel panel_Basic;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_ReviseROI;
        private System.Windows.Forms.ComboBox cmb_ROI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Set;
        private System.Windows.Forms.TabPage tabPage_Output;
        private System.Windows.Forms.CheckBox cb_DispResult;
        private System.Windows.Forms.Panel Panel_Limit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_HaveCalib;
        private System.Windows.Forms.RadioButton rbtn_NoCalib;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown num_AngleRange;
        private System.Windows.Forms.NumericUpDown num_StartAngle;
        private System.Windows.Forms.CheckBox cb_AngleRange;
        private System.Windows.Forms.CheckBox cb_StartAngle;
        private System.Windows.Forms.Label lbl_CurrentAngle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource findLineClassBindingSource;
    }
}
