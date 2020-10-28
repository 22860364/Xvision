using System;
using System.ComponentModel;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.AboutData
{
    /// <summary>
    /// 系统设置项
    /// </summary>
    [Serializable]
    public class SystemSetData:ICloneable 
    {
        [Category("基本设置")]
        public string 软件名称 { get; set; } = "视觉点胶机";

        [Category("基本设置")]
        public bool 开机启动程序 { get; set; } = false;

        public object Clone()
        {
            return ExecuteClone(this);
        }
    }
}
