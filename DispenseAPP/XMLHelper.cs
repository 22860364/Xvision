using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DispenseAPP
{
    /// <summary>
    /// 相关XML的操作类
    /// </summary>
    public class XMLHelper
    {
        /// <summary>
        /// 写入值
        /// </summary>
        public static void WriteValue(string path, string node, string value)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);
            XmlNode Node = xmlDocument.SelectSingleNode(node);
            if(Node == null)
            {
                XmlElement xmlElement = xmlDocument.DocumentElement;//得到根节点
                XmlNode xmlNode = xmlDocument.CreateNode("element", node, "");
                xmlNode.InnerText = value;
                xmlElement.AppendChild(xmlNode);
            }
            else
            {
                Node.Attributes[node].Value = value;
            }
            xmlDocument.Save(path);
        }

        public static string ReadValue(string path, string root, string node)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);
            XmlNode Node = xmlDocument.SelectSingleNode(root);
            return Node.Attributes[node].Value;
        }
    }
}
