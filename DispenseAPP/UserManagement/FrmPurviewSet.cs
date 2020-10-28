using DispenseAPP.CustomControl;
using DispenseAPP.UserManagement;
using System;
using System.Reflection;
using static DispenseAPP.CommonClass;
using System.Linq;
using System.Collections.Generic;

namespace DispenseAPP
{
    public partial class FrmPurviewSet : FormM//权限设置
    {
        User currentUser = null;//权限设置的用户
        public FrmPurviewSet(UserTypeEnum userType)
        {
            InitializeComponent();
            switch (userType)
            {
                case UserTypeEnum.操作员:
                    currentUser = StaticUserParamClass.Operator;
                    break;
                case UserTypeEnum.管理员:
                    currentUser = StaticUserParamClass.Administrator;
                    break;
                case UserTypeEnum.程序员:
                    currentUser = StaticUserParamClass.Programmer;
                    break;
            }         
        }

        private void Lb_CommunType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Lb_CommunType.SelectedIndex < 0)
            {
                return;           
            }
            InitialControl(Lb_CommunType.Text);
        }

        void InitialControl(string typeName)
        {
            foreach (PurviewSetBase item in currentUser.PurviewList)
            {
                if(item.PurviewTypeName == typeName)
                {
                   List<FieldInfo> propertyInfoList = item.GetType().GetFields().ToList();
                    Clb_Purview.Items.AddRange(propertyInfoList.Select(c => c.Name).ToArray());
                }
            }
        }
    }
}
