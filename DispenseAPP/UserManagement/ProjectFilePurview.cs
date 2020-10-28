namespace DispenseAPP.UserManagement
{
    public class ProjectFilePurview : PurviewSetBase//文件权限设置
    {
        public override string PurviewTypeName
        {
            get
            {
                return "项目文件";
            }
        }

        public bool 新建 = true;
        public bool 打开 = true;
        public bool 保存 = true;
        public bool 另存为 = true;
    }
}
