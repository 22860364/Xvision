namespace DispenseAPP
{
    partial class FrmConfigMotionCard
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
            this.Lb_MotionCardType = new System.Windows.Forms.ListBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Lb_MotionCard = new System.Windows.Forms.ListBox();
            this.Num_HomeOrder = new System.Windows.Forms.NumericUpDown();
            this.lbl_HomeOrder = new System.Windows.Forms.Label();
            this.Btn_Config_Axis = new System.Windows.Forms.Button();
            this.Btn_Config_IO = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Config_Card = new System.Windows.Forms.Button();
            this.Btn_Config_Limit = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Num_HomeOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.Location = new System.Drawing.Point(3, 1);
            this.lbl_ProjectName.Size = new System.Drawing.Size(107, 20);
            this.lbl_ProjectName.Text = "配置运动控制卡";
            // 
            // Lb_MotionCardType
            // 
            this.Lb_MotionCardType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb_MotionCardType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_MotionCardType.FormattingEnabled = true;
            this.Lb_MotionCardType.ItemHeight = 17;
            this.Lb_MotionCardType.Items.AddRange(new object[] {
            "正运动",
            "固高",
            "研华",
            "凌华",
            "雷赛"});
            this.Lb_MotionCardType.Location = new System.Drawing.Point(1, 32);
            this.Lb_MotionCardType.Name = "Lb_MotionCardType";
            this.Lb_MotionCardType.Size = new System.Drawing.Size(127, 240);
            this.Lb_MotionCardType.TabIndex = 2;
            this.Lb_MotionCardType.SelectedIndexChanged += new System.EventHandler(this.Lb_MotionCardType_SelectedIndexChanged);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(405, 289);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.Btn_Cancel.TabIndex = 6;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(324, 289);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 28);
            this.Btn_OK.TabIndex = 5;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Lb_MotionCard
            // 
            this.Lb_MotionCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb_MotionCard.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_MotionCard.FormattingEnabled = true;
            this.Lb_MotionCard.ItemHeight = 17;
            this.Lb_MotionCard.Location = new System.Drawing.Point(137, 66);
            this.Lb_MotionCard.Name = "Lb_MotionCard";
            this.Lb_MotionCard.ScrollAlwaysVisible = true;
            this.Lb_MotionCard.Size = new System.Drawing.Size(262, 206);
            this.Lb_MotionCard.TabIndex = 8;
            this.Lb_MotionCard.SelectedIndexChanged += new System.EventHandler(this.Lb_MotionCard_SelectedIndexChanged);
            // 
            // Num_HomeOrder
            // 
            this.Num_HomeOrder.Location = new System.Drawing.Point(216, 33);
            this.Num_HomeOrder.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Num_HomeOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_HomeOrder.Name = "Num_HomeOrder";
            this.Num_HomeOrder.Size = new System.Drawing.Size(120, 23);
            this.Num_HomeOrder.TabIndex = 61;
            this.Num_HomeOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_HomeOrder
            // 
            this.lbl_HomeOrder.Location = new System.Drawing.Point(134, 32);
            this.lbl_HomeOrder.Name = "lbl_HomeOrder";
            this.lbl_HomeOrder.Size = new System.Drawing.Size(81, 23);
            this.lbl_HomeOrder.TabIndex = 60;
            this.lbl_HomeOrder.Text = "回零顺序：";
            this.lbl_HomeOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Config_Axis
            // 
            this.Btn_Config_Axis.Enabled = false;
            this.Btn_Config_Axis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Config_Axis.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Config_Axis.Location = new System.Drawing.Point(405, 140);
            this.Btn_Config_Axis.Name = "Btn_Config_Axis";
            this.Btn_Config_Axis.Size = new System.Drawing.Size(75, 26);
            this.Btn_Config_Axis.TabIndex = 63;
            this.Btn_Config_Axis.Text = "配置轴";
            this.Btn_Config_Axis.UseVisualStyleBackColor = true;
            this.Btn_Config_Axis.Click += new System.EventHandler(this.Btn_Config_Axis_Click);
            // 
            // Btn_Config_IO
            // 
            this.Btn_Config_IO.Enabled = false;
            this.Btn_Config_IO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Config_IO.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Config_IO.Location = new System.Drawing.Point(405, 175);
            this.Btn_Config_IO.Name = "Btn_Config_IO";
            this.Btn_Config_IO.Size = new System.Drawing.Size(75, 26);
            this.Btn_Config_IO.TabIndex = 64;
            this.Btn_Config_IO.Text = "配置IO";
            this.Btn_Config_IO.UseVisualStyleBackColor = true;
            this.Btn_Config_IO.Click += new System.EventHandler(this.Btn_Config_IO_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Enabled = false;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Add.Location = new System.Drawing.Point(405, 66);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 28);
            this.Btn_Add.TabIndex = 65;
            this.Btn_Add.Text = "添加";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Enabled = false;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Delete.Location = new System.Drawing.Point(405, 103);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 28);
            this.Btn_Delete.TabIndex = 66;
            this.Btn_Delete.Text = "删除";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Config_Card
            // 
            this.Btn_Config_Card.Enabled = false;
            this.Btn_Config_Card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Config_Card.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Config_Card.Location = new System.Drawing.Point(405, 245);
            this.Btn_Config_Card.Name = "Btn_Config_Card";
            this.Btn_Config_Card.Size = new System.Drawing.Size(75, 26);
            this.Btn_Config_Card.TabIndex = 69;
            this.Btn_Config_Card.Text = "配置卡";
            this.Btn_Config_Card.UseVisualStyleBackColor = true;
            this.Btn_Config_Card.Click += new System.EventHandler(this.Btn_Config_Card_Click);
            // 
            // Btn_Config_Limit
            // 
            this.Btn_Config_Limit.Enabled = false;
            this.Btn_Config_Limit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Config_Limit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Config_Limit.Location = new System.Drawing.Point(405, 210);
            this.Btn_Config_Limit.Name = "Btn_Config_Limit";
            this.Btn_Config_Limit.Size = new System.Drawing.Size(75, 26);
            this.Btn_Config_Limit.TabIndex = 70;
            this.Btn_Config_Limit.Text = "配置限位";
            this.Btn_Config_Limit.UseVisualStyleBackColor = true;
            this.Btn_Config_Limit.Click += new System.EventHandler(this.Btn_Config_Limit_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Enabled = false;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Save.Location = new System.Drawing.Point(351, 32);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(67, 24);
            this.Btn_Save.TabIndex = 71;
            this.Btn_Save.Text = "保存";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // FrmConfigMotionCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(484, 321);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Config_Limit);
            this.Controls.Add(this.Btn_Config_Card);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Btn_Config_IO);
            this.Controls.Add(this.Btn_Config_Axis);
            this.Controls.Add(this.Num_HomeOrder);
            this.Controls.Add(this.lbl_HomeOrder);
            this.Controls.Add(this.Lb_MotionCard);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Lb_MotionCardType);
            this.MaxVisible = false;
            this.Name = "FrmConfigMotionCard";
            this.Text = "配置运动控制卡";
            this.TitleVisiable = false;
            this.Controls.SetChildIndex(this.Lb_MotionCardType, 0);
            this.Controls.SetChildIndex(this.Btn_OK, 0);
            this.Controls.SetChildIndex(this.Btn_Cancel, 0);
            this.Controls.SetChildIndex(this.Lb_MotionCard, 0);
            this.Controls.SetChildIndex(this.lbl_HomeOrder, 0);
            this.Controls.SetChildIndex(this.Num_HomeOrder, 0);
            this.Controls.SetChildIndex(this.Btn_Config_Axis, 0);
            this.Controls.SetChildIndex(this.Btn_Config_IO, 0);
            this.Controls.SetChildIndex(this.Btn_Add, 0);
            this.Controls.SetChildIndex(this.Btn_Delete, 0);
            this.Controls.SetChildIndex(this.Btn_Config_Card, 0);
            this.Controls.SetChildIndex(this.Btn_Config_Limit, 0);
            this.Controls.SetChildIndex(this.Btn_Save, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Num_HomeOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lb_MotionCardType;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.ListBox Lb_MotionCard;
        private System.Windows.Forms.NumericUpDown Num_HomeOrder;
        private System.Windows.Forms.Label lbl_HomeOrder;
        private System.Windows.Forms.Button Btn_Config_Axis;
        private System.Windows.Forms.Button Btn_Config_IO;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Config_Card;
        private System.Windows.Forms.Button Btn_Config_Limit;
        private System.Windows.Forms.Button Btn_Save;
    }
}