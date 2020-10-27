using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_Location.ContourMatchin
{
    public partial class Tools_ContourMatching : UserControl,IEvent 
    {
        private ContourMatchingClass _contourMatching;
        public event ClickOKButtonDelegate _clickOKButton;
        public event ClickCancelDelegate _clickCancelButton;
        private FrmContourMathing frmContourMatching;

        public Tools_ContourMatching(ContourMatchingClass contourMatching)
        {
            InitializeComponent();
            _contourMatching = contourMatching;
            Binding binding = new Binding("Text", _contourMatching,"BlockName");
            txt_Name.DataBindings.Add(binding);
            binding = new Binding("SelectedItem", _contourMatching, "ROI");
            cmb_ROI.DataBindings.Add(binding);
            binding = new Binding("Checked", _contourMatching, "DispResult");
            cb_DispResult.DataBindings.Add(binding);
            Initial_Reference();//添加引用
        }

        public void Initial_Reference()
        {
            List<ITools> tools = _contourMatching.SelectedNormalBlock.ToolsList.GetRange(0, FrmEdit._currentRowIndex + 1);
            if(tools != null)//首先判断该算子前有没有工具
            {
                List<ITools> roiTools = tools.FindAll(c => c.GetType().IsDefined(typeof(ROIAttribute), true));//查找出所有被标记了ROI的类
                foreach (ITools item in roiTools)
                {
                    cmb_ROI.Items.Add(item.BlockName);
                }
            }
        }

        private void btn_Set_Click(object sender, EventArgs e)//设置
        {
            if (WindowIndexDic[CurrentWindowIndex].Image != null && WindowIndexDic[CurrentWindowIndex].Image.IsInitialized())
            {
                if(WindowIndexDic[CurrentWindowIndex].Image.CountChannels() == 1)
                {
                    frmContourMatching = new FrmContourMathing(_contourMatching,cmb_ROI.SelectedItem.ToString());
                    frmContourMatching.ShowDialog();
                }
                else
                {
                    MessageBox.Show("只支持单通道图像！");
                }
            }
            else
            {
                MessageBox.Show("输入图像为空！");
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            _clickOKButton(_contourMatching);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            _clickCancelButton();
        }
    }
}
