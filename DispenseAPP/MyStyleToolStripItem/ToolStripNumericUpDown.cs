using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DispenseAPP.MyStyleToolStripItem
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip)]
    public class ToolStripNumericUpDown: ToolStripControlHost
    {
        public ToolStripNumericUpDown():base (new NumericUpDown())
        {

        }
    }
}
