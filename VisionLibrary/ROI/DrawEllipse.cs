using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionLibrary.ROI
{
    public class DrawEllipse:DrawROIable //画椭圆
    {
        public DrawEllipse(double row,double column,double phi,double radius1,double radius2)
        {
            Row = row;
            Column = column;
            Phi = phi;
            Radius1 = radius1;
            Radius2 = radius2;
            ROIType = ROIType.Ellipse;
            Region = new HRegion();
            Region.GenEllipse(Row, Column, Phi, Radius1, Radius2);
        }
        public double Row { get; set; }

        public double Column { get; set; }

        public double Phi { get; set; }

        public double Radius1 { get; set; }

        public double Radius2 { get; set; }

        public override DrawROIable AffineTransROI(HHomMat2D homMat2D)
        {
            double row = homMat2D.AffineTransPoint2d(Row, Column,  out double column);
            homMat2D.HomMat2dToAffinePar(out double sy, out double phi, out double theta, out double tx, out double ty);
            return new DrawEllipse(row, column, Phi + phi, Radius1, Radius2);
        }
    }
}
