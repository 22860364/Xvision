using System;
using System.Windows.Forms;
using System.Xml;
using System.Collections;
using System.Data;

namespace DispenseAPP.MultiLanguage
{
    public class LanguageHelper//语言转换公共类
    {

        public static Language defaultLanguage = GetDefaultLanguage();

        public static void SetControlLanguageText(Form form)
        {
            Hashtable hashtable = ReadXMLText(form.Name, defaultLanguage);           
            if (hashtable == null)
            {
                return;
            }
            foreach (Control control in form.Controls)
            {
                SetContainerLanguage(control, hashtable);
            }
        }

        private static void SetContainerLanguage(Control ctrl, Hashtable hashtable)//设置容器类控件
        {
            if (ctrl is DataGridView)
            {
                try
                {
                    DataGridView dataGridView = ctrl as DataGridView;
                    foreach (DataGridViewColumn dgvc in dataGridView.Columns)
                    {
                        try
                        {
                            if (dgvc.HeaderText.ToString() != "" && dgvc.Visible)
                            {
                                if(hashtable.ContainsKey(dgvc.Name))
                                {
                                    dgvc.HeaderText = (string)hashtable[dgvc.Name];
                                }
                            }
                        }
                        catch { }
                    }
                }
                catch(Exception){ }
            }
           else if(ctrl is MenuStrip)
            {
                MenuStrip menuStrip = ctrl as MenuStrip;
                foreach (ToolStripMenuItem toolItem in menuStrip.Items)
                {
                    try
                    {
                        if(hashtable.ContainsKey(toolItem.Name))
                        {
                            toolItem.Text = (string)hashtable[toolItem.Name];
                        }
                    }
                    catch(Exception)
                    {
                    }
                    finally
                    {
                        if(toolItem.DropDownItems.Count >0)
                        {
                            GetItemText(toolItem, hashtable);
                        }
                    }
                }
            }          
            else if(ctrl is TreeView)
            {
                TreeView treeView = ctrl as TreeView;
                foreach (TreeNode node in treeView.Nodes)
                {
                    try
                    {
                        if(hashtable.ContainsKey(node.Name))
                        {
                            node.Text = (string)hashtable[node.Name];
                        }
                    }
                    catch(Exception)
                    {
                    }
                    finally
                    {
                        if(node.Nodes.Count>0 )
                        {
                            GetNodeText(node, hashtable);
                        }
                    }
                }
            }
            else if(ctrl is TabControl)
            {
                TabControl tabCtrl = ctrl as TabControl;
                try
                {
                    foreach (TabPage tabPage in tabCtrl.TabPages)
                    {
                        if (hashtable.ContainsKey(tabPage.Name))
                        {
                            tabPage.Text = (string)hashtable[tabPage.Name];
                        }
                    }
                }
                catch(Exception)
                {

                }
            }
            else if(ctrl is StatusStrip)
            {
                StatusStrip statusStrip = ctrl as StatusStrip;
                foreach (ToolStripItem toolItem in statusStrip.Items)
                {
                    try
                    {
                        if(hashtable.ContainsKey(toolItem.Name))
                        {
                            toolItem.Text = (string)hashtable[toolItem.Name];
                        }
                    }
                    catch(Exception)
                    {

                    }
                    finally
                    {
                        ToolStripDropDownButton tsDDBtn = toolItem as ToolStripDropDownButton;
                        if(tsDDBtn != null && tsDDBtn.DropDownItems.Count >0)
                        {
                            GetItemText(tsDDBtn,hashtable);
                        }
                    }
                }
            }
            else if(ctrl is ToolStrip)
            {
                ToolStrip toolStrip = ctrl as ToolStrip;
                foreach (ToolStripItem  toolItem in toolStrip.Items)
                {
                    try
                    {
                        if(hashtable.ContainsKey(toolItem.Name))
                        {
                            toolItem.Text = (string)hashtable[toolItem.Name];
                        }
                    }
                    catch(Exception)
                    {

                    }
                }
            }
            else if(ctrl is CheckedListBox)
            {
                CheckedListBox chkListBox = ctrl as CheckedListBox;
                try
                {
                    for (int i = 0; i < chkListBox.Items.Count; i++)
                    {
                        if(hashtable.ContainsKey(chkListBox.Items[i]))
                        {
                            chkListBox.Items[i] = (string)hashtable[chkListBox.Items[i]];
                        }                       
                    }
                }
                catch(Exception)
                {

                }
            }
            else if(ctrl is UserControl)
            {
                UserControl userControl = ctrl as UserControl;
                System.Reflection.FieldInfo[] fieldInfo = userControl.GetType().GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                for (int i = 0; i < fieldInfo.Length; i++)
                {
                   if (fieldInfo[i].FieldType.Name == "ContextMenuStrip")
                    {
                        ContextMenuStrip contextMenuStrip = (ContextMenuStrip)fieldInfo[i].GetValue(userControl);
                        foreach (ToolStripMenuItem toolItem in contextMenuStrip.Items)
                        {
                            try
                            {
                                if (hashtable.ContainsKey(toolItem.Name))
                                {
                                    toolItem.Text = (string)hashtable[toolItem.Name];
                                }
                            }
                            catch (Exception)
                            {
                            }
                            finally
                            {
                                if (toolItem.DropDownItems.Count > 0)
                                {
                                    GetItemText(toolItem, hashtable);
                                }
                            }
                        }
                    }
                }

            }
            if(ctrl.HasChildren)
            {
                foreach (Control c in ctrl.Controls)
                {
                    SetContainerLanguage(c, hashtable);
                }                
            }
            else
            {
                SetLanguage(ctrl, hashtable);
            }
        }

