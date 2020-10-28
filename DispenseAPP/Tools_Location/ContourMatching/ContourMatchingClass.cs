using DispenseAPP.Tools_Location.CalibROI;
using HalconDotNet;
using System;
using System.Drawing;
using VisionLibrary;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_Location.ContourMatchin
{
    [ReferenceAngle]
    [ReferencePoint]
    [Serializable]
    public class ContourMatchingClass : ITools
    {
        public string ROI { get; set; } = "全图";
        public bool DispResult { get; set; } = true;
        public ushort LowThreshold { get; set; } = 10;
        public ushort HighThreshold { get; set; } = 40;
        public short StartAngle { get; set; } = -30;
        public short AngleExtent { get; set; } = 30;
        public float Smooth { get; set; } = 3;
        public ushort NumMatches { get; set; } = 1;
        public ushort MaxOverLap { get; set; } = 50;
        public ushort MinScore { get; set; } = 60;
        public ushort NumLeves { get; set; } = 3;
        public uint MinContour { get; set; } = 100;
        public uint MaxContour { get; set; } = 100000;

        public HShapeModel _HShapeModel;

        public HImage _TemplateImage;

        [Reference(true)]
        public int Count { get; set; }

        private PointF[] _match;
        [Reference(false)]
        [ReferencePoint]
        public PointF[] Match
        { get { return _match; } set { _match = value; } }

        private double[] _angle;
        [Reference(false)]
        [ReferenceAngle]
        public double[] Angle
        { get { return _angle; } set { _angle = value; } }

        private double[] _score;
        [Reference(false)]
        public double[] Score
        { get { return _score; } set { _score = value; } }

        public ContourMatchingClass()
        {
            ToolsKitName = ToolsKitNameEnum.Location;
            ToolsName = ToolsNameEnum.ContourMatching;
        }

        public override void Execute(UC_Image imageWindow)
        {
            VisionLibrary.ContourMatching matching = new VisionLibrary.ContourMatching();
            HImage image = imageWindow.Image;
            HRegion region = null;
            HXLDCont[] xld = null;      
            if(image != null && image.IsInitialized())//首先保证有图像
            {
                if (ROI != "全图")
                {
                    region = (SelectedNormalBlock.ToolsList.Find(c => c.BlockName == ROI) as CreateROIClass)._OriginalROI.Region;
                    if (region != null && region.IsInitialized())
                    {
                        image = image.ReduceDomain(region);
                    }
                    else
                    {
                        SetResult();
                        return;
                    }
                }
                xld = matching.BaseContourFindShapeModel(image, _HShapeModel, StartAngle, AngleExtent, MinScore, NumMatches, MaxOverLap,  out _match, out _angle, out _score);
                if(imageWindow != null)
                {
                    imageWindow.DispImage(image);//先显示图片
                }
                if (DispResult == true && imageWindow != null)
                {
                    if (ROI != "全图")
                    {
                        if (_match.Length > 0)
                        {
                            imageWindow.DispObject(region, false, "blue");
                        }
                        else
                        {
                            imageWindow.DispObject(region, false, "red");
                        }
                    }
                    foreach (HXLDCont item in xld)
                    {
                        imageWindow.DispObject(item, false, "green");
                    }
                }
                if (_match.Length > 0)
                {
                    ExecuteResult = "MatchNum：" + _match.Length;
                    ExecuteState = ExecuteStateEnum.OK;
                    StepState = true;
                }
                else
                {
                    SetResult();
                }
            }
            else
            {
                SetResult();
            }
        }

        private void SetResult()
        {
            ExecuteResult = "MatchNum：0";
            ExecuteState = ExecuteStateEnum.NG;
            StepState = false;
        }
    }
}
