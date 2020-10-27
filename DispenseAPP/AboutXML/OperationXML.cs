using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DispenseAPP.AboutXML
{
    public static class OperationXML
    {
        public static void SetDefaultProject(string value)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Application.StartupPath + "\\Project\\ProjectInfo.xml");
            DataTable dt = ds.Tables["Softimite"];
            dt.Rows[0]["CurrentProjectPath"] = value;
            ds.AcceptChanges();
            ds.WriteXml(Application.StartupPath + "\\Project\\ProjectInfo.xml");
        }

        public static string GetDefautProject()
        {
            string value = null;
            XmlReader reader = new XmlTextReader(Application.StartupPath + "\\Project\\ProjectInfo.xml");
            XmlDocument dc = new XmlDocument();
            dc.Load(reader);
            XmlNode root = dc.DocumentElement;
            XmlNode node = root.SelectSingleNode("CurrentProjectPath");
            if (node != null && node.InnerText != "")
            {
                value =  node.InnerText;
            }
            reader.Close();
            reader.Dispose();
            return value;
        }
    }
}
