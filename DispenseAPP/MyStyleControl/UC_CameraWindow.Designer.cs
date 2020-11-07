namespace DispenseAPP.MyStyleControl
{
    partial class UC_CameraWindow
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CameraWindow));
            this.Ts = new System.Windows.Forms.ToolStrip();
            this.Tscmb_Camera = new System.Windows.Forms.ToolStripComboBox();
            this.Tss_AvailableCamera = new System.Windows.Forms.ToolStripSeparator();
            this.Tsbtn_ImageAdaptation = new System.Windows.Forms.ToolStripButton();
            this.Tss_ImageAdaption = new System.Windows.Forms.ToolStripSeparator();
            this.Tsbtn_SingleAcq = new System.Windows.Forms.ToolStripButton();
            this.Tss_SingleAcq = new System.Windows.Forms.ToolStripSeparator();
            this.Tsbtn_ContinueAcq = new System.Windows.Forms.ToolStripButton();
            this.Tss_ContinueAcq = new System.Windows.Forms.ToolStripSeparator();
            this.Tsbtn_DrawRectangle = new System.Windows.Forms.ToolStripButton();
            this.Tss_DrawRectangle = new System.Windows.Forms.ToolStripSeparator();
            this.Tsbtn_DrawRectangle2 = new System.Windows.Forms.ToolStripButton();
            this.Tss_DrawRectangle2 = new System.Windows.Forms.ToolStripSeparator();
            this.Tsbtn_DrawAnnular = new System.Windows.Forms.ToolStripButton();
            this.uC_MyWindow1 = new VisionWindow.UC_MyWindow();
            this.Ts.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ts
            // 
            this.Ts.AutoSize = false;
            this.Ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tscmb_Camera,
            this.Tss_AvailableCamera,
            this.Tsbtn_ImageAdaptation,
            this.Tss_ImageAdaption,
            this.Tsbtn_SingleAcq,
            this.Tss_SingleAcq,
            this.Tsbtn_ContinueAcq,
            this.Tss_ContinueAcq,
            this.Tsbtn_DrawRectangle,
            this.Tss_DrawRectangle,
            this.Tsbtn_DrawRectangle2,
            this.Tss_DrawRectangle2,
            this.Tsbtn_DrawAnnular});
            this.Ts.Location = new System.Drawing.Point(0, 0);
            this.Ts.Name = "Ts";
            this.Ts.Size = new System.Drawing.Size(684, 23);
            this.Ts.TabIndex = 13;
            this.Ts.Text = "toolStrip1";
            // 
            // Tscmb_Camera
            // 
            this.Tscmb_Camera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tscmb_Camera.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tscmb_Camera.Name = "Tscmb_Camera";
            this.Tscmb_Camera.Size = new System.Drawing.Size(121, 23);
            this.Tscmb_Camera.SelectedIndexChanged += new System.EventHandler(this.Tscmb_Camera_SelectedIndexChanged);
            // 
            // Tss_AvailableCamera
            // 
            this.Tss_AvailableCamera.Name = "Tss_AvailableCamera";
            this.Tss_AvailableCamera.Size = new System.Drawing.Size(6, 23);
            // 
            // Tsbtn_ImageAdaptation
            // 
            this.Tsbtn_ImageAdaptation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsbtn_ImageAdaptation.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_ImageAdaptation.Image")));
            this.Tsbtn_ImageAdaptation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_ImageAdaptation.Name = "Tsbtn_ImageAdaptation";
            this.Tsbtn_ImageAdaptation.Size = new System.Drawing.Size(72, 20);
            this.Tsbtn_ImageAdaptation.Text = "图像自适应";
            this.Tsbtn_ImageAdaptation.Click += new System.EventHandler(this.Tsbtn_ImageAdaptation_Click);
            // 
            // Tss_ImageAdaption
            // 
            this.Tss_ImageAdaption.Name = "Tss_ImageAdaption";
            this.Tss_ImageAdaption.Size = new System.Drawing.Size(6, 23);
            // 
            // Tsbtn_SingleAcq
            // 
            this.Tsbtn_SingleAcq.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsbtn_SingleAcq.Enabled = false;
            this.Tsbtn_SingleAcq.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_SingleAcq.Image")));
            this.Tsbtn_SingleAcq.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_SingleAcq.Name = "Tsbtn_SingleAcq";
            this.Tsbtn_SingleAcq.Size = new System.Drawing.Size(60, 20);
            this.Tsbtn_SingleAcq.Text = "单帧采集";
            this.Tsbtn_SingleAcq.Click += new System.EventHandler(this.Tsbtn_SingleAcq_Click);
            // 
            // Tss_SingleAcq
            // 
            this.Tss_SingleAcq.Name = "Tss_SingleAcq";
            this.Tss_SingleAcq.Size = new System.Drawing.Size(6, 23);
            // 
            // Tsbtn_ContinueAcq
            // 
            this.Tsbtn_ContinueAcq.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsbtn_ContinueAcq.Enabled = false;
            this.Tsbtn_ContinueAcq.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_ContinueAcq.Image")));
            this.Tsbtn_ContinueAcq.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_ContinueAcq.Name = "Tsbtn_ContinueAcq";
            this.Tsbtn_ContinueAcq.Size = new System.Drawing.Size(60, 20);
            this.Tsbtn_ContinueAcq.Text = "实时采集";
            this.Tsbtn_ContinueAcq.Click += new System.EventHandler(this.Tsbtn_ContinueAcq_Click);
            // 
            // Tss_ContinueAcq
            // 
            this.Tss_ContinueAcq.Name = "Tss_ContinueAcq";
            this.Tss_ContinueAcq.Size = new System.Drawing.Size(6, 23);
            // 
            // Tsbtn_DrawRectangle
            // 
            this.Tsbtn_DrawRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsbtn_DrawRectangle.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_DrawRectangle.Image")));
            this.Tsbtn_DrawRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_DrawRectangle.Name = "Tsbtn_DrawRectangle";
            this.Tsbtn_DrawRectangle.Size = new System.Drawing.Size(48, 20);
            this.Tsbtn_DrawRectangle.Text = "画矩形";
            this.Tsbtn_DrawRectangle.Click += new System.EventHandler(this.Tsbtn_DrawRectangle_Click);
            // 
            // Tss_DrawRectangle
            // 
            this.Tss_DrawRectangle.Name = "Tss_DrawRectangle";
            this.Tss_DrawRectangle.Size = new System.Drawing.Size(6, 23);
            // 
            // Tsbtn_DrawRectangle2
            // 
            this.Tsbtn_DrawRectangle2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsbtn_DrawRectangle2.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_DrawRectangle2.Image")));
            this.Tsbtn_DrawRectangle2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_DrawRectangle2.Name = "Tsbtn_DrawRectangle2";
            this.Tsbtn_DrawRectangle2.Size = new System.Drawing.Size(55, 20);
            this.Tsbtn_DrawRectangle2.Text = "画矩形2";
            this.Tsbtn_DrawRectangle2.Click += new System.EventHandler(this.Tsbtn_DrawRectangle2_Click);
            // 
            // Tss_DrawRectangle2
            // 
            this.Tss_DrawRectangle2.Name = "Tss_DrawRectangle2";
            this.Tss_DrawRectangle2.Size = new System.Drawing.Size(6, 23);
            // 
            // Tsbtn_DrawAnnular
            // 
            this.Tsbtn_DrawAnnular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsbtn_DrawAnnular.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_DrawAnnular.Image")));
            this.Tsbtn_DrawAnnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_DrawAnnular.Name = "Tsbtn_DrawAnnular";
            this.Tsbtn_DrawAnnular.Size = new System.Drawing.Size(48, 20);
            this.Tsbtn_DrawAnnular.Text = "画环形";
            // 
            // uC_MyWindow1
            // 
            this.uC_MyWindow1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_MyWindow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.uC_MyWindow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_MyWindow1.Cursor = System.Windows.Forms.Cursors.Default;
            this.uC_MyWindow1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uC_MyWindow1.Location = new System.Drawing.Point(-1, 26);
            this.uC_MyWindow1.Name = "uC_MyWindow1";
            this.uC_MyWindow1.Size = new System.Drawing.Size(686, 416);
            this.uC_MyWindow1.TabIndex = 14;
            // 
            // UC_CameraWindow
            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Load += UC_CameraWindow_Load;
            this.Controls.Add(this.uC_MyWindow1);
            this.Controls.Add(this.Ts);
            this.Name = "UC_CameraWindow";
            this.Size = new System.Drawing.Size(684, 441);
            this.Ts.ResumeLayout(false);
            this.Ts.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.ToolStrip Ts;
        private System.Windows.Forms.ToolStripComboBox Tscmb_Camera;
        private System.Windows.Forms.ToolStripSeparator Tss_AvailableCamera;
        private System.Windows.Forms.ToolStripButton Tsbtn_ImageAdaptation;
        private System.Windows.Forms.ToolStripSeparator Tss_ImageAdaption;
        private System.Windows.Forms.ToolStripButton Tsbtn_SingleAcq;
        private System.Windows.Forms.ToolStripSeparator Tss_SingleAcq;
        private System.Windows.Forms.ToolStripButton Tsbtn_ContinueAcq;
        private System.Windows.Forms.ToolStripSeparator Tss_ContinueAcq;
        private System.Windows.Forms.ToolStripButton Tsbtn_DrawRectangle;
        private System.Windows.Forms.ToolStripSeparator Tss_DrawRectangle;
        private System.Windows.Forms.ToolStripButton Tsbtn_DrawRectangle2;
        private System.Windows.Forms.ToolStripSeparator Tss_DrawRectangle2;
        private System.Windows.Forms.ToolStripButton Tsbtn_DrawAnnular;
        private VisionWindow.UC_MyWindow uC_MyWindow1;
    }
}
