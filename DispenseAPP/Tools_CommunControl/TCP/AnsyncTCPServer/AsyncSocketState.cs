using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP.Tools_CommunControl.TCP.AnsyncTCPServer
{
    public class AsyncSocketState
    {
        #region filed
        private Socket _clientSocket;//客户端的Socket
        #endregion

        #region Property
        public Socket ClientSocket
        {
            get { return _clientSocket;  }
        }
        #endregion

        #region 构造函数
        public AsyncSocketState(Socket clientSocket)
        {
            _clientSocket = clientSocket;
        }

        public void Close()
        {
            _clientSocket.Shutdown(SocketShutdown.Both);//关闭数据的发送和接受
            _clientSocket.Close();
        }
        #endregion
    }
}
