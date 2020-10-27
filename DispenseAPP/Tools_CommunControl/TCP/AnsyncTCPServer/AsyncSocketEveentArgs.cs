using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP.Tools_CommunControl.TCP.AnsyncTCPServer
{
    public class AsyncSocketEventArgs:EventArgs
    {
        public string _msg;//提示信息

        public AsyncSocketState _state;//客户端状态类

        public bool IsHandled { get; set; }//是否已经处理过了

        public AsyncSocketEventArgs(string msg)
        {
            _msg = msg;
            IsHandled = false;
        }

        public AsyncSocketEventArgs(AsyncSocketState state)
        {
            _state = state;
            IsHandled = false;
        }

        public AsyncSocketEventArgs(string msg, AsyncSocketState state)
        {
            _msg = msg;
            _state = state;
            IsHandled = false;
        }

    }
}
