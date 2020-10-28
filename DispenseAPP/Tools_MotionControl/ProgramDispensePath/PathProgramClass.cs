using DispenseAPP.AboutData;
using DispenseAPP.Tools_MotionControl.ProgramDispensePath.DispenseFunction;
using System.Collections.Generic;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_MotionControl.ProgrammingDispensePath
{
    public class PathProgramClass : ITools
    {
        public PathProgramClass()
        {
            ToolsName = ToolsNameEnum.PathProgram;
            ToolsKitName = ToolsKitNameEnum.Location;
        }
        public string[] SelectAxisArray { get; set; }//选择的轴
        public string SelectCardName { get; set; } = "";//选择的卡名称
        public string SelectVisionData { get; set; } = "无";//选择的视觉数据

        public List<DispensePath> DispensePathList = new List<DispensePath>();

        public override void Execute(UC_Image imageWindow)//职责链模式 1.先将表格中的数据做处理  2.执行处理过的数据
        {
            if(MotionCardDict.ContainsKey(SelectCardName) && MotionCardDict[SelectCardName].CardConnectState)//卡名称存在并且连接成功
            {

            }
            else//执行失败
            {
                SetError("运动控制卡对象不存在或连接失败");
            }
        }

        private void SetError(string error)
        {
            ExecuteState = ExecuteStateEnum.NG;
            StepState = false;
            ExecuteResult = error;
        }
    }
    public class DispenseRequestClass//点胶请求类
    {
        public List<DispensePath> DispensePathList = new List<DispensePath>();//点胶轨迹源数据集合

        public Dispense_RotateClass RotateClass = new Dispense_RotateClass();//旋转

        public Dispense_ZoomClass ZoomClass = new Dispense_ZoomClass();//缩放

        public Dispense_ChamferingClass ChamferingClass = new Dispense_ChamferingClass();//倒角

        public Dispense_ArrayClass ArrayClass = new Dispense_ArrayClass();//阵列
    }
}
