using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Basler.Pylon;
using HalconDotNet;

namespace CameraLibrary
{
    public class Basler : ICamerable
    {
        #region 私有变量
        Camera baslerCamera = null;
        PixelDataConverter converter = new PixelDataConverter();
        Bitmap bitmap = null;
        HImage hImage = null;
        #endregion

        #region 公有函数
        public override bool InitialCamera(string _serialNumber)// 初始化相机
        {
            try
            {
                baslerCamera = new Camera(_serialNumber);//根据相机ID创建相机对象  
                if (baslerCamera == null)
                {
                    return false;
                }
                baslerCamera.StreamGrabber.ImageGrabbed += StreamGrabber_ImageGrabbed;//注册采集回调函数
                baslerCamera.ConnectionLost += BaslerCamera_ConnectionLost;
                baslerCamera.Open();//打开相机
                ConnectState = true;
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void BaslerCamera_ConnectionLost(object sender, EventArgs e)//相机连接失败
        {
            ConnectState = false;
            baslerCamera.StreamGrabber.Stop();
            baslerCamera.Close();
            baslerCamera = null;//相机连接失败后 将相机对象置为空
        }

        public override void DisposeCamera()// 释放相机
        {
            if (baslerCamera == null)
            {
                return;
            }
            ConnectState = false;
            baslerCamera.StreamGrabber.Stop();
            baslerCamera.Close();
        }

        public override bool CheckCameraAvailable()// 检查相机是否可用
        {
            if (baslerCamera == null)
            {
                return false;
            }
            if (baslerCamera.IsOpen && baslerCamera.IsConnected)
            {
                return true;
            }
            return false;
        }

        public override List<string> GetCameraList()// 获得相机列表
        {
            List<string> cameraList = new List<string>();
            List<ICameraInfo> listInfo = CameraFinder.Enumerate(DeviceType.GigE);//枚举相机列表            
            foreach (ICameraInfo info in listInfo)
            {
                cameraList.Add(info.GetValueOrDefault("VendorName", "") + ":" + info.GetValueOrDefault("SerialNumber", ""));
            }
            return cameraList;
        }

        public override bool SingleFrameAcquisiton()// 单帧采集
        {
            if (baslerCamera == null)
            {
                return false;
            }
            StopAcquisition();
            string currentMode = baslerCamera.Parameters[PLCamera.AcquisitionMode].GetValue();
            if (currentMode != PLCamera.AcquisitionMode.SingleFrame)
            {
                baslerCamera.Parameters[PLCamera.AcquisitionMode].SetValue(PLCamera.AcquisitionMode.SingleFrame);
            }
            baslerCamera.StreamGrabber.Start(1, GrabStrategy.LatestImages, GrabLoop.ProvidedByStreamGrabber);//开始采集
            return true;
        }

        public override bool ContinuousAcquisition()// 实时采集
        {
            if (baslerCamera == null)
            {
                return false;
            }
            StopAcquisition();
            string currentMode = baslerCamera.Parameters[PLCamera.AcquisitionMode].GetValue();
            if (currentMode != PLCamera.AcquisitionMode.Continuous)
            {
                baslerCamera.Parameters[PLCamera.AcquisitionMode].SetValue(PLCamera.AcquisitionMode.Continuous);
            }
            baslerCamera.StreamGrabber.Start(GrabStrategy.LatestImages, GrabLoop.ProvidedByStreamGrabber);//开始采集
            return true;
        }

        public override void StopAcquisition()// 停止采集
        {
            if (baslerCamera != null)
            {
                if (baslerCamera.StreamGrabber.IsGrabbing == true)
                {
                    baslerCamera.StreamGrabber.Stop();
                }
            }
        }
        #endregion

        #region 公有函数（获得相机参数）
        public override double GetExposureTime()// 获得曝光时间
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.ExposureTimeAbs].GetValue();
            }
            catch
            {
                return 0;
            }
        }

