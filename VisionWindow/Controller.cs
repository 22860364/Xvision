using System.Drawing;
using VisionWindow.ROI;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System;
using System.IO;
using System.Collections.Generic;
using HalconDotNet;

namespace VisionWindow
{
    public class Controller //该类目前支持两种ROI 搜索ROI和屏蔽ROI 
    {
        #region 私有变量
        PictureBox pictureBox;
        Point mouseDownPoint = new Point(0, 0);
        PointF screenDray = new PointF(0, 0);
        PointF screenPan = new PointF(0, 0);
        bool IsComputerDispRectangle = true;
        Graphics g = null;
        bool imageAdaptation = false;
        Size currentImageSize = new Size(0, 0);
        float zoom;
        byte R;
        byte G;
        byte B;
        int X;
        int Y;
        public event Action<int, int, float, byte, byte, byte> UpdateInfoEvent;//定义鼠标移动事件
        public event Action<Size> UpdateImageSizeEvent;
        PointF Screen { get => new PointF(screenDray.X + screenPan.X, screenDray.Y + screenPan.Y); }
        #endregion

        #region 公共变量
        public Bitmap _Bitmap = null;
        public HImage _HImage { get; set; } = null;
        public List<float[]> XList = null;
        public List<float[]> YList = null;

        public enum MouseMode
        {
            MouseLeftDown,
            MouseMove,
        }
        #endregion

        #region 程序集变量
        /// <summary>
        /// 搜索范围
        /// </summary>
        public ShapeBase[] SearchRanges = new ShapeBase[5];

        /// <summary>
        /// 搜索对象
        /// </summary>
        public ShapeBase[] SearchObjects = new ShapeBase[5];
        #endregion

        #region 十字线 
        public bool CrossVisible { get; set; } = false;//是否显示十字线

        public Color _Color { get; set; } = Color.Red;//十字线颜色
        #endregion

        #region 显示刻度 通过数量来控制刻度的显示与否
        public int CircleNumber { get; set; } = 0;//圆形数量

        public int LinesNumber { get; set; } = 0;//直线数量

        public float ScaleGap { get; set; } = 1.5f;//刻度间距

        public float ScaleWidth { get; set; } = 1f;//刻度线宽

        public float Ratio { get; set; } = 1f;//像素比率 默认是1比1  也就是一个像素1mm
        #endregion

        public Controller(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            this.pictureBox.MouseDown += PictureBox_MouseDown;
            this.pictureBox.MouseMove += PictureBox_MouseMove;
            this.pictureBox.MouseUp += PictureBox_MouseUp;
            this.pictureBox.MouseWheel += PictureBox_MouseWheel;
            this.pictureBox.Paint += PictureBox_Paint;
        }

        #region PictureBox事件
        /// <summary>
        /// 执行鼠标按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = e.Location;//记录鼠标位置
            if (e.Button == MouseButtons.Left && !ContainsResizeRegion(SearchRanges))//鼠标左键按下并且不包含要改变大小的区域
            {
                GetAllSelectAndContains(MouseMode.MouseLeftDown, e.Location);
            }
            pictureBox.Invalidate();
        }

