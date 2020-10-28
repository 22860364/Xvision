using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DispenseAPP.CustomControl
{
    public partial class ButtonM : UserControl
    {
        public ButtonM()
        {
            InitializeComponent();
        }

        private Image _imageDefault = null;
        [Description("默认的图片")]
        public Image ImageDefault
        {
            get { return _imageDefault; }
            set
            {
                _imageDefault = value;
                label1.Image = _imageDefault;
            }
        }
        [Description("光标移动到控件上方显示图片")]
        public Image ImageMove { get; set; } = null;

        [Description("光标离开控件上方显示图片")]
        public Image ImageLeave { get; set; } = null;

        private Color _backColorM = Color.Transparent;
        [Description("控件的背景色")]
        public Color BackColorM
        {
            get { return _backColorM; }
            set
            {
                _backColorM = value;
                label1.BackColor = _backColorM;
            }
        }
        [Description("光标移动到控件上方显示的背景色")]
        public Color BackColorMove { get; set; } = Color.Transparent;
        [Description("光标离开控件显示的背景色")]
        public Color BackColorLeave { get; set; } = Color.Transparent;

        private string _textM = "";
        [Description("显示的文字")]
        public string TextM
        {
            get { return _textM; }
            set
            {
                _textM = value;
                label1.Text = _textM;
            }
        }

        private Color _textColor = Color.Black;
        [Description("文字的颜色")]
        public Color TextColor
        {
            get
            { return _textColor; }
            set
            {
                _textColor = value;
                label1.ForeColor = _textColor;
            }
        }

        private Font _fontM = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)134));
        [Description("用于显示文本的字体")]
        public Font FontM
        {
            get { return _fontM; }
            set
            {
                _fontM = value;
                label1.Font = _fontM;
            }
        }

        public event EventHandler ButtonClick;

        private void label1_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke(sender, e);
        }

        /// <summary>
        /// 鼠标离开控件的可见部分时发生
        /// </summary>
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            if(ImageLeave != null)
            {
                ImageDefault = ImageLeave;
            }
            if(BackColorLeave != Color.Transparent)
            {
                BackColorLeave = BackColorLeave;
            }
        }

        /// <summary>
        /// 鼠标指针移过组件时发生
        /// </summary>
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ImageMove != null)
            {
                ImageDefault = ImageMove;
            }
            if (BackColorMove != Color.Transparent)
            {
                BackColorMove = BackColorMove;
            }
        }
    }
}
