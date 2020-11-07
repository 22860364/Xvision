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

namespace DispenseAPP.Tools_ImageEnhancement.Filter
{
    public partial class FilterToolControl : UserControlTool
    {
        public FilterToolEntity filterToolEntity { get; set; } = null;
        public FilterToolControl(FilterToolEntity _filterToolEntity)
        {
            InitializeComponent();
            filterToolEntity = _filterToolEntity;
        }
    }
}
