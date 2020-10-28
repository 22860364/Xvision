using System;
namespace DispenseAPP.AboutData
{
    [Serializable]
    public class CameraDataClass
    {
        public string CameraID { get; set; }//相机ID

        public string CustomName { get; set; }//自定义名称

        public bool AutoConnect { get; set; }//自动连接
    }
}
