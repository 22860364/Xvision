﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DispenseAPP
{
    public static class INIFile
    {
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileInt(string lpAppName, string lpKeyName, int nDefault, string lpFileName);

        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

        [DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

        public static string projectFilePath = Application.StartupPath + "\\项目文件\\";

        /// <summary>
        /// 读取int类型数值
        /// </summary>
        /// <returns></returns>
        public static int ReadInt(string section, string name, int def, string fileName)
        {
            return GetPrivateProfileInt(section, name, def, fileName);
        }

        /// <summary>
        /// 读取string字符串
        /// </summary>
        /// <param name="section"></param>
        /// <param name="name"></param>
        /// <param name="def"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string ReadString(string section, string name, string def, string fileName)
        {
            StringBuilder sb = new StringBuilder(2048);
            GetPrivateProfileString(section, name, def, sb, 2048, fileName);
            return sb.ToString();
        }

        /// <summary>
        /// 写入int数值[如果不存在 节-键，则自动创建]
        /// </summary>
        /// <param name="section"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="fileName"></param>
        public static void WriteInt(string section, string name, int intValue, string fileName)
        {
            WritePrivateProfileString(section, name, intValue.ToString(), fileName);
        }

        /// <summary>
        /// 写入string字符串
        /// </summary>
        /// <param name="section">节</param>
        /// <param name="name">键</param>
        /// <param name="stringValue">值</param>
        /// <param name="fileName">文件名</param>
        public static void WriteString(string section, string name, string stringValue, string fileName)
        {
            WritePrivateProfileString(section, name, stringValue, fileName);
        }

        /// <summary>
        /// 删除指定的节
        /// </summary>
        /// <param name="section"></param>
        /// <param name="fileName"></param>
        public static void DeleteSection(string section, string fileName)
        {
            WritePrivateProfileString(section, null, null, fileName);
        }

        /// <summary>
        /// 删除全部节
        /// </summary>
        /// <param name="fileName"></param>
        public static void DeleteAllSection(string fileName)
        {
            WritePrivateProfileString(null, null, null, fileName);
        }

        /// <summary>
        /// 读取指定的 节——键
        /// </summary>
        /// <param name="section"></param>
        /// <param name="name"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string ReadValue(string section, string name, string fileName)
        {
            StringBuilder sb = new StringBuilder(2048);
            GetPrivateProfileString(section, name, "", sb, 2048, fileName);
            return sb.ToString();
        }

        /// <summary>
        /// 写入指定的 节——键
        /// </summary>
        /// <param name="section"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="fileName"></param>
        public static void WriteValue(string section, string name, string value, string fileName)
        {
            WritePrivateProfileString(section, name, value, fileName);
        }
    }
}
