namespace DispenseAPP.Tools_Other.ReadWriteVar
{
    partial class Tools_ReadWriteVar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.tabControl_FindLine = new System.Windows.Forms.TabControl();
            this.Tp_Base = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Path = new System.Windows.Forms.Button();
            this.Txt_Path = new System.Windows.Forms.TextBox();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tp_Data = new System.Windows.Forms.TabPage();
            this.Panel_Data = new System.Windows.Forms.Panel();
            this.DG_VarName = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rbtn_Write = new System.Windows.Forms.RadioButton();
            this.Rbtn_Read = new System.Windows.Forms.RadioButton();
            this.Col_VarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Checked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl_FindLine.SuspendLayout();
            this.Tp_Base.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Tp_Data.SuspendLayout();
            this.Panel_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_VarName)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(240, 365);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.Btn_Cancel.TabIndex = 7;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(159, 365);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 28);
            this.Btn_OK.TabIndex = 6;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // tabControl_FindLine
            // 
            this.tabControl_FindLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_FindLine.Controls.Add(this.Tp_Base);
            this.tabControl_FindLine.Controls.Add(this.Tp_Data);
            this.tabControl_FindLine.ItemSize = new System.Drawing.Size(65, 18);
            this.tabControl_FindLine.Location = new System.Drawing.Point(0, 2);
            this.tabControl_FindLine.Multiline = true;
            this.tabControl_FindLine.Name = "tabControl_FindLine";
            this.tabControl_FindLine.SelectedIndex = 0;
            this.tabControl_FindLine.Size = new System.Drawing.Size(328, 361);
            this.tabControl_FindLine.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_FindLine.TabIndex = 5;
            // 
            // Tp_Base
            // 
            this.Tp_Base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Tp_Base.Controls.Add(this.groupBox1);
            this.Tp_Base.Controls.Add(this.Txt_Name);
            this.Tp_Base.Controls.Add(this.label1);
            this.Tp_Base.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tp_Base.Location = new System.Drawing.Point(4, 22);
            this.Tp_Base.Name = "Tp_Base";
            this.Tp_Base.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_Base.Size = new System.Drawing.Size(320, 335);
            this.Tp_Base.TabIndex = 0;
            this.Tp_Base.Text = "基本";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Path);
            this.groupBox1.Controls.Add(this.Txt_Path);
            this.groupBox1.Location = new System.Drawing.Point(19, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 91);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件路径";
            // 
            // Btn_Path
            // 
            this.Btn_Path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Path.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Path.Location = new System.Drawing.Point(217, 31);
            this.Btn_Path.Name = "Btn_Path";
            this.Btn_Path.Size = new System.Drawing.Size(47, 42);
            this.Btn_Path.TabIndex = 8;
            this.Btn_Path.Text = "路径";
            this.Btn_Path.UseVisualStyleBackColor = true;
            this.Btn_Path.Click += new System.EventHandler(this.Btn_Path_Click);
            // 
            // Txt_Path
            // 
            this.Txt_Path.Location = new System.Drawing.Point(6, 22);
            this.Txt_Path.Multiline = true;
            this.Txt_Path.Name = "Txt_Path";
            this.Txt_Path.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Txt_Path.Size = new System.Drawing.Size(205, 63);
            this.Txt_Path.TabIndex = 0;
            // 
            // Txt_Name
            // 
            this.Txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_Name.Location = new System.Drawing.Point(76, 16);
            this.Txt_Name.Multiline = true;
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(213, 23);
            this.Txt_Name.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "算子名：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tp_Data
            // 
            this.Tp_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Tp_Data.Controls.Add(this.Panel_Data);
            this.Tp_Data.Location = new System.Drawing.Point(4, 22);
            this.Tp_Data.Name = "Tp_Data";
            this.Tp_Data.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_Data.Size = new System.Drawing.Size(320, 335);
            this.Tp_Data.TabIndex = 1;
            this.Tp_Data.Text = "数据";
            // 
            // Panel_Data
            // 
            this.Panel_Data.AutoScroll = true;
            this.Panel_Data.Controls.Add(this.DG_VarName);
            this.Panel_Data.Controls.Add(this.groupBox2);
            this.Panel_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Data.Location = new System.Drawing.Point(3, 3);
            this.Panel_Data.Name = "Panel_Data";
            this.Panel_Data.Size = new System.Drawing.Size(314, 329);
            this.Panel_Data.TabIndex = 0;
            // 
            // DG_VarName
            // 
            this.DG_VarName.AllowUserToAddRows = false;
            this.DG_VarName.AllowUserToResizeColumns = false;
            this.DG_VarName.AllowUserToResizeRows = false;
            this.DG_VarName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_VarName.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_VarName.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_VarName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_VarName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_VarName,
            this.Col_Checked});
            this.DG_VarName.Location = new System.Drawing.Point(12, 51);
            this.DG_VarName.MultiSelect = false;
            this.DG_VarName.Name = "DG_VarName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DG_VarName.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_VarName.RowTemplate.Height = 23;
            this.DG_VarName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_VarName.Size = new System.Drawing.Size(276, 272);
            this.DG_VarName.TabIndex = 1;
            this.DG_VarName.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DG_VarName_RowPostPaint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rbtn_Write);
            this.groupBox2.Controls.Add(this.Rbtn_Read);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 42);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "模式";
            // 
            // Rbtn_Write
            // 
            this.Rbtn_Write.AutoSize = true;
            this.Rbtn_Write.Location = new System.Drawing.Point(184, 15);
            this.Rbtn_Write.Name = "Rbtn_Write";
            this.Rbtn_Write.Size = new System.Drawing.Size(38, 21);
            this.Rbtn_Write.TabIndex = 1;
            this.Rbtn_Write.TabStop = true;
            this.Rbtn_Write.Text = "写";
            this.Rbtn_Write.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Read
            // 
            this.Rbtn_Read.AutoSize = true;
            this.Rbtn_Read.Location = new System.Drawing.Point(29, 15);
            this.Rbtn_Read.Name = "Rbtn_Read";
            this.Rbtn_Read.Size = new System.Drawing.Size(38, 21);
            this.Rbtn_Read.TabIndex = 0;
            this.Rbtn_Read.TabStop = true;
            this.Rbtn_Read.Text = "读";
            this.Rbtn_Read.UseVisualStyleBackColor = true;
            // 
            // Col_VarName
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.Col_VarName.DefaultCellStyle = dataGridViewCellStyle2;
            this.Col_VarName.HeaderText = "变量名称";
            this.Col_VarName.Name = "Col_VarName";
            this.Col_VarName.ReadOnly = true;
            this.Col_VarName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col_VarName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_Checked
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.Col_Checked.DefaultCellStyle = dataGridViewCellStyle3;
            this.Col_Checked.FillWeight = 40F;
            this.Col_Checked.HeaderText = "状态";
            this.Col_Checked.Name = "Col_Checked";
            // 
            // Tools_ReadWriteVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.tabControl_FindLine);
            this.Name = "Tools_ReadWriteVar";
            this.Size = new System.Drawing.Size(328, 398);
            this.tabControl_FindLine.ResumeLayout(false);
            this.Tp_Base.ResumeLayout(false);
            this.Tp_Base.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Tp_Data.ResumeLayout(false);
            this.Panel_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_VarName)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.TabControl tabControl_FindLine;
        private System.Windows.Forms.TabPage Tp_Base;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Path;
        private System.Windows.Forms.TextBox Txt_Path;
        private System.Windows.Forms.TabPage Tp_Data;
        private System.Windows.Forms.Panel Panel_Data;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Rbtn_Write;
        private System.Windows.Forms.RadioButton Rbtn_Read;
        private System.Windows.Forms.DataGridView DG_VarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_VarName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_Checked;
    }
}
