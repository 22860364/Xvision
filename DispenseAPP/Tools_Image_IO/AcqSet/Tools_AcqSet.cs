using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    public partial class Tools_AcqSet : UserControl, IEvent
    {
        AcqSetClass _acqSetClass;
        ICameraable SelectCamera;
        bool AcquisitionBusy = false;
        public event ClickOKButtonDelegate _clickOKButton;
        public event ClickCancelDelegate _clickCancelButton;
        private bool SetControlMaxMin = false;

        public Tools_AcqSet(AcqSetClass acqSetClass)//构造函数
        {
            InitializeComponent();
            _acqSetClass = acqSetClass;
            foreach (KeyValuePair<string, ICameraable> item in CameraIDObjectDict)//通过遍历来找到可用的相机
            {
                if (item.Value.CheckCameraAvailable() == true)
                {
                    TreeNode node = new TreeNode(CameraDataDic.Find(c => c.CameraID == item.Key).CustomName);
                    TreeView_AvailCamera.Nodes.Add(node);
                }
            }
            panel_Base.Enabled = false;
            Panel_AdvanceSetup.Enabled = false;
            SetLightParamPanelEnable(false);
            InitialDataBinding();
        }

        private void InitialDataBinding()//数据绑定
        {
            //相机
            Txt_Name.DataBindings.Add("Text", _acqSetClass, "BlockName");
            //基本
            Cb_ImageFormat.DataBindings.Add("Checked", _acqSetClass, "EnableImageFormat");
            Cmb_ImageFormat.SelectedIndex = Cmb_ImageFormat.Items.IndexOf("Mono8");
            Cb_ExposureTime.DataBindings.Add("Checked", _acqSetClass, "EnableExposureTime");        
            Cb_Gain.DataBindings.Add("Checked", _acqSetClass, "EnableGain");            
            Cb_ImageWidth.DataBindings.Add("Checked", _acqSetClass, "EnableImageWidth");            
            Cb_ImageHeight.DataBindings.Add("Checked", _acqSetClass, "EnableImageHeight");            
            Cb_Shift_Y.DataBindings.Add("Checked", _acqSetClass, "EnableShiftX");            
            Cb_Shift_X.DataBindings.Add("Checked", _acqSetClass, "EnableShiftY");        
            //高级
            cb_TriggerMode.DataBindings.Add("Checked", _acqSetClass, "EnableTriggerMode");
            cb_TriggerDelay.DataBindings.Add("Checked", _acqSetClass, "EnableTriggerDelayTime");     
            cb_TimeOut.DataBindings.Add("Checked", _acqSetClass, "EnableTimeOut");        
            Cmb_TriggerMode.SelectedIndex = Cmb_TriggerMode.Items.IndexOf("Software trigger");
            if(_acqSetClass.SelectedCamera != "" && FindTreeViewContainText()!= null)
            {
                TreeView_AvailCamera.SelectedNode = FindTreeViewContainText(); //因为相机的名称是唯一的 所以暂且认为只会找到一个
                TreeView_AvailCamera_NodeMouseDoubleClick(TreeView_AvailCamera, new TreeNodeMouseClickEventArgs(FindTreeViewContainText(), MouseButtons.Left, 2, 0, 0));                
            }
        }


        private TreeNode FindTreeViewContainText()
        {
            TreeNode treeNode = null;
            foreach (TreeNode item in TreeView_AvailCamera.Nodes)
            {
                if(item.Text == _acqSetClass.SelectedCamera)
                {
                    treeNode = item;
                }
            }
            return treeNode;
        }

        #region 图像格式 //待开放
        private void Cb_ImageFormat_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_ImageFormat.Checked == true)
            {
                Cmb_ImageFormat.Enabled = true;
            }
            else
            {
                Cmb_ImageFormat.Enabled = false;
            }
        }
        #endregion

        #region 图像高度  注意：在采集的同时不可以改变图像的宽度和高度  //待开放
        private void TrackBar_ImageHeight_Scroll(object sender, EventArgs e)//图像高度改变
        {
            Num_ImageHeight.Value = Tb_ImageHeight.Value;
        }

        private void Num_ImageHeight_ValueChanged(object sender, EventArgs e)//图像高度改变
        {
            if (SetControlMaxMin == false)
            {
                Tb_ImageHeight.Value = (int)Num_ImageHeight.Value;
            }
        }

        private void Cb_ImageHeight_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_ImageHeight.Checked == true)
            {
                Tb_ImageHeight.Enabled =true;
                Num_ImageHeight.Enabled = true;
            }
            else
            {
                Tb_ImageHeight.Enabled = false;
                Num_ImageHeight.Enabled = false;
            }
        }
        #endregion

        #region 图像宽度  //待开放
        private void Cb_ImageWidth_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_ImageWidth.Checked == true)
            {
                Tb_ImageWidth.Enabled = true;
                Num_ImageWidth.Enabled = true;
            }
            else
            {
                Tb_ImageWidth.Enabled = false;
                Num_ImageWidth.Enabled = false;
            }
        }

        private void TrackBar_ImageWidth_Scroll(object sender, EventArgs e)
        {
            Num_ImageWidth.Value = Tb_ImageWidth.Value;
        }

        private void Num_ImageWidth_ValueChanged(object sender, EventArgs e)
        {
            if (SetControlMaxMin == false) //当不设置控件的最大最小值时 才进行设置
            {
                Tb_ImageWidth.Value = (int)Num_ImageWidth.Value;
            }
        }
        #endregion

        #region 曝光
        private void Cb_ExposureTime_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_ExposureTime.Checked == true)
            {
                Num_ExposureTime.Enabled = true;
                Tb_ExposureTime.Enabled = true;
            }
            else
            {
                Num_ExposureTime.Enabled = false;
                Tb_ExposureTime.Enabled = false;
            }
        }

        private void TrackBar_ExposureTime_Scroll(object sender, EventArgs e)//曝光值改变
        {
            Num_ExposureTime.Value = Tb_ExposureTime.Value;
        }

        private void Num_ExposureTime_ValueChanged(object sender, EventArgs e)//曝光值改变
        {
            if (SetControlMaxMin == false)
            {
                Tb_ExposureTime.Value = (int)Num_ExposureTime.Value;
                SelectCamera.SetExposureTime(Convert.ToDouble(Num_ExposureTime.Value));
            }
        }
        #endregion

        #region 增益
        private void TrackBar_Gain_Scroll(object sender, EventArgs e)
        {
            Num_Gain.Value = Tb_Gain.Value;
        }

        private void Num_Gain_ValueChanged(object sender, EventArgs e)
        {
            if (SetControlMaxMin == false)
            {
                Tb_Gain.Value = (int)Num_Gain.Value;
                SelectCamera.SetGain(Convert.ToDouble(Num_Gain.Value));
            }
        }

        private void Cb_Gain_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_Gain.Checked == true)
            {
                Tb_Gain.Enabled = true;
                Num_Gain.Enabled = true;
            }
            else
            {
                Tb_Gain.Enabled = false;
                Num_Gain.Enabled = false;
            }
        }

        #endregion

        #region 偏移量  //待开放
        private void Cb_Shift_Y_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_Shift_Y.Checked == true)
            {
                Num_Shift_Y.Enabled = true;
            }
            else
            {
                Num_Shift_Y.Enabled = false;
            }
        }

        private void Cb_Shift_X_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_Shift_X.Checked == true)
            {
                Num_Shift_X.Enabled = true;
            }
            else
            {
                Num_Shift_X.Enabled = false;
            }
        }

        private void Num_Shift_X_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Num_Shift_Y_ValueChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region 触发模式  //待开放
        private void Cb_TriggerMode_CheckedChanged(object sender, EventArgs e)//触发模式
        {
            if (cb_TriggerMode.Checked == true)
            {
                Cmb_TriggerMode.Enabled =true;
            }
            else
            {
                Cmb_TriggerMode.Enabled = false;
            }
        }
        #endregion

        #region 超时
        private void Cb_TimeOut_CheckedChanged(object sender, EventArgs e)//超时
        {
            if (cb_TimeOut.Checked == true)
            {
                Num_TimeOut.Enabled = true;
                Tb_TimeOut.Enabled = true;
            }
            else
            {
                Num_TimeOut.Enabled = false;
                Tb_TimeOut.Enabled = false;
            }
        }

        private void Tb_TimeOut_Scroll(object sender, EventArgs e)
        {
            Num_TimeOut.Value = Tb_TimeOut.Value;
        }

        private void Num_TimeOut_ValueChanged(object sender, EventArgs e)
        {
            Tb_TimeOut.Value = (int)Num_TimeOut.Value;
        }

        #endregion

        #region 触发延时
        private void TrackBar_TriggerDelay_Scroll(object sender, EventArgs e)
        {
            Num_TriggerDelay.Value = Tb_TriggerDelay.Value;
        }

        private void Num_TriggerDelay_ValueChanged(object sender, EventArgs e)
        {
            Tb_TriggerDelay.Value = (int)Num_TriggerDelay.Value;
        }

        private void Cb_TriggerDelay_CheckedChanged(object sender, EventArgs e)//延时
        {
            if (cb_TriggerDelay.Checked == true)
            {
                Num_TriggerDelay.Enabled = true;
                Tb_TriggerDelay.Enabled = true;
            }
            else
            {
                Num_TriggerDelay.Enabled = false;
                Tb_TriggerDelay.Enabled = false;
            }
        }
        #endregion

        #region 光源参数设置  //待开放
        private void SetLightParamPanelEnable(bool state)//设置光源参数界面控件的Enable属性
        {
            foreach (Control item in Panel_LightSet.Controls)//遍历Panel中的所有控件
            {
                if (item is ComboBox || item is CheckBox || item is NumericUpDown)
                {
                    item.Enabled = state;
                }
                if (item is GroupBox)
                {
                    foreach (Control items in item.Controls)
                    {
                        if (items is RadioButton || items is ComboBox || items is NumericUpDown || items is TrackBar)
                        {
                            items.Enabled = state;
                        }
                    }
                }
            }
        }

        private void Cmb_Channel1_SelectedIndexChanged(object sender, EventArgs e)//通道1
        {
            if (Cmb_Channel1.SelectedItem.ToString() == "亮度")
            {
                Tb_Channel1.Enabled = true;
                Num_Channel1.Enabled = true;
            }
            else
            {
                Tb_Channel1.Enabled = false;
                Num_Channel1.Enabled = false;
            }
        }

        private void Cmb_Channel2_SelectedIndexChanged(object sender, EventArgs e)//通道2
        {
            if (Cmb_Channel2.SelectedItem.ToString() == "亮度")
            {
                Tb_Channel2.Enabled = true;
                Num_Channel2.Enabled = true;
            }
            else
            {
                Tb_Channel2.Enabled = false;
                Num_Channel2.Enabled = false;
            }
        }

        private void Cmb_Channel3_SelectedIndexChanged(object sender, EventArgs e)//通道3
        {
            if (Cmb_Channel3.SelectedItem.ToString() == "亮度")
            {
                Tb_Channel3.Enabled = true;
                Num_Channel3.Enabled = true;
            }
            else
            {
                Tb_Channel3.Enabled = false;
                Num_Channel3.Enabled = false;
            }
        }

        private void Cmb_Channel4_SelectedIndexChanged(object sender, EventArgs e)//通道4
        {
            if (Cmb_Channel4.SelectedItem.ToString() == "亮度")
            {
                Tb_Channel4.Enabled = true;
                Num_Channel4.Enabled = true;
            }
            else
            {
                Tb_Channel4.Enabled = false;
                Num_Channel4.Enabled = false;
            }
        }

        private void Cmb_Channel5_SelectedIndexChanged(object sender, EventArgs e)//通道5
        {
            if (Cmb_Channel5.SelectedItem.ToString() == "亮度")
            {
                Tb_Channel5.Enabled = true;
                Num_Channel5.Enabled = true;
            }
            else
            {
                Tb_Channel5.Enabled = false;
                Num_Channel5.Enabled = false;
            }
        }

        private void Cmb_Channel6_SelectedIndexChanged(object sender, EventArgs e)//通道6
        {
            if (Cmb_Channel6.SelectedItem.ToString() == "亮度")
            {
                Tb_Channel6.Enabled = true;
                Num_Channel6.Enabled = true;
            }
            else
            {
                Tb_Channel6.Enabled = false;
                Num_Channel6.Enabled = false;
            }
        }

        private void Cmb_Channel7_SelectedIndexChanged(object sender, EventArgs e)//通道7
        {
            if (Cmb_Channel7.SelectedItem.ToString() == "亮度")
            {
                Tb_Channel7.Enabled = true;
                Num_Channel7.Enabled = true;
            }
            else
            {
                Tb_Channel7.Enabled = false;
                Num_Channel7.Enabled = false;
            }
        }

        private void Cmb_Channel8_SelectedIndexChanged(object sender, EventArgs e)//通道8
        {
            if (Cmb_Channel8.SelectedItem.ToString() == "亮度")
            {
                Tb_Channel8.Enabled = true;
                Num_Channel8.Enabled = true;
            }
            else
            {
                Tb_Channel8.Enabled = false;
                Num_Channel8.Enabled = false;
            }
        }
        #endregion

        private void TreeView_AvailCamera_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)//鼠标双击节点 进入相机实时模式
        {
            if (AcquisitionBusy == true)
            {
                SelectCamera.StopAcquisition(); //如果这个时候有相机在采集 则需要停止相机采集 然后用新的相机采集
            }
            panel_Base.Enabled = true;
            Panel_AdvanceSetup.Enabled = true;//设置界面的使能状态
            SelectCamera = CameraIDObjectDict[CameraDataDic.Find(c => c.CustomName == TreeView_AvailCamera.SelectedNode.Text).CameraID];
            SelectCamera.ImageCallBackEvent += SelectCamera_ImageCallBackEvent;//为事件注册方法
            SetControlMaxMin = true;
            //设置控件的最大最小值
            Num_ExposureTime.Maximum = (decimal)SelectCamera.GetMaxExposureTime();
            Num_ExposureTime.Minimum = (decimal)SelectCamera.GetMinExposureTime();
            Tb_ExposureTime.Maximum = (int)Num_ExposureTime.Maximum;
            Tb_ExposureTime.Minimum = (int)Num_ExposureTime.Minimum;
            Num_Gain.Maximum = (decimal)SelectCamera.GetMaxGain();
            Num_Gain.Minimum = (decimal)SelectCamera.GetMinGain();
            Tb_Gain.Maximum = (int)Num_Gain.Maximum;
            Tb_Gain.Minimum = (int)Num_Gain.Minimum;
            Num_ImageWidth.Maximum = SelectCamera.GetImageMaxWidth();
            Num_ImageWidth.Minimum = SelectCamera.GetImageMinWidth();
            Tb_ImageWidth.Maximum = (int)Num_ImageWidth.Maximum;
            Tb_ImageWidth.Minimum = (int)Num_ImageWidth.Minimum;
            Num_ImageHeight.Maximum = SelectCamera.GetImageMaxHeight();
            Num_ImageHeight.Minimum = SelectCamera.GetImageMinHeight();
            Tb_ImageHeight.Maximum = (int)Num_ImageHeight.Maximum;
            Tb_ImageHeight.Minimum = (int)Num_ImageHeight.Minimum;
            Num_TriggerDelay.Maximum = (decimal)SelectCamera.GetTriggerDelayTimeMax();
            Num_TriggerDelay.Minimum = (decimal)SelectCamera.GetTriggerDelayTimeMin();
            Tb_TriggerDelay.Maximum = (int)Num_TriggerDelay.Maximum;
            Tb_TriggerDelay.Minimum = (int)Num_TriggerDelay.Minimum;
            SetControlMaxMin = false;
            if (e.Node.Text == _acqSetClass.SelectedCamera)//当前选择的相机和传入的相机名称相同 则设置传入的相机参数
            {
                Num_ExposureTime.DataBindings.Add("Value", _acqSetClass, "ExposureTime");
                Num_Gain.DataBindings.Add("Value", _acqSetClass, "Gain");
                Num_ImageWidth.DataBindings.Add("Value", _acqSetClass, "ImageWidth");
                Num_ImageHeight.DataBindings.Add("Value", _acqSetClass, "ImageHeight");
                Num_Shift_X.DataBindings.Add("Value", _acqSetClass, "ShiftX");
                Num_Shift_Y.DataBindings.Add("Value", _acqSetClass, "ShiftY");
                Num_TriggerDelay.DataBindings.Add("Value", _acqSetClass, "TriggerDelayTime");
            }
            else
            {
                Num_ExposureTime.Value = (decimal)SelectCamera.GetExposureTime();
                Num_Gain.Value = (decimal)SelectCamera.GetGain();
                Num_ImageWidth.Value = SelectCamera.GetImageWidth();
                Num_ImageHeight.Value = SelectCamera.GetImageHeight();
                Num_TriggerDelay.Value = (decimal)SelectCamera.GetTriggerDelayTime();
            }
            SelectCamera.ContinuousAcquisition();
            AcquisitionBusy = true;
            Tc_AcqSet.SelectedIndex = 1;
        }

        private void SelectCamera_ImageCallBackEvent(HalconDotNet.HImage image)//相机回调函数
        {
            WindowIndexDic[CurrentWindowIndex].DispImage(image, false);
        }

        private void Btn_OK_Click(object sender, EventArgs e)//光源参数暂时先不管
        {
            if (Txt_Name.Text == "")
            {
                MessageBox.Show("请输入算子名", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            if (_acqSetClass.SelectedNormalBlock.ToolsList.Find(c => c.BlockName == Txt_Name.Text) != null)
            {
                MessageBox.Show("该算子名已经被使用！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            if (AcquisitionBusy == true)
            {
                SelectCamera.StopAcquisition();
                SelectCamera.ImageCallBackEvent -= SelectCamera_ImageCallBackEvent;//为事件移除方法
            }          
            _acqSetClass.BlockName = Txt_Name.Text;
            if(TreeView_AvailCamera.SelectedNode != null)
            {
                _acqSetClass.SelectedCamera = TreeView_AvailCamera.SelectedNode.Text;
                _acqSetClass.EnableExposureTime = Cb_ExposureTime.Checked;
                _acqSetClass.ExposureTime = (double)Num_ExposureTime.Value;
                _acqSetClass.EnableGain = Cb_Gain.Checked;
                _acqSetClass.Gain = (double)Num_Gain.Value;
                _acqSetClass.EnableImageWidth = Cb_ImageWidth.Checked;
                _acqSetClass.ImageWidth = (long)Num_ImageWidth.Value;
                _acqSetClass.EnableImageHeight = Cb_ImageHeight.Checked;
                _acqSetClass.ImageHeight = (long)Num_ImageHeight.Value;
                _acqSetClass.EnableShiftX = Cb_Shift_X.Checked;
                _acqSetClass.ShiftX = (int)Num_Shift_X.Value;
                _acqSetClass.EnableShiftY = Cb_Shift_Y.Checked;
                _acqSetClass.ShiftY = (int)Num_Shift_Y.Value;
                _acqSetClass.EnableTriggerMode = cb_TriggerMode.Checked;
                _acqSetClass.TriggerMode = Cmb_TriggerMode.SelectedItem.ToString();
                _acqSetClass.EnableTimeOut = cb_TimeOut.Checked;
                _acqSetClass.TimeOut = (double)Num_TimeOut.Value;
                _acqSetClass.EnableTriggerDelayTime = cb_TriggerDelay.Checked;
                _acqSetClass.TriggerDelayTime = (double)Num_TriggerDelay.Value;
            }
            _clickOKButton(_acqSetClass);
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            if (AcquisitionBusy == true)
            {
                SelectCamera.StopAcquisition();
                SelectCamera.ImageCallBackEvent -= SelectCamera_ImageCallBackEvent;//为事件移除方法
            }
            _clickCancelButton();
        }

        private void TreeView_AvailCamera_DrawNode(object sender, DrawTreeNodeEventArgs e)//当需要绘制节点时，在所有者描述模式下发生
        {
            e.DrawDefault = true;
        }
    }
}
