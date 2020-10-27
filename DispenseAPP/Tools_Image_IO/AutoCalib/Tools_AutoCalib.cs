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
    public partial class Tools_AutoCalib : UserControl,IEvent
    {
        private AutoCalibClass _autoCalibClass;
        public Tools_AutoCalib(AutoCalibClass autoCalibClass)
        {
            InitializeComponent();
            _autoCalibClass = autoCalibClass;
            txt_Name.DataBindings.Add("Text", _autoCalibClass, "BlockName", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        public event ClickOKButtonDelegate _clickOKButton;

        public event ClickCancelDelegate _clickCancelButton;

        private void btn_OK_Click(object sender, EventArgs e)
        {
            _clickOKButton(_autoCalibClass);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            _clickCancelButton();
        }

        private void Btn_Set_Click(object sender, EventArgs e)
        {
            FrmCalib frmCalib = new FrmCalib(Cmb_CalibProject.SelectedItem.ToString());
            frmCalib.ShowDialog();
        }
    }
}
