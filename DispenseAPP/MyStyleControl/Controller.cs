using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DispenseAPP.MyStyleControl
{
   public class Controller
    {
        private PictureBox pictureBox;
        public event Action<int, int, float, byte, byte, byte> UpdateInfoEvent;//定义鼠标移动事件
        public event Action<Size> UpdateImageSizeEvent;  //定义获取图片大小事件
        Point mouseDownPoint = new Point(0, 0);
        PointF screenDray = new PointF(0, 0);
        PointF screenPan = new PointF(0, 0);
        public Bitmap image { get; set; } = null;
        public HImage hImage { get; set; } = null;
        Size currentImageSize = new Size(0, 0);
        public List<float[]> XList = null;
        public List<float[]> YList = null;
        PointF Screen { get => new PointF(screenDray.X + screenPan.X, screenDray.Y + screenPan.Y); }
        HWindow window;
        public Controller(PictureBox _pictureBox)
        {
            this.pictureBox = _pictureBox;
            window = new HWindow(0, 0, pictureBox.Width, pictureBox.Height, pictureBox.Handle, "visible", "");
            this.pictureBox.MouseDown += PictureBox_MouseDown;
            this.pictureBox.MouseMove += PictureBox_MouseMove;
            this.pictureBox.MouseUp += PictureBox_MouseUp;
            this.pictureBox.MouseWheel += PictureBox_MouseWheel;
            this.pictureBox.Paint += PictureBox_Paint;
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 相机调用拍照时调用
        /// </summary>
        /// <param name="_bitmap"></param>
        /// <param name="_hImage"></param>
        public void DispImage(Bitmap _image, HImage _hImage)
        {
            if (_image == null) return;
            image = _image;
            hImage = _hImage;
            ModifyImageSize();
        }
        /// <summary>
        /// 调用图片路径时调用
        /// </summary>
        /// <param name="fileName"></param>
        public void DispImage(string fileName)
        {
            if (!File.Exists(fileName)) return;
            image = FileStreamReadImage(fileName);
            hImage = new HImage(fileName);
            ModifyImageSize();

        }

        private void ModifyImageSize()
        {
            currentImageSize.Width = image.Width;
            currentImageSize.Height = image.Height;            
            XList = null;
            YList = null;
            pictureBox.Invalidate();
            UpdateImageSizeEvent(new Size(currentImageSize.Width, currentImageSize.Height));
        }
        private Bitmap FileStreamReadImage(string path)
        {
            Bitmap bitmap = null;
            if (File.Exists(path))
            {
                using (FileStream fs = File.OpenRead(path))
                {
                    int fileLength = (int)fs.Length;//获得文件长度
                    byte[] imageByte = new byte[fileLength];//建立字节数组
                    fs.Read(imageByte, 0, fileLength);//按字节流读取
                    MemoryStream ms = new MemoryStream(imageByte);
                    bitmap = (Bitmap)Image.FromStream(ms);
                    fs.Close();
                    fs.Dispose();
                }
            }
            return bitmap;
        }
    }
}
