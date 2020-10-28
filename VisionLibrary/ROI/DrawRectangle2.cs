using HalconDotNet;

namespace VisionLibrary.ROI
{
    public class DrawRectangle2:DrawROIable 
    {
        public DrawRectangle2(double row,double column,double phi,double length1,double length2)
        {
            Row = row;
            Colulmn = column;
            Phi = phi;
            Length1 = length1;
            Length2 = length2;
            ROIType = ROIType.Rectangle2;
            Region = new HRegion();
            Region.GenRectangle2(Row, Colulmn, Phi, Length1, Length2);
        }
        public double Row { get; set; }

        public double Colulmn { get; set; }

        public double Phi { get; set; }

        public double Length1 { get; set; }

        public double Length2 { get; set; }

        public override DrawROIable AffineTransROI(HHomMat2D homMat2D)
        {
            double row = homMat2D.AffineTransPoint2d(Row,Colulmn, out double column);
            homMat2D.HomMat2dToAffinePar(out double sy,out double phi,out double theta,out double tx,out double ty);
            return new DrawRectangle2(row, column, Phi + phi, Length1, Length2);
        }
    }
}
