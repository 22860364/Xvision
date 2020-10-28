using DispenseAPP.CustomControl;
using static DispenseAPP.CommonClass;
using System;
using DispenseAPP.AboutData;
using System.Windows.Forms;

namespace DispenseAPP
{
    public partial class FrmSystemSet : FormM
    {
        public FrmSystemSet()
        {
            InitializeComponent();
        }

        SystemSetData SystemSetItem { get; set; } = null;

        private void FrmSystemSet_Load(object sender, EventArgs e)
        {
            SystemSetItem = (SystemSetData)StaticPublicData.SystemSetData.Clone();
            prgSet.SelectedObject = SystemSetItem;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            StaticPublicData.SystemSetData = SystemSetItem;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
