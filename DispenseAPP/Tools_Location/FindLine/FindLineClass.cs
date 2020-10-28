using HalconDotNet;
using System.Drawing;
using VisionLibrary;

namespace DispenseAPP.Tools_Location.FindLine
{
    public class FindLineClass : ITools
    {
        public string ROI { get; set; } = "常量";
        public string ReviseROI { get; set; } = "不使用";
        public bool NoCalib { get; set; } = true;
        public bool HaveCalib { get; set; }
        public bool EnableStartAngle { get; set; } = false;
        public bool EnableEndAngle { get; set; } = false;
        public ushort StartAngle { get; set; }
        public ushort AngleRange { get; set; }
        public string CurrentAngle { get; set; } = "Null";
        public bool DispResult { get; set; } = true;
        public EdgePolarEnum EdgePolar { get; set; } = EdgePolarEnum.negative;//从白到黑
        public EdgeTypeEnum EdgeType { get; set; } = EdgeTypeEnum.first;//默认第一条
        public ushort EdgeThreshold { get; set; } = 30;
        public ushort SearchPointNum { get; set; } = 30;
        public ushort EdgeWidth { get; set; } = 1;

        private PointF _firstPoint;
        public PointF FirstPoint { get { return _firstPoint; } set { _firstPoint = value; } }

        private PointF _endPoint;
        public PointF EndPoint { get { return _endPoint; } set { _endPoint = value; } }

        private double _angle;
        public double Angle { get { return _angle; } set { _angle = value; } }
        public double Row { get; set; }
        public double Column { get; set; }
        public double Phi { get; set; }
        public double Length1 { get; set; }
        public double Length2 { get; set; }


        public FindLineClass()
        {
            ToolsKitName = ToolsKitNameEnum.Location;
            ToolsName = ToolsNameEnum.FindLine;
        }

        public override void Execute(UC_Image imageWindow)
        {
            LineDetection lineDetection = new LineDetection();
            HImage image = imageWindow.Image;
            HRegion region = new HRegion();
            region.GenRectangle2(Row, Column, Phi, Length1, Length2);
            if (image != null && image.IsInitialized())
            {
                if (ROI != "常量")
                {

                }
                if (ReviseROI != "不使用")
                {

                }
                lineDetection.FindLine(image, Row, Column, Phi, Length1, Length2, SearchPointNum, EdgeWidth, EdgeThreshold, EdgePolar, EdgeType, out _firstPoint, out _endPoint, out _angle, out HXLDCont[] xldCont, out HXLDCont line);
                HSystem.SetSystem("flush_graphic", "false");
                if (imageWindow != null)
                {
                    imageWindow.DispImage(image);
                }
                if (DispResult == true && imageWindow != null)
                {
                    imageWindow.Window.SetDraw("margin");
                    if (line != null && line.IsInitialized())//找到了直线  之后需要加限制条件
                    {
                        imageWindow.DispObject(region, true, "blue");
                        imageWindow.DispObject(line, false, "green");
                    }
                    else //未找到直线 
                    {
                        imageWindow.DispObject(region, true, "red");
                        ExecuteResult = "None";
                        StepState = false;
                        ExecuteState = CommonClass.ExecuteStateEnum.NG;
                    }
                }
                HSystem.SetSystem("flush_graphic", "true");
            }
        }
    }
}
