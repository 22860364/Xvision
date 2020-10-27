using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace CameraLibrary
{
  
    public abstract class ICamerable //如果写成接口会更好 但是为了事件只允许一个客户端订阅 事件需要为 
    {
     
        public bool ConnectState { get; set; } = false;

        #region 设置相机参数
        public abstract bool SetExposureTime(double value);//设置曝光时间（小曝光）

        public abstract bool SetGain(double value);//设置增益（小增益）

        public abstract bool SetImageHeight(long value);//设置图像高度

        public abstract bool SetImageWidth(long value);//设置图像宽度

        public abstract bool SetImageFormat(string value);//设置图像格式

        public abstract bool SetTriggerMode(string triggerMode);//设置触发模式

        public abstract bool SetTriggerDelay(double value);//设置触发延时

        public abstract bool SetTimeOut(double value);//设置超时

        public abstract bool SetImageOffsetX(long value);//设置图像X方向偏移

        public abstract bool SetImageOffsetY(long value);//设置图像Y方向偏移

        #endregion

        #region 获得相机参数
        public abstract double GetExposureTime();//获取曝光时间

        public abstract double GetMinExposureTime();//获取最小曝光时间

        public abstract double GetMaxExposureTime();//获得最大曝光时间

        public abstract double GetGain();//获得相机增益

        public abstract double GetMaxGain();//获得最大增益

        public abstract double GetMinGain();//获得最小增益

        public abstract double GetTriggerDelayTime();//获得触发延时时间

        public abstract double GetTimeout();//获得超时时间

        public abstract long GetImageMaxWidth();//获得图片最大宽度

        public abstract long GetImageMaxHeight();//获得图片最大高度

        public abstract long GetImageMinWidth();//获得图片的最小宽度

        public abstract long GetImageMinHeight();//获得图片的最小高度
        public abstract long GetMinImageOffsetY(); // 获取图像最小Y偏移
        public abstract long GetMinImageOffsetX();  // 获取图像最小X偏移
        public abstract long GetMaxImageOffsetY();  // 获取图像最大Y偏移
        public abstract long GetMaxImageOffsetX();  // 获取图像最大X偏移
        public abstract double GetTriggerDelayTimeMax();//获得最大触发延时时间

        public abstract double GetTriggerDelayTimeMin();//获得最小触发延时时间

        public abstract double GetTimeoutMax();//获得最大超时时间

        public abstract double GetTimeoutMin();//获得最小超时时间

        public abstract long GetImageWidth();//获得图片宽度

        public abstract long GetImageHeight();//获得图片高度

        public abstract string GetImageFormat();//获得图片格式
        #endregion

        #region 操作
        public abstract bool InitialCamera(string _serialNumber);// 初始化相机

        public abstract void DisposeCamera();// 释放相机

        public abstract bool SingleFrameAcquisiton();// 单帧采集

        public abstract bool ContinuousAcquisition();// 连续采集

        public abstract void StopAcquisition();// 停止采集

        public abstract bool CheckCameraAvailable();// 检查相机是否可用

        public abstract List<string> GetCameraList();// 相机列表

        protected event Action<Bitmap,HImage> ImageCallBackEvent;//图像回调事件
       

        public void Register(Action<Bitmap, HImage> action)//注册图像回调事件
        {
            ImageCallBackEvent = action;
        }

        public void DoSomething(Bitmap bitmap, HImage hImage)
        {
            ImageCallBackEvent(bitmap,hImage);
        }

       
        #endregion
    }
}
