using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DispenseAPP.MyStyleControl;
using DispenseAPP.Tools_Location.ContourMatchin;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_Location.SearchingOfContour
{
    public partial class SeachOfContourToolControl : UserControlTool
    {
        public SeachOfContourToolControl(SearchOfContourToolEntity entity)
        {
            InitializeComponent();
            Entity = entity;
            txtName.Text = entity.StepCustomName;
        }

        /// <summary>
        /// 轮廓搜索对象
        /// </summary>
        SearchOfContourToolEntity Entity { get; set; } = null;

        /// <summary>
        /// 点击设置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSet_Click(object sender, EventArgs e)
        {
            if(ImageWindowIndexDic[0].Control._Bitmap == null)
            {
                MessageBox.Show("输入图像为空...");
                return;
            }
            FrmContourMathing frmContourMathing = new FrmContourMathing(Entity, ImageWindowIndexDic[0].Control);
            frmContourMathing.ShowDialog();
        }

        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            if(!ClickOKCheck(Entity.StepCustomName, Entity.SelectedOperatorBlock.ToolList))
            {
                return;
            }
            Entity.StepCustomName = txtName.Text.Trim();
            base.BtnOK_Click(sender, e);
        }

        protected override bool ClickOKCheck(string stepName, List<IToolable> toolableList)
        {
            return base.ClickOKCheck(stepName, toolableList);
        }
    }
}
