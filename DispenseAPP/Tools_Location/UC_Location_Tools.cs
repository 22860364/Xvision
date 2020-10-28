using DispenseAPP.Tools_Location.CalibROI;
using DispenseAPP.Tools_Location.ContourMatchin;
using DispenseAPP.Tools_Location.CreateROI;
using DispenseAPP.Tools_Location.FindLine;
using DispenseAPP.Tools_MotionControl.ProgrammingDispensePath;
using System;
using System.Windows.Forms;

namespace DispenseAPP.Tools_Location
{
    public partial class UC_Location_Tools : UserControl
    {
        public event ClickToolsDelegate ClickToolsEvent;
        public UC_Location_Tools()
        {
            InitializeComponent();
        }

        private void lbl_FindLine_Click(object sender, EventArgs e)
        {
            ClickToolsEvent(ToolsNameEnum.FindLine,new FindLineClass());
        }

        private void lbl_FindCircle_Click(object sender, EventArgs e)
        {
            //ClickToolsEvent("找圆");
        }

        private void lbl_ContourMatch_Click(object sender, EventArgs e)
        {
            ClickToolsEvent(ToolsNameEnum.ContourMatching,new ContourMatchingClass());
        }

        private void lbl_GrayValueBasedMatch_Click(object sender, EventArgs e)
        {
            //ClickToolsEvent("基于灰度值的采集设置");
        }

        private void Lbl_ROICalib_Click(object sender, EventArgs e)
        {
            ClickToolsEvent(ToolsNameEnum.ReviseROI, new ReviseROIClass());
        }

        private void Lbl_CreateROI_Click(object sender, EventArgs e)//创建ROI
        {
            ClickToolsEvent(ToolsNameEnum.CreateROI, new CreateROIClass());
        }

    }
}
