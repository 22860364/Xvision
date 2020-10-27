using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using MvCamCtrl.NET;

namespace CameraLibrary
{
    public class HIKVISION : ICamerable
    {
        #region 私有变量
        private MyCamera hikvisionCamera = null;
        private int index;
        private MyCamera.MV_CC_DEVICE_INFO deviceInfo;
        static MyCamera.MV_CC_DEVICE_INFO_LIST stDevList = new MyCamera.MV_CC_DEVICE_INFO_LIST();
        #endregion

        public override bool CheckCameraAvailable()
        {
            return MyCamera.MV_CC_IsDeviceAccessible_NET(ref deviceInfo, MyCamera.MV_ACCESS_Exclusive);
        }

        public override void DisposeCamera()
        {
            hikvisionCamera.MV_CC_CloseDevice_NET() ;//关闭设备
            hikvisionCamera.MV_CC_DestroyDevice_NET();//销毁句柄 释放资源
        }

        public override List<string> GetCameraList()
        {
            List<string> cameraList = new List<string>();
            //uint nTLayerType = MyCamera.MV_GIGE_DEVICE | MyCamera.MV_USB_DEVICE;
            //if (MyCamera.MV_CC_EnumDevices_NET(nTLayerType, ref stDevList) == MyCamera.MV_OK)
            //{
            //    for (int i = 0; i < stDevList.nDeviceNum; i++)
            //    {
            //        MyCamera.MV_CC_DEVICE_INFO deviceInfo = (MyCamera.MV_CC_DEVICE_INFO)Marshal.PtrToStructure(stDevList.pDeviceInfo[i], typeof(MyCamera.MV_CC_DEVICE_INFO));
            //        if (deviceInfo.nTLayerType == MyCamera.MV_GIGE_DEVICE)
            //        {
            //            MyCamera.MV_GIGE_DEVICE_INFO gigeInfo = (MyCamera.MV_GIGE_DEVICE_INFO)MyCamera.ByteToStruct(deviceInfo.SpecialInfo.stGigEInfo, typeof(MyCamera.MV_GIGE_DEVICE_INFO));
            //            cameraList.Add(gigeInfo.chManufacturerName + ":" + gigeInfo.chSerialNumber + "_" + i.ToString());//制造商名称
            //        }
            //        else if (deviceInfo.nTLayerType == MyCamera.MV_USB_DEVICE)
            //        {
            //            MyCamera.MV_USB3_DEVICE_INFO usbInfo = (MyCamera.MV_USB3_DEVICE_INFO)MyCamera.ByteToStruct(deviceInfo.SpecialInfo.stUsb3VInfo, typeof(MyCamera.MV_USB3_DEVICE_INFO));
            //            cameraList.Add(usbInfo.chVendorName + ":" + usbInfo.chSerialNumber + "_" + i.ToString());
            //        }
            //    }
            //}
            return cameraList;
        }

