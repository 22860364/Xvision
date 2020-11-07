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

namespace DispenseAPP.Tools_ImageEnhancement.Morphology
{
    public partial class MorphologyToolControl : UserControlTool
    {
        public MorphologyToolEntity morphologyToolEntity { get; set; } = null;
        public MorphologyToolControl(MorphologyToolEntity _morphologyToolEntity)
        {
            InitializeComponent();
            morphologyToolEntity = _morphologyToolEntity;
        }
    }
}
