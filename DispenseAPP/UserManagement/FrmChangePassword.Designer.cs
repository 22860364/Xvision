namespace DispenseAPP.UserManagement
{
    partial class FrmChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_OriginalPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_NewPassword = new System.Windows.Forms.TextBox();
            this.Txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "原密码：";
            // 
            // Txt_OriginalPassword
            // 
            this.Txt_OriginalPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_OriginalPassword.Location = new System.Drawing.Point(89, 45);
            this.Txt_OriginalPassword.Name = "Txt_OriginalPassword";
            this.Txt_OriginalPassword.PasswordChar = '*';
            this.Txt_OriginalPassword.Size = new System.Drawing.Size(179, 23);
            this.Txt_OriginalPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认密码：";
            // 
            // Txt_NewPassword
            // 
            this.Txt_NewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_NewPassword.Location = new System.Drawing.Point(89, 89);
            this.Txt_NewPassword.Name = "Txt_NewPassword";
            this.Txt_NewPassword.PasswordChar = '*';
            this.Txt_NewPassword.Size = new System.Drawing.Size(179, 23);
            this.Txt_NewPassword.TabIndex = 5;
            // 
            // Txt_ConfirmPassword
            // 
            this.Txt_ConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_ConfirmPassword.Location = new System.Drawing.Point(89, 132);
            this.Txt_ConfirmPassword.Name = "Txt_ConfirmPassword";
            this.Txt_ConfirmPassword.PasswordChar = '*';
            this.Txt_ConfirmPassword.Size = new System.Drawing.Size(179, 23);
            this.Txt_ConfirmPassword.TabIndex = 6;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Location = new System.Drawing.Point(202, 171);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(66, 28);
            this.Btn_Cancel.TabIndex = 8;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Location = new System.Drawing.Point(89, 171);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(66, 28);
            this.Btn_OK.TabIndex = 7;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 215);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Txt_ConfirmPassword);
            this.Controls.Add(this.Txt_NewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_OriginalPassword);
            this.Controls.Add(this.label1);
            this.Name = "FrmChangePassword";
            this.Text = "修改密码";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Txt_OriginalPassword, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.Txt_NewPassword, 0);
            this.Controls.SetChildIndex(this.Txt_ConfirmPassword, 0);
            this.Controls.SetChildIndex(this.Btn_OK, 0);
            this.Controls.SetChildIndex(this.Btn_Cancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_OriginalPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_NewPassword;
        private System.Windows.Forms.TextBox Txt_ConfirmPassword;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
    }
}