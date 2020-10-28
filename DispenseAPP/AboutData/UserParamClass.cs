using DispenseAPP.UserManagement;
using System;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.AboutData
{
    [Serializable]
    public class UserParamClass
    {
        public User Operator = new User(UserTypeEnum.操作员, "123456",new DisplayPurview(false),new IOPurview(false),new CoordinatePurview(false,false,false));

        public User Administrator = new User(UserTypeEnum.管理员, "190516",new DisplayPurview(false),new IOPurview(true),new CoordinatePurview(false,true,true));

        public User Programmer = new User(UserTypeEnum.程序员, "19960730",new DisplayPurview(true),new IOPurview(true),new CoordinatePurview(true,true,true));

        
    }
}
