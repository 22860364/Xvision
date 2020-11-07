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

namespace DispenseAPP.Tools_ScreenCheck.LightLeak
{
    public partial class LightLeakToolControl : UserControlTool
    {
        public LightLeakToolEntity leakToolEntity { get; set; } = null;
        public LightLeakToolControl(LightLeakToolEntity _lightLeakToolEntity)
        {
            InitializeComponent();
            this.leakToolEntity = _lightLeakToolEntity;
        }
    }
}
