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

namespace DispenseAPP.Tools_ImageEnhancement.Pretreatment
{
    public partial class PretreatmentToolControl : UserControlTool
    {
        public PretreatmentToolEntity pretreatmentToolEntity { get; set; } = null;
        public PretreatmentToolControl(PretreatmentToolEntity _pretreatmentToolEntity)
        {
            InitializeComponent();
            this.pretreatmentToolEntity = _pretreatmentToolEntity;
        }
    }
}
