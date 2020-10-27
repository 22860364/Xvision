using DispenseAPP.AboutData;
using DispenseAPP.接口;

namespace DispenseAPP.MotionCardClass
{
    public class MotionCardFactory
    {
        public static IMotionCard CreateMotionCard(MCDataClass mCDataClass)
        {
            IMotionCard motionCard = null;
            switch (mCDataClass.Name.Split('_')[0])
            {
                case "ZMotion":
                    motionCard = new ZMClass(mCDataClass);
                    break;
                case "GTS":
                    motionCard = new GTSClass(mCDataClass);
                    break;
            }
            return motionCard;
        }
    }
}
