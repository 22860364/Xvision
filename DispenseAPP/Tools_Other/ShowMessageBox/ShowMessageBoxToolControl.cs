using System;
using System.Collections.Generic;
using DispenseAPP.MyStyleControl;
using System.Windows.Forms;

namespace DispenseAPP.Tools_Other.ShowMessageBox
{
    public partial class ShowMessageBoxToolControl : UserControlTool
    {
        public ShowMessageBoxToolControl(ShowMessageBoxToolEntity entity)
        {
            InitializeComponent();
            Entity = entity;
            InitialControl();
        }

        /// <summary>
        /// 初始化控件
        /// </summary>
        void InitialControl()
        {
            txtName.Text = Entity.StepCustomName;
            txtCaption.Text = Entity.Caption;
            txtText.Text = Entity.Text;
            chkDisplaySecondButton.Checked = Entity.VisibleSecondButton;
        }

        /// <summary>
        /// 显示对话框实体对象
        /// </summary>
        public ShowMessageBoxToolEntity Entity { get; set; }

        /// <summary>
        /// 点击OK按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            if (!ClickOKCheck(Entity.StepCustomName, Entity.SelectedOperatorBlock.ToolList))
            {
                return;
            }
            Entity.StepCustomName = txtName.Text.Trim();
            Entity.Caption = txtCaption.Text.Trim();
            Entity.Text = txtText.Text.Trim();
            Entity.VisibleSecondButton = chkDisplaySecondButton.Checked;
            ExecuteClickOkEvent(Entity);
        }

        /// <summary>
        /// 点击OK前的检查
        /// </summary>
        /// <param name="stepName"></param>
        /// <param name="toolableList"></param>
        /// <returns></returns>
        protected override bool ClickOKCheck(string stepName, List<IToolable> toolableList)
        {
            if(!base.ClickOKCheck(stepName, toolableList))
            {
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtCaption.Text))
            {
                MessageBox.Show("消息框的标题不能为空...");
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtText.Text))
            {
                MessageBox.Show("消息框的文本不能为空...");
                return false; 
            }
            return true;
        }
    }
}
