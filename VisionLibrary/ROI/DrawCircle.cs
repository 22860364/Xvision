using HalconDotNet;

namespace VisionLibrary.ROI
{
    public class DrawCircle:DrawROIable 
    {
        public DrawCircle(double row,double column,double radius)
        {
            Row = row;
            Column = column;
            Radius = radius;
            ROIType = ROIType.Circle;
            Region = new HRegion(Row, Column, Radius);
        }
        public double Row { get; set; }

        public double Column { get; set; }

        public double Radius { get; set; }

        public override DrawROIable AffineTransROI(HHomMat2D homMat2D)
        {
            double row = homMat2D.AffineTransPoint2d(Row, Column, out double column);
            return new DrawCircle(row, column, Radius);
        }
    }
}
