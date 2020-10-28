using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ThridLibray;

namespace CameraLibrary.CameraType
{
    class DaHua : ICamerable
    {
        List<IGrabbedRawData> m_frameList = new List<IGrabbedRawData>();        /* 图像缓存列表 */
        Thread renderThread = null;         /* 显示线程  */
        bool m_bShowLoop = true;            /* 线程控制变量 */
        Mutex m_mutex = new Mutex();        /* 锁，保证多线程安全 */
        Stopwatch m_stopWatch = new Stopwatch();
        private Graphics _g = null;
        bool m_bShowByGDI;                  /* 是否使用GDI绘图 */
        private IDevice m_dev;    /* 设备对象 */
        private string userID;
        List<IDeviceInfo> li = Enumerator.EnumerateDevices();
        public override bool CheckCameraAvailable()  // 检查相机是否可用
        {
            if (m_dev == null)
            {
                return false;
            }
            if (m_dev.IsOpen)
            {
                return true;
            }
            return false;
        }  

        public override bool ContinuousAcquisition()  // 实时采集
        {
            return AcquisitionSet("Off");
        } 

        public override void DisposeCamera()   // 释放相机
        {
            if (m_dev == null)
            {
                return;
            }
            ConnectState = false;
            m_dev.ShutdownGrab();
            m_dev.Close();
        }

        public override List<string> GetCameraList()  // 获取相机列表
        {
            List<string> cameraList = new List<string>();
            foreach (IDeviceInfo info in li)
            {
                cameraList.Add(info.Key);
            }
            return cameraList;
        }

