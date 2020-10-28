using DispenseAPP.CustomControl;
using System;
using System.Drawing;
using HalconDotNet;

namespace DispenseAPP.Tools_Location.ContourMatching
{
    public partial class FrmEditContour : FormM
    {
        public FrmEditContour(Bitmap bitmap,HImage hImage)
        {
            InitializeComponent();
            uC_MyWindow1.Control.DispImage(bitmap, hImage);
        }

        private void Tslbl_Eraser_Click(object sender, EventArgs e)//显示橡皮擦
        {

        }
    }
}
