using System;
using System.Windows.Forms;

namespace DispenseAPP.Tools_Other.LogicOperation
{
    public partial class Tools_Logic_Operation : UserControl,IEvent
    {
        private LogicOperationClass _logicOperationClass;
        public Tools_Logic_Operation(LogicOperationClass logicOperationClass)
        {
            InitializeComponent();
            _logicOperationClass = logicOperationClass;
            txt_Name.Text = _logicOperationClass.BlockName;
        }

        public event ClickCancelDelegate _clickCancelButton;

        public event ClickOKButtonDelegate _clickOKButton;

        private void btn_Set_Click(object sender, EventArgs e)//点击设置按钮 弹出编辑框
        {
            FrmLogicOperation frmLogicOperation = new FrmLogicOperation(_logicOperationClass);
            frmLogicOperation.ShowDialog();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            _clickOKButton(_logicOperationClass);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            _clickCancelButton();
        }
    }
}
