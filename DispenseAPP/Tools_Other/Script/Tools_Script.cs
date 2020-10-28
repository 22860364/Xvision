using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DispenseAPP.Tools_Other.Script
{
    public partial class Tools_Script : UserControl,IEvent 
    {
        public Tools_Script(ScriptClass scriptClass)
        {
            InitializeComponent();
            _scriptClass = scriptClass;
            txt_Name.Text = _scriptClass.BlockName;
        }

        public event ClickCancelDelegate _clickCancelButton;
        public event ClickOKButtonDelegate _clickOKButton;
        private ScriptClass _scriptClass;


        private void btn_Set_Click(object sender, EventArgs e)//设置
        {
            FrmScript frmScript = new FrmScript();
            frmScript.ShowDialog();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            _clickOKButton(_scriptClass);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            _clickCancelButton();
        }
    }
}
