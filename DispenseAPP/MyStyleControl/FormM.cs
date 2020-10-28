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
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.StandardDoubleClick, true);
        }

        public enum FormSize
        {
            Normal = 0,//正常大小
            Max = 1,//最大化
        };

        private bool closeVisible = true;
        [Description("是否允许使用关闭按钮")]
        public bool CloseVisible
        {
            get
            {
                return closeVisible;
            }
            set
            {
                closeVisible = value;
                Lbl_Close.Visible = value;
            }
        }

        #region 关闭按钮
        private void Lbl_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Lbl_Close_MouseEnter(object sender, EventArgs e)
        {
            Lbl_Close.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void Lbl_Close_MouseLeave(object sender, EventArgs e)
        {
            Lbl_Close.BackColor = Color.Transparent;
        }
        #endregion

        #region Lable图片和颜色
        private Color titleForeColor = Color.Black;
        [Description("窗体文本的文字颜色")]
        public Color TitleForeColor
        {
            get
            {
                return titleForeColor;
            }
            set
            {
                titleForeColor = value;
                lbl_Title.ForeColor = value;
            }
        }


        private Image titleImage = null;
        [Description("窗体图标")]
        public Image TitleImage
        {
            get
            {
                return titleImage;
            }
            set
            {
                titleImage = value;
                lbl_Title.Image = value;
            }
        }

        private Color titleColor = Color.White;
        [Description("窗体文本的背景颜色")]
        public Color TitleColor
        {
            get
            {
                return titleColor;
            }
            set
            {
                titleColor = value;
                lbl_Title.BackColor = value;
            }
        }
        
        #endregion

        private Color myBackColor = SystemColors.Control;
        [Description("窗体顶部颜色")]
        public Color MyBackColor
        {
            get
            {
                return myBackColor;
            }
            set
            {
                myBackColor = value;
                panel_Title.BackColor = myBackColor;
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
                lbl_Title.Text = _titleText;
            }
        }

        /// <summary>
        /// 记录鼠标按下事件的坐标
        /// </summary>
        private Point _downPoint;

        /// <summary>
        /// 当鼠标指针在组件上方并按下鼠标按钮时发生
        /// </summary>
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _downPoint = new Point(e.X, e.Y);
        }

        /// <summary>
        /// 鼠标指针移过组件时发生
        /// </summary>
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(Location.X + e.X - _downPoint.X, Location.Y + e.Y - _downPoint.Y);
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

        protected override void WndProc(ref System.Windows.Forms.Message m)
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
    }
}
