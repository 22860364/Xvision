namespace DispenseAPP.Tools_MotionControl.MeasureHeight
{
    partial class MeasureHeight_ADChannelRead
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cmb_SelectCard = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Num_HeightVoltage = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Num_LowVoltage = new System.Windows.Forms.NumericUpDown();
            this.Cb_LimitVoltage = new System.Windows.Forms.CheckBox();
            this.Num_ReadTimes = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Num_ChannelNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_HeightVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_LowVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ReadTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ChannelNum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cmb_SelectCard);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Num_HeightVoltage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Num_LowVoltage);
            this.groupBox1.Controls.Add(this.Cb_LimitVoltage);
            this.groupBox1.Controls.Add(this.Num_ReadTimes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Num_ChannelNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AD通道读取";
            // 
            // Cmb_SelectCard
            // 
            this.Cmb_SelectCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_SelectCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_SelectCard.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cmb_SelectCard.FormattingEnabled = true;
            this.Cmb_SelectCard.Location = new System.Drawing.Point(59, 19);
            this.Cmb_SelectCard.Name = "Cmb_SelectCard";
            this.Cmb_SelectCard.Size = new System.Drawing.Size(166, 25);
            this.Cmb_SelectCard.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(4, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "选择卡";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Num_HeightVoltage
            // 
            this.Num_HeightVoltage.DecimalPlaces = 1;
            this.Num_HeightVoltage.Location = new System.Drawing.Point(204, 90);
            this.Num_HeightVoltage.Name = "Num_HeightVoltage";
            this.Num_HeightVoltage.Size = new System.Drawing.Size(87, 23);
            this.Num_HeightVoltage.TabIndex = 11;
            this.Num_HeightVoltage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(175, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "—";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Num_LowVoltage
            // 
            this.Num_LowVoltage.DecimalPlaces = 1;
            this.Num_LowVoltage.Location = new System.Drawing.Point(101, 90);
            this.Num_LowVoltage.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Num_LowVoltage.Name = "Num_LowVoltage";
            this.Num_LowVoltage.Size = new System.Drawing.Size(68, 23);
            this.Num_LowVoltage.TabIndex = 9;
            // 
            // Cb_LimitVoltage
            // 
            this.Cb_LimitVoltage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cb_LimitVoltage.Location = new System.Drawing.Point(7, 89);
            this.Cb_LimitVoltage.Name = "Cb_LimitVoltage";
            this.Cb_LimitVoltage.Size = new System.Drawing.Size(88, 23);
            this.Cb_LimitVoltage.TabIndex = 8;
            this.Cb_LimitVoltage.Text = "限制电压(V)";
            this.Cb_LimitVoltage.UseVisualStyleBackColor = true;
            this.Cb_LimitVoltage.CheckedChanged += new System.EventHandler(this.Cb_LimitVoltage_CheckedChanged);
            // 
            // Num_ReadTimes
            // 
            this.Num_ReadTimes.Location = new System.Drawing.Point(204, 52);
            this.Num_ReadTimes.Name = "Num_ReadTimes";
            this.Num_ReadTimes.Size = new System.Drawing.Size(89, 23);
            this.Num_ReadTimes.TabIndex = 7;
            this.Num_ReadTimes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(142, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "读取次数";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Num_ChannelNum
            // 
            this.Num_ChannelNum.Location = new System.Drawing.Point(47, 52);
            this.Num_ChannelNum.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Num_ChannelNum.Name = "Num_ChannelNum";
            this.Num_ChannelNum.Size = new System.Drawing.Size(89, 23);
            this.Num_ChannelNum.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "通道";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MeasureHeight_ADChannelRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "MeasureHeight_ADChannelRead";
            this.Size = new System.Drawing.Size(298, 122);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Num_HeightVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_LowVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ReadTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ChannelNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown Num_ReadTimes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Num_ChannelNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Cb_LimitVoltage;
        private System.Windows.Forms.NumericUpDown Num_LowVoltage;
        private System.Windows.Forms.NumericUpDown Num_HeightVoltage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cmb_SelectCard;
        private System.Windows.Forms.Label label4;
    }
}
