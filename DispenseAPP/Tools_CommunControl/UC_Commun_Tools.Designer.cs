namespace DispenseAPP.Tools_CommunControl
{
    partial class UC_Commun_Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Commun_Tools));
            this.Lbl_TCPIP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Serial = new System.Windows.Forms.Label();
            this.Lbl_PLC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_TCPIP
            // 
            this.Lbl_TCPIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_TCPIP.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_TCPIP.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_TCPIP.Image")));
            this.Lbl_TCPIP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_TCPIP.Location = new System.Drawing.Point(0, 0);
            this.Lbl_TCPIP.Name = "Lbl_TCPIP";
            this.Lbl_TCPIP.Size = new System.Drawing.Size(330, 32);
            this.Lbl_TCPIP.TabIndex = 2;
            this.Lbl_TCPIP.Text = "          TCP/IP";
            this.Lbl_TCPIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_TCPIP.Click += new System.EventHandler(this.Lbl_TCPIP_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "          Modbus";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Serial
            // 
            this.Lbl_Serial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Serial.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Serial.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_Serial.Image")));
            this.Lbl_Serial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Serial.Location = new System.Drawing.Point(0, 32);
            this.Lbl_Serial.Name = "Lbl_Serial";
            this.Lbl_Serial.Size = new System.Drawing.Size(330, 32);
            this.Lbl_Serial.TabIndex = 4;
            this.Lbl_Serial.Text = "          串口";
            this.Lbl_Serial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Serial.Click += new System.EventHandler(this.Lbl_Serial_Click);
            // 
            // Lbl_PLC
            // 
            this.Lbl_PLC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_PLC.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_PLC.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_PLC.Image")));
            this.Lbl_PLC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_PLC.Location = new System.Drawing.Point(0, 96);
            this.Lbl_PLC.Name = "Lbl_PLC";
            this.Lbl_PLC.Size = new System.Drawing.Size(330, 32);
            this.Lbl_PLC.TabIndex = 6;
            this.Lbl_PLC.Text = "          PLC";
            this.Lbl_PLC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_PLC.Click += new System.EventHandler(this.Lbl_PLC_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(3, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "          IO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_Commun_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lbl_PLC);
            this.Controls.Add(this.Lbl_Serial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_TCPIP);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UC_Commun_Tools";
            this.Size = new System.Drawing.Size(330, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_TCPIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Serial;
        private System.Windows.Forms.Label Lbl_PLC;
        private System.Windows.Forms.Label label5;
    }
}
