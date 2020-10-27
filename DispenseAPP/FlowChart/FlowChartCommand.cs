using System.Windows.Forms;

namespace DispenseAPP
{
    public class FlowChartCommand
    {
        protected string _commandText;//命令文本
        public string CommandText
        {
            get { return _commandText; }
            set { _commandText = value; }
        }

        MouseEventArgs _mouseInfo;//鼠标信息
        public MouseEventArgs MouseInfo
        {
            get { return _mouseInfo; }
            set { _mouseInfo = value; }
        }

        int _key;//按下的键
        public int Key
        {
            get { return _key; }
            set { _key = value; }
        }

        public FlowChartCommand(string text ,MouseEventArgs mouse,int key)
        {
            _commandText = text;
            _mouseInfo = mouse;
            _key = key;
        }
    }
}
