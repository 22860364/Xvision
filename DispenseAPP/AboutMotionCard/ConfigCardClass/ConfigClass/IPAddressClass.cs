using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP.AboutMotionCard.ConfigCardClass
{
    [Serializable]
   public class IPAddressClass:IConfigCardable
    {
        public string IPAddress { get; set; } = "";
    }
}
