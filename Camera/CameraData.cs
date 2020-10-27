using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraLibrary
{
    public class CameraData    // 不用
    {
        public static CameraData InertData = new CameraData();
        public Bitmap bitmap = null;
        public HImage hImage = null;
    }
}
