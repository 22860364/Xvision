using DispenseAPP.AboutData;
using System;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    [Serializable]
    public class AcqSetClass : ITools
    {
        public AcqSetClass()
        {
            ToolsKitName = ToolsKitNameEnum.ImageIO;
            ToolsName = ToolsNameEnum.AcqSet;
        }
        public override void Execute(UC_Image imageWindow) //两个问题：1.当某个参数设置失败后，要怎么处理 2.当某个参数设置失败后，其余参数要不要继续设置
        {
            if(SelectedCamera == "")//根据就没有选择相机 那就不需要进行参数设置 
            {
                SetOKResult();
            }
            else//选择了相机 
            {
                CameraDataClass cameraDataClass = CameraDataDic.Find(c => c.CustomName == SelectedCamera);
                if (cameraDataClass != null)
                {
                    ICameraable cameraable = CameraIDObjectDict[cameraDataClass.CameraID];
                    if (cameraable != null)
                    {
                        if (EnableImageFormat == true)
                        {
                            if (!cameraable.SetImageFormat(ImageFormat))
                            {
                                SetNGResult();
                            }
                        }
                        if (EnableExposureTime == true)
                        {
                            if (!cameraable.SetExposureTime(ExposureTime))
                            {
                                SetNGResult();
                            }
                        }
                        if (EnableGain == true)
                        {
                            if (!cameraable.SetGain(Gain))
                            {
                                SetNGResult();
                            }
                        }
                        if (EnableImageWidth == true)
                        {
                            if (!cameraable.SetImageWidth(ImageWidth))
                            {
                                SetNGResult();
                            }
                        }
                        if (EnableImageHeight == true)
                        {
                            if (!cameraable.SetImageHeight(ImageHeight))
                            {
                                SetNGResult();
                            }
                        }
                        if (EnableTriggerMode == true)
                        {
                            if (!cameraable.SetTriggerMode(TriggerMode))
                            {
                                SetNGResult();
                            }
                        }
                        if (EnableTriggerDelayTime == true)
                        {
                            if (!cameraable.SetTriggerDelay(TriggerDelayTime))
                            {
                                SetNGResult();
                            }
                        }
                        if (EnableTimeOut == true)
                        {
                            if (!cameraable.SetTimeOut(TimeOut))
                            {
                                SetNGResult();
                            }
                        }
                        
                    }
                    else
                    {
                        ExecuteState = ExecuteStateEnum.NG;
                        ExecuteResult = "None";
                        StepState = false;
                    }
                }
                else
                {
                    ExecuteState = ExecuteStateEnum.NG;
                    ExecuteResult = "None";
                    StepState = false;
                }
            }         
        }

        private void SetNGResult()
        {
            ExecuteState = ExecuteStateEnum.NG;
            ExecuteResult = SelectedCamera;
            StepState = false;
            return;
        }

        private void SetOKResult()
        {
            ExecuteState = ExecuteStateEnum.OK;
            ExecuteResult = SelectedCamera;
            StepState = true;
        }

        #region 相机
        public string SelectedCamera { get; set; } = "";
        #endregion

        #region 基本
        public bool EnableImageFormat { get; set; } = false;

        public string ImageFormat { get; set; } = "Mono8";

        public bool EnableExposureTime { get; set; } = false;

        public double ExposureTime { get; set; } = 0;

        public bool EnableGain { get; set; } = false;

        public double Gain { get; set; } = 0;

        public bool EnableImageWidth { get; set; } = false;

        public long ImageWidth { get; set; } = 0;

        public bool EnableImageHeight { get; set; } = false;

        public long ImageHeight { get; set; } = 0;

        public bool EnableShiftX { get; set; } = false;

        public int ShiftX { get; set; } = 0;

        public bool EnableShiftY { get; set; } = false;

        public int ShiftY { get; set; } = 0;
        #endregion

        #region 高级设置
        public bool EnableTriggerMode { get; set; } = false;

        public string TriggerMode { get; set; } = "Software trigger";

        public bool EnableTriggerDelayTime { get; set; } = false;

        public double TriggerDelayTime { get; set; }

        public bool EnableTimeOut { get; set; } = false;

        public double TimeOut { get; set; }
        #endregion

        #region 光源
        public bool EnableLightMode { get; set; }

        public string LightMode { get; set; }

        public bool EnableTriggerPolarity { get; set; }

        public string TriggerPolarity { get; set; }

        public string CommandType { get; set; }

        public string Channel1 { get; set; }

        public int Channel1Value { get; set; }

        public string Channel2 { get; set; }

        public int Channel2Value { get; set; }

        public string Channel3 { get; set; }

        public int Channel3Value { get; set; }

        public string Channel4 { get; set; }

        public int Channel4Value { get; set; }

        public string Channel5 { get; set; }

        public int Channel5Value { get; set; }

        public string Channel6 { get; set; }

        public int Channel6Value { get; set; }

        public string Channel7 { get; set; }

        public int Channel7Value { get; set; }

        public string Channel8 { get; set; }

        public int Channel8Value { get; set; }

        public bool Update { get; set; }

        public int DelayTime { get; set; }
        #endregion
    }
}

