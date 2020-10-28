using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.VisualStyles;

namespace DispenseAPP.ToolBar
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip)]
    public class ToolStripCheckBox: ToolStripItem
    {
        private bool IsChecked = false;
        public bool HasChecked
        {
            get
            {
                return IsChecked;
            }
            set
            {
                IsChecked = value;
                Invalidate();
            }
        }

        protected override void OnClick(EventArgs e)
        {
            IsChecked = !IsChecked;
            base.OnClick(e);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            if(Owner != null)
            {
                Point pLocation = new Point(e.ClipRectangle.X, e.ClipRectangle.Height / 2 - (13 / 2));
                Size txtSize = TextRenderer.MeasureText(Text, Font);
                Rectangle rectText = new Rectangle(pLocation.X + 13, pLocation.Y, txtSize.Width, txtSize.Height);
                CheckBoxState chkState = IsChecked ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal;
                CheckBoxRenderer.DrawCheckBox(e.Graphics, pLocation, rectText, Text, Font, false, chkState);
            }
        }

        public override Size GetPreferredSize(Size constrainingSize)//重写宽度和高度 为了适应大小 否则重绘会出现文字超出边缘的情况
        {
             base.GetPreferredSize(constrainingSize);
            Size preferredSize = base.GetPreferredSize(constrainingSize);
            preferredSize.Width += 13;
            return preferredSize;
        }

    }
}
