using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DispenseAPP.CustomControl
{
    public partial class FormM : Form
    {
        public FormM()
        {
            InitializeComponent();
        }

        public enum FormSize
        {
            Normal = 0,//正常大小
            Max = 1,//最大化
        };

         private bool maxVisible = true;
         [Description("是否允许最大化")]
         public bool MaxVisible
         {
             get { return maxVisible; }
             set
             {
                 maxVisible = value;
                 if (!maxVisible)                                 
                 {
                    btnM_Max.Enabled = false;
                 }
             }
        }


        private string _titleText;
        [Description("窗体标题")]
        public override string Text
        {
            get { return _titleText; }
            set
            {
                _titleText = value;
                lbl_ProjectName.Text = _titleText;
            }
        }

        private bool _titleVisiable = true;
        [Description("窗体标题是否显示")]
        public bool TitleVisiable
        {
            get { return _titleVisiable; }
            set
            {
                _titleVisiable = value;
                if(!_titleVisiable)
                {
                    lbl_Title.Visible = false;
                    lbl_ProjectName.Location = new Point(3, 1);
                }
                else
                {
                    lbl_Title.Visible = true;
                    lbl_ProjectName.Location = new Point(115, 1);
                }
            }
        }

        private FormSize _defaultFormSize = FormSize.Normal;
        [Description("窗口默认大小")]
        public FormSize DefaultFormSize
        {
            get { return _defaultFormSize; }
            set
            {
                _defaultFormSize = value;
                if (_defaultFormSize == FormSize.Max)
                {
                    //防止遮挡任务栏
                    this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);//调整窗体可调整到的最大大小
                    this.WindowState = FormWindowState.Maximized;
                    //重置最大化图标
                    this.btnM_Max.ImageDefault = Properties.Resources.title_bar_max3;
                    this.btnM_Max.ImageLeave = Properties.Resources.title_bar_max3;
                    this.btnM_Max.ImageMove = Properties.Resources.title_bar_max4;
                }
            }
        }

        /// <summary>
        /// 记录鼠标按下事件的坐标
        /// </summary>
        private Point _downPoint;

        /// <summary>
        /// 当鼠标指针在组件上方并按下鼠标按钮时发生
        /// </summary>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _downPoint = new Point(e.X, e.Y);
        }

        /// <summary>
        /// 鼠标指针移过组件时发生
        /// </summary>
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(this.Location.X + e.X - _downPoint.X, this.Location.Y + e.Y - _downPoint.Y);
            }
        }

        const int Guying_HTLEFT = 10;
        const int Guying_HTRIGHT = 11;
        const int Guying_HTTOP = 12;
        const int Guying_HTTOPLEFT = 13;
        const int Guying_HTTOPRIGHT = 14;
        const int Guying_HTBOTTOM = 15;
        const int Guying_HTBOTTOMLEFT = 0x10;
        const int Guying_HTBOTTOMRIGHT = 17;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0084:
                    base.WndProc(ref m);
                    Point vPoint = new Point((int)m.LParam & 0xFFFF,
                        (int)m.LParam >> 16 & 0xFFFF);
                    vPoint = PointToClient(vPoint);
                    if (vPoint.X <= 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)Guying_HTTOPLEFT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)Guying_HTBOTTOMLEFT;
                        else m.Result = (IntPtr)Guying_HTLEFT;
                    else if (vPoint.X >= ClientSize.Width - 5)
                        if (vPoint.Y <= 5)
                            m.Result = (IntPtr)Guying_HTTOPRIGHT;
                        else if (vPoint.Y >= ClientSize.Height - 5)
                            m.Result = (IntPtr)Guying_HTBOTTOMRIGHT;
                        else m.Result = (IntPtr)Guying_HTRIGHT;
                    else if (vPoint.Y <= 5)
                        m.Result = (IntPtr)Guying_HTTOP;
                    else if (vPoint.Y >= ClientSize.Height - 5)
                        m.Result = (IntPtr)Guying_HTBOTTOM;
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        /// <summary>
        /// 最小化事件
        /// </summary>
        private void BtnM_Min_ButtonClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 最大化事件
        /// </summary>
        private void btnM_Max_ButtonClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)//如果当前是最大化
            {
                WindowState = FormWindowState.Normal;
                //重置最大化图标
                btnM_Max.ImageDefault = Properties.Resources.title_bar_max1;
                btnM_Max.ImageLeave = Properties.Resources.title_bar_max1;
                btnM_Max.ImageMove = Properties.Resources.title_bar_max2;
            }
            else
            {
                //防止遮挡任务栏
                MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                WindowState = FormWindowState.Maximized;
                //重置最大化图标
                btnM_Max.ImageDefault = Properties.Resources.title_bar_max3;
                btnM_Max.ImageLeave = Properties.Resources.title_bar_max3;
                btnM_Max.ImageMove = Properties.Resources.title_bar_max4;
            }
        }

        /// <summary>
        /// 关闭事件
        /// </summary>
        private void btnM_Close_ButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
