using DispenseAPP.MyStyleControl;
using DispenseAPP.Tools_ImageEnhancement.RotateShiftImage;
using System;
using System.Windows.Forms;

namespace DispenseAPP.Tools_ImageEnhancement
{
    public partial class Tools_RotateShiftImage : UserControlTool
    {
        Tools_RotateShiftImageClass RotateShiftImageEntity { get; set; } = null;
        public Tools_RotateShiftImage(Tools_RotateShiftImageClass _rotateShiftImageEntity)
        {
            InitializeComponent();
            RotateShiftImageEntity = _rotateShiftImageEntity;
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Set_Click(object sender, EventArgs e)
        {

        }
    }
}
