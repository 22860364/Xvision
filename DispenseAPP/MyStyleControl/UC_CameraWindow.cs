using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;
using CameraLibrary;
using System.ComponentModel;
using VisionWindow;
using System.Drawing;
using HalconDotNet;

namespace DispenseAPP.MyStyleControl
{
    public partial class UC_CameraWindow : UserControl
    {
        public UC_CameraWindow()
        {
            InitializeComponent();
            InitialControlAndCamera();
        }

        public Controller Control
        {
            get
            {
                return uC_MyWindow1.Control;
            }
        }

        public void ExecuteClose()
        {
            if(Camerable != null)
            {
                Camerable.StopAcquisition();
            }
        }
        private void UC_CameraWindow_Load(object sender, System.EventArgs e)
        {
            if (!DesignMode)
            {

            }
        }
        ICamerable Camerable = null;//表示当前选择的相机

        public void InitialControlAndCamera()//初始化控件和相机
        {
            //向下拉框中添加可用相机
            foreach (KeyValuePair<string, ICamerable> item in CameraIDObjectDict)
            {
                if (item.Value.CheckCameraAvailable())//检查该相机是否可用
                {
                    Tscmb_Camera.Items.Add(StaticPublicData.CameraDataItems[item.Key].CustomName);//添加自定义名称
                }
            }
            if (Tscmb_Camera.Items.Count > 0)
            {
                Tscmb_Camera.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 选择相机
        /// </summary>
        public void SelectCamera(string cameraName)
        {
            if(Tscmb_Camera.Items.Contains(cameraName))//如果下拉框中包含该相机名称 则改变下拉框的索引
            {
                Tscmb_Camera.SelectedIndex = Tscmb_Camera.Items.IndexOf(cameraName);
            }
        }

        void Tscmb_Camera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tscmb_Camera.SelectedIndex >= 0)
            {
                Tsbtn_ContinueAcq.Enabled = true;
                Tsbtn_SingleAcq.Enabled = true;
                Camerable = CameraIDObjectDict[StaticPublicData.CameraDataItems.Find(c => c.CustomName == Tscmb_Camera.Text).SystemName];
                Camerable.Register(SelectCamera_ImageCallBackEvent);
            }
        }

        void SelectCamera_ImageCallBackEvent(Bitmap bitmap, HImage hImage)
        {
            if (bitmap != null)
            {
                uC_MyWindow1.Control.DispImage(bitmap, hImage);
            }
        }

        void Tsbtn_SingleAcq_Click(object sender, EventArgs e)//单帧采集
        {
            Camerable.SingleFrameAcquisiton();
        }

        void Tsbtn_ContinueAcq_Click(object sender, EventArgs e)//实时采集
        {
            foreach (ToolStripItem item in Ts.Items)
            {
                item.Enabled = Tsbtn_ContinueAcq.Checked;
            }
            if (Tsbtn_ContinueAcq.Checked)
            {
                Camerable.StopAcquisition();
            }
            else
            {
                Camerable.ContinuousAcquisition();
                Tsbtn_ContinueAcq.Enabled = true;
            }
            Tsbtn_ContinueAcq.Checked = !Tsbtn_ContinueAcq.Checked;            
        }

        #region 显示属性相关
        private bool _dispImageAdaption = true;
        [Description("显示图像自适应按钮")]
        public bool DispImageAdaption
        {
            get { return _dispImageAdaption; }
            set
            {
                _dispImageAdaption = value;
                Tsbtn_ImageAdaptation.Visible = value;
                Tss_ImageAdaption.Visible = value;
            }
        }

        public bool _dispAvailableCamera = true;
        [Description("显示可用相机按钮")]
        public bool DispAvailableCamera
        {
            get { return _dispAvailableCamera; }
            set
            {
                _dispAvailableCamera = value;
                Tscmb_Camera.Visible = value;
                Tss_AvailableCamera.Visible = value;
            }
        }

        public bool _dispSingleAcq = true;
        [Description("显示单帧采集按钮")]
        public bool DispSingleAcq
        {
            get { return _dispSingleAcq; }
            set
            {
                _dispSingleAcq = value;
                Tsbtn_SingleAcq.Visible = value;
                Tss_SingleAcq.Visible = value;
            }
        }

        public bool _dispContinueAcq = true;
        [Description("显示连续采集按钮")]
        public bool DispContinueAcq
        {
            get { return _dispSingleAcq; }
            set
            {
                _dispContinueAcq = value;
                Tsbtn_ContinueAcq.Visible = value;
                Tss_ContinueAcq.Visible = value;
            }
        }

        public bool _dispDrawRectangle = true;
        [Description("显示画矩形按钮")]
        public bool DispDrawRectangle
        {
            get { return _dispDrawRectangle; }
            set
            {
                _dispDrawRectangle = value;
                Tsbtn_DrawRectangle.Visible = value;
                Tss_DrawRectangle.Visible = value;
            }
        }

        public bool _dispDrawRectangle2 = true;
        [Description("显示画旋转矩形按钮")]
        public bool DispDrawRectangle2
        {
            get { return _dispDrawRectangle2; }
            set
            {
                _dispDrawRectangle2 = value;
                Tsbtn_DrawRectangle2.Visible = value;
                Tss_DrawRectangle2.Visible = value;
            }
        }
        #endregion

        private void Tsbtn_DrawRectangle_Click(object sender, EventArgs e)
        {
          //  uC_MyWindow1.DrawRectangle();
        }

        private void Tsbtn_ImageAdaptation_Click(object sender, EventArgs e)
        {
            uC_MyWindow1.Control.ImageAdaptation();
        }

        private void Tsbtn_DrawRectangle2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
