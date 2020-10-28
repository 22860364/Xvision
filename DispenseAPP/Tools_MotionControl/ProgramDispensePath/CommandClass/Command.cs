using System.Windows.Forms;

namespace DispenseAPP
{
    public abstract class Command
    {
        public static DataGridView DG_Motion;
        public static int AxisCount;
        public abstract void Excute();//执行
        public abstract void Undo();//撤销
    }
}
