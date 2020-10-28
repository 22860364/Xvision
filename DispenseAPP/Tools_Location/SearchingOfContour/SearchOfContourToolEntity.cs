using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using VisionLibrary;
using static DispenseAPP.CommonClass;
using System.Linq;

namespace DispenseAPP.Tools_Location.ContourMatchin
{
    /// <summary>
    /// 轮廓匹配实体类
    /// </summary>
    [ReferenceAngle]
    [ReferencePoint]
    [Serializable]
    public class SearchOfContourToolEntity : IToolable
    {
        /// <summary>
        /// 用于序列化和反序列化
        /// </summary>
        public SearchOfContourToolEntity()
        {
        }

        /// <summary>
        /// 低阈值
        /// </summary>
        public ushort LowThreshold { get; set; } = 10;

        /// <summary>
        /// 高阈值
        /// </summary>
        public ushort HighThreshold { get; set; } = 40;

        /// <summary>
        /// 起始角度
        /// </summary>
        public short StartAngle { get; set; } = -30;

        /// <summary>
        /// 角度范围
        /// </summary>
        public short AngleExtent { get; set; } = 30;

        /// <summary>
        /// 匹配个数
        /// </summary>
        public ushort NumMatches { get; set; } = 1;

        /// <summary>
        /// 重合度
        /// </summary>
        public ushort MaxOverLap { get; set; } = 50;

        /// <summary>
        /// 最小分数
        /// </summary>
        public ushort MinScore { get; set; } = 60;

        /// <summary>
        /// 金字塔层数
        /// </summary>
        public ushort NumLeves { get; set; } = 3;

        /// <summary>
        /// 最短轮廓 
        /// </summary>
        public uint MinContour { get; set; } = 100;

        /// <summary>
        /// 最长轮廓
        /// </summary>
        public uint MaxContour { get; set; } = 100000;

        /// <summary>
        /// 模板图片
        /// </summary>
        public Bitmap TempImage { get; set; } = null;

        /// <summary>
        /// 模板ID
        /// </summary>
        public HShapeModel _HShapeModel { get; set; } = null;

        /// <summary>
        /// Halcon的模板图片
        /// </summary>
        public HImage HTempImage { get; set; } = null;

        [Reference(true)]
        public int Count { get; set; } = 0;

        [Reference(false)]
        [ReferencePoint]
        public PointF[] Result { get; set; } = null;

        [Reference(false)]
        [ReferenceAngle]
        public double[] Angle { get; set; } = null;

        [Reference(false)]
        public double[] Score { get; set; } = null;

        public override ToolsKitNameEnum ToolKitName => ToolsKitNameEnum.Location;

        public override string ToolName => "轮廓匹配";

        public override void Execute()
        {
            if(TempImage == null)
            {
                SetNG("模板图片不存在！");
                return;
            }
            VisionLibrary.ContourMatching matching = new VisionLibrary.ContourMatching();
            HImage hImage = ImageWindowIndexDic[Convert.ToInt32(SelectedOperatorBlock.ImageWindowIndex)].Control._HImage;
            matching.BaseContourFindShapeModel(hImage, _HShapeModel, StartAngle, AngleExtent, MinScore, NumMatches, MaxOverLap, NumLeves, HighThreshold,LowThreshold,MinContour,MaxContour, out List<ContourMatchingResult> contourMatchingResultList, out List<float[]> X, out List<float[]> Y);
            if(contourMatchingResultList.Count == 0)
            {
                SetNG("MatchNum：0");
                return;
            }
            Count = contourMatchingResultList.Count;
            ImageWindowIndexDic[Convert.ToInt32(SelectedOperatorBlock.ImageWindowIndex)].Control.DispXLDCont(X, Y);
            Score = contourMatchingResultList.Select(c => c.分数).ToArray();
            Angle = contourMatchingResultList.Select(c => c.旋转角度).ToArray();
            List<PointF> pointFList = new List<PointF>();
            foreach (ContourMatchingResult item in contourMatchingResultList)
            {
                pointFList.Add(new PointF(item.中心X, item.中心Y));
            }
            Result = pointFList.ToArray();
            SetOK("MatchNum:" + Count);
        }

        public override bool RunAgoCheck()
        {
            ErrorList.Clear();
            return ErrorList.Count == 0;
        }
    }
}
