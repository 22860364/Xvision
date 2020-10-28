using DispenseAPP.Tools_Location.ProgramDispensePath.DisplayImagePath;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GDI_
{
    public partial class DrawMap : UserControl
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public DrawMap()
        {
            InitializeComponent();
            pictureBox1.MouseWheel += PictureBox1_MouseWheel;//注册鼠标滚轮事件
        }

        #region 鼠标事件
        /// <summary>
        /// 当操作鼠标滚轮时执行
        /// </summary>
        /// <param name="sender"></param> 
        /// <param name="e"></param>
        private void PictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            PointF mousePosInModel = CanvasToModel(new PointF(e.X, e.Y));//将鼠标在画布中的坐标转换为模型坐标
            float zoomDelta = 1.05f * Math.Abs(e.Delta) / 100.0f;
            if (e.Delta < 0)
            {
                if (zoom >= minZoom)
                {
                    zoom /= zoomDelta;
                }
            }
            else
            {
                if (zoom <= maxZoom)
                {
                    zoom *= zoomDelta;
                }
            }
            screenPan.X += e.X - ModelToCanvas(mousePosInModel).X;
            screenPan.Y += e.Y - ModelToCanvas(mousePosInModel).Y;
            pictureBox1.Invalidate();
        }

        /// <summary>
        /// 按下鼠标按钮时触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Cursor = Cursors.Hand;
                mouseDownPoint.X = e.X;
                mouseDownPoint.Y = e.Y;
            }
        }

        /// <summary>
        /// 释放鼠标按钮时触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Cursor = Cursors.Default;
                screenPan.X += screenDray.X;
                screenPan.Y += screenDray.Y;
                screenDray.X = 0;
                screenDray.Y = 0;
                bmpImage = null;
                g = null;
            }
            pictureBox1.Invalidate();
        }

        /// <summary>
        /// 鼠标指针移动时触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                screenDray.X = e.X - mouseDownPoint.X;
                screenDray.Y = e.Y - mouseDownPoint.Y;
                pictureBox1.Invalidate();
            }
            Tslb_X_Pos.Text = ((int)CanvasToModel(new PointF(e.X, e.Y)).X).ToString();
            Tslb_Y_Pos.Text =  ((int)CanvasToModel(new PointF(e.X, e.Y)).Y).ToString();
        }
        #endregion

        #region 私有属性
        private PointF ScreenPan
        {
            get
            {
                return new PointF(screenPan.X + screenDray.X, screenPan.Y + screenDray.Y);
            }
        }
        #endregion

        #region 坐标转换
        /// <summary>
        /// 画布坐标转为模型坐标
        /// </summary>
        /// <param name="pointInCanvas"></param>
        /// <returns></returns>
        private PointF CanvasToModel(PointF pointInCanvas)
        {
            return new PointF((pointInCanvas.X - ScreenPan.X) / zoom, (pointInCanvas.Y - ScreenPan.Y) / zoom);
        }

        /// <summary>
        /// 模型坐标转为画布坐标
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private float ModelToCanvas(float value)
        {
            return value * zoom;
        }

        /// <summary>
        /// 模型坐标转为画布坐标
        /// </summary>
        /// <param name="pointInModel"></param>
        /// <returns></returns>
        private PointF ModelToCanvas(PointF pointInModel)
        {
            return new PointF(pointInModel.X * zoom + ScreenPan.X, pointInModel.Y * zoom + ScreenPan.Y);
        }
        #endregion



        #region 私有变量
        /// <summary>
        /// 画图对象
        /// </summary>
        private Graphics g;
        /// <summary>
        /// 图像对象
        /// </summary>
        private Bitmap bmpImage = null;
        /// <summary>
        /// 当前比列
        /// </summary>
        private float zoom = 1.0f;
        /// <summary>
        /// 最小比列
        /// </summary>
        private float minZoom = 1e-4f;
        /// <summary>
        /// 最大比列
        /// </summary>
        private float maxZoom = 1e4f;
        /// <summary>
        /// 鼠标右键按下累计的移动量
        /// </summary>
        private PointF screenPan = new PointF();
        /// <summary>
        /// 鼠标右键按下单次的移动量
        /// </summary>
        private PointF screenDray = new PointF();
        /// <summary>
        /// 按下鼠标时的坐标
        /// </summary>
        private PointF mouseDownPoint = new PointF();
        /// <summary>
        /// 显示网格
        /// </summary>
        private bool isGrid;
        /// <summary>
        /// 显示捕获点
        /// </summary>
        private bool isCapturePoint ;
        /// <summary>
        /// 自适应
        /// </summary>
        private bool isAutoSize;
        /// <summary>
        /// 点胶轨迹列表
        /// </summary>
        private List<PathStruct> pathList = new List<PathStruct>();
        /// <summary>
        /// 计算圆得到的中心
        /// </summary>
        private PointF circleCenter = new PointF();
        /// <summary>
        /// 计算圆得到的半径
        /// </summary>
        private float radius;
        /// <summary>
        /// 节点的大小
        /// </summary>
        private int capturePointSize = 6;
        /// <summary>
        /// X方向差值
        /// </summary>
        private float xDirDifferValue;
        /// <summary>
        /// Y方向差值
        /// </summary>
        private float yDirDifferValue;
        /// <summary>
        /// 显示图像的矩形
        /// </summary>
        private Rectangle dispRect;
        #endregion

        /// <summary>
        /// X方向的差值
        /// </summary>
        public float XDirDifferValue
        {
            get
            {
                return xDirDifferValue;
            }
            set
            {
                xDirDifferValue = value;
            }
        }

        /// <summary>
        /// Y方向的差值
        /// </summary>
        public float YDirDifferValue
        {
            get
            {
                return yDirDifferValue;
            }
            set
            {
                yDirDifferValue = value;
            }
        }

        #region 私有结构
        /// <summary>
        /// 轨迹结构
        /// </summary>
        private struct PathStruct
        {
            public string PathType;
            public float StartX;
            public float StartY;
            public float CenterX;
            public float CenterY;
            public float EndX;
            public float EndY;
            public bool select;
        }
        #endregion

        /// <summary>
        /// 控件需要重新绘制时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (bmpImage == null)
            {
                bmpImage = new Bitmap(pictureBox1.Width + Convert.ToInt32(Math.Abs(screenPan.X)), pictureBox1.Height + Convert.ToInt32(Math.Abs(screenPan.Y)));
            }
            if (g == null)
            {
                g = Graphics.FromImage(bmpImage);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }
            g.Clear(pictureBox1.BackColor);
            for (int i = 0; i < pathList.Count; i++)
            {
                switch (pathList[i].PathType)
                {
                    case "起点":
                        DrawStartPoint(new PointF(pathList[i].StartX, pathList[i].StartY), pathList[i].select);
                        break;
                    case "直线":
                        DrawLine(new PointF(pathList[i].StartX, pathList[i].StartY), new PointF(pathList[i].EndX, pathList[i].EndY), pathList[i].select);
                        break;
                    case "圆弧":
                        ComputerArc(new PointF(pathList[i].StartX, pathList[i].StartY), new PointF(pathList[i].CenterX, pathList[i].CenterY), new PointF(pathList[i].EndX, pathList[i].EndY), pathList[i].select);
                        break;
                    case "圆":
                        ComputerCircle(new PointF(pathList[i].StartX, pathList[i].StartY), new PointF(pathList[i].CenterX, pathList[i].CenterY), new PointF(pathList[i].EndX, pathList[i].EndY), ref circleCenter, ref radius);
                        DrawCircle(circleCenter, radius, pathList[i].select);
                        break;
                }
            }
            DrawGrid(g);
            dispRect = new Rectangle(0, 0, bmpImage.Width, bmpImage.Height);
            e.Graphics.DrawImage(bmpImage, dispRect);
        }

        /// <summary>
        /// 添加轨迹
        /// </summary>
        public void AddPath(string pathType, bool select, float startX, float startY, float endX = 0, float endY = 0, float centerX = 0, float centerY = 0)
        {
            PathStruct pathStruct = new PathStruct();
            pathStruct.PathType = pathType;
            pathStruct.StartX = startX;
            pathStruct.StartY = startY;
            pathStruct.CenterX = centerX;
            pathStruct.CenterY = centerY;
            pathStruct.EndX = endX;
            pathStruct.EndY = endY;
            pathStruct.select = select;
            pathList.Add(pathStruct);
            pictureBox1.Invalidate();
        }

        /// <summary>
        /// 删除轨迹
        /// </summary>
        public void DelPath()
        {
            pathList.Clear();
            pictureBox1.Invalidate();
        }

        public void ComputerCircle(PointF start, PointF center, PointF end, ref PointF circleCenter, ref float radius)
        {
            double u = (center.Y - start.Y) / (center.X - start.X);
            double v = (end.Y - center.Y) / (end.X - center.X);
            double w = 0.5 * (start.Y + center.Y) + 0.5 * (start.X + center.X) / ((center.Y - start.Y) / (center.X - start.X));
            double k = 0.5 * (center.Y + end.Y) + 0.5 * (center.X + end.X) / ((end.Y - center.Y) / (end.X - center.X));
            circleCenter.X = Convert.ToSingle((k - w) / (1 / v - 1 / u));
            circleCenter.Y = Convert.ToSingle((w - k) / u / (1 / v - 1 / u) + w);
            radius = Convert.ToSingle(Math.Sqrt(Math.Pow((start.Y - circleCenter.Y), 2) + Math.Pow((start.X - circleCenter.X), 2)));
        }

        public void DrawCircle(PointF center, float radius, bool select)// 画圆
        {
            PointF centerInCanvas = ModelToCanvas(center);
            float radiusInCanvas = ModelToCanvas(radius);
            if (select == true)
            {
                g.DrawEllipse(new Pen(Color.Green, 1), centerInCanvas.X - radiusInCanvas, centerInCanvas.Y - radiusInCanvas, radiusInCanvas * 2, radiusInCanvas * 2);
            }
            else
            {
                g.DrawEllipse(new Pen(Color.Red, 1), centerInCanvas.X - radiusInCanvas, centerInCanvas.Y - radiusInCanvas, radiusInCanvas * 2, radiusInCanvas * 2);
            }
            if (isCapturePoint == true)//画节点
            {
                if (select == true)
                {
                    //上和下
                    g.FillRectangle(Brushes.Green, centerInCanvas.X - capturePointSize / 2, centerInCanvas.Y - radiusInCanvas - capturePointSize / 2, capturePointSize, capturePointSize);
                    g.FillRectangle(Brushes.Green, centerInCanvas.X - capturePointSize / 2, centerInCanvas.Y + radiusInCanvas - capturePointSize / 2, capturePointSize, capturePointSize);
                    //左和右
                    g.FillRectangle(Brushes.Green, centerInCanvas.X - radiusInCanvas - capturePointSize / 2, centerInCanvas.Y - capturePointSize / 2, capturePointSize, capturePointSize);
                    g.FillRectangle(Brushes.Green, centerInCanvas.X + radiusInCanvas - capturePointSize / 2, centerInCanvas.Y - capturePointSize / 2, capturePointSize, capturePointSize);
                }
                else
                {
                    //上和下
                    g.FillRectangle(Brushes.Red, centerInCanvas.X - capturePointSize / 2, centerInCanvas.Y - radiusInCanvas - capturePointSize / 2, capturePointSize, capturePointSize);
                    g.FillRectangle(Brushes.Red, centerInCanvas.X - capturePointSize / 2, centerInCanvas.Y + radiusInCanvas - capturePointSize / 2, capturePointSize, capturePointSize);
                    //左和右
                    g.FillRectangle(Brushes.Red, centerInCanvas.X - radiusInCanvas - capturePointSize / 2, centerInCanvas.Y - capturePointSize / 2, capturePointSize, capturePointSize);
                    g.FillRectangle(Brushes.Red, centerInCanvas.X + radiusInCanvas - capturePointSize / 2, centerInCanvas.Y - capturePointSize / 2, capturePointSize, capturePointSize);
                }
            }
        }

        /// <summary>
        /// 画直线
        /// </summary>
        public void DrawLine(PointF startPoint, PointF endPoint, bool select)
        {
            PointF startInCanvas = ModelToCanvas(startPoint);
            PointF endInCanvas = ModelToCanvas(endPoint);
            if (select == true)
            {
                g.DrawLine(Pens.Green, startInCanvas, endInCanvas);
            }
            else
            {
                g.DrawLine(Pens.Red, startInCanvas, endInCanvas);
            }

            if (isCapturePoint == true)
            {
                if (select == true)
                {
                    g.FillRectangle(Brushes.Green, endInCanvas.X - capturePointSize / 2, endInCanvas.Y - capturePointSize / 2, capturePointSize, capturePointSize);
                }
                else
                {
                    g.FillRectangle(Brushes.Red, endInCanvas.X - capturePointSize / 2, endInCanvas.Y - capturePointSize / 2, capturePointSize, capturePointSize);
                }
            }
        }

        /// <summary>
        /// 计算圆弧
        /// </summary>
        public void ComputerArc(PointF start, PointF center, PointF end, bool select)
        {
            //三个点 O为原点 A为圆弧起点 B为圆弧终点
            float radius = 0;
            PointF PointA = new PointF();
            PointF PointB = new PointF();
            PointF PointC = new PointF();
            PointF PointO = new PointF();
            PointA.X = start.X; PointA.Y = start.Y;
            PointB.X = center.X; PointB.Y = center.Y;
            PointC.X = end.X; PointC.Y = end.Y;
            ComputerCircle(PointA, PointB, PointC, ref PointO, ref radius);
            double angle1, angle2, angle3;
            double sinValue1, cosValue1, sinValue2, cosValue2, sinValue3, cosValue3;

            sinValue1 = (start.Y - PointO.Y) / radius;
            cosValue1 = (start.X - PointO.X) / radius;
            if (cosValue1 >= 0.99999)
            {
                cosValue1 = 0.99999;
            }
            if (cosValue1 <= -0.99999)
            {
                cosValue1 = -0.99999;
            }
            angle1 = Math.Acos(cosValue1);
            angle1 = angle1 / 3.14 * 180;
            if (sinValue1 < -0.05)
            {
                angle1 = 360 - angle1;
            }

            sinValue2 = (center.Y - PointO.Y) / radius;
            cosValue2 = (center.X - PointO.X) / radius;
            if (cosValue2 >= 0.99999)
            {
                cosValue2 = 0.99999;
            }
            if (cosValue2 <= -0.99999)
            {
                cosValue2 = -0.99999;
            }
            angle2 = Math.Acos(cosValue2);
            angle2 = angle2 / 3.14 * 180;
            if (sinValue2 < -0.05)
            {
                angle2 = 360 - angle2;
            }

            sinValue3 = (end.Y - PointO.Y) / radius;
            cosValue3 = (end.X - PointO.X) / radius;
            if (cosValue3 >= 0.99999)
            {
                cosValue3 = 0.99999;
            }
            if (cosValue3 <= -0.99999)
            {
                cosValue3 = -0.99999;
            }
            angle3 = Math.Acos(cosValue3);
            angle3 = angle3 / 3.14 * 180;
            if (sinValue3 < -0.05)
            {
                angle3 = 360 - angle3;
            }

            bool PosDown = false;
            double Delta13;
            if (angle1 < angle3)
            { Delta13 = angle3 - angle1; }
            else
            {
                Delta13 = angle3 - angle1 + 360;
            }
            double Delta12;
            if (angle1 < angle2)
            {
                Delta12 = angle2 - angle1;
            }
            else
            {
                Delta12 = angle2 - angle1 + 360;
            }
            if (Delta13 > Delta12)
            {
                PosDown = true;
            }
            else
                PosDown = false;
            if (PosDown)
            {
                if (angle3 > angle1)
                {
                    DrawArc(new PointF(PointO.X, PointO.Y), radius, angle1, angle3 - angle1, PointB, PointC, select);
                }

                else
                {
                    DrawArc(new PointF(PointO.X, PointO.Y), radius, angle1, angle3 - angle1 + 360, PointB, PointC, select);
                }
            }
            else
            {
                if (angle1 > angle3)
                {
                    DrawArc(new PointF(PointO.X, PointO.Y), radius, angle3, angle1 - angle3, PointB, PointC, select);
                }
                else
                {
                    DrawArc(new PointF(PointO.X, PointO.Y), radius, angle3, angle1 - angle3 + 360, PointB, PointC, select);
                }
            }
        }

        /// <summary>
        /// 画圆弧
        /// </summary>
        public void DrawArc(PointF center, float radius, double startAngle, double sweepAngle, PointF centerPoint, PointF endPoint, bool select)
        {
            PointF centerInCanvas = ModelToCanvas(center);
            double radiusInCanvas = ModelToCanvas(radius);
            PointF centerPointInCanvas = ModelToCanvas(centerPoint);
            PointF endPointInCnavas = ModelToCanvas(endPoint);
            if (radiusInCanvas > 0)
            {
                if (select == true)
                {
                    g.DrawArc(Pens.Green, (float)(centerInCanvas.X - radiusInCanvas), (float)(centerInCanvas.Y - radiusInCanvas), (float)radiusInCanvas * 2, (float)radiusInCanvas * 2, (float)(startAngle), (float)(sweepAngle));
                }
                else
                {
                    g.DrawArc(Pens.Red, (float)(centerInCanvas.X - radiusInCanvas), (float)(centerInCanvas.Y - radiusInCanvas), (float)radiusInCanvas * 2, (float)radiusInCanvas * 2, (float)(startAngle), (float)(sweepAngle));
                }
                if (isCapturePoint == true)
                {
                    if (select == true)
                    {
                        g.FillRectangle(Brushes.Green, centerPointInCanvas.X - capturePointSize / 2, centerPointInCanvas.Y - capturePointSize / 2, capturePointSize, capturePointSize);
                        g.FillRectangle(Brushes.Green, endPointInCnavas.X - capturePointSize / 2, endPointInCnavas.Y - capturePointSize / 2, capturePointSize, capturePointSize);
                    }
                    else
                    {
                        g.FillRectangle(Brushes.Red, centerPointInCanvas.X - capturePointSize / 2, centerPointInCanvas.Y - capturePointSize / 2, capturePointSize, capturePointSize);
                        g.FillRectangle(Brushes.Red, endPointInCnavas.X - capturePointSize / 2, endPointInCnavas.Y - capturePointSize / 2, capturePointSize, capturePointSize);
                    }
                }
            }
        }

        /// <summary>
        /// 画起点
        /// </summary>
        public void DrawStartPoint(PointF startPoint, bool select)
        {
            PointF startInCanvas = ModelToCanvas(startPoint);
            if (select == true)
            {
                g.FillEllipse(Brushes.Green, startInCanvas.X - capturePointSize / 2, startInCanvas.Y - capturePointSize / 2, capturePointSize, capturePointSize);
            }
            else
            {
                g.FillEllipse(Brushes.Red, startInCanvas.X - capturePointSize / 2, startInCanvas.Y - capturePointSize / 2, capturePointSize, capturePointSize);
            }
        }

        /// <summary>
        /// 画网格
        /// </summary>
        private void DrawGrid(Graphics graphics)
        {
            Pen gridPen = new Pen(Color.DimGray, 1);
            gridPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            if (isGrid == true)
            {
                //画横线
                for (int i = 0; i < bmpImage.Height; i += 25)
                {
                    graphics.DrawLine(gridPen, new Point(0, i), new Point(bmpImage.Width, i));
                }
                //画竖线
                for (int i = 0; i < bmpImage.Width; i += 25)
                {
                    graphics.DrawLine(gridPen, new Point(i, 0), new Point(i, bmpImage.Height));
                }
            }
        }

        /// <summary>
        /// 画坐标系
        /// </summary>
        private void DrawCoordinate()
        {
            g.DrawLine(Pens.Yellow, this.bmpImage.Width / 2, this.bmpImage.Height / 2 - 25, this.bmpImage.Width / 2, this.bmpImage.Height / 2 + 25);
            g.DrawLine(Pens.Yellow, this.bmpImage.Width / 2 - 25, this.bmpImage.Height / 2, this.bmpImage.Width / 2 + 25, this.bmpImage.Height / 2);
        }

        private void Tsmi_ImageAdaptive_Click(object sender, EventArgs e)//图像自适应
        {

        }

        private void Tsmi_ArrayAdaptive_Click(object sender, EventArgs e)//阵列自适应
        {

        }

        private void Tsmi_ShowGrid_Click(object sender, EventArgs e)//显示网格
        {

        }

        private void Tsbtn_ShowPoint_Click(object sender, EventArgs e)//显示坐标点
        {

        }

        private void Tsbtn_ShowCoordinate_Click(object sender, EventArgs e)//显示坐标系
        {

        }

        private void Tsbtn_MoreSet_Click(object sender, EventArgs e)//更多设置
        {

        }
    }
}
