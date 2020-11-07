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

namespace DispenseAPP.Tools_ImageEnhancement.DisposeImage
{
    public partial class DisposeImageToolControl : UserControlTool
    {
        public DisposeImageToolEntity disposeImageToolEntity { get; set; } = null;
        public DisposeImageToolControl(DisposeImageToolEntity _disposeImageToolEntity)
        {
            InitializeComponent();
            disposeImageToolEntity = _disposeImageToolEntity;
        }
    }
}
