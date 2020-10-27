using DispenseAPP.CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DispenseAPP.Tools_Image_IO.AutoCalib
{
    public partial class FrmCalib : FormM
    {
        private string _calibProject;//标定方案

        public FrmCalib(string calibProject)
        {
            InitializeComponent();
            _calibProject = calibProject;
            if(_calibProject != "无") //如果标定方案为无 则默认为手眼标定
            {

            }
            else
            {
                
            }
        }

        private void ChangeCalibMethod(string calibMethod)
        {
            switch(calibMethod)
            {
                case "手眼标定":
                    break;
            }
        }

        private void Tsbtn_New_Click(object sender, EventArgs e)//新建标定
        {
            FrmNewCalib frmNewCalib = new FrmNewCalib();
            frmNewCalib.ShowDialog();
        }
    }
}
