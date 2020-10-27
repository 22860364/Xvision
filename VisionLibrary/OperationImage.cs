using HalconDotNet;

namespace VisionLibrary
{
    public class OperationImage//操作图像类
    {
        public HImage RotateImage(HImage inputImage, double angle, string interpolation)//旋转图像
        {
            return inputImage.RotateImage(angle, interpolation);
        }

        public HImage MirrorImage(HImage inputImage, string mode)//镜像图像
        {
            return inputImage.MirrorImage(mode);
        }
    }
}
