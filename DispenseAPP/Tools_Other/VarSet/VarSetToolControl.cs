using System;
using System.Collections.Generic;
using DispenseAPP.MyStyleControl;
using DispenseAPP.OtherTools.VariableSetTools;

namespace DispenseAPP.Tools_Other.VarSet
{
    /// <summary>
    /// 变量设置工具控件
    /// </summary>
    public partial class VarSetToolControl : UserControlTool
    {
        /// <summary>
        /// 变量设置工具实体
        /// </summary>
        VarSetToolEntity Entity { get; set; }

        public VarSetToolControl(VarSetToolEntity variableSetToolEntity)
        {
            InitializeComponent();
            Entity = variableSetToolEntity;
            txtName.Text = Entity.StepCustomName;
        }

        /// <summary>
        /// 进入设置界面
        /// </summary>
        private void BtnSet_Click(object sender, EventArgs e)
        {
            FrmVariableSet frmVarSet = new FrmVariableSet(Entity);
            frmVarSet.ShowDialog();
        }

        /// <summary>
        /// 点击确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            if (!ClickOKCheck(Entity.StepCustomName, Entity.SelectedOperatorBlock.ToolList))
            {
                return;
            }
            Entity.StepCustomName = txtName.Text;//设置算子名称
            ExecuteClickOkEvent(Entity);
        }


        /// <summary>
        /// 点击确定按钮的检查
        /// </summary>
        /// <param name="stepName"></param>
        /// <param name="toolableList"></param>
        /// <returns></returns>
        protected override bool ClickOKCheck(string stepName, List<IToolable> toolableList)
        {
            return base.ClickOKCheck(stepName, toolableList);
        }
    }
}
