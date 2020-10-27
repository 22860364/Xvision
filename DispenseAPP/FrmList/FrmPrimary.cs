using DispenseAPP.CustomControl;
using System;
using System.Windows.Forms;
using DispenseAPP.MultiLanguage;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static DispenseAPP.CommonClass;
using System.Threading;
using DispenseAPP.FrmList;
using DispenseAPP.Tools_CommunControl;
using System.Reflection;
using System.Collections.Generic;
using System.Drawing;
using DispenseAPP.AboutData;
using System.ComponentModel;
using DispenseAPP.接口;
using DispenseAPP.MotionCardClass;
using System.Diagnostics;

namespace DispenseAPP
{
    public delegate void ClickToolsDelegate(ToolsNameEnum toolsName, ITools tools);
    public delegate void DisplayMessageDelegate(string value, Color color);//显示消息委托
    public delegate void ClickOKButtonDelegate(ITools toolsParam);//自定义工具控件确认按钮委托
    public delegate void ClickOKDelegate();
    public delegate void ClickCancelDelegate();//自定义工具控件取消按钮委托
    public delegate void EditConfirmDelegate(object anyType);//任意类型窗体回传值委托
    public enum Language
    {
        English,
        Chinese,
    }

    public enum CurrentFrmEnum //当前界面
    {
        FrmRun,
        FrmEdit,
        FrmWorkFlow,
    }

    public partial class FrmPrimary : FormM, INotifyPropertyChanged
    {

        FrmEdit _frmEdit;

        FrmRun _frmRun;

        private ProjectParamClass projectParam = new ProjectParamClass();

        private LocalParamClass localParamClass = new LocalParamClass();

        private string _currentProjectPath = "";
        public string CurrentProjectPath
        {
            get { return _currentProjectPath; }
            set
            {
                _currentProjectPath = value;
                MyDataBindingsClass.NotifyPropertyChanged(this, () => CurrentProjectPath, PropertyChanged);
            }
        }

        private CurrentFrmEnum currentFrm;//当前界面 当设置属性时设置一些按钮的显示状态
        private CurrentFrmEnum CurrentFrm
        {
            get { return currentFrm; }
            set
            {
                currentFrm = value;
                switch (value)
                {
                    case CurrentFrmEnum.FrmEdit:
                        Tbtn_UI_Run.Visible = true;
                        Tbtn_UI_FlowChart.Visible = true;
                        Tbtn_UI_Debug.Visible = false;
                        Tbtn_Back.Visible = false;
                        break;
                    case CurrentFrmEnum.FrmRun:
                        Tbtn_Back.Visible = true;
                        Tbtn_UI_Run.Visible = false;
                        Tbtn_UI_Debug.Visible = false;
                        Tbtn_UI_FlowChart.Visible = false;
                        break;
                    case CurrentFrmEnum.FrmWorkFlow:
                        Tbtn_UI_Run.Visible = true;
                        Tbtn_UI_Debug.Visible = true;
                        Tbtn_Back.Visible = false;
                        Tbtn_UI_FlowChart.Visible = false;
                        break;
                }
            }
        }

