using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DispenseAPP.Tools_ScreenCheck
{
    public partial class UC_ScreenCheck_Tools : UserControl
    {
        public event Action<string, IToolable> ClickToolsEvent;
        public UC_ScreenCheck_Tools()
        {
            InitializeComponent();
        }
    }
}
