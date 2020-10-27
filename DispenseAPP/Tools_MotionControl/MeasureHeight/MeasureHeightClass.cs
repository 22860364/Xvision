using DispenseAPP.Tools_MotionControl.MeasureHeight.Commun;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_MotionControl.MeasureHeight
{
    public class MeasureHeightClass : ITools
    {
        public ushort DelayTime { get; set; } = 0;//测高延时  防止机械抖动造成的误差

        public float AllowDeviation { get; set; } = 0;//允许误差 当任意一个点与原始数据的偏差大于该值 则报警

        public ushort DeformationRadius { get; set; } = 0;//变形范围半径

        public string CalibMode { get; set; } = "平面校正";

        public string SelectCard { get; set; } = "";//选择卡

        public string[] SelecectAxisArray { get; set; } = null;//选择轴

        public string CommunMode { get; set; } = "AD通道";//通信方式

        public ushort InitialDigits { get; set; } = 0;//读取起始位

        public ushort ExtractCharNum { get; set; } = 1;//提取字符数

        public ushort DecimalPlaces { get; set; } = 1;//小数点位数

        public ushort SamplingPeriod { get; set; } = 10;//采样周期

        public string ReadMode { get; set; } = "平均值";

        public GetHeightValueClass getHeightValueClass;

        public override void Execute(UC_Image imageWindow)
        {
            if(MotionCardDict.ContainsKey(SelectCard))//控制卡连接成功 卡中包含所选择的轴 控制卡集合中包含卡
            {
                if(MotionCardDict[SelectCard].CardConnectState)
                {
                    if(CardContainsAxis(SelectCard, SelecectAxisArray))
                    {
                       
                    }
                    else
                    {
                        SetResultNG("控制卡不包含选择轴");
                        return;
                    }
                }
                else
                {
                    SetResultNG("控制卡连接失败");
                    return;
                }
            }
            else
            {
                SetResultNG("控制卡对象不存在");
                return;
            }
        }

        private void SetResultNG(string error)
        {
            ExecuteState = ExecuteStateEnum.NG;
            StepState = false;
            ExecuteResult = error;
        }

        public class MeasureHeightParamClass//测高参数类 设置界面的参数
        {

        }
    }
}
