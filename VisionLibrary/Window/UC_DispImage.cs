using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace VisionLibrary.Window
{
    public partial class UC_DispImage : UserControl
    {
        private Graphics g = null;
        private Bitmap bitmap = null;
        public UC_DispImage()
        {
            InitializeComponent();
        }

        public void DrawPoint()
        {

        }

        public void DrawLine()
        {
            
        }

        public void DrawRectangle()
        {

        }

        public void DrawRectangle2()
        {
            
        }

        private void PictureBox_Image_Paint(object sender, PaintEventArgs e)
        {
            if (bitmap == null)
            {
                bitmap = new Bitmap(PictureBox_Image.Width, PictureBox_Image.Height);
            }
            if (g == null)
            {
                g = Graphics.FromImage(bitmap);
                g.SmoothingMode = SmoothingMode.AntiAlias;
            }
            e.Graphics.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
        }
    }
}
