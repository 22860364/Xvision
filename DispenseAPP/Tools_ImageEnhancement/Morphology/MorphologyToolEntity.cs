using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP.Tools_ImageEnhancement.Morphology
{
  public  class MorphologyToolEntity : IToolable
    {
        public string ParameterName { get; set; } = null;
        public int Row { get; set; } = 0;
        public int Column  { get; set; } = 1;
        public int Iterations { get; set; } = 1;
        public override ToolsKitNameEnum ToolKitName => ToolsKitNameEnum.Enhancement;

        public override string ToolName => "形态学";

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
