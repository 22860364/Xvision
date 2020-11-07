using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;

namespace DispenseAPP.MyStyleControl
{
    public partial class UC_MyWindows : UserControl
    {
        HWindow myWindow;
        public Controller Control { get; }
        public UC_MyWindows()
        {
            InitializeComponent();
            Control = new Controller(PB_Window);
            Control.UpdateImageSizeEvent += Control_UpdateImageSizeEvent;
            Control.UpdateInfoEvent += Control_UpdateInfoEvent;
        }

        private void Control_UpdateImageSizeEvent(Size size)
        {
            Tslbl_Width.Text = size.Width.ToString();
            Tslbl_Height.Text = size.Height.ToString();
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
    }
}
