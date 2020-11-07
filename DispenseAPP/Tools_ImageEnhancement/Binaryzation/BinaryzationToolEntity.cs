using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP.Tools_ImageEnhancement.Binaryzation
{
    /// <summary>
    /// 二值化
    /// </summary>
   public class BinaryzationToolEntity : IToolable
    {
        public string Roi { get; set; }
        public int HighThreshold { get; set; } = 128;
        public int LowThreshold { get; set; } = 0;
        public override ToolsKitNameEnum ToolKitName => ToolsKitNameEnum.Enhancement;

        public override string ToolName => "二值化";

        public override void Execute()
        {
            throw new NotImplementedException();
        }

        public override bool RunAgoCheck()
        {
            throw new NotImplementedException();
        }
    }
}
