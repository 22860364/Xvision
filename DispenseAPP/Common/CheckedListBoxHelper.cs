using System.Collections.Generic;
using System.Windows.Forms;

namespace DispenseAPP.Tools_CommonClass
{
    public class CheckedListBoxHelper
    {
        public static List<string> GetCheckListBoxSelect(CheckedListBox checkedListBox)//获得所选项的文本
        {
            List<string> selectList = new List<string>();
            for (int i = 0; i < checkedListBox.CheckedItems.Count ; i++)
            {
                  selectList.Add(checkedListBox.GetItemText(checkedListBox.CheckedItems[i]));
            }
            return selectList;
        }

        public static void SelectItemFromStringList(CheckedListBox checkedListBox,List<string> itemList,bool nonExistentProcess = true)//根据字符串选择项 
        {
            if (itemList == null) return;
            foreach (string item in itemList)
            {
                if (ContainsItem(item, checkedListBox, out int index))
                {
                    checkedListBox.SetItemChecked(index, true);
                }
                else//如果不存在 则添加为???
                {
                    if(nonExistentProcess)
                    {
                        checkedListBox.Items.Add("???", true);
                    }
                }
            }
        }


        private static bool ContainsItem(string text, CheckedListBox checkedListBox,out int index)//查询CheckedListBox中是否包含文本为输入值得项 如果包含则返回True 并且返回索引 
        {
            index = -1;
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if(checkedListBox.GetItemText(checkedListBox.Items[i]) == text)
                {
                    index = i;
                    return true;
                }
            }
            return false;
        }
    }
}
