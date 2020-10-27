namespace DispenseAPP.Tools_Measure
{
    partial class UC_Measure_Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Measure_Tools));
            this.Lbl_GeometricalRelation = new System.Windows.Forms.Label();
            this.Lbl_CaliperMeasure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_GeometricalRelation
            // 
            this.Lbl_GeometricalRelation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_GeometricalRelation.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_GeometricalRelation.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_GeometricalRelation.Image")));
            this.Lbl_GeometricalRelation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_GeometricalRelation.Location = new System.Drawing.Point(0, 0);
            this.Lbl_GeometricalRelation.Name = "Lbl_GeometricalRelation";
            this.Lbl_GeometricalRelation.Size = new System.Drawing.Size(330, 32);
            this.Lbl_GeometricalRelation.TabIndex = 2;
            this.Lbl_GeometricalRelation.Text = "          几何关系";
            this.Lbl_GeometricalRelation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_GeometricalRelation.Click += new System.EventHandler(this.Lbl_GeometricalRelation_Click);
            // 
            // Lbl_CaliperMeasure
            // 
            this.Lbl_CaliperMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_CaliperMeasure.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_CaliperMeasure.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_CaliperMeasure.Image")));
            this.Lbl_CaliperMeasure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_CaliperMeasure.Location = new System.Drawing.Point(0, 32);
            this.Lbl_CaliperMeasure.Name = "Lbl_CaliperMeasure";
            this.Lbl_CaliperMeasure.Size = new System.Drawing.Size(330, 32);
            this.Lbl_CaliperMeasure.TabIndex = 3;
            this.Lbl_CaliperMeasure.Text = "          卡尺测量";
            this.Lbl_CaliperMeasure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_CaliperMeasure.Click += new System.EventHandler(this.Lbl_CaliperMeasure_Click);
            // 
            // UC_Measure_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Lbl_CaliperMeasure);
            this.Controls.Add(this.Lbl_GeometricalRelation);
            this.Name = "UC_Measure_Tools";
            this.Size = new System.Drawing.Size(330, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_GeometricalRelation;
        private System.Windows.Forms.Label Lbl_CaliperMeasure;
    }
}
