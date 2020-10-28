using DispenseAPP.Tools_Location.ContourMatchin;
using System;
using System.Xml.Serialization;

namespace DispenseAPP.AboutData
{
    [Serializable]
    public class CameraDataItem
    {
        /// <summary>
        /// 无参构造函数用于序列化
        /// </summary>
        public CameraDataItem()
        {
        }

        /// <summary>
        /// 表示存储相机对象的相关数据
        /// </summary>
        /// <param name="systemName">系统名称</param>
        /// <param name="customName">用户自定义名称</param>
        /// <param name="autoConnect">开启软件自动连接</param>
        public CameraDataItem(string systemName,string customName,bool autoConnect)
        {
            SystemName = systemName;
            CustomName = customName;
            AutoConnect = autoConnect;
        }

        /// <summary>
        /// 相机的系统名称（格式为  厂商:序列化）
        /// </summary>
        public string SystemName { get; set; } = null;

        /// <summary>
        /// 用户自定义名称
        /// </summary>
        public string CustomName { get; set; } = null;

        /// <summary>
        /// 开启软件自动连接
        /// </summary>
        public bool AutoConnect { get; set; } = false;

        /// <summary>
        /// X方向分辨率
        /// </summary>
        public float RotioX { get; set; } = 0.02f;

        /// <summary>
        /// Y方向分辨率
        /// </summary>
        public float RotioY { get; set; } = 0.02f;

        /// <summary>
        /// 该相机标定的定位算法
        /// </summary>
        [XmlElement("VisionProcessOfCalib")]
        public SearchOfContourToolEntity ToolEntity { get; set; } = new SearchOfContourToolEntity();
    }
}