        public override double GetGain()// 获得增益
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.GainRaw].GetValue();
            }
            catch
            {
                return 0;
            }
        }

        public override long GetImageMaxHeight()// 获得图像最大高度
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.Height].GetMaximum();
            }
            catch
            {
                return 0;
            }
        }

        public override long GetImageMaxWidth()// 获得图像最大宽度
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.Width].GetMaximum();
            }
            catch
            {
                return 0;
            }
        }

        public override long GetImageMinWidth()
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.Width].GetMinimum();
            }
            catch
            {
                return 0;
            }
        }

        public override long GetImageMinHeight()
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.Height].GetMinimum();
            }
            catch
            {
                return 0;
            }
        }

        public override double GetTriggerDelayTime()
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.TriggerDelayAbs].GetValue();
            }
            catch
            {
                return 0;
            }
        }

        public override double GetTimeout()
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.FrameTimeoutAbs].GetValue();
            }
            catch
            {
                return 0;
            }
        }

        public override double GetTriggerDelayTimeMax()//获得最大触发延时时间
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.TriggerDelayAbs].GetMaximum();
            }
            catch
            {
                return 0;
            }
        }

        public override double GetTriggerDelayTimeMin()//获得最小触发延时时间
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.TriggerDelayAbs].GetMinimum();
            }
            catch
            {
                return 0;
            }
        }

        public override double GetTimeoutMax()
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.FrameTimeoutAbs].GetMaximum();
            }
            catch
            {
                return 0;
            }
        }

        public override double GetTimeoutMin()
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.FrameTimeoutAbs].GetMinimum();
            }
            catch
            {
                return 0;
            }
        }

        public override long GetImageWidth()
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.Width].GetValue();
            }
            catch
            {
                return 0;
            }
        }

        public override long GetImageHeight()
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.Height].GetValue();
            }
            catch
            {
                return 0;
            }
        }

        public override double GetMaxExposureTime()// 获得最大曝光时间
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.ExposureTimeAbs].GetMaximum();
            }
            catch
            {
                return 0;
            }
        }

        public override double GetMinExposureTime()// 获得最小曝光时间
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.ExposureTimeAbs].GetMinimum();
            }
            catch
            {
                return 0;
            }
        }

        public override double GetMaxGain()// 获得最大增益
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.GainRaw].GetMaximum();
            }
            catch
            {
                return 0;
            }
        }

        public override double GetMinGain()// 获得最小增益
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.GainRaw].GetMinimum();
            }
            catch
            {
                return 0;
            }
        }

        public override string GetImageFormat()// 获得图像格式
        {
            return baslerCamera.Parameters[PLCamera.PixelFormat].GetValue();
        }

        private string GetTriggerMode()// 获得触发模式
        {
            string value = null;
            try
            {
                value = baslerCamera.Parameters[PLCamera.TriggerMode].GetValue();//off
                value = baslerCamera.Parameters[PLCamera.TriggerSource].GetValue();//Line1
            }
            catch
            {
            }
            return value;
        }

        public override long GetMinImageOffsetY()
        {
            return baslerCamera.Parameters[PLCamera.OffsetY].GetMinimum();
        }

        public override long GetMinImageOffsetX()
        {
            return baslerCamera.Parameters[PLCamera.OffsetX].GetMinimum();
        }

        public override long GetMaxImageOffsetY()
        {
            return baslerCamera.Parameters[PLCamera.OffsetY].GetMaximum();
        }

        public override long GetMaxImageOffsetX()
        {
            return baslerCamera.Parameters[PLCamera.OffsetX].GetMaximum();
        }
        #endregion

        #region 公有函数（设置相机参数）

        /// <summary>
        /// 设置曝光时间
        /// </summary>
        /// <param name="value"></param>
        public override bool SetExposureTime(double value)
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.ExposureTimeAbs].TrySetValue(value);
            }
            catch
            {
                return false;
            }
        }

        public override bool SetGain(double value)// 设置增益
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.GainRaw].TrySetValue((long)value);
            }
            catch
            {
                return false;
            }
        }

        public override bool SetImageHeight(long value)// 设置图像高度
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.Height].TrySetValue(value);
            }
            catch
            {
                return false;
            }
        }

        public override bool SetImageWidth(long value)// 设置图像宽度
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.Width].TrySetValue(value);
            }
            catch
            {
                return false;
            }
        }

        public override bool SetImageFormat(string value)// 设置图像格式
        {
            switch (value)
            {
                case "Mono8":
                    return baslerCamera.Parameters[PLCamera.PixelFormat].TrySetValue(PLCamera.PixelFormat.Mono8);
                case "RGB8":
                    return baslerCamera.Parameters[PLCamera.PixelFormat].TrySetValue(PLCamera.PixelFormat.RGB8);
                default:
                    return false;
            }
        }

        public override bool SetTriggerDelay(double value)//设置触发延时 触发信号发出，经过延时的时间，再开始采集 单位：微秒
        {
            return baslerCamera.Parameters[PLCamera.TriggerDelayAbs].TrySetValue(value);
        }

        public override bool SetTimeOut(double value)// 设置超时等待时间
        {
            return baslerCamera.Parameters[PLCamera.FrameTimeoutAbs].TrySetValue(value);
        }

        public override bool SetTriggerMode(string value)// 设置触发模式（待完善）
        {
            if (value == "Software trigger")
            {
                if (baslerCamera.Parameters[PLCamera.TriggerMode].TrySetValue(PLCamera.TriggerMode.On))
                {
                    return baslerCamera.Parameters[PLCamera.TriggerSource].TrySetValue(PLCamera.TriggerSource.Software);
                }
            }
            return false;
        }

        public override bool SetImageOffsetX(long value)//设置图像水平偏移
        {
            return baslerCamera.Parameters[PLCamera.OffsetX].TrySetValue(value);
        }

        public override bool SetImageOffsetY(long value)//设置图像竖直偏移
        {
            return baslerCamera.Parameters[PLCamera.OffsetY].TrySetValue(value);
        }
        #endregion

        #region 私有函数
        private void StreamGrabber_ImageGrabbed(object sender, ImageGrabbedEventArgs e)// 回调函数
        {
            IGrabResult grabResult = e.GrabResult;
            using (grabResult)
            {
                try
                {
                    if (grabResult.GrabSucceeded == true)
                    {
                        if (IsMonoFormat(grabResult) == true)//黑白图像
                        {
                            Bitmap _bitmap = bitmap;
                            HImage _hImage = hImage;
                            Bitmap __bitmap = null;
                            __bitmap = new Bitmap(grabResult.Width, grabResult.Height,    PixelFormat.Format32bppRgb);
                            BitmapData bmpData = __bitmap.LockBits(new Rectangle(0, 0, __bitmap.Width, __bitmap.Height), ImageLockMode.ReadWrite, __bitmap.PixelFormat);
                            converter.OutputPixelFormat = PixelType.BGRA8packed;
                            IntPtr ptrBmp = bmpData.Scan0;
                            converter.Convert(ptrBmp, bmpData.Stride * __bitmap.Height, grabResult);
                            __bitmap.UnlockBits(bmpData);
                            bitmap = RotateImage(__bitmap, 180);
                            byte[] buffer = grabResult.PixelData as byte[];
                            IntPtr p = Marshal.UnsafeAddrOfPinnedArrayElement(buffer, 0);
                            HImage __hImage = new HImage("byte", grabResult.Width, grabResult.Height, p);
                            hImage = __hImage.RotateImage(180d, "constant");
                           // CameraData.InertData.bitmap = new Bitmap(bitmap);//如果这里不使用new Bitmap则会内存泄漏
                           // CameraData.InertData.hImage = hImage;
                            DoSomething(bitmap, hImage);
                            if (_bitmap != null)
                            {
                                _bitmap.Dispose();
                            }
                            if (_hImage != null)
                            {
                                _hImage.Dispose();
                            }
                        }
                        else
                        {
                            if (grabResult.PixelTypeValue != PixelType.RGB8packed)//不是RGB8格式，则转换为RGB8格式，然后生成彩色图像（如果是RGB8格式则不需要转换）
                            {
                                byte[] buffer_rgb = new byte[grabResult.Width * grabResult.Height * 3];
                                IntPtr p = Marshal.UnsafeAddrOfPinnedArrayElement(buffer_rgb, 0);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    e.DisposeGrabResultIfClone();
                }
            }
        }

        public Bitmap RotateImage(Bitmap bitmap, float angle)
        {
            Bitmap returnBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            Graphics g = Graphics.FromImage(returnBitmap);
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.TranslateTransform((float)bitmap.Width / 2, (float)bitmap.Height / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-(float)bitmap.Width / 2, -(float)bitmap.Height / 2);
            g.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
            return returnBitmap;
        }

        private bool IsMonoFormat(IGrabResult grabResult)// 判断图像的格式
        {
            switch (grabResult.PixelTypeValue)
            {
                case PixelType.Mono1packed:
                case PixelType.Mono2packed:
                case PixelType.Mono4packed:
                case PixelType.Mono8:
                case PixelType.Mono8signed:
                case PixelType.Mono10:
                case PixelType.Mono10p:
                case PixelType.Mono10packed:
                case PixelType.Mono12:
                case PixelType.Mono12p:
                case PixelType.Mono12packed:
                case PixelType.Mono16:
                    return true;
                default:
                    return false;
            }
        }

       
        #endregion
    }
}
