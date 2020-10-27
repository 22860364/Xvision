using DispenseAPP.AttributeClass;
using HalconDotNet;
using System;
using System.Collections.Generic;
using System.IO;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    [Serializable]
    [ReferenceImage]
    public class ImportImageClass : ITools //导入图像
    {
        public ImportImageClass()
        {
            ToolsKitName = ToolsKitNameEnum.ImageIO;
            ToolsName = ToolsNameEnum.ImportImage;
        }

        [Reference(true)]
        public string FilePath { get => _filePath; set => _filePath = value; }
        [Reference(true)]

        public string FileName { get => _fileName; set => _fileName = value; }
        [Reference(true)]
        public string BaseName { get => _baseName; set => _baseName = value; }

        public string imagePath = "";

        [NonSerialized]
        private HImage _image;

        [ReferenceImage]
        public HImage Image { get => _image; set => _image = value; }

        public bool CycleLoading { get; set; } = true;//循环加载

        public bool ImageBackup { get; set; } = true;//图像备份

        [NonSerialized]
        private List<string> pathList;

        [NonSerialized]
        private string _baseName = "";

        [NonSerialized]
        private string _fileName = "";

        [NonSerialized]
        private string _filePath = "";

        public override void Execute(UC_Image imageWindow)
        {
            string currentImagePath = null;
            if (pathList == null)
            {
                pathList = new List<string>();
            }
            if (CycleLoading == true && IsRunState == true)//只有当循环加载为真并且运行模式才会循环读取图片
            {
                if (pathList.Count == 0)//当存放图像路径的集合为空时 则添加
                {
                    string extension = Path.GetExtension(imagePath);//获得扩展名 循环加载只是遍历相同扩展名的文件
                    DirectoryInfo info = new DirectoryInfo(Path.GetDirectoryName(imagePath));
                    foreach (FileInfo item in info.GetFiles("*" + extension))
                    {
                        pathList.Add(item.FullName);
                    }
                    pathList.Sort();
                }
                currentImagePath = pathList[pathList.Count - 1];
                pathList.Remove(currentImagePath);
            }
            else
            {
                currentImagePath = imagePath;
            }
            if (imagePath != "")
            {
                FileName = currentImagePath;
                FilePath = Path.GetDirectoryName(currentImagePath); //获得目录信息
                BaseName = Path.GetFileName(currentImagePath);//获取文件名和扩展名
            }
            if (File.Exists(currentImagePath))//首先需要判断文件是否存在
            {
                HImage image = new HImage();
                image.ReadImage(currentImagePath);//读取图片有没有可能出现异常？
                if (SelectedNormalBlock.WindowIndex != "不显示")
                {
                    imageWindow.DispImage(image, true);//将图片显示到界面上,并清空显示
                }
                if (ImageBackup == true)//图像备份
                {
                    if (Image != null && Image.IsInitialized())
                    {
                        Image.Dispose();
                    }
                    Image = image.Clone();
                }
                image.Dispose();
                ExecuteState = ExecuteStateEnum.OK;
                StepState = true;
                ExecuteResult = currentImagePath;
            }
            else
            {
                ExecuteState = ExecuteStateEnum.NG;
                ExecuteResult = "None";
                StepState = false;
            }
        }
    }
}
