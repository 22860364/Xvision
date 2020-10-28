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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_Camera = new System.Windows.Forms.DataGridView();
            this.Col_CameraID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CustomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_AutoConnect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Camera)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.Location = new System.Drawing.Point(3, 1);
            this.lbl_ProjectName.Size = new System.Drawing.Size(65, 20);
            this.lbl_ProjectName.Text = "相机配置";
            // 
            // DG_Camera
            // 
            this.DG_Camera.AllowUserToAddRows = false;
            this.DG_Camera.AllowUserToDeleteRows = false;
            this.DG_Camera.AllowUserToResizeColumns = false;
            this.DG_Camera.AllowUserToResizeRows = false;
            this.DG_Camera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Camera.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Camera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DG_Camera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_Camera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_CameraID,
            this.Col_CustomName,
            this.Col_AutoConnect});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_Camera.DefaultCellStyle = dataGridViewCellStyle10;
            this.DG_Camera.GridColor = System.Drawing.Color.Black;
            this.DG_Camera.Location = new System.Drawing.Point(4, 32);
            this.DG_Camera.MultiSelect = false;
            this.DG_Camera.Name = "DG_Camera";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Camera.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DG_Camera.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DG_Camera.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DG_Camera.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DG_Camera.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DG_Camera.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DG_Camera.RowTemplate.Height = 25;
            this.DG_Camera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Camera.ShowCellErrors = false;
            this.DG_Camera.ShowCellToolTips = false;
            this.DG_Camera.ShowEditingIcon = false;
            this.DG_Camera.ShowRowErrors = false;
            this.DG_Camera.Size = new System.Drawing.Size(488, 244);
            this.DG_Camera.TabIndex = 21;
            this.DG_Camera.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DG_Camera_RowPostPaint);
            // 
            // Col_CameraID
            // 
            this.Col_CameraID.DataPropertyName = "CameraID";
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Col_CameraID.DefaultCellStyle = dataGridViewCellStyle8;
            this.Col_CameraID.HeaderText = "相机ID";
            this.Col_CameraID.Name = "Col_CameraID";
            this.Col_CameraID.ReadOnly = true;
            this.Col_CameraID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_CustomName
            // 
            this.Col_CustomName.DataPropertyName = "CustomName";
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Col_CustomName.DefaultCellStyle = dataGridViewCellStyle9;
            this.Col_CustomName.HeaderText = "用户定义名称";
            this.Col_CustomName.Name = "Col_CustomName";
            this.Col_CustomName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Col_AutoConnect
            // 
            this.Col_AutoConnect.DataPropertyName = "AutoConnect";
            this.Col_AutoConnect.FillWeight = 70F;
            this.Col_AutoConnect.HeaderText = "自动连接";
            this.Col_AutoConnect.Name = "Col_AutoConnect";
            this.Col_AutoConnect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(417, 282);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.Btn_Cancel.TabIndex = 23;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(321, 282);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 28);
            this.Btn_OK.TabIndex = 22;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // FrmConfigCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(497, 314);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.DG_Camera);
            this.MaxVisible = false;
            this.Name = "FrmConfigCamera";
            this.Text = "相机配置";
            this.TitleVisiable = false;
            this.Controls.SetChildIndex(this.DG_Camera, 0);
            this.Controls.SetChildIndex(this.Btn_OK, 0);
            this.Controls.SetChildIndex(this.Btn_Cancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Camera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Camera;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CameraID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CustomName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_AutoConnect;
    }
}