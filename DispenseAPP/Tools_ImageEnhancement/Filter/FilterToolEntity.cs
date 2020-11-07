using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP.Tools_ImageEnhancement.Filter
{
  public  class FilterToolEntity : IToolable
    {
        /// <summary>
        /// 滤波系数
        /// </summary>
        public int Coefficient { get; set; } = 3;
        /// <summary>
        /// 参数名称
        /// </summary>
        public string ParameterName { get; set; } = null;
        public override ToolsKitNameEnum ToolKitName => ToolsKitNameEnum.Enhancement;

        public override string ToolName => "滤波";

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
