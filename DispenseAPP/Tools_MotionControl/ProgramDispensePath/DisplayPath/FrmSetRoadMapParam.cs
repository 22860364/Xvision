using DispenseAPP.CustomControl;
using System;
using System.Windows.Forms;
using static DispenseAPP.Tools_Location.ProgramDispensePath.DisplayImagePath.RoadMapParamClass;

namespace DispenseAPP.Tools_Location.ProgramDispensePath.DisplayImagePath
{
    public partial class FrmSetRoadMapParam : FormM
    {
        private RoadMapParamClass _roadMapParamClass;
        public event Action ClickApplyButtonEvent;
        public FrmSetRoadMapParam(RoadMapParamClass roadMapParamClass)
        {
            InitializeComponent();
            _roadMapParamClass = roadMapParamClass;
            InitialControl();
        }

        private void InitialControl()//初始化控件
        {
            Lbl_SelectPointColor.BackColor = _roadMapParamClass.SelectPointColor;
            Lbl_GridColor.BackColor = _roadMapParamClass.GridColor;
            Lbl_BackColor.BackColor = _roadMapParamClass.BackColor;
            Lbl_NoSelectPointColor.BackColor = _roadMapParamClass.NoSelectPointColor;
            Num_SelectPointSize.Value = _roadMapParamClass.SelectPointSize;
            Num_NoSelectPointSize.Value = _roadMapParamClass.NoSelectPointSize;
            Lbl_NoSelectRoadLineColor.BackColor = _roadMapParamClass.NoSelectRoadColor;
            Lbl_SelectRoadLineColor.BackColor = _roadMapParamClass.SelectRoadColor;
            Num_NoSelectRoadWidth.Value = _roadMapParamClass.NoSelectRoadWidth;
            Num_SelectRoadWidth.Value = _roadMapParamClass.SelectRoadWidth;
            Lbl_CoordinateLineColor.BackColor = _roadMapParamClass.CoordinateLineColor;
            Lbl_Cursor.BackColor = _roadMapParamClass.CursorColor;
            Lbl_ArrayPathColor.BackColor = _roadMapParamClass.ArrayPathColor;
            Lbl_OtherColor.BackColor = _roadMapParamClass.OtherColor;
            Cb_UseDottedLineConnectStartPointWithLastPoint.Checked = _roadMapParamClass.UseDottedConnectStartPointWithLastPoint;
            Cb_UseDottedLineConnectSinglePointWithLastPoint.Checked = _roadMapParamClass.UseDottedConnectSinglePointWithLastPoint;
            Cmb_DrawQuality.SelectedIndex = Cmb_DrawQuality.Items.IndexOf(_roadMapParamClass.DrawQuality.ToString());
            Num_ZoomSpeed.Value = (decimal)_roadMapParamClass.ZoomSpeed;
            Num_PictrureCenterShiftX.Value = _roadMapParamClass.PictureCenterShiftX;
            Num_PictrureCenterShiftY.Value = _roadMapParamClass.PictureCenterShiftY;
            Num_PictureWidthZoomShiftFactor.Value = (decimal)_roadMapParamClass.PictureWidthZoomShiftFactor;
            Num_PictureHeigthZoomShiftFactor.Value = (decimal)_roadMapParamClass.PictureHeightZoomShiftFactor;
            Num_NeedleDiameter.Value = (decimal)_roadMapParamClass.NeedleInnerDiameter;
        }

        private void Btn_Apply_Click(object sender, EventArgs e)//应用
        {
            SetValue();
            ClickApplyButtonEvent();
        }

        private void Btn_OK_Click(object sender, EventArgs e)//确定
        {
            SetValue();
            Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)//取消
        {
            Close();
        }

