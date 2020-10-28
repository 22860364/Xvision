using System;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;
using DispenseAPP.FrmList;

namespace DispenseAPP.ToolBar
{
    public partial class ToolBarSystem : UserControl
    {
        FrmPrimary _frmPrimary = null;
        public ToolBarSystem(FrmPrimary frmPrimary)
        {
            InitializeComponent();
            _frmPrimary = frmPrimary;
        }

        public void SetControlEnableInRunMode(bool enable)
        {
            Enabled = enable;
        }

        /// <summary>
        /// 点击系统设置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsbtnSet_Click(object sender, EventArgs e)
        {
            FrmSystemSet frmSystemSet = new FrmSystemSet();
            if(frmSystemSet.ShowDialog() == DialogResult.OK)
            {
                _frmPrimary.SetCurrentProjectName();
            }
        }
    }
}
