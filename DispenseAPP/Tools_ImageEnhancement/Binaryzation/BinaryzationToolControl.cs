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

namespace DispenseAPP.Tools_ImageEnhancement.Binaryzation
{
    public partial class BinaryzationToolControl : UserControlTool
    {
        public BinaryzationToolEntity binaryzationToolEntity { get; set; } = null;
        public BinaryzationToolControl(BinaryzationToolEntity _binaryzationToolEntity)
        {
            InitializeComponent();
            binaryzationToolEntity = _binaryzationToolEntity;
        }
    }
}
