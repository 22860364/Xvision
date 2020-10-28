using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DispenseAPP.MyStyleControl
{
    public partial class UserControlTool : UserControl
    {
        public UserControlTool()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.StandardDoubleClick, true);
        }

        /// <summary>
        /// 点击确定按钮事件
        /// </summary>
        public event Action<IToolable> ClickOKEvent;

        /// <summary>
        /// 点击取消按钮事件
        /// </summary>
        public event Action ClickCancelEvent;

        /// <summary>
        /// 点击确定按钮执行的检查
        /// </summary>
        /// <param name="stepName">算子名</param>
        /// <param name="toolableList">该工具所在的普通算子块的工具集</param>
        /// <returns></returns>
        protected virtual bool ClickOKCheck(string stepName,List<IToolable> toolableList)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text.Trim()))
            {
                MessageBox.Show("算子名不能为空");
                return false;
            }
            if (txtName.Text.Trim() != stepName)
            {
                if (toolableList.Find(c => c.StepCustomName == txtName.Text.Trim()) != null)
                {
                    MessageBox.Show("该算子名已经被使用！");
                    return false;
                }
            }
            return true;
        }

        protected void ExecuteClickOkEvent(IToolable toolable)
        {
            ClickOKEvent?.Invoke(toolable);
        }

        protected virtual void BtnOK_Click(object sender, EventArgs e)
        {
        }

        protected virtual void BtnCancel_Click(object sender, EventArgs e)
        {
            ClickCancelEvent?.Invoke();
        }
    }
}
