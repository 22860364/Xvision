using System.Collections.Generic;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.UserManagement
{
    public class User//用户类  操作员 管理员 程序员 都是用户 只是定义不同 权限高低不同而已 
    {
        public User(UserTypeEnum userType,string password, DisplayPurview displayPurview, IOPurview ioPurview,CoordinatePurview coordinatePurview)
        {
            UserType = userType;
            PassWord = password;
            PurviewList.Add(displayPurview);
            PurviewList.Add(ioPurview);
            PurviewList.Add(coordinatePurview);
        }

        public UserTypeEnum UserType { get; set; }//用户

        public string PassWord { get; set; }//密码       

        public List<PurviewSetBase> PurviewList = new List<PurviewSetBase>();//权限集合
    }
}
