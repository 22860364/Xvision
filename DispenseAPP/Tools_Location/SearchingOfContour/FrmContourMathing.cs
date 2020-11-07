using DispenseAPP.CustomControl;
using System;
using System.Drawing;
using System.Windows.Forms;
using VisionLibrary;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using HalconDotNet;
using VisionWindow;
using DispenseAPP.Tools_Location.ContourMatching;

namespace DispenseAPP.Tools_Location.ContourMatchin
{
    /// <summary>
    /// 轮廓匹配窗体
    /// </summary>
    public partial class FrmContourMathing : FormM
    {
        VisionLibrary.ContourMatching contourMatching = new VisionLibrary.ContourMatching();
        bool isInitial = true;
        List<float[]> X = null;
        List<float[]> Y = null;
        Bitmap tempBitmap = null;//模板图片
        HImage hTempImage = null;//Halcon的模板图片
        float zoom;
        PointF screen = new PointF(0, 0);
        List<ContourMatchingResult> contourMatchingResultList = null;
        Rectangle rectangle;
        HShapeModel _hShapeModel = null;

        SearchOfContourToolEntity Entity { get; set;}
        private void FrmContourMathing_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {

            }
        }
        public FrmContourMathing(SearchOfContourToolEntity entity,Controller controller)
        {
            InitializeComponent();      
            if(controller != null && controller._Bitmap != null && controller._HImage != null)//可以选择从外部传入图片
            {
                uC_MyWindow1.Control.DispImage(controller._Bitmap, controller._HImage);
            }
            Entity = entity;
            InitialControlValue();
        }

        void InitialControlValue()
        {
            num_LowThreshold.Value = Entity.LowThreshold;
            num_HightThreshold.Value = Entity.HighThreshold;
            num_MinContour.Value = Entity.MinContour;
            num_MaxContour.Value = Entity.MaxContour;
            cmbNumLevels.SelectedItem = Entity.NumLeves.ToString();
            num_StartAngle.Value = Entity.StartAngle;
            num_AngleExtent.Value = Entity.AngleExtent;
            num_OverLap.Value = Entity.MaxOverLap;
            num_MinScore.Value = Entity.MinScore;
            num_MatchingNum.Value = Entity.NumMatches;
            isInitial = false;
            if (Entity.TempImage != null)//如果模板图片不为null  则执行创建模板的行为
            {
                tempBitmap = Entity.TempImage;
                hTempImage = Entity.HTempImage;
                ExecuteCreateModel();
                Pb_TempImage.Invalidate();
            }
        }

        public FrmContourMathing(SearchOfContourToolEntity entity)
        {
            Entity = entity;
            InitialControlValue();
        }

        void Btn_New_Click(object sender, EventArgs e)//新建 如果有画ROI 则裁剪出模板图片 如果没有裁剪 
        {
            //if (uC_MyWindow1.Control.ROIBase == null)
            //{
            //    MessageBox.Show("未设置ROI或ROI越界！");
            //    return;
            //}
            //rectangle = uC_MyWindow1.Control.GetRectangleROI();
            //tempBitmap = uC_MyWindow1.Control.CutImageByRectangleROI();
            //hTempImage = uC_MyWindow1.Control._HImage.CropPart(rectangle.Y, rectangle.X, rectangle.Width, rectangle.Height);
            //uC_MyWindow1.Control.ROIBase = null;
            //uC_MyWindow1.Control.ExecuteRePaint();
            //ExecuteCreateModel();
        }

        private void Btn_Matching_Click(object sender, EventArgs e)//执行匹配
        {
            if (tempBitmap == null)
            {
                MessageBox.Show("请加载模板图像!");
                return;
            }
            uC_MyWindow1.Control.DispXLDCont(null, null);
            contourMatching.BaseContourFindShapeModel(uC_MyWindow1.Control._HImage, _hShapeModel,(int)num_StartAngle.Value, (int)num_AngleExtent.Value, (int)num_MinScore.Value, (int)num_MatchingNum.Value, (int)num_OverLap.Value, Convert.ToInt32(cmbNumLevels.SelectedItem.ToString()),(int)num_HightThreshold.Value,(int)num_LowThreshold.Value,(uint)num_MinContour.Value,(uint)num_MaxContour.Value, out contourMatchingResultList, out List<float[]> X, out List<float[]> Y);
              DG_MatchingNum.DataSource = new BindingList<ContourMatchingResult>(contourMatchingResultList);
            if(X.Count >0 && Y.Count >0)
            {
                uC_MyWindow1.Control.DispXLDCont(X, Y);
            }
            else
            {
                MessageBox.Show("模板没有有效的轮廓！");
            }
        }

        void ExecuteCreateModel()//执行创建模板
        {
            if(tempBitmap != null && hTempImage != null)
            {
                _hShapeModel = contourMatching.BaseContourCreateShapeMode(hTempImage,(int)num_HightThreshold.Value, (int)num_LowThreshold.Value, (uint)num_MinContour.Value, (uint)num_MaxContour.Value, out X, out Y);
                ComputerDispRectangle();
                Pb_TempImage.Invalidate();
                if(X.Count ==0 || Y.Count == 0)
                {
                    MessageBox.Show("模板没有有效的轮廓！");
                }
            }
            else
            {
                MessageBox.Show("模板没有有效的轮廓！");
            }
        }

