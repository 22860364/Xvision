using System.Windows.Forms;

namespace DispenseAPP
{
    public class FlowChartCommand
    {
        protected string _commandText;
        public string CommandText
        {
            get { return _commandText; }
            set { _commandText = value; }
        }

        public MouseEventArgs MouseInfo { get; set; }
        public int Key { get; set; }

        public FlowChartCommand(string text ,MouseEventArgs mouse,int key)
        {
            _commandText = text;
            MouseInfo = mouse;
            Key = key;
        }
    }
}
