using DispenseAPP.Tools_CommunControl.TCP.AnsyncTCPServer;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace DispenseAPP
{
    public class AnsyncSocketTCPServer : IDisposable
    {

        #region filed
        private int _maxClient;//允许连接的最大客户端数量

        private int _clientCount;//当前连接的客户端数量

        private Socket _serverSocket;//服务器使用的socket

        private List<AsyncSocketState> _clients;//客户端会话列表
        #endregion

        #region Property
        public bool IsRunning { get; private set; }//服务器是否在运行

        public IPAddress Address { get; private set; }//监听的IP地址

        public int Port { get; private set; }//监听的端口

        public Encoding Encoding { get; private set; }

        public bool Success
        {
            get
            {
                if(_clients.Count>0)
                {
                    return true; 
                }
                else
                {
                    return false;
                }
            }
        }

        public byte[] ReveiveDataBuffer //接受数据缓冲区
        { get; set; }

        public int Length { get; set; }

        public bool IsReceiveData { get; set; }
        #endregion

        #region 构造函数

        public AnsyncSocketTCPServer(IPAddress localIPAddress, int listenPort, int maxClinet)
        {
            Address = localIPAddress;
            Port = listenPort;
            Encoding = Encoding.Default;
            _maxClient = maxClinet;
            _clients = new List<AsyncSocketState>();
            _serverSocket = new Socket(localIPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            
        }

        public AnsyncSocketTCPServer(int listenPort) : this(IPAddress.Any, listenPort, 1024)
        {}

        public AnsyncSocketTCPServer(IPEndPoint localEP) : this(localEP.Address, localEP.Port, 1024)
        {}
        #endregion

        public void Start()//启动服务器
        {
            if(!IsRunning)
            {
                IsRunning = true;
                _serverSocket.Bind(new IPEndPoint(Address, Port));
                _serverSocket.Listen(1024);
                _serverSocket.BeginAccept(new AsyncCallback(HandleAcceptConnect), _serverSocket);
            }
        }

        public void Stop()//停止服务器
        {
            if(IsRunning)
            {
                IsRunning = false;
                _serverSocket.Close();
            }
        }

        private void HandleAcceptConnect(IAsyncResult ar)//处理客户端连接
        {
            if(IsRunning)
            {
                Socket server = (Socket)ar.AsyncState;
                Socket client = server.EndAccept(ar);//异步接受传入的连接尝试
                if(_clientCount < _maxClient)
                {
                    AsyncSocketState state = new AsyncSocketState(client);
                    lock(_clients)
                    {
                        _clients.Add(state);
                        _clientCount++;
                        RaiseClientConnected(state);
                    }
                    ReveiveDataBuffer = new byte[client.ReceiveBufferSize];
                    client.BeginReceive(ReveiveDataBuffer, 0, ReveiveDataBuffer.Length, SocketFlags.None, new AsyncCallback(HandleDataReceived),state);
                }
                else
                {
                    RaiseOtherException(null);
                }
                server.BeginAccept(new AsyncCallback(HandleAcceptConnect), ar.AsyncState);
            }
        }

        private void HandleDataReceived(IAsyncResult ar)//处理客户端数据
        {
            if(IsRunning)
            {
                AsyncSocketState state = (AsyncSocketState)ar.AsyncState;
                Socket client = state.ClientSocket;
                try
                {
                    int receive = client.EndReceive(ar);
                    if(receive == 0)
                    {
                        CloseSocket(state);
                        RaisedNetError(state);
                        return;
                    }
                    RaisedDataReceived(state);
                    Length = receive;
                    IsReceiveData = true;
                }
                catch
                {
                    RaisedNetError(state);
                }
                finally
                {
                    client.BeginReceive(ReveiveDataBuffer, 0, ReveiveDataBuffer.Length, SocketFlags.None, new AsyncCallback(HandleDataReceived), state);//继续接受来自客户端的数据
                }
            }
        }

        public void Send(byte[] data)
        {
            foreach (AsyncSocketState item in _clients)
            {
                item.ClientSocket.BeginSend(data, 0, data.Length, SocketFlags.None, null, item);
            }
        }

        #region Event
        public event EventHandler<AsyncSocketEventArgs> ClientConnected;//与客户端连接事件

        private void RaiseClientConnected(AsyncSocketState state)
        {
            ClientConnected?.Invoke(this, new AsyncSocketEventArgs(state));
        }

        public event EventHandler<AsyncSocketEventArgs> ClientDisconnected;//客户端连接断开事件

        private void RaisedClientDisConnected(Socket client)
        {
            ClientDisconnected?.Invoke(this, new AsyncSocketEventArgs("连接断开"));
        }

        public event EventHandler<AsyncSocketEventArgs> DataReceived;

        private void RaisedDataReceived(AsyncSocketState state)
        {
            DataReceived?.Invoke(this, new AsyncSocketEventArgs(state));
        }

        public event EventHandler<AsyncSocketEventArgs> CompletedSend;
        private void RaisedCompletedSend(AsyncSocketState state)
        {
            CompletedSend?.Invoke(this, new AsyncSocketEventArgs(state));
        }

        public event EventHandler<AsyncSocketEventArgs> NetError;//网络错误事件
        private void RaisedNetError(AsyncSocketState state)
        {
            NetError?.Invoke(this, new AsyncSocketEventArgs(state));
        }

        public event EventHandler<AsyncSocketEventArgs> OtherException;
        private void RaiseOtherException(AsyncSocketState state,string descrip)
        {
            OtherException?.Invoke(this, new AsyncSocketEventArgs(descrip, state));
        }

        private void RaiseOtherException(AsyncSocketState state)
        {
            RaiseOtherException(state, "");
        }

        #endregion

        #region Close
        public void CloseSocket(AsyncSocketState state)
        {
            if(state != null)
            {
                _clients.Remove(state);
                _clientCount--;
                state.Close();//触发关闭事件
            }
        }

        public void Close()
        {
            foreach (AsyncSocketState item in _clients)
            {
                CloseSocket(item);
            }
            _clientCount = 0;
            _clients.Clear();
        }
        #endregion

        #region IDisposable Support
        private bool disposedValue = false; // 要检测冗余调用

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 释放托管状态(托管对象)。
                    try
                    {

                    }
                    catch
                    {

                    }
                }

                // TODO: 释放未托管的资源(未托管的对象)并在以下内容中替代终结器。
                // TODO: 将大型字段设置为 null。
                disposedValue = true;
            }
        }

        // TODO: 仅当以上 Dispose(bool disposing) 拥有用于释放未托管资源的代码时才替代终结器。
        // ~AnsyncSocketTCPServer() {
        //   // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
        //   Dispose(false);
        // }

        // 添加此代码以正确实现可处置模式。
        public void Dispose()
        {
            // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
            Dispose(true);
            // TODO: 如果在以上内容中替代了终结器，则取消注释以下行。
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
