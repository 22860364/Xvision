namespace DispenseAPP.Tools_CommunControl.PLC
{
    partial class UC_PLCSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PLCSet));
            this.Lbl_LocalIP = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Lv_PLC = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Num_RemotePort = new System.Windows.Forms.NumericUpDown();
            this.Cmb_RemoteIP = new System.Windows.Forms.ComboBox();
            this.Cmb_LocalIP = new System.Windows.Forms.ComboBox();
            this.Lbl_RemotePort = new System.Windows.Forms.Label();
            this.Lbl_RemoteIP = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_RemotePort)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_LocalIP
            // 
            this.Lbl_LocalIP.Location = new System.Drawing.Point(16, 18);
            this.Lbl_LocalIP.Name = "Lbl_LocalIP";
            this.Lbl_LocalIP.Size = new System.Drawing.Size(79, 23);
            this.Lbl_LocalIP.TabIndex = 4;
            this.Lbl_LocalIP.Text = "本地IP：";
            this.Lbl_LocalIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Update);
            this.groupBox1.Controls.Add(this.Btn_Delete);
            this.groupBox1.Controls.Add(this.Btn_Add);
            this.groupBox1.Controls.Add(this.Lv_PLC);
            this.groupBox1.Controls.Add(this.Num_RemotePort);
            this.groupBox1.Controls.Add(this.Cmb_RemoteIP);
            this.groupBox1.Controls.Add(this.Cmb_LocalIP);
            this.groupBox1.Controls.Add(this.Lbl_RemotePort);
            this.groupBox1.Controls.Add(this.Lbl_RemoteIP);
            this.groupBox1.Controls.Add(this.Lbl_LocalIP);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 427);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLC通讯设置";
            // 
            // Btn_Update
            // 
            this.Btn_Update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Update.Location = new System.Drawing.Point(379, 226);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(75, 28);
            this.Btn_Update.TabIndex = 16;
            this.Btn_Update.Text = "刷新";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Delete.Location = new System.Drawing.Point(379, 179);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 28);
            this.Btn_Delete.TabIndex = 15;
            this.Btn_Delete.Text = "删除";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Add.Location = new System.Drawing.Point(379, 134);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(72, 28);
            this.Btn_Add.TabIndex = 14;
            this.Btn_Add.Text = "添加";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Lv_PLC
            // 
            this.Lv_PLC.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.Lv_PLC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lv_PLC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.Lv_PLC.FullRowSelect = true;
            this.Lv_PLC.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.Lv_PLC.HideSelection = false;
            this.Lv_PLC.Location = new System.Drawing.Point(19, 134);
            this.Lv_PLC.MultiSelect = false;
            this.Lv_PLC.Name = "Lv_PLC";
            this.Lv_PLC.ShowGroups = false;
            this.Lv_PLC.Size = new System.Drawing.Size(354, 287);
            this.Lv_PLC.SmallImageList = this.imageList1;
            this.Lv_PLC.TabIndex = 12;
            this.Lv_PLC.UseCompatibleStateImageBehavior = false;
            this.Lv_PLC.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 354;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "连接成功.png");
            this.imageList1.Images.SetKeyName(1, "连接失败.png");
            // 
            // Num_RemotePort
            // 
            this.Num_RemotePort.Location = new System.Drawing.Point(101, 105);
            this.Num_RemotePort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Num_RemotePort.Name = "Num_RemotePort";
            this.Num_RemotePort.Size = new System.Drawing.Size(105, 23);
            this.Num_RemotePort.TabIndex = 11;
            this.Num_RemotePort.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // Cmb_RemoteIP
            // 
            this.Cmb_RemoteIP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_RemoteIP.FormattingEnabled = true;
            this.Cmb_RemoteIP.Location = new System.Drawing.Point(101, 61);
            this.Cmb_RemoteIP.Name = "Cmb_RemoteIP";
            this.Cmb_RemoteIP.Size = new System.Drawing.Size(217, 25);
            this.Cmb_RemoteIP.TabIndex = 9;
            // 
            // Cmb_LocalIP
            // 
            this.Cmb_LocalIP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_LocalIP.FormattingEnabled = true;
            this.Cmb_LocalIP.Location = new System.Drawing.Point(101, 18);
            this.Cmb_LocalIP.Name = "Cmb_LocalIP";
            this.Cmb_LocalIP.Size = new System.Drawing.Size(217, 25);
            this.Cmb_LocalIP.TabIndex = 8;
            // 
            // Lbl_RemotePort
            // 
            this.Lbl_RemotePort.Location = new System.Drawing.Point(16, 104);
            this.Lbl_RemotePort.Name = "Lbl_RemotePort";
            this.Lbl_RemotePort.Size = new System.Drawing.Size(79, 23);
            this.Lbl_RemotePort.TabIndex = 7;
            this.Lbl_RemotePort.Text = "远程端口：";
            this.Lbl_RemotePort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_RemoteIP
            // 
            this.Lbl_RemoteIP.Location = new System.Drawing.Point(16, 61);
            this.Lbl_RemoteIP.Name = "Lbl_RemoteIP";
            this.Lbl_RemoteIP.Size = new System.Drawing.Size(79, 23);
            this.Lbl_RemoteIP.TabIndex = 6;
            this.Lbl_RemoteIP.Text = "远程IP：";
            this.Lbl_RemoteIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_PLCEnt_Set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_PLCEnt_Set";
            this.Size = new System.Drawing.Size(460, 427);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Num_RemotePort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_LocalIP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_RemotePort;
        private System.Windows.Forms.Label Lbl_RemoteIP;
        private System.Windows.Forms.ComboBox Cmb_RemoteIP;
        private System.Windows.Forms.ComboBox Cmb_LocalIP;
        private System.Windows.Forms.NumericUpDown Num_RemotePort;
        private System.Windows.Forms.ListView Lv_PLC;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
