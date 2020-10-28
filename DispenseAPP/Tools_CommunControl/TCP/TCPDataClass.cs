using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP.AboutData
{
    public enum TCPType
    {
        Server,
        Client,
    }

    [Serializable]
    public class TCPDataClass
    {
        public TCPType Type { get; set; }

        public string IPAddress { get; set; }

        public int Port { get; set; }
    }
}