        void Num_LowThreshold_ValueChanged(object sender, EventArgs e)//当低阈值改变时 重新创建模板
        {
            if (isInitial == false)
            {
                num_HightThreshold.Minimum = num_LowThreshold.Value;
                ExecuteCreateModel();
            }
        }

        void Num_HightThreshold_ValueChanged(object sender, EventArgs e)//当高阈值改变时 重新创建模板
        {
            if (isInitial == false )
            {
                num_LowThreshold.Maximum = num_HightThreshold.Value;
                ExecuteCreateModel();
            }
        }

        void DG_MatchingNum_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)//绘制行号
        {
            Rectangle rct = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, DG_MatchingNum.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), DG_MatchingNum.RowHeadersDefaultCellStyle.Font, rct, DG_MatchingNum.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

        void Btn_OK_Click(object sender, EventArgs e)
        {
            //创建参数
            Entity.HighThreshold = (ushort)num_HightThreshold.Value;
            Entity.LowThreshold = (ushort)num_LowThreshold.Value;
            Entity.MinContour = (uint)num_MinContour.Value;
            Entity.MaxContour = (uint)num_MaxContour.Value;
            Entity.NumLeves = Convert.ToUInt16(cmbNumLevels.SelectedItem.ToString());
            //查找参数
            Entity.StartAngle = (short)num_StartAngle.Value;
            Entity.AngleExtent = (short)num_AngleExtent.Value;
            Entity.MaxOverLap = (ushort)num_OverLap.Value;
            Entity.NumMatches = (ushort)num_MatchingNum.Value;
            Entity.MinScore = (ushort)num_MinScore.Value;
            if (tempBitmap != null)
            {
                Entity.TempImage = tempBitmap;//保存模板图片
            }
            if(_hShapeModel != null && _hShapeModel.IsInitialized())
            {
                Entity._HShapeModel = _hShapeModel.Clone();
            }
            if(hTempImage != null)
            {
                Entity.HTempImage = hTempImage;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Num_MinContour_ValueChanged(object sender, EventArgs e)
        {
            if (isInitial == false )
            {
                num_MaxContour.Minimum = num_MinContour.Value;
                ExecuteCreateModel();
            }
        }

        void Num_MaxContour_ValueChanged(object sender, EventArgs e)
        {
            if (isInitial == false )
            {
                num_MinContour.Maximum = num_MaxContour.Value;
                ExecuteCreateModel();
            }
        }

        void Cmb_NumLevels_SelectedIndexChanged(object sender, EventArgs e)//当金字塔层数发生改变后
        {
            if (isInitial == false )
            {

            }
        }

        void Pb_TempImage_Paint(object sender, PaintEventArgs e)
        {
            Bitmap _bitmap = new Bitmap(Pb_TempImage.Width, Pb_TempImage.Height);
            Graphics g = Graphics.FromImage(_bitmap);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.Clear(Pb_TempImage.BackColor);
            if (tempBitmap != null)
            {
                g.DrawImage(tempBitmap, screen.X, screen.Y, tempBitmap.Width * zoom, tempBitmap.Height * zoom);
            }
            if (X != null && Y != null)
            {
                for (int j = 0; j < X.Count; j++)
                {
                    for (int i = 0; i < X[j].Length; i++)
                    {
                        g.FillEllipse(Brushes.Blue, ImageToPB(X[j][i], XYTypeEnum.X), ImageToPB(Y[j][i], XYTypeEnum.Y), 1, 1);
                    }
                }
            }
            e.Graphics.DrawImage(_bitmap, 0, 0, _bitmap.Width, _bitmap.Height);
            g.Dispose();
            _bitmap.Dispose();
        }

        void ComputerDispRectangle()//计算显示的矩形
        {
            if (tempBitmap != null)
            {
                zoom = Math.Min((float)Pb_TempImage.ClientRectangle.Width / tempBitmap.Width, (float)Pb_TempImage.ClientRectangle.Height / tempBitmap.Height);
                screen.X = (Pb_TempImage.ClientRectangle.Width - (tempBitmap.Width * zoom)) / 2;
                screen.Y = (Pb_TempImage.ClientRectangle.Height - (tempBitmap.Height * zoom)) / 2;
            }
        }

        #region 坐标系转换
        enum XYTypeEnum
        {
            X,
            Y,
        }

        float ImageToPB(float pos, XYTypeEnum xyType)
        {
            float value = 0f;
            switch (xyType)
            {
                case XYTypeEnum.X:
                    value = pos * zoom + screen.X;
                    break;
                case XYTypeEnum.Y:
                    value = pos * zoom + screen.Y;
                    break;
            }
            return value;
        }
        #endregion

        private void FrmContourMathing_FormClosing(object sender, FormClosingEventArgs e)
        {
            uC_MyWindow1.ExecuteClose();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)//编辑模板
        {
            if (tempBitmap == null)
            {
                MessageBox.Show("请加载模板图像!");
                return;
            }
            FrmEditContour frmEditContour = new FrmEditContour(tempBitmap, hTempImage);
            frmEditContour.ShowDialog();
        }
    }
}
