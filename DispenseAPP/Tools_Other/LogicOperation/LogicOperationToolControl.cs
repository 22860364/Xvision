using System;
using System.Collections.Generic;
using DispenseAPP.MyStyleControl;

namespace DispenseAPP.Tools_Other.LogicOperation
{
    public partial class LogicOperationToolControl : UserControlTool
    {
        /// <summary>
        /// 逻辑运算实体对象
        /// </summary>
        LogicOperationToolEntity Entity { get; set; } = null;

        public LogicOperationToolControl(LogicOperationToolEntity logicOperationEntity)
        {
            InitializeComponent();
            Entity = logicOperationEntity;
            txtName.Text = Entity.StepCustomName;
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            FrmLogicOperation frmLogicOperation = new FrmLogicOperation(Entity);
            frmLogicOperation.ShowDialog();
        }

        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            if(!ClickOKCheck(Entity.StepCustomName,Entity.SelectedOperatorBlock.ToolList))
            {
                return;
            }
            Entity.StepCustomName = txtName.Text;
            ExecuteClickOkEvent(Entity);
        }

        protected override bool ClickOKCheck(string stepName, List<IToolable> toolableList)
        {
            return base.ClickOKCheck(stepName, toolableList);
        }
    }
}
