using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;
using HalconDotNet;

namespace DispenseAPP
{
    public partial class Tools_AcqImage : UserControl, IEvent
    {
        private AcqImageClass _acqImageClass;

        private bool AcquisitionBusy = false;// 采集繁忙

        private ICameraable SelectCamera;

        public event ClickOKButtonDelegate _clickOKButton;

        public event ClickCancelDelegate _clickCancelButton;

        public Tools_AcqImage(AcqImageClass acqImageClass)
        {
            InitializeComponent();
            _acqImageClass = acqImageClass;
            foreach (KeyValuePair<string, ICameraable> item in CameraIDObjectDict)//通过遍历来找到可用的相机
            {
                if (item.Value.CheckCameraAvailable() == true)
                {
                    TreeNode node = new TreeNode(CameraDataDic.Find(c => c.CameraID == item.Key).CustomName);
                    Tv_AvailCamera.Nodes.Add(node);
                }                
            }
            Txt_Name.DataBindings.Add("Text", _acqImageClass, "BlockName");
            Cb_ImageBackUp.DataBindings.Add("Checked", _acqImageClass, "EnableImageBackup");
            Cb_ImageCache.DataBindings.Add("Checked", _acqImageClass, "EnableImageCache");
            Cmb_ImageCache.SelectedIndex = Cmb_ImageCache.Items.IndexOf(_acqImageClass.ImageCache);
            if(_acqImageClass.SelectedCamera != null && FindTreeViewContainText()!= null)
            {
                Tv_AvailCamera.SelectedNode = FindTreeViewContainText();
                TreeView_AvailCamera_NodeMouseDoubleClick(Tv_AvailCamera, new TreeNodeMouseClickEventArgs(FindTreeViewContainText(), MouseButtons.Left, 2, 0, 0));
            }
        }

        private TreeNode FindTreeViewContainText()
        {
            TreeNode treeNode = null;
            foreach (TreeNode item in Tv_AvailCamera.Nodes)
            {
                if (item.Text == _acqImageClass.SelectedCamera)
                {
                    treeNode = item;
                }
            }
            return treeNode;
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (Txt_Name.Text == "")
            {
                MessageBox.Show("请输入算子名", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            if( !(_acqImageClass.BlockName != "" && _acqImageClass.BlockName == Txt_Name.Text))
            {
                if (_acqImageClass.SelectedNormalBlock.ToolsList.Find(c => c.BlockName == Txt_Name.Text) != null)
                {
                    MessageBox.Show("该算子名已经被使用！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            if (AcquisitionBusy == true)
            {
                SelectCamera.StopAcquisition();
                SelectCamera.ImageCallBackEvent -= SelectCamera_ImageCallBackEvent;
            }      
            _acqImageClass.BlockName = Txt_Name.Text;
            if(Tv_AvailCamera.SelectedNode != null)
            {
                _acqImageClass.SelectedCamera = Tv_AvailCamera.SelectedNode.Text;
            }     
            _acqImageClass.EnableImageBackup = Cb_ImageBackUp.Checked;//输出图像备份
            _acqImageClass.EnableImageCache = Cb_ImageCache.Checked;//图像缓存
            _acqImageClass.ImageCache = Cmb_ImageCache.SelectedItem.ToString();
            _clickOKButton(_acqImageClass);
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            if (AcquisitionBusy == true)
            {
                SelectCamera.StopAcquisition();
                SelectCamera.ImageCallBackEvent -= SelectCamera_ImageCallBackEvent;
            }
            _clickCancelButton();
        }

        private void TreeView_AvailCamera_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (AcquisitionBusy == true)
            {
                SelectCamera.StopAcquisition();
            }
            SelectCamera = CameraIDObjectDict[CameraDataDic.Find(c => c.CustomName == Tv_AvailCamera.SelectedNode.Text).CameraID];
            SelectCamera.ImageCallBackEvent += SelectCamera_ImageCallBackEvent;
            SelectCamera.ContinuousAcquisition();
            AcquisitionBusy = true;
        }

        private void SelectCamera_ImageCallBackEvent(HImage image)
        {
            WindowIndexDic[CurrentWindowIndex].DispImage(image, false);
        }

        private void Tv_AvailCamera_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            e.DrawDefault = true;
            return;
        }
    }
}
