namespace DispenseAPP.CustomControl
{
    partial class FormM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormM));
            this.panel_Title = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btnM_Min = new DispenseAPP.CustomControl.ButtonM();
            this.btnM_Max = new DispenseAPP.CustomControl.ButtonM();
            this.btnM_Close = new DispenseAPP.CustomControl.ButtonM();
            this.lbl_ProjectName = new System.Windows.Forms.Label();
            this.panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.panel_Title.Controls.Add(this.lbl_Title);
            this.panel_Title.Controls.Add(this.btnM_Min);
            this.panel_Title.Controls.Add(this.btnM_Max);
            this.panel_Title.Controls.Add(this.btnM_Close);
            this.panel_Title.Controls.Add(this.lbl_ProjectName);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(1, 1);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1136, 25);
            this.panel_Title.TabIndex = 0;
            this.panel_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Title.Location = new System.Drawing.Point(3, 1);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(92, 20);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "SecondVM -";
            // 
            // btnM_Min
            // 
            this.btnM_Min.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnM_Min.AutoSize = true;
            this.btnM_Min.BackColor = System.Drawing.Color.Transparent;
            this.btnM_Min.BackColorLeave = System.Drawing.Color.Transparent;
            this.btnM_Min.BackColorM = System.Drawing.Color.Transparent;
            this.btnM_Min.BackColorMove = System.Drawing.Color.Transparent;
            this.btnM_Min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnM_Min.FontM = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnM_Min.ImageDefault = ((System.Drawing.Image)(resources.GetObject("btnM_Min.ImageDefault")));
            this.btnM_Min.ImageLeave = ((System.Drawing.Image)(resources.GetObject("btnM_Min.ImageLeave")));
            this.btnM_Min.ImageMove = ((System.Drawing.Image)(resources.GetObject("btnM_Min.ImageMove")));
            this.btnM_Min.Location = new System.Drawing.Point(1037, 1);
            this.btnM_Min.Name = "btnM_Min";
            this.btnM_Min.Size = new System.Drawing.Size(22, 22);
            this.btnM_Min.TabIndex = 2;
            this.btnM_Min.TextColor = System.Drawing.Color.Black;
            this.btnM_Min.TextM = "";
            this.btnM_Min.ButtonClick += new System.EventHandler(this.BtnM_Min_ButtonClick);
            // 
            // btnM_Max
            // 
            this.btnM_Max.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnM_Max.AutoSize = true;
            this.btnM_Max.BackColor = System.Drawing.Color.Transparent;
            this.btnM_Max.BackColorLeave = System.Drawing.Color.Transparent;
            this.btnM_Max.BackColorM = System.Drawing.Color.Transparent;
            this.btnM_Max.BackColorMove = System.Drawing.Color.Transparent;
            this.btnM_Max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnM_Max.FontM = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnM_Max.ImageDefault = ((System.Drawing.Image)(resources.GetObject("btnM_Max.ImageDefault")));
            this.btnM_Max.ImageLeave = ((System.Drawing.Image)(resources.GetObject("btnM_Max.ImageLeave")));
            this.btnM_Max.ImageMove = ((System.Drawing.Image)(resources.GetObject("btnM_Max.ImageMove")));
            this.btnM_Max.Location = new System.Drawing.Point(1071, 1);
            this.btnM_Max.Name = "btnM_Max";
            this.btnM_Max.Size = new System.Drawing.Size(22, 22);
            this.btnM_Max.TabIndex = 3;
            this.btnM_Max.TextColor = System.Drawing.Color.Black;
            this.btnM_Max.TextM = "";
            this.btnM_Max.ButtonClick += new System.EventHandler(this.btnM_Max_ButtonClick);
            // 
            // btnM_Close
            // 
            this.btnM_Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnM_Close.AutoSize = true;
            this.btnM_Close.BackColor = System.Drawing.Color.Transparent;
            this.btnM_Close.BackColorLeave = System.Drawing.Color.Transparent;
            this.btnM_Close.BackColorM = System.Drawing.Color.Transparent;
            this.btnM_Close.BackColorMove = System.Drawing.Color.Transparent;
            this.btnM_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnM_Close.FontM = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnM_Close.ImageDefault = ((System.Drawing.Image)(resources.GetObject("btnM_Close.ImageDefault")));
            this.btnM_Close.ImageLeave = ((System.Drawing.Image)(resources.GetObject("btnM_Close.ImageLeave")));
            this.btnM_Close.ImageMove = ((System.Drawing.Image)(resources.GetObject("btnM_Close.ImageMove")));
            this.btnM_Close.Location = new System.Drawing.Point(1105, 1);
            this.btnM_Close.Name = "btnM_Close";
            this.btnM_Close.Size = new System.Drawing.Size(22, 22);
            this.btnM_Close.TabIndex = 1;
            this.btnM_Close.TextColor = System.Drawing.Color.Black;
            this.btnM_Close.TextM = "";
            this.btnM_Close.ButtonClick += new System.EventHandler(this.btnM_Close_ButtonClick);
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.AutoSize = true;
            this.lbl_ProjectName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ProjectName.ForeColor = System.Drawing.Color.Black;
            this.lbl_ProjectName.Location = new System.Drawing.Point(101, 1);
            this.lbl_ProjectName.Name = "lbl_ProjectName";
            this.lbl_ProjectName.Size = new System.Drawing.Size(38, 20);
            this.lbl_ProjectName.TabIndex = 0;
            this.lbl_ProjectName.Text = "Title";
            this.lbl_ProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1138, 575);
            this.Controls.Add(this.panel_Title);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormM";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel panel_Title;
        private ButtonM btnM_Min;
        private ButtonM btnM_Max;
        private ButtonM btnM_Close;
        protected System.Windows.Forms.Label lbl_ProjectName;
        private System.Windows.Forms.Label lbl_Title;
    }
}