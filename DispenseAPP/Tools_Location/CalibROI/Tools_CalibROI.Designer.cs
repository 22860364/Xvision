namespace DispenseAPP.Tools_Location.CalibROI
{
    partial class Tools_CalibROI
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.tabControl_FindLine = new System.Windows.Forms.TabControl();
            this.tabPage_Base = new System.Windows.Forms.TabPage();
            this.panel_Basic = new System.Windows.Forms.Panel();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_Param = new System.Windows.Forms.TabPage();
            this.Panel_Param = new System.Windows.Forms.Panel();
            this.gb_ReferenceAngle = new System.Windows.Forms.GroupBox();
            this.clb_Angle = new System.Windows.Forms.CheckedListBox();
            this.gb_ReferencePoint = new System.Windows.Forms.GroupBox();
            this.clb_Point = new System.Windows.Forms.CheckedListBox();
            this.lbl_CalibMode = new System.Windows.Forms.Label();
            this.cmb_CalibMode = new System.Windows.Forms.ComboBox();
            this.tabControl_FindLine.SuspendLayout();
            this.tabPage_Base.SuspendLayout();
            this.panel_Basic.SuspendLayout();
            this.tabPage_Param.SuspendLayout();
            this.Panel_Param.SuspendLayout();
            this.gb_ReferenceAngle.SuspendLayout();
            this.gb_ReferencePoint.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(222, 371);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(127, 371);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 28);
            this.btn_OK.TabIndex = 19;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // tabControl_FindLine
            // 
            this.tabControl_FindLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabControl_FindLine.Controls.Add(this.tabPage_Base);
            this.tabControl_FindLine.Controls.Add(this.tabPage_Param);
            this.tabControl_FindLine.ItemSize = new System.Drawing.Size(65, 18);
            this.tabControl_FindLine.Location = new System.Drawing.Point(0, 1);
            this.tabControl_FindLine.Multiline = true;
            this.tabControl_FindLine.Name = "tabControl_FindLine";
            this.tabControl_FindLine.SelectedIndex = 0;
            this.tabControl_FindLine.Size = new System.Drawing.Size(330, 364);
            this.tabControl_FindLine.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_FindLine.TabIndex = 18;
            // 
            // tabPage_Base
            // 
            this.tabPage_Base.Controls.Add(this.panel_Basic);
            this.tabPage_Base.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage_Base.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Base.Name = "tabPage_Base";
            this.tabPage_Base.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Base.Size = new System.Drawing.Size(322, 338);
            this.tabPage_Base.TabIndex = 0;
            this.tabPage_Base.Text = "基本";
            this.tabPage_Base.UseVisualStyleBackColor = true;
            // 
            // panel_Basic
            // 
            this.panel_Basic.AutoScroll = true;
            this.panel_Basic.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Basic.Controls.Add(this.txt_Name);
            this.panel_Basic.Controls.Add(this.label1);
            this.panel_Basic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Basic.Location = new System.Drawing.Point(3, 3);
            this.panel_Basic.Name = "panel_Basic";
            this.panel_Basic.Size = new System.Drawing.Size(316, 332);
            this.panel_Basic.TabIndex = 0;
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Name.Location = new System.Drawing.Point(78, 21);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(190, 23);
            this.txt_Name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "算子名：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage_Param
            // 
            this.tabPage_Param.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Param.Controls.Add(this.Panel_Param);
            this.tabPage_Param.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Param.Name = "tabPage_Param";
            this.tabPage_Param.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Param.Size = new System.Drawing.Size(322, 338);
            this.tabPage_Param.TabIndex = 2;
            this.tabPage_Param.Text = "参数";
            // 
            // Panel_Param
            // 
            this.Panel_Param.AutoScroll = true;
            this.Panel_Param.Controls.Add(this.gb_ReferenceAngle);
            this.Panel_Param.Controls.Add(this.gb_ReferencePoint);
            this.Panel_Param.Controls.Add(this.lbl_CalibMode);
            this.Panel_Param.Controls.Add(this.cmb_CalibMode);
            this.Panel_Param.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Param.Location = new System.Drawing.Point(3, 3);
            this.Panel_Param.Name = "Panel_Param";
            this.Panel_Param.Size = new System.Drawing.Size(316, 332);
            this.Panel_Param.TabIndex = 0;
            // 
            // gb_ReferenceAngle
            // 
            this.gb_ReferenceAngle.Controls.Add(this.clb_Angle);
            this.gb_ReferenceAngle.Location = new System.Drawing.Point(15, 184);
            this.gb_ReferenceAngle.Name = "gb_ReferenceAngle";
            this.gb_ReferenceAngle.Size = new System.Drawing.Size(263, 145);
            this.gb_ReferenceAngle.TabIndex = 9;
            this.gb_ReferenceAngle.TabStop = false;
            this.gb_ReferenceAngle.Text = "参考角度";
            // 
            // clb_Angle
            // 
            this.clb_Angle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clb_Angle.CheckOnClick = true;
            this.clb_Angle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_Angle.FormattingEnabled = true;
            this.clb_Angle.Location = new System.Drawing.Point(3, 19);
            this.clb_Angle.Name = "clb_Angle";
            this.clb_Angle.Size = new System.Drawing.Size(257, 123);
            this.clb_Angle.TabIndex = 1;
            this.clb_Angle.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Clb_Angle_ItemCheck);
            // 
            // gb_ReferencePoint
            // 
            this.gb_ReferencePoint.Controls.Add(this.clb_Point);
            this.gb_ReferencePoint.Location = new System.Drawing.Point(15, 40);
            this.gb_ReferencePoint.Name = "gb_ReferencePoint";
            this.gb_ReferencePoint.Size = new System.Drawing.Size(263, 138);
            this.gb_ReferencePoint.TabIndex = 8;
            this.gb_ReferencePoint.TabStop = false;
            this.gb_ReferencePoint.Text = "参考点";
            // 
            // clb_Point
            // 
            this.clb_Point.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clb_Point.CheckOnClick = true;
            this.clb_Point.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_Point.FormattingEnabled = true;
            this.clb_Point.Location = new System.Drawing.Point(3, 19);
            this.clb_Point.Name = "clb_Point";
            this.clb_Point.Size = new System.Drawing.Size(257, 116);
            this.clb_Point.TabIndex = 0;
            this.clb_Point.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Clb_Point_ItemCheck);
            this.clb_Point.SelectedIndexChanged += new System.EventHandler(this.Clb_Point_SelectedIndexChanged);
            // 
            // lbl_CalibMode
            // 
            this.lbl_CalibMode.Location = new System.Drawing.Point(12, 9);
            this.lbl_CalibMode.Name = "lbl_CalibMode";
            this.lbl_CalibMode.Size = new System.Drawing.Size(80, 23);
            this.lbl_CalibMode.TabIndex = 3;
            this.lbl_CalibMode.Text = "校正方式：";
            this.lbl_CalibMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_CalibMode
            // 
            this.cmb_CalibMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CalibMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_CalibMode.FormattingEnabled = true;
            this.cmb_CalibMode.Items.AddRange(new object[] {
            "水平",
            "垂直",
            "水平&垂直",
            "水平&垂直&角度",
            "水平&角度",
            "垂直&角度"});
            this.cmb_CalibMode.Location = new System.Drawing.Point(98, 9);
            this.cmb_CalibMode.Name = "cmb_CalibMode";
            this.cmb_CalibMode.Size = new System.Drawing.Size(180, 25);
            this.cmb_CalibMode.TabIndex = 0;
            this.cmb_CalibMode.SelectedIndexChanged += new System.EventHandler(this.Cmb_CalibMode_SelectedIndexChanged);
            // 
            // Tools_CalibROI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tabControl_FindLine);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Tools_CalibROI";
            this.Size = new System.Drawing.Size(330, 400);
            this.Load += new System.EventHandler(this.Tools_CalibROI_Load);
            this.tabControl_FindLine.ResumeLayout(false);
            this.tabPage_Base.ResumeLayout(false);
            this.panel_Basic.ResumeLayout(false);
            this.panel_Basic.PerformLayout();
            this.tabPage_Param.ResumeLayout(false);
            this.Panel_Param.ResumeLayout(false);
            this.gb_ReferenceAngle.ResumeLayout(false);
            this.gb_ReferencePoint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TabControl tabControl_FindLine;
        private System.Windows.Forms.TabPage tabPage_Base;
        private System.Windows.Forms.Panel panel_Basic;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_Param;
        private System.Windows.Forms.Panel Panel_Param;
        private System.Windows.Forms.Label lbl_CalibMode;
        private System.Windows.Forms.ComboBox cmb_CalibMode;
        private System.Windows.Forms.GroupBox gb_ReferenceAngle;
        private System.Windows.Forms.GroupBox gb_ReferencePoint;
        private System.Windows.Forms.CheckedListBox clb_Angle;
        private System.Windows.Forms.CheckedListBox clb_Point;
    }
}
