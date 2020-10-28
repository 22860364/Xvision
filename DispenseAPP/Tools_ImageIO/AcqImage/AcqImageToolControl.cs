using System;
using DispenseAPP.MyStyleControl;
using CameraLibrary;
using static DispenseAPP.CommonClass;
using System.Collections.Generic;
using System.Windows;
using System.Drawing;
using HalconDotNet;

namespace DispenseAPP.Tools_ImageIO.AcqImage
{
    public partial class AcqImageToolControl : UserControlTool
    {
        /// <summary>
        /// 图像采集工具对象
        /// </summary>
        AcqImageToolEntity Entity { get; set; } = null;

        /// <summary>
        /// 相机对象
        /// </summary>
        ICamerable Camerable { get; set; } = null;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="entity">传入采集图像数据类</param>
        public AcqImageToolControl(AcqImageToolEntity entity)
        {
            InitializeComponent();
            Entity = entity;
            InitialHelper.InitialCamera(cmbCamera);
            InitialHelper.InitialComboBoxValue(cmbCamera, Entity.SelectedCameraName);
        }

        /// <summary>
        /// 单帧采集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSingleAcq_Click(object sender, EventArgs e)
        {
            Camerable.SingleFrameAcquisiton();
        }

        /// <summary>
        /// 连续采集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnContinueAcq_Click(object sender, EventArgs e)
        {
            btnSingleAcq.Enabled = false;
            btnContinueAcq.Enabled = false;
            Camerable.ContinuousAcquisition();
        }

        /// <summary>
        /// 停止采集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStopAcq_Click(object sender, EventArgs e)
        {
            Camerable.StopAcquisition();
            if (!btnContinueAcq.Enabled)
            {
                btnContinueAcq.Enabled = true;
            }
            if(!btnSingleAcq.Enabled)
            {
                btnSingleAcq.Enabled = true;
            }
        }

        /// <summary>
        /// 当选择的相机的索引发生变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCamera.SelectedIndex < 0)
            {
                return;
            }
            if (cmbCamera != null)
            {
                Camerable.StopAcquisition();
            }
            btnContinueAcq.Enabled = true;
            btnSingleAcq.Enabled = true;
            Camerable = CameraIDObjectDict[StaticPublicData.CameraDataItems.Find(c => c.CustomName == cmbCamera.Text).SystemName];
            Camerable.Register(ImageCallBackEvent);//注册事件
        }

        /// <summary>
        /// 相机采集回调
        /// </summary>
        void ImageCallBackEvent(Bitmap bitmap, HImage hImage)
        {
            if (bitmap != null && Entity.SelectedOperatorBlock.ImageWindowIndex != "不显示")
            {
                ImageWindowIndexDic[Convert.ToInt32(Entity.SelectedOperatorBlock.ImageWindowIndex)].Control.DispImage(bitmap, hImage);
            }
        }

        /// <summary>
        /// 点击确定按钮的检查
        /// </summary>
        /// <param name="stepName">工具的算子名称</param>
        /// <param name="toolableList">该工具所在集合的工具集</param>
        /// <returns></returns>
        protected override bool ClickOKCheck(string stepName, List<IToolable> toolableList)
        {
            if (!base.ClickOKCheck(stepName, toolableList))
            {
                return false;
            }
            if(cmbCamera.SelectedIndex < 0)
            {
                MessageBox.Show("请选择相机！");
                return false;
            }
            return true;
        }

        /// <summary>
        /// 点击确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            if (!ClickOKCheck(Entity.StepCustomName, Entity.SelectedOperatorBlock.ToolList))
            {
                return;
            }
            if (Camerable != null)
            {
                Camerable.StopAcquisition();
            }
            Entity.StepCustomName = txtName.Text.Trim();
            if (cmbCamera.Text != "???")
            {
                Entity.SelectedCameraName = StaticPublicData.CameraDataItems.Find(c => c.CustomName == cmbCamera.Text).SystemName;//保存相机的系统名称  因为系统名称不会被更改 而且可以通过键值对结合直接拿到相机对象
            }
            ExecuteClickOkEvent(Entity);
        }

        /// <summary>
        /// 点击取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void BtnCancel_Click(object sender, EventArgs e)
        {
            if(Camerable !=null)
            {
                Camerable.StopAcquisition();
            }
            base.BtnCancel_Click(sender, e);
        }
    }
}
