using DispenseAPP.CustomControl;
using System.Windows.Forms;

namespace DispenseAPP
{
    public partial class FrmRenameBlock : FormM
    {
        public FrmRenameBlock(string name,ProjectParamClass projectParam)
        {
            InitializeComponent();
            _projectParamClass = projectParam;
            _name = name;
            txt_blockName.Text = name;            
        }

        private string _name;

        public event EditConfirmDelegate EditConfirmEvent;

        private ProjectParamClass _projectParamClass ;

        private void btn_OK_Click(object sender, System.EventArgs e)//将修改后的值回传回去
        {
            EditConfirmEvent(txt_blockName.Text.Trim());
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Cancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void txt_blockName_TextChanged(object sender, System.EventArgs e)
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

        /// <summary>
        /// 查询算子块名称是否已经存在
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private bool QueryFlowChartExitsName(string name)
        {
            Element element = _projectParamClass._flowChartList.Find(c => c.Name == name);
            if(element != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txt_blockName_KeyPress(object sender, KeyPressEventArgs e)//用户按下并释放某个键后触发
        {
            //不允许输入空格
        }
    }
}
