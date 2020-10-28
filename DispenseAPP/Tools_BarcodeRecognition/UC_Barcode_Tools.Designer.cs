namespace DispenseAPP.Tools_BarcodeRecognition
{
    partial class UC_Barcode_Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Barcode_Tools));
            this.lbl_Classifier = new System.Windows.Forms.Label();
            this.lbl_OCR = new System.Windows.Forms.Label();
            this.lbl_Barcode = new System.Windows.Forms.Label();
            this.lbl_QRCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Classifier
            // 
            this.lbl_Classifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Classifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Classifier.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Classifier.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Classifier.Image")));
            this.lbl_Classifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Classifier.Location = new System.Drawing.Point(0, 96);
            this.lbl_Classifier.Name = "lbl_Classifier";
            this.lbl_Classifier.Size = new System.Drawing.Size(330, 32);
            this.lbl_Classifier.TabIndex = 2;
            this.lbl_Classifier.Text = "          分类器";
            this.lbl_Classifier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Classifier.Click += new System.EventHandler(this.lbl_Classifier_Click);
            // 
            // lbl_OCR
            // 
            this.lbl_OCR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_OCR.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_OCR.Image = ((System.Drawing.Image)(resources.GetObject("lbl_OCR.Image")));
            this.lbl_OCR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_OCR.Location = new System.Drawing.Point(0, 0);
            this.lbl_OCR.Name = "lbl_OCR";
            this.lbl_OCR.Size = new System.Drawing.Size(330, 32);
            this.lbl_OCR.TabIndex = 3;
            this.lbl_OCR.Text = "          OCR字符识别";
            this.lbl_OCR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_OCR.Click += new System.EventHandler(this.lbl_OCR_Click);
            // 
            // lbl_Barcode
            // 
            this.lbl_Barcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Barcode.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Barcode.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Barcode.Image")));
            this.lbl_Barcode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Barcode.Location = new System.Drawing.Point(0, 32);
            this.lbl_Barcode.Name = "lbl_Barcode";
            this.lbl_Barcode.Size = new System.Drawing.Size(330, 32);
            this.lbl_Barcode.TabIndex = 4;
            this.lbl_Barcode.Text = "          条形码识别";
            this.lbl_Barcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Barcode.Click += new System.EventHandler(this.lbl_Barcode_Click);
            // 
            // lbl_QRCode
            // 
            this.lbl_QRCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_QRCode.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_QRCode.Image = ((System.Drawing.Image)(resources.GetObject("lbl_QRCode.Image")));
            this.lbl_QRCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_QRCode.Location = new System.Drawing.Point(0, 64);
            this.lbl_QRCode.Name = "lbl_QRCode";
            this.lbl_QRCode.Size = new System.Drawing.Size(330, 32);
            this.lbl_QRCode.TabIndex = 5;
            this.lbl_QRCode.Text = "          二维码识别";
            this.lbl_QRCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_QRCode.Click += new System.EventHandler(this.lbl_QRCode_Click);
            // 
            // UC_Barcode_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_QRCode);
            this.Controls.Add(this.lbl_Barcode);
            this.Controls.Add(this.lbl_OCR);
            this.Controls.Add(this.lbl_Classifier);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UC_Barcode_Tools";
            this.Size = new System.Drawing.Size(330, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Classifier;
        private System.Windows.Forms.Label lbl_OCR;
        private System.Windows.Forms.Label lbl_Barcode;
        private System.Windows.Forms.Label lbl_QRCode;
    }
}
