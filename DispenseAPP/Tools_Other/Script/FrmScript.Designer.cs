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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.elementHost_TextEditor = new System.Windows.Forms.Integration.ElementHost();
            this.Txt_ErrorMessage = new System.Windows.Forms.TextBox();
            this.Btn_Run = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Lb_BlockName = new System.Windows.Forms.ListBox();
            this.DG_Var = new System.Windows.Forms.DataGridView();
            this.Btn_Compile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Var)).BeginInit();
            this.SuspendLayout();
            // 
            // elementHost_TextEditor
            // 
            this.elementHost_TextEditor.Location = new System.Drawing.Point(3, 28);
            this.elementHost_TextEditor.Name = "elementHost_TextEditor";
            this.elementHost_TextEditor.Size = new System.Drawing.Size(524, 422);
            this.elementHost_TextEditor.TabIndex = 1;
            this.elementHost_TextEditor.Text = "elementHost1";
            this.elementHost_TextEditor.Child = null;
            // 
            // Txt_ErrorMessage
            // 
            this.Txt_ErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_ErrorMessage.Location = new System.Drawing.Point(3, 456);
            this.Txt_ErrorMessage.Multiline = true;
            this.Txt_ErrorMessage.Name = "Txt_ErrorMessage";
            this.Txt_ErrorMessage.Size = new System.Drawing.Size(710, 90);
            this.Txt_ErrorMessage.TabIndex = 2;
            // 
            // Btn_Run
            // 
            this.Btn_Run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Run.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Run.Location = new System.Drawing.Point(719, 488);
            this.Btn_Run.Name = "Btn_Run";
            this.Btn_Run.Size = new System.Drawing.Size(75, 26);
            this.Btn_Run.TabIndex = 4;
            this.Btn_Run.Text = "运行";
            this.Btn_Run.UseVisualStyleBackColor = true;
            this.Btn_Run.Click += new System.EventHandler(this.Btn_Run_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(719, 520);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 26);
            this.Btn_OK.TabIndex = 5;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Lb_BlockName
            // 
            this.Lb_BlockName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb_BlockName.FormattingEnabled = true;
            this.Lb_BlockName.ItemHeight = 17;
            this.Lb_BlockName.Location = new System.Drawing.Point(531, 32);
            this.Lb_BlockName.Name = "Lb_BlockName";
            this.Lb_BlockName.ScrollAlwaysVisible = true;
            this.Lb_BlockName.Size = new System.Drawing.Size(263, 155);
            this.Lb_BlockName.TabIndex = 6;
            this.Lb_BlockName.SelectedIndexChanged += new System.EventHandler(this.Lb_BlockName_SelectedIndexChanged);
            // 
            // DG_Var
            // 
            this.DG_Var.AllowUserToAddRows = false;
            this.DG_Var.AllowUserToDeleteRows = false;
            this.DG_Var.AllowUserToResizeColumns = false;
            this.DG_Var.AllowUserToResizeRows = false;
            this.DG_Var.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Var.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Var.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_Var.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_Var.Location = new System.Drawing.Point(531, 193);
            this.DG_Var.Name = "DG_Var";
            this.DG_Var.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Var.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_Var.RowHeadersVisible = false;
            this.DG_Var.RowTemplate.Height = 23;
            this.DG_Var.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Var.Size = new System.Drawing.Size(263, 257);
            this.DG_Var.TabIndex = 7;
            this.DG_Var.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Var_CellDoubleClick);
            // 
            // Btn_Compile
            // 
            this.Btn_Compile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Compile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Compile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Compile.Location = new System.Drawing.Point(719, 456);
            this.Btn_Compile.Name = "Btn_Compile";
            this.Btn_Compile.Size = new System.Drawing.Size(75, 26);
            this.Btn_Compile.TabIndex = 8;
            this.Btn_Compile.Text = "编译";
            this.Btn_Compile.UseVisualStyleBackColor = true;
            this.Btn_Compile.Click += new System.EventHandler(this.Btn_Compile_Click);
            // 
            // FrmScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(795, 550);
            this.Controls.Add(this.Btn_Compile);
            this.Controls.Add(this.DG_Var);
            this.Controls.Add(this.Lb_BlockName);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Btn_Run);
            this.Controls.Add(this.Txt_ErrorMessage);
            this.Controls.Add(this.elementHost_TextEditor);
            this.Name = "FrmScript";
            this.Text = "写脚本";
            this.Controls.SetChildIndex(this.elementHost_TextEditor, 0);
            this.Controls.SetChildIndex(this.Txt_ErrorMessage, 0);
            this.Controls.SetChildIndex(this.Btn_Run, 0);
            this.Controls.SetChildIndex(this.Btn_OK, 0);
            this.Controls.SetChildIndex(this.Lb_BlockName, 0);
            this.Controls.SetChildIndex(this.DG_Var, 0);
            this.Controls.SetChildIndex(this.Btn_Compile, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Var)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost_TextEditor;
        private System.Windows.Forms.TextBox Txt_ErrorMessage;
        private System.Windows.Forms.Button Btn_Run;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.ListBox Lb_BlockName;
        private System.Windows.Forms.DataGridView DG_Var;
        private System.Windows.Forms.Button Btn_Compile;
    }
}