using DispenseAPP.Tools_Location.ContourMatchin;
using System;
using System.Windows.Forms;

namespace DispenseAPP.Tools_Location
{
    public partial class UC_Location_Tools : UserControl
    {
        public event Action<string, IToolable> ClickToolsEvent;
        public UC_Location_Tools()
        {
            InitializeComponent();
        }

        private void Lbl_ContourMatch_Click(object sender, EventArgs e)
        {
            ClickToolsEvent("轮廓匹配",new SearchOfContourToolEntity());
        }
    }
}
