using System;

namespace DispenseAPP.Tools_ImageEnhancement.RotateShiftImage
{
    [Serializable]
    public class Tools_RotateShiftImageClass : IToolable
    {
        public int RotateAngle { get; set; } = 0; //旋转角度

        public int Shift_X { get; set; } = 0;//X方向偏移

        public int Shift_Y { get; set; } = 0;//Y方向偏移

        public bool ChangeImageSize { get; set; } = false;//不改变图像尺寸

        public override ToolsKitNameEnum ToolKitName => ToolsKitNameEnum.ImageIO;

        public override string ToolName => "旋转平移图像";

        public override void Execute()
        {
            
        }

        public override bool RunAgoCheck()
        {
            ErrorList.Clear();
            return ErrorList.Count == 0;
        }
    }
}
