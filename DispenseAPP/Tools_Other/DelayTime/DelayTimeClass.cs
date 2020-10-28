using System.Threading;
using System;

namespace DispenseAPP.Tools_Other.DelayTime
{
    [Serializable]
    [UnAbleManualExecute]
    public class DelayTimeClass : ITools
    {
        public DelayTimeClass()
        {
            ToolsName = ToolsNameEnum.DelayTime;
            ToolsKitName = ToolsKitNameEnum.Other;
        }

        public override void Execute(UC_Image imageWindow)
        {
                Thread.Sleep(Time);
                ExecuteState = CommonClass.ExecuteStateEnum.OK;
                ExecuteResult = "Delay:" + Time.ToString() + "ms";
                StepState = true;
        }

        public int Time { get; set; }
    }
}
