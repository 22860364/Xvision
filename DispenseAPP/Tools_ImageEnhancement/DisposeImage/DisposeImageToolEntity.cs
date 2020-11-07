using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP.Tools_ImageEnhancement.DisposeImage
{
    /// <summary>
    /// 图像操作
    /// </summary>
  public  class DisposeImageToolEntity : IToolable
    {
        public string PperationType { get; set; }
        public int Constant { get; set; } = 1;
        public override ToolsKitNameEnum ToolKitName => ToolsKitNameEnum.Enhancement;

        public override string ToolName => "操作图像";

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
