using System.Collections.Generic;
using DispenseAPP.接口;
using System.Threading;
using DispenseAPP.AboutData;
using System.Windows.Forms;
using HalconDotNet;
using DispenseAPP.Tools_CommunControl.PLC.DLL;
using System.IO.Ports;

namespace DispenseAPP
{
    public enum ToolsKitNameEnum
    {
        ImageIO,
        Location,
        Measure,
        Other,
        Barcode,
        Commun,
        MotionControl,
    }

    public enum ToolsNameEnum
    {
        AcqImage,
        AcqSet,
        CacheImage,
        ExportImage,
        ImportImage,
        AutoCalib,
        ReviseROI,
        ContourMatching,
        CreateROI,
        FindLine,
        FindCircle,
        PathProgram,//点胶轨迹编程
        LaserMeasureHeight,//激光测高
        DelayTime,//延时
        LogicOperation,
        Script,
        VarSet,
        TCP_IP,
        PLC,
        Serial,
        GeometericalRelation,
    }

    public static class CommonClass
    {
        static CommonClass()
        {
            for (int i = 0; i < 10; i++) //初始化10个队列
            {
                Queue<HImage> hImages = new Queue<HImage>();
                ImageQueue.Add(hImages);
            }            
        }

        public static List<Thread> RunThreadList = new List<Thread>();//运行线程List

        public static bool IsRunState = false;//当前是否在运行状态
      
        public static Dictionary<string, ICameraable> CameraIDObjectDict = new Dictionary<string, ICameraable>();// 键(相机ID)值(相机对象)对集合
      
        public static Dictionary<string, AnsyncSocketTCPServer> ServerDict = new Dictionary<string, AnsyncSocketTCPServer>();//存放服务器端口和服务器对象的键值对集合

        public static Dictionary<string, Qs_Ent_Asc_Class> QsAscDict = new Dictionary<string, Qs_Ent_Asc_Class>();//存放PLC通讯名称和对象的键值对集合

        public static Dictionary<string, SerialPort> SerialDict = new Dictionary<string, SerialPort>();//存放串口通讯的键值对集合

        // 键（控制卡的名称）值（控制卡对象）对集合
        public static Dictionary<string, IMotionCard> MotionCardDict = new Dictionary<string, IMotionCard>();

        //存放窗口索引（键）和窗口对象
        public static Dictionary<int, UC_Image> WindowIndexDic = new Dictionary<int, UC_Image>();

        public static int  CurrentWindowIndex { get; set; } = 1;//当前窗口索引

        public static List<CameraDataClass> CameraDataDic = new List<CameraDataClass>();//存放相机数据的键值对集合

        public static string LocalParamPath = Application.StartupPath + "\\LocalParam.lp";

        public static List<Queue<HImage>> ImageQueue = new List<Queue<HImage>>();

        public static ProjectParamClass StaticProjectParamClass;//静态的项目文件

        public static LocalParamClass StaticLocalParamClass;//静态本地参数

        public static bool ProjectIsChange//方案是否更改
        {
            get;
            set;
        }

        public static bool CurrentWhetherNewProject
        {
            get;
            set;
        }

        public enum OutStateEnum : uint// DO输出状态
        {
            OFF = 0,
            ON = 1,
        }

        public enum ExecuteStateEnum//工具执行状态
        {
            OK,
            NG,
        }

        public enum JOGMotionDir : int// JOG运动方向
        {
            Negative = -1, //负向
            Positive = 1, //正向
        }

        public enum MotionMode : int// 运动模式
        {
            Absolute = 0,
            Relaitve = 1,
        }       

        public static bool CardContainsAxis(string cardName,string[] axisName)//卡中是否包含一个或多个轴
        {
            for (int i = 0; i < axisName.Length; i++)
            {
                if(MotionCardDict[cardName].McDataClass.AxisConfigList.Find(c=>c.AxisName == axisName[i]) == null)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
