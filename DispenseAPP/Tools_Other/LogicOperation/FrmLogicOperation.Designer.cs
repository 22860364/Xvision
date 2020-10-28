namespace DispenseAPP.Tools_Other.LogicOperation
{
    partial class FrmLogicOperation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lb_BlockName = new System.Windows.Forms.ListBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Txt_Code = new System.Windows.Forms.TextBox();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.Btn_Calculate = new System.Windows.Forms.Button();
            this.Btn_One = new System.Windows.Forms.Button();
            this.Btn_Two = new System.Windows.Forms.Button();
            this.Btn_Three = new System.Windows.Forms.Button();
            this.Btn_Six = new System.Windows.Forms.Button();
            this.Btn_Five = new System.Windows.Forms.Button();
            this.Btn_Four = new System.Windows.Forms.Button();
            this.Btn_Nine = new System.Windows.Forms.Button();
            this.Btn_Eight = new System.Windows.Forms.Button();
            this.Btn_Seven = new System.Windows.Forms.Button();
            this.Btn_Zero = new System.Windows.Forms.Button();
            this.Btn_RadixPoint = new System.Windows.Forms.Button();
            this.Btn_Greater = new System.Windows.Forms.Button();
            this.Btn_GreateOrEqual = new System.Windows.Forms.Button();
            this.Btn_LessThan = new System.Windows.Forms.Button();
            this.Btn_LessThanOrEqual = new System.Windows.Forms.Button();
            this.Btn_Equal = new System.Windows.Forms.Button();
            this.Btn_NotEqual = new System.Windows.Forms.Button();
            this.Btn_RightParentheses = new System.Windows.Forms.Button();
            this.Btn_LeftParentheses = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Subtract = new System.Windows.Forms.Button();
            this.Btn_Divide = new System.Windows.Forms.Button();
            this.Btn_Multiply = new System.Windows.Forms.Button();
            this.Btn_False = new System.Windows.Forms.Button();
            this.Btn_True = new System.Windows.Forms.Button();
            this.Btn_Or = new System.Windows.Forms.Button();
            this.Btn_And = new System.Windows.Forms.Button();
            this.DG_Name_Value = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Name_Value)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(65, 20);
            this.lbl_Title.Text = "逻辑运算";
            // 
            // Lb_BlockName
            // 
            this.Lb_BlockName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Lb_BlockName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb_BlockName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_BlockName.FormattingEnabled = true;
            this.Lb_BlockName.ItemHeight = 17;
            this.Lb_BlockName.Location = new System.Drawing.Point(466, 32);
            this.Lb_BlockName.Name = "Lb_BlockName";
            this.Lb_BlockName.ScrollAlwaysVisible = true;
            this.Lb_BlockName.Size = new System.Drawing.Size(326, 189);
            this.Lb_BlockName.TabIndex = 2;
            this.Lb_BlockName.SelectedIndexChanged += new System.EventHandler(this.Lb_BlockName_SelectedIndexChanged);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(717, 505);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.Btn_Cancel.TabIndex = 22;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(621, 505);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 28);
            this.Btn_OK.TabIndex = 21;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Txt_Code
            // 
            this.Txt_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Txt_Code.Location = new System.Drawing.Point(1, 30);
            this.Txt_Code.Multiline = true;
            this.Txt_Code.Name = "Txt_Code";
            this.Txt_Code.Size = new System.Drawing.Size(459, 292);
            this.Txt_Code.TabIndex = 23;
            // 
            // txt_Result
            // 
            this.txt_Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txt_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Result.Location = new System.Drawing.Point(2, 328);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ReadOnly = true;
            this.txt_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Result.Size = new System.Drawing.Size(378, 69);
            this.txt_Result.TabIndex = 24;
            // 
            // Btn_Calculate
            // 
            this.Btn_Calculate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Calculate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Calculate.Location = new System.Drawing.Point(385, 328);
            this.Btn_Calculate.Name = "Btn_Calculate";
            this.Btn_Calculate.Size = new System.Drawing.Size(75, 69);
            this.Btn_Calculate.TabIndex = 25;
            this.Btn_Calculate.Text = "计算";
            this.Btn_Calculate.UseVisualStyleBackColor = true;
            this.Btn_Calculate.Click += new System.EventHandler(this.Btn_Calculate_Click);
            // 
            // Btn_One
            // 
            this.Btn_One.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_One.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_One.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_One.Location = new System.Drawing.Point(291, 403);
            this.Btn_One.Name = "Btn_One";
            this.Btn_One.Size = new System.Drawing.Size(52, 28);
            this.Btn_One.TabIndex = 26;
            this.Btn_One.Text = "1";
            this.Btn_One.UseVisualStyleBackColor = true;
            this.Btn_One.Click += new System.EventHandler(this.Btn_One_Click);
            // 
            // Btn_Two
            // 
            this.Btn_Two.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Two.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Two.Location = new System.Drawing.Point(349, 403);
            this.Btn_Two.Name = "Btn_Two";
            this.Btn_Two.Size = new System.Drawing.Size(52, 28);
            this.Btn_Two.TabIndex = 27;
            this.Btn_Two.Text = "2";
            this.Btn_Two.UseVisualStyleBackColor = true;
            this.Btn_Two.Click += new System.EventHandler(this.Btn_Two_Click);
            // 
            // Btn_Three
            // 
            this.Btn_Three.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Three.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Three.Location = new System.Drawing.Point(407, 403);
            this.Btn_Three.Name = "Btn_Three";
            this.Btn_Three.Size = new System.Drawing.Size(52, 28);
            this.Btn_Three.TabIndex = 28;
            this.Btn_Three.Text = "3";
            this.Btn_Three.UseVisualStyleBackColor = true;
            this.Btn_Three.Click += new System.EventHandler(this.Btn_Three_Click);
            // 
            // Btn_Six
            // 
            this.Btn_Six.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Six.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Six.Location = new System.Drawing.Point(407, 437);
            this.Btn_Six.Name = "Btn_Six";
            this.Btn_Six.Size = new System.Drawing.Size(52, 28);
            this.Btn_Six.TabIndex = 31;
            this.Btn_Six.Text = "6";
            this.Btn_Six.UseVisualStyleBackColor = true;
            this.Btn_Six.Click += new System.EventHandler(this.Btn_Six_Click);
            // 
            // Btn_Five
            // 
            this.Btn_Five.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Five.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Five.Location = new System.Drawing.Point(349, 437);
            this.Btn_Five.Name = "Btn_Five";
            this.Btn_Five.Size = new System.Drawing.Size(52, 28);
            this.Btn_Five.TabIndex = 30;
            this.Btn_Five.Text = "5";
            this.Btn_Five.UseVisualStyleBackColor = true;
            this.Btn_Five.Click += new System.EventHandler(this.Btn_Five_Click);
            // 
            // Btn_Four
            // 
            this.Btn_Four.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Four.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Four.Location = new System.Drawing.Point(291, 437);
            this.Btn_Four.Name = "Btn_Four";
            this.Btn_Four.Size = new System.Drawing.Size(52, 28);
            this.Btn_Four.TabIndex = 29;
            this.Btn_Four.Text = "4";
            this.Btn_Four.UseVisualStyleBackColor = true;
            this.Btn_Four.Click += new System.EventHandler(this.Btn_Four_Click);
            // 
            // Btn_Nine
            // 
            this.Btn_Nine.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nine.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Nine.Location = new System.Drawing.Point(407, 471);
            this.Btn_Nine.Name = "Btn_Nine";
            this.Btn_Nine.Size = new System.Drawing.Size(52, 28);
            this.Btn_Nine.TabIndex = 34;
            this.Btn_Nine.Text = "9";
            this.Btn_Nine.UseVisualStyleBackColor = true;
            this.Btn_Nine.Click += new System.EventHandler(this.Btn_Nine_Click);
            // 
            // Btn_Eight
            // 
            this.Btn_Eight.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eight.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Eight.Location = new System.Drawing.Point(349, 471);
            this.Btn_Eight.Name = "Btn_Eight";
            this.Btn_Eight.Size = new System.Drawing.Size(52, 28);
            this.Btn_Eight.TabIndex = 33;
            this.Btn_Eight.Text = "8";
            this.Btn_Eight.UseVisualStyleBackColor = true;
            this.Btn_Eight.Click += new System.EventHandler(this.Btn_Eight_Click);
            // 
            // Btn_Seven
            // 
            this.Btn_Seven.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Seven.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Seven.Location = new System.Drawing.Point(291, 471);
            this.Btn_Seven.Name = "Btn_Seven";
            this.Btn_Seven.Size = new System.Drawing.Size(52, 28);
            this.Btn_Seven.TabIndex = 32;
            this.Btn_Seven.Text = "7";
            this.Btn_Seven.UseVisualStyleBackColor = true;
            this.Btn_Seven.Click += new System.EventHandler(this.Btn_Seven_Click);
            // 
            // Btn_Zero
            // 
            this.Btn_Zero.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Zero.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Zero.Location = new System.Drawing.Point(291, 505);
            this.Btn_Zero.Name = "Btn_Zero";
            this.Btn_Zero.Size = new System.Drawing.Size(110, 28);
            this.Btn_Zero.TabIndex = 35;
            this.Btn_Zero.Text = "0";
            this.Btn_Zero.UseVisualStyleBackColor = true;
            this.Btn_Zero.Click += new System.EventHandler(this.Btn_Zero_Click);
            // 
            // Btn_RadixPoint
            // 
            this.Btn_RadixPoint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_RadixPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_RadixPoint.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_RadixPoint.Location = new System.Drawing.Point(407, 505);
            this.Btn_RadixPoint.Name = "Btn_RadixPoint";
            this.Btn_RadixPoint.Size = new System.Drawing.Size(52, 28);
            this.Btn_RadixPoint.TabIndex = 36;
            this.Btn_RadixPoint.Text = ".";
            this.Btn_RadixPoint.UseVisualStyleBackColor = true;
            this.Btn_RadixPoint.Click += new System.EventHandler(this.Btn_RadixPoint_Click);
            // 
            // Btn_Greater
            // 
            this.Btn_Greater.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Greater.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Greater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Greater.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Greater.Location = new System.Drawing.Point(2, 403);
            this.Btn_Greater.Name = "Btn_Greater";
            this.Btn_Greater.Size = new System.Drawing.Size(52, 28);
            this.Btn_Greater.TabIndex = 37;
            this.Btn_Greater.Text = ">";
            this.Btn_Greater.UseVisualStyleBackColor = true;
            this.Btn_Greater.Click += new System.EventHandler(this.Btn_Greater_Click);
            // 
            // Btn_GreateOrEqual
            // 
            this.Btn_GreateOrEqual.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_GreateOrEqual.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_GreateOrEqual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Btn_GreateOrEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_GreateOrEqual.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_GreateOrEqual.Location = new System.Drawing.Point(2, 437);
            this.Btn_GreateOrEqual.Name = "Btn_GreateOrEqual";
            this.Btn_GreateOrEqual.Size = new System.Drawing.Size(52, 28);
            this.Btn_GreateOrEqual.TabIndex = 38;
            this.Btn_GreateOrEqual.Text = ">=";
            this.Btn_GreateOrEqual.UseVisualStyleBackColor = true;
            this.Btn_GreateOrEqual.Click += new System.EventHandler(this.Btn_GreateOrEqual_Click);
            // 
            // Btn_LessThan
            // 
            this.Btn_LessThan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_LessThan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LessThan.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_LessThan.Location = new System.Drawing.Point(2, 471);
            this.Btn_LessThan.Name = "Btn_LessThan";
            this.Btn_LessThan.Size = new System.Drawing.Size(52, 28);
            this.Btn_LessThan.TabIndex = 39;
            this.Btn_LessThan.Text = "<";
            this.Btn_LessThan.UseVisualStyleBackColor = true;
            this.Btn_LessThan.Click += new System.EventHandler(this.Btn_LessThan_Click);
            // 
            // Btn_LessThanOrEqual
            // 
            this.Btn_LessThanOrEqual.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_LessThanOrEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LessThanOrEqual.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_LessThanOrEqual.Location = new System.Drawing.Point(2, 505);
            this.Btn_LessThanOrEqual.Name = "Btn_LessThanOrEqual";
            this.Btn_LessThanOrEqual.Size = new System.Drawing.Size(52, 28);
            this.Btn_LessThanOrEqual.TabIndex = 40;
            this.Btn_LessThanOrEqual.Text = "<=";
            this.Btn_LessThanOrEqual.UseVisualStyleBackColor = true;
            this.Btn_LessThanOrEqual.Click += new System.EventHandler(this.Btn_LessThanOrEqual_Click);
            // 
            // Btn_Equal
            // 
            this.Btn_Equal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Equal.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Equal.Location = new System.Drawing.Point(60, 403);
            this.Btn_Equal.Name = "Btn_Equal";
            this.Btn_Equal.Size = new System.Drawing.Size(52, 28);
            this.Btn_Equal.TabIndex = 41;
            this.Btn_Equal.Text = "==";
            this.Btn_Equal.UseVisualStyleBackColor = true;
            this.Btn_Equal.Click += new System.EventHandler(this.Btn_Equal_Click);
            // 
            // Btn_NotEqual
            // 
            this.Btn_NotEqual.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_NotEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NotEqual.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_NotEqual.Location = new System.Drawing.Point(60, 437);
            this.Btn_NotEqual.Name = "Btn_NotEqual";
            this.Btn_NotEqual.Size = new System.Drawing.Size(52, 28);
            this.Btn_NotEqual.TabIndex = 42;
            this.Btn_NotEqual.Text = "!=";
            this.Btn_NotEqual.UseVisualStyleBackColor = true;
            this.Btn_NotEqual.Click += new System.EventHandler(this.Btn_NotEqual_Click);
            // 
            // Btn_RightParentheses
            // 
            this.Btn_RightParentheses.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_RightParentheses.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_RightParentheses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_RightParentheses.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_RightParentheses.Location = new System.Drawing.Point(60, 505);
            this.Btn_RightParentheses.Name = "Btn_RightParentheses";
            this.Btn_RightParentheses.Size = new System.Drawing.Size(52, 28);
            this.Btn_RightParentheses.TabIndex = 44;
            this.Btn_RightParentheses.Text = ")";
            this.Btn_RightParentheses.UseVisualStyleBackColor = true;
            this.Btn_RightParentheses.Click += new System.EventHandler(this.Btn_RightParentheses_Click);
            // 
            // Btn_LeftParentheses
            // 
            this.Btn_LeftParentheses.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_LeftParentheses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LeftParentheses.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_LeftParentheses.Location = new System.Drawing.Point(60, 471);
            this.Btn_LeftParentheses.Name = "Btn_LeftParentheses";
            this.Btn_LeftParentheses.Size = new System.Drawing.Size(52, 28);
            this.Btn_LeftParentheses.TabIndex = 43;
            this.Btn_LeftParentheses.Text = "(";
            this.Btn_LeftParentheses.UseVisualStyleBackColor = true;
            this.Btn_LeftParentheses.Click += new System.EventHandler(this.Btn_LeftParentheses_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Add.Location = new System.Drawing.Point(118, 403);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(52, 28);
            this.Btn_Add.TabIndex = 45;
            this.Btn_Add.Text = "+";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Subtract
            // 
            this.Btn_Subtract.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Subtract.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Subtract.Location = new System.Drawing.Point(118, 437);
            this.Btn_Subtract.Name = "Btn_Subtract";
            this.Btn_Subtract.Size = new System.Drawing.Size(52, 28);
            this.Btn_Subtract.TabIndex = 46;
            this.Btn_Subtract.Text = "-";
            this.Btn_Subtract.UseVisualStyleBackColor = true;
            this.Btn_Subtract.Click += new System.EventHandler(this.Btn_Subtract_Click);
            // 
            // Btn_Divide
            // 
            this.Btn_Divide.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Divide.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Divide.Location = new System.Drawing.Point(118, 505);
            this.Btn_Divide.Name = "Btn_Divide";
            this.Btn_Divide.Size = new System.Drawing.Size(52, 28);
            this.Btn_Divide.TabIndex = 48;
            this.Btn_Divide.Text = "/";
            this.Btn_Divide.UseVisualStyleBackColor = true;
            this.Btn_Divide.Click += new System.EventHandler(this.Btn_Divide_Click);
            // 
            // Btn_Multiply
            // 
            this.Btn_Multiply.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Multiply.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Multiply.Location = new System.Drawing.Point(118, 471);
            this.Btn_Multiply.Name = "Btn_Multiply";
            this.Btn_Multiply.Size = new System.Drawing.Size(52, 28);
            this.Btn_Multiply.TabIndex = 47;
            this.Btn_Multiply.Text = "*";
            this.Btn_Multiply.UseVisualStyleBackColor = true;
            this.Btn_Multiply.Click += new System.EventHandler(this.Btn_Multiply_Click);
            // 
            // Btn_False
            // 
            this.Btn_False.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_False.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_False.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_False.Location = new System.Drawing.Point(176, 505);
            this.Btn_False.Name = "Btn_False";
            this.Btn_False.Size = new System.Drawing.Size(52, 28);
            this.Btn_False.TabIndex = 52;
            this.Btn_False.Text = "false";
            this.Btn_False.UseVisualStyleBackColor = true;
            this.Btn_False.Click += new System.EventHandler(this.Btn_False_Click);
            // 
            // Btn_True
            // 
            this.Btn_True.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_True.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_True.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_True.Location = new System.Drawing.Point(176, 471);
            this.Btn_True.Name = "Btn_True";
            this.Btn_True.Size = new System.Drawing.Size(52, 28);
            this.Btn_True.TabIndex = 51;
            this.Btn_True.Text = "true";
            this.Btn_True.UseVisualStyleBackColor = true;
            this.Btn_True.Click += new System.EventHandler(this.Btn_True_Click);
            // 
            // Btn_Or
            // 
            this.Btn_Or.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Or.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Or.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Or.Location = new System.Drawing.Point(176, 437);
            this.Btn_Or.Name = "Btn_Or";
            this.Btn_Or.Size = new System.Drawing.Size(52, 28);
            this.Btn_Or.TabIndex = 50;
            this.Btn_Or.Text = "||";
            this.Btn_Or.UseVisualStyleBackColor = true;
            this.Btn_Or.Click += new System.EventHandler(this.Btn_Or_Click);
            // 
            // Btn_And
            // 
            this.Btn_And.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_And.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_And.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_And.Location = new System.Drawing.Point(176, 403);
            this.Btn_And.Name = "Btn_And";
            this.Btn_And.Size = new System.Drawing.Size(52, 28);
            this.Btn_And.TabIndex = 49;
            this.Btn_And.Text = "&&&&";
            this.Btn_And.UseVisualStyleBackColor = true;
            this.Btn_And.Click += new System.EventHandler(this.Btn_And_Click);
            // 
            // DG_Name_Value
            // 
            this.DG_Name_Value.AllowUserToAddRows = false;
            this.DG_Name_Value.AllowUserToDeleteRows = false;
            this.DG_Name_Value.AllowUserToResizeColumns = false;
            this.DG_Name_Value.AllowUserToResizeRows = false;
            this.DG_Name_Value.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Name_Value.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Name_Value.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_Name_Value.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_Name_Value.Location = new System.Drawing.Point(466, 227);
            this.DG_Name_Value.Name = "DG_Name_Value";
            this.DG_Name_Value.ReadOnly = true;
            this.DG_Name_Value.RowHeadersVisible = false;
            this.DG_Name_Value.RowTemplate.Height = 23;
            this.DG_Name_Value.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Name_Value.Size = new System.Drawing.Size(326, 272);
            this.DG_Name_Value.TabIndex = 1;
            this.DG_Name_Value.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Name_Value_CellDoubleClick);
            // 
            // FrmLogicOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(793, 537);
            this.Controls.Add(this.Btn_False);
            this.Controls.Add(this.Btn_True);
            this.Controls.Add(this.Btn_Or);
            this.Controls.Add(this.Btn_And);
            this.Controls.Add(this.Btn_Divide);
            this.Controls.Add(this.Btn_Multiply);
            this.Controls.Add(this.Btn_Subtract);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Btn_RightParentheses);
            this.Controls.Add(this.Btn_LeftParentheses);
            this.Controls.Add(this.Btn_NotEqual);
            this.Controls.Add(this.Btn_Equal);
            this.Controls.Add(this.Btn_LessThanOrEqual);
            this.Controls.Add(this.Btn_LessThan);
            this.Controls.Add(this.Btn_GreateOrEqual);
            this.Controls.Add(this.Btn_Greater);
            this.Controls.Add(this.Btn_RadixPoint);
            this.Controls.Add(this.Btn_Zero);
            this.Controls.Add(this.Btn_Nine);
            this.Controls.Add(this.Btn_Eight);
            this.Controls.Add(this.Btn_Seven);
            this.Controls.Add(this.Btn_Six);
            this.Controls.Add(this.Btn_Five);
            this.Controls.Add(this.Btn_Four);
            this.Controls.Add(this.Btn_Three);
            this.Controls.Add(this.Btn_Two);
            this.Controls.Add(this.Btn_One);
            this.Controls.Add(this.Btn_Calculate);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.Txt_Code);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Lb_BlockName);
            this.Controls.Add(this.DG_Name_Value);
            this.Name = "FrmLogicOperation";
            this.Text = "逻辑运算";
            this.Load += new System.EventHandler(this.FrmLogicOperation_Load);
            this.Controls.SetChildIndex(this.DG_Name_Value, 0);
            this.Controls.SetChildIndex(this.Lb_BlockName, 0);
            this.Controls.SetChildIndex(this.Btn_OK, 0);
            this.Controls.SetChildIndex(this.Btn_Cancel, 0);
            this.Controls.SetChildIndex(this.Txt_Code, 0);
            this.Controls.SetChildIndex(this.txt_Result, 0);
            this.Controls.SetChildIndex(this.Btn_Calculate, 0);
            this.Controls.SetChildIndex(this.Btn_One, 0);
            this.Controls.SetChildIndex(this.Btn_Two, 0);
            this.Controls.SetChildIndex(this.Btn_Three, 0);
            this.Controls.SetChildIndex(this.Btn_Four, 0);
            this.Controls.SetChildIndex(this.Btn_Five, 0);
            this.Controls.SetChildIndex(this.Btn_Six, 0);
            this.Controls.SetChildIndex(this.Btn_Seven, 0);
            this.Controls.SetChildIndex(this.Btn_Eight, 0);
            this.Controls.SetChildIndex(this.Btn_Nine, 0);
            this.Controls.SetChildIndex(this.Btn_Zero, 0);
            this.Controls.SetChildIndex(this.Btn_RadixPoint, 0);
            this.Controls.SetChildIndex(this.Btn_Greater, 0);
            this.Controls.SetChildIndex(this.Btn_GreateOrEqual, 0);
            this.Controls.SetChildIndex(this.Btn_LessThan, 0);
            this.Controls.SetChildIndex(this.Btn_LessThanOrEqual, 0);
            this.Controls.SetChildIndex(this.Btn_Equal, 0);
            this.Controls.SetChildIndex(this.Btn_NotEqual, 0);
            this.Controls.SetChildIndex(this.Btn_LeftParentheses, 0);
            this.Controls.SetChildIndex(this.Btn_RightParentheses, 0);
            this.Controls.SetChildIndex(this.Btn_Add, 0);
            this.Controls.SetChildIndex(this.Btn_Subtract, 0);
            this.Controls.SetChildIndex(this.Btn_Multiply, 0);
            this.Controls.SetChildIndex(this.Btn_Divide, 0);
            this.Controls.SetChildIndex(this.Btn_And, 0);
            this.Controls.SetChildIndex(this.Btn_Or, 0);
            this.Controls.SetChildIndex(this.Btn_True, 0);
            this.Controls.SetChildIndex(this.Btn_False, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Name_Value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Lb_BlockName;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.TextBox Txt_Code;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Button Btn_Calculate;
        private System.Windows.Forms.Button Btn_One;
        private System.Windows.Forms.Button Btn_Two;
        private System.Windows.Forms.Button Btn_Three;
        private System.Windows.Forms.Button Btn_Six;
        private System.Windows.Forms.Button Btn_Five;
        private System.Windows.Forms.Button Btn_Four;
        private System.Windows.Forms.Button Btn_Nine;
        private System.Windows.Forms.Button Btn_Eight;
        private System.Windows.Forms.Button Btn_Seven;
        private System.Windows.Forms.Button Btn_Zero;
        private System.Windows.Forms.Button Btn_RadixPoint;
        private System.Windows.Forms.Button Btn_Greater;
        private System.Windows.Forms.Button Btn_GreateOrEqual;
        private System.Windows.Forms.Button Btn_LessThan;
        private System.Windows.Forms.Button Btn_LessThanOrEqual;
        private System.Windows.Forms.Button Btn_Equal;
        private System.Windows.Forms.Button Btn_NotEqual;
        private System.Windows.Forms.Button Btn_RightParentheses;
        private System.Windows.Forms.Button Btn_LeftParentheses;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Subtract;
        private System.Windows.Forms.Button Btn_Divide;
        private System.Windows.Forms.Button Btn_Multiply;
        private System.Windows.Forms.Button Btn_False;
        private System.Windows.Forms.Button Btn_True;
        private System.Windows.Forms.Button Btn_Or;
        private System.Windows.Forms.Button Btn_And;
        private System.Windows.Forms.DataGridView DG_Name_Value;
    }
}