        public FrmPrimary(string projectName)
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); //禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); //双缓冲
            CurrentProjectPath = projectName;
            lbl_ProjectName.DataBindings.Add("Text", this, "CurrentProjectPath");
            CurrentFrm = CurrentFrmEnum.FrmWorkFlow;//默认打开的界面为流程界面
            ReadProjectParam(CurrentProjectPath);//读取项目文件
            LoadLocalParam(LocalParamPath);//读取本地参数
            InitializeAboutControl();//初始化控件
            InitialCamera();//初始化相机
            InitialMotionCard();//初始化运动控制卡
            StaticProjectParamClass = projectParam;
            StaticLocalParamClass = localParamClass;
        }

        private void FrmPrimary_Load(object sender, EventArgs e)
        {
            if (!FileTypeRegister.FileTypeRegistered(".sec"))
            {
                FileTypeRegInfo fileTypeRegInfo = new FileTypeRegInfo(".sec");
                fileTypeRegInfo.Description = "项目文件";
                fileTypeRegInfo.ExePath = Application.ExecutablePath;
                fileTypeRegInfo.ExtendName = ".sec";
                fileTypeRegInfo.IconPath = Application.ExecutablePath;
                //注册
                FileTypeRegister fileTypeRegister = new FileTypeRegister();
                FileTypeRegister.RegisterFileType(fileTypeRegInfo);
            }
        }

        private void InitializeAboutControl()
        {
            WindowIndexDic.Clear();
            _frmEdit = new FrmEdit(projectParam);
            _frmEdit.JumpToDebug += _frmEdit_JumpToDebug;
            _frmEdit.AddControlType = ToPanelControl.WorkFlowControl;
            ControlClass.AddControlToPanel(_frmEdit, panel_FrmEditRun);//这里决定了Panel中显示什么 要分两种情况 1.当前界面为调试界面或流程界面 2.当前界面为自动运行界面
            _frmRun = new FrmRun(projectParam);
            if (LanguageHelper.defaultLanguage != Language.Chinese)
            {
                LanguageHelper.SetControlLanguageText(this);
            }
        }

        private void _frmEdit_JumpToDebug()//跳转到调试界面  将当前按钮切换为图像流程图界面
        {
            _frmEdit.AddControlType = ToPanelControl.ImageControl;
            CurrentFrm = CurrentFrmEnum.FrmEdit;
        }

        #region 切换界面
        private void Tbtn_USWorkFlow_Click(object sender, EventArgs e) //点击流程界面按钮
        {
            _frmEdit.AddControlType = ToPanelControl.WorkFlowControl;
            CurrentFrm = CurrentFrmEnum.FrmWorkFlow;
        }

        private void Tbtn_USImage_Click(object sender, EventArgs e)//点击图像界面按钮
        {
            _frmEdit.AddControlType = ToPanelControl.ImageControl;
            CurrentFrm = CurrentFrmEnum.FrmEdit;
        }

        private void Tbtn_FrmRun_Click(object sender, EventArgs e)//点击运行界面
        {
            ControlClass.AddControlToPanel(_frmRun, panel_FrmEditRun);
            CurrentFrm = CurrentFrmEnum.FrmRun;
            _frmRun.SetPanelLayout();
        }

        private void Tbtn_Return_Click(object sender, EventArgs e)//点击返回
        {
            ControlClass.SendMessage(panel_FrmEditRun.Handle, ControlClass.WM_SETREDRAW, 0, IntPtr.Zero);//关闭重绘
            ControlClass.AddControlToPanel(_frmEdit, panel_FrmEditRun);
            if (_frmEdit.AddControlType == ToPanelControl.ImageControl)
            {
                CurrentFrm = CurrentFrmEnum.FrmEdit;
                _frmEdit.AddControlType = ToPanelControl.ImageControl;
            }
            else if (_frmEdit.AddControlType == ToPanelControl.WorkFlowControl)
            {
                CurrentFrm = CurrentFrmEnum.FrmWorkFlow;
            }
            _frmEdit.SetFormLayout(WindowState);
            ControlClass.SendMessage(panel_FrmEditRun.Handle, ControlClass.WM_SETREDRAW, 1, IntPtr.Zero);//开启重绘
            panel_FrmEditRun.Refresh();//强制刷新指定控件                    
        }
        #endregion

        #region 项目管理

        private void ReadProjectParam(string projectPath)//读取项目文件
        {
            if (projectPath != null && File.Exists(projectPath))
            {
                using (FileStream stream = new FileStream(projectPath, FileMode.Open))
                {
                    BinaryFormatter binaryF = new BinaryFormatter();
                    object objectClass = binaryF.Deserialize(stream);
                    projectParam = (ProjectParamClass)objectClass;
                    StaticProjectParamClass = projectParam;
                    stream.Close();
                    stream.Dispose();
                }
                CurrentWhetherNewProject = false;//打开之前的项目
            }
            else
            {
                CurrentWhetherNewProject = true;//新建项目
            }
        }

        private void SaveProjectParam(string path)//保存项目文件
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                BinaryFormatter bFormat = new BinaryFormatter();
                bFormat.Serialize(stream, projectParam);
                stream.Close();
                stream.Dispose();
            }
            stopwatch.Stop();
            MessageBox.Show(stopwatch.ElapsedMilliseconds.ToString());
            using (FileStream fs = new FileStream(LocalParamPath, FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, localParamClass);
                fs.Close();
                fs.Dispose();
            }
        }
        private void Tbtn_New_Click(object sender, EventArgs e)//新建方案
        {
            //如果当前项目被更改则需弹出提示框 询问用户是否需要保存已经更改的方案
            if (ProjectIsChange == true)
            {
                switch (MessageBox.Show("方案已更改，是否保存？", "保存", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1))
                {
                    case DialogResult.Yes:
                        SaveProjectParam(CurrentProjectPath);
                        NewProject();
                        break;
                    case DialogResult.No:
                        NewProject();
                        break;
                }
            }
            else
            {
                NewProject();
            }
            CurrentProjectPath = null;
        }

        private void NewProject()
        {
            CurrentWhetherNewProject = true;
            ProjectIsChange = false;
            projectParam = new ProjectParamClass();
            StaticProjectParamClass = projectParam;
            InitializeAboutControl();
        }

        private void Tbtn_Open_Click(object sender, EventArgs e)//打开方案
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "项目文件（*.sec）|*.sec";
                openFile.RestoreDirectory = true;//对话框关闭前还原当前目录
                openFile.Title = "打开项目";
                openFile.InitialDirectory = Application.StartupPath + "\\Project\\";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    if (ProjectIsChange == true)
                    {
                        switch (MessageBox.Show("方案已更改，是否保存？", "保存", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1))
                        {
                            case DialogResult.Yes:
                                SaveProjectParam(CurrentProjectPath);
                                OpenProject(openFile.FileName);
                                break;
                            case DialogResult.No:
                                OpenProject(openFile.FileName);
                                break;
                        }
                    }
                    else
                    {
                        OpenProject(openFile.FileName);
                    }
                }
            }
        }

        private void OpenProject(string fileName)
        {
            CurrentWhetherNewProject = false;
            ReadProjectParam(fileName);
            InitializeAboutControl();
            CurrentProjectPath = fileName;
            ProjectIsChange = false;
        }

        private void Tbtn_Save_Click(object sender, EventArgs e)//保存方案
        {
            if (CurrentProjectPath == "")//当前项目名称为空时
            {
                using (SaveFileDialog saveFile = new SaveFileDialog())
                {
                    saveFile.Filter = "项目文件（*.sec）|*.sec";
                    saveFile.RestoreDirectory = true;//对话框关闭前还原当前目录
                    saveFile.Title = "保存项目";
                    saveFile.InitialDirectory = Application.StartupPath + "\\Project\\";
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        CurrentProjectPath = saveFile.FileName;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            SaveProjectParam(CurrentProjectPath);
            ProjectIsChange = false;
        }

        private void Tbtn_SaveAs_Click(object sender, EventArgs e)//方案另存为
        {
            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.Filter = "项目文件（*.sec）|*.sec";
                saveFile.RestoreDirectory = true;//对话框关闭前还原当前目录
                saveFile.Title = "项目另存为";
                saveFile.InitialDirectory = Application.StartupPath + "\\Project\\";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    SaveProjectParam(saveFile.FileName);
                    CurrentProjectPath = saveFile.FileName;
                    ProjectIsChange = false;
                }
                else
                {
                    return;
                }
            }
        }

        private void Tsmi_退出_Click(object sender, EventArgs e)
        {
        }

        private void FrmPrimary_FormClosing(object sender, FormClosingEventArgs e)//程序关闭时
        {
            foreach (ICameraable item in CameraIDObjectDict.Values)//关闭连接的所有相机
            {
                item.StopAcquisition();
                item.DisposeCamera();
            }
            foreach (IMotionCard item in MotionCardDict.Values)
            {
                item.CloseMotionCard(out string errorMessage);
            }
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void LoadLocalParam(string path)
        {
            if (path != null && File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    LocalParamClass tempLocalParamClass = (LocalParamClass)binaryFormatter.Deserialize(fs);
                    foreach (FieldInfo item in tempLocalParamClass.GetType().GetFields())//遍历所有字段
                    {
                        if(item != null)
                        {
                            localParamClass.GetType().GetField(item.Name).SetValue(localParamClass, tempLocalParamClass.GetType().GetField(item.Name).GetValue(tempLocalParamClass));
                        }
                    }
                    fs.Close();
                    fs.Dispose();
                }
            }
        }
        #endregion

        #region 运行控制
        private void Tbtn_SingleRun_Click(object sender, EventArgs e)//单次运行
        {
            IsSigleRunMode = true;
            RunTempMethod();
        }

        private bool IsSigleRunMode = false;

        public event PropertyChangedEventHandler PropertyChanged;

        private void Tbtn_CycleRun_Click(object sender, EventArgs e)//循环运行
        {
            IsSigleRunMode = false;
            RunTempMethod();
        }

        private void RunTempMethod()//开始执行中间方法
        {
            if (currentFrm != CurrentFrmEnum.FrmRun && _frmEdit.AddControlType == ToPanelControl.WorkFlowControl)//如果是流程界面则跳转到图像窗口界面
            {
                CurrentFrm = CurrentFrmEnum.FrmEdit;
                _frmEdit.AddControlType = ToPanelControl.ImageControl;
            }
            SetRunModeControlEnable(false);
            IsRunState = true;
            Thread RunThread = new Thread(new ParameterizedThreadStart(RunMethod));
            RunThreadList.Add(RunThread);
            RunThread.IsBackground = true;
            RunThread.Start(RunThread);
        }

        private void RunMethod(object thread)
        {
            while (true)
            {
                foreach (ChartLine item in projectParam._chartLineList)
                {
                    if (item.StartBlock is StartBlock)
                    {
                        item.StartBlock.Execute((Thread)thread);
                    }
                }
                if (IsSigleRunMode)
                {
                    break;
                }
            }
            Invoke(new Action<bool>(SetRunModeControlEnable), true);
            IsRunState = false;
        }

        private void SetRunModeControlEnable(bool b)
        {
            Tbtn_New.Enabled = b;
            Tbtn_Open.Enabled = b;
            Tbtn_Save.Enabled = b;
            Tbtn_SaveAs.Enabled = b;
            Tbtn_Run.Enabled = b;
            Tbtn_Reset.Enabled = b;
            Tbtn_Loop.Enabled = b;
            Tbtn_UI_Run.Enabled = b;
            Tbtn_Back.Enabled = b;
            menuStrip.Enabled = b;
            _frmEdit.RunModeControlEnable(b);
        }

        private void Tbtn_Stop_Click(object sender, EventArgs e)//停止
        {
            IsSigleRunMode = true;
            //停止当前流程中开启的线程
            foreach (Thread item in RunThreadList)
            {
                if (item != null && item.ThreadState != System.Threading.ThreadState.Aborted)
                {
                    item.Abort();
                }
            }
            RunThreadList.Clear();
            Invoke(new Action<bool>(SetRunModeControlEnable), true);
        }

        private void Tbtn_Reset_Click(object sender, EventArgs e)//开启一个线程进行轴复位 界面不会卡死
        {
            Thread homeThread = new Thread(AxisHome)
            {
                IsBackground = true//设置为后台线程
            };
            homeThread.Start();
        }

        private void AxisHome()
        {
            Dictionary<int, List<MCDataClass>> homeOrderDict = new Dictionary<int, List<MCDataClass>>();//存放回零顺序和回零轴号的键值对集合
            for (int i = 1; i <= 5; i++)//卡和轴最多支持5个回零等级
            {
                List<MCDataClass> mCDataClassList = StaticLocalParamClass.MCDataList.FindAll(c => c.HomeOrder == i);
                if (mCDataClassList != null )
                {
                    homeOrderDict.Add(i, mCDataClassList);
                }
            }
            foreach (List<MCDataClass> item in homeOrderDict.Values)//在这里需要使用异步回零
            {
                foreach (MCDataClass items in item)//同一级别的回零任务
                {
                    MotionCardDict[items.Name].Home(out string error);
                }
            }
        }
        #endregion

        #region 语言设置
        private void Chinese中文ToolStripMenuItem_Click(object sender, EventArgs e)//点击中文
        {
            SetCurrentLanguage(Language.Chinese);
        }

        private void English英文ToolStripMenuItem_Click(object sender, EventArgs e)//点击英文
        {
            SetCurrentLanguage(Language.English);
        }

        private void SetCurrentLanguage(Language selectedLanguage)
        {
            if (selectedLanguage != LanguageHelper.defaultLanguage)
            {
                LanguageHelper.SetDefaultLanguage(selectedLanguage);
                LanguageHelper.SetControlLanguageText(this);
            }
        }
        #endregion

        private void Tsmi_ConfigWindow_Click(object sender, EventArgs e)//配置窗口
        {
            FrmConfigWindow frmConfigWindow = new FrmConfigWindow(projectParam);
            frmConfigWindow._clickOkButton += FrmConfigWindow__clickOkButton;
            frmConfigWindow.ShowDialog();
        }

        private void FrmConfigWindow__clickOkButton()//点击确定按钮重新配置窗口
        {
            _frmRun.SetPanelLayout();
        }

        private void FrmPrimary_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                _frmEdit.SetFormLayout(FormWindowState.Normal);
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                _frmEdit.SetFormLayout(FormWindowState.Maximized);
            }
        }

        private void 通信设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfigCommun frmConfigCommun = new FrmConfigCommun("TCP/IP");
            frmConfigCommun.ShowDialog();
        }

        private void 控制卡设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfigMotionCard frmConfigMotionCard = new FrmConfigMotionCard();
            if (frmConfigMotionCard.ShowDialog() == DialogResult.OK)//如果点击确定
            {

            }
        }

        private void InitialCamera()//初始化相机
        {
            //第一步：获得当前搜索到的所有相机
            List<string> list = new List<string>();
            var atype = typeof(ICameraable);//获得接口的类型 
            Type[] types = Assembly.GetCallingAssembly().GetTypes();//获得当前程序集中定义的类型
            foreach (Type item in types)//遍历当前程序集中的所有类型
            {
                Type[] type = item.GetInterfaces();
                foreach (Type items in type)
                {
                    if (items.FullName == atype.FullName)
                    {
                        ICameraable camera = Activator.CreateInstance(item) as ICameraable;
                        list.AddRange(camera.GetCameraList());
                    }
                }
            }
            //第二步：创建相机对象、连接相机、添加到键值对集合中
            foreach (string item in list)
            {
                if (CameraIDObjectDict.ContainsKey(item) == false)
                {
                    ICameraable cameraObject = CameraFactory.CreateCamera(item.Split(':')[0]);//根据厂商名称创建对应的相机
                    if (cameraObject.InitialCamera(item.Split(':')[1]))//相机连接成功
                    {
                        CameraIDObjectDict.Add(item, cameraObject);
                        if (localParamClass.cameraDataClass.Find(c => c.CameraID == item) == null)
                        {
                            CameraDataClass cameraDataClass = new CameraDataClass
                            {
                                CameraID = item,
                                CustomName = item.Split(':')[1],
                                AutoConnect = true
                            };
                            localParamClass.cameraDataClass.Add(cameraDataClass);
                        }
                    }
                }
            }
            CameraDataDic = localParamClass.cameraDataClass;
        }

        private void Tsmi_ConfigCamera_Click(object sender, EventArgs e)//配置相机
        {
            FrmConfigCamera frmConfigCamera = new FrmConfigCamera(localParamClass.cameraDataClass);
            if (frmConfigCamera.ShowDialog() == DialogResult.OK)//如果为确定  则保存
            {
                CameraDataDic = localParamClass.cameraDataClass;
            }
        }

        private void InitialMotionCard()//初始化运动控制卡 只有在软件初始化时会执行初始化卡
        {
            if (localParamClass.MCDataList != null)
            {
                foreach (MCDataClass item in localParamClass.MCDataList)
                {
                    IMotionCard motionCard = MotionCardFactory.CreateMotionCard(item);
                    MotionCardDict.Add(item.Name, motionCard);
                    if (motionCard != null)
                    {
                        motionCard.InitialMotionCard(out string errorMessage);
                    }
                }
            }
        }
    }
}
