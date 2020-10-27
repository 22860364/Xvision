using HalconDotNet;

namespace VisionLibrary.Info
{
    public class GetImageInfo 
    {
        public static int GetImageChannel(HImage hImage)
        {
            return hImage.CountChannels();
        }
    }
}
