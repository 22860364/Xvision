namespace CameraLibrary
{
    public class CameraFactory //这里试着使用工厂方法模式或者抽象工厂模式 
    {
        public static ICamerable CreateCameraObject(string vendor)
        {
            ICamerable camerable = null;
            switch (vendor)
            {
                case "Basler":
                    camerable = new Basler();
                    break;
                case "HIKVISION":
                    camerable = new HIKVISION();
                    break;
            }
            return camerable;
        }
    }
}
