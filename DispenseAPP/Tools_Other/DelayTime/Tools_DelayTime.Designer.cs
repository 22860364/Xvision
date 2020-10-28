namespace DispenseAPP.Tools_Other
{
    partial class Tools_DelayTime
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
            this.tabControl_FindLine = new System.Windows.Forms.TabControl();
            this.tab_Basic = new System.Windows.Forms.TabPage();
            this.lbl_Millisecond = new System.Windows.Forms.Label();
            this.num_Time = new System.Windows.Forms.NumericUpDown();
            this.lbl_Delay = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_BlockName = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.tabControl_FindLine.SuspendLayout();
            this.tab_Basic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Time)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_FindLine
            // 
            this.tabControl_FindLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_FindLine.Controls.Add(this.tab_Basic);
            this.tabControl_FindLine.ItemSize = new System.Drawing.Size(65, 18);
            this.tabControl_FindLine.Location = new System.Drawing.Point(0, 0);
            this.tabControl_FindLine.Multiline = true;
            this.tabControl_FindLine.Name = "tabControl_FindLine";
            this.tabControl_FindLine.SelectedIndex = 0;
            this.tabControl_FindLine.Size = new System.Drawing.Size(330, 363);
            this.tabControl_FindLine.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_FindLine.TabIndex = 15;
            // 
            // tab_Basic
            // 
            this.tab_Basic.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Basic.Controls.Add(this.lbl_Millisecond);
            this.tab_Basic.Controls.Add(this.num_Time);
            this.tab_Basic.Controls.Add(this.lbl_Delay);
            this.tab_Basic.Controls.Add(this.txt_Name);
            this.tab_Basic.Controls.Add(this.lbl_BlockName);
            this.tab_Basic.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab_Basic.Location = new System.Drawing.Point(4, 22);
            this.tab_Basic.Name = "tab_Basic";
            this.tab_Basic.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Basic.Size = new System.Drawing.Size(322, 337);
            this.tab_Basic.TabIndex = 0;
            this.tab_Basic.Text = "基本";
            // 
            // lbl_Millisecond
            // 
            this.lbl_Millisecond.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Millisecond.Location = new System.Drawing.Point(202, 73);
            this.lbl_Millisecond.Name = "lbl_Millisecond";
            this.lbl_Millisecond.Size = new System.Drawing.Size(63, 23);
            this.lbl_Millisecond.TabIndex = 13;
            this.lbl_Millisecond.Text = "毫秒";
            this.lbl_Millisecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_Time
            // 
            this.num_Time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num_Time.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_Time.Location = new System.Drawing.Point(76, 69);
            this.num_Time.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.num_Time.Name = "num_Time";
            this.num_Time.Size = new System.Drawing.Size(120, 26);
            this.num_Time.TabIndex = 12;
            // 
            // lbl_Delay
            // 
            this.lbl_Delay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Delay.Location = new System.Drawing.Point(16, 72);
            this.lbl_Delay.Name = "lbl_Delay";
            this.lbl_Delay.Size = new System.Drawing.Size(40, 24);
            this.lbl_Delay.TabIndex = 11;
            this.lbl_Delay.Text = "延时";
            this.lbl_Delay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Name.Location = new System.Drawing.Point(76, 15);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(213, 24);
            this.txt_Name.TabIndex = 10;
            // 
            // lbl_BlockName
            // 
            this.lbl_BlockName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_BlockName.Location = new System.Drawing.Point(16, 15);
            this.lbl_BlockName.Name = "lbl_BlockName";
            this.lbl_BlockName.Size = new System.Drawing.Size(63, 24);
            this.lbl_BlockName.TabIndex = 9;
            this.lbl_BlockName.Text = "算子名：";
            this.lbl_BlockName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(223, 369);
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
            this.btn_OK.Location = new System.Drawing.Point(125, 369);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 28);
            this.btn_OK.TabIndex = 16;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // Tools_DelayTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tabControl_FindLine);
            this.Name = "Tools_DelayTime";
            this.Size = new System.Drawing.Size(330, 400);
            this.tabControl_FindLine.ResumeLayout(false);
            this.tab_Basic.ResumeLayout(false);
            this.tab_Basic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Time)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_FindLine;
        private System.Windows.Forms.TabPage tab_Basic;
        private System.Windows.Forms.Label lbl_Delay;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_BlockName;
        private System.Windows.Forms.Label lbl_Millisecond;
        private System.Windows.Forms.NumericUpDown num_Time;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
    }
}
