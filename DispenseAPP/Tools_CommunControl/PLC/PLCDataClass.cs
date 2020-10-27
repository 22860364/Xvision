using System;

namespace DispenseAPP.AboutData
{
    [Serializable]
    public class PLCDataClass
    {
        public PLCDataClass(string localIP,string remoteIP,ushort remotePort)
        {
            LocalIP = localIP;
            RemoteIP = remoteIP;
            RemotePort = remotePort;
        }
        public string LocalIP { get; set; }//本地IP

        public string RemoteIP { get; set; }//远程IP

        public ushort RemotePort { get; set; }//远程端口
    }
}
