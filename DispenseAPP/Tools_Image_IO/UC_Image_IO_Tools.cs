using DispenseAPP.Tools_Image_IO.AutoCalib;
using System.Windows.Forms;

namespace DispenseAPP.Tools_Image_IO
{

    public partial class UC_Image_IO_Tools : UserControl
    {
        public UC_Image_IO_Tools()
        {
            InitializeComponent();
        }

        public event ClickToolsDelegate ClickToolsEvent;

        private void Lbl_AcqSet_Click(object sender, System.EventArgs e)//采集设置
        {
            ClickToolsEvent(ToolsNameEnum.AcqSet,new AcqSetClass());
        }

        private void Lbl_AcqImage_Click(object sender, System.EventArgs e)//采集图像
        {
            ClickToolsEvent(ToolsNameEnum.AcqImage,new AcqImageClass());
        }

        private void Lbl_ImportImage_Click(object sender, System.EventArgs e)//导入图像
        {
            ClickToolsEvent(ToolsNameEnum.ImportImage,new ImportImageClass());
        }

        private void Lbl_CacheImage_Click(object sender, System.EventArgs e)
        {
            ClickToolsEvent(ToolsNameEnum.CacheImage,new ImageCacheClass());
        }

        private void Lbl_ExportImage_Click(object sender, System.EventArgs e)
        {
            ClickToolsEvent(ToolsNameEnum.ExportImage,new ExportImageClass());
        }

        private void Lbl_UseCalib_Click(object sender, System.EventArgs e)
        {
            //ClickToolsEvent("应用标定信息");
        }

        private void Lbl_TransformCoordinateSystem_Click(object sender, System.EventArgs e)
        {
            //ClickToolsEvent("坐标系转换");
        }

        private void Lbl_AutoCalib_Click(object sender, System.EventArgs e)
        {
            ClickToolsEvent(ToolsNameEnum.AutoCalib,new AutoCalibClass());
        }
    }
}
