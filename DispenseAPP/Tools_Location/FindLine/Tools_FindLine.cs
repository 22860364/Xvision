using DispenseAPP.Tools_Location.FindLine;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_Location
{
    public partial class Tools_FindLine : UserControl, IEvent
    {
        public Tools_FindLine(FindLineClass findLineClass)
        {
            InitializeComponent();
            _findLineClass = findLineClass;
            Binding binding = new Binding("Text", _findLineClass, "BlockName");
            txt_Name.DataBindings.Add(binding);
            binding = new Binding("Checked", _findLineClass, "DispResult");
            cb_DispResult.DataBindings.Add(binding);
            binding = new Binding("Checked", _findLineClass, "NoCalib");
            rbtn_NoCalib.DataBindings.Add(binding);
            binding = new Binding("Checked", _findLineClass, "HaveCalib");
            rbtn_HaveCalib.DataBindings.Add(binding);
            binding = new Binding("Checked", _findLineClass, "EnableStartAngle");
            cb_StartAngle.DataBindings.Add(binding);
            binding = new Binding("Checked", _findLineClass, "EnableEndAngle");
            cb_AngleRange.DataBindings.Add(binding);
            binding = new Binding("Value", _findLineClass, "StartAngle");
            num_StartAngle.DataBindings.Add(binding);
            binding = new Binding("Value", _findLineClass, "AngleRange");
            num_AngleRange.DataBindings.Add(binding);
            binding = new Binding("Text", _findLineClass, "CurrentAngle");
            lbl_CurrentAngle.DataBindings.Add(binding);
            cmb_ROI.SelectedItem = _findLineClass.ROI;
            cmb_ReviseROI.SelectedItem = _findLineClass.ReviseROI;
        }

        private void InitialROIReference()
        {
            List<ITools> tools = _findLineClass.SelectedNormalBlock.ToolsList.GetRange(0, FrmEdit._currentRowIndex + 1);
            if (tools != null)
            {
                foreach (var item in tools)
                {
                    if (item.GetType().IsDefined(typeof(ROIAttribute), true))//如果类比标记为ROI 则将算子名添加到下拉框中
                    {
                        cmb_ROI.Items.Add(item.BlockName);
                    }
                    if (item.GetType().IsDefined(typeof(ReviseROIAttribute), true))
                    {
                        foreach (PropertyInfo items in item.GetType().GetProperties())
                        {
                            if(items.IsDefined(typeof(ReviseROIAttribute),true))//如果该属性被标记为校正ROI 则添加到下拉框中
                            {
                                cmb_ReviseROI.Items.Add(item.BlockName + "-" + items.Name);//算子名+属性名
                            }
                        }
                    }
                }
            }
            if(cmb_ReviseROI.Items.Contains(_findLineClass.ReviseROI))
            {
                cmb_ReviseROI.SelectedItem = _findLineClass.ReviseROI;
            }
            else
            {
                cmb_ReviseROI.Items.Add("!!!");
                cmb_ReviseROI.SelectedItem = "!!!";
            }
            if (cmb_ROI.Items.Contains(_findLineClass.ROI))
            {
                cmb_ROI.SelectedItem = _findLineClass.ROI;
            }
            else
            {
                cmb_ROI.Items.Add("!!!");
                cmb_ROI.SelectedItem = "!!!";
            }
        }

        private FindLineClass _findLineClass;

        public event ClickOKButtonDelegate _clickOKButton;

        public event ClickCancelDelegate _clickCancelButton;

        private void btn_Set_Click(object sender, EventArgs e)//设置找直线参数
        {
            if (WindowIndexDic[CurrentWindowIndex].Image != null && WindowIndexDic[CurrentWindowIndex].Image.IsInitialized())
            {
                FrmFindLine frmFindLine = new FrmFindLine(_findLineClass);
                frmFindLine.ShowDialog();
            }
            else
            {
                MessageBox.Show("输入图像为空！");
            }
        }

        private void cb_StartAngle_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_StartAngle.Checked == true)
            {
                num_StartAngle.Enabled = true;
            }
            else
            {
                num_StartAngle.Enabled = false;
            }
        }

        private void cb_EndAngle_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_AngleRange.Checked == true)
            {
                num_AngleRange.Enabled = true;
            }
            else
            {
                num_AngleRange.Enabled = false;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)//取消
        {
            _clickCancelButton();
        }

        private void btn_OK_Click(object sender, EventArgs e)//确定
        {
            _clickOKButton(_findLineClass);
        }

        private void cmb_ROI_SelectedIndexChanged(object sender, EventArgs e) //如果ROI不为常量 则ROI校正不可用
        {
            if(cmb_ROI.SelectedItem.ToString() != "常量")
            {
                cmb_ReviseROI.Enabled = false;
            }
            else
            {
                cmb_ReviseROI.Enabled = true;
            }
        }
    }
}
