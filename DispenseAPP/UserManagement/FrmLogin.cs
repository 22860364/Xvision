using DispenseAPP.CustomControl;
using System;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    public partial class FrmLogin : FormM
    {
        string passWord = null;
        UserTypeEnum _userType;
        bool _userLock;

        public FrmLogin(UserTypeEnum userType, bool userLock = false)
        {
            InitializeComponent();
            Cmb_User.SelectedIndex = Cmb_User.Items.IndexOf(userType.ToString());
            ChangeCommon(userType);
            _userLock = userLock;
            if (_userLock)
            {
                Cmb_User.Enabled = false;
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if(Txt_PassWord.Text == passWord)
            {
                CurrentUserType = _userType;
                StaticPublicData.SystemData.LastLoginUser = _userType;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("密码输入错误！请重新输入，如忘记密码请与管理员联系!", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_PassWord.Clear();
                Txt_PassWord.Focus();
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        void ChangeCommon(UserTypeEnum userType)
        {
            _userType = userType;
            switch (userType)
            {
                case UserTypeEnum.操作员:
                    passWord = StaticUserParamClass.Operator.PassWord;
                    break;
                case UserTypeEnum.管理员:
                    passWord = StaticUserParamClass.Administrator.PassWord;
                    break;
                case UserTypeEnum.程序员:
                    passWord = StaticUserParamClass.Programmer.PassWord;
                    break;

            }
        }

        private void Cmb_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Cmb_User.SelectedIndex >=0)
            {
                ChangeCommon((UserTypeEnum)Enum.Parse(typeof(UserTypeEnum), Cmb_User.Text));
                Txt_PassWord.Clear();
                Txt_PassWord.Focus();
            }
        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            Txt_PassWord.Focus();
        }
    }
}
