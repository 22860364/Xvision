using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DispenseAPP.Tools_BarcodeRecognition
{
    public partial class UC_Barcode_Tools : UserControl
    {
        public event ClickToolsDelegate ClickToolsEvent;
        public UC_Barcode_Tools()
        {
            InitializeComponent();
        }

        private void lbl_OCR_Click(object sender, EventArgs e)
        {
            //ClickToolsEvent("OCR字符识别");
        }

        private void lbl_Barcode_Click(object sender, EventArgs e)
        {
            //ClickToolsEvent("条形码识别");
        }

        private void lbl_QRCode_Click(object sender, EventArgs e)
        {
            //ClickToolsEvent("二维码识别");
        }

        private void lbl_Classifier_Click(object sender, EventArgs e)
        {
            //ClickToolsEvent("分类器");
        }
    }
}
