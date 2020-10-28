using DispenseAPP.FlowChart.Block;
using DispenseAPP.FlowChart.LineClass;
using System;
using System.Xml.Serialization;

namespace DispenseAPP.AboutData
{
    [Serializable]
    [XmlRoot("LocalData")]
    public class PublicData//公共参数 不随产品变化的参数
    {
        /// <summary>
        /// 相机数据
        /// </summary>
        public CameraDataItems CameraDataItems { get; set; } = new CameraDataItems();

        /// <summary>
        /// 系统数据
        /// </summary>
        public System SystemData { get; set; } = new System();

        /// <summary>
        /// 系统设置数据
        /// </summary>
        public SystemSetData SystemSetData { get; set; } = new SystemSetData();


        /// <summary>
        /// 算子块数据
        /// </summary>
        public BlockItems BlockItems { get; set; } = new BlockItems();

        /// <summary>
        /// 连接线数据
        /// </summary>
        public LineItems LineItems { get; set; } = new LineItems();

        /// <summary>
        /// 变量数据 使用二进制序列化保存
        /// </summary>
        public dynamic VariableData = new VarClass();

    }
}
