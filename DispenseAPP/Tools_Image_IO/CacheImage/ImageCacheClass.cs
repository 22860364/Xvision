using HalconDotNet;
using System;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    [Serializable]

    public class ImageCacheClass :ITools
    {
        public ImageCacheClass()
        {
            ToolsKitName = ToolsKitNameEnum.ImageIO;
            ToolsName = ToolsNameEnum.CacheImage;
        }

        public string SelectNode { get; set; } = "";

        public bool ResetDisplay { get; set; }//重置显示

        public override void Execute(UC_Image imageWindow)
        {
            if(SelectNode != "")
            {
                string parentNodeText = SelectNode.Split('-')[0];
                string nodeText = SelectNode.Split('-')[1];
                if (parentNodeText  == "图像缓存")
                {
                    int index = Convert.ToInt32(nodeText.Substring(4));
                    HImage hImage = ImageQueue[index].Dequeue();//移除并返回位于开始处的对象
                    if(hImage != null && hImage.IsInitialized())
                    {
                        imageWindow.DispImage(hImage);//显示图片
                        hImage.Dispose();
                    }
                }
                else //为普通算子块中的工具输出
                {
                  NormalBlock normalBlock = ProjectParamClass._flowChartList.Find(c => c.Name == parentNodeText) as NormalBlock;//先找到对应的算子块
                    if(normalBlock != null) //算子块可能被人为删除
                    {
                        ITools tools = normalBlock.ToolsList.Find(c => c.BlockName == nodeText.Split('.')[0]);//找到对应的工具
                        if(tools != null)//工具可能被人为删除
                        {
                            HImage hImage = tools.GetType().GetProperty(SelectNode.Split('-')[1].Split('.')[1]).GetValue(tools) as HImage;//找到对应的属性
                            if(hImage !=null && hImage.IsInitialized())//可能会找不到图片或者相机连接失败 会造成图片为空的情况
                            {
                                imageWindow.DispImage(hImage);//显示图片
                            }
                            else
                            {
                                SetNGResult();
                                return;
                            }
                        }
                        else
                        {
                            SetNGResult();
                            return;
                        }
                    }
                    else
                    {
                        SetNGResult();
                        return;
                    }
                }
                ExecuteResult = SelectNode.Split('-')[1];
                ExecuteState = ExecuteStateEnum.OK;
                StepState = true;
            }
            else
            {
                SetNGResult();
            }
        }

        private void SetNGResult()
        {
            ExecuteResult = "None";
            ExecuteState = ExecuteStateEnum.NG;
            StepState = false;
        }
    }
}
