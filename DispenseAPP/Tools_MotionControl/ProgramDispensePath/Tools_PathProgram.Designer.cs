namespace DispenseAPP.Tools_MotionControl.ProgrammingDispensePath
{
    partial class Tools_PathProgramming
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
            this.TC_PathProgram = new System.Windows.Forms.TabControl();
            this.tab_Basic = new System.Windows.Forms.TabPage();
            this.Panel_Basic = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_MeasureHeightData = new System.Windows.Forms.ComboBox();
            this.Cmb_VisionData = new System.Windows.Forms.ComboBox();
            this.Btn_Set = new System.Windows.Forms.Button();
            this.lbl_BlockName = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.tab_Params = new System.Windows.Forms.TabPage();
            this.Panel_AxisParam = new System.Windows.Forms.Panel();
            this.Cmb_SelectCard = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_ReferenceAxis = new System.Windows.Forms.GroupBox();
            this.Cmb_AxisZ = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cmb_AxisY = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmb_AxisX = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TC_PathProgram.SuspendLayout();
            this.tab_Basic.SuspendLayout();
            this.Panel_Basic.SuspendLayout();
            this.tab_Params.SuspendLayout();
            this.Panel_AxisParam.SuspendLayout();
            this.gb_ReferenceAxis.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(250, 367);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.Btn_Cancel.TabIndex = 23;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(169, 367);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 28);
            this.Btn_OK.TabIndex = 22;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // TC_PathProgram
            // 
            this.TC_PathProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TC_PathProgram.Controls.Add(this.tab_Basic);
            this.TC_PathProgram.Controls.Add(this.tab_Params);
            this.TC_PathProgram.ItemSize = new System.Drawing.Size(65, 18);
            this.TC_PathProgram.Location = new System.Drawing.Point(0, 2);
            this.TC_PathProgram.Multiline = true;
            this.TC_PathProgram.Name = "TC_PathProgram";
            this.TC_PathProgram.SelectedIndex = 0;
            this.TC_PathProgram.Size = new System.Drawing.Size(328, 361);
            this.TC_PathProgram.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TC_PathProgram.TabIndex = 21;
            // 
            // tab_Basic
            // 
            this.tab_Basic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tab_Basic.Controls.Add(this.Panel_Basic);
            this.tab_Basic.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab_Basic.Location = new System.Drawing.Point(4, 22);
            this.tab_Basic.Name = "tab_Basic";
            this.tab_Basic.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Basic.Size = new System.Drawing.Size(320, 335);
            this.tab_Basic.TabIndex = 0;
            this.tab_Basic.Text = "基本";
            // 
            // Panel_Basic
            // 
            this.Panel_Basic.AutoScroll = true;
            this.Panel_Basic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Panel_Basic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Basic.Controls.Add(this.label6);
            this.Panel_Basic.Controls.Add(this.label2);
            this.Panel_Basic.Controls.Add(this.Cmb_MeasureHeightData);
            this.Panel_Basic.Controls.Add(this.Cmb_VisionData);
            this.Panel_Basic.Controls.Add(this.Btn_Set);
            this.Panel_Basic.Controls.Add(this.lbl_BlockName);
            this.Panel_Basic.Controls.Add(this.txt_Name);
            this.Panel_Basic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Basic.Location = new System.Drawing.Point(3, 3);
            this.Panel_Basic.Name = "Panel_Basic";
            this.Panel_Basic.Size = new System.Drawing.Size(314, 329);
            this.Panel_Basic.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(10, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "测高数据";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "视觉数据";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cmb_MeasureHeightData
            // 
            this.Cmb_MeasureHeightData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_MeasureHeightData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_MeasureHeightData.FormattingEnabled = true;
            this.Cmb_MeasureHeightData.Location = new System.Drawing.Point(75, 87);
            this.Cmb_MeasureHeightData.Name = "Cmb_MeasureHeightData";
            this.Cmb_MeasureHeightData.Size = new System.Drawing.Size(151, 25);
            this.Cmb_MeasureHeightData.TabIndex = 24;
            // 
            // Cmb_VisionData
            // 
            this.Cmb_VisionData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_VisionData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_VisionData.FormattingEnabled = true;
            this.Cmb_VisionData.Location = new System.Drawing.Point(75, 51);
            this.Cmb_VisionData.Name = "Cmb_VisionData";
            this.Cmb_VisionData.Size = new System.Drawing.Size(151, 25);
            this.Cmb_VisionData.TabIndex = 23;
            // 
            // Btn_Set
            // 
            this.Btn_Set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Set.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Set.Location = new System.Drawing.Point(75, 133);
            this.Btn_Set.Name = "Btn_Set";
            this.Btn_Set.Size = new System.Drawing.Size(68, 28);
            this.Btn_Set.TabIndex = 20;
            this.Btn_Set.Text = "设置";
            this.Btn_Set.UseVisualStyleBackColor = true;
            this.Btn_Set.Click += new System.EventHandler(this.Btn_Set_Click);
            // 
            // lbl_BlockName
            // 
            this.lbl_BlockName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_BlockName.Location = new System.Drawing.Point(10, 15);
            this.lbl_BlockName.Name = "lbl_BlockName";
            this.lbl_BlockName.Size = new System.Drawing.Size(44, 24);
            this.lbl_BlockName.TabIndex = 9;
            this.lbl_BlockName.Text = "算子名";
            this.lbl_BlockName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Name.Location = new System.Drawing.Point(75, 15);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(196, 24);
            this.txt_Name.TabIndex = 10;
            // 
            // tab_Params
            // 
            this.tab_Params.Controls.Add(this.Panel_AxisParam);
            this.tab_Params.Location = new System.Drawing.Point(4, 22);
            this.tab_Params.Name = "tab_Params";
            this.tab_Params.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Params.Size = new System.Drawing.Size(320, 335);
            this.tab_Params.TabIndex = 1;
            this.tab_Params.Text = "轴参数";
            // 
            // Panel_AxisParam
            // 
            this.Panel_AxisParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Panel_AxisParam.Controls.Add(this.Cmb_SelectCard);
            this.Panel_AxisParam.Controls.Add(this.label1);
            this.Panel_AxisParam.Controls.Add(this.gb_ReferenceAxis);
            this.Panel_AxisParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_AxisParam.Location = new System.Drawing.Point(3, 3);
            this.Panel_AxisParam.Name = "Panel_AxisParam";
            this.Panel_AxisParam.Size = new System.Drawing.Size(314, 329);
            this.Panel_AxisParam.TabIndex = 0;
            // 
            // Cmb_SelectCard
            // 
            this.Cmb_SelectCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_SelectCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_SelectCard.FormattingEnabled = true;
            this.Cmb_SelectCard.Location = new System.Drawing.Point(79, 10);
            this.Cmb_SelectCard.Name = "Cmb_SelectCard";
            this.Cmb_SelectCard.Size = new System.Drawing.Size(166, 25);
            this.Cmb_SelectCard.TabIndex = 11;
            this.Cmb_SelectCard.SelectedIndexChanged += new System.EventHandler(this.Cmb_SelectCard_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "选择卡：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gb_ReferenceAxis
            // 
            this.gb_ReferenceAxis.Controls.Add(this.Cmb_AxisZ);
            this.gb_ReferenceAxis.Controls.Add(this.label5);
            this.gb_ReferenceAxis.Controls.Add(this.Cmb_AxisY);
            this.gb_ReferenceAxis.Controls.Add(this.label4);
            this.gb_ReferenceAxis.Controls.Add(this.Cmb_AxisX);
            this.gb_ReferenceAxis.Controls.Add(this.label3);
            this.gb_ReferenceAxis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_ReferenceAxis.Location = new System.Drawing.Point(10, 41);
            this.gb_ReferenceAxis.Name = "gb_ReferenceAxis";
            this.gb_ReferenceAxis.Size = new System.Drawing.Size(235, 124);
            this.gb_ReferenceAxis.TabIndex = 0;
            this.gb_ReferenceAxis.TabStop = false;
            this.gb_ReferenceAxis.Text = "引用轴";
            // 
            // Cmb_AxisZ
            // 
            this.Cmb_AxisZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_AxisZ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_AxisZ.FormattingEnabled = true;
            this.Cmb_AxisZ.Location = new System.Drawing.Point(55, 89);
            this.Cmb_AxisZ.Name = "Cmb_AxisZ";
            this.Cmb_AxisZ.Size = new System.Drawing.Size(166, 25);
            this.Cmb_AxisZ.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Z轴：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cmb_AxisY
            // 
            this.Cmb_AxisY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_AxisY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_AxisY.FormattingEnabled = true;
            this.Cmb_AxisY.Location = new System.Drawing.Point(55, 54);
            this.Cmb_AxisY.Name = "Cmb_AxisY";
            this.Cmb_AxisY.Size = new System.Drawing.Size(166, 25);
            this.Cmb_AxisY.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Y轴：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cmb_AxisX
            // 
            this.Cmb_AxisX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_AxisX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_AxisX.FormattingEnabled = true;
            this.Cmb_AxisX.Location = new System.Drawing.Point(55, 19);
            this.Cmb_AxisX.Name = "Cmb_AxisX";
            this.Cmb_AxisX.Size = new System.Drawing.Size(166, 25);
            this.Cmb_AxisX.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "X轴：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tools_PathProgramming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.TC_PathProgram);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Tools_PathProgramming";
            this.Size = new System.Drawing.Size(328, 398);
            this.TC_PathProgram.ResumeLayout(false);
            this.tab_Basic.ResumeLayout(false);
            this.Panel_Basic.ResumeLayout(false);
            this.Panel_Basic.PerformLayout();
            this.tab_Params.ResumeLayout(false);
            this.Panel_AxisParam.ResumeLayout(false);
            this.gb_ReferenceAxis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.TabControl TC_PathProgram;
        private System.Windows.Forms.TabPage tab_Basic;
        private System.Windows.Forms.Panel Panel_Basic;
        private System.Windows.Forms.Button Btn_Set;
        private System.Windows.Forms.Label lbl_BlockName;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TabPage tab_Params;
        private System.Windows.Forms.Panel Panel_AxisParam;
        private System.Windows.Forms.GroupBox gb_ReferenceAxis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_SelectCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cmb_AxisX;
        private System.Windows.Forms.ComboBox Cmb_AxisZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cmb_AxisY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cmb_MeasureHeightData;
        private System.Windows.Forms.ComboBox Cmb_VisionData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
    }
}
