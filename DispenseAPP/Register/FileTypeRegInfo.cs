using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP
{
    public class FileTypeRegInfo //文件类型注册信息
    {
        public string ExtendName;//扩展名

        public string Description;//描述

        public string IconPath;//关联的图标路径

        public string ExePath;//应用程序路径

        public FileTypeRegInfo(){}

        public FileTypeRegInfo(string extendName)
        {
            ExtendName = extendName;
        }
    }
}
