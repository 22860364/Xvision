using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DispenseAPP
{
    public enum ToPanelControl
    {
        WorkFlowControl,
        ImageControl
    }
    public static class ControlClass
    {
        public static void AddControlToPanel(Control control,Panel panel)
        {
            panel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            if(control is Form)//如果是窗体，则需要手动显示
            {
                (control as Form).TopLevel = false;//设置不是顶级窗口
            }
            panel.Controls.Add(control);
            control.Show();
            control.BringToFront();
        }
    }
}
