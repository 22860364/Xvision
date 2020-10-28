using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DispenseAPP.Tools_Image_IO.AutoCalib
{
    public partial class UC_Calib_ImageSet : UserControl
    {
        public UC_Calib_ImageSet()
        {
            InitializeComponent();
            Rbtn_No.Checked = true;
        }

        private void Rbtn_No_CheckedChanged(object sender, EventArgs e)//不引入外部点
        {
            SC_Calib.Panel2Collapsed = true;
        }

        private void Rbtn_Yes_CheckedChanged(object sender, EventArgs e)//引入外部点
        {
            SC_Calib.Panel1Collapsed = true;
        }
    }
}
