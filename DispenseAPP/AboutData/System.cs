using System;
using System.Xml.Serialization;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.AboutData
{
    /// <summary>
    /// 系统数据
    /// </summary>
    [XmlRoot("SystemData")]
    [Serializable]
    public class System
    {
        /// <summary>
        /// 启用胶阀
        /// </summary>
        public bool EnableRubble = true;

        /// <summary>
        /// 启用CCD观察模式
        /// </summary>
        public bool EnableCCDObserveMode = false;

        /// <summary>
        /// 启用自动拍照
        /// </summary>
        public bool EnableAutoPhoto = true;

        /// <summary>
        /// 图像窗口数量
        /// </summary>
        public int ImageWindowCount = 1;

        /// <summary>
        /// 消息窗口数量
        /// </summary>
        public int MessageWindowCount = 1;

        /// <summary>
        /// 上一次选择的普通算子块名称
        /// </summary>
        public string LastSelectedBlockName { get; set; } = null;

        /// <summary>
        /// 上一次打开的文件 
        /// </summary>
        public string LastFilePath { get; set; } = null;

        /// <summary>
        /// 产量
        /// </summary>
        public ulong Yield { get; set; } = 0;

        /// <summary>
        /// 点胶时间
        /// </summary>
        public string DispenseTime { get; set; } = null;

        /// <summary>
        /// 上次登录的用户类型
        /// </summary>
        public UserTypeEnum LastLoginUser { get; set; } = UserTypeEnum.操作员;
    }
}
