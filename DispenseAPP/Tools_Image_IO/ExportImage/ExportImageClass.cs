using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP
{
    [Serializable]
    public class ExportImageClass : ITools
    {
        public ExportImageClass()
        {
            ToolsKitName = ToolsKitNameEnum.ImageIO;
            ToolsName = ToolsNameEnum.ExportImage;
        }

        public string Path { get; set; }// 路径

        public string SubPath { get; set; }// 子路径

        public string FileName { get; set; }// 文件名

        public string ImageSource { get; set; }// 图像源

        public string ImageFormat { get; set; }// 图像格式

        public int MaxCount { get; set; }// 最大数目

        public bool useCacheArea { get; set; }// 启用缓存区

        public override void Execute(UC_Image imageWindow)
        {
           
        }
    }
}
