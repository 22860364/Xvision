namespace DispenseAPP.Tools_Location.ContourMatching
{
    partial class FrmEditTemplate
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
            this.UC_Image = new DispenseAPP.UC_Image();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.Location = new System.Drawing.Point(3, 1);
            this.lbl_ProjectName.Size = new System.Drawing.Size(74, 21);
            this.lbl_ProjectName.Text = "编辑模板";
            // 
            // UC_Image
            // 
            this.UC_Image.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UC_Image.Location = new System.Drawing.Point(8, 32);
            this.UC_Image.Name = "UC_Image";
            this.UC_Image.Size = new System.Drawing.Size(371, 359);
            this.UC_Image.TabIndex = 1;
            // 
            // FrmEditTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(653, 399);
            this.Controls.Add(this.UC_Image);
            this.DoubleBuffered = true;
            this.Name = "FrmEditTemplate";
            this.Text = "编辑模板";
            this.TitleVisiable = false;
            this.Controls.SetChildIndex(this.UC_Image, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Image UC_Image;
    }
}