        /// <summary>
        /// 执行鼠标移动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//按下左键移动 执行更改区域的大小
            {
                foreach (ShapeBase item in SearchRanges)
                {
                    if (item != null && item.IsSelect)
                    {
                        PointF point = new PointF(PBToImage(e.Location).X - PBToImage(mouseDownPoint).X, PBToImage(e.Location).Y - PBToImage(mouseDownPoint).Y);
                        if (pictureBox.Cursor == Cursors.SizeAll)
                        {
                            item.ExecuteMoveROI(point);
                        }
                        else if (item.EnableResize)
                        {
                            item.ExecuteResizeROI(point);
                        }
                    }
                }
                mouseDownPoint = e.Location;
            }
            else if (e.Button == MouseButtons.Right)
            {
                screenDray.X = e.X - mouseDownPoint.X;
                screenDray.Y = e.Y - mouseDownPoint.Y;//计算差值
            }
            else if (e.Button == MouseButtons.None)//移动时没有按下任何键
            {
                ExecuteSelectNode(e.Location, SearchObjects);
                ExecuteSelectNode(e.Location, SearchRanges);//命中测试 是否移动到节点的上方
                if (!ContainsResizeRegion(SearchRanges))
                {
                    GetAllSelectAndContains(MouseMode.MouseMove, e.Location);
                }
            }
            X = Convert.ToInt32(PBToImage(e.Location).X);
            Y = Convert.ToInt32(PBToImage(e.Location).Y);
            GetRGBValue(new Point(X, Y));
            UpdateInfoEvent?.Invoke(X, Y, zoom, R, G, B);
            pictureBox.Invalidate();
        }

        /// <summary>
        /// 执行选择节点
        /// </summary>
        void ExecuteSelectNode(PointF mousePos, ShapeBase[] shapeBases)
        {
            foreach (ShapeBase item in shapeBases)
            {
                if (item != null && item.IsSelect && item.IsContain)
                {
                    pictureBox.Cursor = item.ExecuteSelectNode(mousePos, pictureBox.Cursor);
                }
            }
        }

        /// <summary>
        /// 获得所有Select和Cantains的ShapeBase
        /// </summary>
        void GetAllSelectAndContains(MouseMode mouseMode, PointF mousePos)
        {
            List<ShapeBase> shapeBases = new List<ShapeBase>();
            foreach (ShapeBase item in SearchRanges)
            {
                if (item != null && item.ExecuteShapeBaseSelectCantains(mousePos, mouseMode))
                {
                    shapeBases.Add(item);
                }
            }
            BubbleSort(shapeBases);//进行冒泡排序 两两比较 根据该Region除去相交区域的部分的面积来判断
            if (shapeBases.Count > 0)
            {
                for (int i = shapeBases.Count - 1; i >= 0; i--)
                {
                    if (mouseMode == MouseMode.MouseLeftDown)
                    {
                        SetShapeCantains(i, shapeBases, mousePos);
                        if (shapeBases[i].IsSelect)
                        {
                            shapeBases[i].IsContain = false;//在鼠标按下的情况下 如果该区域被选中 则不显示粗线
                        }
                    }
                    else if (mouseMode == MouseMode.MouseMove) 
                    {
                        SetShapeBaseSelect(i, shapeBases, mousePos);
                    }
                    if (shapeBases[i].IsSelect && shapeBases[i].IsContain || (mouseMode == MouseMode.MouseLeftDown && shapeBases[i].IsSelect))//如果该区域被选中并且显示粗线 则显示SizeAll 有一种情况是 区域被选中 但是鼠标的当前位置不处于该区域中 所以这种情况下显示手  或者 如果当前的选择模式是左键按下 并且该区域被选中的时候 鼠标的形状也显示SizeAll
                    {
                        pictureBox.Cursor = Cursors.SizeAll;
                    }
                    else if (shapeBases[i].IsContain)
                    {
                        pictureBox.Cursor = Cursors.Hand;
                    }
                }
            }
            else
            {
                pictureBox.Cursor = Cursors.Default;
            }
        }

        void SetShapeBaseSelect(int i,List<ShapeBase> shapeBases,PointF mousePos)
        {
            if (i == 0 && !ContainsOverShpae(mousePos, shapeBases))//如果该区域的面积最小 并且该位置不处于其它区域的上方 则显示粗线
            {
                shapeBases[i].IsContain = true;
            }
            else if (shapeBases[i].IsSelect && shapeBases[i].MouseOverGraphics(mousePos))
            {
                shapeBases[i].IsContain = true;
            }
            else
            {
                shapeBases[i].IsContain = false;
            }
        }

        void SetShapeCantains(int i,List<ShapeBase> shapeBases,PointF mousePos)
        {
            if (i == 0 && !ContainsOverShpae(mousePos, shapeBases))//如果该区域的面积最小 并且该位置不处于其它区域的上方 则选中
            {
                shapeBases[i].IsSelect = true;
            }
            else if (shapeBases[i].IsSelect && shapeBases[i].MouseOverGraphics(mousePos))//如果该区域被选中并且当前鼠标位置处于该区域的上方则被选中
            {
                shapeBases[i].IsSelect = true;
            }
            else
            {
                shapeBases[i].IsSelect = false;
            }
        }

        /// <summary>
        /// 当前的鼠标位置是否处于图形的上方
        /// </summary>
        /// <param name="mousePos"></param>
        /// <returns></returns>
        bool ContainsOverShpae(PointF mousePos, List<ShapeBase> shapeBases)
        {
            if (shapeBases.Count <= 1)
            {
                return false;
            }
            for (int i = 1; i < shapeBases.Count; i++)
            {
                if (shapeBases[i].MouseOverGraphics(mousePos))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 是否包含要改变大小的区域
        /// </summary>
        /// <param name="shapeBases"></param>
        /// <returns></returns>
        bool ContainsResizeRegion(ShapeBase[] shapeBases)
        {
            foreach (ShapeBase item in shapeBases)
            {
                if (item != null && item.EnableResize)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 对区域的面积减去相交的部分进行排序 索引为0表示面积最小
        /// </summary>
        /// <param name="shapeBases"></param>
        void BubbleSort(List<ShapeBase> shapeBases)
        {
            ShapeBase tempShapeBase = null;
            for (int i = 0; i < shapeBases.Count - 1; i++)
            {
                for (int j = i + 1; j < shapeBases.Count; j++)
                {
                    if (shapeBases[i].ExcludeRegion(shapeBases[j].Region) > shapeBases[j].ExcludeRegion(shapeBases[i].Region))
                    {
                        tempShapeBase = shapeBases[i];
                        shapeBases[i] = shapeBases[j];
                        shapeBases[j] = tempShapeBase;
                    }
                }
            }
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (_Bitmap == null)
            {
                return;
            }
            Bitmap img = new Bitmap(pictureBox.Width, pictureBox.Height);
            g = Graphics.FromImage(img);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.Clear(pictureBox.BackColor);
            if (_Bitmap != null)
            {
                g.DrawImage(_Bitmap, Screen.X, Screen.Y, currentImageSize.Width * zoom, currentImageSize.Height * zoom);
            }
            DrawSearchShieldRegion(g);
            DrawAuxiliaryLine(g);
            DrawPoint(g);
            e.Graphics.DrawImage(img, 0, 0, img.Width, img.Height);
            g.Dispose();
            img.Dispose();
            GC.Collect(1);//强制对第0代到第1代进行垃圾回收
        }

        private void PictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            PointF mouseInImage = PBToImage(e.Location);
            if (e.Delta > 0)
            {
                zoom *= 1.05f * Math.Abs(e.Delta) / 100.0f;
            }
            else if (e.Delta < 0)
            {
                zoom /= 1.05f * Math.Abs(e.Delta) / 100.0f;
            }
            screenPan.X += e.X - ImageToPB(mouseInImage).X;
            screenPan.Y += e.Y - ImageToPB(mouseInImage).Y;
            UpdateInfoEvent?.Invoke(X, Y, zoom, R, G, B);
            pictureBox.Invalidate();
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                screenPan.X += screenDray.X;
                screenPan.Y += screenDray.Y;
                screenDray.X = 0;
                screenDray.Y = 0;
            }
            pictureBox.Invalidate();
        }
        #endregion

        /// <summary>
        /// 画搜索框 屏蔽框
        /// </summary>
        /// <param name="g"></param>
        void DrawSearchShieldRegion(Graphics g)
        {
            foreach (ShapeBase item in SearchRanges)
            {
                if (item != null)
                {
                    item.Draw(g, zoom, Screen);
                }
            }
            foreach (ShapeBase item in SearchObjects)
            {
                if (item != null)
                {
                    item.Draw(g, zoom, Screen);
                }
            }
        }

        void DrawPoint(Graphics g)
        {
            if (XList != null && YList != null)
            {
                for (int j = 0; j < XList.Count; j++)
                {
                    List<PointF> pointFList = new List<PointF>();
                    for (int i = 0; i < XList[j].Length; i++)
                    {
                        PointF pointF = new PointF(ImageToPB(XList[j][i], XYTypeEnum.X), ImageToPB(YList[j][i], XYTypeEnum.Y));
                        pointFList.Add(pointF);
                    }
                    g.DrawLines(new Pen(Color.LightGreen, 2), pointFList.ToArray());
                }
            }
        }

        public void DispXLDCont(List<float[]> xList, List<float[]> yList)
        {
            XList = xList;
            YList = yList;
            pictureBox.Invalidate();
        }

        void GetRGBValue(Point point)
        {
            try
            {
                if (_Bitmap != null)
                {
                    if (point.X >= 0 && point.X < _Bitmap.Width && point.Y >= 0 && point.Y < _Bitmap.Height)
                    {
                        Color pointColor = _Bitmap.GetPixel(point.X, point.Y);
                        R = pointColor.R;
                        G = pointColor.G;
                        B = pointColor.B;
                    }
                }
            }
            catch
            {
            }
        }

        void DrawAuxiliaryLine(Graphics g)//画辅助线
        {
            if (_Bitmap != null)
            {
                Pen pen = new Pen(_Color, 1);
                if (CrossVisible)
                {
                    g.DrawLine(pen, ImageToPB(new PointF(currentImageSize.Width / 2, 0)), ImageToPB(new PointF(currentImageSize.Width / 2, currentImageSize.Height)));//竖线
                    g.DrawLine(pen, ImageToPB(new PointF(0, currentImageSize.Height / 2)), ImageToPB(new PointF(currentImageSize.Width, currentImageSize.Height / 2)));//横线 
                }
                PointF centerInImage = new PointF(currentImageSize.Width / 2, currentImageSize.Height / 2);//获得图像的中心坐标
                for (int i = 1; i <= CircleNumber; i++)//画圆形刻度
                {
                    RectangleF rectangleF = new RectangleF(ImageToPB(new PointF(centerInImage.X - (i * (ScaleGap / Ratio)), centerInImage.Y - (i * (ScaleGap / Ratio)))), new SizeF(ScaleGap * 2 / Ratio * i * zoom, ScaleGap * 2 / Ratio * i * zoom));
                    g.DrawEllipse(pen, rectangleF);
                }
                for (int i = 1; i <= LinesNumber; i++)//画直线刻度
                {
                    if (i > CircleNumber)
                    {
                        g.DrawLine(pen, ImageToPB(new PointF(centerInImage.X - (ScaleWidth / 2 / Ratio), centerInImage.Y - (i * (ScaleGap / Ratio)))), ImageToPB(new PointF(centerInImage.X + (ScaleWidth / 2 / Ratio), centerInImage.Y - (i * (ScaleGap / Ratio)))));//上
                        g.DrawLine(pen, ImageToPB(new PointF(centerInImage.X - (ScaleWidth / 2 / Ratio), centerInImage.Y + (i * (ScaleGap / Ratio)))), ImageToPB(new PointF(centerInImage.X + (ScaleWidth / 2 / Ratio), centerInImage.Y + (i * (ScaleGap / Ratio)))));//下    
                        g.DrawLine(pen, ImageToPB(new PointF(centerInImage.X - (i * (ScaleGap / Ratio)), centerInImage.Y - (ScaleWidth / 2 / Ratio))), ImageToPB(new PointF(centerInImage.X - (i * (ScaleGap / Ratio)), centerInImage.Y + (ScaleWidth / 2 / Ratio))));//左
                        g.DrawLine(pen, ImageToPB(new PointF(centerInImage.X + (i * (ScaleGap / Ratio)), centerInImage.Y - (ScaleWidth / 2 / Ratio))), ImageToPB(new PointF(centerInImage.X + (i * (ScaleGap / Ratio)), centerInImage.Y + (ScaleWidth / 2 / Ratio))));//右
                    }
                }
                pen.Dispose();
            }
        }

        #region 图片相关
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

        private void ComputerImageDispRectangle()//最终求左顶点和大小
        {
            if (_Bitmap != null && (IsComputerDispRectangle || imageAdaptation))
            {
                zoom = Math.Min(pictureBox.ClientRectangle.Width * 1.0f / currentImageSize.Width, pictureBox.ClientRectangle.Height * 1.0f / currentImageSize.Height);
                screenPan.X = (pictureBox.ClientRectangle.Width - (currentImageSize.Width * zoom)) / 2;
                screenPan.Y = (pictureBox.ClientRectangle.Height - (currentImageSize.Height * zoom)) / 2;
                if (IsComputerDispRectangle)
                {
                    IsComputerDispRectangle = false;
                }
                if (imageAdaptation)
                {
                    imageAdaptation = false;
                }
            }
        }
        #endregion

        #region 坐标系转换
        private PointF PBToImage(PointF MousePos)//PB坐标系转化为图像坐标系
        {
            if (zoom == 0)
            {
                return new PointF(0, 0);
            }
            PointF pointF = new PointF((MousePos.X - Screen.X) / zoom, (MousePos.Y - Screen.Y) / zoom);
            return pointF;
        }

        private PointF ImageToPB(PointF imagePos)//图像坐标系转换为PB坐标系
        {
            return new PointF(imagePos.X * zoom + Screen.X, imagePos.Y * zoom + Screen.Y);
        }

        PointF[] ImageToPB(PointF[] imagePos)
        {
            List<PointF> pos = new List<PointF>();
            foreach (PointF item in imagePos)
            {
                pos.Add(ImageToPB(item));
            }
            return pos.ToArray();
        }

        float ImageToPB(float pos, XYTypeEnum xyType)
        {
            float value = 0f;
            switch (xyType)
            {
                case XYTypeEnum.X:
                    value = pos * zoom + Screen.X;
                    break;
                case XYTypeEnum.Y:
                    value = pos * zoom + Screen.Y;
                    break;
            }
            return value;
        }

        enum XYTypeEnum
        {
            X,
            Y,
        }
        #endregion

        #region 显示图像
        public void DispImage(Bitmap _image, HImage _hImage)//当传入图像时 改变图像的Size信息
        {
            if (_image == null)
            {
                return;
            }
            _Bitmap = _image;
            _HImage = _hImage;
            currentImageSize.Width = _Bitmap.Width;
            currentImageSize.Height = _Bitmap.Height;
            ComputerImageDispRectangle();
            XList = null;
            YList = null;
            pictureBox.Invalidate();
            UpdateImageSizeEvent(new Size(currentImageSize.Width, currentImageSize.Height));
        }

        public void DispImage(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return;
            }
            _Bitmap = FileStreamReadImage(fileName);
            _HImage = new HImage(fileName); ;
            currentImageSize.Width = _Bitmap.Width;
            currentImageSize.Height = _Bitmap.Height;
            ComputerImageDispRectangle();
            XList = null;
            YList = null;
            pictureBox.Invalidate();
            UpdateImageSizeEvent(new Size(currentImageSize.Width, currentImageSize.Height));
        }

        public Bitmap RotateImage(Bitmap bitmap, float angle)
        {
            Bitmap returnBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            Graphics g = Graphics.FromImage(returnBitmap);
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.TranslateTransform((float)bitmap.Width / 2, (float)bitmap.Height / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-(float)bitmap.Width / 2, -(float)bitmap.Height / 2);
            g.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
            return returnBitmap;
        }

        /// <summary>
        /// 图像自适应
        /// </summary>
        public void ImageAdaptation()
        {
            imageAdaptation = true;
            ComputerImageDispRectangle();
            pictureBox.Invalidate();
        }
        #endregion

        /// <summary>
        /// 为搜索范围 搜索对象 屏蔽范围设置对应的ROI
        /// </summary>
        /// <param name="regionType"></param>
        /// <param name="shapeBase"></param>
        //public void SetRegionType(string regionType, Color linecolor, float ratio, ref ShapeBase shapeBase)
        //{
        //    switch (regionType)
        //    {
        //        case "矩形":
        //            shapeBase = new ShapeRectangle(CalculatePostion.GetPointCollectionFromImageSize(_Bitmap.Size, ratio), linecolor);//像素坐标
        //            break;
        //        case "无":
        //            shapeBase = null;
        //            break;
        //    }
        //    pictureBox.Invalidate();
        //}

        /// <summary>
        /// 执行裁剪
        /// </summary>
        public void ExecuteClicp()
        {
            for (int i = 1; i < SearchRanges.Length; i++)
            {
                if (SearchRanges[i] != null)
                {
                    SearchRanges[0].Region.Exclude(SearchRanges[i].Region);
                }
            }
            pictureBox.Invalidate();
        }
    }
}
