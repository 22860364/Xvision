using DispenseAPP.AboutData;
using System.Collections.Generic;
using System.Threading;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.接口
{
    public abstract class IMotionCard //规定：轴号从[0]开始
    {
        public List<AxisStateClass> AxisStateList = new List<AxisStateClass>();

        protected Timer ReadTimer;
        protected bool StartCheck { get; set; }//开始读取IO 特殊信号 轴位置 到位信号
        public MCDataClass McDataClass { get; set;}

        #region 回零集合 定义回零顺序分为5个级别
        public List<int> AxisIndexList1 = new List<int>();
        public List<int> AxisIndexList2 = new List<int>();
        public List<int> AxisIndexList3 = new List<int>();
        public List<int> AxisIndexList4 = new List<int>();
        public List<int> AxisIndexList5 = new List<int>();
        #endregion

        public IMotionCard(MCDataClass mcDataClass)
        {
            McDataClass = mcDataClass;
        }

        public bool CardConnectState { get; protected set; }

        public abstract bool InitialMotionCard(out string error);

        public abstract bool CloseMotionCard(out string error);

        public abstract bool JOG(int axisID, float speed, float acc, float dec, JOGMotionDir dir,out string error);

        public abstract bool PTP(int axisID, float speed, float acc, float dec, MotionMode motionMode, float position,out string error);

        public abstract bool ReadDI(int index,out bool state,out string error);

        public abstract bool ReadDO(int index,out bool state,out string error);

        public abstract bool SetDO(int index, OutStateEnum state,out string error);

        public abstract bool StopMotion(int axisID, out string error);

        public abstract bool Home(out string errorMessage);

        protected abstract void ReadIOAxisState(object data);

        public abstract bool ReadAD(int index, out string value);

        public abstract bool SetSoftLimit(int axisID,bool PELEnable,float PELValue,bool MELEnable,float MELValue);//设置软限位
    }

    public class AxisStateClass
    {
        public short AxisID { get; set; }//轴号
        public string AxisName { get; set;}//轴名称
        public bool PEl { get; set; }//正向硬限位
        public bool ORG { get; set; }//原点信号
        public bool MEL { get; set; }//负向硬限位
        public bool Alarm { get; set; }//报警信号
        public bool MotionFinsh { get; set; }//运动已完成
        public float AxisPosition { get; set; }//当前轴位置
        public bool SoftPEL { get; set; }//正向软限位
        public bool SoftMEL { get; set; }//负向软限位
    }
}
