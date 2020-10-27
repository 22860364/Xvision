namespace DispenseAPP.Tools_CommunControl
{
    partial class FrmConfigCommun
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
            this.Lb_CommunType = new System.Windows.Forms.ListBox();
            this.Panel_Commun = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.Location = new System.Drawing.Point(3, 1);
            this.lbl_ProjectName.Size = new System.Drawing.Size(65, 20);
            this.lbl_ProjectName.Text = "通讯设置";
            // 
            // Lb_CommunType
            // 
            this.Lb_CommunType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb_CommunType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_CommunType.FormattingEnabled = true;
            this.Lb_CommunType.ItemHeight = 17;
            this.Lb_CommunType.Items.AddRange(new object[] {
            "TCP/IP",
            "串口",
            "Modbus",
            "三菱Q系列PLC"});
            this.Lb_CommunType.Location = new System.Drawing.Point(1, 32);
            this.Lb_CommunType.Name = "Lb_CommunType";
            this.Lb_CommunType.Size = new System.Drawing.Size(127, 427);
            this.Lb_CommunType.TabIndex = 1;
            this.Lb_CommunType.SelectedIndexChanged += new System.EventHandler(this.Lb_CommunType_SelectedIndexChanged);
            // 
            // Panel_Commun
            // 
            this.Panel_Commun.AutoScroll = true;
            this.Panel_Commun.Location = new System.Drawing.Point(134, 32);
            this.Panel_Commun.Name = "Panel_Commun";
            this.Panel_Commun.Size = new System.Drawing.Size(465, 427);
            this.Panel_Commun.TabIndex = 2;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(524, 465);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(420, 465);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 28);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // FrmConfigCommun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(600, 494);
            this.Controls.Add(this.Panel_Commun);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.Lb_CommunType);
            this.MaxVisible = false;
            this.Name = "FrmConfigCommun";
            this.Text = "通讯设置";
            this.TitleVisiable = false;
            this.Controls.SetChildIndex(this.Lb_CommunType, 0);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.Panel_Commun, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lb_CommunType;
        private System.Windows.Forms.Panel Panel_Commun;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
    }
}