namespace DispenseAPP
{
    public class Message 
    {
        /// <summary>
        /// 使用指定的参数实例化消息
        /// </summary>
        /// <param name="time">时间</param>
        /// <param name="stepName">算子块名</param>
        /// <param name="toolName">工具名</param>
        /// <param name="runMessage">运行消息</param>
        /// <param name="expectionMessage">异常消息</param>
        public Message(string time,string stepName,string toolName,string runMessage,string expectionMessage)
        {
            Time = time;
            StepName = stepName;
            ToolName = toolName;
            RunMessage = runMessage;
            ExceptionMessage = expectionMessage;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public Message()
        {
        }

        /// <summary>
        /// 时间
        /// </summary>
        public string Time { get; set; } = "";

        /// <summary>
        /// 算子名
        /// </summary>
        public string StepName { get; set; } = "";

        /// <summary>
        /// 工具名
        /// </summary>
        public string ToolName { get; set; } = "";

        /// <summary>
        /// 运行消息
        /// </summary>
        public string RunMessage { get; set; } = "";

        /// <summary>
        /// 异常消息
        /// </summary>
        public string ExceptionMessage { get; set; } = "";
    }
}
