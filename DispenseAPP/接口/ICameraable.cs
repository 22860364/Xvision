using System.Collections.Generic;
using HalconDotNet;

namespace DispenseAPP
{
    public delegate void ImageCallBackDelegate(HImage image);
    public interface ICameraable
    {
        #region 设置相机参数
        bool SetExposureTime(double value);// 设置曝光时间（小曝光）

        bool SetGain(double value);// 设置增益（小增益）

        bool  SetImageHeight(long value);// 设置图像高度

        bool SetImageWidth(long value);// 设置图像宽度

        bool SetImageFormat(string value);// 设置图像格式

        bool SetTriggerMode(string triggerMode);// 设置触发模式

        bool SetTriggerDelay(double value);// 设置触发延时

        bool SetTimeOut(double value);// 设置超时

        bool SetImageOffsetX(long value);// 设置图像X方向偏移

        bool SetImageOffsetY(long value);// 设置图像Y方向偏移

        #endregion

        #region 获得相机参数
        double GetExposureTime();// 获取曝光时间

        double GetMinExposureTime();// 获取最小曝光时间

        double GetMaxExposureTime();// 获得最大曝光时间

        double GetGain();// 获得相机增益

        double GetMaxGain();// 获得最大增益

        double GetMinGain();// 获得最小增益

        double GetTriggerDelayTime();//获得触发延时时间

        double GetTimeout();//获得超时时间

        long GetImageMaxWidth();// 获得图片最大宽度

        long GetImageMaxHeight();//获得图片最大高度

        long GetImageMinWidth();//获得图片的最小宽度

        long GetImageMinHeight();//获得图片的最小高度

        double GetTriggerDelayTimeMax();//获得最大触发延时时间

        double GetTriggerDelayTimeMin();//获得最小触发延时时间

        double GetTimeoutMax();//获得最大超时时间

        double GetTimeoutMin();//获得最小超时时间

        long GetImageWidth();//获得图片宽度

        long GetImageHeight();//获得图片高度

        string GetImageFormat();// 获得图片格式
        #endregion

        #region 操作

        bool InitialCamera(string _serialNumber);// 初始化相机

        bool DisposeCamera();// 释放相机

        void SingleFrameAcquisiton();// 单帧采集

        void ContinuousAcquisition();// 连续采集

        void StopAcquisition();// 停止采集

        bool CheckCameraAvailable();// 检查相机是否可用

        List<string> GetCameraList();// 相机列表

        event ImageCallBackDelegate ImageCallBackEvent;// 图像回调事件
        #endregion
    }
}
