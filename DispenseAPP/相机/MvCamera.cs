using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvCamCtrl.NET;

namespace DispenseAPP.相机
{
    public class MvCamera
    {
        public event ImageCallBackDelegate ImageCallBackEvent;

        private MyCamera camera = null;

        public bool CheckCameraAvailable()
        {
            throw new NotImplementedException();
        }

        public void ContinuousAcquisition()
        {
            throw new NotImplementedException();
        }

        public bool DisposeCamera()
        {
            throw new NotImplementedException();
        }

        public List<string> GetCameraList()
        {
            throw new NotImplementedException();
        }

        public double GetExposureTime()
        {
            throw new NotImplementedException();
        }

        public double GetGain()
        {
            throw new NotImplementedException();
        }

        public string GetImageFormat()
        {
            throw new NotImplementedException();
        }

        public long GetImageHeight()
        {
            throw new NotImplementedException();
        }

        public long GetImageMaxHeight()
        {
            throw new NotImplementedException();
        }

        public long GetImageMaxWidth()
        {
            throw new NotImplementedException();
        }

        public long GetImageMinHeight()
        {
            throw new NotImplementedException();
        }

        public long GetImageMinWidth()
        {
            throw new NotImplementedException();
        }

        public long GetImageWidth()
        {
            throw new NotImplementedException();
        }

        public double GetMaxExposureTime()
        {
            throw new NotImplementedException();
        }

        public double GetMaxGain()
        {
            throw new NotImplementedException();
        }

        public double GetMinExposureTime()
        {
            throw new NotImplementedException();
        }

        public double GetMinGain()
        {
            throw new NotImplementedException();
        }

        public double GetTimeout()
        {
            throw new NotImplementedException();
        }

        public double GetTimeoutMax()
        {
            throw new NotImplementedException();
        }

        public double GetTimeoutMin()
        {
            throw new NotImplementedException();
        }

        public double GetTriggerDelayTime()
        {
            throw new NotImplementedException();
        }

        public double GetTriggerDelayTimeMax()
        {
            throw new NotImplementedException();
        }

        public double GetTriggerDelayTimeMin()
        {
            throw new NotImplementedException();
        }

        public bool InitialCamera(string _serialNumber)
        {
            throw new NotImplementedException();
        }

        public bool SetExposureTime(double value)
        {
            throw new NotImplementedException();
        }

        public bool SetGain(double value)
        {
            throw new NotImplementedException();
        }

        public bool SetImageFormat(string value)
        {
            throw new NotImplementedException();
        }

        public bool SetImageHeight(long value)
        {
            throw new NotImplementedException();
        }

        public bool SetImageOffsetX(long value)
        {
            throw new NotImplementedException();
        }

        public bool SetImageOffsetY(long value)
        {
            throw new NotImplementedException();
        }

        public bool SetImageWidth(long value)
        {
            throw new NotImplementedException();
        }

        public bool SetTimeOut(double value)
        {
            throw new NotImplementedException();
        }

        public bool SetTriggerDelay(double value)
        {
            throw new NotImplementedException();
        }

        public bool SetTriggerMode(string triggerMode)
        {
            throw new NotImplementedException();
        }

        public void SingleFrameAcquisiton()
        {
            throw new NotImplementedException();
        }

        public void StopAcquisition()
        {
            throw new NotImplementedException();
        }
    }
}
