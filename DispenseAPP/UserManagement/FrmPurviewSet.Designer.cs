namespace DispenseAPP
{
    partial class FrmPurviewSet
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.Clb_Purview = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lb_CommunType
            // 
            this.Lb_CommunType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb_CommunType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_CommunType.FormattingEnabled = true;
            this.Lb_CommunType.ItemHeight = 17;
            this.Lb_CommunType.Items.AddRange(new object[] {
            "显示",
            "坐标系",
            "IO",
            "轴参数",
            "工具"});
            this.Lb_CommunType.Location = new System.Drawing.Point(1, 25);
            this.Lb_CommunType.Name = "Lb_CommunType";
            this.Lb_CommunType.Size = new System.Drawing.Size(127, 427);
            this.Lb_CommunType.TabIndex = 2;
            this.Lb_CommunType.SelectedIndexChanged += new System.EventHandler(this.Lb_CommunType_SelectedIndexChanged);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(402, 460);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(321, 460);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 28);
            this.btn_OK.TabIndex = 5;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // Clb_Purview
            // 
            this.Clb_Purview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Clb_Purview.CheckOnClick = true;
            this.Clb_Purview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clb_Purview.FormattingEnabled = true;
            this.Clb_Purview.Location = new System.Drawing.Point(0, 0);
            this.Clb_Purview.Name = "Clb_Purview";
            this.Clb_Purview.Size = new System.Drawing.Size(346, 427);
            this.Clb_Purview.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Clb_Purview);
            this.panel1.Location = new System.Drawing.Point(134, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 427);
            this.panel1.TabIndex = 8;
            // 
            // FrmPurviewSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.Lb_CommunType);
            this.Name = "FrmPurviewSet";
            this.Text = "权限设置";
            this.Controls.SetChildIndex(this.Lb_CommunType, 0);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lb_CommunType;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.CheckedListBox Clb_Purview;
        private System.Windows.Forms.Panel panel1;
    }
}