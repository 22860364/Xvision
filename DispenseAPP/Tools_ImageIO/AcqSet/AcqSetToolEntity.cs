using System;
using CameraLibrary;

namespace DispenseAPP
{
    [Serializable]
    [UnableManualExecute]
    public class AcqSetToolEntity : IToolable
    {
        ICamerable Camerable { get; set;} = null;

        /// <summary>
        /// 用于序列化
        /// </summary>
        public AcqSetToolEntity()
        {
        }

        public AcqSetToolEntity(string cameraName)
        {
            SelectedCameraName = cameraName;
        }

        public override void Execute()
        {
            if (Camerable is null) return;
           
            if ( EnableExposureTime == true && !Camerable.SetExposureTime(ExposureTime))
            {
                SetNG("设置曝光失败！");
                return;
            }
            SetOK(SelectedCameraName);
        }

        public string SelectedCameraName { get; set; }

        public bool EnableExposureTime { get; set; } = false;

        public double ExposureTime { get; set; } = 0;

        public bool EnableTriggerDelayTime { get; set; } = false;

        public double TriggerDelayTime { get; set; }

        public override ToolsKitNameEnum ToolKitName => ToolsKitNameEnum.ImageIO;

        public override string ToolName => "采集设置";

        public override object Clone()
        {
            return MemberwiseClone();
        }

        public override bool RunAgoCheck()
        {
            ErrorList.Clear();
            return ErrorList.Count == 0;
        }
    }
}

