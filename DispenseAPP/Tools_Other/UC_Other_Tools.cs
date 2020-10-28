using System;
using System.Windows.Forms;
using DispenseAPP.Tools_Other.VarSet;
using DispenseAPP.Tools_Other.DelayTime;
using DispenseAPP.Tools_Other.Script;
using DispenseAPP.Tools_Other.LogicOperation;
using DispenseAPP.Tools_Other.ReadWriteVar;
using DispenseAPP.Tools_Other.ShowMessageBox;

namespace DispenseAPP.Tools_Other
{
    public partial class UC_Other_Tools : UserControl
    {
        public event Action<string, IToolable> ClickToolsEvent;
        public UC_Other_Tools()
        {
            InitializeComponent();
        }

        private void Lbl_VarSet_Click(object sender, EventArgs e)//变量设置
        {
            ClickToolsEvent("变量设置",new VarSetToolEntity());
        }

        private void Lbl_LogicalOperation_Click(object sender, EventArgs e)//逻辑运算
        {
            ClickToolsEvent("逻辑运算",new LogicOperationToolEntity());
        }

        /// <summary>
        /// 延时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lbl_Delay_Click(object sender, EventArgs e)
        {
            ClickToolsEvent("延时",new DelayTimeToolEntity());
        }

        /// <summary>
        /// 脚本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lbl_Script_Click(object sender, EventArgs e)
        {
            ClickToolsEvent("脚本",new Tools_ScriptClass());
        }

        /// <summary>
        /// 读写变量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lbl_ReadWriteVar_Click(object sender, EventArgs e)
        {
            ClickToolsEvent("读写变量", new ReadWriteVarToolEntity());
        }

        /// <summary>
        /// 弹出对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lbl_ShowMessageBox_Click(object sender, EventArgs e)
        {
            ClickToolsEvent("弹出对话框", new ShowMessageBoxToolEntity());
        }
    }
}
