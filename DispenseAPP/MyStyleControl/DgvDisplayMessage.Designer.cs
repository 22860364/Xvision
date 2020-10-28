namespace DispenseAPP.MyStyleControl
{
    partial class DgvDisplayMessage
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
            this.dgvMessage = new DispenseAPP.MyStyleControl.MyDataGridView();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBlockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRunMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCatchMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMessage
            // 
            this.dgvMessage.AllowUserToAddRows = false;
            this.dgvMessage.AllowUserToDeleteRows = false;
            this.dgvMessage.AllowUserToResizeColumns = false;
            this.dgvMessage.AllowUserToResizeRows = false;
            this.dgvMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMessage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMessage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTime,
            this.ColBlockName,
            this.ColStepName,
            this.ColRunMessage,
            this.ColCatchMessage});
            this.dgvMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMessage.Location = new System.Drawing.Point(0, 0);
            this.dgvMessage.Name = "dgvMessage";
            this.dgvMessage.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMessage.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMessage.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvMessage.RowTemplate.Height = 23;
            this.dgvMessage.Size = new System.Drawing.Size(708, 176);
            this.dgvMessage.TabIndex = 0;
            this.dgvMessage.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvMessage_RowPostPaint);
            // 
            // ColTime
            // 
            this.ColTime.FillWeight = 30F;
            this.ColTime.HeaderText = "时间";
            this.ColTime.Name = "ColTime";
            this.ColTime.ReadOnly = true;
            this.ColTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColBlockName
            // 
            this.ColBlockName.HeaderText = "算子名";
            this.ColBlockName.Name = "ColBlockName";
            this.ColBlockName.ReadOnly = true;
            this.ColBlockName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColStepName
            // 
            this.ColStepName.HeaderText = "工具名";
            this.ColStepName.Name = "ColStepName";
            this.ColStepName.ReadOnly = true;
            this.ColStepName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColRunMessage
            // 
            this.ColRunMessage.HeaderText = "运行消息";
            this.ColRunMessage.Name = "ColRunMessage";
            this.ColRunMessage.ReadOnly = true;
            this.ColRunMessage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColCatchMessage
            // 
            this.ColCatchMessage.HeaderText = "异常消息";
            this.ColCatchMessage.Name = "ColCatchMessage";
            this.ColCatchMessage.ReadOnly = true;
            this.ColCatchMessage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DgvDisplayMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dgvMessage);
            this.Name = "DgvDisplayMessage";
            this.Size = new System.Drawing.Size(708, 176);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyDataGridView dgvMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBlockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStepName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRunMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCatchMessage;
    }
}
