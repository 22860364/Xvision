using DispenseAPP.AboutData;
using DispenseAPP.Tools_Other.DelayTime;
using DispenseAPP.Tools_Other.LogicOperation;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using static DispenseAPP.CommonClass;
using System.Collections.Generic;
using DispenseAPP.Tools_Other.VarSet;
using DispenseAPP.Tools_Other.ShowMessageBox;
using DispenseAPP.Tools_Location.ContourMatchin;

namespace DispenseAPP
{
    [XmlInclude(typeof(LogicOperationToolEntity))]
    [XmlInclude(typeof(ImportImageToolEntity))]
    [XmlInclude(typeof(AcqSetToolEntity))]
    [XmlInclude(typeof(AcqImageToolEntity))]
    [XmlInclude(typeof(DelayTimeToolEntity))]
    [XmlInclude(typeof(VarSetToolEntity))]    
    [XmlInclude(typeof(ShowMessageBoxToolEntity))]
    [XmlInclude(typeof(SearchOfContourToolEntity))]
    [Serializable]
    public abstract class IToolable : ICloneable, INotifyPropertyChanged
    {
        /// <summary>
        /// 不启用
        /// </summary>
        public bool Disable { get; set; } = false;

        /// <summary>
        /// 该工具所在工具箱名称
        /// </summary>
        public abstract ToolsKitNameEnum ToolKitName {get;}//工具箱名称

        /// <summary>
        /// 该工具的名称
        /// </summary>
        public abstract string ToolName { get;}

        string stepCustomName;
        /// <summary>
        /// 自定义算子名
        /// </summary>
        public string StepCustomName
        {
            get => stepCustomName;
            set
            {
                stepCustomName = value;
                MyDataBindingsClass.NotifyPropertyChanged(this, () => StepCustomName, PropertyChanged);
            }
        }

        /// <summary>
        /// 系统的算子名
        /// </summary>
        public string StepSystemName { get; set;}

        bool stepState = false;
        /// <summary>
        /// 执行状态
        /// </summary>
        [Reference(true)]
        [ConditionJudge]
        [XmlIgnore]
        public bool StepState
        {
            get => stepState;
            set
            {
                stepState = value;
                MyDataBindingsClass.NotifyPropertyChanged(this, () => StepState, PropertyChanged);
            }
        }        

        string executeResult = "Null";
        /// <summary>
        /// 执行结果
        /// </summary>
        [XmlIgnore]
        public string ExecutionResult
        {
            get => executeResult;
            set 
            {
                executeResult = value;
                MyDataBindingsClass.NotifyPropertyChanged(this, () => ExecutionResult, PropertyChanged);
            }
        }

        string executeTime= "Null";
        /// <summary>
        /// 执行时间
        /// </summary>
        [XmlIgnore]
        public string ExecutionTime
        {
            get => executeTime;
            set
            {
                executeTime = value;
                MyDataBindingsClass.NotifyPropertyChanged(this, () => ExecutionTime, PropertyChanged);
            }
        }

        /// <summary>
        /// 当前工具所在的普通算子块
        /// </summary>
        [XmlIgnore]
        public OperatorBlock SelectedOperatorBlock
        {
            get
            {
                return StaticPublicData.BlockItems[NameType.CustomName,OperatorBlockName] as OperatorBlock;
            }
        }

        /// <summary>
        /// 当前工具所在的普通算子块名称
        /// </summary>
        public string OperatorBlockName { get; set;}
        
        /// <summary>
        /// 属性更改时触发
        /// </summary>
        [field:NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 错误消息列表
        /// </summary>
        public List<string> ErrorList { get; set; } = new List<string>();

        /// <summary>
        /// 用于测量运行时间的对象
        /// </summary>
        [NonSerialized]
        [XmlIgnore]
        Stopwatch stopwatch = null;

        /// <summary>
        /// 计算执行时间
        /// </summary>
        public void ComputerExecuteTime()
        {         
            if (!Disable)
            {
                if(stopwatch == null)
                {
                    stopwatch = new Stopwatch();
                }
                stopwatch.Restart();
                Execute();
                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;
                ExecutionTime = ts.TotalSeconds.ToString("f2");
            }
            else
            {
                StepState = true;
                ExecutionResult = "";
                ExecutionTime = "Disable";
            }               
        }

        /// <summary>
        /// 设置OK结果
        /// </summary>
        /// <param name="success"></param>
        protected virtual void SetOK(string success)
        {
            DisplayMessage(success, null);
            StepState = true;
            ExecutionResult = success;
            StepState = true;
        }

        /// <summary>
        /// 设置NG结果
        /// </summary>
        /// <param name="error"></param>
        protected virtual void SetNG(string error)
        {
            DisplayMessage(null, error);
            StepState = false;
            ExecutionResult = error;
            StepState = false;
        }

        /// <summary>
        /// 在运行状态下显示消息
        /// </summary>
        /// <param name="successMessage"></param>
        /// <param name="exceptionMessage"></param>
        void DisplayMessage(string successMessage,string exceptionMessage)
        {
            if (SelectedOperatorBlock.MessageWindowIndex != "不显示" && IsRunState && !SelectedOperatorBlock.VisibleMessage)
            {
                Message message = new Message()
                {
                    Time = DateTime.Now.ToLongTimeString().ToString(),
                    StepName = SelectedOperatorBlock.CustomName,
                    ToolName = StepCustomName,
                    ExceptionMessage = exceptionMessage,
                    RunMessage = successMessage,
                };
                MessageWindowIndexDic[Convert.ToInt32(SelectedOperatorBlock.MessageWindowIndex)].AddMessage(message);
            };
        }

        /// <summary>
        /// 执行工具的方法
        /// </summary>
        public abstract void Execute();

        /// <summary>
        /// 运行前检查 防止在运行中出现错误
        /// </summary>
        /// <returns></returns>
        public abstract bool RunAgoCheck();

        /// <summary>
        /// 执行克隆
        /// </summary>
        /// <returns></returns>
        public virtual object Clone()
        {
            return MemberwiseClone();
        }
    }
}
