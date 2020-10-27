using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionLibrary.ROI
{
    public class DrawRectangle1:DrawROIable 
    {
        public DrawRectangle1(double row1,double column1,double row2,double column2)
        {
            Row1 = row1;
            Column1 = column1;
            Row2 = row2;
            Column2 = column2;
            ROIType = ROIType.Rectangle1;
            Region = new HRegion();
            Region.GenRectangle1(Row1, Column1, Row2, Column2);
        }
        public double Row1 { get; set; }

        public double Column1 { get; set; }

        public double Row2 { get; set; }

        public double Column2 { get; set; }

        public override DrawROIable AffineTransROI(HHomMat2D homMat2D)
        {
           double row1 = homMat2D.AffineTransPoint2d(Row1, Column1,  out double column1);
            double row2 = homMat2D.AffineTransPoint2d(Row2, Column2,  out double column2);
            return new DrawRectangle1(row1, column1, row2, column2);
        }
    }
}
