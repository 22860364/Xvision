using DispenseAPP.FrmList;
using DispenseAPP.OtherTools.VariableSetTools;
using DispenseAPP.Tools_Other.VarSet;
using System;
using System.Windows.Forms;

namespace DispenseAPP.ToolBar
{
    public partial class ToolBarPlatform : UserControl
    {
        FrmPrimary _frmPrimary = null;
        public ToolBarPlatform(FrmPrimary frmPrimary)
        {
            InitializeComponent();
            _frmPrimary = frmPrimary;
        }

        private void Tsmi_配置窗口_Click(object sender, EventArgs e)
        {
            FrmConfigWindow frmConfigWindow = new FrmConfigWindow();
            if (frmConfigWindow.ShowDialog() == DialogResult.OK)
            {
                _frmPrimary.ReSet_the_form_Layout();
            }
        }

        public void SetControlEnableInRunMode(bool enable)
        {
            Enabled = enable;
        }

        private void Tsbtn_实时变量_Click(object sender, EventArgs e)
        {
            FrmVarRealTimeValue frmVarRealTimeValue = new FrmVarRealTimeValue();
            frmVarRealTimeValue.ShowDialog();
        }

        private void Tsbtn_变量设置_Click(object sender, EventArgs e)
        {
            FrmVarList frmVarList = new FrmVarList();
            frmVarList.ShowDialog();
        }
    }
}
