using CameraLibrary;
using DispenseAPP.AboutData;
using DispenseAPP.Tools_Other.LogicOperation;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;
using DispenseAPP.FlowChart.Block;
using DispenseAPP.FlowChart.LineClass;

namespace DispenseAPP.FrmList
{
    public partial class FrmInitial : Form
    {
        public FrmInitial()
        {
            InitializeComponent();
        }

        private void FrmInitial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Timer.Stop();
            Timer.Dispose();
        }

        private void FrmInitial_Shown(object sender, EventArgs e)
        {
            BGW.RunWorkerAsync();
        }

        private void BGW_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            SetTextboxValue("正在加载本地参数...");
            LoadPublicData(LocalDataPath);
            Thread.Sleep(100);           
            SetTextboxValue("正在初始化相机...");
            InitialCamera();
            Thread.Sleep(100);
            SetTextboxValue("正在初始化工具...");
            InitialLogicOperation();
            Thread.Sleep(100);
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// 设置文本框的值
        /// </summary>
        void SetTextboxValue(string value)
        {
            Invoke(new Action(() =>
            {
                Lbl_Info.Text = value;
            }));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void BGW_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Timer.Start();
        }

        /// <summary>
        /// 加载本地参数
        /// </summary>
        /// <param name="path"></param>
        void LoadPublicData(string path)
        {
            StaticPublicData = new PublicData
            {
                CameraDataItems = DeserializerToXML<CameraDataItems>(LocalDataPath + "CameraData.xml"),
                SystemData = DeserializerToXML<AboutData.System>(LocalDataPath + "SystemData.xml"),
                SystemSetData = DeserializerToXML<SystemSetData>(LocalDataPath + "SystemSetData.xml"),
                BlockItems = DeserializerToXML<BlockItems>(LocalDataPath + "BlockData.xml"),
                LineItems = DeserializerToXML<LineItems>(LocalDataPath + "LineData.xml"),
            };
            DeserializerToBinary(LocalDataPath + "VarsData.sec", ref StaticPublicData.VariableData);
        }

        /// <summary>
        /// 初始化逻辑运算工具
        /// </summary>
        void InitialLogicOperation()
        {
            foreach (BlockItem item in StaticPublicData.BlockItems)
            {
                if (item is OperatorBlock normalBlock)
                {
                    foreach (IToolable items in normalBlock.ToolList)
                    {
                        if (items is LogicOperationToolEntity logicOperationClass)
                        {
                            logicOperationClass.ComputerExecuteTime();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 初始化相机
        /// </summary>
        void InitialCamera()
        {
            //第一步：获得当前搜索到的所有相机
            List<string> list = new List<string>();
            var atype = typeof(ICamerable);//获得接口的类型 
            Assembly assembly = Assembly.LoadFrom(Application.StartupPath + "\\CameraLibrary.dll");
            foreach (Type item in assembly.GetTypes())//遍历当前程序集中的所有类型
            {
                if (item.IsClass && item.IsSubclassOf(atype))
                {
                    ICamerable camera = Activator.CreateInstance(item) as ICamerable;
                    list.AddRange(camera.GetCameraList());
                }
            }
            //第二步：创建相机对象、连接相机、添加到键值对集合中    这里需要考虑2中情况 1.相机没有检测到 也就是状态栏没有显示 2.状态栏有显示是红色的
            foreach (string item in list)
            {
                if (StaticPublicData.CameraDataItems[item] != null && StaticPublicData.CameraDataItems[item].AutoConnect == false)
                {
                    continue;
                }
                ICamerable cameraObject = CameraFactory.CreateCameraObject(item.Split(':')[0]);//根据厂商名称创建对应的相机
                cameraObject.InitialCamera(item.Split(':')[1]);
                CameraIDObjectDict.Add(item, cameraObject);
                if (StaticPublicData.CameraDataItems[item] == null)
                {
                    StaticPublicData.CameraDataItems.Add(new CameraDataItem
                    {
                        SystemName = item,
                        CustomName = item.Split(':')[1],
                        AutoConnect = true
                    });
                }
            }
            
        }
    }
}
