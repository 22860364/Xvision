using System;
using System.Drawing;

namespace DispenseAPP.Tools_Location.ProgramDispensePath.DisplayImagePath
{
    [Serializable]
    public class RoadMapParamClass//路径参数设置
    {
        public enum DrawQualityEnum
        {
            普通,
            高,
        }

        public Color BackColor { get; set; } = Color.Black;//背景色

        public Color GridColor { get; set; } = Color.DimGray;

        public Color NoSelectPointColor { get; set; } = Color.Red;//未选中点颜色

        public Color SelectPointColor { get; set; } = Color.LimeGreen;//选中点颜色

        public ushort NoSelectPointSize { get; set; } = 4;//未选中坐标点尺寸

        public ushort SelectPointSize { get; set; } = 4;//选中坐标点尺寸

        public Color NoSelectRoadColor { get; set; } = Color.White;//未选中路线颜色

        public Color SelectRoadColor { get; set; } = Color.DodgerBlue;//选中路线颜色

        public ushort NoSelectRoadWidth { get; set; } = 1;//未选中路线宽度

        public ushort SelectRoadWidth { get; set; } = 1;//选中路线宽度

        public Color CoordinateLineColor { get; set; } = Color.Yellow;//坐标轴线颜色

        public Color CursorColor { get; set; } = Color.Blue;//十字光标颜色

        public Color ArrayPathColor { get; set; } = Color.Magenta;//阵列路径颜色

        public Color OtherColor { get; set; } = Color.Yellow;

        public bool UseDottedConnectStartPointWithLastPoint { get; set; } = false;//用虚线连接起点与上一个点

        public bool UseDottedConnectSinglePointWithLastPoint { get; set; } = false;//用虚线连接单点与上一个点

        public DrawQualityEnum DrawQuality { get; set; } = DrawQualityEnum.普通;//绘图质量

        public float ZoomSpeed { get; set; } = 1f;//缩放速度

        public ushort PictureCenterShiftX { get; set; } = 1;//图片中心补偿X

        public ushort PictureCenterShiftY { get; set;}//图片中心补偿Y

        public float PictureWidthZoomShiftFactor { get; set; } = 1f;//图片宽度比例补偿系数
        public float PictureHeightZoomShiftFactor { get; set; } = 1f;//图片宽度比例补偿系数

        public float NeedleInnerDiameter { get; set; } = 1f;//针头内径用于矩形填充

        public bool ShowGrid { get; set; } = true;//显示网格

        public bool ShowPoint { get; set; } = true;//显示节点

        public bool ShowCoordinate { get; set; } = true;//显示坐标轴

        public bool AutoSize { get; set; } = true;//图像自适应大小
    }
}
