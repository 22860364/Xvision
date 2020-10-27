namespace DispenseAPP.Tools_Measure.GeometricalRelation
{
    partial class Tools_GeometricalRelation
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
            this.tabControl_FindLine = new System.Windows.Forms.TabControl();
            this.tabPage_Base = new System.Windows.Forms.TabPage();
            this.panel_Basic = new System.Windows.Forms.Panel();
            this.lbl_ReferencePoint = new System.Windows.Forms.Label();
            this.lbl_CalibMode = new System.Windows.Forms.Label();
            this.cmb_GeometricFeature = new System.Windows.Forms.ComboBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_Limited = new System.Windows.Forms.TabPage();
            this.Panel_Limit = new System.Windows.Forms.Panel();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Tv_ReferencePoint = new System.Windows.Forms.TreeView();
            this.tabControl_FindLine.SuspendLayout();
            this.tabPage_Base.SuspendLayout();
            this.panel_Basic.SuspendLayout();
            this.tabPage_Limited.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_FindLine
            // 
            this.tabControl_FindLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabControl_FindLine.Controls.Add(this.tabPage_Base);
            this.tabControl_FindLine.Controls.Add(this.tabPage_Limited);
            this.tabControl_FindLine.ItemSize = new System.Drawing.Size(65, 18);
            this.tabControl_FindLine.Location = new System.Drawing.Point(0, 0);
            this.tabControl_FindLine.Multiline = true;
            this.tabControl_FindLine.Name = "tabControl_FindLine";
            this.tabControl_FindLine.SelectedIndex = 0;
            this.tabControl_FindLine.Size = new System.Drawing.Size(330, 364);
            this.tabControl_FindLine.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_FindLine.TabIndex = 19;
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
            this.panel_Basic.Controls.Add(this.Tv_ReferencePoint);
            this.panel_Basic.Controls.Add(this.lbl_ReferencePoint);
            this.panel_Basic.Controls.Add(this.lbl_CalibMode);
            this.panel_Basic.Controls.Add(this.cmb_GeometricFeature);
            this.panel_Basic.Controls.Add(this.txt_Name);
            this.panel_Basic.Controls.Add(this.label1);
            this.panel_Basic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Basic.Location = new System.Drawing.Point(3, 3);
            this.panel_Basic.Name = "panel_Basic";
            this.panel_Basic.Size = new System.Drawing.Size(316, 332);
            this.panel_Basic.TabIndex = 0;
            // 
            // lbl_ReferencePoint
            // 
            this.lbl_ReferencePoint.Location = new System.Drawing.Point(3, 98);
            this.lbl_ReferencePoint.Name = "lbl_ReferencePoint";
            this.lbl_ReferencePoint.Size = new System.Drawing.Size(67, 23);
            this.lbl_ReferencePoint.TabIndex = 7;
            this.lbl_ReferencePoint.Text = "引用点：";
            this.lbl_ReferencePoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_CalibMode
            // 
            this.lbl_CalibMode.Location = new System.Drawing.Point(3, 60);
            this.lbl_CalibMode.Name = "lbl_CalibMode";
            this.lbl_CalibMode.Size = new System.Drawing.Size(80, 23);
            this.lbl_CalibMode.TabIndex = 5;
            this.lbl_CalibMode.Text = "几何特征：";
            this.lbl_CalibMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_GeometricFeature
            // 
            this.cmb_GeometricFeature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_GeometricFeature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_GeometricFeature.FormattingEnabled = true;
            this.cmb_GeometricFeature.Items.AddRange(new object[] {
            "点到到距离（2点）",
            "点到线距离（3点）",
            "线到线距离（4点）",
            "直线拟合（任意点）",
            "圆拟合（任意点）",
            "椭圆拟合（任意点）",
            "矢量与水平轴夹角（2点）",
            "矢量与垂直轴夹角（2点）",
            "向量夹角（4点）",
            "直线交点（4点）",
            "线段中点（2点）"});
            this.cmb_GeometricFeature.Location = new System.Drawing.Point(89, 60);
            this.cmb_GeometricFeature.Name = "cmb_GeometricFeature";
            this.cmb_GeometricFeature.Size = new System.Drawing.Size(202, 25);
            this.cmb_GeometricFeature.TabIndex = 4;
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Name.Location = new System.Drawing.Point(89, 21);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(202, 23);
            this.txt_Name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "算子名：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage_Limited
            // 
            this.tabPage_Limited.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Limited.Controls.Add(this.Panel_Limit);
            this.tabPage_Limited.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Limited.Name = "tabPage_Limited";
            this.tabPage_Limited.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Limited.Size = new System.Drawing.Size(322, 338);
            this.tabPage_Limited.TabIndex = 2;
            this.tabPage_Limited.Text = "限制";
            // 
            // Panel_Limit
            // 
            this.Panel_Limit.AutoScroll = true;
            this.Panel_Limit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Limit.Location = new System.Drawing.Point(3, 3);
            this.Panel_Limit.Name = "Panel_Limit";
            this.Panel_Limit.Size = new System.Drawing.Size(316, 332);
            this.Panel_Limit.TabIndex = 0;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(224, 369);
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
            this.Btn_OK.Location = new System.Drawing.Point(122, 369);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 28);
            this.Btn_OK.TabIndex = 21;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Tv_ReferencePoint
            // 
            this.Tv_ReferencePoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tv_ReferencePoint.CheckBoxes = true;
            this.Tv_ReferencePoint.Location = new System.Drawing.Point(6, 124);
            this.Tv_ReferencePoint.Name = "Tv_ReferencePoint";
            this.Tv_ReferencePoint.Size = new System.Drawing.Size(285, 205);
            this.Tv_ReferencePoint.TabIndex = 8;
            // 
            // Tools_GeometricalRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.tabControl_FindLine);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Tools_GeometricalRelation";
            this.Size = new System.Drawing.Size(330, 400);
            this.tabControl_FindLine.ResumeLayout(false);
            this.tabPage_Base.ResumeLayout(false);
            this.panel_Basic.ResumeLayout(false);
            this.panel_Basic.PerformLayout();
            this.tabPage_Limited.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_FindLine;
        private System.Windows.Forms.TabPage tabPage_Base;
        private System.Windows.Forms.Panel panel_Basic;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_Limited;
        private System.Windows.Forms.Panel Panel_Limit;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Label lbl_CalibMode;
        private System.Windows.Forms.ComboBox cmb_GeometricFeature;
        private System.Windows.Forms.Label lbl_ReferencePoint;
        private System.Windows.Forms.TreeView Tv_ReferencePoint;
    }
}
