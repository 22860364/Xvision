namespace DispenseAPP.AboutMotionCard.ConfigCardClass.ZMotion
{
    partial class FrmConfigIPAddress
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
            this.lbl_IPAddress = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Cmb_IPAddress = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.Location = new System.Drawing.Point(3, 1);
            this.lbl_ProjectName.Size = new System.Drawing.Size(121, 20);
            this.lbl_ProjectName.Text = "配置正运动控制卡";
            // 
            // lbl_IPAddress
            // 
            this.lbl_IPAddress.Location = new System.Drawing.Point(35, 50);
            this.lbl_IPAddress.Name = "lbl_IPAddress";
            this.lbl_IPAddress.Size = new System.Drawing.Size(69, 23);
            this.lbl_IPAddress.TabIndex = 57;
            this.lbl_IPAddress.Text = "IP地址：";
            this.lbl_IPAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(236, 128);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.Btn_Cancel.TabIndex = 60;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(38, 128);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 28);
            this.Btn_OK.TabIndex = 59;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Cmb_IPAddress
            // 
            this.Cmb_IPAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_IPAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_IPAddress.FormattingEnabled = true;
            this.Cmb_IPAddress.Location = new System.Drawing.Point(110, 50);
            this.Cmb_IPAddress.Name = "Cmb_IPAddress";
            this.Cmb_IPAddress.Size = new System.Drawing.Size(201, 25);
            this.Cmb_IPAddress.TabIndex = 61;
            // 
            // FrmConfigZMotionCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 160);
            this.Controls.Add(this.Cmb_IPAddress);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.lbl_IPAddress);
            this.MaxVisible = false;
            this.Name = "FrmConfigZMotionCard";
            this.Text = "配置正运动控制卡";
            this.TitleVisiable = false;
            this.Controls.SetChildIndex(this.lbl_IPAddress, 0);
            this.Controls.SetChildIndex(this.Btn_OK, 0);
            this.Controls.SetChildIndex(this.Btn_Cancel, 0);
            this.Controls.SetChildIndex(this.Cmb_IPAddress, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_IPAddress;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.ComboBox Cmb_IPAddress;
    }
}