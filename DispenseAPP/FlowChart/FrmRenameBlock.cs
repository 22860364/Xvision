using DispenseAPP.CustomControl;
using System;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    public partial class FrmRenameBlock : FormM
    {
        public FrmRenameBlock(string name)
        {
            InitializeComponent();
            _name = name;
            txt_blockName.Text = name;            
        }

        string _name;

        public event Action<object> EditConfirmEvent;

        private void Btn_OK_Click(object sender, EventArgs e)//将修改后的值回传回去
        {
            EditConfirmEvent(txt_blockName.Text.Trim());
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Txt_blockName_TextChanged(object sender, EventArgs e)
        {
            if(txt_blockName.Text == _name || QueryFlowChartExitsName(txt_blockName.Text) == true)
            {
                btn_OK.Enabled = false;
            }
            else
            {
                btn_OK.Enabled = true;
            }
        }

        private bool QueryFlowChartExitsName(string name)// 查询算子块名称是否已经存在
        {
            BlockItem element = StaticPublicData.BlockItems[NameType.CustomName, name];
            if(element != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Txt_blockName_KeyPress(object sender, KeyPressEventArgs e)//用户按下并释放某个键后触发
        {
            //不允许输入空格
        }
    }
}
