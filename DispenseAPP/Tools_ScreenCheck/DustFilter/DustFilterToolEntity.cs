using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP.Tools_ScreenCheck.DustFilter
{
    /// <summary>
    /// 过滤灰尘
    /// </summary>
    public class DustFilterToolEntity : IToolable
    {
        public override ToolsKitNameEnum ToolKitName => ToolsKitNameEnum.ScreenCheck;

        public override string ToolName => "灰尘过滤";

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
