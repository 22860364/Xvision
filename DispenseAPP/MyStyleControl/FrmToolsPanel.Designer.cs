namespace DispenseAPP.MyStyleControl
{
    partial class FrmToolsPanel
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
            this.Panel_Tools = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Panel_Tools
            // 
            this.Panel_Tools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Tools.Location = new System.Drawing.Point(1, 26);
            this.Panel_Tools.Name = "Panel_Tools";
            this.Panel_Tools.Size = new System.Drawing.Size(365, 402);
            this.Panel_Tools.TabIndex = 1;
            // 
            // FrmToolsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(367, 429);
            this.Controls.Add(this.Panel_Tools);
            this.Name = "FrmToolsPanel";
            this.Text = "未知";
            this.Controls.SetChildIndex(this.Panel_Tools, 0);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel Panel_Tools;
    }
}