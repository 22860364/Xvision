namespace DispenseAPP
{
    partial class FrmRun
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
            this.TLPanel_Window = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // TLPanel_Window
            // 
            this.TLPanel_Window.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1298F));
            this.TLPanel_Window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPanel_Window.Location = new System.Drawing.Point(0, 0);
            this.TLPanel_Window.Name = "TLPanel_Window";
            this.TLPanel_Window.Size = new System.Drawing.Size(1298, 617);
            this.TLPanel_Window.TabIndex = 0;
            // 
            // FrmRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1298, 617);
            this.Controls.Add(this.TLPanel_Window);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRun";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPanel_Window;
    }
}