        public override bool SingleFrameAcquisiton() // 单帧采集
        {
            bool state = false;
            if (!state)
            {
                AcquisitionSet("On");
                state = true;
            }
            try
            {
                m_dev.ExecuteSoftwareTrigger();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public override void StopAcquisition()  // 停止采集
        {
            if (m_dev != null)
            {
                m_dev.ShutdownGrab();
            }
        }

        #region 公有函数（获得相机参数）
        public override double GetExposureTime()   // 获取曝光时间
        {
            try
            {
                using (IFloatParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ExposureTime])

                {

                    return p.GetValue();

                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public override double GetGain()   // 获取增益
        {
            try
            {
                using (IFloatParameter p = m_dev.ParameterCollection[ParametrizeNameSet.GainRaw])

                {

                    return p.GetValue();

                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public override string GetImageFormat()   // 获取图像格式
        {
           
                using (IEnumParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ImagePixelFormat])

                {

                    return p.GetValue();

                }
           
        }

        public override long GetImageHeight()  // 获取图像高
        {
            try
            {
                using (IIntegraParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ImageHeight])

                {

                    return p.GetValue();

                }
            }
            catch (Exception)
            {

                return 0;
            }
            
        }

        public override long GetImageMaxHeight()  // 获取最大图像高
        {
            try
            {
                using (IIntegraParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ImageHeight])

                {

                    return p.GetMaximum();

                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public override long GetImageMaxWidth()  // 获取最大图像宽
        {
            try
            {
                using (IIntegraParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ImageWidth])

                {

                    return p.GetMaximum();

                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public override long GetImageMinHeight()  // 获取最小图像高
        {
            try
            {
                using (IIntegraParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ImageHeight])

                {

                    return p.GetMinimum();

                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public override long GetImageMinWidth()  // 获取最小图像宽
        {
            try
            {
                using (IIntegraParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ImageWidth])

                {

                    return p.GetMinimum();

                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public override long GetImageWidth()  // 获取图像宽
        {
            try
            {
                using (IIntegraParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ImageWidth])

                {

                    return p.GetValue();

                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public override double GetMaxExposureTime()  // 获取最大曝光时间
        {
            try
            {
                using (IFloatParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ExposureTime])

                {

                    return p.GetMaximum();

                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public override double GetMaxGain()  // 获取最大增益
        {
            try
            {
                using (IFloatParameter p = m_dev.ParameterCollection[ParametrizeNameSet.GainRaw])

                {

                    return p.GetMaximum();

                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public override double GetMinExposureTime()  // 获取最小曝光时间
        {
            try
            {
                using (IFloatParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ExposureTime])

                {

                    return p.GetMinimum();

                }
            }
            catch (Exception)
            {

                return 0;
            }
            
        }

        public override double GetMinGain()  // 获取最小增益
        {
            try
            {
                using (IFloatParameter p = m_dev.ParameterCollection[ParametrizeNameSet.GainRaw])

                {

                    return p.GetMinimum();

                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public override double GetTimeout()  // 未添加获取超时
        {
            //try
            //{
            //    using (IFloatParameter p = m_dev.ParameterCollection[ParametrizeNameSet.Ti])

            //    {

            //        return p.GetMinimum();

            //    }
            //}
            //catch (Exception)
            //{

            return 0;
            //}
        }

        public override double GetTimeoutMax()  // 未添加获取最大超时
        {
            return 0;
        }

        public override double GetTimeoutMin()  // 未添加获取最小超时
        {
            return 0;
        }

        public override double GetTriggerDelayTime()  // 获取触发延迟
        {
            try
            {
                using (IFloatParameter p = m_dev.ParameterCollection[ParametrizeNameSet.TriggerDelay])

                {

                    return p.GetValue();

                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public override double GetTriggerDelayTimeMax()  // 获取最大触发延迟
        {
            try
            {
                using (IFloatParameter p = m_dev.ParameterCollection[ParametrizeNameSet.TriggerDelay])

                {

                    return p.GetMaximum();

                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public override double GetTriggerDelayTimeMin()  // 获取最小触发延迟
        {
            try
            {
                using (IFloatParameter p = m_dev.ParameterCollection[ParametrizeNameSet.TriggerDelay])

                {

                    return p.GetMinimum();

                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public override long GetMinImageOffsetY()
        {
            using (IIntegraParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ImageOffsetY])

            {

                return p.GetMinimum();

            }
        }

        public override long GetMinImageOffsetX()
        {
            using (IIntegraParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ImageOffsetX])

            {

                return p.GetMinimum();

            }
        }

        public override long GetMaxImageOffsetY()
        {
            using (IIntegraParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ImageOffsetY])

            {

                return p.GetMaximum();

            }
        }

        public override long GetMaxImageOffsetX()
        {
            using (IIntegraParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ImageOffsetX])

            {

                return p.GetMaximum();

            }
        }
        #endregion

        #region 公有函数（设置相机参数）
        public override bool SetExposureTime(double value)
        {
            try
            {
                using (IFloatParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ExposureTime])

                {

                    return p.SetValue(value);

                }

            }
            catch (Exception)
            {

                return false;
            }
        }

        public override bool SetGain(double value)
        {
            try
            {
                using (IFloatParameter p = m_dev.ParameterCollection[ParametrizeNameSet.GainRaw])

                {

                    return p.SetValue(value);

                }

            }
            catch (Exception)
            {

                return false;
            }
        }

        public override bool SetImageFormat(string value)
        {
            using (IEnumParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ImagePixelFormat])

            {

                return p.SetValue(value);

            }
        }

        public override bool SetImageHeight(long value)
        {
            try
            {
                using (IIntegraParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ImageHeight])

                {

                    return p.SetValue(value);

                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public override bool SetImageOffsetX(long value)
        {
            using (IIntegraParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ImageOffsetX])

            {

                return p.SetValue(value);

            }
        }

        public override bool SetImageOffsetY(long value)
        {
            using (IIntegraParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ImageOffsetY])

            {

                return p.SetValue(value);

            }
        }

        public override bool SetImageWidth(long value)
        {
            using (IIntegraParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ImageWidth])

            {

                return p.SetValue(value);

            }
        }

        public override bool SetTimeOut(double value)   // 未完成
        {
            return true;
        }

        public override bool SetTriggerDelay(double value)
        {
            using (IFloatParameter p = m_dev.ParameterCollection[ParametrizeNameSet.TriggerDelay])

            {

                return p.SetValue(value);

            }
        }

        public override bool SetTriggerMode(string triggerMode)
        {
            using (IEnumParameter p = m_dev.ParameterCollection[ParametrizeNameSet.TriggerMode])
            {
                return p.SetValue(triggerMode);
            }
        }


        #endregion

        public override bool InitialCamera(string _serialNumber)  // 初始化相机
        {
            string name = "Machine Vision:" + _serialNumber;
            this.userID = name;
            /* 设备搜索 */
            

            if (li.Count > 0)
            {
                for (int i = 0; i < li.Count; i++)
                {
                    if (li[i].Key == userID)
                    {
                        m_dev = Enumerator.GetDeviceByKey(userID);
                        try
                        {
                            if (m_dev.Open())
                            {
                                using (IEnumParameter p = m_dev.ParameterCollection[ParametrizeNameSet.ImagePixelFormat])
                                {
                                    p.SetValue("Mono8");
                                }
                                /* 开启相机线程 */
                                renderThread = new Thread(new ThreadStart(ShowThread));
                                renderThread.IsBackground = true;
                                renderThread.Start();
                                /* 设置缓存个数为8（默认值为16） */
                                m_dev.StreamGrabber.SetBufferCount(8);

                                /* 注册码流回调事件 图像回调函数 */
                                m_dev.StreamGrabber.ImageGrabbed += OnImageGrabbed;
                                /* 相机短线回调 */
                                m_dev.ConnectionLost += OnConnectLoss;
                                ConnectState = true;
                            }
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                        
                    }
                }
            }
            return true;
        }

        private void OnConnectLoss(object sender, EventArgs e)   // 相机断开回调
        {
            if (m_dev == null)
            {
                m_dev.ShutdownGrab();
                m_dev.Dispose();
                m_dev = null;
            }
        }

        private void OnImageGrabbed(object sender, GrabbedEventArgs e)   // 相机数据回调函数
        {
            m_mutex.WaitOne();
            m_frameList.Add(e.GrabResult.Clone());
            m_mutex.ReleaseMutex();
        }

        private void ShowThread()  // 开启线程采集
        {
            try
            {
                while (m_bShowLoop)
                {
                    if (m_frameList.Count == 0)
                    {
                        Thread.Sleep(10);
                        continue;
                    }

                    /* 图像队列取最新帧 */
                    m_mutex.WaitOne();
                    IGrabbedRawData frame = m_frameList.ElementAt(m_frameList.Count - 1);
                    m_frameList.Clear();
                    m_mutex.ReleaseMutex();

                    /* 主动调用回收垃圾 */
                    GC.Collect();

                    /* 控制显示最高帧率为25FPS */
                    if (false == isTimeToDisplay())
                    {
                        continue;
                    }

                    try
                    {
                        /* 图像转码成bitmap图像 */
                        var bitmap = frame.ToBitmap(false);
                        //   Bitmap bit = bitmap.Clone();
                        m_bShowByGDI = true;
                        if (m_bShowByGDI)
                        {
                            HImage himage = BitmapToHImage(bitmap);
                            /// 添加事件通过绑定事件的方式进行图像传播
                            DoSomething(bitmap,himage);
                            
                        }
                    }
                    catch (Exception exception)
                    {
                        Catcher.Show(exception);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        const int DEFAULT_INTERVAL = 40;
        private bool isTimeToDisplay()
        {
            m_stopWatch.Stop();
            long m_lDisplayInterval = m_stopWatch.ElapsedMilliseconds;
            if (m_lDisplayInterval <= DEFAULT_INTERVAL)
            {
                m_stopWatch.Start();
                return false;
            }
            else
            {
                m_stopWatch.Reset();
                m_stopWatch.Start();
                return true;
            }
        }

        private bool AcquisitionSet(string value)
        {
            if (m_dev == null)
            {
                return false;
            }
            m_dev.TriggerSet.Open(TriggerSourceEnum.Software);
            SetTriggerMode(value);
            if (!m_dev.GrabUsingGrabLoopThread())
            {
                return false;
            }
            return true;
        }

        private static HImage BitmapToHImage(Bitmap SrcImage)  // 转HImage对象
        {
            HImage hImage = new HImage();
            try
            {
                Point po = new Point(0, 0);
                Size so = new Size(SrcImage.Width, SrcImage.Height);
                //template.Width, template.Height        
                Rectangle ro = new Rectangle(po, so);
                Bitmap DstImage = new Bitmap(SrcImage.Width, SrcImage.Height, PixelFormat.Format8bppIndexed);
                DstImage = SrcImage.Clone(ro, PixelFormat.Format8bppIndexed);
                int width = DstImage.Width;
                int height = DstImage.Height;
                Rectangle rect = new Rectangle(0, 0, width, height);
                System.Drawing.Imaging.BitmapData dstBmpData = DstImage.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
                //pImage.PixelFormat     
                int PixelSize = Bitmap.GetPixelFormatSize(dstBmpData.PixelFormat) / 8;
                int stride = dstBmpData.Stride;
                //重点在此       
                unsafe
                {
                    int count = height * width;
                    byte[] data = new byte[count];
                    byte* bptr = (byte*)dstBmpData.Scan0;
                    fixed (byte* pData = data)
                    {
                        for (int i = 0; i < height; i++)
                            for (int j = 0; j < width; j++)
                            {
                                data[i * width + j] = bptr[i * stride + j];
                            }
                        hImage.GenImage1( "byte", width, height, new IntPtr(pData));
                    }
                }
                DstImage.UnlockBits(dstBmpData);
            }
            catch { }
            return hImage;
        }



    }
}
