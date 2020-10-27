using System;
using System.Windows.Forms;
using HalconDotNet;
using System.Drawing;
using System.Collections.Generic;
using VisionLibrary.ROI;

namespace DispenseAPP
{
    public delegate void DrawFinshDelegate(DrawROIable region);

    public partial class UC_Image : UserControl
    {
        public event Action<DrawROIable> DrawFinshEvent;//画ROI结束事件
        public event Action StartDrawEvent;//画ROI开始事件

        public UC_Image()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);//自行绘制,不通过操作系统绘制
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);//禁止擦除背景
            SetStyle(ControlStyles.DoubleBuffer, true);//双缓冲          
        }

        public HWindow Window { get { return HWindow.HalconWindow; } }//窗口句柄
        public HImage Image;//当前窗口的图片
        public Dictionary<HObject, string> hobjectList = new Dictionary<HObject, string>();//显示的集合和对应的颜色 

        #region 画ROI
        private void DrawLine()//画线段
        {
            DrawPublicMethod();
            HRegion region = new HRegion();
            HWindow.HalconWindow.DrawLine(out double row1, out double column1, out double row2, out double column2);
            region.GenRegionLine(row1, column1, row2, column2);
            HWindow.HalconWindow.DispRegion(region);
            DrawFinshEvent(new DrawLine(row1, column1, row2, column2));
        }

        private void DrawEllipse()//画椭圆
        {
            DrawPublicMethod();
            HRegion region = new HRegion();
            HWindow.HalconWindow.DrawEllipse(out double row, out double column, out double phi, out double radius1, out double radius2);
            region.GenEllipse(row, column, phi, radius1, radius2);
            HWindow.HalconWindow.DispRegion(region);
            DrawFinshEvent(new DrawEllipse(row, column, phi, radius1, radius2));
        }

        private void DrawCircle()
        {
            DrawPublicMethod();
            HRegion region = new HRegion();
            HWindow.HalconWindow.DrawCircle(out double row, out double column, out double radius);
            region.GenCircle(row, column, radius);
            HWindow.HalconWindow.DispRegion(region);
            DrawFinshEvent(new DrawCircle(row, column, radius));
        }

        private void DrawRectangle()
        {
            DrawPublicMethod();
            HRegion region = new HRegion();
            HWindow.HalconWindow.DrawRectangle1(out double row1, out double column1, out double row2, out double column2);
            region.GenRectangle1(row1, column1, row2, column2);
            HWindow.HalconWindow.DispRegion(region);
            DrawFinshEvent(new DrawRectangle1(row1, column1, row2, column2));
        }

        private void DrawRectangle2()
        {
            DrawPublicMethod();
            HRegion region = new HRegion();
            HWindow.HalconWindow.DrawRectangle2(out double row1, out double column1, out double phi, out double length1, out double length2);
            region.GenRectangle2(row1, column1, phi, length1, length2);
            HWindow.HalconWindow.DispRegion(region);
            DrawFinshEvent(new DrawRectangle2(row1, column1, phi, length1, length2));
        }

        public void DrawPublicMethod()
        {
            StartDrawEvent();//触发开始画事件
            DispImage(Image, true);
            HWindow.HalconWindow.SetColor("blue");
            HWindow.HalconWindow.SetDraw("margin");
        }
        #endregion

        public void DispObject(HObject obj, bool isClearList = false, string color = "green")
        {
            if (isClearList == true)
            {
                hobjectList.Clear();//清空显示集合
            }
            hobjectList.Add(obj.Clone(), color);
            HWindow.Invalidate();
        }

        public void DispImage(HImage image, bool isClearWindow = false)//显示图片
        {
            if (Image != null && Image.IsInitialized())
            {
                Image.Dispose();
                GC.Collect();//对所有代进行强制收集
            }
            Image = image.Clone();
            int win_width, win_height;
            image.GetImageSize(out int img_width, out int img_height);
            win_width = HWindow.Width;
            win_height = HWindow.Height;
            double imageRatio = img_width / (double)win_width;
            double windowRatio = img_height / (double)win_height;
            HWindow.ImagePart = new Rectangle(0, 0, (int)(win_width * Math.Max(imageRatio, windowRatio)), (int)(win_height * Math.Max(imageRatio, windowRatio)));
            if (isClearWindow)
            {
                HWindow.HalconWindow.ClearWindow();
            }
            image.DispImage(HWindow.HalconWindow);
        }

        private void HWindow_Paint(object sender, PaintEventArgs e)
        {
            if (Image != null && Image.IsInitialized())
            {
                DispImage(Image, true);//显示图像
            }
            foreach (KeyValuePair<HObject, string> item in hobjectList)//显示HObject
            {
                if (item.Key != null && item.Key.IsInitialized())
                {
                    HWindow.HalconWindow.SetColor(item.Value);
                    HWindow.HalconWindow.DispObj(item.Key);
                }
            }
        }
    }
}
