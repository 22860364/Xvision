using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.VisualStyles;

namespace DispenseAPP.MyStyleToolStripItem
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip)]
    public class ToolStripRadioButton : ToolStripItem
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Point pLocation = new Point(e.ClipRectangle.X, e.ClipRectangle.Height / 2 - (13 / 2));
            Size txtSize = TextRenderer.MeasureText(Text, Font);
            Rectangle rectText = new Rectangle(pLocation.X + 13, pLocation.Y, txtSize.Width, txtSize.Height);
            RadioButtonState radioButtonState = IsCheck ? RadioButtonState.CheckedNormal : RadioButtonState.UncheckedNormal;
            RadioButtonRenderer.DrawRadioButton(e.Graphics, pLocation, rectText, Text, Font, false, radioButtonState);
        }

        private bool IsCheck = false;
        public bool HasCheck
        {
            get
            {
                return IsCheck;
            }
            set
            {
                IsCheck = value;
                Invalidate();
            }
        }

        protected override void OnClick(EventArgs e)
        {
            foreach (ToolStripItem item in this.Owner.Items)
            {
                if (item is ToolStripRadioButton toolStripRadioButton)
                {
                    toolStripRadioButton.HasCheck = false;
                }
            }
            IsCheck = !IsCheck;
            base.OnClick(e);
        }

        public override Size GetPreferredSize(Size constrainingSize)
        {
            base.GetPreferredSize(constrainingSize);
            Size preferredSize = base.GetPreferredSize(constrainingSize);
            preferredSize.Width += 13;
            return preferredSize;
        }
    }
}
