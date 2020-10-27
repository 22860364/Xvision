using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DispenseAPP.Tools_Image_IO.ExportImage
{
    public partial class Tools_ExportImage : UserControl,IEvent 
    {
        public Tools_ExportImage(ExportImageClass exportImageClass)
        {
            InitializeComponent();
            _exportImageClass = exportImageClass;
        }

        private ExportImageClass _exportImageClass;

        public event ClickCancelDelegate _clickCancelButton;
        public event ClickOKButtonDelegate _clickOKButton;

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            _clickCancelButton();
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            _clickOKButton(_exportImageClass);
        }
    }
}
