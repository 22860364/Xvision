using DispenseAPP.AboutData;
using System.Collections.Generic;
using System;
using DispenseAPP.Tools_Location.ProgramDispensePath.DisplayImagePath;

namespace DispenseAPP
{
    [Serializable]
    public class LocalParamClass //本地参数和项目无关
    {
        public List<CameraDataClass> cameraDataClass = new List<CameraDataClass>();//相机参数

        public List<MCDataClass> MCDataList = new List<MCDataClass>();//运动控制卡数据类

        public CrossParamClass crossParamClass = new CrossParamClass();//十字线参数

        public RoadMapParamClass roadMapParamClass = new RoadMapParamClass();//路径图参数 
    }
}
