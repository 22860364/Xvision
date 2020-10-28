namespace DispenseAPP
{
    partial class FrmConfigCamera
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCamera = new System.Windows.Forms.DataGridView();
            this.BbtnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.Col_CameraID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CustomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_AutoConnect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(65, 20);
            this.lbl_Title.Text = "配置相机";
            // 
            // dgvCamera
            // 
            this.dgvCamera.AllowUserToAddRows = false;
            this.dgvCamera.AllowUserToDeleteRows = false;
            this.dgvCamera.AllowUserToResizeColumns = false;
            this.dgvCamera.AllowUserToResizeRows = false;
            this.dgvCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCamera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCamera.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCamera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCamera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCamera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_CameraID,
            this.Col_CustomName,
            this.Col_AutoConnect});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCamera.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCamera.GridColor = System.Drawing.Color.Black;
            this.dgvCamera.Location = new System.Drawing.Point(2, 31);
            this.dgvCamera.MultiSelect = false;
            this.dgvCamera.Name = "dgvCamera";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCamera.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCamera.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCamera.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCamera.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvCamera.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCamera.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCamera.RowTemplate.Height = 25;
            this.dgvCamera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCamera.ShowCellErrors = false;
            this.dgvCamera.ShowCellToolTips = false;
            this.dgvCamera.ShowEditingIcon = false;
            this.dgvCamera.ShowRowErrors = false;
            this.dgvCamera.Size = new System.Drawing.Size(529, 244);
            this.dgvCamera.TabIndex = 21;
            this.dgvCamera.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DG_Camera_RowPostPaint);
            // 
            // BbtnCancel
            // 
            this.BbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BbtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BbtnCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BbtnCancel.Location = new System.Drawing.Point(462, 281);
            this.BbtnCancel.Name = "BbtnCancel";
            this.BbtnCancel.Size = new System.Drawing.Size(67, 28);
            this.BbtnCancel.TabIndex = 23;
            this.BbtnCancel.Text = "取 消";
            this.BbtnCancel.UseVisualStyleBackColor = true;
            this.BbtnCancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(391, 281);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(65, 28);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "确 定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Col_CameraID
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Col_CameraID.DefaultCellStyle = dataGridViewCellStyle2;
            this.Col_CameraID.HeaderText = "相机ID";
            this.Col_CameraID.Name = "Col_CameraID";
            this.Col_CameraID.ReadOnly = true;
            this.Col_CameraID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_CustomName
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Col_CustomName.DefaultCellStyle = dataGridViewCellStyle3;
            this.Col_CustomName.HeaderText = "用户定义名称";
            this.Col_CustomName.Name = "Col_CustomName";
            this.Col_CustomName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_AutoConnect
            // 
            this.Col_AutoConnect.FillWeight = 50F;
            this.Col_AutoConnect.HeaderText = "自动连接";
            this.Col_AutoConnect.Name = "Col_AutoConnect";
            this.Col_AutoConnect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FrmConfigCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(533, 314);
            this.Controls.Add(this.BbtnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvCamera);
            this.Name = "FrmConfigCamera";
            this.Text = "配置相机";
            this.Controls.SetChildIndex(this.dgvCamera, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.BbtnCancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCamera;
        private System.Windows.Forms.Button BbtnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CameraID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CustomName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_AutoConnect;
    }
}