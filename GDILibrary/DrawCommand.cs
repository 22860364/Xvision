using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDILibrary
{
    public enum CommandType
    {
        MouseLeftDown,
        MouseUp,
        MouseMove,
    }
    public class DrawCommand
    {
        public CommandType CommandText { get; set; }//命令文本

        public MouseEventArgs MouseInfo { get; set; }//鼠标信息

        public DrawCommand(CommandType commandText,MouseEventArgs mouseInfo)
        {
            CommandText = commandText;
            MouseInfo = mouseInfo;
        }
    }
}
