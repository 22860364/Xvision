namespace DispenseAPP.UserManagement
{
    public class DisplayPurview: PurviewSetBase
    {
        public DisplayPurview(bool dispWorkFlowChartForm)
        {
            显示流程图界面 = dispWorkFlowChartForm;
        }

        public bool 显示流程图界面 = true;

        public override string PurviewTypeName
        {
            get
            {
                return "显示";
            }
       }
    }
}
