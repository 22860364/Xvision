namespace DispenseAPP.Tools_ImageEnhancement
{
    partial class Tools_RotateShiftImage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Panel_Base = new System.Windows.Forms.Panel();
            this.Btn_Set = new System.Windows.Forms.Button();
            this.lbl_BlockName = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.tpBasic.SuspendLayout();
            this.pnlBasic.SuspendLayout();
            this.TcTool.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Panel_Base.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpBasic
            // 
            this.tpBasic.Location = new System.Drawing.Point(4, 22);
            this.tpBasic.Margin = new System.Windows.Forms.Padding(6);
            this.tpBasic.Padding = new System.Windows.Forms.Padding(6);
            this.tpBasic.Size = new System.Drawing.Size(487, 522);
            // 
            // pnlBasic
            // 
            this.pnlBasic.Controls.Add(this.btnSet);
            this.pnlBasic.Location = new System.Drawing.Point(6, 6);
            this.pnlBasic.Size = new System.Drawing.Size(475, 510);
            this.pnlBasic.Controls.SetChildIndex(this.txtName, 0);
            this.pnlBasic.Controls.SetChildIndex(this.btnSet, 0);
            // 
            // txtName
            // 
            this.txtName.Margin = new System.Windows.Forms.Padding(6);
            this.txtName.Size = new System.Drawing.Size(332, 50);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.ItemSize = new System.Drawing.Size(65, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 543);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.Panel_Base);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(486, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本";
            // 
            // Panel_Base
            // 
            this.Panel_Base.Controls.Add(this.Btn_Set);
            this.Panel_Base.Controls.Add(this.lbl_BlockName);
            this.Panel_Base.Controls.Add(this.txt_Name);
            this.Panel_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Base.Location = new System.Drawing.Point(4, 4);
            this.Panel_Base.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_Base.Name = "Panel_Base";
            this.Panel_Base.Size = new System.Drawing.Size(478, 509);
            this.Panel_Base.TabIndex = 0;
            // 
            // Btn_Set
            // 
            this.Btn_Set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Set.Location = new System.Drawing.Point(117, 104);
            this.Btn_Set.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Set.Name = "Btn_Set";
            this.Btn_Set.Size = new System.Drawing.Size(106, 39);
            this.Btn_Set.TabIndex = 13;
            this.Btn_Set.Text = "设置";
            this.Btn_Set.UseVisualStyleBackColor = true;
            this.Btn_Set.Click += new System.EventHandler(this.Btn_Set_Click);
            // 
            // lbl_BlockName
            // 
            this.lbl_BlockName.AutoSize = true;
            this.lbl_BlockName.Location = new System.Drawing.Point(27, 22);
            this.lbl_BlockName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BlockName.Name = "lbl_BlockName";
            this.lbl_BlockName.Size = new System.Drawing.Size(64, 24);
            this.lbl_BlockName.TabIndex = 11;
            this.lbl_BlockName.Text = "算子名";
            this.lbl_BlockName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Name.Location = new System.Drawing.Point(117, 20);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(281, 35);
            this.txt_Name.TabIndex = 12;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(375, 552);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(112, 42);
            this.Btn_Cancel.TabIndex = 25;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(254, 552);
            this.Btn_OK.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(112, 42);
            this.Btn_OK.TabIndex = 24;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // btnSet
            // 
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSet.Location = new System.Drawing.Point(29, 89);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 42);
            this.btnSet.TabIndex = 10;
            this.btnSet.Text = "设 置";
            this.btnSet.UseVisualStyleBackColor = true;
            // 
            // Tools_RotateShiftImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.tabControl1);
            this.Name = "Tools_RotateShiftImage";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.Btn_OK, 0);
            this.Controls.SetChildIndex(this.Btn_Cancel, 0);
            this.Controls.SetChildIndex(this.TcTool, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.tpBasic.ResumeLayout(false);
            this.pnlBasic.ResumeLayout(false);
            this.pnlBasic.PerformLayout();
            this.TcTool.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Panel_Base.ResumeLayout(false);
            this.Panel_Base.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Panel Panel_Base;
        private System.Windows.Forms.Label lbl_BlockName;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button Btn_Set;
        private System.Windows.Forms.Button btnSet;
    }
}
