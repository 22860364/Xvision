using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP.Tools_ImageEnhancement.Pretreatment
{
   public class PretreatmentToolEntity : IToolable
    {
        public override ToolsKitNameEnum ToolKitName => ToolsKitNameEnum.Enhancement;

        public override string ToolName => "预处理";

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
