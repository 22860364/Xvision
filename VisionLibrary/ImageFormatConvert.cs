using System.Drawing;
using System.Drawing.Imaging;
using HalconDotNet;

namespace VisionLibrary
{
    public class ImageFormatConvert
    {
        public static void Bitmap8ToHImage(Bitmap bmp, out HImage hImage)
        {
            try
            {
                Rectangle rectangle = new Rectangle(0, 0, bmp.Width, bmp.Height);
                BitmapData bitmapData = bmp.LockBits(rectangle, ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
                hImage = new HImage("byte", bmp.Width, bmp.Height, bitmapData.Scan0);
                bmp.UnlockBits(bitmapData);
            }
            catch
            {
                hImage = null;
            }
        }

        public static void Bitmap24ToHImage(Bitmap bmp,out HImage hImage)
        {
            try
            {
                hImage = new HImage();
                Rectangle rectangle = new Rectangle(0, 0, bmp.Width, bmp.Height);
                BitmapData bitmapData = bmp.LockBits(rectangle, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                hImage.GenImageInterleaved(bitmapData.Scan0, "bgr", bmp.Width, bmp.Height, 0, "byte", 0, 0, 0, 0, -1, 0);
            }
            catch
            {
                hImage = null;
            }
        }
    }
}
