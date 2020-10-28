namespace DispenseAPP.Tools_MotionControl
{
    partial class UC_MotionControl_Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MotionControl_Tools));
            this.Lbl_LaserMeasureHeight = new System.Windows.Forms.Label();
            this.Lbl_PathProgram = new System.Windows.Forms.Label();
            this.Lbl_MeasureGlueWeight = new System.Windows.Forms.Label();
            this.Lbl_AutoCalibNeedle = new System.Windows.Forms.Label();
            this.Lbl_MachineMeasureHeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_LaserMeasureHeight
            // 
            this.Lbl_LaserMeasureHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_LaserMeasureHeight.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_LaserMeasureHeight.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_LaserMeasureHeight.Image")));
            this.Lbl_LaserMeasureHeight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_LaserMeasureHeight.Location = new System.Drawing.Point(0, 96);
            this.Lbl_LaserMeasureHeight.Name = "Lbl_LaserMeasureHeight";
            this.Lbl_LaserMeasureHeight.Size = new System.Drawing.Size(330, 32);
            this.Lbl_LaserMeasureHeight.TabIndex = 14;
            this.Lbl_LaserMeasureHeight.Text = "          激光测高";
            this.Lbl_LaserMeasureHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_LaserMeasureHeight.Click += new System.EventHandler(this.Lbl_LaserMeasureHeight_Click);
            // 
            // Lbl_PathProgram
            // 
            this.Lbl_PathProgram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_PathProgram.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_PathProgram.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_PathProgram.Image")));
            this.Lbl_PathProgram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_PathProgram.Location = new System.Drawing.Point(0, 64);
            this.Lbl_PathProgram.Name = "Lbl_PathProgram";
            this.Lbl_PathProgram.Size = new System.Drawing.Size(330, 32);
            this.Lbl_PathProgram.TabIndex = 13;
            this.Lbl_PathProgram.Text = "          点胶轨迹设置";
            this.Lbl_PathProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_PathProgram.Click += new System.EventHandler(this.Lbl_DispensePathProgramming_Click);
            // 
            // Lbl_MeasureGlueWeight
            // 
            this.Lbl_MeasureGlueWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_MeasureGlueWeight.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_MeasureGlueWeight.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_MeasureGlueWeight.Image")));
            this.Lbl_MeasureGlueWeight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_MeasureGlueWeight.Location = new System.Drawing.Point(0, 32);
            this.Lbl_MeasureGlueWeight.Name = "Lbl_MeasureGlueWeight";
            this.Lbl_MeasureGlueWeight.Size = new System.Drawing.Size(330, 32);
            this.Lbl_MeasureGlueWeight.TabIndex = 12;
            this.Lbl_MeasureGlueWeight.Text = "          胶重计量";
            this.Lbl_MeasureGlueWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_MeasureGlueWeight.Click += new System.EventHandler(this.Lbl_MeasureGlueWeight_Click);
            // 
            // Lbl_AutoCalibNeedle
            // 
            this.Lbl_AutoCalibNeedle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_AutoCalibNeedle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_AutoCalibNeedle.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_AutoCalibNeedle.Image")));
            this.Lbl_AutoCalibNeedle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_AutoCalibNeedle.Location = new System.Drawing.Point(0, 0);
            this.Lbl_AutoCalibNeedle.Name = "Lbl_AutoCalibNeedle";
            this.Lbl_AutoCalibNeedle.Size = new System.Drawing.Size(330, 32);
            this.Lbl_AutoCalibNeedle.TabIndex = 11;
            this.Lbl_AutoCalibNeedle.Text = "          自动对针";
            this.Lbl_AutoCalibNeedle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_AutoCalibNeedle.Click += new System.EventHandler(this.Lbl_AutoCalibNeedle_Click);
            // 
            // Lbl_MachineMeasureHeight
            // 
            this.Lbl_MachineMeasureHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_MachineMeasureHeight.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_MachineMeasureHeight.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_MachineMeasureHeight.Image")));
            this.Lbl_MachineMeasureHeight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_MachineMeasureHeight.Location = new System.Drawing.Point(0, 128);
            this.Lbl_MachineMeasureHeight.Name = "Lbl_MachineMeasureHeight";
            this.Lbl_MachineMeasureHeight.Size = new System.Drawing.Size(330, 32);
            this.Lbl_MachineMeasureHeight.TabIndex = 15;
            this.Lbl_MachineMeasureHeight.Text = "          机械测高";
            this.Lbl_MachineMeasureHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_MachineMeasureHeight.Click += new System.EventHandler(this.Lbl_MachineMeasureHeight_Click);
            // 
            // UC_MotionControl_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Lbl_MachineMeasureHeight);
            this.Controls.Add(this.Lbl_LaserMeasureHeight);
            this.Controls.Add(this.Lbl_PathProgram);
            this.Controls.Add(this.Lbl_MeasureGlueWeight);
            this.Controls.Add(this.Lbl_AutoCalibNeedle);
            this.Name = "UC_MotionControl_Tools";
            this.Size = new System.Drawing.Size(330, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_LaserMeasureHeight;
        private System.Windows.Forms.Label Lbl_PathProgram;
        private System.Windows.Forms.Label Lbl_MeasureGlueWeight;
        private System.Windows.Forms.Label Lbl_AutoCalibNeedle;
        private System.Windows.Forms.Label Lbl_MachineMeasureHeight;
    }
}
