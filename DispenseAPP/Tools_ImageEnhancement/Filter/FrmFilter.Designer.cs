namespace DispenseAPP.Tools_ImageEnhancement.Filter
{
    partial class FrmFilter
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
            this.uC_DrawComponent1 = new DispenseAPP.MyStyleControl.UC_DrawComponent();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(102, 28);
            this.lbl_Title.Text = "FrmFilter";
            // 
            // uC_DrawComponent1
            // 
            this.uC_DrawComponent1.Location = new System.Drawing.Point(6, 47);
            this.uC_DrawComponent1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_DrawComponent1.Name = "uC_DrawComponent1";
            this.uC_DrawComponent1.Size = new System.Drawing.Size(1057, 56);
            this.uC_DrawComponent1.TabIndex = 4;
            // 
            // FrmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 995);
            this.Controls.Add(this.uC_DrawComponent1);
            this.Name = "FrmFilter";
            this.Text = "FrmFilter";
            this.Controls.SetChildIndex(this.uC_DrawComponent1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private MyStyleControl.UC_DrawComponent uC_DrawComponent1;
    }
}