using DispenseAPP.CustomControl;
using DispenseAPP.Tools_Location.CalibROI;
using HalconDotNet;
using System;
using static DispenseAPP.CommonClass;
using System.Windows.Forms;
using VisionLibrary.ROI;

namespace DispenseAPP.Tools_Location.CreateROI
{
    public partial class FrmCreateROI : FormM
    {
        private CreateROIClass _createROIClas;

        private bool _roiRevise;

        private HHomMat2D _homMat2D;

        private DrawROIable _drawROIable;

        public FrmCreateROI(CreateROIClass createROIClass, bool roiRevise, HHomMat2D homMat2D)
        {
            InitializeComponent();
            _createROIClas = createROIClass;
            uC_Image1.StartDrawEvent += UC_Image1_StartDrawEvent;
            uC_Image1.DrawFinshEvent += UC_Image1_DrawFinshEvent;
            _roiRevise = roiRevise;
            cmb_ROIType.SelectedItem = _createROIClas.ROIType;
            if (_drawROIable != null && _drawROIable.Region != null && _drawROIable.Region.IsInitialized())
            {
                uC_Image1.Window.SetDraw("margin");
                uC_Image1.DispObject(_drawROIable.Region, true, "blue");
            }
            if (roiRevise == false)
            {
                gb_ROIReviseLate.Visible = false;
            }
            else
            {
                gb_ROIReviseLate.Visible = true;
            }
            if (homMat2D != null)
            {
                _homMat2D = homMat2D.HomMat2dInvert();//反转矩阵
            }
        }

