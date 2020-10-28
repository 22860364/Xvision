using DispenseAPP.AboutData;
using DispenseAPP.接口;
using System;
using System.Threading;
using Advantech.Motion;
using DispenseAPP.AboutMotionCard.ConfigCardClass.GTS;
using System.Collections.Generic;
using System.IO;

namespace DispenseAPP.MotionCardClass.AdvantechMC
{
    public class AdvClass : IMotionCard
    {
        private DEV_LIST[] dEV_LIST = new DEV_LIST[10];//设备信息
        private IntPtr Handle = IntPtr.Zero;//卡句柄
        private Dictionary<ushort, IntPtr> AxisHandleDic = new Dictionary<ushort, IntPtr>();

        public AdvClass(MCDataClass mcDataClass) : base(mcDataClass)
        {
            ReadTimer = new Timer(new TimerCallback(ReadIOAxisState), null, 0, 200);
        }

        public override bool InitialMotionCard(out string error)//初始化
        {
            error = "";
            if (McDataClass.CardConfig is ConfigFileIDClass configFileIDClass)
            {
                if (configFileIDClass.ConfigFilePath == "")
                {
                    error = "[卡." + McDataClass.Name + "]未配置,请先配置！";
                    return false;
                }
                uint actualDeviceNum = 0;
                if(Motion.mAcm_GetAvailableDevs(dEV_LIST,10,ref actualDeviceNum) != 0)
                {
                    error = "[卡." + McDataClass.Name + "]获取可用设备失败！";
                    return false;
                }
                if(Motion.mAcm_DevOpen(dEV_LIST[configFileIDClass.CardID].DeviceNum,ref Handle)!=0)//打开指定设备并获取句柄
                {
                    error = "打开[卡." + McDataClass.Name + "]失败！";
                    return false;
                }
                if (File.Exists(configFileIDClass.ConfigFilePath) == true)
                {
                    if (Motion.mAcm_DevLoadConfig(Handle, configFileIDClass.ConfigFilePath) != 0)
                    {
                        error = "加载[卡." + McDataClass.Name + "]配置文件失败！";
                        return false;
                    }
                }
                else
                {
                    error = "[卡." + McDataClass.Name + "]配置文件不存在,请检查！";
                    return false;
                }
                for (int i = 0; i < McDataClass.AxisConfigList.Count; i++)
                {
                    ushort axisID = (ushort)McDataClass.AxisConfigList[i].AxisID;
                    string axisName = McDataClass.AxisConfigList[i].AxisName;
                    IntPtr axisHandle = IntPtr.Zero;
                    if(Motion.mAcm_AxOpen(Handle,axisID,ref axisHandle) !=0)
                    {
                        error = "[卡." + McDataClass.Name + "][轴." + axisName + "]打开失败！";
                        return false;
                    }
                    AxisHandleDic.Add(axisID, axisHandle);
                    if(Motion.mAcm_AxSetSvOn(axisHandle,1)!=0)
                    {
                        error = "[卡." + McDataClass.Name + "][轴." + axisName + "]打开使能失败！";
                        return false;
                    }
                    if(Motion.mAcm_AxResetError(axisHandle)!=0)
                    {
                        error = "[卡." + McDataClass.Name + "][轴." + axisName + "]复位错误失败！";
                        return false;
                    }
                }
                return true;
            }
           return false;
        }

        public override bool CloseMotionCard(out string error)//关闭
        {
            error = "";
            for (ushort i = 0; i < McDataClass.AxisConfigList.Count; i++)
            {
                ushort axisID = (ushort)McDataClass.AxisConfigList[i].AxisID;
                string axisName = McDataClass.AxisConfigList[i].AxisName;
                IntPtr axisHandle = AxisHandleDic[axisID];
                if (Motion.mAcm_AxSetSvOn(axisHandle, 1) != 0)
                {
                    error = "[卡." + McDataClass.Name + "][轴." + axisName + "]关闭使能失败！";
                    return false;
                }
                if(Motion.mAcm_AxClose(ref axisHandle) != 0)
                {
                    error = "[卡." + McDataClass.Name + "][轴." + axisName + "]关闭失败！";
                    return false;
                }
            }
            if(Motion.mAcm_DevClose(ref Handle)!=0)
            {
                error = "[卡." + McDataClass.Name + "]关闭失败！";
                return false;
            }
            return true;
        }

        public override bool Home(out string error)
        {
            throw new NotImplementedException();
        }

        protected override void ReadIOAxisState(object data)
        {

        }

        public override bool JOG(int axisID, float speed, float acc, float dec, CommonClass.JOGMotionDir dir, out string error)
        {
            throw new NotImplementedException();
        }

        public override bool PTP(int axisID, float speed, float acc, float dec, CommonClass.MotionMode motionMode, float position, out string error)
        {
            throw new NotImplementedException();
        }

        public override bool StopMotion(int axisID,  out string error)
        {
            throw new NotImplementedException();
        }

        public override bool SetDO(int index, CommonClass.OutStateEnum state, out string error)
        {
            throw new NotImplementedException();
        }

        public override bool ReadAD(int index, out string value)
        {
            throw new NotImplementedException();
        }

        public override bool ReadDI(int index, out bool state, out string error)
        {
            throw new NotImplementedException();
        }

        public override bool ReadDO(int index, out bool state, out string error)
        {
            throw new NotImplementedException();
        }

        public override bool SetSoftLimit(int axisID, bool PELEnable, float PELValue, bool MELEnable, float MELValue)
        {
            throw new NotImplementedException();
        }
    }
}
