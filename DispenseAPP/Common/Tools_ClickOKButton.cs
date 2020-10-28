using System.Collections.Generic;
using System.Windows;

namespace DispenseAPP.Tools_CommonClass
{
    public class Tools_ClickOKButton
    {
        public static bool CheckBlockName(string text,string currentName,List<IToolable> toolsList)
        {
            if(string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("算子名不能为空");
                return false;
            }
            if(text != currentName)
            {
                if(toolsList.Find(c=>c.StepCustomName == text)!= null)
                {
                    MessageBox.Show("该算子名已经被使用！");
                    return false ;
                }
            }
            return true;
        }
    }
}
