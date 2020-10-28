namespace DispenseAPP.Tools_Location.CreateROI
{
    partial class Tools_CreateROI
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
            this.tabPage_Base = new System.Windows.Forms.TabPage();
            this.panel_Basic = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_ReviseROI = new System.Windows.Forms.ComboBox();
            this.btn_Set = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_Output = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_DispResult = new System.Windows.Forms.CheckBox();
            this.tabControl_FindLine.SuspendLayout();
            this.tabPage_Base.SuspendLayout();
            this.panel_Basic.SuspendLayout();
            this.tabPage_Output.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(222, 371);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.btn_Cancel.TabIndex = 17;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(127, 371);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 28);
            this.btn_OK.TabIndex = 16;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // tabControl_FindLine
            // 
            this.tabControl_FindLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabControl_FindLine.Controls.Add(this.tabPage_Base);
            this.tabControl_FindLine.Controls.Add(this.tabPage_Output);
            this.tabControl_FindLine.ItemSize = new System.Drawing.Size(65, 18);
            this.tabControl_FindLine.Location = new System.Drawing.Point(0, 1);
            this.tabControl_FindLine.Multiline = true;
            this.tabControl_FindLine.Name = "tabControl_FindLine";
            this.tabControl_FindLine.SelectedIndex = 0;
            this.tabControl_FindLine.Size = new System.Drawing.Size(330, 364);
            this.tabControl_FindLine.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_FindLine.TabIndex = 15;
            // 
            // tabPage_Base
            // 
            this.tabPage_Base.Controls.Add(this.panel_Basic);
            this.tabPage_Base.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage_Base.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Base.Name = "tabPage_Base";
            this.tabPage_Base.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Base.Size = new System.Drawing.Size(322, 338);
            this.tabPage_Base.TabIndex = 0;
            this.tabPage_Base.Text = "基本";
            this.tabPage_Base.UseVisualStyleBackColor = true;
            // 
            // panel_Basic
            // 
            this.panel_Basic.AutoScroll = true;
            this.panel_Basic.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Basic.Controls.Add(this.label2);
            this.panel_Basic.Controls.Add(this.cmb_ReviseROI);
            this.panel_Basic.Controls.Add(this.btn_Set);
            this.panel_Basic.Controls.Add(this.txt_Name);
            this.panel_Basic.Controls.Add(this.label1);
            this.panel_Basic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Basic.Location = new System.Drawing.Point(3, 3);
            this.panel_Basic.Name = "panel_Basic";
            this.panel_Basic.Size = new System.Drawing.Size(316, 332);
            this.panel_Basic.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "ROI校正：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_ReviseROI
            // 
            this.cmb_ReviseROI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ReviseROI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_ReviseROI.FormattingEnabled = true;
            this.cmb_ReviseROI.Items.AddRange(new object[] {
            "不使用"});
            this.cmb_ReviseROI.Location = new System.Drawing.Point(76, 63);
            this.cmb_ReviseROI.Name = "cmb_ReviseROI";
            this.cmb_ReviseROI.Size = new System.Drawing.Size(202, 25);
            this.cmb_ReviseROI.TabIndex = 16;
            // 
            // btn_Set
            // 
            this.btn_Set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Set.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Set.Location = new System.Drawing.Point(76, 117);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(67, 28);
            this.btn_Set.TabIndex = 15;
            this.btn_Set.Text = "设置";
            this.btn_Set.UseVisualStyleBackColor = true;
            this.btn_Set.Click += new System.EventHandler(this.btn_Set_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Name.Location = new System.Drawing.Point(76, 19);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(202, 23);
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
            // tabPage_Output
            // 
            this.tabPage_Output.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Output.Controls.Add(this.panel1);
            this.tabPage_Output.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Output.Name = "tabPage_Output";
            this.tabPage_Output.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Output.Size = new System.Drawing.Size(322, 338);
            this.tabPage_Output.TabIndex = 2;
            this.tabPage_Output.Text = "输出";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.cb_DispResult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 332);
            this.panel1.TabIndex = 0;
            // 
            // cb_DispResult
            // 
            this.cb_DispResult.Checked = true;
            this.cb_DispResult.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_DispResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_DispResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_DispResult.Location = new System.Drawing.Point(13, 14);
            this.cb_DispResult.Name = "cb_DispResult";
            this.cb_DispResult.Size = new System.Drawing.Size(128, 24);
            this.cb_DispResult.TabIndex = 2;
            this.cb_DispResult.Text = "显示结果";
            this.cb_DispResult.UseVisualStyleBackColor = true;
            // 
            // Tools_CreateROI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tabControl_FindLine);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Tools_CreateROI";
            this.Size = new System.Drawing.Size(330, 400);
            this.tabControl_FindLine.ResumeLayout(false);
            this.tabPage_Base.ResumeLayout(false);
            this.panel_Basic.ResumeLayout(false);
            this.panel_Basic.PerformLayout();
            this.tabPage_Output.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TabControl tabControl_FindLine;
        private System.Windows.Forms.TabPage tabPage_Base;
        private System.Windows.Forms.Panel panel_Basic;
        private System.Windows.Forms.Button btn_Set;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_Output;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_DispResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_ReviseROI;
    }
}
