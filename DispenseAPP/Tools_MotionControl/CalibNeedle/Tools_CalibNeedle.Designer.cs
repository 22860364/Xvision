namespace DispenseAPP.Tools_MotionControl.CalibNeedle
{
    partial class Tools_CalibNeedle
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
            this.Panel_Basic = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_BlockName = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.tab_Params = new System.Windows.Forms.TabPage();
            this.Panel_Param = new System.Windows.Forms.Panel();
            this.gb_ReferenceAxis = new System.Windows.Forms.GroupBox();
            this.clb_ReferenceAxis = new System.Windows.Forms.CheckedListBox();
            this.tabControl_FindLine.SuspendLayout();
            this.tab_Basic.SuspendLayout();
            this.Panel_Basic.SuspendLayout();
            this.tab_Params.SuspendLayout();
            this.Panel_Param.SuspendLayout();
            this.gb_ReferenceAxis.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(223, 371);
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
            this.btn_OK.Location = new System.Drawing.Point(125, 371);
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
            this.tabControl_FindLine.Controls.Add(this.tab_Params);
            this.tabControl_FindLine.ItemSize = new System.Drawing.Size(65, 18);
            this.tabControl_FindLine.Location = new System.Drawing.Point(0, 2);
            this.tabControl_FindLine.Multiline = true;
            this.tabControl_FindLine.Name = "tabControl_FindLine";
            this.tabControl_FindLine.SelectedIndex = 0;
            this.tabControl_FindLine.Size = new System.Drawing.Size(330, 363);
            this.tabControl_FindLine.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_FindLine.TabIndex = 18;
            // 
            // tab_Basic
            // 
            this.tab_Basic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tab_Basic.Controls.Add(this.Panel_Basic);
            this.tab_Basic.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab_Basic.Location = new System.Drawing.Point(4, 22);
            this.tab_Basic.Name = "tab_Basic";
            this.tab_Basic.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Basic.Size = new System.Drawing.Size(322, 337);
            this.tab_Basic.TabIndex = 0;
            this.tab_Basic.Text = "基本";
            // 
            // Panel_Basic
            // 
            this.Panel_Basic.AutoScroll = true;
            this.Panel_Basic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Panel_Basic.Controls.Add(this.button1);
            this.Panel_Basic.Controls.Add(this.lbl_BlockName);
            this.Panel_Basic.Controls.Add(this.txt_Name);
            this.Panel_Basic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Basic.Location = new System.Drawing.Point(3, 3);
            this.Panel_Basic.Name = "Panel_Basic";
            this.Panel_Basic.Size = new System.Drawing.Size(316, 331);
            this.Panel_Basic.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(91, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "设置";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_BlockName
            // 
            this.lbl_BlockName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_BlockName.Location = new System.Drawing.Point(14, 10);
            this.lbl_BlockName.Name = "lbl_BlockName";
            this.lbl_BlockName.Size = new System.Drawing.Size(71, 24);
            this.lbl_BlockName.TabIndex = 9;
            this.lbl_BlockName.Text = "算子名：";
            this.lbl_BlockName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Name.Location = new System.Drawing.Point(91, 10);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(213, 24);
            this.txt_Name.TabIndex = 10;
            // 
            // tab_Params
            // 
            this.tab_Params.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tab_Params.Controls.Add(this.Panel_Param);
            this.tab_Params.Location = new System.Drawing.Point(4, 22);
            this.tab_Params.Name = "tab_Params";
            this.tab_Params.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Params.Size = new System.Drawing.Size(322, 337);
            this.tab_Params.TabIndex = 1;
            this.tab_Params.Text = "参数";
            // 
            // Panel_Param
            // 
            this.Panel_Param.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Panel_Param.Controls.Add(this.gb_ReferenceAxis);
            this.Panel_Param.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Param.Location = new System.Drawing.Point(3, 3);
            this.Panel_Param.Name = "Panel_Param";
            this.Panel_Param.Size = new System.Drawing.Size(316, 331);
            this.Panel_Param.TabIndex = 0;
            // 
            // gb_ReferenceAxis
            // 
            this.gb_ReferenceAxis.Controls.Add(this.clb_ReferenceAxis);
            this.gb_ReferenceAxis.Location = new System.Drawing.Point(3, 3);
            this.gb_ReferenceAxis.Name = "gb_ReferenceAxis";
            this.gb_ReferenceAxis.Size = new System.Drawing.Size(310, 122);
            this.gb_ReferenceAxis.TabIndex = 0;
            this.gb_ReferenceAxis.TabStop = false;
            this.gb_ReferenceAxis.Text = "引用轴";
            // 
            // clb_ReferenceAxis
            // 
            this.clb_ReferenceAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_ReferenceAxis.FormattingEnabled = true;
            this.clb_ReferenceAxis.Location = new System.Drawing.Point(3, 19);
            this.clb_ReferenceAxis.Name = "clb_ReferenceAxis";
            this.clb_ReferenceAxis.Size = new System.Drawing.Size(304, 100);
            this.clb_ReferenceAxis.TabIndex = 0;
            // 
            // Tools_CalibNeedle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tabControl_FindLine);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Tools_CalibNeedle";
            this.Size = new System.Drawing.Size(330, 400);
            this.tabControl_FindLine.ResumeLayout(false);
            this.tab_Basic.ResumeLayout(false);
            this.Panel_Basic.ResumeLayout(false);
            this.Panel_Basic.PerformLayout();
            this.tab_Params.ResumeLayout(false);
            this.Panel_Param.ResumeLayout(false);
            this.gb_ReferenceAxis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TabControl tabControl_FindLine;
        private System.Windows.Forms.TabPage tab_Basic;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_BlockName;
        private System.Windows.Forms.TabPage tab_Params;
        private System.Windows.Forms.Panel Panel_Param;
        private System.Windows.Forms.GroupBox gb_ReferenceAxis;
        private System.Windows.Forms.CheckedListBox clb_ReferenceAxis;
        private System.Windows.Forms.Panel Panel_Basic;
        private System.Windows.Forms.Button button1;
    }
}
