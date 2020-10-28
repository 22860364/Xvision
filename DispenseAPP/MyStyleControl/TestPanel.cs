using System.Drawing;
using System.Windows.Forms;

namespace DispenseAPP.MyStyleControl
{
    public partial class TestPanel : Panel
    {
        public TestPanel()
        {
            InitializeComponent();
        }

        protected override Point ScrollToControl(Control activeControl)
        {
            return AutoScrollPosition;
        }
    }
}
