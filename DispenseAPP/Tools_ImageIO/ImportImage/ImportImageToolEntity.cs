using DispenseAPP.AttributeClass;
using System;
using System.Collections.Generic;
using System.IO;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    /// <summary>
    /// 导入图像工具
    /// </summary>
    [Serializable]
    [ReferenceImage]
    public class ImportImageToolEntity : IToolable
    {
        public ImportImageToolEntity()
        {
        }

        public string ImagePath { get; set; } = "";

        public bool CycleLoad { get; set; }

        public override ToolsKitNameEnum ToolKitName => ToolsKitNameEnum.ImageIO;

        public override string ToolName => "导入图像";

        List<string> FilePathList { get; set; } = null;

        public override void Execute()
        {
            string currentImagePath = null;
            if (FilePathList == null)
            {
                FilePathList = new List<string>();
            }
            if (CycleLoad == true && IsRunState == true)//只有当循环加载为真并且运行模式才会循环读取图片
            {
                if (FilePathList.Count == 0)//当存放图像路径的集合为空时 则添加
                {
                    string extension = Path.GetExtension(ImagePath);//获得扩展名 循环加载只是遍历相同扩展名的文件
                    DirectoryInfo info = new DirectoryInfo(Path.GetDirectoryName(ImagePath));
                    foreach (FileInfo item in info.GetFiles("*" + extension))
                    {
                        FilePathList.Add(item.FullName);
                    }
                    FilePathList.Sort();
                }
                currentImagePath = FilePathList[FilePathList.Count - 1];
                FilePathList.Remove(currentImagePath);
            }
            else
            {
                currentImagePath = ImagePath;
            }
            if (!System.IO.File.Exists(currentImagePath))//判断文件是否存在
            {
                SetNG(currentImagePath + "文件不存在！");
                return;
            }
            if (SelectedOperatorBlock.ImageWindowIndex != "不显示")
            {
                ImageWindowIndexDic[Convert.ToInt32(SelectedOperatorBlock.ImageWindowIndex)].Control.DispImage(currentImagePath);
            }
            SetOK(currentImagePath);
        }

        public override bool RunAgoCheck()
        {
            ErrorList.Clear();
            return ErrorList.Count == 0;
        }
    }
}
