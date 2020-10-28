namespace DispenseAPP.UserManagement
{
    public class IOPurview:PurviewSetBase//IO权限设置
    {
        public IOPurview(bool editIO)
        {
            编辑IO = editIO;
        }

        public bool 编辑IO = true;//增加 删除 更改端口 更改名称 操作输出信号

        public override string PurviewTypeName
        {
            get
            {
                return "IO";
            }
        }
    }
}
