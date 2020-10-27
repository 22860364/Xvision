using HalconDotNet;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace VisionLibrary
{
    public class HImageToBitmap
    {
        [DllImport("kernel32.dll")]
        public static extern void CopyMemory(int Destination, int add, int Length);

        public void HImageToBitmap8(HImage image, out Bitmap bitmap)
        {
            try
            {
                const int Alpha = 255;
                IntPtr pointer = image.GetImagePointer1(out string type, out int width, out int height);
                bitmap = new Bitmap(width, height, PixelFormat.Format8bppIndexed);
                ColorPalette colorPalette = bitmap.Palette;//设置调色板
                for (int i = 0; i < 255; i++)
                {
                    colorPalette.Entries[i] = Color.FromArgb(Alpha, i, i, i);
                }
                bitmap.Palette = colorPalette;
                Rectangle rectangle = new Rectangle(0, 0, width, height);
                BitmapData bitmapData = bitmap.LockBits(rectangle, ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
                int pixelSize = Image.GetPixelFormatSize(bitmapData.PixelFormat) / 8;
                int[] ptr = new int[2];
                ptr[0] = bitmapData.Scan0.ToInt32();
                ptr[1] = pointer.ToInt32();
                if (width % 4 == 0)
                {
                    CopyMemory(ptr[0], ptr[1], width * height * pixelSize);
                }
                else
                {
                    for (int i = 0; i < height - 1; i++)
                    {
                        ptr[1] += width;
                        CopyMemory(ptr[0], ptr[1], width * pixelSize);
                        ptr[0] += bitmapData.Stride;//扫描宽度
                    }
                }
                bitmap.UnlockBits(bitmapData);
            }
            catch
            {
                bitmap = null;
            }
        }

        public void HImageToBitmap24(HImage image, out Bitmap bitmap)
        {
            try
            {
                image.GetImagePointer3(out IntPtr pRed, out IntPtr pGreen, out IntPtr pBlue, out string type, out int width, out int height);
                bitmap = new Bitmap(width, height, PixelFormat.Format32bppRgb);
                Rectangle rectangle = new Rectangle(0, 0, width, height);
                BitmapData bitmapData = bitmap.LockBits(rectangle, ImageLockMode.ReadWrite, PixelFormat.Format32bppRgb);
                int imageSize = width * height;
                unsafe
                {
                    byte* bptr = (byte*)bitmapData.Scan0;
                    byte* r = (byte*)pRed.ToInt64();
                    byte* g = (byte*)pGreen.ToInt64();
                    byte* b = (byte*)pBlue.ToInt64();
                    for (int i = 0; i < imageSize; i++)
                    {
                        bptr[i * 4] = b[i];
                        bptr[i * 4 + 1] = g[i];
                        bptr[i * 4 + 2] = r[i];
                        bptr[i * 4 + 3] = 255;
                    }
                }
                bitmap.UnlockBits(bitmapData);
            }
            catch
            {
                bitmap = null;
            }
        }
    }
}
