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

namespace DispenseAPP.Tools_ScreenCheck.DustFilter
{
    /// <summary>
    /// 灰尘
    /// </summary>
    public partial class DustFilterToolControl : UserControlTool
    {
        public DustFilterToolEntity dustFilterToolEntity { get; set; }
        public DustFilterToolControl(DustFilterToolEntity _dustFilterToolEntity)
        {
            InitializeComponent();
            this.dustFilterToolEntity = _dustFilterToolEntity;
        }
    }
}
