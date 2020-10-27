namespace DispenseAPP.Tools_CommunControl.Serial
{
    partial class UC_SerialSet
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
            this.gb_SerialSet = new System.Windows.Forms.GroupBox();
            this.Cmb_DataBit = new System.Windows.Forms.ComboBox();
            this.Cmb_Parity = new System.Windows.Forms.ComboBox();
            this.Cmb_StopBits = new System.Windows.Forms.ComboBox();
            this.Cmb_HandShake = new System.Windows.Forms.ComboBox();
            this.Cmb_BaudRate = new System.Windows.Forms.ComboBox();
            this.Lbl_DataBit = new System.Windows.Forms.Label();
            this.Lbl_Parity = new System.Windows.Forms.Label();
            this.Lbl_StopBis = new System.Windows.Forms.Label();
            this.Lbl_HandShake = new System.Windows.Forms.Label();
            this.Lbl_BaudRate = new System.Windows.Forms.Label();
            this.Cb_Enable = new System.Windows.Forms.CheckBox();
            this.Lbl_State = new System.Windows.Forms.Label();
            this.Cmb_PortName = new System.Windows.Forms.ComboBox();
            this.lbl_PortName = new System.Windows.Forms.Label();
            this.gb_SerialSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_SerialSet
            // 
            this.gb_SerialSet.Controls.Add(this.Cmb_DataBit);
            this.gb_SerialSet.Controls.Add(this.Cmb_Parity);
            this.gb_SerialSet.Controls.Add(this.Cmb_StopBits);
            this.gb_SerialSet.Controls.Add(this.Cmb_HandShake);
            this.gb_SerialSet.Controls.Add(this.Cmb_BaudRate);
            this.gb_SerialSet.Controls.Add(this.Lbl_DataBit);
            this.gb_SerialSet.Controls.Add(this.Lbl_Parity);
            this.gb_SerialSet.Controls.Add(this.Lbl_StopBis);
            this.gb_SerialSet.Controls.Add(this.Lbl_HandShake);
            this.gb_SerialSet.Controls.Add(this.Lbl_BaudRate);
            this.gb_SerialSet.Controls.Add(this.Cb_Enable);
            this.gb_SerialSet.Controls.Add(this.Lbl_State);
            this.gb_SerialSet.Controls.Add(this.Cmb_PortName);
            this.gb_SerialSet.Controls.Add(this.lbl_PortName);
            this.gb_SerialSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_SerialSet.Location = new System.Drawing.Point(0, 0);
            this.gb_SerialSet.Name = "gb_SerialSet";
            this.gb_SerialSet.Size = new System.Drawing.Size(460, 427);
            this.gb_SerialSet.TabIndex = 0;
            this.gb_SerialSet.TabStop = false;
            this.gb_SerialSet.Text = "串口设置";
            // 
            // Cmb_DataBit
            // 
            this.Cmb_DataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_DataBit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_DataBit.FormattingEnabled = true;
            this.Cmb_DataBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.Cmb_DataBit.Location = new System.Drawing.Point(133, 294);
            this.Cmb_DataBit.Name = "Cmb_DataBit";
            this.Cmb_DataBit.Size = new System.Drawing.Size(196, 25);
            this.Cmb_DataBit.TabIndex = 25;
            this.Cmb_DataBit.SelectedIndexChanged += new System.EventHandler(this.Cmb_DataBit_SelectedIndexChanged);
            // 
            // Cmb_Parity
            // 
            this.Cmb_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Parity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_Parity.FormattingEnabled = true;
            this.Cmb_Parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.Cmb_Parity.Location = new System.Drawing.Point(133, 250);
            this.Cmb_Parity.Name = "Cmb_Parity";
            this.Cmb_Parity.Size = new System.Drawing.Size(196, 25);
            this.Cmb_Parity.TabIndex = 24;
            this.Cmb_Parity.SelectedIndexChanged += new System.EventHandler(this.Cmb_Parity_SelectedIndexChanged);
            // 
            // Cmb_StopBits
            // 
            this.Cmb_StopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_StopBits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_StopBits.FormattingEnabled = true;
            this.Cmb_StopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.Cmb_StopBits.Location = new System.Drawing.Point(133, 206);
            this.Cmb_StopBits.Name = "Cmb_StopBits";
            this.Cmb_StopBits.Size = new System.Drawing.Size(196, 25);
            this.Cmb_StopBits.TabIndex = 23;
            this.Cmb_StopBits.SelectedIndexChanged += new System.EventHandler(this.Cmb_StopBits_SelectedIndexChanged);
            // 
            // Cmb_HandShake
            // 
            this.Cmb_HandShake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_HandShake.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_HandShake.FormattingEnabled = true;
            this.Cmb_HandShake.Items.AddRange(new object[] {
            "None",
            "HardWare",
            "Xon/Xoff"});
            this.Cmb_HandShake.Location = new System.Drawing.Point(133, 162);
            this.Cmb_HandShake.Name = "Cmb_HandShake";
            this.Cmb_HandShake.Size = new System.Drawing.Size(196, 25);
            this.Cmb_HandShake.TabIndex = 22;
            this.Cmb_HandShake.SelectedIndexChanged += new System.EventHandler(this.Cmb_HandShake_SelectedIndexChanged);
            // 
            // Cmb_BaudRate
            // 
            this.Cmb_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_BaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_BaudRate.FormattingEnabled = true;
            this.Cmb_BaudRate.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.Cmb_BaudRate.Location = new System.Drawing.Point(133, 118);
            this.Cmb_BaudRate.Name = "Cmb_BaudRate";
            this.Cmb_BaudRate.Size = new System.Drawing.Size(196, 25);
            this.Cmb_BaudRate.TabIndex = 21;
            this.Cmb_BaudRate.SelectedIndexChanged += new System.EventHandler(this.Cmb_BaudRate_SelectedIndexChanged);
            // 
            // Lbl_DataBit
            // 
            this.Lbl_DataBit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_DataBit.Location = new System.Drawing.Point(37, 295);
            this.Lbl_DataBit.Name = "Lbl_DataBit";
            this.Lbl_DataBit.Size = new System.Drawing.Size(69, 24);
            this.Lbl_DataBit.TabIndex = 20;
            this.Lbl_DataBit.Text = "数据位：";
            this.Lbl_DataBit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Parity
            // 
            this.Lbl_Parity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Parity.Location = new System.Drawing.Point(37, 251);
            this.Lbl_Parity.Name = "Lbl_Parity";
            this.Lbl_Parity.Size = new System.Drawing.Size(69, 24);
            this.Lbl_Parity.TabIndex = 19;
            this.Lbl_Parity.Text = "奇偶校验：";
            this.Lbl_Parity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_StopBis
            // 
            this.Lbl_StopBis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_StopBis.Location = new System.Drawing.Point(37, 207);
            this.Lbl_StopBis.Name = "Lbl_StopBis";
            this.Lbl_StopBis.Size = new System.Drawing.Size(69, 24);
            this.Lbl_StopBis.TabIndex = 18;
            this.Lbl_StopBis.Text = "停止位：";
            this.Lbl_StopBis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_HandShake
            // 
            this.Lbl_HandShake.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_HandShake.Location = new System.Drawing.Point(37, 163);
            this.Lbl_HandShake.Name = "Lbl_HandShake";
            this.Lbl_HandShake.Size = new System.Drawing.Size(69, 24);
            this.Lbl_HandShake.TabIndex = 17;
            this.Lbl_HandShake.Text = "流控制：";
            this.Lbl_HandShake.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_BaudRate
            // 
            this.Lbl_BaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_BaudRate.Location = new System.Drawing.Point(37, 119);
            this.Lbl_BaudRate.Name = "Lbl_BaudRate";
            this.Lbl_BaudRate.Size = new System.Drawing.Size(69, 24);
            this.Lbl_BaudRate.TabIndex = 16;
            this.Lbl_BaudRate.Text = "波特率：";
            this.Lbl_BaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cb_Enable
            // 
            this.Cb_Enable.AutoSize = true;
            this.Cb_Enable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cb_Enable.Location = new System.Drawing.Point(133, 76);
            this.Cb_Enable.Name = "Cb_Enable";
            this.Cb_Enable.Size = new System.Drawing.Size(60, 21);
            this.Cb_Enable.TabIndex = 15;
            this.Cb_Enable.Text = "已启用";
            this.Cb_Enable.UseVisualStyleBackColor = true;
            this.Cb_Enable.CheckedChanged += new System.EventHandler(this.Cb_Enable_CheckedChanged);
            // 
            // Lbl_State
            // 
            this.Lbl_State.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_State.Location = new System.Drawing.Point(37, 76);
            this.Lbl_State.Name = "Lbl_State";
            this.Lbl_State.Size = new System.Drawing.Size(69, 24);
            this.Lbl_State.TabIndex = 14;
            this.Lbl_State.Text = "状态：";
            this.Lbl_State.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cmb_PortName
            // 
            this.Cmb_PortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_PortName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_PortName.FormattingEnabled = true;
            this.Cmb_PortName.Location = new System.Drawing.Point(133, 28);
            this.Cmb_PortName.Name = "Cmb_PortName";
            this.Cmb_PortName.Size = new System.Drawing.Size(196, 25);
            this.Cmb_PortName.TabIndex = 13;
            this.Cmb_PortName.SelectedIndexChanged += new System.EventHandler(this.Cmb_PortName_SelectedIndexChanged);
            // 
            // lbl_PortName
            // 
            this.lbl_PortName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PortName.Location = new System.Drawing.Point(37, 29);
            this.lbl_PortName.Name = "lbl_PortName";
            this.lbl_PortName.Size = new System.Drawing.Size(69, 24);
            this.lbl_PortName.TabIndex = 10;
            this.lbl_PortName.Text = "端口：";
            this.lbl_PortName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_SerialSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.gb_SerialSet);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UC_SerialSet";
            this.Size = new System.Drawing.Size(460, 427);
            this.gb_SerialSet.ResumeLayout(false);
            this.gb_SerialSet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_SerialSet;
        private System.Windows.Forms.Label lbl_PortName;
        private System.Windows.Forms.CheckBox Cb_Enable;
        private System.Windows.Forms.Label Lbl_State;
        private System.Windows.Forms.ComboBox Cmb_PortName;
        private System.Windows.Forms.ComboBox Cmb_DataBit;
        private System.Windows.Forms.ComboBox Cmb_Parity;
        private System.Windows.Forms.ComboBox Cmb_StopBits;
        private System.Windows.Forms.ComboBox Cmb_HandShake;
        private System.Windows.Forms.ComboBox Cmb_BaudRate;
        private System.Windows.Forms.Label Lbl_DataBit;
        private System.Windows.Forms.Label Lbl_Parity;
        private System.Windows.Forms.Label Lbl_StopBis;
        private System.Windows.Forms.Label Lbl_HandShake;
        private System.Windows.Forms.Label Lbl_BaudRate;
    }
}