        private static void SetLanguage(Control ctrl,Hashtable hashtable)
        {
            if (ctrl is CheckBox)
            {
                CheckBox checkBox = ctrl as CheckBox;
                try
                {
                    if(hashtable.ContainsKey(checkBox.Name))
                    {
                        checkBox.Text = (string)hashtable[checkBox.Name];
                    }
                }
                catch (Exception)
                {
                }
            }
            else if (ctrl is Label)
            {
                Label label = ctrl as Label;
                try
                {
                    if (hashtable.ContainsKey(label.Name))
                    {
                        label.Text = (string)hashtable[label.Name];
                    }
                }
                catch (Exception)
                {
                }
            }

            else if (ctrl is Button)
            {
                Button button = ctrl as Button;
                try
                {
                    if (hashtable.ContainsKey(button.Name))
                    {
                        button.Text = (string)hashtable[button.Name];
                    }                    
                }
                catch (Exception)
                {
                }
            }
            else if (ctrl is GroupBox)
            {
                GroupBox groupBox = ctrl as GroupBox;
                try
                {
                    if (hashtable.ContainsKey(groupBox.Name))
                    {
                        groupBox.Text = (string)hashtable[groupBox.Name];
                    }
                }
                catch (Exception)
                {
                }
            }
            else if (ctrl is RadioButton)
            {
                RadioButton radioButton = ctrl as RadioButton;
                try
                {
                    if (hashtable.ContainsKey(radioButton.Name))
                    {
                        radioButton.Text = (string)hashtable[radioButton.Name];
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private static void GetItemText(ToolStripDropDownItem menuItem, Hashtable hashtable)//递归菜单
        {
            foreach (ToolStripItem toolItem in menuItem.DropDownItems)
            {
                try
                {
                    if (hashtable.ContainsKey(toolItem.Name))
                    {
                        toolItem.Text = (string)hashtable[toolItem.Name];
                    }
                }
                catch(Exception )
                {
                }
                finally
                {
                    if(toolItem is ToolStripDropDownItem)
                    {
                        ToolStripDropDownItem subMenuStrip = toolItem as ToolStripDropDownItem;
                        if(subMenuStrip.DropDownItems.Count >0)
                        {                       
                            GetItemText(subMenuStrip, hashtable);
                        }
                    }
                }
            }
        }

        private static void GetNodeText(TreeNode node,Hashtable hashtable)
        {
            foreach (TreeNode treeNode in node.Nodes)
            {
                try
                {
                    if(hashtable.ContainsKey(treeNode.Name))
                    {
                        treeNode.Text = (string)hashtable[treeNode.Name];
                    }
                }
                catch(Exception)
                {
                }
                finally
                {
                    if(treeNode.Nodes.Count >0)
                    {
                        GetNodeText(treeNode, hashtable);
                    }
                }
            }
        }

        public static void SetDefaultLanguage(Language language)//设置默认语言
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Application.StartupPath + "\\Language\\DefaultLanguage.xml");
            DataTable dt = ds.Tables["Softimite"];
            dt.Rows[0]["DefaultLanguage"] = language;
            ds.AcceptChanges();
            ds.WriteXml(Application.StartupPath + "\\Language\\DefaultLanguage.xml");
            defaultLanguage = language;
        }

        public static Language GetDefaultLanguage()//读取默认语言
        {
            Language defaultLanguage = Language.Chinese;
            XmlReader reader = new XmlTextReader(Application.StartupPath + "\\Language\\DefaultLanguage.xml");
            XmlDocument dc = new XmlDocument();
            dc.Load(reader);
            XmlNode root = dc.DocumentElement;
            XmlNode node = root.SelectSingleNode("DefaultLanguage");
            if (node != null)
            {
                defaultLanguage = (Language)Enum.Parse(typeof(Language),node.InnerText);
            }
            reader.Close();
            reader.Dispose();
            return defaultLanguage;
        }

        public static Hashtable ReadXMLText(string frmName, Language language)//从XML文件中读取要修改Text的内容
        {
            try
            {
                Hashtable hashtable = new Hashtable();
                XmlReader reader = null;
                if (!new System.IO.FileInfo(Application.StartupPath + "\\Language\\" + language.ToString() + ".xml").Exists)//判断语言的配置文件是否存在
                {
                    return null;
                }
                else
                {
                    reader = new XmlTextReader(Application.StartupPath + "\\Language\\" + language.ToString() + ".xml");
                }
                XmlDocument doc = new XmlDocument();
                doc.Load(reader);
                XmlNode root = doc.DocumentElement;
                XmlNodeList nodeList = root.SelectNodes("Form[Name='" + frmName + "']/Controls/Control");
                foreach (XmlNode node in nodeList)
                {
                    try
                    {
                        XmlNode node1 = node.SelectSingleNode("@name");
                        XmlNode node2 = node.SelectSingleNode("@text");
                        if (node1 != null)
                        {
                            hashtable.Add(node1.InnerText, node2.InnerText);
                        }
                    }
                    catch { }
                }
                reader.Close();
                reader.Dispose();
                return hashtable;
            }
            catch
            {
                return null;
            }
        }
    }
}
