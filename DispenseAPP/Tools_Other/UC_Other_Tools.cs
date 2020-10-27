using System;
using System.Windows.Forms;
using DispenseAPP.Tools_Other.VarSet;
using DispenseAPP.Tools_Other.DelayTime;
using DispenseAPP.Tools_Other.Script;
using DispenseAPP.Tools_Other.LogicOperation;

namespace DispenseAPP.Tools_Other
{
    public partial class UC_Other_Tools : UserControl
    {
        public event ClickToolsDelegate ClickToolsEvent;
        public UC_Other_Tools()
        {
            InitializeComponent();
        }

        private void Lbl_VarSet_Click(object sender, EventArgs e)//变量设置
        {
            ClickToolsEvent(ToolsNameEnum.VarSet,new VarSetClass());
        }

        private void Lbl_LogicalOperation_Click(object sender, EventArgs e)//逻辑运算
        {
            ClickToolsEvent(ToolsNameEnum.LogicOperation,new LogicOperationClass());
        }

        private void Lbl_Delay_Click(object sender, EventArgs e)//延时
        {
            ClickToolsEvent(ToolsNameEnum.DelayTime,new DelayTimeClass());
        }

        private void Lbl_Script_Click(object sender, EventArgs e)//脚本
        {
            ClickToolsEvent(ToolsNameEnum.Script,new ScriptClass());
        }
    }
}
