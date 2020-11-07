namespace DispenseAPP.Tools_ImageEnhancement.Pretreatment
{
    partial class PretreatmentToolControl
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
            this.btnSet = new System.Windows.Forms.Button();
            this.tpBasic.SuspendLayout();
            this.pnlBasic.SuspendLayout();
            this.TcTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpBasic
            // 
            this.tpBasic.Location = new System.Drawing.Point(4, 22);
            this.tpBasic.Size = new System.Drawing.Size(487, 522);
            // 
            // pnlBasic
            // 
            this.pnlBasic.Controls.Add(this.btnSet);
            this.pnlBasic.Size = new System.Drawing.Size(479, 514);
            this.pnlBasic.Controls.SetChildIndex(this.txtName, 0);
            this.pnlBasic.Controls.SetChildIndex(this.btnSet, 0);
            // 
            // btnSet
            // 
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSet.Location = new System.Drawing.Point(24, 77);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 42);
            this.btnSet.TabIndex = 11;
            this.btnSet.Text = "设 置";
            this.btnSet.UseVisualStyleBackColor = true;
            // 
            // PretreatmentToolControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PretreatmentToolControl";
            this.tpBasic.ResumeLayout(false);
            this.pnlBasic.ResumeLayout(false);
            this.pnlBasic.PerformLayout();
            this.TcTool.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSet;
    }
}
