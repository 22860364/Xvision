using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                this.label1.Image = _imageDefault;
            }
        }

        private Image _imageMove = null;
        [Description("光标移动到控件上方显示图片")]
        public Image ImageMove
        {
            get { return _imageMove; }
            set { _imageMove = value; }
        }

        private Image _imageLeave = null;
        [Description("光标离开控件上方显示图片")]
        public Image ImageLeave
        {
            get { return _imageLeave; }
            set { _imageLeave = value; }
        }

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

        private Color _backColorMove = Color.Transparent;
        [Description("光标移动到控件上方显示的背景色")]
        public Color BackColorMove
        {
            get { return _backColorMove; }
            set { _backColorMove = value; }
        }

        private Color _backColorLeave = Color.Transparent;
        [Description("光标离开控件显示的背景色")]
        public Color BackColorLeave
        {
            get { return _backColorLeave; }
            set { _backColorLeave = value; }
        }

        private string _textM = "";
        [Description("显示的文字")]
        public string TextM
        {
            get { return _textM; }
            set
            {
                _textM = value;
                this.label1.Text = _textM;
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
                this.label1.ForeColor = _textColor;
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
                this.label1.Font = _fontM;
            }
        }

        public event EventHandler ButtonClick;

        private void label1_Click(object sender, EventArgs e)
        {
            if (ButtonClick != null)
            {
                ButtonClick(sender, e);
            }
        }

        /// <summary>
        /// 鼠标离开控件的可见部分时发生
        /// </summary>
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            if(_imageLeave != null)
            {
                ImageDefault = _imageLeave;
            }
            if(_backColorLeave != Color.Transparent)
            {
                BackColorLeave = _backColorLeave;
            }
        }

        /// <summary>
        /// 鼠标指针移过组件时发生
        /// </summary>
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_imageMove != null)
            {
                ImageDefault = _imageMove;
            }
            if (_backColorMove != Color.Transparent)
            {
                BackColorMove = _backColorMove;
            }
        }
    }
}
