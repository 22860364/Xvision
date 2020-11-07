using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DispenseAPP.Tools_ImageEnhancement.RotateShiftImage;
using DispenseAPP.Tools_ImageEnhancement.Binaryzation;
using DispenseAPP.Tools_ImageEnhancement.DisposeImage;
using DispenseAPP.Tools_ImageEnhancement.Filter;
using DispenseAPP.Tools_ImageEnhancement.Morphology;
using DispenseAPP.Tools_ImageEnhancement.Pretreatment;

namespace DispenseAPP.Tools_ImageEnhancement
{
    public partial class UC_Image_Enhancement_Tools : UserControl
    {
        public event Action<string, IToolable> ClickToolsEvent;
        public UC_Image_Enhancement_Tools()
        {
            InitializeComponent();
        }

        private void Lbl_Pretreatment_Click(object sender, EventArgs e)  // 预处理
        {
            ClickToolsEvent("预处理", new PretreatmentToolEntity());
        }
        private void Lal_RotateTranslation_Click(object sender, EventArgs e)  // 旋转平移
        {
            ClickToolsEvent("平移旋转", new Tools_RotateShiftImageClass());
        }

        private void Lbl_Filter_Click(object sender, EventArgs e)  // 滤波
        {
            ClickToolsEvent("滤波", new FilterToolEntity());
        }

        private void Lbl_IDispose_Click(object sender, EventArgs e) // 图像操作
        {
            ClickToolsEvent("图像操作", new DisposeImageToolEntity());
        }

        private void Lbl_Binaryzation_Click(object sender, EventArgs e)  // 二值化
        {
            ClickToolsEvent("二值化", new BinaryzationToolEntity());
        }

        private void Lbl_Morphology_Click(object sender, EventArgs e)  // 膨胀腐蚀
        {
            ClickToolsEvent("形态学", new MorphologyToolEntity());
        }
    }

    

        
}
