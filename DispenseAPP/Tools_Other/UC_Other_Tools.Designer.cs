namespace DispenseAPP.Tools_Other
{
    partial class UC_Other_Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Other_Tools));
            this.Lbl_Script = new System.Windows.Forms.Label();
            this.Lbl_Delay = new System.Windows.Forms.Label();
            this.Lbl_LogicalOper = new System.Windows.Forms.Label();
            this.Lbl_VarSet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Script
            // 
            this.Lbl_Script.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Script.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Script.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_Script.Image")));
            this.Lbl_Script.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Script.Location = new System.Drawing.Point(0, 96);
            this.Lbl_Script.Name = "Lbl_Script";
            this.Lbl_Script.Size = new System.Drawing.Size(330, 32);
            this.Lbl_Script.TabIndex = 4;
            this.Lbl_Script.Text = "          脚本工具";
            this.Lbl_Script.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Script.Click += new System.EventHandler(this.Lbl_Script_Click);
            // 
            // Lbl_Delay
            // 
            this.Lbl_Delay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Delay.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Delay.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_Delay.Image")));
            this.Lbl_Delay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Delay.Location = new System.Drawing.Point(0, 64);
            this.Lbl_Delay.Name = "Lbl_Delay";
            this.Lbl_Delay.Size = new System.Drawing.Size(330, 32);
            this.Lbl_Delay.TabIndex = 3;
            this.Lbl_Delay.Text = "          延时";
            this.Lbl_Delay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Delay.Click += new System.EventHandler(this.Lbl_Delay_Click);
            // 
            // Lbl_LogicalOper
            // 
            this.Lbl_LogicalOper.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_LogicalOper.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_LogicalOper.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_LogicalOper.Image")));
            this.Lbl_LogicalOper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_LogicalOper.Location = new System.Drawing.Point(0, 32);
            this.Lbl_LogicalOper.Name = "Lbl_LogicalOper";
            this.Lbl_LogicalOper.Size = new System.Drawing.Size(330, 32);
            this.Lbl_LogicalOper.TabIndex = 2;
            this.Lbl_LogicalOper.Text = "          逻辑运算";
            this.Lbl_LogicalOper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_LogicalOper.Click += new System.EventHandler(this.Lbl_LogicalOperation_Click);
            // 
            // Lbl_VarSet
            // 
            this.Lbl_VarSet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_VarSet.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_VarSet.Image = ((System.Drawing.Image)(resources.GetObject("Lbl_VarSet.Image")));
            this.Lbl_VarSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_VarSet.Location = new System.Drawing.Point(0, 0);
            this.Lbl_VarSet.Name = "Lbl_VarSet";
            this.Lbl_VarSet.Size = new System.Drawing.Size(330, 32);
            this.Lbl_VarSet.TabIndex = 1;
            this.Lbl_VarSet.Text = "          变量设置";
            this.Lbl_VarSet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_VarSet.Click += new System.EventHandler(this.Lbl_VarSet_Click);
            // 
            // UC_Other_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Lbl_Script);
            this.Controls.Add(this.Lbl_Delay);
            this.Controls.Add(this.Lbl_LogicalOper);
            this.Controls.Add(this.Lbl_VarSet);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UC_Other_Tools";
            this.Size = new System.Drawing.Size(330, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_VarSet;
        private System.Windows.Forms.Label Lbl_LogicalOper;
        private System.Windows.Forms.Label Lbl_Delay;
        private System.Windows.Forms.Label Lbl_Script;
    }
}
