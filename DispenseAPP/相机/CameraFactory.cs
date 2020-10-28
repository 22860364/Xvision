namespace DispenseAPP
{
    public class CameraFactory
    {
        public static ICameraable CreateCamera(string vendor)
        {
            ICameraable iCamera = null;
            switch(vendor)
            {
                case "Basler":
                    iCamera = new BaslerCamera();
                    break;
                case "HIKVISION":
                    break;
            }
            return iCamera;
        }
    }
}
