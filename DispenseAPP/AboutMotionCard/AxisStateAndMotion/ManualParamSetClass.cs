namespace DispenseAPP.AboutMotionCard.AxisStateAndMotion
{
    public class ManualParamSetClass //运动模式参数类
    {
        public enum MotionModeEnum
        {
            Continue,
            FixedLength,
        }

        public MotionModeEnum MotionMode { get; set; } = MotionModeEnum.Continue;

        public float Length { get; set; } = 1;

        public float Speed { get; set; } = 10;
    }
}
