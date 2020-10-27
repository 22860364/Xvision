using System;
using System.Collections.Generic;
using Basler.Pylon;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using HalconDotNet;

namespace DispenseAPP
{
    public class BaslerCamera : ICameraable
    {
        #region 私有变量
        /// <summary>
        /// 相机对象
        /// </summary>
        private Camera baslerCamera = null;

        /// <summary>
        /// 控制相机采图过程
        /// </summary>
        private bool grabOver = false;

        private HImage image = new HImage();

        IntPtr frameAddress = IntPtr.Zero;

        #endregion

        #region 公有函数
        /// <summary>
        /// 初始化相机
        /// </summary>
        /// <param name="_serialNumber"></param>
        /// <returns></returns>
        public bool InitialCamera(string _serialNumber)
        {
            try
            {
                baslerCamera = new Camera(_serialNumber);//根据相机ID创建相机对象                       
                baslerCamera.StreamGrabber.ImageGrabbed += StreamGrabber_ImageGrabbed;//注册采集回调函数
                baslerCamera.StreamGrabber.GrabStarted += StreamGrabber_GrabStarted;//抓取开始事件
                baslerCamera.StreamGrabber.GrabStopped += StreamGrabber_GrabStopped;//结束抓取事件
                baslerCamera.Open();//打开相机
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 释放相机
        /// </summary> 
        public bool DisposeCamera()
        {
            try
            {
                if (baslerCamera != null)
                {
                    baslerCamera.StreamGrabber.Stop();
                    baslerCamera.Close();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool CheckCameraAvailable()// 检查相机是否可用
        {
            try
            {
                if (baslerCamera != null)
                {
                    if (baslerCamera.IsConnected == true && baslerCamera.IsOpen == true)
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<string> GetCameraList()// 获得相机列表
        {
            List<string> cameraList = new List<string>();
            try
            {
                List<ICameraInfo> listInfo = CameraFinder.Enumerate(DeviceType.GigE);//枚举相机列表            
                foreach (ICameraInfo info in listInfo)
                {
                    cameraList.Add(info.GetValueOrDefault("VendorName", "") + ":" + info.GetValueOrDefault("SerialNumber", ""));
                }
            }
            catch
            {
            }
            return cameraList;
        }

        public void SingleFrameAcquisiton()// 单帧采集
        {
            try
            {
                StopAcquisition();
                string currentMode = baslerCamera.Parameters[PLCamera.AcquisitionMode].GetValue();
                if (currentMode != PLCamera.AcquisitionMode.SingleFrame)
                {
                    baslerCamera.Parameters[PLCamera.AcquisitionMode].SetValue(PLCamera.AcquisitionMode.SingleFrame);
                }
                baslerCamera.StreamGrabber.Start(1, GrabStrategy.LatestImages, GrabLoop.ProvidedByStreamGrabber);//开始采集
            }
            catch
            {
            }
        }

        public void ContinuousAcquisition()// 实时采集
        {
            StopAcquisition();
            string currentMode = baslerCamera.Parameters[PLCamera.AcquisitionMode].GetValue();
            if (currentMode != PLCamera.AcquisitionMode.Continuous)
            {
                baslerCamera.Parameters[PLCamera.AcquisitionMode].SetValue(PLCamera.AcquisitionMode.Continuous);
            }
            baslerCamera.StreamGrabber.Start(GrabStrategy.LatestImages, GrabLoop.ProvidedByStreamGrabber);//开始采集
        }

        public void StopAcquisition()// 停止采集
        {
            try
            {
                if (baslerCamera != null)
                {
                    if (baslerCamera.StreamGrabber.IsGrabbing == true)
                    {
                        baslerCamera.StreamGrabber.Stop();
                    }
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// 相机采集图片事件
        /// </summary>
        public event ImageCallBackDelegate ImageCallBackEvent;
        #endregion

        #region 公有函数（获得相机参数）
        public double GetExposureTime()// 获得曝光时间
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.ExposureTimeAbs].GetValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public double GetGain()// 获得增益
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.GainRaw].GetValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public long GetImageMaxHeight()// 获得图像最大高度
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.Height].GetMaximum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public long GetImageMaxWidth()// 获得图像最大宽度
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.Width].GetMaximum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public long GetImageMinWidth()
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.Width].GetMinimum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public long GetImageMinHeight()
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.Height].GetMinimum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public double GetTriggerDelayTime()
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.TriggerDelayAbs].GetValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public double GetTimeout()
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.FrameTimeoutAbs].GetValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public double GetTriggerDelayTimeMax()//获得最大触发延时时间
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.TriggerDelayAbs].GetMaximum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public double GetTriggerDelayTimeMin()//获得最小触发延时时间
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.TriggerDelayAbs].GetMinimum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public double GetTimeoutMax()
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.FrameTimeoutAbs].GetMaximum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public double GetTimeoutMin()
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.FrameTimeoutAbs].GetMinimum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public long GetImageWidth()
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.Width].GetValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public long GetImageHeight()
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.Height].GetValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public double GetMaxExposureTime()// 获得最大曝光时间
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.ExposureTimeAbs].GetMaximum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public double GetMinExposureTime()// 获得最小曝光时间
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.ExposureTimeAbs].GetMinimum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public double GetMaxGain()// 获得最大增益
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.GainRaw].GetMaximum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public double GetMinGain()// 获得最小增益
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.GainRaw].GetMinimum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public string GetImageFormat()// 获得图像格式
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
        #endregion

        #region 公有函数（设置相机参数）

        /// <summary>
        /// 设置曝光时间
        /// </summary>
        /// <param name="value"></param>
        public bool SetExposureTime(double value)
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.ExposureTimeAbs].TrySetValue(value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool SetGain(double value)// 设置增益
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.GainRaw].TrySetValue((long)value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool SetImageHeight(long value)// 设置图像高度
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.Height].TrySetValue(value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool SetImageWidth(long value)// 设置图像宽度
        {
            try
            {
                return baslerCamera.Parameters[PLCamera.Width].TrySetValue(value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool SetImageFormat(string value)// 设置图像格式
        {
            switch (value)
            {
                case "Mono8":
                    return baslerCamera.Parameters[PLCamera.PixelFormat].TrySetValue(PLCamera.PixelFormat.Mono8);
                case "RGB8":
                    return baslerCamera.Parameters[PLCamera.PixelFormat].TrySetValue(PLCamera.PixelFormat.RGB8);
            }
            return false;
        }

        public bool SetTriggerDelay(double value)//设置触发延时 触发信号发出，经过延时的时间，再开始采集 单位：微秒
        {
            return baslerCamera.Parameters[PLCamera.TriggerDelayAbs].TrySetValue(value);
        }

        public bool SetTimeOut(double value)// 设置超时等待时间
        {
            return baslerCamera.Parameters[PLCamera.FrameTimeoutAbs].TrySetValue(value);
        }

        public bool SetTriggerMode(string value)// 设置触发模式（待完善）
        {
            if (value == "SoftWare trigger")
            {
                if (baslerCamera.Parameters[PLCamera.TriggerMode].TrySetValue(PLCamera.TriggerMode.On))

                    if (baslerCamera.Parameters[PLCamera.TriggerSource].TrySetValue(PLCamera.TriggerSource.Software))
                    {

                    }
            }
            return false;
        }

        /// <summary>
        /// 设置图像水平偏移
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetImageOffsetX(long value)
        {
            if (baslerCamera.Parameters[PLCamera.OffsetX].TrySetValue(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 设置图像竖直偏移
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetImageOffsetY(long value)
        {
            if (baslerCamera.Parameters[PLCamera.OffsetY].TrySetValue(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 私有函数
        /// <summary>
        /// 采集结束
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamGrabber_GrabStopped(object sender, GrabStopEventArgs e)
        {
            grabOver = false;
        }

        /// <summary>
        /// 采集开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamGrabber_GrabStarted(object sender, EventArgs e)
        {
            grabOver = true;
        }

        /// <summary>
        /// 回调函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamGrabber_ImageGrabbed(object sender, ImageGrabbedEventArgs e)
        {
            PixelDataConverter pxConvert = new PixelDataConverter();
            IGrabResult grabResult = e.GrabResult;
            using (grabResult)
            {
                try
                {
                    if (grabResult.GrabSucceeded == true)
                    {
                        if (grabOver)
                        {
                            if (IsMonoFormat(grabResult) == true)//黑白图像
                            {
                                if (frameAddress == IntPtr.Zero)
                                {
                                    frameAddress = Marshal.AllocHGlobal((IntPtr)grabResult.PayloadSize);
                                }
                                pxConvert.OutputPixelFormat = PixelType.Mono8;
                                pxConvert.Convert(frameAddress, grabResult.PayloadSize, grabResult);//这句话在干什么
                                image.GenImage1("byte", grabResult.Width, grabResult.Height, frameAddress);
                                ImageCallBackEvent(image);
                            }
                            else
                            {
                                if (grabResult.PixelTypeValue != PixelType.RGB8packed)//不是RGB8格式，则转换为RGB8格式，然后生成彩色图像（如果是RGB8格式则不需要转换）
                                {
                                    byte[] buffer_rgb = new byte[grabResult.Width * grabResult.Height * 3];
                                    pxConvert.OutputPixelFormat = PixelType.RGB8packed;
                                    pxConvert.Convert(buffer_rgb, grabResult);
                                    IntPtr p = Marshal.UnsafeAddrOfPinnedArrayElement(buffer_rgb, 0);
                                    image.GenImageInterleaved(p, "rgb", grabResult.Width, grabResult.Height, 0, "byte", grabResult.Width, grabResult.Height, 0, 0, -1, 0);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Basler类", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                finally
                {
                    e.DisposeGrabResultIfClone();
                    image.Dispose();
                }
            }
        }

        /// <summary>
        /// 判断图像的格式
        /// </summary>
        /// <param name="grabResult"></param>
        /// <returns></returns>
        private bool IsMonoFormat(IGrabResult grabResult)
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
    }//类结束
}//命名空间
