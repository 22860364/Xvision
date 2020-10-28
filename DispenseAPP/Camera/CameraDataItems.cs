using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP.AboutData
{
    public class CameraDataItems:List<CameraDataItem>
    {
        public CameraDataItem this[string systemName]
        {
            get
            {
                return Find(c => c.SystemName == systemName);
            }
        }
    }
}
