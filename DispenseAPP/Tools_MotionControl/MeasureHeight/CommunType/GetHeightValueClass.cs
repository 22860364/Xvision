using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP.Tools_MotionControl.MeasureHeight.Commun
{
    public abstract class GetHeightValueClass
    {
        public abstract bool ReadHeightValue(out float value);
    }
}
