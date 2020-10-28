using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP.Tools_Measure.GeometricalRelation
{
    public class GeometericalRelationClass : ITools
    {
        public string GeometericalFeature { get; set; } = "点到到距离（2点）"; //几何特征

        public GeometericalRelationClass()
        {
            ToolsName = ToolsNameEnum.GeometericalRelation;
            ToolsKitName = ToolsKitNameEnum.Measure;
        }

        public override void Execute(UC_Image imageWindow)
        {
            throw new NotImplementedException();
        }
    }
}
