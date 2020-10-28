using System.Windows.Forms;

namespace DispenseAPP.静态类
{
    public class QueryDifferenceName//查询不同的名称
    {
        public static bool ToolClickOK(string text,NormalBlock normalBlock,string blockName)
        {
            if (text == "")
            {
                MessageBox.Show("请输入算子名", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (!(blockName != "" && blockName == text))
            {
                if (normalBlock.ToolsList.Find(c => c.BlockName == text) != null)
                {
                    MessageBox.Show("该算子名已经被使用！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return false;
                }
            }
            return true;
        }
    }
}
