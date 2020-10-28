using System.Threading;
using System;

namespace DispenseAPP.Tools_Other.DelayTime
{
    [Serializable]
    [UnableManualExecute]
    public class DelayTimeToolEntity : IToolable
    {
        public DelayTimeToolEntity()
        {
        }

        public override void Execute()
        {
            Thread.Sleep(Time);
            SetOK("执行延时[" + Time.ToString() + "]ms");
        }

        public override bool RunAgoCheck()
        {
            ErrorList.Clear();
            return ErrorList.Count == 0;
        }

        public int Time { get; set; }

        public override ToolsKitNameEnum ToolKitName => ToolsKitNameEnum.Other;

        public override string ToolName => "延时";
    }
}
