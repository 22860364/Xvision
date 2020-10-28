using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP
{
    public class FileTypeRegister //注册自定义的文件类型
    {
        public static void RegisterFileType(FileTypeRegInfo regInfo)//使文件类型与对应的图标及应用程序关联起来
        {
            if (FileTypeRegistered(regInfo.ExtendName))
            {
                return;
            }
            RegistryKey fileTypeKey = Registry.ClassesRoot.CreateSubKey(regInfo.ExtendName);
            string relationName = regInfo.ExtendName.Substring(1, regInfo.ExtendName.Length - 1).ToUpper() + "_FileType";
            fileTypeKey.SetValue("", relationName);
            fileTypeKey.Close();

            RegistryKey relationKey = Registry.ClassesRoot.CreateSubKey(relationName);
            relationKey.SetValue("", regInfo.Description);

            RegistryKey iconKey = relationKey.CreateSubKey("defaultIcon");
            iconKey.SetValue("", regInfo.IconPath);

            RegistryKey shellKey = relationKey.CreateSubKey("Shell");

            RegistryKey openKey = relationKey.CreateSubKey("Open");

            RegistryKey commandKey = openKey.CreateSubKey("Command");
            commandKey.SetValue("", regInfo.ExePath + "%1");//"%1"表示将被双击的文件路径传给目标应用程序
            relationKey.Close();
        }

        public static bool UpdateFileTypeRegInfo(FileTypeRegInfo regInfo)//更新指定文件类型关联信息
        {
            if (!FileTypeRegistered(regInfo.ExtendName))//没有注册则跳出 
            {
                return false;
            }
            string extendName = regInfo.ExtendName;
            string relationName = extendName.Substring(1, extendName.Length - 1).ToUpper() + "_FileType";
            RegistryKey relationKey = Registry.ClassesRoot.OpenSubKey(relationName, true);
            relationKey.SetValue("", regInfo.Description);
            RegistryKey iconKey = relationKey.OpenSubKey("DefaultIcon", true);
            iconKey.SetValue("", regInfo.IconPath);
            RegistryKey shellKey = relationKey.OpenSubKey("Shell");
            RegistryKey openKey = shellKey.OpenSubKey("Open");
            RegistryKey commandKey = openKey.OpenSubKey("Command", true);
            commandKey.SetValue("", regInfo.ExePath + "%1");
            relationKey.Close();
            return true;
        }

        public static FileTypeRegInfo GetFileTypeRegInfo(string extendName)
        {
            if (!FileTypeRegistered(extendName))//没有注册过返回null
            {
                return null;
            }
            FileTypeRegInfo regInfo = new FileTypeRegInfo(extendName);
            string relationName = extendName.Substring(1, extendName.Length - 1).ToUpper() + "_FileType";
            RegistryKey relationKey = Registry.ClassesRoot.OpenSubKey(relationName);
            regInfo.Description = relationKey.GetValue("").ToString();
            RegistryKey iconKey = relationKey.OpenSubKey("DefaultIcon");
            regInfo.IconPath = iconKey.GetValue("").ToString();
            RegistryKey shellKey = relationKey.OpenSubKey("Shell");
            RegistryKey openKey = shellKey.OpenSubKey("Open");
            RegistryKey commandKey = openKey.OpenSubKey("Command");
            string temp = commandKey.GetValue("").ToString();
            regInfo.ExePath = temp.Substring(0, temp.Length - 3);
            return regInfo;
        }


        public static bool FileTypeRegistered(string extendName)//指定文件类型是否已经注册 返回true表示已经注册过了
        {
            RegistryKey softwareKey = Registry.ClassesRoot.OpenSubKey(extendName);
            if (softwareKey != null)
            {
                return true;
            }
            return false;
        }
    }
}
