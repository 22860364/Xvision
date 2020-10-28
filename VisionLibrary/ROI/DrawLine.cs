using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;

namespace VisionLibrary.ROI
{
    public class DrawLine:DrawROIable 
    {
        public DrawLine(double startRow,double startColumn,double endRow,double endColumn)
        {
            StartRow = startRow;
            StartColumn = startColumn;
            EndRow = endRow;
            EndColumn = endColumn;
            ROIType = ROIType.Line;
            Region = new HRegion();
            Region.GenRegionLine(StartRow, StartColumn, EndRow, EndColumn);
        }
        public double StartRow { get; set; }

        public double StartColumn { get; set; }

        public double EndRow { get; set; }
         
        public double EndColumn { get; set; }

        public override DrawROIable AffineTransROI(HHomMat2D homMat2D)
        {
            double startRow = homMat2D.AffineTransPoint2d(StartRow, StartColumn, out double startColumn);
            double endRow = homMat2D.AffineTransPoint2d(EndColumn, EndRow, out double endColumn);
            return new DrawLine(startRow, startColumn, endRow, endColumn);
        }
    }
}
