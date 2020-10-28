using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP.Tools_Other.Script
{
    [Serializable]
    public class ScriptClass : ITools
    {

        public ScriptClass()
        {
            ToolsName = ToolsNameEnum.Script;
            ToolsKitName = ToolsKitNameEnum.Other;
        }

        public override void Execute(UC_Image imageWindow)
        {

        }
    }
}
