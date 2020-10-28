namespace DispenseAPP.FrmList
{
    partial class FrmConfigWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_WindowNum = new System.Windows.Forms.Label();
            this.Num_ImageWindowNum = new System.Windows.Forms.NumericUpDown();
            this.DG_WindowIndex = new System.Windows.Forms.DataGridView();
            this.Col_BlockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ImageWindow = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Col_MessageWindow = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Num_MessageWindowNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Num_ImageWindowNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_WindowIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_MessageWindowNum)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(65, 20);
            this.lbl_Title.Text = "配置窗口";
            // 
            // lbl_WindowNum
            // 
            this.lbl_WindowNum.AutoSize = true;
            this.lbl_WindowNum.Location = new System.Drawing.Point(58, 42);
            this.lbl_WindowNum.Name = "lbl_WindowNum";
            this.lbl_WindowNum.Size = new System.Drawing.Size(80, 17);
            this.lbl_WindowNum.TabIndex = 10;
            this.lbl_WindowNum.Text = "图像窗口数目";
            this.lbl_WindowNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Num_ImageWindowNum
            // 
            this.Num_ImageWindowNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num_ImageWindowNum.Location = new System.Drawing.Point(144, 40);
            this.Num_ImageWindowNum.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.Num_ImageWindowNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_ImageWindowNum.Name = "Num_ImageWindowNum";
            this.Num_ImageWindowNum.Size = new System.Drawing.Size(75, 23);
            this.Num_ImageWindowNum.TabIndex = 11;
            this.Num_ImageWindowNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_ImageWindowNum.ValueChanged += new System.EventHandler(this.Num_WindowNum_ValueChanged);
            // 
            // DG_WindowIndex
            // 
            this.DG_WindowIndex.AllowUserToAddRows = false;
            this.DG_WindowIndex.AllowUserToDeleteRows = false;
            this.DG_WindowIndex.AllowUserToResizeColumns = false;
            this.DG_WindowIndex.AllowUserToResizeRows = false;
            this.DG_WindowIndex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_WindowIndex.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_WindowIndex.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_WindowIndex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_WindowIndex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_BlockName,
            this.Col_ImageWindow,
            this.Col_MessageWindow});
            this.DG_WindowIndex.Location = new System.Drawing.Point(4, 69);
            this.DG_WindowIndex.Name = "DG_WindowIndex";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_WindowIndex.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_WindowIndex.RowHeadersVisible = false;
            this.DG_WindowIndex.RowTemplate.Height = 23;
            this.DG_WindowIndex.Size = new System.Drawing.Size(462, 375);
            this.DG_WindowIndex.TabIndex = 14;
            // 
            // Col_BlockName
            // 
            this.Col_BlockName.HeaderText = "算子名";
            this.Col_BlockName.Name = "Col_BlockName";
            this.Col_BlockName.ReadOnly = true;
            this.Col_BlockName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_ImageWindow
            // 
            this.Col_ImageWindow.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Col_ImageWindow.FillWeight = 40F;
            this.Col_ImageWindow.HeaderText = "图像窗口索引";
            this.Col_ImageWindow.Items.AddRange(new object[] {
            "0",
            "不显示"});
            this.Col_ImageWindow.Name = "Col_ImageWindow";
            // 
            // Col_MessageWindow
            // 
            this.Col_MessageWindow.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Col_MessageWindow.FillWeight = 40F;
            this.Col_MessageWindow.HeaderText = "消息窗口索引";
            this.Col_MessageWindow.Items.AddRange(new object[] {
            "0",
            "不显示"});
            this.Col_MessageWindow.Name = "Col_MessageWindow";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(391, 450);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.btn_Cancel.TabIndex = 19;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(310, 450);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 28);
            this.btn_OK.TabIndex = 18;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "消息窗口数目";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Num_MessageWindowNum
            // 
            this.Num_MessageWindowNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num_MessageWindowNum.Location = new System.Drawing.Point(322, 40);
            this.Num_MessageWindowNum.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.Num_MessageWindowNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_MessageWindowNum.Name = "Num_MessageWindowNum";
            this.Num_MessageWindowNum.Size = new System.Drawing.Size(72, 23);
            this.Num_MessageWindowNum.TabIndex = 21;
            this.Num_MessageWindowNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_MessageWindowNum.ValueChanged += new System.EventHandler(this.Num_MessageWindowNum_ValueChanged);
            // 
            // FrmConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(471, 485);
            this.Controls.Add(this.Num_MessageWindowNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.DG_WindowIndex);
            this.Controls.Add(this.Num_ImageWindowNum);
            this.Controls.Add(this.lbl_WindowNum);
            this.Name = "FrmConfigWindow";
            this.Text = "配置窗口";
            this.Controls.SetChildIndex(this.lbl_WindowNum, 0);
            this.Controls.SetChildIndex(this.Num_ImageWindowNum, 0);
            this.Controls.SetChildIndex(this.DG_WindowIndex, 0);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Num_MessageWindowNum, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Num_ImageWindowNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_WindowIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_MessageWindowNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_WindowNum;
        private System.Windows.Forms.NumericUpDown Num_ImageWindowNum;
        private System.Windows.Forms.DataGridView DG_WindowIndex;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Num_MessageWindowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_BlockName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col_ImageWindow;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col_MessageWindow;
    }
}