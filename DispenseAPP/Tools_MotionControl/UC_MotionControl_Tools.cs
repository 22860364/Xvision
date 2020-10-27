using System;
using System.Windows.Forms;
using DispenseAPP.Tools_MotionControl.MeasureHeight;
using DispenseAPP.Tools_MotionControl.ProgrammingDispensePath;

namespace DispenseAPP.Tools_MotionControl
{
    public partial class UC_MotionControl_Tools : UserControl
    {
        public event ClickToolsDelegate ClickToolsEvent;
        public UC_MotionControl_Tools()
        {
            InitializeComponent();
        }
        private void Lbl_DispensePathProgramming_Click(object sender, EventArgs e)
        {
            ClickToolsEvent(ToolsNameEnum.PathProgram, new PathProgramClass());
        }

        private void Lbl_AutoCalibNeedle_Click(object sender, EventArgs e)//自动对针
        {

        }

        private void Lbl_MeasureGlueWeight_Click(object sender, EventArgs e)//胶重计量
        {

        }

        private void Lbl_LaserMeasureHeight_Click(object sender, EventArgs e)//测高
        {
            ClickToolsEvent(ToolsNameEnum.LaserMeasureHeight, new MeasureHeightClass());
        }

        private void Lbl_MachineMeasureHeight_Click(object sender, EventArgs e)
        {

        }
    }
}
