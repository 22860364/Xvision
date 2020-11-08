using DispenseAPP.AttributeClass;
using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP.Tools_ScreenCheck.BadParameterSetting
{
    [Serializable]
    [ReferenceImage]
    [UnableManualExecute]
    public class BadParameterSettingToolEntity : IToolable
    {
        public override ToolsKitNameEnum ToolKitName => ToolsKitNameEnum.ScreenCheck;

        public override string ToolName => "不良点参数设置";
        public HRegion Hregion { get; set; }
        public HImage Himage { get; set; }
        public int MeanMaskWidth { get; set; }
        public int MeanMaskHeight { get; set; }
        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }
        public double MinGray { get; set; }
        public double MaxGray { get; set; }
        public double SelectShapeMin { get; set; }
        public double SelectShapeMax { get; set; }
        public double Phi { get; set; }
        public string Interpolation { get; set; } = "constant";
        public double Sigmal { get; set; } = 3;
        public int Sigma2 { get; set; } = 5;
        public string Norm { get; set; }
        public string Mode { get; set; }
        public double Mult { get; set; }
        public double Add { get; set; }
        public string Direction { get; set; }
        public string RftGenericNorm { get; set; }
        public string ResultType { get; set; }
     
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
