namespace DispenseAPP.Tools_CommunControl.TCP
{
    partial class UC_TCPSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TCPSet));
            this.gb_TCP设置 = new System.Windows.Forms.GroupBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lv_TCP_IP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.num_PortNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_IP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Mode = new System.Windows.Forms.GroupBox();
            this.rbtn_Client = new System.Windows.Forms.RadioButton();
            this.rbtn_Serve = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gb_TCP设置.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_PortNum)).BeginInit();
            this.gb_Mode.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_TCP设置
            // 
            this.gb_TCP设置.Controls.Add(this.btn_Update);
            this.gb_TCP设置.Controls.Add(this.btn_Delete);
            this.gb_TCP设置.Controls.Add(this.btn_Add);
            this.gb_TCP设置.Controls.Add(this.lv_TCP_IP);
            this.gb_TCP设置.Controls.Add(this.num_PortNum);
            this.gb_TCP设置.Controls.Add(this.label2);
            this.gb_TCP设置.Controls.Add(this.cmb_IP);
            this.gb_TCP设置.Controls.Add(this.label1);
            this.gb_TCP设置.Controls.Add(this.gb_Mode);
            this.gb_TCP设置.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_TCP设置.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_TCP设置.Location = new System.Drawing.Point(0, 0);
            this.gb_TCP设置.Name = "gb_TCP设置";
            this.gb_TCP设置.Size = new System.Drawing.Size(460, 427);
            this.gb_TCP设置.TabIndex = 0;
            this.gb_TCP设置.TabStop = false;
            this.gb_TCP设置.Text = "TCP/IP设置";
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Update.Location = new System.Drawing.Point(379, 245);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 28);
            this.btn_Update.TabIndex = 13;
            this.btn_Update.Text = "刷新";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Delete.Location = new System.Drawing.Point(379, 201);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 28);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Add.Location = new System.Drawing.Point(379, 157);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 28);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "添加";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // lv_TCP_IP
            // 
            this.lv_TCP_IP.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lv_TCP_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_TCP_IP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lv_TCP_IP.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_TCP_IP.HideSelection = false;
            this.lv_TCP_IP.Location = new System.Drawing.Point(9, 151);
            this.lv_TCP_IP.MultiSelect = false;
            this.lv_TCP_IP.Name = "lv_TCP_IP";
            this.lv_TCP_IP.ShowGroups = false;
            this.lv_TCP_IP.Size = new System.Drawing.Size(364, 270);
            this.lv_TCP_IP.TabIndex = 10;
            this.lv_TCP_IP.UseCompatibleStateImageBehavior = false;
            this.lv_TCP_IP.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 364;
            // 
            // num_PortNum
            // 
            this.num_PortNum.Location = new System.Drawing.Point(115, 122);
            this.num_PortNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_PortNum.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.num_PortNum.Name = "num_PortNum";
            this.num_PortNum.Size = new System.Drawing.Size(105, 23);
            this.num_PortNum.TabIndex = 9;
            this.num_PortNum.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "端口号：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_IP
            // 
            this.cmb_IP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_IP.FormattingEnabled = true;
            this.cmb_IP.Location = new System.Drawing.Point(115, 88);
            this.cmb_IP.Name = "cmb_IP";
            this.cmb_IP.Size = new System.Drawing.Size(258, 25);
            this.cmb_IP.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "主机名/IP：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gb_Mode
            // 
            this.gb_Mode.Controls.Add(this.rbtn_Client);
            this.gb_Mode.Controls.Add(this.rbtn_Serve);
            this.gb_Mode.Location = new System.Drawing.Point(6, 22);
            this.gb_Mode.Name = "gb_Mode";
            this.gb_Mode.Size = new System.Drawing.Size(367, 54);
            this.gb_Mode.TabIndex = 0;
            this.gb_Mode.TabStop = false;
            this.gb_Mode.Text = "模式";
            // 
            // rbtn_Client
            // 
            this.rbtn_Client.AutoSize = true;
            this.rbtn_Client.Location = new System.Drawing.Point(263, 22);
            this.rbtn_Client.Name = "rbtn_Client";
            this.rbtn_Client.Size = new System.Drawing.Size(62, 21);
            this.rbtn_Client.TabIndex = 1;
            this.rbtn_Client.Text = "客户端";
            this.rbtn_Client.UseVisualStyleBackColor = true;
            // 
            // rbtn_Serve
            // 
            this.rbtn_Serve.AutoSize = true;
            this.rbtn_Serve.Checked = true;
            this.rbtn_Serve.Location = new System.Drawing.Point(39, 22);
            this.rbtn_Serve.Name = "rbtn_Serve";
            this.rbtn_Serve.Size = new System.Drawing.Size(62, 21);
            this.rbtn_Serve.TabIndex = 0;
            this.rbtn_Serve.TabStop = true;
            this.rbtn_Serve.Text = "服务器";
            this.rbtn_Serve.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "连接成功.png");
            this.imageList1.Images.SetKeyName(1, "连接失败.png");
            // 
            // UC_Set_TCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.gb_TCP设置);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UC_Set_TCP";
            this.Size = new System.Drawing.Size(460, 427);
            this.gb_TCP设置.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_PortNum)).EndInit();
            this.gb_Mode.ResumeLayout(false);
            this.gb_Mode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_TCP设置;
        private System.Windows.Forms.GroupBox gb_Mode;
        private System.Windows.Forms.RadioButton rbtn_Client;
        private System.Windows.Forms.RadioButton rbtn_Serve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_IP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_PortNum;
        private System.Windows.Forms.ListView lv_TCP_IP;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
