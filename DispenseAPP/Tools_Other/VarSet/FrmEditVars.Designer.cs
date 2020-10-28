namespace DispenseAPP.Tools_Other.VarSet
{
    partial class FrmEditVars
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_EditVars = new System.Windows.Forms.DataGridView();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.num_ArraySize = new System.Windows.Forms.NumericUpDown();
            this.lbl_Type = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_EditVars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ArraySize)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_EditVars
            // 
            this.DG_EditVars.AllowUserToAddRows = false;
            this.DG_EditVars.AllowUserToDeleteRows = false;
            this.DG_EditVars.AllowUserToResizeColumns = false;
            this.DG_EditVars.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LemonChiffon;
            this.DG_EditVars.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_EditVars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_EditVars.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_EditVars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_EditVars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_EditVars.Location = new System.Drawing.Point(4, 30);
            this.DG_EditVars.Name = "DG_EditVars";
            this.DG_EditVars.RowHeadersWidth = 35;
            this.DG_EditVars.RowTemplate.Height = 23;
            this.DG_EditVars.Size = new System.Drawing.Size(417, 234);
            this.DG_EditVars.TabIndex = 1;
            this.DG_EditVars.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DG_EditVars_RowPostPaint);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(338, 269);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(77, 29);
            this.btn_Cancel.TabIndex = 45;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(232, 269);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(77, 29);
            this.btn_OK.TabIndex = 44;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // num_ArraySize
            // 
            this.num_ArraySize.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_ArraySize.Location = new System.Drawing.Point(87, 269);
            this.num_ArraySize.Name = "num_ArraySize";
            this.num_ArraySize.Size = new System.Drawing.Size(120, 26);
            this.num_ArraySize.TabIndex = 46;
            this.num_ArraySize.ValueChanged += new System.EventHandler(this.Num_ArraySize_ValueChanged);
            // 
            // lbl_Type
            // 
            this.lbl_Type.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Type.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Type.Location = new System.Drawing.Point(8, 269);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(73, 26);
            this.lbl_Type.TabIndex = 47;
            this.lbl_Type.Text = "数组大小";
            this.lbl_Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmEditVars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 300);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.num_ArraySize);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.DG_EditVars);
            this.Name = "FrmEditVars";
            this.Text = "编辑变量";
            this.Controls.SetChildIndex(this.DG_EditVars, 0);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.num_ArraySize, 0);
            this.Controls.SetChildIndex(this.lbl_Type, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DG_EditVars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ArraySize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_EditVars;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.NumericUpDown num_ArraySize;
        private System.Windows.Forms.Label lbl_Type;
    }
}