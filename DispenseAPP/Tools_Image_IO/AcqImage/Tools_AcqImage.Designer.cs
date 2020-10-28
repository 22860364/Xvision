namespace DispenseAPP
{
    partial class Tools_AcqImage
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
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.tabPage_Output = new System.Windows.Forms.TabPage();
            this.Panel_Out = new System.Windows.Forms.Panel();
            this.Cmb_ImageCache = new System.Windows.Forms.ComboBox();
            this.Cb_ImageCache = new System.Windows.Forms.CheckBox();
            this.Cb_ImageBackUp = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel_Basic = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Tv_AvailCamera = new System.Windows.Forms.TreeView();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tc_AcqImage = new System.Windows.Forms.TabControl();
            this.tabPage_Output.SuspendLayout();
            this.Panel_Out.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel_Basic.SuspendLayout();
            this.Tc_AcqImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(248, 368);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.Btn_Cancel.TabIndex = 5;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(146, 368);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 28);
            this.Btn_OK.TabIndex = 4;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // tabPage_Output
            // 
            this.tabPage_Output.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Output.Controls.Add(this.Panel_Out);
            this.tabPage_Output.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Output.Name = "tabPage_Output";
            this.tabPage_Output.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Output.Size = new System.Drawing.Size(322, 337);
            this.tabPage_Output.TabIndex = 2;
            this.tabPage_Output.Text = "输出";
            // 
            // Panel_Out
            // 
            this.Panel_Out.AutoScroll = true;
            this.Panel_Out.Controls.Add(this.Cmb_ImageCache);
            this.Panel_Out.Controls.Add(this.Cb_ImageCache);
            this.Panel_Out.Controls.Add(this.Cb_ImageBackUp);
            this.Panel_Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Out.Location = new System.Drawing.Point(3, 3);
            this.Panel_Out.Name = "Panel_Out";
            this.Panel_Out.Size = new System.Drawing.Size(316, 331);
            this.Panel_Out.TabIndex = 0;
            // 
            // Cmb_ImageCache
            // 
            this.Cmb_ImageCache.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_ImageCache.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_ImageCache.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cmb_ImageCache.FormattingEnabled = true;
            this.Cmb_ImageCache.Items.AddRange(new object[] {
            "缓存队列1",
            "缓存队列2",
            "缓存队列3",
            "缓存队列4",
            "缓存队列5",
            "缓存队列6",
            "缓存队列7",
            "缓存队列8",
            "缓存队列9",
            "缓存队列10"});
            this.Cmb_ImageCache.Location = new System.Drawing.Point(126, 56);
            this.Cmb_ImageCache.Name = "Cmb_ImageCache";
            this.Cmb_ImageCache.Size = new System.Drawing.Size(145, 25);
            this.Cmb_ImageCache.TabIndex = 7;
            // 
            // Cb_ImageCache
            // 
            this.Cb_ImageCache.Checked = true;
            this.Cb_ImageCache.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_ImageCache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cb_ImageCache.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cb_ImageCache.Location = new System.Drawing.Point(22, 57);
            this.Cb_ImageCache.Name = "Cb_ImageCache";
            this.Cb_ImageCache.Size = new System.Drawing.Size(98, 24);
            this.Cb_ImageCache.TabIndex = 3;
            this.Cb_ImageCache.Text = "图像缓存：";
            this.Cb_ImageCache.UseVisualStyleBackColor = true;
            // 
            // Cb_ImageBackUp
            // 
            this.Cb_ImageBackUp.Checked = true;
            this.Cb_ImageBackUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_ImageBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cb_ImageBackUp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cb_ImageBackUp.Location = new System.Drawing.Point(22, 19);
            this.Cb_ImageBackUp.Name = "Cb_ImageBackUp";
            this.Cb_ImageBackUp.Size = new System.Drawing.Size(117, 24);
            this.Cb_ImageBackUp.TabIndex = 2;
            this.Cb_ImageBackUp.Text = "输出图像备份";
            this.Cb_ImageBackUp.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel_Basic);
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(322, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel_Basic
            // 
            this.panel_Basic.AutoScroll = true;
            this.panel_Basic.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Basic.Controls.Add(this.label2);
            this.panel_Basic.Controls.Add(this.Tv_AvailCamera);
            this.panel_Basic.Controls.Add(this.Txt_Name);
            this.panel_Basic.Controls.Add(this.label1);
            this.panel_Basic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Basic.Location = new System.Drawing.Point(3, 3);
            this.panel_Basic.Name = "panel_Basic";
            this.panel_Basic.Size = new System.Drawing.Size(316, 331);
            this.panel_Basic.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "可用相机：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tv_AvailCamera
            // 
            this.Tv_AvailCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tv_AvailCamera.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.Tv_AvailCamera.Location = new System.Drawing.Point(6, 81);
            this.Tv_AvailCamera.Name = "Tv_AvailCamera";
            this.Tv_AvailCamera.ShowLines = false;
            this.Tv_AvailCamera.ShowPlusMinus = false;
            this.Tv_AvailCamera.ShowRootLines = false;
            this.Tv_AvailCamera.Size = new System.Drawing.Size(284, 247);
            this.Tv_AvailCamera.TabIndex = 4;
            this.Tv_AvailCamera.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.Tv_AvailCamera_DrawNode);
            this.Tv_AvailCamera.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_AvailCamera_NodeMouseDoubleClick);
            // 
            // Txt_Name
            // 
            this.Txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_Name.Location = new System.Drawing.Point(63, 19);
            this.Txt_Name.Multiline = true;
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(213, 23);
            this.Txt_Name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "算子名：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tc_AcqImage
            // 
            this.Tc_AcqImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Tc_AcqImage.Controls.Add(this.tabPage1);
            this.Tc_AcqImage.Controls.Add(this.tabPage_Output);
            this.Tc_AcqImage.ItemSize = new System.Drawing.Size(65, 18);
            this.Tc_AcqImage.Location = new System.Drawing.Point(0, 3);
            this.Tc_AcqImage.Multiline = true;
            this.Tc_AcqImage.Name = "Tc_AcqImage";
            this.Tc_AcqImage.SelectedIndex = 0;
            this.Tc_AcqImage.Size = new System.Drawing.Size(330, 363);
            this.Tc_AcqImage.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tc_AcqImage.TabIndex = 3;
            // 
            // Tools_AcqImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Tc_AcqImage);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Tools_AcqImage";
            this.Size = new System.Drawing.Size(330, 400);
            this.tabPage_Output.ResumeLayout(false);
            this.Panel_Out.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel_Basic.ResumeLayout(false);
            this.panel_Basic.PerformLayout();
            this.Tc_AcqImage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.TabPage tabPage_Output;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel_Basic;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Tc_AcqImage;
        private System.Windows.Forms.Panel Panel_Out;
        private System.Windows.Forms.CheckBox Cb_ImageCache;
        private System.Windows.Forms.CheckBox Cb_ImageBackUp;
        private System.Windows.Forms.ComboBox Cmb_ImageCache;
        private System.Windows.Forms.TreeView Tv_AvailCamera;
        private System.Windows.Forms.Label label2;
    }
}
