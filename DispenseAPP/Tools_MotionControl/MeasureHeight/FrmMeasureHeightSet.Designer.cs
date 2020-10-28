namespace DispenseAPP.Tools_MotionControl.MeasureHeight
{
    partial class FrmMeasureHeightSet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMeasureHeightSet));
            this.DG_MeasureHeight = new System.Windows.Forms.DataGridView();
            this.Col_MeasureHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TS_Operation = new System.Windows.Forms.ToolStrip();
            this.Tssbtn_Add = new System.Windows.Forms.ToolStripButton();
            this.Tssbtn_Insert = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_Delete = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_Array = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Tsbtn_Up = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_Down = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_InvertOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Tssbtn_ModifPosition = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_LocateToXY = new System.Windows.Forms.ToolStripButton();
            this.Tsbtn_LocateToZ = new System.Windows.Forms.ToolStripButton();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Cmb_SelectCamera = new System.Windows.Forms.ComboBox();
            this.Btn_SingleFrame = new System.Windows.Forms.Button();
            this.Btn_ShowSet = new System.Windows.Forms.Button();
            this.Btn_ContinueFrame = new System.Windows.Forms.Button();
            this.UC_Image = new DispenseAPP.UC_Image();
            this.uC_AxisPositionState1 = new DispenseAPP.UC_AxisPositionState();
            ((System.ComponentModel.ISupportInitialize)(this.DG_MeasureHeight)).BeginInit();
            this.TS_Operation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.Location = new System.Drawing.Point(3, 1);
            this.lbl_ProjectName.Size = new System.Drawing.Size(65, 20);
            this.lbl_ProjectName.Text = "测高设置";
            // 
            // DG_MeasureHeight
            // 
            this.DG_MeasureHeight.AllowUserToAddRows = false;
            this.DG_MeasureHeight.AllowUserToDeleteRows = false;
            this.DG_MeasureHeight.AllowUserToResizeColumns = false;
            this.DG_MeasureHeight.AllowUserToResizeRows = false;
            this.DG_MeasureHeight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_MeasureHeight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_MeasureHeight.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_MeasureHeight.ColumnHeadersHeight = 22;
            this.DG_MeasureHeight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_MeasureHeight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_MeasureHeight});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_MeasureHeight.DefaultCellStyle = dataGridViewCellStyle2;
            this.DG_MeasureHeight.GridColor = System.Drawing.SystemColors.Control;
            this.DG_MeasureHeight.Location = new System.Drawing.Point(434, 58);
            this.DG_MeasureHeight.Name = "DG_MeasureHeight";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_MeasureHeight.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DG_MeasureHeight.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DG_MeasureHeight.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_MeasureHeight.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DG_MeasureHeight.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DG_MeasureHeight.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.DG_MeasureHeight.RowTemplate.Height = 23;
            this.DG_MeasureHeight.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_MeasureHeight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_MeasureHeight.Size = new System.Drawing.Size(360, 397);
            this.DG_MeasureHeight.TabIndex = 41;
            this.DG_MeasureHeight.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DG_MeasureHeight_RowPostPaint);
            // 
            // Col_MeasureHeight
            // 
            this.Col_MeasureHeight.HeaderText = "测高H";
            this.Col_MeasureHeight.Name = "Col_MeasureHeight";
            // 
            // TS_Operation
            // 
            this.TS_Operation.AutoSize = false;
            this.TS_Operation.Dock = System.Windows.Forms.DockStyle.None;
            this.TS_Operation.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.TS_Operation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tssbtn_Add,
            this.Tssbtn_Insert,
            this.Tsbtn_Delete,
            this.Tsbtn_Array,
            this.toolStripSeparator4,
            this.Tsbtn_Up,
            this.Tsbtn_Down,
            this.Tsbtn_InvertOrder,
            this.toolStripSeparator5,
            this.Tssbtn_ModifPosition,
            this.Tsbtn_LocateToXY,
            this.Tsbtn_LocateToZ});
            this.TS_Operation.Location = new System.Drawing.Point(434, 29);
            this.TS_Operation.Name = "TS_Operation";
            this.TS_Operation.Size = new System.Drawing.Size(360, 26);
            this.TS_Operation.TabIndex = 50;
            this.TS_Operation.Text = "toolStrip1";
            // 
            // Tssbtn_Add
            // 
            this.Tssbtn_Add.AutoSize = false;
            this.Tssbtn_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tssbtn_Add.Image = ((System.Drawing.Image)(resources.GetObject("Tssbtn_Add.Image")));
            this.Tssbtn_Add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tssbtn_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tssbtn_Add.Name = "Tssbtn_Add";
            this.Tssbtn_Add.Size = new System.Drawing.Size(28, 25);
            this.Tssbtn_Add.Text = "添加行";
            this.Tssbtn_Add.Click += new System.EventHandler(this.Tssbtn_Add_Click);
            // 
            // Tssbtn_Insert
            // 
            this.Tssbtn_Insert.AutoSize = false;
            this.Tssbtn_Insert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tssbtn_Insert.Image = ((System.Drawing.Image)(resources.GetObject("Tssbtn_Insert.Image")));
            this.Tssbtn_Insert.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tssbtn_Insert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tssbtn_Insert.Name = "Tssbtn_Insert";
            this.Tssbtn_Insert.Size = new System.Drawing.Size(28, 25);
            this.Tssbtn_Insert.Text = "插入行";
            this.Tssbtn_Insert.Click += new System.EventHandler(this.Tssbtn_Insert_Click);
            // 
            // Tsbtn_Delete
            // 
            this.Tsbtn_Delete.AutoSize = false;
            this.Tsbtn_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsbtn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_Delete.Image")));
            this.Tsbtn_Delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tsbtn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_Delete.Name = "Tsbtn_Delete";
            this.Tsbtn_Delete.Size = new System.Drawing.Size(28, 25);
            this.Tsbtn_Delete.Text = "删除行";
            this.Tsbtn_Delete.Click += new System.EventHandler(this.Tsbtn_Delete_Click);
            // 
            // Tsbtn_Array
            // 
            this.Tsbtn_Array.AutoSize = false;
            this.Tsbtn_Array.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsbtn_Array.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_Array.Image")));
            this.Tsbtn_Array.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tsbtn_Array.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_Array.Name = "Tsbtn_Array";
            this.Tsbtn_Array.Size = new System.Drawing.Size(28, 25);
            this.Tsbtn_Array.Text = "删除行";
            this.Tsbtn_Array.Click += new System.EventHandler(this.Tsbtn_Array_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 26);
            // 
            // Tsbtn_Up
            // 
            this.Tsbtn_Up.AutoSize = false;
            this.Tsbtn_Up.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsbtn_Up.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_Up.Image")));
            this.Tsbtn_Up.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tsbtn_Up.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_Up.Name = "Tsbtn_Up";
            this.Tsbtn_Up.Size = new System.Drawing.Size(28, 25);
            this.Tsbtn_Up.Text = "上移";
            this.Tsbtn_Up.Click += new System.EventHandler(this.Tsbtn_Up_Click);
            // 
            // Tsbtn_Down
            // 
            this.Tsbtn_Down.AutoSize = false;
            this.Tsbtn_Down.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsbtn_Down.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_Down.Image")));
            this.Tsbtn_Down.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tsbtn_Down.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_Down.Name = "Tsbtn_Down";
            this.Tsbtn_Down.Size = new System.Drawing.Size(28, 25);
            this.Tsbtn_Down.Text = "下移";
            this.Tsbtn_Down.Click += new System.EventHandler(this.Tsbtn_Down_Click);
            // 
            // Tsbtn_InvertOrder
            // 
            this.Tsbtn_InvertOrder.AutoSize = false;
            this.Tsbtn_InvertOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsbtn_InvertOrder.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_InvertOrder.Image")));
            this.Tsbtn_InvertOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tsbtn_InvertOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_InvertOrder.Name = "Tsbtn_InvertOrder";
            this.Tsbtn_InvertOrder.Size = new System.Drawing.Size(28, 25);
            this.Tsbtn_InvertOrder.Text = "下移";
            this.Tsbtn_InvertOrder.Click += new System.EventHandler(this.Tsbtn_InvertOrder_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 26);
            // 
            // Tssbtn_ModifPosition
            // 
            this.Tssbtn_ModifPosition.AutoSize = false;
            this.Tssbtn_ModifPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Tssbtn_ModifPosition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tssbtn_ModifPosition.Image = ((System.Drawing.Image)(resources.GetObject("Tssbtn_ModifPosition.Image")));
            this.Tssbtn_ModifPosition.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tssbtn_ModifPosition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tssbtn_ModifPosition.Name = "Tssbtn_ModifPosition";
            this.Tssbtn_ModifPosition.Size = new System.Drawing.Size(28, 25);
            this.Tssbtn_ModifPosition.Text = "更改坐标";
            this.Tssbtn_ModifPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tssbtn_ModifPosition.Click += new System.EventHandler(this.Tssbtn_ModifPosition_Click);
            // 
            // Tsbtn_LocateToXY
            // 
            this.Tsbtn_LocateToXY.AutoSize = false;
            this.Tsbtn_LocateToXY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Tsbtn_LocateToXY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsbtn_LocateToXY.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_LocateToXY.Image")));
            this.Tsbtn_LocateToXY.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tsbtn_LocateToXY.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_LocateToXY.Name = "Tsbtn_LocateToXY";
            this.Tsbtn_LocateToXY.Size = new System.Drawing.Size(28, 25);
            this.Tsbtn_LocateToXY.Text = "移动到XY坐标";
            this.Tsbtn_LocateToXY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tsbtn_LocateToZ
            // 
            this.Tsbtn_LocateToZ.AutoSize = false;
            this.Tsbtn_LocateToZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Tsbtn_LocateToZ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsbtn_LocateToZ.Image = ((System.Drawing.Image)(resources.GetObject("Tsbtn_LocateToZ.Image")));
            this.Tsbtn_LocateToZ.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tsbtn_LocateToZ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsbtn_LocateToZ.Name = "Tsbtn_LocateToZ";
            this.Tsbtn_LocateToZ.Size = new System.Drawing.Size(28, 25);
            this.Tsbtn_LocateToZ.Text = "移动到Z坐标";
            this.Tsbtn_LocateToZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(729, 630);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(66, 31);
            this.Btn_Cancel.TabIndex = 52;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(657, 630);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(66, 31);
            this.Btn_OK.TabIndex = 51;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            // 
            // Cmb_SelectCamera
            // 
            this.Cmb_SelectCamera.BackColor = System.Drawing.Color.White;
            this.Cmb_SelectCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_SelectCamera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_SelectCamera.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cmb_SelectCamera.FormattingEnabled = true;
            this.Cmb_SelectCamera.Items.AddRange(new object[] {
            "平面校正",
            "立体校正"});
            this.Cmb_SelectCamera.Location = new System.Drawing.Point(4, 30);
            this.Cmb_SelectCamera.Name = "Cmb_SelectCamera";
            this.Cmb_SelectCamera.Size = new System.Drawing.Size(138, 25);
            this.Cmb_SelectCamera.TabIndex = 54;
            this.Cmb_SelectCamera.SelectedIndexChanged += new System.EventHandler(this.Cmb_SelectCamera_SelectedIndexChanged);
            // 
            // Btn_SingleFrame
            // 
            this.Btn_SingleFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SingleFrame.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_SingleFrame.Location = new System.Drawing.Point(148, 30);
            this.Btn_SingleFrame.Name = "Btn_SingleFrame";
            this.Btn_SingleFrame.Size = new System.Drawing.Size(70, 25);
            this.Btn_SingleFrame.TabIndex = 56;
            this.Btn_SingleFrame.Text = "单帧采集";
            this.Btn_SingleFrame.UseVisualStyleBackColor = true;
            this.Btn_SingleFrame.Click += new System.EventHandler(this.Btn_SingleFrame_Click);
            // 
            // Btn_ShowSet
            // 
            this.Btn_ShowSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ShowSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_ShowSet.Location = new System.Drawing.Point(300, 30);
            this.Btn_ShowSet.Name = "Btn_ShowSet";
            this.Btn_ShowSet.Size = new System.Drawing.Size(70, 25);
            this.Btn_ShowSet.TabIndex = 58;
            this.Btn_ShowSet.Text = "显示设置";
            this.Btn_ShowSet.UseVisualStyleBackColor = true;
            this.Btn_ShowSet.Click += new System.EventHandler(this.Btn_ShowSet_Click);
            // 
            // Btn_ContinueFrame
            // 
            this.Btn_ContinueFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ContinueFrame.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_ContinueFrame.Location = new System.Drawing.Point(224, 30);
            this.Btn_ContinueFrame.Name = "Btn_ContinueFrame";
            this.Btn_ContinueFrame.Size = new System.Drawing.Size(70, 25);
            this.Btn_ContinueFrame.TabIndex = 59;
            this.Btn_ContinueFrame.Text = "实时采集";
            this.Btn_ContinueFrame.UseVisualStyleBackColor = true;
            this.Btn_ContinueFrame.Click += new System.EventHandler(this.Btn_ContinueFrame_Click);
            // 
            // UC_Image
            // 
            this.UC_Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.UC_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC_Image.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UC_Image.Location = new System.Drawing.Point(1, 58);
            this.UC_Image.Name = "UC_Image";
            this.UC_Image.Size = new System.Drawing.Size(430, 390);
            this.UC_Image.TabIndex = 60;
            // 
            // uC_AxisPositionState1
            // 
            this.uC_AxisPositionState1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uC_AxisPositionState1.AxisName = null;
            this.uC_AxisPositionState1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.uC_AxisPositionState1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uC_AxisPositionState1.Location = new System.Drawing.Point(1, 453);
            this.uC_AxisPositionState1.Name = "uC_AxisPositionState1";
            this.uC_AxisPositionState1.Size = new System.Drawing.Size(430, 208);
            this.uC_AxisPositionState1.TabIndex = 61;
            // 
            // FrmMeasureHeightSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(795, 665);
            this.Controls.Add(this.uC_AxisPositionState1);
            this.Controls.Add(this.UC_Image);
            this.Controls.Add(this.Btn_ContinueFrame);
            this.Controls.Add(this.Btn_ShowSet);
            this.Controls.Add(this.Btn_SingleFrame);
            this.Controls.Add(this.Cmb_SelectCamera);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.TS_Operation);
            this.Controls.Add(this.DG_MeasureHeight);
            this.Name = "FrmMeasureHeightSet";
            this.Text = "测高设置";
            this.TitleVisiable = false;
            this.Controls.SetChildIndex(this.DG_MeasureHeight, 0);
            this.Controls.SetChildIndex(this.TS_Operation, 0);
            this.Controls.SetChildIndex(this.Btn_OK, 0);
            this.Controls.SetChildIndex(this.Btn_Cancel, 0);
            this.Controls.SetChildIndex(this.Cmb_SelectCamera, 0);
            this.Controls.SetChildIndex(this.Btn_SingleFrame, 0);
            this.Controls.SetChildIndex(this.Btn_ShowSet, 0);
            this.Controls.SetChildIndex(this.Btn_ContinueFrame, 0);
            this.Controls.SetChildIndex(this.UC_Image, 0);
            this.Controls.SetChildIndex(this.uC_AxisPositionState1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DG_MeasureHeight)).EndInit();
            this.TS_Operation.ResumeLayout(false);
            this.TS_Operation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_MeasureHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MeasureHeight;
        private System.Windows.Forms.ToolStrip TS_Operation;
        private System.Windows.Forms.ToolStripButton Tsbtn_Delete;
        private System.Windows.Forms.ToolStripButton Tsbtn_Array;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton Tsbtn_Up;
        private System.Windows.Forms.ToolStripButton Tsbtn_Down;
        private System.Windows.Forms.ToolStripButton Tsbtn_InvertOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton Tssbtn_Add;
        private System.Windows.Forms.ToolStripButton Tssbtn_Insert;
        private System.Windows.Forms.ToolStripButton Tssbtn_ModifPosition;
        private System.Windows.Forms.ToolStripButton Tsbtn_LocateToXY;
        private System.Windows.Forms.ToolStripButton Tsbtn_LocateToZ;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.ComboBox Cmb_SelectCamera;
        private System.Windows.Forms.Button Btn_SingleFrame;
        private System.Windows.Forms.Button Btn_ShowSet;
        private System.Windows.Forms.Button Btn_ContinueFrame;
        private UC_Image UC_Image;
        private UC_AxisPositionState uC_AxisPositionState1;
    }
}