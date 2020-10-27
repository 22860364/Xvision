namespace DispenseAPP.Tools_Image_IO.ImportImage
{
    partial class Tools_ImportImage
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
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.tabControl_FindLine = new System.Windows.Forms.TabControl();
            this.tabPage_Base = new System.Windows.Forms.TabPage();
            this.panel_Basic = new System.Windows.Forms.Panel();
            this.Btn_Path = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Cb_CycleLoad = new System.Windows.Forms.CheckBox();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_Output = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cb_ImageBackup = new System.Windows.Forms.CheckBox();
            this.tabControl_FindLine.SuspendLayout();
            this.tabPage_Base.SuspendLayout();
            this.panel_Basic.SuspendLayout();
            this.tabPage_Output.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(222, 370);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.Btn_Cancel.TabIndex = 14;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(127, 370);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 28);
            this.Btn_OK.TabIndex = 13;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // tabControl_FindLine
            // 
            this.tabControl_FindLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabControl_FindLine.Controls.Add(this.tabPage_Base);
            this.tabControl_FindLine.Controls.Add(this.tabPage_Output);
            this.tabControl_FindLine.ItemSize = new System.Drawing.Size(65, 18);
            this.tabControl_FindLine.Location = new System.Drawing.Point(0, 0);
            this.tabControl_FindLine.Multiline = true;
            this.tabControl_FindLine.Name = "tabControl_FindLine";
            this.tabControl_FindLine.SelectedIndex = 0;
            this.tabControl_FindLine.Size = new System.Drawing.Size(330, 364);
            this.tabControl_FindLine.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_FindLine.TabIndex = 12;
            // 
            // tabPage_Base
            // 
            this.tabPage_Base.Controls.Add(this.panel_Basic);
            this.tabPage_Base.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage_Base.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Base.Name = "tabPage_Base";
            this.tabPage_Base.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Base.Size = new System.Drawing.Size(322, 338);
            this.tabPage_Base.TabIndex = 0;
            this.tabPage_Base.Text = "基本";
            this.tabPage_Base.UseVisualStyleBackColor = true;
            // 
            // panel_Basic
            // 
            this.panel_Basic.AutoScroll = true;
            this.panel_Basic.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Basic.Controls.Add(this.Btn_Path);
            this.panel_Basic.Controls.Add(this.label3);
            this.panel_Basic.Controls.Add(this.Cb_CycleLoad);
            this.panel_Basic.Controls.Add(this.txt_Path);
            this.panel_Basic.Controls.Add(this.Txt_Name);
            this.panel_Basic.Controls.Add(this.label1);
            this.panel_Basic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Basic.Location = new System.Drawing.Point(3, 3);
            this.panel_Basic.Name = "panel_Basic";
            this.panel_Basic.Size = new System.Drawing.Size(316, 332);
            this.panel_Basic.TabIndex = 0;
            // 
            // Btn_Path
            // 
            this.Btn_Path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Path.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Path.Location = new System.Drawing.Point(230, 164);
            this.Btn_Path.Name = "Btn_Path";
            this.Btn_Path.Size = new System.Drawing.Size(60, 28);
            this.Btn_Path.TabIndex = 15;
            this.Btn_Path.Text = "路径";
            this.Btn_Path.UseVisualStyleBackColor = true;
            this.Btn_Path.Click += new System.EventHandler(this.Btn_Path_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "图像路径：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cb_CycleLoad
            // 
            this.Cb_CycleLoad.Checked = true;
            this.Cb_CycleLoad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_CycleLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cb_CycleLoad.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cb_CycleLoad.Location = new System.Drawing.Point(6, 164);
            this.Cb_CycleLoad.Name = "Cb_CycleLoad";
            this.Cb_CycleLoad.Size = new System.Drawing.Size(117, 24);
            this.Cb_CycleLoad.TabIndex = 13;
            this.Cb_CycleLoad.Text = "循环加载";
            this.Cb_CycleLoad.UseVisualStyleBackColor = true;
            // 
            // txt_Path
            // 
            this.txt_Path.BackColor = System.Drawing.Color.White;
            this.txt_Path.Location = new System.Drawing.Point(6, 88);
            this.txt_Path.Multiline = true;
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.ReadOnly = true;
            this.txt_Path.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Path.Size = new System.Drawing.Size(284, 70);
            this.txt_Path.TabIndex = 5;
            // 
            // Txt_Name
            // 
            this.Txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_Name.Location = new System.Drawing.Point(63, 19);
            this.Txt_Name.Multiline = true;
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(202, 23);
            this.Txt_Name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "算子名：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage_Output
            // 
            this.tabPage_Output.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Output.Controls.Add(this.panel1);
            this.tabPage_Output.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Output.Name = "tabPage_Output";
            this.tabPage_Output.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Output.Size = new System.Drawing.Size(322, 338);
            this.tabPage_Output.TabIndex = 2;
            this.tabPage_Output.Text = "输出";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.Cb_ImageBackup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 332);
            this.panel1.TabIndex = 0;
            // 
            // Cb_ImageBackup
            // 
            this.Cb_ImageBackup.Checked = true;
            this.Cb_ImageBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_ImageBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cb_ImageBackup.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cb_ImageBackup.Location = new System.Drawing.Point(13, 14);
            this.Cb_ImageBackup.Name = "Cb_ImageBackup";
            this.Cb_ImageBackup.Size = new System.Drawing.Size(128, 24);
            this.Cb_ImageBackup.TabIndex = 2;
            this.Cb_ImageBackup.Text = "输出图像备份";
            this.Cb_ImageBackup.UseVisualStyleBackColor = true;
            // 
            // Tools_ImportImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.tabControl_FindLine);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Tools_ImportImage";
            this.Size = new System.Drawing.Size(330, 400);
            this.tabControl_FindLine.ResumeLayout(false);
            this.tabPage_Base.ResumeLayout(false);
            this.panel_Basic.ResumeLayout(false);
            this.panel_Basic.PerformLayout();
            this.tabPage_Output.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.TabControl tabControl_FindLine;
        private System.Windows.Forms.TabPage tabPage_Base;
        private System.Windows.Forms.Panel panel_Basic;
        private System.Windows.Forms.Button Btn_Path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Cb_CycleLoad;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_Output;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox Cb_ImageBackup;
    }
}
