using System.Drawing;
using System;
namespace DispenseAPP.Tools_Location.ProgramDispensePath.DisplayImagePath
{
    [Serializable]
    public class CrossParamClass//中心线参数设置
    {
        public bool ShowCross { get; set; } = false;//显示十字线
        public Color CrossColor { get; set; } = Color.Red;//十字线颜色
        public ushort LineScaleNumber { get; set; } = 0;//直线刻度数量
        public ushort CircleScaleNumber { get; set; } = 0;//圆形刻度数量
        public float ScaleGap { get; set; } = 1.5f;//刻度间距
        public float ScaleLineWidth { get; set; } = 1;//刻度线宽
    }
}
