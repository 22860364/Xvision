using DispenseAPP.MyStyleControl;
using System;

namespace DispenseAPP.Tools_Other.Script
{
    public partial class Tools_Script : MyUserControl
    {
        Tools_ScriptClass _scriptClass;

        public Tools_Script(Tools_ScriptClass scriptClass)
        {
            InitializeComponent();
            _scriptClass = scriptClass;
            Txt_Name.Text = _scriptClass.StepCustomName;
        }

        private void Btn_Set_Click(object sender, EventArgs e)//设置
        {
            FrmScript frmScript = new FrmScript(_scriptClass);
            frmScript.ShowDialog();
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
           base.ClickOk(_scriptClass);
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            base.ClickCancel();
        }
    }
}
