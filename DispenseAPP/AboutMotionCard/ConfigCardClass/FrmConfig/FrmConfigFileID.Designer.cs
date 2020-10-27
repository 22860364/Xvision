namespace DispenseAPP.AboutMotionCard.ConfigCardClass.GTS
{
    partial class FrmConfigFileAndID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Load = new System.Windows.Forms.Button();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.lbl_IPAddress = new System.Windows.Forms.Label();
            this.Num_CardNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_CardNum)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.Location = new System.Drawing.Point(3, 1);
            this.lbl_ProjectName.Size = new System.Drawing.Size(135, 20);
            this.lbl_ProjectName.Text = "配置固高运动控制卡";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Load);
            this.groupBox2.Controls.Add(this.txt_Path);
            this.groupBox2.Location = new System.Drawing.Point(8, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 84);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "配置文件路径";
            // 
            // Btn_Load
            // 
            this.Btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Load.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Load.Location = new System.Drawing.Point(350, 33);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(75, 27);
            this.Btn_Load.TabIndex = 62;
            this.Btn_Load.Text = "加载";
            this.Btn_Load.UseVisualStyleBackColor = true;
            this.Btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(6, 22);
            this.txt_Path.Multiline = true;
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Path.Size = new System.Drawing.Size(338, 55);
            this.txt_Path.TabIndex = 0;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(284, 173);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.Btn_Cancel.TabIndex = 62;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(86, 173);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 28);
            this.Btn_OK.TabIndex = 61;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // lbl_IPAddress
            // 
            this.lbl_IPAddress.Location = new System.Drawing.Point(11, 43);
            this.lbl_IPAddress.Name = "lbl_IPAddress";
            this.lbl_IPAddress.Size = new System.Drawing.Size(69, 23);
            this.lbl_IPAddress.TabIndex = 63;
            this.lbl_IPAddress.Text = "卡号：";
            this.lbl_IPAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Num_CardNum
            // 
            this.Num_CardNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num_CardNum.Location = new System.Drawing.Point(74, 43);
            this.Num_CardNum.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.Num_CardNum.Name = "Num_CardNum";
            this.Num_CardNum.Size = new System.Drawing.Size(120, 23);
            this.Num_CardNum.TabIndex = 64;
            // 
            // FrmConfigGTSCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 205);
            this.Controls.Add(this.Num_CardNum);
            this.Controls.Add(this.lbl_IPAddress);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.groupBox2);
            this.MaxVisible = false;
            this.Name = "FrmConfigGTSCard";
            this.Text = "配置固高运动控制卡";
            this.TitleVisiable = false;
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.Btn_OK, 0);
            this.Controls.SetChildIndex(this.Btn_Cancel, 0);
            this.Controls.SetChildIndex(this.lbl_IPAddress, 0);
            this.Controls.SetChildIndex(this.Num_CardNum, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_CardNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Load;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Label lbl_IPAddress;
        private System.Windows.Forms.NumericUpDown Num_CardNum;
    }
}