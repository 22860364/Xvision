using DispenseAPP.CustomControl;
using DispenseAPP.Tools_Location.CalibROI;
using HalconDotNet;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VisionLibrary.ROI;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_Location.ContourMatchin
{
    public partial class FrmContourMathing : FormM
    {

        private ContourMatchingClass _contourMatchingClass;

        private HImage TemplateImage;//模板图片

        private HXLDCont XLD = null;

        private VisionLibrary.ContourMatching matching = new VisionLibrary.ContourMatching();

        private HShapeModel _hShapeMode = null;

        private bool isInitial = false;

        private HRegion _hRegion = null;

        private string _roi;

        public FrmContourMathing(ContourMatchingClass contourMathingClass, string roi)
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲      
            _contourMatchingClass = contourMathingClass;
            num_LowThreshold.Value = _contourMatchingClass.LowThreshold;
            num_HightThreshold.Value = _contourMatchingClass.HighThreshold;
            num_MinContour.Value = _contourMatchingClass.MinContour;
            num_MaxContour.Value = _contourMatchingClass.MaxContour;
            cmb_NumLevels.SelectedItem = _contourMatchingClass.NumLeves.ToString();
            num_StartAngle.Value = _contourMatchingClass.StartAngle;
            num_AngleExtent.Value = _contourMatchingClass.AngleExtent;
            num_OverLap.Value = _contourMatchingClass.MaxOverLap;
            num_MinScore.Value = _contourMatchingClass.MinScore;
            num_MatchingNum.Value = _contourMatchingClass.NumMatches;
            _hShapeMode = _contourMatchingClass._HShapeModel;
            //显示图像控件初始化
            UC_Image.StartDrawEvent += UC_Image_StartDrawEvent;//开始画ROI事件  
            UC_Image.DrawFinshEvent += UC_Image_DrawFinshEvent;//画ROI结束事件
            isInitial = true;
            _roi = roi;
        }

        private void UC_Image_DrawFinshEvent(DrawROIable rectangle1)
        {
            panel_Param.Enabled = true;
            btn_OK.Enabled = true;
            btn_Cancel.Enabled = true;
            btn_Matching.Enabled = true;
            HRegion region = new HRegion();
            DrawRectangle1 _rectangle1 = rectangle1 as DrawRectangle1;
            region.GenRectangle1(_rectangle1.Row1, _rectangle1.Column1, _rectangle1.Row2, _rectangle1.Column2);
            _hRegion = region;
            TemplateImage = UC_Image.Image.ReduceDomain(_hRegion);//减少图像的域
            TemplateImage = TemplateImage.CropDomain();
        }

        private void FrmContourMathing_Load(object sender, EventArgs e)//显示传入的图像
        {
            UC_Image.DispImage(WindowIndexDic[CurrentWindowIndex].Image, true);
            if (_contourMatchingClass._TemplateImage != null && _contourMatchingClass._TemplateImage.IsInitialized())
            {
                TemplateImage = _contourMatchingClass._TemplateImage;
                CreateShapeModel();
            }
        }

        private void UC_Image_StartDrawEvent()
        {
            panel_Param.Enabled = false;
            btn_OK.Enabled = false;
            btn_Cancel.Enabled = false;
            btn_Matching.Enabled = false;
        }

        private void btn_New_Click(object sender, EventArgs e)//新建  首先要判断当前是否有画ROI
        {
            if (_hRegion != null && _hRegion.IsInitialized() && TemplateImage != null && TemplateImage.IsInitialized())//点击新建后 
            {
                CreateShapeModel();
                UC_Image.DispImage(UC_Image.Image, true);
                _hRegion = null;
            }
            else
            {
                MessageBox.Show("未设置ROI或ROI越界！", "ROI消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CreateShapeModel()//创建模板
        {
            _hShapeMode = matching.BaseContourCreateShapeMode(TemplateImage, Convert.ToInt32(cmb_NumLevels.SelectedItem.ToString()), "no_pregeneration", "use_polarity", (int)num_HightThreshold.Value, (int)num_LowThreshold.Value, (uint)num_MinContour.Value, (uint)num_MaxContour.Value, out XLD);
            UC_Image_Template.DispImage(TemplateImage, true);
            if (XLD != null && XLD.IsInitialized())
            {
                UC_Image_Template.DispXLD(XLD);
            }
            else
            {
                MessageBox.Show("模板没有有效的轮廓！", "轮廓匹配", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)//加载
        {
        }

        private void btn_Edit_Click(object sender, EventArgs e)//编辑
        {
        }

        private void btn_Save_Click(object sender, EventArgs e)//保存 将创建好的模板保存到本地 下次可以直接使用
        {
            if (_hShapeMode != null && _hShapeMode.IsInitialized())
            {
                using (SaveFileDialog saveFile = new SaveFileDialog())//弹出保存对话框
                {
                    saveFile.Filter = "BMP文件(*.bmp)|*.bmp|JPG文件(*.jpg)|*.jpg|PNG文件(*.png)|*.png";
                    saveFile.FilterIndex = 1;
                    saveFile.RestoreDirectory = true;//对话框关闭前还原目录
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        TemplateImage.WriteImage(Path.GetExtension(saveFile.FileName), 0, saveFile.FileName);
                    }
                }
            }
            else
            {
                MessageBox.Show("还未创建模板图片！", "模板图片消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void num_LowThreshold_ValueChanged(object sender, EventArgs e)//当低阈值改变时 重新创建模板
        {
            if (isInitial == true)
            {
                num_HightThreshold.Minimum = num_LowThreshold.Value;
                if (TemplateImage != null && TemplateImage.IsInitialized())
                {
                    CreateShapeModel();
                }
            }
        }

        private void num_HightThreshold_ValueChanged(object sender, EventArgs e)//当高阈值改变时 重新创建模板
        {
            if (isInitial == true)//当初始化完成后 才可以手动创建模板
            {
                num_LowThreshold.Maximum = num_HightThreshold.Value;
                if (TemplateImage != null && TemplateImage.IsInitialized())
                {
                    CreateShapeModel();
                }
            }
        }

        private void DG_MatchingNum_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)//绘制行号
        {
            Rectangle rct = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, DG_MatchingNum.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), DG_MatchingNum.RowHeadersDefaultCellStyle.Font, rct, DG_MatchingNum.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (_hShapeMode != null && _hShapeMode.IsInitialized())
            {
                //创建参数
                _contourMatchingClass.HighThreshold = (ushort)num_HightThreshold.Value;
                _contourMatchingClass.LowThreshold = (ushort)num_LowThreshold.Value;
                _contourMatchingClass.Smooth = (float)num_Smooth.Value;
                _contourMatchingClass.MinContour = (uint)num_MinContour.Value;
                _contourMatchingClass.MaxContour = (uint)num_MaxContour.Value;
                _contourMatchingClass.NumLeves = Convert.ToUInt16(cmb_NumLevels.SelectedItem.ToString());
                //查找参数
                _contourMatchingClass.StartAngle = (short)num_StartAngle.Value;
                _contourMatchingClass.AngleExtent = (short)num_AngleExtent.Value;
                _contourMatchingClass.MaxOverLap = (ushort)num_OverLap.Value;
                _contourMatchingClass.NumMatches = (ushort)num_MatchingNum.Value;
                _contourMatchingClass.MinScore = (ushort)num_MinScore.Value;
                _contourMatchingClass._HShapeModel = _hShapeMode.Clone();//将模板ID克隆一份
                _contourMatchingClass._TemplateImage = TemplateImage.Clone();//将模板图片克隆一份
                Close();
            }
            else
            {
                MessageBox.Show("请创建有效的模板！", "轮廓匹配模板", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void num_MinContour_ValueChanged(object sender, EventArgs e)
        {
            if (isInitial == true)
            {
                num_MaxContour.Minimum = num_MinContour.Value;
                if (TemplateImage != null && TemplateImage.IsInitialized())
                {
                    CreateShapeModel();
                }
            }
        }

        private void num_MaxContour_ValueChanged(object sender, EventArgs e)
        {
            if (isInitial == true)
            {
                num_MinContour.Maximum = num_MaxContour.Value;
                if (TemplateImage != null && TemplateImage.IsInitialized())
                {
                    CreateShapeModel();
                }
            }
        }

        private void cmb_NumLevels_SelectedIndexChanged(object sender, EventArgs e)//当金字塔层数发生改变后
        {
            if (isInitial == true)
            {
                if (_hShapeMode != null && _hShapeMode.IsInitialized())
                {
                    if (cmb_NumLevels.SelectedItem.ToString() == "自动")
                    {
                        cmb_NumLevels.SelectedItem = matching.AutoComputerNumLevels(_hShapeMode).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("轮廓模板未就绪！");
                }
            }
        }

        private void btn_Matching_Click(object sender, EventArgs e)
        {
            double[] angle, score;
            PointF[] match;
            HImage image = UC_Image.Image;
            HXLDCont[] xldCont;
            HRegion roi_Region = null;
            if (_hShapeMode != null && _hShapeMode.IsInitialized())
            {
                UC_Image.DispImage(image, true);
                UC_Image.Window.SetDraw("margin");
                if (_roi != "全图")
                {
                    roi_Region = (_contourMatchingClass.SelectedNormalBlock.ToolsList.Find(c => c.BlockName == _roi) as CreateROIClass)._OriginalROI.Region;
                    if (roi_Region != null && roi_Region.IsInitialized())
                    {
                        image = image.ReduceDomain(roi_Region);
                    }
                    else
                    {
                        MessageBox.Show("ROI区域不存在", "ROI提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }
                xldCont = matching.BaseContourFindShapeModel(image, _hShapeMode, (int)num_StartAngle.Value, (int)num_AngleExtent.Value, (int)num_MinScore.Value, (int)num_MatchingNum.Value, (int)num_OverLap.Value, out match, out angle, out score);
                if (_roi != "全图")
                {
                    if (match.Length > 0)
                    {
                        UC_Image.DispObject(roi_Region, true, "blue");
                    }
                    else
                    {
                        UC_Image.DispObject(roi_Region, true, "red");
                    }
                }
                DG_MatchingNum.Rows.Clear();
                if (match != null)//当异常时 数组是引用类型  设为null
                {
                    for (int i = 0; i < match.Length; i++)
                    {
                        DG_MatchingNum.RowCount = match.Length;
                        DG_MatchingNum.Rows[i].Cells[0].Value = match[i].X.ToString("f4");
                        DG_MatchingNum.Rows[i].Cells[1].Value = match[i].Y.ToString("f4");
                        DG_MatchingNum.Rows[i].Cells[2].Value = angle[i].ToString("f4");
                        DG_MatchingNum.Rows[i].Cells[3].Value = score[i].ToString("f4");
                        UC_Image.DispObject(xldCont[i], false, "green");
                    }
                }
            }
            else
            {
                MessageBox.Show("请加载模板图像！", "轮廓匹配", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
