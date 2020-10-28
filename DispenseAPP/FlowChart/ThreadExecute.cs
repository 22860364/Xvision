using System.Threading;

namespace DispenseAPP.FlowChart.BlockClass
{
    public class ThreadExecute
    {
        public void Execute(object element)
        {
            while (true)
            {
                if (element == null)
                {
                    if(CurrentThread != null && FrmPrimary.BThreadList.Contains(CurrentThread))
                    {
                        FrmPrimary.BThreadList.Remove(CurrentThread);
                    }
                    break;
                }
                else
                {
                    element = ((BlockItem)element).Execute();
                }
            }
        }

        public Thread CurrentThread = null;//运行的线程
    }
}
