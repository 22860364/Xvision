using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DispenseAPP.Tools_ScreenCheck.DustFilter;
using DispenseAPP.Tools_ScreenCheck.BadParameterSetting;

namespace DispenseAPP.Tools_ScreenCheck
{
    public partial class UC_ScreenCheck_Tools : UserControl
    {
        public event Action<string, IToolable> ClickToolsEvent;
        public UC_ScreenCheck_Tools()
        {
            InitializeComponent();
        }

        private void Lbl_DustFilter_Click(object sender, EventArgs e)
        {
            ClickToolsEvent("灰尘过滤", new DustFilterToolEntity());
        }

        private void Lbl_BadParameterSetting_Click(object sender, EventArgs e)
        {
            ClickToolsEvent("不良点参数设置", new BadParameterSettingToolEntity());
        }

        
    }
}
