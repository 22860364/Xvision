using DispenseAPP.CustomControl;
using System;
using System.Drawing;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;
using HalconDotNet;
using DispenseAPP.Tools_Location.ProgramDispensePath.DisplayImagePath;

namespace DispenseAPP.Tools_MotionControl.MeasureHeight
{
    public partial class FrmMeasureHeightSet : FormM
    {
        private string _cardName;
        private string[] _axisArray;
        public FrmMeasureHeightSet(string cardName, string[] axisArray)
        {
            InitializeComponent();
            _cardName = cardName;
            Execute();
            _axisArray = axisArray;
        }

        private void DG_MeasureHeight_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)//行级绘制触发的事件
        {
            Rectangle rct = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, DG_MeasureHeight.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), DG_MeasureHeight.RowHeadersDefaultCellStyle.Font, rct, DG_MeasureHeight.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

        private void Tssbtn_Add_Click(object sender, EventArgs e)
        {

        }

        private void Tssbtn_Insert_Click(object sender, EventArgs e)
        {

        }

        private void Tsbtn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void Tsbtn_Array_Click(object sender, EventArgs e)
        {

        }

        private void Tsbtn_Up_Click(object sender, EventArgs e)
        {

        }

        private void Tsbtn_Down_Click(object sender, EventArgs e)
        {

        }

        private void Tsbtn_InvertOrder_Click(object sender, EventArgs e)
        {

        }

        private void Tssbtn_ModifPosition_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ShowSet_Click(object sender, EventArgs e)//显示设置
        {
            FrmSetCrossParam frmSetCrossParam = new FrmSetCrossParam(StaticLocalParamClass.crossParamClass);
            frmSetCrossParam.ClickApplyEvent += FrmSetCrossParam_ClickApplyEvent;
            frmSetCrossParam.ShowDialog();
            Execute();
        }

        private void Execute()
        {
            if (StaticLocalParamClass.crossParamClass.ShowCross)
            {
                UC_Image.Window.SetLineWidth(StaticLocalParamClass.crossParamClass.ScaleLineWidth);
                UC_Image.Window.SetColor(StaticLocalParamClass.crossParamClass.CrossColor.Name.ToLower());
                UC_Image.Window.DispCross((double)UC_Image.Height , UC_Image.Width , 500d, 0d);
            }
        }

        private void FrmSetCrossParam_ClickApplyEvent()//点击应用按钮
        {
            Execute();
        }

        private void Btn_ContinueFrame_Click(object sender, EventArgs e)//实时采集
        {
            if (Cmb_SelectCamera.SelectedIndex > -1)
            {
                if (CameraIDObjectDict.ContainsKey(Cmb_SelectCamera.SelectedText))
                {
                    CameraIDObjectDict[Cmb_SelectCamera.SelectedText].SingleFrameAcquisiton();
                }
            }
        }

        private void Btn_SingleFrame_Click(object sender, EventArgs e)//单帧采集
        {
            if (Cmb_SelectCamera.SelectedIndex > -1)
            {
                if (CameraIDObjectDict.ContainsKey(Cmb_SelectCamera.SelectedText))
                {
                    CameraIDObjectDict[Cmb_SelectCamera.SelectedText].ContinuousAcquisition();
                }
            }
        }

        private void Cmb_SelectCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_SelectCamera.SelectedIndex >= 0)
            {
                if (CameraIDObjectDict.ContainsKey(Cmb_SelectCamera.SelectedText))
                {
                    CameraIDObjectDict[Cmb_SelectCamera.SelectedText].ImageCallBackEvent += FrmMeasureHeightSet_ImageCallBackEvent;
                }
            }
        }

        private void FrmMeasureHeightSet_ImageCallBackEvent(HImage image)
        {
            UC_Image.DispImage(image);
        }
    }
}
