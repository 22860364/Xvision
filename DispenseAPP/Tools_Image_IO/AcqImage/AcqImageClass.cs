using System;
using static DispenseAPP.CommonClass;
using HalconDotNet;
using DispenseAPP.AttributeClass;
using DispenseAPP.AboutData;
using System.Windows.Forms;

namespace DispenseAPP
{
    [Serializable]
    [ReferenceImage]
    public class AcqImageClass : ITools
    {
        public AcqImageClass()
        {
            ToolsKitName = ToolsKitNameEnum.ImageIO;
            ToolsName = ToolsNameEnum.AcqImage;
        }

        private void AcqImageClass_ImageCallBackEvent(HImage image)
        {
            if (EnableImageCache == true)//缓存队列：将相机采集到的图像缓存到该队列 可以被"图像缓存"功能使用
            {
                int index = Convert.ToInt32(ImageCache.Substring(4));
                if (ImageQueue[index].Count > 100)
                {
                    ImageQueue[index].Dequeue();
                }
                ImageQueue[index].Enqueue(image.Clone());
            }
            if (EnableImageBackup == true)//输出图像备份 将原始图像备份并添加到算子输出 可以被"图像缓存"功能使用
            {
                Image = image.Clone();
            }
            uc_Image.DispImage(image);
            camera.ImageCallBackEvent -= AcqImageClass_ImageCallBackEvent;//取消注册事件
            _controlBool = false;
        }

        public string SelectedCamera { get; set; } = "";//选择的相机
        public bool EnableImageBackup { get; set; } = true;//图像备份
        public bool EnableImageCache { get; set; } = false;//启用图像缓存
        public string ImageCache { get; set; } = "缓存队列1";

        [NonSerialized]
        private UC_Image uc_Image;

        [ReferenceImage]
        public static HImage Image { get; set; }

        private static ICameraable camera;

        private bool _controlBool = false;

        public override void Execute(UC_Image imageWindow)
        {
            uc_Image = imageWindow;
            if (SelectedCamera == "")
            {
                SetOkResult();
            }
            else
            {
                CameraDataClass cameraDataClass = CameraDataDic.Find(c => c.CustomName == SelectedCamera);
                if (cameraDataClass != null)
                {
                    camera = CameraIDObjectDict[cameraDataClass.CameraID];
                    if (camera != null)
                    {
                        camera.ImageCallBackEvent += AcqImageClass_ImageCallBackEvent;//注册事件
                        _controlBool = true;
                        camera.SingleFrameAcquisiton();
                        while (true)
                        {                         
                            if (_controlBool == false)
                            {
                                break;
                            }
                            Application.DoEvents();
                        }                     
                        SetOkResult();
                    }
                    else
                    {
                        SetNGResult();
                    }
                }
                else//未找到添加相机时的那个相机
                {
                    SetNGResult();
                }
            }
        }

        private void SetNGResult()
        {
            ExecuteState = ExecuteStateEnum.NG;
            ExecuteResult = "None";
            StepState = false;
        }

        private void SetOkResult()
        {
            ExecuteState = ExecuteStateEnum.OK;
            ExecuteResult = SelectedCamera;
            StepState = true;
        }
    }
}