        private void UC_Image1_DrawFinshEvent(DrawROIable roi)//画ROI结束事件
        {
            cmb_ROIType.Enabled = true;
            HSystem.SetSystem("clip_region", "false");
            switch (cmb_ROIType.SelectedItem.ToString())
            {
                case "线段":
                    DrawLine drawLine = roi as DrawLine;
                    if (_roiRevise)
                    {
                        txt_Revise1.Text = drawLine.StartColumn.ToString("f4");
                        txt_Revise2.Text = drawLine.StartRow.ToString("f4");
                        txt_Revise3.Text = drawLine.EndColumn.ToString("f4");
                        txt_Revise4.Text = drawLine.EndRow.ToString("f4");
                        double startRow = _homMat2D.AffineTransPoint2d(drawLine.StartRow, drawLine.StartColumn, out double startColumn);
                        double endRow = _homMat2D.AffineTransPoint2d(drawLine.EndRow, drawLine.EndColumn, out double endColumn);
                        txt_Original1.Text = startColumn.ToString("f4");//起始点X
                        txt_Original2.Text = startRow.ToString("f4");
                        txt_Original3.Text = endColumn.ToString("f4");//终止点X
                        txt_Original4.Text = endRow.ToString("f4");
                        _drawROIable = new DrawLine(startRow, startColumn, endRow, endColumn);
                    }
                    else
                    {
                        txt_Original1.Text = drawLine.StartColumn.ToString("f4");//起始点X
                        txt_Original2.Text = drawLine.StartRow.ToString("f4");
                        txt_Original3.Text = drawLine.EndColumn.ToString("f4");//终止点X
                        txt_Original4.Text = drawLine.EndRow.ToString("f4");
                        _drawROIable = drawLine;
                    }
                    break;
                case "圆":
                    DrawCircle drawCircle = roi as DrawCircle;
                    if (_roiRevise)
                    {
                        txt_Revise1.Text = drawCircle.Column.ToString("f4");
                        txt_Revise2.Text = drawCircle.Row.ToString("f4");
                        txt_Revise3.Text = drawCircle.Radius.ToString("f4");
                        double row = _homMat2D.AffineTransPoint2d(drawCircle.Row, drawCircle.Column, out double column);
                        txt_Original1.Text = column.ToString("f4");
                        txt_Original2.Text = row.ToString("f4");
                        txt_Original3.Text = drawCircle.Radius.ToString("f4");
                        _drawROIable = new DrawCircle(row, column, drawCircle.Radius);
                    }
                    else
                    {
                        txt_Original1.Text = drawCircle.Column.ToString("f4");
                        txt_Original2.Text = drawCircle.Row.ToString("f4");
                        txt_Original3.Text = drawCircle.Radius.ToString("f4");
                        _drawROIable = drawCircle;
                    }
                    break;
                case "椭圆":
                    DrawEllipse drawEllipse = roi as DrawEllipse;
                    if (_roiRevise)
                    {
                        txt_Revise1.Text = drawEllipse.Column.ToString("f4");
                        txt_Revise2.Text = drawEllipse.Row.ToString("f4");
                        txt_Revise3.Text = drawEllipse.Radius1.ToString("f4");
                        txt_Revise4.Text = drawEllipse.Radius2.ToString("f4");
                        txt_Revise5.Text = drawEllipse.Phi.ToString("f4");
                        double row = _homMat2D.AffineTransPoint2d(drawEllipse.Row, drawEllipse.Column, out double column);
                        _homMat2D.HomMat2dToAffinePar(out double sy, out double phi, out double theta, out double tx, out double ty);
                        txt_Original1.Text = column.ToString("f4");
                        txt_Original2.Text = row.ToString("f4");
                        txt_Original3.Text = drawEllipse.Radius1.ToString("f4");
                        txt_Original4.Text = drawEllipse.Radius2.ToString("f4");
                        txt_Original5.Text = ((drawEllipse.Phi + phi) * 180 / Math.PI).ToString("f4");
                    }
                    else
                    {
                        txt_Original1.Text = drawEllipse.Column.ToString("f4");
                        txt_Original2.Text = drawEllipse.Row.ToString("f4");
                        txt_Original3.Text = drawEllipse.Radius1.ToString("f4");
                        txt_Original4.Text = drawEllipse.Radius2.ToString("f4");
                        txt_Original5.Text = (drawEllipse.Phi * 180 / Math.PI).ToString("f4");
                    }
                    break;
                case "平行矩形":
                    DrawRectangle1 drawRectangle1 = roi as DrawRectangle1;
                    if (_roiRevise)
                    {
                        txt_Revise1.Text = drawRectangle1.Column1.ToString("f4");
                        txt_Revise2.Text = drawRectangle1.Row1.ToString("f4");
                        txt_Revise3.Text = drawRectangle1.Column2.ToString("f4");
                        txt_Revise4.Text = drawRectangle1.Row2.ToString("f4");
                        double row1 = _homMat2D.AffineTransPoint2d(drawRectangle1.Row1, drawRectangle1.Column1, out double column1);
                        double row2 = _homMat2D.AffineTransPoint2d(drawRectangle1.Row2, drawRectangle1.Column2, out double column2);
                        txt_Original1.Text = column1.ToString("f4");
                        txt_Original2.Text = row1.ToString("f4");
                        txt_Original3.Text = column2.ToString("f4");
                        txt_Original4.Text = row2.ToString("f4");
                        _drawROIable = new DrawRectangle1(row1, column1, row2, column2);
                    }
                    else
                    {
                        txt_Original1.Text = drawRectangle1.Column1.ToString("f4");
                        txt_Original2.Text = drawRectangle1.Row1.ToString("f4");
                        txt_Original3.Text = drawRectangle1.Column2.ToString("f4");
                        txt_Original4.Text = drawRectangle1.Row2.ToString("f4");
                        _drawROIable = drawRectangle1;
                    }
                    break;
                case "旋转矩形":
                    DrawRectangle2 drawRectangle2 = roi as DrawRectangle2;
                    if (_roiRevise)
                    {
                        txt_Revise1.Text = drawRectangle2.Colulmn.ToString("f4");
                        txt_Revise2.Text = drawRectangle2.Row.ToString("f4");
                        txt_Revise3.Text = drawRectangle2.Length1.ToString("f4");
                        txt_Revise4.Text = drawRectangle2.Length2.ToString("f4");
                        txt_Revise5.Text = (drawRectangle2.Phi * 180 / Math.PI).ToString("f4");
                        double row = _homMat2D.AffineTransPoint2d(drawRectangle2.Row, drawRectangle2.Colulmn, out double column);
                        _homMat2D.HomMat2dToAffinePar(out double sy, out double phi, out double theta, out double tx, out double ty);
                        txt_Original1.Text = column.ToString("f4");
                        txt_Original2.Text = row.ToString("f4");
                        txt_Original3.Text = drawRectangle2.Length1.ToString("f4");
                        txt_Original4.Text = drawRectangle2.Length2.ToString("f4");
                        txt_Original5.Text = ((phi + drawRectangle2.Phi) * 180 / Math.PI).ToString("f4");
                        _drawROIable = new DrawRectangle2(row, column, phi + drawRectangle2.Phi, drawRectangle2.Length1, drawRectangle2.Length2);
                    }
                    else
                    {
                        txt_Original1.Text = drawRectangle2.Colulmn.ToString("f4");
                        txt_Original2.Text = drawRectangle2.Row.ToString("f4");
                        txt_Original3.Text = drawRectangle2.Length1.ToString("f4");
                        txt_Original4.Text = drawRectangle2.Length2.ToString("f4");
                        txt_Original5.Text = (drawRectangle2.Phi * 180 / Math.PI).ToString("f4");
                        _drawROIable = drawRectangle2;
                    }
                    break;
            }
        }

