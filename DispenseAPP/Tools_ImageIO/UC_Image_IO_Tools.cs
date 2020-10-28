using System;
using System.Windows.Forms;

namespace DispenseAPP.Tools_Image_IO
{

    public partial class UC_Image_IO_Tools : UserControl
    {
        public UC_Image_IO_Tools()
        {
            InitializeComponent();
        }

        public event Action<string, IToolable> ClickToolsEvent;

        private void Lbl_AcqSet_Click(object sender, EventArgs e)//采集设置
        {
            ClickToolsEvent("采集设置",new AcqSetToolEntity());
        }

        private void Lbl_AcqImage_Click(object sender, EventArgs e)//采集图像
        {
            ClickToolsEvent("采集图像",new AcqImageToolEntity());
        }

        private void Lbl_ImportImage_Click(object sender, EventArgs e)//导入图像
        {
            ClickToolsEvent("导入图像",new ImportImageToolEntity());
        }
    }
}
