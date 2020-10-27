using System;
using System.Windows.Forms;
using DispenseAPP.OtherTools.VariableSetTools;
using DispenseAPP.Tools_Other.VarSet;

namespace DispenseAPP.Tools_Other
{
    public partial class Tools_VarSet : UserControl,IEvent 
    {
        public Tools_VarSet(VarSetClass varSetClass,ProjectParamClass projectParam)
        {
            InitializeComponent();
            _varSetClass = varSetClass;
            _projectParam = projectParam;
            txt_Name.Text = _varSetClass.BlockName;
        }

        public event ClickCancelDelegate _clickCancelButton;
        public event ClickOKButtonDelegate _clickOKButton;
        private VarSetClass _varSetClass;

        private ProjectParamClass _projectParam;

        private void btn_Set_Click(object sender, EventArgs e)
        {
            FrmVarSet frmVarSet = new FrmVarSet(_projectParam, _varSetClass);
            frmVarSet.ShowDialog();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            _varSetClass.BlockName = txt_Name.Text;
            _clickOKButton(_varSetClass);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            _clickCancelButton();
        }
    }
}
