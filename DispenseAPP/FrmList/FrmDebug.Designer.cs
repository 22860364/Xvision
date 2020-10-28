namespace DispenseAPP
{
    partial class FrmDebug
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
            this.panel_Image = new System.Windows.Forms.Panel();
            this.UC_Image_Debug = new DispenseAPP.UC_Image();
            this.panel_Image.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Image
            // 
            this.panel_Image.Controls.Add(this.UC_Image_Debug);
            this.panel_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Image.Location = new System.Drawing.Point(0, 0);
            this.panel_Image.Name = "panel_Image";
            this.panel_Image.Size = new System.Drawing.Size(966, 617);
            this.panel_Image.TabIndex = 3;
            // 
            // UC_Image_Debug
            // 
            this.UC_Image_Debug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_Image_Debug.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UC_Image_Debug.Location = new System.Drawing.Point(0, 0);
            this.UC_Image_Debug.Name = "UC_Image_Debug";
            this.UC_Image_Debug.Size = new System.Drawing.Size(966, 617);
            this.UC_Image_Debug.TabIndex = 0;
            // 
            // FrmDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(966, 617);
            this.Controls.Add(this.panel_Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDebug";
            this.Text = "FrmImage";
            this.panel_Image.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Image;
        private UC_Image UC_Image_Debug;
    }
}