namespace DispenseAPP.Tools_Image_IO.AutoCalib
{
    partial class FrmNewCalib
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
            this.Gb_CalibMethod = new System.Windows.Forms.GroupBox();
            this.Rbtn_MultiCamera_Length = new System.Windows.Forms.RadioButton();
            this.Rbtn_MultiCamera_Board = new System.Windows.Forms.RadioButton();
            this.Rbtn_Distortion = new System.Windows.Forms.RadioButton();
            this.Rbtn_RotationCenter = new System.Windows.Forms.RadioButton();
            this.Rbtn_PointDistance = new System.Windows.Forms.RadioButton();
            this.Rbtn_Hand_Eye = new System.Windows.Forms.RadioButton();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_CalibProjectName = new System.Windows.Forms.TextBox();
            this.Txt_CalibResultName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Gb_CalibMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.Location = new System.Drawing.Point(3, 1);
            this.lbl_ProjectName.Size = new System.Drawing.Size(65, 20);
            this.lbl_ProjectName.Text = "新建标定";
            // 
            // Gb_CalibMethod
            // 
            this.Gb_CalibMethod.Controls.Add(this.Rbtn_MultiCamera_Length);
            this.Gb_CalibMethod.Controls.Add(this.Rbtn_MultiCamera_Board);
            this.Gb_CalibMethod.Controls.Add(this.Rbtn_Distortion);
            this.Gb_CalibMethod.Controls.Add(this.Rbtn_RotationCenter);
            this.Gb_CalibMethod.Controls.Add(this.Rbtn_PointDistance);
            this.Gb_CalibMethod.Controls.Add(this.Rbtn_Hand_Eye);
            this.Gb_CalibMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gb_CalibMethod.Location = new System.Drawing.Point(8, 32);
            this.Gb_CalibMethod.Name = "Gb_CalibMethod";
            this.Gb_CalibMethod.Size = new System.Drawing.Size(355, 181);
            this.Gb_CalibMethod.TabIndex = 1;
            this.Gb_CalibMethod.TabStop = false;
            this.Gb_CalibMethod.Text = "标定方式";
            // 
            // Rbtn_MultiCamera_Length
            // 
            this.Rbtn_MultiCamera_Length.AutoSize = true;
            this.Rbtn_MultiCamera_Length.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rbtn_MultiCamera_Length.Location = new System.Drawing.Point(208, 149);
            this.Rbtn_MultiCamera_Length.Name = "Rbtn_MultiCamera_Length";
            this.Rbtn_MultiCamera_Length.Size = new System.Drawing.Size(109, 21);
            this.Rbtn_MultiCamera_Length.TabIndex = 5;
            this.Rbtn_MultiCamera_Length.TabStop = true;
            this.Rbtn_MultiCamera_Length.Text = "多相机（定长）";
            this.Rbtn_MultiCamera_Length.UseVisualStyleBackColor = true;
            // 
            // Rbtn_MultiCamera_Board
            // 
            this.Rbtn_MultiCamera_Board.AutoSize = true;
            this.Rbtn_MultiCamera_Board.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rbtn_MultiCamera_Board.Location = new System.Drawing.Point(18, 149);
            this.Rbtn_MultiCamera_Board.Name = "Rbtn_MultiCamera_Board";
            this.Rbtn_MultiCamera_Board.Size = new System.Drawing.Size(121, 21);
            this.Rbtn_MultiCamera_Board.TabIndex = 4;
            this.Rbtn_MultiCamera_Board.TabStop = true;
            this.Rbtn_MultiCamera_Board.Text = "多相机（标定板）";
            this.Rbtn_MultiCamera_Board.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Distortion
            // 
            this.Rbtn_Distortion.AutoSize = true;
            this.Rbtn_Distortion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rbtn_Distortion.Location = new System.Drawing.Point(208, 91);
            this.Rbtn_Distortion.Name = "Rbtn_Distortion";
            this.Rbtn_Distortion.Size = new System.Drawing.Size(73, 21);
            this.Rbtn_Distortion.TabIndex = 3;
            this.Rbtn_Distortion.TabStop = true;
            this.Rbtn_Distortion.Text = "畸变标定";
            this.Rbtn_Distortion.UseVisualStyleBackColor = true;
            // 
            // Rbtn_RotationCenter
            // 
            this.Rbtn_RotationCenter.AutoSize = true;
            this.Rbtn_RotationCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rbtn_RotationCenter.Location = new System.Drawing.Point(18, 91);
            this.Rbtn_RotationCenter.Name = "Rbtn_RotationCenter";
            this.Rbtn_RotationCenter.Size = new System.Drawing.Size(97, 21);
            this.Rbtn_RotationCenter.TabIndex = 2;
            this.Rbtn_RotationCenter.TabStop = true;
            this.Rbtn_RotationCenter.Text = "旋转中心标定";
            this.Rbtn_RotationCenter.UseVisualStyleBackColor = true;
            // 
            // Rbtn_PointDistance
            // 
            this.Rbtn_PointDistance.AutoSize = true;
            this.Rbtn_PointDistance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rbtn_PointDistance.Location = new System.Drawing.Point(208, 33);
            this.Rbtn_PointDistance.Name = "Rbtn_PointDistance";
            this.Rbtn_PointDistance.Size = new System.Drawing.Size(85, 21);
            this.Rbtn_PointDistance.TabIndex = 1;
            this.Rbtn_PointDistance.TabStop = true;
            this.Rbtn_PointDistance.Text = "点距离标定";
            this.Rbtn_PointDistance.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Hand_Eye
            // 
            this.Rbtn_Hand_Eye.AutoSize = true;
            this.Rbtn_Hand_Eye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rbtn_Hand_Eye.Location = new System.Drawing.Point(18, 33);
            this.Rbtn_Hand_Eye.Name = "Rbtn_Hand_Eye";
            this.Rbtn_Hand_Eye.Size = new System.Drawing.Size(73, 21);
            this.Rbtn_Hand_Eye.TabIndex = 0;
            this.Rbtn_Hand_Eye.TabStop = true;
            this.Rbtn_Hand_Eye.Text = "手眼标定";
            this.Rbtn_Hand_Eye.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(294, 317);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.Btn_Cancel.TabIndex = 4;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(200, 317);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 28);
            this.Btn_OK.TabIndex = 3;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "标定方案名称：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "标定结果名称：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txt_CalibProjectName
            // 
            this.Txt_CalibProjectName.Location = new System.Drawing.Point(129, 225);
            this.Txt_CalibProjectName.Multiline = true;
            this.Txt_CalibProjectName.Name = "Txt_CalibProjectName";
            this.Txt_CalibProjectName.Size = new System.Drawing.Size(181, 25);
            this.Txt_CalibProjectName.TabIndex = 7;
            // 
            // Txt_CalibResultName
            // 
            this.Txt_CalibResultName.Location = new System.Drawing.Point(131, 267);
            this.Txt_CalibResultName.Multiline = true;
            this.Txt_CalibResultName.Name = "Txt_CalibResultName";
            this.Txt_CalibResultName.Size = new System.Drawing.Size(179, 25);
            this.Txt_CalibResultName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(316, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = ".cal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(316, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = ".ini";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmNewCalib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(370, 349);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_CalibResultName);
            this.Controls.Add(this.Txt_CalibProjectName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Gb_CalibMethod);
            this.MaxVisible = false;
            this.Name = "FrmNewCalib";
            this.Text = "新建标定";
            this.TitleVisiable = false;
            this.Controls.SetChildIndex(this.Gb_CalibMethod, 0);
            this.Controls.SetChildIndex(this.Btn_OK, 0);
            this.Controls.SetChildIndex(this.Btn_Cancel, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Txt_CalibProjectName, 0);
            this.Controls.SetChildIndex(this.Txt_CalibResultName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Gb_CalibMethod.ResumeLayout(false);
            this.Gb_CalibMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_CalibMethod;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.RadioButton Rbtn_MultiCamera_Length;
        private System.Windows.Forms.RadioButton Rbtn_MultiCamera_Board;
        private System.Windows.Forms.RadioButton Rbtn_Distortion;
        private System.Windows.Forms.RadioButton Rbtn_RotationCenter;
        private System.Windows.Forms.RadioButton Rbtn_PointDistance;
        private System.Windows.Forms.RadioButton Rbtn_Hand_Eye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_CalibProjectName;
        private System.Windows.Forms.TextBox Txt_CalibResultName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}