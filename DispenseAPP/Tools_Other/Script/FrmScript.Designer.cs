namespace DispenseAPP.Tools_Other.Script
{
    partial class FrmScript
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.elementHost_TextEditor = new System.Windows.Forms.Integration.ElementHost();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.btn_Compile = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.lb_BlockName = new System.Windows.Forms.ListBox();
            this.DG_Var = new System.Windows.Forms.DataGridView();
            this.ColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Var)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.Location = new System.Drawing.Point(3, 1);
            this.lbl_ProjectName.Size = new System.Drawing.Size(51, 20);
            this.lbl_ProjectName.Text = "写脚本";
            // 
            // elementHost_TextEditor
            // 
            this.elementHost_TextEditor.Location = new System.Drawing.Point(3, 28);
            this.elementHost_TextEditor.Name = "elementHost_TextEditor";
            this.elementHost_TextEditor.Size = new System.Drawing.Size(524, 450);
            this.elementHost_TextEditor.TabIndex = 1;
            this.elementHost_TextEditor.Text = "elementHost1";
            this.elementHost_TextEditor.Child = null;
            // 
            // txt_Message
            // 
            this.txt_Message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Message.Location = new System.Drawing.Point(3, 482);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(686, 64);
            this.txt_Message.TabIndex = 2;
            // 
            // btn_Compile
            // 
            this.btn_Compile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Compile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Compile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Compile.Location = new System.Drawing.Point(695, 482);
            this.btn_Compile.Name = "btn_Compile";
            this.btn_Compile.Size = new System.Drawing.Size(75, 28);
            this.btn_Compile.TabIndex = 4;
            this.btn_Compile.Text = "编译";
            this.btn_Compile.UseVisualStyleBackColor = true;
            this.btn_Compile.Click += new System.EventHandler(this.Btn_Compile_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(695, 516);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 28);
            this.btn_OK.TabIndex = 5;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // lb_BlockName
            // 
            this.lb_BlockName.FormattingEnabled = true;
            this.lb_BlockName.ItemHeight = 17;
            this.lb_BlockName.Location = new System.Drawing.Point(531, 32);
            this.lb_BlockName.Name = "lb_BlockName";
            this.lb_BlockName.Size = new System.Drawing.Size(245, 157);
            this.lb_BlockName.TabIndex = 6;
            // 
            // DG_Var
            // 
            this.DG_Var.AllowUserToAddRows = false;
            this.DG_Var.AllowUserToDeleteRows = false;
            this.DG_Var.AllowUserToResizeColumns = false;
            this.DG_Var.AllowUserToResizeRows = false;
            this.DG_Var.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Var.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Var.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_Var.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_Var.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColType,
            this.ColName,
            this.ColValue});
            this.DG_Var.Location = new System.Drawing.Point(531, 195);
            this.DG_Var.Name = "DG_Var";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Var.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DG_Var.RowHeadersVisible = false;
            this.DG_Var.RowTemplate.Height = 23;
            this.DG_Var.Size = new System.Drawing.Size(245, 281);
            this.DG_Var.TabIndex = 7;
            // 
            // ColType
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColType.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColType.FillWeight = 50F;
            this.ColType.HeaderText = "Type";
            this.ColType.Name = "ColType";
            this.ColType.ReadOnly = true;
            this.ColType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColName
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColName.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColValue
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColValue.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColValue.HeaderText = "Value";
            this.ColValue.Name = "ColValue";
            this.ColValue.ReadOnly = true;
            this.ColValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(780, 550);
            this.Controls.Add(this.DG_Var);
            this.Controls.Add(this.lb_BlockName);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Compile);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.elementHost_TextEditor);
            this.MaxVisible = false;
            this.Name = "FrmScript";
            this.Text = "写脚本";
            this.TitleVisiable = false;
            this.Controls.SetChildIndex(this.elementHost_TextEditor, 0);
            this.Controls.SetChildIndex(this.txt_Message, 0);
            this.Controls.SetChildIndex(this.btn_Compile, 0);
            this.Controls.SetChildIndex(this.btn_OK, 0);
            this.Controls.SetChildIndex(this.lb_BlockName, 0);
            this.Controls.SetChildIndex(this.DG_Var, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Var)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost_TextEditor;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.Button btn_Compile;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.ListBox lb_BlockName;
        private System.Windows.Forms.DataGridView DG_Var;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValue;
    }
}