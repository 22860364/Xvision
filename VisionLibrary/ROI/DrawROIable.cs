using HalconDotNet;

namespace VisionLibrary.ROI
{
    public enum ROIType
    {
        Point,
        Circle,
        Line,
        Rectangle1,
        Rectangle2,
        Ellipse,
    }
    public abstract class DrawROIable
    {
        public ROIType ROIType { get; set; } //ROI类型

        public HRegion Region { get; set; }//区域

        public abstract DrawROIable AffineTransROI(HHomMat2D homMat2D);//抽象方法
    }
}
