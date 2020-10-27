using DispenseAPP;
using HalconDotNet;
using System;
using System.Drawing;

namespace VisionLibrary
{
    [Serializable]
    public class ContourMatching//基于轮廓的模板匹配
    {
        public HXLDCont[] BaseContourFindShapeModel(HImage image, HShapeModel hShapeModel, int startAngle, int angleExtent, int minScore, int numMatch, int maxOverlap, out PointF[] match, out double[] angle, out double[] score)// 基于轮廓的查找模板
        {
            HHomMat2D homMat2D = new HHomMat2D();
            HXLDCont[] XLD = null;
            try
            {
                HSystem.SetSystem("border_shape_models", "true");//超出图像边界的模型也可以被找到 认为是遮挡 需要增加时间 
                image.FindShapeModel(hShapeModel, new HTuple(startAngle).TupleRad(), new HTuple(angleExtent).TupleRad(), minScore * 1.0 / 100, numMatch, maxOverlap * 1.0 / 100, "least_squares", 0, 0.9, out HTuple rows, out HTuple columns, out HTuple angles, out HTuple scores);               
                match = new PointF[rows.Length];//重新定义数组的大小
                angle = new double[rows.Length];
                score = new double[rows.Length];
                XLD = new HXLDCont[rows.Length];
                for (int i = 0; i < rows.Length; i++)
                {
                    homMat2D.VectorAngleToRigid(0, 0, 0, rows[i].D, columns[i].D, angles[i].D);
                    XLD[i] = hShapeModel.GetShapeModelContours(1);//参数为金字塔层数
                    XLD[i] = XLD[i].AffineTransContourXld(homMat2D);
                    match[i].X = Convert.ToSingle(columns[i].F.ToString("f3"));
                    match[i].Y = Convert.ToSingle(rows[i].F.ToString("f3"));
                    angle[i] = Convert.ToDouble(angles[i].D.ToString("f3"));
                    score[i] = Convert.ToDouble(scores[i].D.ToString("f3"));
                }
            }
            catch
            {
                match = null;
                angle = null;
                score = null;
                XLD = null;
            }
            return XLD;
        }

        public HShapeModel BaseContourCreateShapeMode(HImage Image, int numLevels, string optimization, string metric, int contrast, int minContrast, uint min, uint max, out HXLDCont xld)
        {
            HShapeModel shapeModel = null;
            HXLDCont xldCont = null;
            HHomMat2D homMat2D = new HHomMat2D();
            Image.GetImageSize(out int width, out int height);
            try
            {
                shapeModel = Image.CreateShapeModel(numLevels, new HTuple(-180).TupleRad(), new HTuple(360).TupleRad(), "auto", optimization, metric, contrast, minContrast);
                if (shapeModel != null && shapeModel.IsInitialized())
                {
                    xldCont = shapeModel.GetShapeModelContours(1);//获得形状模型的轮廓 得到的轮廓处于(0,0)的位置
                    xldCont = xldCont.SelectContoursXld("contour_length", min, max, -0.5, 0.5);
                    homMat2D.VectorAngleToRigid(0, 0, 0, height / 2d, width / 2d, 0);
                    xld = xldCont.AffineTransContourXld(homMat2D);
                }
                else
                {
                    xld = null;
                }
            }
            catch
            {
                xld = null;
                shapeModel = null;
            }
            finally
            {
                xldCont.Dispose();
            }
            return shapeModel;
        }

        public int AutoComputerNumLevels(HShapeModel shapeModel)
        {
            return shapeModel.GetShapeModelParams(out double angleStart, out double angleExtent, out double angleStep, out double scaleMin, out double scaleMax, out double scaleStep, out string metric, out int minContrast);
        }
    }
}
