using CameraLibrary;
using DispenseAPP.MyStyleControl;
using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_ImageIO.AcqSet
{
    public partial class AcqSetToolControl : UserControlTool
    {
        public AcqSetToolControl(AcqSetToolEntity acqSetEntity)
        {
            InitializeComponent();
            AcqSetEntity = acqSetEntity;
            InitialHelper.InitialCamera(cmbCamera);
            InitialHelper.InitialComboBoxValue(cmbCamera, AcqSetEntity.SelectedCameraName);
        }

        /// <summary>
        /// 采集设置工具对象
        /// </summary>
        AcqSetToolEntity AcqSetEntity { get; set; } = null;

        /// <summary>
        /// 相机对象
        /// </summary>
        ICamerable Camerable { get; set; } = null;

        /// <summary>
        /// 正在设置控件的最大最小值
        /// </summary>
        bool SettingControlMinMaxValue { get; set; } = false;

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
            TcTool.SelectedIndex = 1;//跳转到参数界面
            pnlParam.Enabled = true;
        }

        /// <summary>
        /// 停止采集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStopAcq_Click(object sender, EventArgs e)
        {
            Camerable.StopAcquisition();
            if(!btnSingleAcq.Enabled)
            {
                btnSingleAcq.Enabled = true;
            }
            if (!btnContinueAcq.Enabled)
            {
                btnContinueAcq.Enabled = true;
            }
        }

        /// <summary>
        /// 当选择的相机索引发生变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbCamera_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbCamera.SelectedIndex < 0)
            {
                return;
            }
            if (Camerable != null)
            {
                Camerable.StopAcquisition();
            }
            btnContinueAcq.Enabled = true;
            btnSingleAcq.Enabled = true;
            Camerable = CameraIDObjectDict[StaticPublicData.CameraDataItems.Find(c => c.CustomName == cmbCamera.Text).SystemName];
            Camerable.Register(ImageCallBackEvent);//注册事件
            SettingControlMinMaxValue = true;
            trbExposureTime.Maximum = (int)Camerable.GetMaxExposureTime();
            nudExposureTime.Maximum = (decimal)Camerable.GetMaxExposureTime();
            trbExposureTime.Minimum = (int)Camerable.GetMinExposureTime();
            nudExposureTime.Minimum = (decimal)Camerable.GetMinExposureTime();
            SettingControlMinMaxValue = false;
           
            if (AcqSetEntity.SelectedCameraName != null && AcqSetEntity.SelectedCameraName.Equals(cmbCamera.Text))
            {
                nudExposureTime.Value = (decimal)AcqSetEntity.ExposureTime;
                nudDelayTime.Value = (decimal)AcqSetEntity.TriggerDelayTime;
            }
        }

        /// <summary>
        /// 相机采集回调
        /// </summary>
        void ImageCallBackEvent(Bitmap bitmap, HImage hImage)
        {
            if (bitmap != null && AcqSetEntity.SelectedOperatorBlock.ImageWindowIndex != "不显示")
            {
                ImageWindowIndexDic[Convert.ToInt32(AcqSetEntity.SelectedOperatorBlock.ImageWindowIndex)].Control.DispImage(bitmap, hImage);
            }
        }

        /// <summary>
        /// 点击确定按钮的检查
        /// </summary>
        /// <param name="stepName"></param>
        /// <param name="toolableList"></param>
        /// <returns></returns>
        protected override bool ClickOKCheck(string stepName, List<IToolable> toolableList)
        {
            if (!base.ClickOKCheck(stepName, toolableList))
            {
                return false;
            }
            if (cmbCamera.SelectedIndex < 0)
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
            if (!ClickOKCheck(AcqSetEntity.StepCustomName, AcqSetEntity.SelectedOperatorBlock.ToolList))
            {
                return;
            }
            if (Camerable != null)
            {
                Camerable.StopAcquisition();
            }
            AcqSetEntity.EnableExposureTime = chkExposureTime.Checked;
            AcqSetEntity.ExposureTime = (double)nudExposureTime.Value;
            AcqSetEntity.EnableTriggerDelayTime = chkDelayTime.Checked;
            AcqSetEntity.TriggerDelayTime = (double)nudDelayTime.Value;
            AcqSetEntity.StepCustomName = txtName.Text.Trim();
            if (cmbCamera.Text != "???")
            {
                AcqSetEntity.SelectedCameraName = StaticPublicData.CameraDataItems.Find(c => c.CustomName == cmbCamera.Text).SystemName;//保存相机的系统名称  因为系统名称不会被更改 而且可以通过键值对结合直接拿到相机对象
            }
            ExecuteClickOkEvent(AcqSetEntity);
        }

        /// <summary>
        /// 点击取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void BtnCancel_Click(object sender, EventArgs e)
        {
            if (Camerable != null)
            {
                Camerable.StopAcquisition();
            }
            base.BtnCancel_Click(sender, e);
        }

        #region 触发延时
        private void ChkDelayTime_CheckedChanged(object sender, EventArgs e)
        {
            nudDelayTime.Enabled = chkDelayTime.Checked;
        }
        #endregion

        #region 曝光
        private void TrbExposureTime_ValueChanged(object sender, EventArgs e)
        {
            nudExposureTime.Value = trbExposureTime.Value;
        }

        private void NudExposureTime_ValueChanged(object sender, EventArgs e)
        {
            if (!SettingControlMinMaxValue)
            {
                trbExposureTime.Value = (int)nudExposureTime.Value;
                Camerable.SetExposureTime((double)nudExposureTime.Value);
            }
        }

        private void ChkExposureTime_CheckedChanged(object sender, EventArgs e)
        {
            trbExposureTime.Enabled = chkExposureTime.Checked;
            nudExposureTime.Enabled = chkExposureTime.Checked;
        }
        #endregion
    }
}
