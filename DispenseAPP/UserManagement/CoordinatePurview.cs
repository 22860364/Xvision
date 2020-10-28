using System;

namespace DispenseAPP.UserManagement
{
    [Serializable]
    public class CoordinatePurview:PurviewSetBase//坐标系权限设置
    {
        public CoordinatePurview(bool editCoordinate,bool updatePosition,bool location)
        {
            编辑坐标系 = editCoordinate;
            更新坐标 = updatePosition;
            定位 = location;
        }

        public bool 编辑坐标系 = true;
        public bool 更新坐标 = true;
        public bool 定位 = true;

        public override string PurviewTypeName
        {
            get
            {
                return "坐标系";
            }
        }
    }
}
