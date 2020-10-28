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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_WindowNum = new System.Windows.Forms.Label();
            this.num_WindowNum = new System.Windows.Forms.NumericUpDown();
            this.DG_WindowIndex = new System.Windows.Forms.DataGridView();
            this.ColBlockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIndex = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_WindowNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_WindowIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.Location = new System.Drawing.Point(3, 1);
            this.lbl_ProjectName.Size = new System.Drawing.Size(65, 20);
            this.lbl_ProjectName.Text = "配置窗口";
            // 
            // lbl_WindowNum
            // 
            this.lbl_WindowNum.Location = new System.Drawing.Point(5, 38);
            this.lbl_WindowNum.Name = "lbl_WindowNum";
            this.lbl_WindowNum.Size = new System.Drawing.Size(104, 24);
            this.lbl_WindowNum.TabIndex = 10;
            this.lbl_WindowNum.Text = "  窗口数目：";
            this.lbl_WindowNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_WindowNum
            // 
            this.num_WindowNum.Location = new System.Drawing.Point(225, 40);
            this.num_WindowNum.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.num_WindowNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_WindowNum.Name = "num_WindowNum";
            this.num_WindowNum.Size = new System.Drawing.Size(120, 23);
            this.num_WindowNum.TabIndex = 11;
            this.num_WindowNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_WindowNum.ValueChanged += new System.EventHandler(this.Num_WindowNum_ValueChanged);
            // 
            // DG_WindowIndex
            // 
            this.DG_WindowIndex.AllowUserToAddRows = false;
            this.DG_WindowIndex.AllowUserToDeleteRows = false;
            this.DG_WindowIndex.AllowUserToResizeColumns = false;
            this.DG_WindowIndex.AllowUserToResizeRows = false;
            this.DG_WindowIndex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_WindowIndex.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_WindowIndex.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DG_WindowIndex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_WindowIndex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColBlockName,
            this.ColIndex});
            this.DG_WindowIndex.Location = new System.Drawing.Point(8, 69);
            this.DG_WindowIndex.Name = "DG_WindowIndex";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_WindowIndex.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_WindowIndex.RowHeadersVisible = false;
            this.DG_WindowIndex.RowTemplate.Height = 23;
            this.DG_WindowIndex.Size = new System.Drawing.Size(337, 375);
            this.DG_WindowIndex.TabIndex = 14;
            // 
            // ColBlockName
            // 
            this.ColBlockName.HeaderText = "算子块名";
            this.ColBlockName.Name = "ColBlockName";
            this.ColBlockName.ReadOnly = true;
            this.ColBlockName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColIndex
            // 
            this.ColIndex.HeaderText = "窗口索引";
            this.ColIndex.Items.AddRange(new object[] {
            "1",
            "不显示"});
            this.ColIndex.Name = "ColIndex";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(213, 450);
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
            this.btn_OK.Location = new System.Drawing.Point(44, 450);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 28);
            this.btn_OK.TabIndex = 18;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // FrmConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(350, 482);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.DG_WindowIndex);
            this.Controls.Add(this.num_WindowNum);
            this.Controls.Add(this.lbl_WindowNum);
            this.MaxVisible = false;
            this.Name = "FrmConfigWindow";
            this.Text = "配置窗口";
            this.TitleVisiable = false;
            this.Controls.SetChildIndex(this.lbl_WindowNum, 0);
            this.Controls.SetChildIndex(this.num_WindowNum, 0);
            this.Controls.SetChildIndex(this.DG_WindowIndex, 0);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.num_WindowNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_WindowIndex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_WindowNum;
        private System.Windows.Forms.NumericUpDown num_WindowNum;
        private System.Windows.Forms.DataGridView DG_WindowIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBlockName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColIndex;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
    }
}