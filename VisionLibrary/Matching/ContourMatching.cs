using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace VisionLibrary
{
    [Serializable]
    public class ContourMatching//基于轮廓的模板匹配
    {
        public void BaseContourFindShapeModel(HImage _HImage, HShapeModel hShapeModel, int startAngle, int angleExtent, int minScore, int numMatch, int maxOverlap, int numLeveles, int contrast, int minContrast, uint min, uint max, out List<ContourMatchingResult> contourMatchingResultList, out List<float[]> X, out List<float[]> Y)// 基于轮廓的查找模板
        {
            HHomMat2D homMat2D = new HHomMat2D();
            contourMatchingResultList = new List<ContourMatchingResult>();
            X = new List<float[]>();
            Y = new List<float[]>();
            HXLDCont XLD = null;
            try
            {
                HSystem.SetSystem("border_shape_models", "true");//超出图像边界的模型也可以被找到 认为是遮挡 需要增加时间                 
                _HImage.FindShapeModel(hShapeModel, new HTuple(startAngle).TupleRad(), new HTuple(angleExtent).TupleRad(), minScore * 1.0 / 100, numMatch, maxOverlap * 1.0 / 100, "least_squares", numLeveles, 0.1, out HTuple rows, out HTuple columns, out HTuple angles, out HTuple scores);
                for (int i = 0; i < rows.Length; i++)
                {
                    homMat2D.VectorAngleToRigid(0, 0, 0, rows[i].D, columns[i].D, angles[i].D);
                    XLD = hShapeModel.GetShapeModelContours(1);//参数为金字塔层数
                    HXLDCont __XLD = XLD.SelectContoursXld("contour_length", min, max, -0.5, 0.5);
                    HXLDCont ___XLD = __XLD.AffineTransContourXld(homMat2D);
                    ContourMatchingResult matchingResult = new ContourMatchingResult
                    {
                        中心X =  Convert.ToSingle(columns[i].F.ToString("f3")) * 1,
                        中心Y = Convert.ToSingle(rows[i].F.ToString("f3")) * -1,
                        旋转角度 = Convert.ToDouble(angles[i].D.ToString("f3")),
                        分数 = Convert.ToDouble(scores[i].D.ToString("f3")),
                    };
                    contourMatchingResultList.Add(matchingResult);
                    int count = ___XLD.CountObj();//获得轮廓的数量
                    for (int j = 1; j <= count; j++)
                    {
                        HXLDCont hXLDCont = ___XLD.SelectObj(j);
                        hXLDCont.GetContourXld(out HTuple row, out HTuple col);
                        X.Add(col.ToFArr());
                        Y.Add(row.ToFArr());
                    }
                }
            }
            catch
            {
            }
            finally
            {
                if (XLD != null)
                {
                    XLD.Dispose();
                }
            }
        }


        public HShapeModel BaseContourCreateShapeMode(HImage hImage,  int contrast, int minContrast, uint min, uint max, out List<float[]> X, out List<float[]> Y)
        {
            X = new List<float[]>();
            Y = new List<float[]>();
            HXLDCont xldCont = null;
            HShapeModel _HShapeModel = null;
            try
            {
                hImage.GetImageSize(out int width, out int height);
                HSystem.SetSystem("border_shape_models", "false");
                _HShapeModel = hImage.CreateShapeModel("auto", new HTuple(0).TupleRad(), new HTuple(360).TupleRad(), "auto", new HTuple("point_reduction_high").TupleConcat(
        "no_pregeneration"), "use_polarity", new HTuple(minContrast).TupleConcat(contrast).TupleConcat(
        15), 7);
                xldCont = _HShapeModel.GetShapeModelContours(1);//获得形状模型的轮廓 得到的轮廓处于(0,0)的位置
                xldCont = xldCont.SelectContoursXld("contour_length", min, max, -0.5, 0.5);
                HHomMat2D homMat2D = new HHomMat2D();
                homMat2D.VectorAngleToRigid(0, 0, 0, height / 2d, width / 2d, 0);
                xldCont = xldCont.AffineTransContourXld(homMat2D);
                int count = xldCont.CountObj();
                for (int i = 1; i <= count; i++)
                {
                    HXLDCont hXLDCont = xldCont.SelectObj(i);
                    hXLDCont.GetContourXld(out HTuple row, out HTuple col);
                    X.Add(col.ToFArr());
                    Y.Add(row.ToFArr());
                }
            }
            catch
            {
            }
            finally
            {
                if (xldCont != null)
                {
                    xldCont.Dispose();
                }
            }
            return _HShapeModel;
        }

        public int AutoComputerNumLevels(HShapeModel shapeModel)
        {
            return shapeModel.GetShapeModelParams(out double angleStart, out double angleExtent, out double angleStep, out double scaleMin, out double scaleMax, out double scaleStep, out string metric, out int minContrast);
        }
    }

    public class ContourMatchingResult
    {
        public float 中心X { get; set; }

        public float 中心Y { get; set; }

        public double 分数 { get; set; }

        public double 旋转角度 { get; set; }
    }
}
