﻿namespace DispenseAPP.Tools_Other.VarSet
{
    partial class VarSetToolControl
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
            // pnlBasic
            // 
            this.pnlBasic.Controls.Add(this.btnSet);
            this.pnlBasic.Controls.SetChildIndex(this.txtName, 0);
            this.pnlBasic.Controls.SetChildIndex(this.btnSet, 0);
            // 
            // btnSet
            // 
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSet.Location = new System.Drawing.Point(72, 64);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 28);
            this.btnSet.TabIndex = 12;
            this.btnSet.Text = "设 置";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // VariableSetToolControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "VariableSetToolControl";
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