        private void UC_Image1_StartDrawEvent()//开始画ROI事件
        {
            cmb_ROIType.Enabled = false;
        }

        private void cmb_ROIType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_ROIType.SelectedItem.ToString())
            {
                case "线段":
                    SetControlVisible(true, _roiRevise);
                    lbl_Original1.Text = "起始点X：";
                    lbl_Original2.Text = "起始点Y：";
                    lbl_Original3.Text = "终止点X：";
                    lbl_Original4.Text = "终止点Y：";
                    lbl_Original5.Visible = false;
                    txt_Original5.Visible = false;
                    if (_roiRevise)
                    {
                        lbl_Revise1.Text = "起始点X：";
                        lbl_Revise2.Text = "起始点Y：";
                        lbl_Revise3.Text = "终止点X：";
                        lbl_Revise4.Text = "终止点Y：";
                        lbl_Revise5.Visible = false;
                        txt_Revise5.Visible = false;
                    }
                    break;
                case "圆":
                    SetControlVisible(true, _roiRevise);
                    lbl_Original1.Text = "中心点X：";
                    lbl_Original2.Text = "中心点Y：";
                    lbl_Original3.Text = "半径：";
                    lbl_Original4.Visible = false;
                    lbl_Original5.Visible = false;
                    txt_Original4.Visible = false;
                    txt_Original5.Visible = false;
                    if (_roiRevise)
                    {
                        lbl_Revise1.Text = "中心点X：";
                        lbl_Revise2.Text = "中心点Y：";
                        lbl_Revise3.Text = "半径：";
                        lbl_Revise4.Visible = false;
                        lbl_Revise5.Visible = false;
                        txt_Revise4.Visible = false;
                        txt_Revise5.Visible = false;
                    }
                    break;
                case "椭圆":
                    SetControlVisible(true, _roiRevise);
                    lbl_Original1.Text = "中心点X：";
                    lbl_Original2.Text = "中心点Y：";
                    lbl_Original3.Text = "长轴";
                    lbl_Original4.Text = "短轴";
                    lbl_Original5.Text = "角度";
                    if (_roiRevise)
                    {
                        lbl_Revise1.Text = "中心点X：";
                        lbl_Revise2.Text = "中心点Y：";
                        lbl_Revise3.Text = "长轴";
                        lbl_Revise4.Text = "短轴";
                        lbl_Revise5.Text = "角度";
                    }
                    break;
                case "平行矩形":
                    SetControlVisible(true, _roiRevise);
                    lbl_Original1.Text = "左上角X：";
                    lbl_Original2.Text = "左上角Y：";
                    lbl_Original3.Text = "右下角X：";
                    lbl_Original4.Text = "右下角Y：";
                    lbl_Original5.Visible = false;
                    txt_Original5.Visible = false;
                    if (_roiRevise)
                    {
                        lbl_Revise1.Text = "左上角X：";
                        lbl_Revise2.Text = "左上角Y：";
                        lbl_Revise3.Text = "右下角X：";
                        lbl_Revise4.Text = "右下角Y：";
                        lbl_Revise5.Visible = false;
                        txt_Revise5.Visible = false;
                    }
                    break;
                case "旋转矩形":
                    SetControlVisible(true, _roiRevise);
                    lbl_Original1.Text = "中心点X：";
                    lbl_Original2.Text = "中心点Y：";
                    lbl_Original3.Text = "半宽：";
                    lbl_Original4.Text = "半高：";
                    lbl_Original5.Text = "角度";
                    if (_roiRevise)
                    {
                        lbl_Revise1.Text = "中心点X：";
                        lbl_Revise2.Text = "中心点Y：";
                        lbl_Revise3.Text = "半宽：";
                        lbl_Revise4.Text = "半高：";
                        lbl_Revise5.Text = "角度";
                    }
                    break;
            }
        }

        private void SetControlVisible(bool b, bool isRevise)
        {
            foreach (Control item in gb_OriginalROI.Controls)
            {
                item.Visible = b;
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Text = "";
                }
            }
            if (isRevise)
            {
                foreach (Control item in gb_ROIReviseLate.Controls)
                {
                    item.Visible = b;
                    if (item is TextBox)
                    {
                        TextBox txt = item as TextBox;
                        txt.Text = "";
                    }
                }
            }
        }

        private void FrmCreateROI_Load(object sender, EventArgs e)
        {
            uC_Image1.DispImage(WindowIndexDic[CurrentWindowIndex].Image, true);//显示图片
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            _createROIClas.ROIType = cmb_ROIType.SelectedItem.ToString();
            if (_drawROIable != null)
            {
                _createROIClas._OriginalROI = _drawROIable;
            }
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
