using HalconDotNet;
using System;
using VisionLibrary.ROI;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_Location.CalibROI
{
    [Serializable]
    [ROI]
    public class CreateROIClass : ITools
    {
        public string ROIType { get; set; } = "点";//ROI类型

        public string ReviseROI { get; set; } = "不使用";

        public DrawROIable _OriginalROI { get; set; }

        public bool DispResult { get; set; } = true;//显示结果

        public CreateROIClass()
        {
            ToolsKitName = ToolsKitNameEnum.Location;
            ToolsName = ToolsNameEnum.CreateROI;
        }

        public override void Execute(UC_Image imageWindow)
        {
            DrawROIable newROI = null;
            if (ReviseROI != "不使用") //使用ROI校正
            {
                ITools tools = SelectedNormalBlock.ToolsList.Find(c => c.BlockName == ReviseROI.Split('-')[0]);
                if (tools != null)
                {
                    HSystem.SetSystem("clip_region", "false");
                    if (tools.GetType().GetProperty(ReviseROI.Split('-')[1]).GetValue(tools) is HHomMat2D homMat2D)
                    {
                        newROI = _OriginalROI.AffineTransROI(homMat2D);
                        SetResult(true);
                    }
                    else
                    {
                        SetResult(false);
                    }
                }
                else
                {
                    SetResult(false);
                }
            }
            else
            {
                newROI = _OriginalROI;
                SetResult(true);
            }
            if (DispResult == true)//显示结果
            {
                if (imageWindow != null)
                {
                    imageWindow.Window.SetDraw("margin");//设置为显示轮廓
                    if (newROI != null && newROI.Region != null && newROI.Region.IsInitialized())
                    {
                        imageWindow.DispObject(newROI.Region, true, "blue");
                    }
                }
            }
        }

        private void SetResult(bool state)
        {
            if (state == true)
            {
                ExecuteState = ExecuteStateEnum.OK;
                StepState = true;
                ExecuteResult = "None";
            }
            else
            {
                ExecuteState = ExecuteStateEnum.NG;
                StepState = false;
                ExecuteResult = "Invalid";
            }
        }
    }
}
