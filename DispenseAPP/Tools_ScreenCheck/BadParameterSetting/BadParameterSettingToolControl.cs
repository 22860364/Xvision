using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DispenseAPP.MyStyleControl;

namespace DispenseAPP.Tools_ScreenCheck.BadParameterSetting
{
    /// <summary>
    /// 不良点位参数设置
    /// </summary>
    public partial class BadParameterSettingToolControl : UserControlTool
    {
        public BadParameterSettingToolEntity badParameterSettingToolEntity { get; set; } = null;
        public BadParameterSettingToolControl(BadParameterSettingToolEntity _badParameterSettingToolEntity)
        {
            InitializeComponent();
            this.badParameterSettingToolEntity = _badParameterSettingToolEntity;
        }
    }
}