        private void SetValue()
        {
            _roadMapParamClass.SelectPointColor = Lbl_SelectPointColor.BackColor;
            _roadMapParamClass.GridColor = Lbl_GridColor.BackColor;
            _roadMapParamClass.BackColor= Lbl_BackColor.BackColor ;
            _roadMapParamClass.NoSelectPointColor =Lbl_NoSelectPointColor.BackColor ;
            _roadMapParamClass.SelectPointSize =(ushort)Num_SelectPointSize.Value;
            _roadMapParamClass.NoSelectPointSize =(ushort)Num_NoSelectPointSize.Value;
            _roadMapParamClass.NoSelectRoadColor =Lbl_NoSelectRoadLineColor.BackColor;
            _roadMapParamClass.SelectRoadColor =Lbl_SelectRoadLineColor.BackColor;
            _roadMapParamClass.NoSelectRoadWidth =(ushort)Num_NoSelectRoadWidth.Value;
            _roadMapParamClass.SelectRoadWidth = (ushort)Num_SelectRoadWidth.Value;
            _roadMapParamClass.CoordinateLineColor = Lbl_CoordinateLineColor.BackColor;
            _roadMapParamClass.CursorColor = Lbl_Cursor.BackColor;
            _roadMapParamClass.ArrayPathColor =Lbl_ArrayPathColor.BackColor;
            _roadMapParamClass.OtherColor = Lbl_OtherColor.BackColor;
            _roadMapParamClass.UseDottedConnectStartPointWithLastPoint =Cb_UseDottedLineConnectStartPointWithLastPoint.Checked;
            _roadMapParamClass.UseDottedConnectSinglePointWithLastPoint =Cb_UseDottedLineConnectSinglePointWithLastPoint.Checked;
            _roadMapParamClass.DrawQuality = (DrawQualityEnum)Enum.Parse(typeof(DrawQualityEnum), Cmb_DrawQuality.SelectedItem.ToString());
            _roadMapParamClass.ZoomSpeed = (float)Num_ZoomSpeed.Value;
            _roadMapParamClass.PictureCenterShiftX = (ushort)Num_PictrureCenterShiftX.Value;
            _roadMapParamClass.PictureCenterShiftY = (ushort)Num_PictrureCenterShiftY.Value;
            _roadMapParamClass.PictureWidthZoomShiftFactor =(float)Num_PictureWidthZoomShiftFactor.Value;
            _roadMapParamClass.PictureHeightZoomShiftFactor =(float)Num_PictureHeigthZoomShiftFactor.Value;
            _roadMapParamClass.NeedleInnerDiameter =(float)Num_NeedleDiameter.Value;
        }

        private void SetColor(Label label)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                label.BackColor = colorDialog.Color;
            }
        }

        private void Lbl_BackColor_Click(object sender, EventArgs e)
        {
            SetColor(Lbl_BackColor);
        }

        private void Lbl_NoSelectPointColor_Click(object sender, EventArgs e)
        {
            SetColor(Lbl_NoSelectPointColor);
        }

        private void Lbl_SelectPointColor_Click(object sender, EventArgs e)
        {
            SetColor(Lbl_SelectPointColor);
        }

        private void Lbl_NoSelectRoadLineColor_Click(object sender, EventArgs e)
        {
            SetColor(Lbl_NoSelectRoadLineColor);
        }

        private void Lbl_SelectRoadLineColor_Click(object sender, EventArgs e)
        {
            SetColor(Lbl_SelectRoadLineColor);
        }

        private void Lbl_CoordinateLineColor_Click(object sender, EventArgs e)
        {
            SetColor(Lbl_CoordinateLineColor);
        }

        private void Lbl_Cursor_Click(object sender, EventArgs e)
        {
            SetColor(Lbl_Cursor);
        }

        private void Lbl_ArrayPathColor_Click(object sender, EventArgs e)
        {
            SetColor(Lbl_ArrayPathColor);
        }

        private void Lbl_OtherColor_Click(object sender, EventArgs e)
        {
            SetColor(Lbl_OtherColor);
        }

        private void Lbl_GridColor_Click(object sender, EventArgs e)
        {
            SetColor(Lbl_GridColor);
        }
    }
}
