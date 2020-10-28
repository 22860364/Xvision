using System;
using HalconDotNet;
using System.Drawing;

namespace VisionLibrary
{
    public enum EdgePolarEnum//边缘极性
    {
        positive,
        negative,
        all,
    }

    public enum EdgeTypeEnum//边缘类型
    {
        first,
        last,
        all,
    }

    [Serializable]
    public class LineDetection
    {
        public void FindLine(HImage image, double Row, double Column, double Phi, double Length1, double Length2, ushort pointNum, ushort EdgeWidth, ushort EdgeThresold, EdgePolarEnum edgePolar, EdgeTypeEnum edgeType, out PointF firstPoint, out PointF endPoint, out double angle, out HXLDCont[] cross, out HXLDCont line)
        {
            double[] row = new double[pointNum];
            double[] column = new double[pointNum];
            HTuple _rowEdges = new HTuple();
            HTuple _columnEdges = new HTuple();
            image.GetImageSize(out int width, out int height);
            for (int i = 0; i <= (pointNum - 1) / 2; i++)//遍历搜索点数的一半
            {
                row[i] = Row - (Length2 - 2.0 * Length2 * (i + 1) / (pointNum + 1)) * Math.Cos(Phi);
                column[i] = Column - (Length2 - 2.0 * Length2 * (i + 1) / (pointNum + 1)) * Math.Sin(Phi);
                row[pointNum - 1 - i] = 2 * Row - row[i];
                column[pointNum - 1 - i] = 2 * Column - column[i];
            }
            for (int i = 0; i < pointNum - 1; i++)
            {
                HMeasure measure = new HMeasure(row[i], column[i], Phi, Length1, EdgeWidth, width, height, "nearest_neighbor");//获得测量矩形
                measure.MeasurePos(image, 1, EdgeThresold, edgePolar.ToString(), edgeType.ToString(), out HTuple rowEdge, out HTuple columnEdge, out HTuple Amplitude, out HTuple distance);//提取垂直于矩形或环形弧的直边
                if (rowEdge.Length > 0 && columnEdge.Length > 0)
                {
                    _rowEdges = _rowEdges.TupleConcat(rowEdge);
                    _columnEdges =_columnEdges.TupleConcat(columnEdge);
                }
            }
            if (_rowEdges.Length >5)
            {
                HXLDCont Contour = new HXLDCont(_rowEdges, _columnEdges);
                Contour.SmoothContoursXld(5);
                Contour.FitLineContourXld("tukey", -1, 0, 5, 2, out double rowBegin, out double columnBegin, out double rowEnd, out double columnEnd, out double nr, out double nc, out double dist);
                Contour.GenContourPolygonXld(new HTuple(rowBegin, rowEnd), new HTuple(columnBegin, columnEnd));
                cross = new HXLDCont[_rowEdges.Length];
                for (int i = 0; i < _rowEdges.Length; i++)
                {
                    HXLDCont _cross = new HXLDCont();
                    _cross.GenCrossContourXld(_rowEdges[i], _columnEdges[i], 30d, 0);
                    cross[i] = _cross;
                }
                firstPoint = new PointF((float)columnBegin, (float)rowBegin);
                endPoint = new PointF((float)columnEnd, (float)rowEnd);
                angle = HMisc.AngleLx(rowBegin, columnBegin, rowEnd, columnEnd) * 180 / Math.PI;
                line = Contour;
            }
            else
            {
                firstPoint = new PointF(0, 0);
                endPoint = new PointF(0, 0);
                cross = null;
                line = null;
                angle = 0;
            }
        }
    }
}
