using System;
using System.Windows.Forms;

namespace DispenseAPP.Tools_Other.ShowMessageBox
{
    /// <summary>
    /// 弹出对话框工具
    /// </summary>
    [Serializable]
    [UnableManualExecute]
    public class ShowMessageBoxToolEntity : IToolable
    {
        /// <summary>
        /// 用于序列化
        /// </summary>
        public ShowMessageBoxToolEntity()
        {
        }

        /// <summary>
        /// 在消息的标题中显示的文本
        /// </summary>
        public string Caption { get; set; } = null;

        /// <summary>
        /// 在消息框中显示的文本
        /// </summary>
        public string Text { get; set; } = null;

        /// <summary>
        /// 是否启用第二个按钮
        /// </summary>
        public bool VisibleSecondButton { get; set; } = false;

        /// <summary>
        /// 工具箱名称
        /// </summary>
        public override ToolsKitNameEnum ToolKitName => ToolsKitNameEnum.Other;

        /// <summary>
        /// 工具名称
        /// </summary>
        public override string ToolName => "弹出对话框";

        /// <summary>
        /// 按钮1被点击
        /// </summary>
        [ConditionJudge]
        public bool FirstButtonClicked { get; set; } = false;

        /// <summary>
        /// 按钮2被点击
        /// </summary>
        [ConditionJudge]
        public bool SecondButtonClicked { get; set; } = false;

        /// <summary>
        /// 执行方法
        /// </summary>
        public override void Execute()
        {
            switch (MessageBox.Show(Text, Caption, VisibleSecondButton == true?MessageBoxButtons.OKCancel:MessageBoxButtons.OK))
            {
                case DialogResult.OK:
                    FirstButtonClicked = true;
                    break;
                case DialogResult.Cancel:
                    SecondButtonClicked = true;
                    break;
            }
        }

        /// <summary>
        /// 运行前检查
        /// </summary>
        /// <returns></returns>
        public override bool RunAgoCheck()
        {
            ErrorList.Clear();
            return ErrorList.Count == 0;
        }
    }
}
