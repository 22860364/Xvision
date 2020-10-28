using System;
using static DispenseAPP.CommonClass;
using DispenseAPP.AttributeClass;
using CameraLibrary;
using System.Drawing;
using HalconDotNet;

namespace DispenseAPP
{
    [Serializable]
    [ReferenceImage]
    [UnableManualExecute]
    public class AcqImageToolEntity : IToolable
    {
        public AcqImageToolEntity()
        {
        }

        /// <summary>
        /// 相机对象
        /// </summary>
        ICamerable Camerable { get; set;} = null;

        /// <summary>
        /// 相机采集标记 当采集结束设置为true
        /// </summary>
        bool AcqFinshFlag { get; set;}

        /// <summary>
        /// 要进行采集的相机名称
        /// </summary>
        public string SelectedCameraName { get; set; } = null;

        public override ToolsKitNameEnum ToolKitName => ToolsKitNameEnum.ImageIO;

        public override string ToolName => "采集图像";

         void ImageCallBack(Bitmap bitmap,HImage hImage)
        {
            ImageWindowIndexDic[Convert.ToInt32(SelectedOperatorBlock.ImageWindowIndex)].Control.DispImage(bitmap, hImage);
            AcqFinshFlag = true;
        }

        public override void Execute()//在具体的工具的内部不去判断相关的实体对象 比如相机对象 通讯对象 控制卡对象的状态 是否存在
        {
            Camerable = CameraIDObjectDict[SelectedCameraName];
            Camerable.Register(ImageCallBack);//注册事件
            AcqFinshFlag = false;
            if(!Camerable.SingleFrameAcquisiton())//如果单帧采集返回了失败 应该怎么样去提示
            {
                SetNG(null);//应该在相机的内部增加超时时间设置 如果在设置的时间内还没有图像返回 
            }
            while (true)
            {
                if (AcqFinshFlag)
                {
                    break;
                }
            }
            SetOK(SelectedCameraName);
        }

        public override bool RunAgoCheck()
        {
            ErrorList.Clear();
            return ErrorList.Count == 0;
        }
    }
}
