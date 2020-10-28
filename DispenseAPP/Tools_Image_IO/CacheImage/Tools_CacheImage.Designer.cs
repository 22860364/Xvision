namespace DispenseAPP.Tools_Image_IO.CacheImage
{
    partial class Tools_CacheImage
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("缓存队列1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("缓存队列2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("缓存队列3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("缓存队列4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("缓存队列5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("缓存队列6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("缓存队列7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("缓存队列8");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("缓存队列9");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("缓存队列10");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("图像缓存", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.tabControl_FindLine = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel_Basic = new System.Windows.Forms.Panel();
            this.lbl_SelectImage = new System.Windows.Forms.Label();
            this.Tv_Image = new System.Windows.Forms.TreeView();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_Output = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_ImageBackUp = new System.Windows.Forms.CheckBox();
            this.tabControl_FindLine.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel_Basic.SuspendLayout();
            this.tabPage_Output.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Cancel.Location = new System.Drawing.Point(248, 369);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.Btn_Cancel.TabIndex = 8;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_OK.Location = new System.Drawing.Point(148, 369);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 28);
            this.Btn_OK.TabIndex = 7;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // tabControl_FindLine
            // 
            this.tabControl_FindLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabControl_FindLine.Controls.Add(this.tabPage1);
            this.tabControl_FindLine.Controls.Add(this.tabPage_Output);
            this.tabControl_FindLine.ItemSize = new System.Drawing.Size(65, 18);
            this.tabControl_FindLine.Location = new System.Drawing.Point(0, 0);
            this.tabControl_FindLine.Multiline = true;
            this.tabControl_FindLine.Name = "tabControl_FindLine";
            this.tabControl_FindLine.SelectedIndex = 0;
            this.tabControl_FindLine.Size = new System.Drawing.Size(330, 363);
            this.tabControl_FindLine.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_FindLine.TabIndex = 6;
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
            this.panel_Basic.Controls.Add(this.lbl_SelectImage);
            this.panel_Basic.Controls.Add(this.Tv_Image);
            this.panel_Basic.Controls.Add(this.Txt_Name);
            this.panel_Basic.Controls.Add(this.label1);
            this.panel_Basic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Basic.Location = new System.Drawing.Point(3, 3);
            this.panel_Basic.Name = "panel_Basic";
            this.panel_Basic.Size = new System.Drawing.Size(316, 331);
            this.panel_Basic.TabIndex = 0;
            // 
            // lbl_SelectImage
            // 
            this.lbl_SelectImage.Location = new System.Drawing.Point(3, 55);
            this.lbl_SelectImage.Name = "lbl_SelectImage";
            this.lbl_SelectImage.Size = new System.Drawing.Size(76, 23);
            this.lbl_SelectImage.TabIndex = 5;
            this.lbl_SelectImage.Text = "选择图像：";
            this.lbl_SelectImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tv_Image
            // 
            this.Tv_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tv_Image.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.Tv_Image.HideSelection = false;
            this.Tv_Image.Location = new System.Drawing.Point(6, 81);
            this.Tv_Image.Name = "Tv_Image";
            treeNode1.Name = "BufferQueue1";
            treeNode1.Text = "缓存队列1";
            treeNode2.Name = "BufferQueue2";
            treeNode2.Text = "缓存队列2";
            treeNode3.Name = "BufferQueue3";
            treeNode3.Text = "缓存队列3";
            treeNode4.Name = "BufferQueue4";
            treeNode4.Text = "缓存队列4";
            treeNode5.Name = "BufferQueue5";
            treeNode5.Text = "缓存队列5";
            treeNode6.Name = "BufferQueue6";
            treeNode6.Text = "缓存队列6";
            treeNode7.Name = "BufferQueue7";
            treeNode7.Text = "缓存队列7";
            treeNode8.Name = "BufferQueue8";
            treeNode8.Text = "缓存队列8";
            treeNode9.Name = "BufferQueue9";
            treeNode9.Text = "缓存队列9";
            treeNode10.Name = "BufferQueue10";
            treeNode10.Text = "缓存队列10";
            treeNode11.Name = "ImageCache";
            treeNode11.Text = "图像缓存";
            this.Tv_Image.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.Tv_Image.Size = new System.Drawing.Size(284, 234);
            this.Tv_Image.TabIndex = 4;
            this.Tv_Image.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.Tv_Image_DrawNode);
            this.Tv_Image.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Tv_Image_NodeMouseClick);
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
            // tabPage_Output
            // 
            this.tabPage_Output.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Output.Controls.Add(this.panel1);
            this.tabPage_Output.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Output.Name = "tabPage_Output";
            this.tabPage_Output.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Output.Size = new System.Drawing.Size(322, 337);
            this.tabPage_Output.TabIndex = 2;
            this.tabPage_Output.Text = "输出";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.cb_ImageBackUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 331);
            this.panel1.TabIndex = 0;
            // 
            // cb_ImageBackUp
            // 
            this.cb_ImageBackUp.Checked = true;
            this.cb_ImageBackUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ImageBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ImageBackUp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_ImageBackUp.Location = new System.Drawing.Point(22, 19);
            this.cb_ImageBackUp.Name = "cb_ImageBackUp";
            this.cb_ImageBackUp.Size = new System.Drawing.Size(117, 24);
            this.cb_ImageBackUp.TabIndex = 2;
            this.cb_ImageBackUp.Text = "输出图像备份";
            this.cb_ImageBackUp.UseVisualStyleBackColor = true;
            // 
            // Tools_CacheImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.tabControl_FindLine);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Tools_CacheImage";
            this.Size = new System.Drawing.Size(330, 400);
            this.Load += new System.EventHandler(this.Tools_CacheImage_Load);
            this.tabControl_FindLine.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel_Basic.ResumeLayout(false);
            this.panel_Basic.PerformLayout();
            this.tabPage_Output.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.TabControl tabControl_FindLine;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel_Basic;
        private System.Windows.Forms.Label lbl_SelectImage;
        private System.Windows.Forms.TreeView Tv_Image;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_Output;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_ImageBackUp;
    }
}
