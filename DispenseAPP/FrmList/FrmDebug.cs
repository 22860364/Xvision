using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    public partial class FrmDebug : Form
    {
        public FrmDebug()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲     
            WindowIndexDic.Add(1, UC_Image_Debug);   //这里有bug需要注意
        }

        public void AddWindow()
        {
            WindowIndexDic[CurrentWindowIndex].Dock = DockStyle.Fill;
            panel_Image.Controls.Add(WindowIndexDic[CurrentWindowIndex]);
        }
    }
}
