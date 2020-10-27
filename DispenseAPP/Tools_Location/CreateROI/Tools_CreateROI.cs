using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DispenseAPP.Tools_Location.CalibROI;
using static DispenseAPP.CommonClass;
using System.Reflection;
using HalconDotNet;

namespace DispenseAPP.Tools_Location.CreateROI
{
    public partial class Tools_CreateROI : UserControl,IEvent
    {
        private CreateROIClass _createROIClass;
        public event ClickCancelDelegate _clickCancelButton;
        public event ClickOKButtonDelegate _clickOKButton;
        private HHomMat2D _homMat2D;

        public Tools_CreateROI(CreateROIClass createROIClass)
        {
            InitializeComponent();
            _createROIClass = createROIClass;
            txt_Name.Text = _createROIClass.BlockName;
            cmb_ReviseROI.SelectedItem = _createROIClass.ReviseROI;
            InitialReference();
        }

        private void InitialReference()
        {
            List<ITools> toolsList = _createROIClass.SelectedNormalBlock.ToolsList.GetRange(0, FrmEdit._currentRowIndex + 1);//得到在此工具之前的工具集合
            if(toolsList != null)
            {
                foreach (var item in toolsList)
                {
                    if(item.GetType().IsDefined(typeof(ReviseROIAttribute),true))//如果该工具包含校正ROI特性 则进一步判断
                    {
                        foreach (PropertyInfo items in item.GetType().GetProperties())//获得该工具的所有属性
                        {
                            if(items.IsDefined(typeof(ReviseROIAttribute), true))
                            {
                                cmb_ReviseROI.Items.Add(item.BlockName + "-" + items.Name);
                            }
                        }
                    }
                }
            }
        }

        private void btn_Set_Click(object sender, EventArgs e)//ROI设置
        {
            if(WindowIndexDic[CurrentWindowIndex].Image != null & WindowIndexDic[CurrentWindowIndex].Image.IsInitialized())
            {
                bool roiRevise;
                if(cmb_ReviseROI.SelectedItem.ToString() == "不使用")
                {
                    roiRevise = false;
                }
                else
                {
                    roiRevise = true;
                    string toolsName = cmb_ReviseROI.SelectedItem.ToString().Split('-')[0];//工具名称
                    string blockName = cmb_ReviseROI.SelectedItem.ToString().Split('-')[1];//算子名称
                    ITools tools = _createROIClass.SelectedNormalBlock.ToolsList.Find(c => c.BlockName == toolsName);
                    _homMat2D = tools.GetType().GetProperty(blockName).GetValue(tools) as HHomMat2D;
                }
                FrmCreateROI frmCreateROI = new FrmCreateROI(_createROIClass,roiRevise, _homMat2D);
                frmCreateROI.ShowDialog();
            }
            else
            {
                MessageBox.Show("输入图像为空！");
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            _createROIClass.BlockName = txt_Name.Text;
            _createROIClass.ReviseROI = cmb_ReviseROI.SelectedItem.ToString();
            _createROIClass.DispResult = cb_DispResult.Checked;
            _clickOKButton(_createROIClass);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            _clickCancelButton();
        }
    }
}
