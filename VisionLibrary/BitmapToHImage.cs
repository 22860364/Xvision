using HalconDotNet;
using System.Drawing;
using System.Drawing.Imaging;

namespace VisionLibrary
{
    public class BitmapToHImage
    {
        /// <summary>
        /// 将Bitmap的8位灰度图转换为HImage类型的图片
        /// </summary>
        /// <param name="bitmap">传入的Bitmap格式的8位灰度图像</param>
        /// <param name="image">得到的HImage格式的图像</param>
        public static void BitmapToHImage8(Bitmap bitmap, out HImage image)
        {
            Bitmap dstImage = null;
            try
            {           
                dstImage = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format8bppIndexed);
                dstImage = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), PixelFormat.Format8bppIndexed);
                Rectangle rectangle = new Rectangle(0, 0, dstImage.Width, dstImage.Height);
                BitmapData bitmapData = bitmap.LockBits(rectangle, ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
                int pixelSize = Image.GetPixelFormatSize(dstImage.PixelFormat) / 8;
                int stride = bitmapData.Stride;//扫描宽度
                unsafe
                {
                    int count = dstImage.Height * dstImage.Width;
                    byte[] data = new byte[count];
                    byte* bptr = (byte*)bitmapData.Scan0;
                    fixed(byte* pData = data)
                    {
                        for (int i = 0; i < dstImage.Height; i++)
                        {
                            for (int j = 0; j <dstImage.Width ; j++)
                            {
                                data[i * dstImage.Width + j] = bptr[i * stride + j];
                            }
                        }
                        image = new HImage("byte", bitmap.Width, bitmap.Height, new System.IntPtr(pData));
                    }
                }               
                bitmap.UnlockBits(bitmapData);
            }
            catch
            {
                image = null;
            }
            finally
            {
                dstImage.Dispose();
            }
        }

        /// <summary>
        /// 将Bitmap的24位彩色图转换为HImage类型
        /// </summary>
        /// <param name="bitmap">24位彩色图</param>
        /// <param name="image">得到的HImage类型的图像</param>
        public static void BitmapToHImage24(Bitmap bitmap, out HImage image)
        {
            try
            {
                Rectangle rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                BitmapData bitmapData = bitmap.LockBits(rectangle, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                image = new HImage();
                image.GenImageInterleaved(bitmapData.Scan0, "bgr", bitmap.Width, bitmap.Height, 0, "byte", 0, 0, 0, 0, -1, 0);
                bitmap.UnlockBits(bitmapData);
            }
            catch
            {
                image = null;
            }
        }
    }
}
