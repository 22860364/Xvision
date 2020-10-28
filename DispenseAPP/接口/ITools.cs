using DispenseAPP.AboutData;
using System;
using System.ComponentModel;
using System.Diagnostics;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    [Serializable]
    public abstract class ITools : ICloneable, INotifyPropertyChanged
    {
        public bool Forbidden { get; set; }//禁用

        public ToolsNameEnum ToolsName { get; set; }//工具名称

        public ToolsKitNameEnum ToolsKitName { get; set; }//工具箱名称

        private string blockName = "";
        public string BlockName
        {
            get
            {
                return blockName;
            }
            set
            {
                blockName = value;
                MyDataBindingsClass.NotifyPropertyChanged(this, () => BlockName, PropertyChanged);
            }
        }

        [NonSerialized]
        private string executeTime;
        public string ExecuteTime
        {
            get
            {
                return executeTime;
            }
            set
            {
                executeTime = value;
                MyDataBindingsClass.NotifyPropertyChanged(this, () => ExecuteTime, PropertyChanged);
            }
        }

        [NonSerialized]
        private ExecuteStateEnum executeState;
        public ExecuteStateEnum ExecuteState
        {
            get
            {
                return executeState;
            }
            set
            {
                executeState = value;
                MyDataBindingsClass.NotifyPropertyChanged(this, () => ExecuteState, PropertyChanged);
            }
        } 

        [Reference(true)]
        [ConditionJudge]
        public bool StepState { get; set; } = true;//步状态

        private string executeResult;
        public string ExecuteResult
        {
            get
            {
                return executeResult;
            }
            set
            {
                executeResult = value;
                MyDataBindingsClass.NotifyPropertyChanged(this, () => ExecuteResult, PropertyChanged);
            }
        }

        public NormalBlock SelectedNormalBlock { get; set; }//当前工具所对应的普通算子块

        public ProjectParamClass ProjectParamClass;

        public event PropertyChangedEventHandler PropertyChanged;

        public void ComputerExecuteTime(UC_Image imageWindow)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Execute(imageWindow);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            ExecuteTime = ts.TotalMilliseconds.ToString("f2");
        }

        public abstract void Execute(UC_Image imageWindow);// 执行

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
