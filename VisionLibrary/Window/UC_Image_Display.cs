using System;
using System.Drawing;
using System.Windows.Forms;
using HalconDotNet;

namespace DispenseAPP.WindowControl
{
    public partial class UC_Image_Display : UserControl
    {
        public UC_Image_Display()//只是用来显示图像的控件 没有画ROI 和缩放图像的功能 
        {
            InitializeComponent();
        }

        public HWindow Window
        {
            get
            {
                return HWindow.HalconWindow;
            }
        }

        public void DispImage(HImage image, bool isClearWindow = false)//显示图片
        {
            if (isClearWindow)
            {
                HWindow.HalconWindow.ClearWindow();
            }
            int img_width, img_height;
            int win_width, win_height;
            image.GetImageSize(out img_width, out img_height);
            win_width = HWindow.Width;
            win_height = HWindow.Height;
            double imageRatio = (double)img_width / (double)win_width;
            double windowRatio = (double)img_height / (double)win_height;
            HWindow.ImagePart = new Rectangle(0, 0, (int)(win_width * Math.Max(imageRatio, windowRatio)), (int)(win_height * Math.Max(imageRatio, windowRatio)));
            image.DispImage(HWindow.HalconWindow);
        }

        public void DispXLD(HXLDCont xld)
        {
            HWindow.HalconWindow.SetLineWidth(1);
            HWindow.HalconWindow.SetColor("blue");
            HWindow.HalconWindow.DispXld(xld);
        }
    }
}
