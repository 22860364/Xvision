namespace DispenseAPP.Tools_Image_IO.AutoCalib
{
    partial class Tools_AutoCalib
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.tabControl_FindLine = new System.Windows.Forms.TabControl();
            this.tab_Basic = new System.Windows.Forms.TabPage();
            this.Btn_Set = new System.Windows.Forms.Button();
            this.Cmb_CalibProject = new System.Windows.Forms.ComboBox();
            this.Lbl_CalibProject = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.Lbl_BlockName = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cb_DispResult = new System.Windows.Forms.CheckBox();
            this.tabControl_FindLine.SuspendLayout();
            this.tab_Basic.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(250, 367);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(148, 369);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 28);
            this.btn_OK.TabIndex = 19;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
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
            this.tabControl_FindLine.Size = new System.Drawing.Size(328, 361);
            this.tabControl_FindLine.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_FindLine.TabIndex = 18;
            // 
            // tab_Basic
            // 
            this.tab_Basic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tab_Basic.Controls.Add(this.Btn_Set);
            this.tab_Basic.Controls.Add(this.Cmb_CalibProject);
            this.tab_Basic.Controls.Add(this.Lbl_CalibProject);
            this.tab_Basic.Controls.Add(this.txt_Name);
            this.tab_Basic.Controls.Add(this.Lbl_BlockName);
            this.tab_Basic.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab_Basic.Location = new System.Drawing.Point(4, 22);
            this.tab_Basic.Name = "tab_Basic";
            this.tab_Basic.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Basic.Size = new System.Drawing.Size(320, 335);
            this.tab_Basic.TabIndex = 0;
            this.tab_Basic.Text = "基本";
            // 
            // Btn_Set
            // 
            this.Btn_Set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Set.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Set.Location = new System.Drawing.Point(76, 105);
            this.Btn_Set.Name = "Btn_Set";
            this.Btn_Set.Size = new System.Drawing.Size(75, 28);
            this.Btn_Set.TabIndex = 20;
            this.Btn_Set.Text = "设置";
            this.Btn_Set.UseVisualStyleBackColor = true;
            this.Btn_Set.Click += new System.EventHandler(this.Btn_Set_Click);
            // 
            // Cmb_CalibProject
            // 
            this.Cmb_CalibProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_CalibProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_CalibProject.FormattingEnabled = true;
            this.Cmb_CalibProject.Items.AddRange(new object[] {
            "无"});
            this.Cmb_CalibProject.Location = new System.Drawing.Point(76, 57);
            this.Cmb_CalibProject.Name = "Cmb_CalibProject";
            this.Cmb_CalibProject.Size = new System.Drawing.Size(161, 25);
            this.Cmb_CalibProject.TabIndex = 12;
            // 
            // Lbl_CalibProject
            // 
            this.Lbl_CalibProject.Location = new System.Drawing.Point(7, 57);
            this.Lbl_CalibProject.Name = "Lbl_CalibProject";
            this.Lbl_CalibProject.Size = new System.Drawing.Size(63, 23);
            this.Lbl_CalibProject.TabIndex = 11;
            this.Lbl_CalibProject.Text = "标定方案";
            this.Lbl_CalibProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Name.Location = new System.Drawing.Point(75, 15);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(213, 24);
            this.txt_Name.TabIndex = 10;
            // 
            // Lbl_BlockName
            // 
            this.Lbl_BlockName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_BlockName.Location = new System.Drawing.Point(7, 15);
            this.Lbl_BlockName.Name = "Lbl_BlockName";
            this.Lbl_BlockName.Size = new System.Drawing.Size(61, 24);
            this.Lbl_BlockName.TabIndex = 9;
            this.Lbl_BlockName.Text = "算子名";
            this.Lbl_BlockName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.cb_DispResult);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(320, 335);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "输出";
            // 
            // cb_DispResult
            // 
            this.cb_DispResult.Checked = true;
            this.cb_DispResult.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_DispResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_DispResult.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_DispResult.Location = new System.Drawing.Point(22, 18);
            this.cb_DispResult.Name = "cb_DispResult";
            this.cb_DispResult.Size = new System.Drawing.Size(117, 24);
            this.cb_DispResult.TabIndex = 1;
            this.cb_DispResult.Text = " 显示结果";
            this.cb_DispResult.UseVisualStyleBackColor = true;
            // 
            // Tools_AutoCalib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tabControl_FindLine);
            this.Name = "Tools_AutoCalib";
            this.Size = new System.Drawing.Size(328, 398);
            this.tabControl_FindLine.ResumeLayout(false);
            this.tab_Basic.ResumeLayout(false);
            this.tab_Basic.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TabControl tabControl_FindLine;
        private System.Windows.Forms.TabPage tab_Basic;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label Lbl_BlockName;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cb_DispResult;
        private System.Windows.Forms.Button Btn_Set;
        private System.Windows.Forms.ComboBox Cmb_CalibProject;
        private System.Windows.Forms.Label Lbl_CalibProject;
    }
}