        public override bool InitialCamera(string _serialNumber)
        {
            index = Convert.ToInt32(_serialNumber.Split('_')[1]);
            deviceInfo = (MyCamera.MV_CC_DEVICE_INFO)Marshal.PtrToStructure(stDevList.pDeviceInfo[index], typeof(MyCamera.MV_CC_DEVICE_INFO));
            hikvisionCamera = new MyCamera();
            if (hikvisionCamera == null) { return false; }
            if (hikvisionCamera.MV_CC_CreateDevice_NET(ref deviceInfo) != MyCamera.MV_OK)
            {
                return false;
            }
            if (hikvisionCamera.MV_CC_OpenDevice_NET() != MyCamera.MV_OK)
            {
                hikvisionCamera.MV_CC_DestroyDevice_NET();
                return false;
            }
            MyCamera.cbOutputExdelegate ImageCallback = new MyCamera.cbOutputExdelegate(StreamGrabber_ImageGrabber);
            if (hikvisionCamera.MV_CC_RegisterImageCallBackEx_NET(ImageCallback, IntPtr.Zero) != MyCamera.MV_OK)
            {
                return false;
            }
            if (deviceInfo.nTLayerType == MyCamera.MV_GIGE_DEVICE)//探测网络最佳包大小（只对Gige相机有效）
            {
                int nPacketSize = hikvisionCamera.MV_CC_GetOptimalPacketSize_NET();
                if (nPacketSize > 0)
                {
                    if (hikvisionCamera.MV_CC_SetIntValue_NET("GevSCPSPacketSize", (uint)nPacketSize) != MyCamera.MV_OK)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private void StreamGrabber_ImageGrabber(IntPtr pData, ref MyCamera.MV_FRAME_OUT_INFO_EX pFrameInfo, IntPtr pUser)//待完善 直接回调到客户端Bitmap类型图片
        {
            if (pFrameInfo.enPixelType == MyCamera.MvGvspPixelType.PixelType_Gvsp_Mono8 || pFrameInfo.enPixelType == MyCamera.MvGvspPixelType.PixelType_Gvsp_BGR8_Packed)
            {

            }
        }

        public override double GetExposureTime()
        {
            MyCamera.MVCC_FLOATVALUE floatParam = new MyCamera.MVCC_FLOATVALUE();
            if (hikvisionCamera.MV_CC_GetFloatValue_NET("ExposureTime", ref floatParam) == MyCamera.MV_OK)
            {
                return floatParam.fCurValue;             
            }
            return 0d;
        }

        public override double GetGain()
        {
            MyCamera.MVCC_FLOATVALUE floatParam = new MyCamera.MVCC_FLOATVALUE();
            if (hikvisionCamera.MV_CC_GetFloatValue_NET("Gain", ref floatParam) != MyCamera.MV_OK)
            {
                return 0d;
            }
            else
            {
                return floatParam.fCurValue;
            }
        }

        public override string GetImageFormat()
        {
            MyCamera.MVCC_ENUMVALUE enumParam = new MyCamera.MVCC_ENUMVALUE();
            if (hikvisionCamera.MV_CC_GetEnumValue_NET("PixelFormat", ref enumParam) == MyCamera.MV_OK)
            {
                return enumParam.nCurValue.ToString();
            }
            return null;
        }

        public override long GetImageHeight()
        {
            MyCamera.MVCC_INTVALUE_EX intParam = new MyCamera.MVCC_INTVALUE_EX();
            if (hikvisionCamera.MV_CC_GetIntValueEx_NET("Height", ref intParam) == MyCamera.MV_OK)
            {
                return intParam.nCurValue;
            }
            return 0;
        }

        public override long GetImageMaxHeight()
        {
            MyCamera.MVCC_INTVALUE_EX intParam = new MyCamera.MVCC_INTVALUE_EX();
            if (hikvisionCamera.MV_CC_GetIntValueEx_NET("HeightMax", ref intParam) == MyCamera.MV_OK)
            {
                return intParam.nCurValue;
            }
            return 0;
        }

        public override long GetImageMaxWidth()
        {
            MyCamera.MVCC_INTVALUE_EX intParam = new MyCamera.MVCC_INTVALUE_EX();
            if (hikvisionCamera.MV_CC_GetIntValueEx_NET("WidthMax", ref intParam) == MyCamera.MV_OK)
            {
                return intParam.nCurValue;
            }
            return 0;
        }

        public override long GetImageMinHeight()
        {
            return 0;
        }

        public override long GetImageMinWidth()
        {
            return 0;
        }

        public override long GetImageWidth()
        {
            MyCamera.MVCC_INTVALUE_EX intParam = new MyCamera.MVCC_INTVALUE_EX();
            if (hikvisionCamera.MV_CC_GetIntValueEx_NET("Width", ref intParam) == MyCamera.MV_OK)
            {
                return intParam.nCurValue;
            }
            return 0;
        }

        public override double GetMaxExposureTime()
        {
            MyCamera.MVCC_FLOATVALUE floatParam = new MyCamera.MVCC_FLOATVALUE();
            if (hikvisionCamera.MV_CC_GetFloatValue_NET("AutoExposureTimeupperLimit", ref floatParam) != MyCamera.MV_OK)
            {
                return 0d;
            }
            else
            {
                return floatParam.fCurValue;
            }
        }

        public override double GetMaxGain()
        {
            MyCamera.MVCC_FLOATVALUE floatParam = new MyCamera.MVCC_FLOATVALUE();
            if (hikvisionCamera.MV_CC_GetFloatValue_NET("AutoGainupperLimit", ref floatParam) != MyCamera.MV_OK)
            {
                return 0d;
            }
            else
            {
                return floatParam.fCurValue;
            }
        }

        public override double GetMinExposureTime()
        {
            MyCamera.MVCC_FLOATVALUE floatParam = new MyCamera.MVCC_FLOATVALUE();
            if (hikvisionCamera.MV_CC_GetFloatValue_NET("AutoExposureTimeLowerLimit", ref floatParam) != MyCamera.MV_OK)
            {
                return 0d;
            }
            else
            {
                return floatParam.fCurValue;
            }
        }

        public override double GetMinGain()
        {
            MyCamera.MVCC_FLOATVALUE floatParam = new MyCamera.MVCC_FLOATVALUE();
            if (hikvisionCamera.MV_CC_GetFloatValue_NET("AutoGainLowerLimit", ref floatParam) != MyCamera.MV_OK)
            {
                return floatParam.fCurValue;
            }
            return 0d;
        }

        public override double GetTimeout()
        {
            MyCamera.MVCC_INTVALUE_EX intParam = new MyCamera.MVCC_INTVALUE_EX();
            if(hikvisionCamera.MV_CC_GetIntValueEx_NET("FrameTimeoutTime",ref intParam) == MyCamera.MV_OK)
            {
                return intParam.nCurValue;
            }
            return 0d;
        }

        public override double GetTimeoutMax()
        {
            MyCamera.MVCC_INTVALUE_EX intParam = new MyCamera.MVCC_INTVALUE_EX();
            if (hikvisionCamera.MV_CC_GetIntValueEx_NET("FrameTimeoutTime", ref intParam) == MyCamera.MV_OK)
            {
                return intParam.nMax;
            }
            return 0d;
        }

        public override double GetTimeoutMin()
        {
            MyCamera.MVCC_INTVALUE_EX intParam = new MyCamera.MVCC_INTVALUE_EX();
            if (hikvisionCamera.MV_CC_GetIntValueEx_NET("FrameTimeoutTime", ref intParam) == MyCamera.MV_OK)
            {
                return intParam.nMin;
            }
            return 0d;
        }

        public override double GetTriggerDelayTime()
        {
            MyCamera.MVCC_FLOATVALUE floatParam = new MyCamera.MVCC_FLOATVALUE();
            if (hikvisionCamera.MV_CC_GetFloatValue_NET("TriggerDelay", ref floatParam) == MyCamera.MV_OK)
            {
                return floatParam.fCurValue;
            }
            return 0d;
        }

        public override double GetTriggerDelayTimeMax()//需要连接相机验证
        {
            MyCamera.MVCC_FLOATVALUE floatParam = new MyCamera.MVCC_FLOATVALUE();
            if (hikvisionCamera.MV_CC_GetFloatValue_NET("TriggerDelay", ref floatParam) == MyCamera.MV_OK)
            {
                return floatParam.fMax;
            }
            return 0d;
        }

        public override double GetTriggerDelayTimeMin()
        {
            MyCamera.MVCC_FLOATVALUE floatParam = new MyCamera.MVCC_FLOATVALUE();
            if (hikvisionCamera.MV_CC_GetFloatValue_NET("TriggerDelay", ref floatParam) == MyCamera.MV_OK)
            {
                return floatParam.fMin;
            }
            return 0d;
        }

        public override bool SetExposureTime(double value)
        {
            if (hikvisionCamera.MV_CC_SetEnumValue_NET("ExposureAuto", 0) == MyCamera.MV_OK)
            {
                if (hikvisionCamera.MV_CC_SetFloatValue_NET("ExposureTime", (float)value) == MyCamera.MV_OK)
                {
                    return true;
                }
            }
            return false;
        }

        public override bool SetGain(double value)
        {
            if (hikvisionCamera.MV_CC_SetEnumValue_NET("GainAuto", 0) == MyCamera.MV_OK)
            {
                if (hikvisionCamera.MV_CC_SetFloatValue_NET("Gain", (float)value) == MyCamera.MV_OK)
                {
                    return true;
                }
            }
            return false;
        }

        public override bool SetImageFormat(string value)
        {
            switch (value)
            {
                case "Mono8":
                    return hikvisionCamera.MV_CC_SetEnumValue_NET("PixelFormat", (uint)MyCamera.MvGvspPixelType.PixelType_Gvsp_Mono8) == MyCamera.MV_OK;
                case "RGB8Packed":
                    return hikvisionCamera.MV_CC_SetEnumValue_NET("PixelFormat", (uint)MyCamera.MvGvspPixelType.PixelType_Gvsp_RGB8_Packed) == MyCamera.MV_OK;
                default:
                    return false;
            }
        }

        public override bool SetImageHeight(long value)
        {
            return hikvisionCamera.MV_CC_SetIntValueEx_NET("Height", value) == MyCamera.MV_OK;
        }

        public override bool SetImageOffsetX(long value)
        {
            return hikvisionCamera.MV_CC_SetIntValueEx_NET("OffsetX", value) == MyCamera.MV_OK;
        }

        public override bool SetImageOffsetY(long value)
        {
            return hikvisionCamera.MV_CC_SetIntValueEx_NET("OffsetY", value) == MyCamera.MV_OK;
        }

        public override bool SetImageWidth(long value)
        {
            return hikvisionCamera.MV_CC_SetIntValueEx_NET("Width", value) == MyCamera.MV_OK;
        }

        public override bool SetTimeOut(double value)
        {
            return hikvisionCamera.MV_CC_SetIntValueEx_NET("FrameTimeoutTime", (long)value) == MyCamera.MV_OK;
        }

        public  override bool SetTriggerDelay(double value)
        {
            return hikvisionCamera.MV_CC_SetTriggerDelay_NET((float)value) == MyCamera.MV_OK;
        }

        public override bool SetTriggerMode(string triggerMode)//这里需要注意 有TriggerMode TriggerSource TriggerSoftsware 三个参数  连续模式和采集模式是不同的 有了相机再测试
        {
            return true;
        }

        public override bool SingleFrameAcquisiton()
        {
            return Acquisition(MyCamera.MV_CAM_ACQUISITION_MODE.MV_ACQ_MODE_SINGLE);
        }

        private bool Acquisition(MyCamera.MV_CAM_ACQUISITION_MODE acqMode)
        {
            MyCamera.MVCC_ENUMVALUE enumParam = new MyCamera.MVCC_ENUMVALUE();
            if (hikvisionCamera.MV_CC_GetAcquisitionMode_NET(ref enumParam) != MyCamera.MV_OK)
            {
                return false;
            }
            if (enumParam.nCurValue != (uint)acqMode)
            {
                if (hikvisionCamera.MV_CC_SetAcquisitionMode_NET((uint)acqMode) != MyCamera.MV_OK)
                {
                    return false;
                }
            }
            if (hikvisionCamera.MV_CC_StartGrabbing_NET() != MyCamera.MV_OK)
            {
                return false;
            }
            return true;
        }

        public override bool ContinuousAcquisition()
        {
            return Acquisition(MyCamera.MV_CAM_ACQUISITION_MODE.MV_ACQ_MODE_CONTINUOUS);
        }

        public override void StopAcquisition()
        {
            if (hikvisionCamera != null)
            {
                hikvisionCamera.MV_CC_StopGrabbing_NET();                          
            }
        }

        public override long GetMinImageOffsetY()
        {
            MyCamera.MVCC_INTVALUE mVCC_INTVALUE = new MyCamera.MVCC_INTVALUE();
            if (hikvisionCamera.MV_CC_GetAOIoffsetY_NET(ref mVCC_INTVALUE) == MyCamera.MV_OK)
            {
                return mVCC_INTVALUE.nMin;
            }
            return 0;
        }

        public override long GetMinImageOffsetX()
        {
            MyCamera.MVCC_INTVALUE mVCC_INTVALUE = new MyCamera.MVCC_INTVALUE();
            if (hikvisionCamera.MV_CC_GetAOIoffsetX_NET(ref mVCC_INTVALUE) == MyCamera.MV_OK)
            {
                return mVCC_INTVALUE.nMin;
            }
            return 0;
        }

        public override long GetMaxImageOffsetY()
        {
            MyCamera.MVCC_INTVALUE mVCC_INTVALUE = new MyCamera.MVCC_INTVALUE();
            if (hikvisionCamera.MV_CC_GetAOIoffsetY_NET(ref mVCC_INTVALUE) == MyCamera.MV_OK)
            {
                return mVCC_INTVALUE.nMax;
            }
            return 0;
        }

        public override long GetMaxImageOffsetX()
        {
            MyCamera.MVCC_INTVALUE mVCC_INTVALUE = new MyCamera.MVCC_INTVALUE();
            if (hikvisionCamera.MV_CC_GetAOIoffsetX_NET(ref mVCC_INTVALUE) == MyCamera.MV_OK)
            {
                return mVCC_INTVALUE.nMax;
            }
            return 0;
        }
    }
}
