namespace DispenseAPP.Tools_Image_IO.ExportImage
{
    partial class Tools_ExportImage
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
            this.Panel_Basic = new System.Windows.Forms.Panel();
            this.uC_Save1 = new DispenseAPP.Tools_MotionControl.MeasureHeight.UC_Save();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_Advanced = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.num_MaxNum = new System.Windows.Forms.NumericUpDown();
            this.lbl_MaxNum = new System.Windows.Forms.Label();
            this.cmb_Format = new System.Windows.Forms.ComboBox();
            this.lbl_Format = new System.Windows.Forms.Label();
            this.cmb_ImageSource = new System.Windows.Forms.ComboBox();
            this.lbl_ImageSource = new System.Windows.Forms.Label();
            this.cmb_Result = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_MeasureValue = new System.Windows.Forms.ComboBox();
            this.cb_SaveWhen = new System.Windows.Forms.CheckBox();
            this.tabControl_FindLine.SuspendLayout();
            this.tabPage_Base.SuspendLayout();
            this.Panel_Basic.SuspendLayout();
            this.tabPage_Advanced.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_MaxNum)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(263, 369);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(62, 28);
            this.Btn_Cancel.TabIndex = 11;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(188, 369);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(62, 28);
            this.Btn_OK.TabIndex = 10;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // tabControl_FindLine
            // 
            this.tabControl_FindLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabControl_FindLine.Controls.Add(this.tabPage_Base);
            this.tabControl_FindLine.Controls.Add(this.tabPage_Advanced);
            this.tabControl_FindLine.ItemSize = new System.Drawing.Size(65, 18);
            this.tabControl_FindLine.Location = new System.Drawing.Point(-1, 0);
            this.tabControl_FindLine.Multiline = true;
            this.tabControl_FindLine.Name = "tabControl_FindLine";
            this.tabControl_FindLine.SelectedIndex = 0;
            this.tabControl_FindLine.Size = new System.Drawing.Size(330, 361);
            this.tabControl_FindLine.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_FindLine.TabIndex = 9;
            // 
            // tabPage_Base
            // 
            this.tabPage_Base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage_Base.Controls.Add(this.Panel_Basic);
            this.tabPage_Base.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage_Base.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Base.Name = "tabPage_Base";
            this.tabPage_Base.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Base.Size = new System.Drawing.Size(322, 335);
            this.tabPage_Base.TabIndex = 0;
            this.tabPage_Base.Text = "基本";
            // 
            // Panel_Basic
            // 
            this.Panel_Basic.AutoScroll = true;
            this.Panel_Basic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Panel_Basic.Controls.Add(this.uC_Save1);
            this.Panel_Basic.Controls.Add(this.txt_Name);
            this.Panel_Basic.Controls.Add(this.label1);
            this.Panel_Basic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Basic.Location = new System.Drawing.Point(3, 3);
            this.Panel_Basic.Name = "Panel_Basic";
            this.Panel_Basic.Size = new System.Drawing.Size(316, 329);
            this.Panel_Basic.TabIndex = 0;
            // 
            // uC_Save1
            // 
            this.uC_Save1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.uC_Save1.Location = new System.Drawing.Point(13, 39);
            this.uC_Save1.Name = "uC_Save1";
            this.uC_Save1.Size = new System.Drawing.Size(276, 228);
            this.uC_Save1.TabIndex = 4;
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Name.Location = new System.Drawing.Point(66, 10);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(202, 23);
            this.txt_Name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "算子名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage_Advanced
            // 
            this.tabPage_Advanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage_Advanced.Controls.Add(this.panel1);
            this.tabPage_Advanced.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Advanced.Name = "tabPage_Advanced";
            this.tabPage_Advanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Advanced.Size = new System.Drawing.Size(322, 335);
            this.tabPage_Advanced.TabIndex = 2;
            this.tabPage_Advanced.Text = "高级";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.num_MaxNum);
            this.panel1.Controls.Add(this.lbl_MaxNum);
            this.panel1.Controls.Add(this.cmb_Format);
            this.panel1.Controls.Add(this.lbl_Format);
            this.panel1.Controls.Add(this.cmb_ImageSource);
            this.panel1.Controls.Add(this.lbl_ImageSource);
            this.panel1.Controls.Add(this.cmb_Result);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_MeasureValue);
            this.panel1.Controls.Add(this.cb_SaveWhen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 329);
            this.panel1.TabIndex = 0;
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox2.Location = new System.Drawing.Point(13, 223);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(90, 24);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "启用缓存区";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // num_MaxNum
            // 
            this.num_MaxNum.Location = new System.Drawing.Point(99, 179);
            this.num_MaxNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_MaxNum.Name = "num_MaxNum";
            this.num_MaxNum.Size = new System.Drawing.Size(120, 23);
            this.num_MaxNum.TabIndex = 11;
            // 
            // lbl_MaxNum
            // 
            this.lbl_MaxNum.Location = new System.Drawing.Point(10, 178);
            this.lbl_MaxNum.Name = "lbl_MaxNum";
            this.lbl_MaxNum.Size = new System.Drawing.Size(83, 23);
            this.lbl_MaxNum.TabIndex = 10;
            this.lbl_MaxNum.Text = "最大数目：";
            this.lbl_MaxNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Format
            // 
            this.cmb_Format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Format.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Format.FormattingEnabled = true;
            this.cmb_Format.Items.AddRange(new object[] {
            "BMP",
            "JPG",
            "PNG",
            "TIF"});
            this.cmb_Format.Location = new System.Drawing.Point(99, 135);
            this.cmb_Format.Name = "cmb_Format";
            this.cmb_Format.Size = new System.Drawing.Size(115, 25);
            this.cmb_Format.TabIndex = 9;
            // 
            // lbl_Format
            // 
            this.lbl_Format.Location = new System.Drawing.Point(10, 135);
            this.lbl_Format.Name = "lbl_Format";
            this.lbl_Format.Size = new System.Drawing.Size(57, 23);
            this.lbl_Format.TabIndex = 8;
            this.lbl_Format.Text = "格式：";
            this.lbl_Format.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_ImageSource
            // 
            this.cmb_ImageSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ImageSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_ImageSource.FormattingEnabled = true;
            this.cmb_ImageSource.Items.AddRange(new object[] {
            "原图",
            "窗口"});
            this.cmb_ImageSource.Location = new System.Drawing.Point(99, 89);
            this.cmb_ImageSource.Name = "cmb_ImageSource";
            this.cmb_ImageSource.Size = new System.Drawing.Size(115, 25);
            this.cmb_ImageSource.TabIndex = 7;
            // 
            // lbl_ImageSource
            // 
            this.lbl_ImageSource.Location = new System.Drawing.Point(10, 89);
            this.lbl_ImageSource.Name = "lbl_ImageSource";
            this.lbl_ImageSource.Size = new System.Drawing.Size(57, 23);
            this.lbl_ImageSource.TabIndex = 6;
            this.lbl_ImageSource.Text = "图像源：";
            this.lbl_ImageSource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Result
            // 
            this.cmb_Result.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Result.FormattingEnabled = true;
            this.cmb_Result.Items.AddRange(new object[] {
            "Invaild",
            "True",
            "False"});
            this.cmb_Result.Location = new System.Drawing.Point(220, 44);
            this.cmb_Result.Name = "cmb_Result";
            this.cmb_Result.Size = new System.Drawing.Size(68, 25);
            this.cmb_Result.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(194, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_MeasureValue
            // 
            this.cmb_MeasureValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MeasureValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_MeasureValue.FormattingEnabled = true;
            this.cmb_MeasureValue.Location = new System.Drawing.Point(13, 44);
            this.cmb_MeasureValue.Name = "cmb_MeasureValue";
            this.cmb_MeasureValue.Size = new System.Drawing.Size(175, 25);
            this.cmb_MeasureValue.TabIndex = 3;
            // 
            // cb_SaveWhen
            // 
            this.cb_SaveWhen.Checked = true;
            this.cb_SaveWhen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_SaveWhen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_SaveWhen.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_SaveWhen.Location = new System.Drawing.Point(13, 14);
            this.cb_SaveWhen.Name = "cb_SaveWhen";
            this.cb_SaveWhen.Size = new System.Drawing.Size(69, 24);
            this.cb_SaveWhen.TabIndex = 2;
            this.cb_SaveWhen.Text = "保存当";
            this.cb_SaveWhen.UseVisualStyleBackColor = true;
            // 
            // Tools_ExportImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.tabControl_FindLine);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Tools_ExportImage";
            this.Size = new System.Drawing.Size(328, 398);
            this.tabControl_FindLine.ResumeLayout(false);
            this.tabPage_Base.ResumeLayout(false);
            this.Panel_Basic.ResumeLayout(false);
            this.Panel_Basic.PerformLayout();
            this.tabPage_Advanced.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_MaxNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.TabControl tabControl_FindLine;
        private System.Windows.Forms.TabPage tabPage_Base;
        private System.Windows.Forms.TabPage tabPage_Advanced;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_SaveWhen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_MeasureValue;
        private System.Windows.Forms.ComboBox cmb_Result;
        private System.Windows.Forms.ComboBox cmb_Format;
        private System.Windows.Forms.Label lbl_Format;
        private System.Windows.Forms.ComboBox cmb_ImageSource;
        private System.Windows.Forms.Label lbl_ImageSource;
        private System.Windows.Forms.NumericUpDown num_MaxNum;
        private System.Windows.Forms.Label lbl_MaxNum;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel Panel_Basic;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private Tools_MotionControl.MeasureHeight.UC_Save uC_Save1;
    }
}
