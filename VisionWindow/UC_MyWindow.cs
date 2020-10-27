using System.Drawing;
using System.Windows.Forms;
using System;

namespace VisionWindow
{
    public partial class UC_MyWindow : UserControl
    {
        public Controller Control { get; }
        public UC_MyWindow()
        {
            InitializeComponent();
            Control = new Controller(PB_Window);
            Control.UpdateImageSizeEvent += Control_UpdateImageSizeEvent;
            Control.UpdateInfoEvent += Control_UpdateInfoEvent;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void Control_UpdateInfoEvent(int X, int Y, float Zoom, byte R, byte G, byte B)
        {
            Tslbl_X.Text = X.ToString();
            Tslbl_Y.Text = Y.ToString();
            Tslbl_Zoom.Text = Zoom.ToString("f3");
            Tslbl_R.Text = R.ToString();
            Tslbl_G.Text = G.ToString();
            Tslbl_B.Text = B.ToString();
        }

        private void Control_UpdateImageSizeEvent(Size size)
        {
            Tslbl_Width.Text = size.Width.ToString();
            Tslbl_Height.Text = size.Height.ToString();
        }
      
        private void PB_Window_SizeChanged(object sender, EventArgs e)
        {
            Control.ImageAdaptation();
        }

    }
}
