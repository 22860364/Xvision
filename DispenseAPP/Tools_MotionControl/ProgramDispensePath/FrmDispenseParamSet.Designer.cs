namespace DispenseAPP.Tools_MotionControl.ProgramDispensePath
{
    partial class FrmDispenseParamSet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_BlockName = new System.Windows.Forms.Label();
            this.Num_Single_BeforeDelayTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Num_Straight_out_of_glue_Time = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Num_CloseofGuleLaterDelayTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Num_Single_CloseofGlueUPLaterDealyTime = new System.Windows.Forms.NumericUpDown();
            this.Cb_NotInPlaceStartGlue = new System.Windows.Forms.CheckBox();
            this.Cb_Single_EnablePullBackFunction = new System.Windows.Forms.CheckBox();
            this.Btn_Single_PullBackSet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_PathPullBackSet = new System.Windows.Forms.Button();
            this.Cb_Path_EnablePullBackFunction = new System.Windows.Forms.CheckBox();
            this.Num_CloseofGuleDelayTime = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Num_AheadCloseofGlueDistance = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Num_StartofGlueDelayTime = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Num_Path_BeforeDelayTime = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Num_Path_CloseofGlueUPLaterDealyTime = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Single_BeforeDelayTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Straight_out_of_glue_Time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_CloseofGuleLaterDelayTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Single_CloseofGlueUPLaterDealyTime)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_CloseofGuleDelayTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_AheadCloseofGlueDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_StartofGlueDelayTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Path_BeforeDelayTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Path_CloseofGlueUPLaterDealyTime)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.Location = new System.Drawing.Point(3, 1);
            this.lbl_ProjectName.Size = new System.Drawing.Size(93, 20);
            this.lbl_ProjectName.Text = "点胶参数设置";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Single_PullBackSet);
            this.groupBox1.Controls.Add(this.Cb_Single_EnablePullBackFunction);
            this.groupBox1.Controls.Add(this.Cb_NotInPlaceStartGlue);
            this.groupBox1.Controls.Add(this.Num_Single_CloseofGlueUPLaterDealyTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Num_CloseofGuleLaterDelayTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Num_Straight_out_of_glue_Time);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Num_Single_BeforeDelayTime);
            this.groupBox1.Controls.Add(this.lbl_BlockName);
            this.groupBox1.Location = new System.Drawing.Point(8, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 189);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "单点出胶设置";
            // 
            // lbl_BlockName
            // 
            this.lbl_BlockName.Location = new System.Drawing.Point(10, 21);
            this.lbl_BlockName.Name = "lbl_BlockName";
            this.lbl_BlockName.Size = new System.Drawing.Size(83, 23);
            this.lbl_BlockName.TabIndex = 10;
            this.lbl_BlockName.Text = "出胶前延时";
            this.lbl_BlockName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Num_Single_BeforeDelayTime
            // 
            this.Num_Single_BeforeDelayTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num_Single_BeforeDelayTime.Location = new System.Drawing.Point(127, 21);
            this.Num_Single_BeforeDelayTime.Name = "Num_Single_BeforeDelayTime";
            this.Num_Single_BeforeDelayTime.Size = new System.Drawing.Size(103, 23);
            this.Num_Single_BeforeDelayTime.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "持续出胶时间";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Num_Straight_out_of_glue_Time
            // 
            this.Num_Straight_out_of_glue_Time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num_Straight_out_of_glue_Time.Location = new System.Drawing.Point(127, 48);
            this.Num_Straight_out_of_glue_Time.Name = "Num_Straight_out_of_glue_Time";
            this.Num_Straight_out_of_glue_Time.Size = new System.Drawing.Size(103, 23);
            this.Num_Straight_out_of_glue_Time.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "关胶后延时";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Num_CloseofGuleLaterDelayTime
            // 
            this.Num_CloseofGuleLaterDelayTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num_CloseofGuleLaterDelayTime.Location = new System.Drawing.Point(127, 77);
            this.Num_CloseofGuleLaterDelayTime.Name = "Num_CloseofGuleLaterDelayTime";
            this.Num_CloseofGuleLaterDelayTime.Size = new System.Drawing.Size(103, 23);
            this.Num_CloseofGuleLaterDelayTime.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "关胶抬升后延时";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Num_Single_CloseofGlueUPLaterDealyTime
            // 
            this.Num_Single_CloseofGlueUPLaterDealyTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num_Single_CloseofGlueUPLaterDealyTime.Location = new System.Drawing.Point(127, 105);
            this.Num_Single_CloseofGlueUPLaterDealyTime.Name = "Num_Single_CloseofGlueUPLaterDealyTime";
            this.Num_Single_CloseofGlueUPLaterDealyTime.Size = new System.Drawing.Size(103, 23);
            this.Num_Single_CloseofGlueUPLaterDealyTime.TabIndex = 17;
            // 
            // Cb_NotInPlaceStartGlue
            // 
            this.Cb_NotInPlaceStartGlue.Location = new System.Drawing.Point(13, 131);
            this.Cb_NotInPlaceStartGlue.Name = "Cb_NotInPlaceStartGlue";
            this.Cb_NotInPlaceStartGlue.Size = new System.Drawing.Size(115, 25);
            this.Cb_NotInPlaceStartGlue.TabIndex = 18;
            this.Cb_NotInPlaceStartGlue.Text = "不到位开始出胶";
            this.Cb_NotInPlaceStartGlue.UseVisualStyleBackColor = true;
            // 
            // Cb_Single_EnablePullBackFunction
            // 
            this.Cb_Single_EnablePullBackFunction.Location = new System.Drawing.Point(13, 157);
            this.Cb_Single_EnablePullBackFunction.Name = "Cb_Single_EnablePullBackFunction";
            this.Cb_Single_EnablePullBackFunction.Size = new System.Drawing.Size(115, 27);
            this.Cb_Single_EnablePullBackFunction.TabIndex = 19;
            this.Cb_Single_EnablePullBackFunction.Text = "启用拉丝功能";
            this.Cb_Single_EnablePullBackFunction.UseVisualStyleBackColor = true;
            // 
            // Btn_Single_PullBackSet
            // 
            this.Btn_Single_PullBackSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Single_PullBackSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Single_PullBackSet.Location = new System.Drawing.Point(127, 157);
            this.Btn_Single_PullBackSet.Name = "Btn_Single_PullBackSet";
            this.Btn_Single_PullBackSet.Size = new System.Drawing.Size(64, 27);
            this.Btn_Single_PullBackSet.TabIndex = 20;
            this.Btn_Single_PullBackSet.Text = "设置";
            this.Btn_Single_PullBackSet.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Num_Path_CloseofGlueUPLaterDealyTime);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Btn_PathPullBackSet);
            this.groupBox2.Controls.Add(this.Cb_Path_EnablePullBackFunction);
            this.groupBox2.Controls.Add(this.Num_CloseofGuleDelayTime);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Num_AheadCloseofGlueDistance);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Num_StartofGlueDelayTime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Num_Path_BeforeDelayTime);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(268, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 193);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "轨迹出胶设置";
            // 
            // Btn_PathPullBackSet
            // 
            this.Btn_PathPullBackSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PathPullBackSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_PathPullBackSet.Location = new System.Drawing.Point(127, 164);
            this.Btn_PathPullBackSet.Name = "Btn_PathPullBackSet";
            this.Btn_PathPullBackSet.Size = new System.Drawing.Size(65, 24);
            this.Btn_PathPullBackSet.TabIndex = 20;
            this.Btn_PathPullBackSet.Text = "设置";
            this.Btn_PathPullBackSet.UseVisualStyleBackColor = true;
            // 
            // Cb_Path_EnablePullBackFunction
            // 
            this.Cb_Path_EnablePullBackFunction.Location = new System.Drawing.Point(6, 164);
            this.Cb_Path_EnablePullBackFunction.Name = "Cb_Path_EnablePullBackFunction";
            this.Cb_Path_EnablePullBackFunction.Size = new System.Drawing.Size(115, 23);
            this.Cb_Path_EnablePullBackFunction.TabIndex = 19;
            this.Cb_Path_EnablePullBackFunction.Text = "启用拉丝功能";
            this.Cb_Path_EnablePullBackFunction.UseVisualStyleBackColor = true;
            // 
            // Num_CloseofGuleDelayTime
            // 
            this.Num_CloseofGuleDelayTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num_CloseofGuleDelayTime.Location = new System.Drawing.Point(127, 105);
            this.Num_CloseofGuleDelayTime.Name = "Num_CloseofGuleDelayTime";
            this.Num_CloseofGuleDelayTime.Size = new System.Drawing.Size(103, 23);
            this.Num_CloseofGuleDelayTime.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "关胶延时";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Num_AheadCloseofGlueDistance
            // 
            this.Num_AheadCloseofGlueDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num_AheadCloseofGlueDistance.Location = new System.Drawing.Point(127, 77);
            this.Num_AheadCloseofGlueDistance.Name = "Num_AheadCloseofGlueDistance";
            this.Num_AheadCloseofGlueDistance.Size = new System.Drawing.Size(103, 23);
            this.Num_AheadCloseofGlueDistance.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "提前关胶距离";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Num_StartofGlueDelayTime
            // 
            this.Num_StartofGlueDelayTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num_StartofGlueDelayTime.Location = new System.Drawing.Point(127, 48);
            this.Num_StartofGlueDelayTime.Name = "Num_StartofGlueDelayTime";
            this.Num_StartofGlueDelayTime.Size = new System.Drawing.Size(103, 23);
            this.Num_StartofGlueDelayTime.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "出胶延时";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Num_Path_BeforeDelayTime
            // 
            this.Num_Path_BeforeDelayTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num_Path_BeforeDelayTime.Location = new System.Drawing.Point(127, 21);
            this.Num_Path_BeforeDelayTime.Name = "Num_Path_BeforeDelayTime";
            this.Num_Path_BeforeDelayTime.Size = new System.Drawing.Size(103, 23);
            this.Num_Path_BeforeDelayTime.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "出胶前延时";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(436, 244);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.Btn_Cancel.TabIndex = 10;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(355, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "确定";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "关胶抬升后延时";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Num_Path_CloseofGlueUPLaterDealyTime
            // 
            this.Num_Path_CloseofGlueUPLaterDealyTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num_Path_CloseofGlueUPLaterDealyTime.Location = new System.Drawing.Point(127, 134);
            this.Num_Path_CloseofGlueUPLaterDealyTime.Name = "Num_Path_CloseofGlueUPLaterDealyTime";
            this.Num_Path_CloseofGlueUPLaterDealyTime.Size = new System.Drawing.Size(103, 23);
            this.Num_Path_CloseofGlueUPLaterDealyTime.TabIndex = 22;
            // 
            // FrmDispenseParamSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(515, 276);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDispenseParamSet";
            this.Text = "点胶参数设置";
            this.TitleVisiable = false;
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.Btn_Cancel, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Num_Single_BeforeDelayTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Straight_out_of_glue_Time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_CloseofGuleLaterDelayTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Single_CloseofGlueUPLaterDealyTime)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Num_CloseofGuleDelayTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_AheadCloseofGlueDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_StartofGlueDelayTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Path_BeforeDelayTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Path_CloseofGlueUPLaterDealyTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_BlockName;
        private System.Windows.Forms.NumericUpDown Num_Single_BeforeDelayTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Num_Straight_out_of_glue_Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Num_Single_CloseofGlueUPLaterDealyTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Num_CloseofGuleLaterDelayTime;
        private System.Windows.Forms.CheckBox Cb_Single_EnablePullBackFunction;
        private System.Windows.Forms.CheckBox Cb_NotInPlaceStartGlue;
        private System.Windows.Forms.Button Btn_Single_PullBackSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_PathPullBackSet;
        private System.Windows.Forms.CheckBox Cb_Path_EnablePullBackFunction;
        private System.Windows.Forms.NumericUpDown Num_CloseofGuleDelayTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Num_AheadCloseofGlueDistance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Num_StartofGlueDelayTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Num_Path_BeforeDelayTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown Num_Path_CloseofGlueUPLaterDealyTime;
        private System.Windows.Forms.Label label8;
    }
}