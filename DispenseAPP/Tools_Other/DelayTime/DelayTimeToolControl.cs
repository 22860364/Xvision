using System;
using System.Collections.Generic;
using DispenseAPP.MyStyleControl;

namespace DispenseAPP.Tools_Other.DelayTime
{
    public partial class DelayTimeToolControl : UserControlTool
    {
        /// <summary>
        /// 延时工具实体对象
        /// </summary>
        DelayTimeToolEntity Entity { get; set; } = null;

        public DelayTimeToolControl(DelayTimeToolEntity delayTimeToolEntity)
        {
            InitializeComponent();
            Entity = delayTimeToolEntity;
            InitialControlValue();
        }

        void InitialControlValue()
        {
            txtName.Text = Entity.StepCustomName;
            nudTime.Value = Entity.Time;
        }

        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            if(!ClickOKCheck(Entity.StepCustomName,Entity.SelectedOperatorBlock.ToolList))
            {
                return;
            }
            Entity.StepCustomName = txtName.Text.Trim();
            Entity.Time = Convert.ToInt32(nudTime.Value);
            ExecuteClickOkEvent(Entity);
        }

        protected override bool ClickOKCheck(string stepName, List<IToolable> toolableList)
        {
            if(!base.ClickOKCheck(stepName, toolableList))
            {
                return false;
            }
            return true;
        }
    }
}
