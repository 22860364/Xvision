namespace DispenseAPP.Tools_ImageIO.AcqSet
{
    partial class AcqSetToolControl
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
            this.btnStopAcq = new System.Windows.Forms.Button();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnContinueAcq = new System.Windows.Forms.Button();
            this.btnSingleAcq = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlParam = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDelayTime = new System.Windows.Forms.NumericUpDown();
            this.chkDelayTime = new System.Windows.Forms.CheckBox();
            this.nudExposureTime = new System.Windows.Forms.NumericUpDown();
            this.trbExposureTime = new System.Windows.Forms.TrackBar();
            this.chkExposureTime = new System.Windows.Forms.CheckBox();
            this.tpBasic.SuspendLayout();
            this.pnlBasic.SuspendLayout();
            this.TcTool.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExposureTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbExposureTime)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBasic
            // 
            this.pnlBasic.Controls.Add(this.btnStopAcq);
            this.pnlBasic.Controls.Add(this.cmbCamera);
            this.pnlBasic.Controls.Add(this.label2);
            this.pnlBasic.Controls.Add(this.btnContinueAcq);
            this.pnlBasic.Controls.Add(this.btnSingleAcq);
            this.pnlBasic.Controls.SetChildIndex(this.txtName, 0);
            this.pnlBasic.Controls.SetChildIndex(this.btnSingleAcq, 0);
            this.pnlBasic.Controls.SetChildIndex(this.btnContinueAcq, 0);
            this.pnlBasic.Controls.SetChildIndex(this.label2, 0);
            this.pnlBasic.Controls.SetChildIndex(this.cmbCamera, 0);
            this.pnlBasic.Controls.SetChildIndex(this.btnStopAcq, 0);
            // 
            // Tc_AcqSet
            // 
            this.TcTool.Controls.Add(this.tabPage1);
            this.TcTool.Controls.SetChildIndex(this.tabPage1, 0);
            this.TcTool.Controls.SetChildIndex(this.tpBasic, 0);
            // 
            // btnStopAcq
            // 
            this.btnStopAcq.Enabled = false;
            this.btnStopAcq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopAcq.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStopAcq.Location = new System.Drawing.Point(219, 101);
            this.btnStopAcq.Name = "btnStopAcq";
            this.btnStopAcq.Size = new System.Drawing.Size(75, 28);
            this.btnStopAcq.TabIndex = 22;
            this.btnStopAcq.Text = "停止采集";
            this.btnStopAcq.UseVisualStyleBackColor = true;
            this.btnStopAcq.Click += new System.EventHandler(this.BtnStopAcq_Click);
            // 
            // cmbCamera
            // 
            this.cmbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Location = new System.Drawing.Point(72, 56);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(190, 25);
            this.cmbCamera.TabIndex = 21;
            this.cmbCamera.SelectedIndexChanged += new System.EventHandler(this.CmbCamera_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "相机";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnContinueAcq
            // 
            this.btnContinueAcq.Enabled = false;
            this.btnContinueAcq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinueAcq.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnContinueAcq.Location = new System.Drawing.Point(118, 101);
            this.btnContinueAcq.Name = "btnContinueAcq";
            this.btnContinueAcq.Size = new System.Drawing.Size(75, 28);
            this.btnContinueAcq.TabIndex = 19;
            this.btnContinueAcq.Text = "连续采集";
            this.btnContinueAcq.UseVisualStyleBackColor = true;
            this.btnContinueAcq.Click += new System.EventHandler(this.BtnContinueAcq_Click);
            // 
            // btnSingleAcq
            // 
            this.btnSingleAcq.Enabled = false;
            this.btnSingleAcq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingleAcq.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSingleAcq.Location = new System.Drawing.Point(16, 101);
            this.btnSingleAcq.Name = "btnSingleAcq";
            this.btnSingleAcq.Size = new System.Drawing.Size(75, 28);
            this.btnSingleAcq.TabIndex = 18;
            this.btnSingleAcq.Text = "单帧采集";
            this.btnSingleAcq.UseVisualStyleBackColor = true;
            this.btnSingleAcq.Click += new System.EventHandler(this.BtnSingleAcq_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.pnlParam);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(322, 339);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "参数";
            // 
            // pnlParam
            // 
            this.pnlParam.AutoScroll = true;
            this.pnlParam.Controls.Add(this.label3);
            this.pnlParam.Controls.Add(this.nudDelayTime);
            this.pnlParam.Controls.Add(this.chkDelayTime);
            this.pnlParam.Controls.Add(this.nudExposureTime);
            this.pnlParam.Controls.Add(this.trbExposureTime);
            this.pnlParam.Controls.Add(this.chkExposureTime);
            this.pnlParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlParam.Enabled = false;
            this.pnlParam.Location = new System.Drawing.Point(3, 3);
            this.pnlParam.Name = "pnlParam";
            this.pnlParam.Size = new System.Drawing.Size(316, 333);
            this.pnlParam.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "ms";
            // 
            // nudDelayTime
            // 
            this.nudDelayTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudDelayTime.Location = new System.Drawing.Point(66, 55);
            this.nudDelayTime.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDelayTime.Name = "nudDelayTime";
            this.nudDelayTime.Size = new System.Drawing.Size(94, 23);
            this.nudDelayTime.TabIndex = 25;
            // 
            // chkDelayTime
            // 
            this.chkDelayTime.AutoSize = true;
            this.chkDelayTime.Checked = true;
            this.chkDelayTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDelayTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDelayTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkDelayTime.Location = new System.Drawing.Point(7, 55);
            this.chkDelayTime.Name = "chkDelayTime";
            this.chkDelayTime.Size = new System.Drawing.Size(53, 24);
            this.chkDelayTime.TabIndex = 23;
            this.chkDelayTime.Text = "延时";
            this.chkDelayTime.UseVisualStyleBackColor = true;
            this.chkDelayTime.CheckedChanged += new System.EventHandler(this.ChkDelayTime_CheckedChanged);
            // 
            // nudExposureTime
            // 
            this.nudExposureTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudExposureTime.Location = new System.Drawing.Point(203, 10);
            this.nudExposureTime.Name = "nudExposureTime";
            this.nudExposureTime.Size = new System.Drawing.Size(86, 23);
            this.nudExposureTime.TabIndex = 12;
            this.nudExposureTime.ValueChanged += new System.EventHandler(this.NudExposureTime_ValueChanged);
            // 
            // trbExposureTime
            // 
            this.trbExposureTime.AutoSize = false;
            this.trbExposureTime.Location = new System.Drawing.Point(57, 12);
            this.trbExposureTime.Name = "trbExposureTime";
            this.trbExposureTime.Size = new System.Drawing.Size(140, 24);
            this.trbExposureTime.TabIndex = 11;
            this.trbExposureTime.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbExposureTime.ValueChanged += new System.EventHandler(this.TrbExposureTime_ValueChanged);
            // 
            // chkExposureTime
            // 
            this.chkExposureTime.AutoSize = true;
            this.chkExposureTime.Checked = true;
            this.chkExposureTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExposureTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkExposureTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkExposureTime.Location = new System.Drawing.Point(7, 12);
            this.chkExposureTime.Name = "chkExposureTime";
            this.chkExposureTime.Size = new System.Drawing.Size(48, 21);
            this.chkExposureTime.TabIndex = 10;
            this.chkExposureTime.Text = "曝光";
            this.chkExposureTime.UseVisualStyleBackColor = true;
            this.chkExposureTime.CheckedChanged += new System.EventHandler(this.ChkExposureTime_CheckedChanged);
            // 
            // AcqSetToolControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AcqSetToolControl";
            this.tpBasic.ResumeLayout(false);
            this.pnlBasic.ResumeLayout(false);
            this.pnlBasic.PerformLayout();
            this.TcTool.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlParam.ResumeLayout(false);
            this.pnlParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExposureTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbExposureTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStopAcq;
        private System.Windows.Forms.ComboBox cmbCamera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnContinueAcq;
        private System.Windows.Forms.Button btnSingleAcq;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlParam;
        private System.Windows.Forms.NumericUpDown nudExposureTime;
        private System.Windows.Forms.TrackBar trbExposureTime;
        private System.Windows.Forms.CheckBox chkExposureTime;
        private System.Windows.Forms.NumericUpDown nudDelayTime;
        private System.Windows.Forms.CheckBox chkDelayTime;
        private System.Windows.Forms.Label label3;
    }
}
