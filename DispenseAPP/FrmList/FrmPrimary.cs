using System;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;
using System.Threading;
using System.Collections.Generic;
using System.Drawing;
using DispenseAPP.AboutData;
using System.ComponentModel;
using System.Diagnostics;
using CameraLibrary;
using System.IO.Ports;
using DispenseAPP.ToolBar;
using DispenseAPP.FrmList;

namespace DispenseAPP
{
    public partial class FrmPrimary : Form, INotifyPropertyChanged
    {
        FrmEdit _frmEdit = null;
        UserParamClass userParamClass = new UserParamClass();
        static List<Thread> RunThreadList = new List<Thread>();//运行线程List
        public static BindingList<Thread> BThreadList = new BindingList<Thread>(RunThreadList);
        public event PropertyChangedEventHandler PropertyChanged;
        Point _downPoint;

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

        private CurrentFrmEnum CurrentFrm { get; set; }

        #region 工具栏
        ToolBarProduction toolBar_Production = null;
        ToolBarPlatform toolBar_Config = null;
        ToolBarSystem toolBar_System = null;
        #endregion

        public FrmPrimary()
        {
            InitializeComponent();
            StaticUserParamClass = userParamClass;
        }

        private void FrmPrimary_Load(object sender, EventArgs e)
        {
            if (new FrmInitial().ShowDialog() == DialogResult.OK)
            {
                CheckForIllegalCrossThreadCalls = false;
                BThreadList = new BindingList<Thread>(RunThreadList);
                BThreadList.ListChanged += BThreadList_ListChanged;
                InitializeControl();//初始化控件                                 
                SetCurrentProjectName();
                CurrentFrm = CurrentFrmEnum.FrmEdit;//默认打开的界面为流程界面
                SetPreviewAbout();
                Timer_Disp.Enabled = true;
                Timer_Disp.Start();//开启定时器      
                MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                WindowState = FormWindowState.Normal;
                Tsmi_Click(MS.Items[1], null);
                Lbl_Title.Location = new Point(panel_Title.Width / 2 - Lbl_Title.Width / 2, Lbl_Title.Location.Y);
            }
            else
            {
                Process.GetCurrentProcess().Kill();
            }
        }

        #region about thread
        private void BThreadList_ListChanged(object sender, ListChangedEventArgs e)//当存储线程的集合发生变化时
        {
            if (BThreadList.Count == 0)//如果存储线程的集合中没有线程对象时  则改变界面上控件的使能
            {
                Invoke(new Action<bool>(SetControlEnableInRunMode), true);
                IsRunState = false;
            }
        }
        #endregion

        private void InitializeControl()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); //禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); //双缓冲            
            Lbl_Title.DataBindings.Add("Text", this, "CurrentProjectPath");
            _frmEdit = new FrmEdit();
            _frmEdit.JumpToDebug += SwitchToRun;
            _frmEdit.Tools_Add_Edit_Event += SetToolStripEnbale;//change the enable of some buttons when adding or editing tools
            _frmEdit.AddControlType = ToPanelControl.ImageControl;
            ControlClass.AddControlToPanel(_frmEdit, panel_FrmEditRun);//这里决定了Panel中显示什么 要分两种情况 1.当前界面为调试界面或流程界面 2.当前界面为自动运行界面
            _frmEdit.SetFormLayout(WindowState);
            _frmEdit.SetLayout();
            toolBar_Config = new ToolBarPlatform(this);
            toolBar_System = new ToolBarSystem(this);
            toolBar_Production = new ToolBarProduction(this);
            toolBar_Production.SetControlCheckBox();
            InitialCameraStatu();
        }

        #region About control
        public void SwitchToWorkFlowChart()//切换至流程图界面
        {
            _frmEdit.AddControlType = ToPanelControl.WorkFlowControl;
            CurrentFrm = CurrentFrmEnum.FrmWorkFlow;
        }

        public void SwitchToRun()//切换至运行界面
        {
            _frmEdit.AddControlType = ToPanelControl.ImageControl;
            CurrentFrm = CurrentFrmEnum.FrmEdit;
        }

        public void ReSet_the_form_Layout()//when Configuring the form
        {
            _frmEdit.SetLayout();
        }

        private void FrmPrimary_Resize(object sender, EventArgs e)
        {
            if (_frmEdit != null)
            {
                _frmEdit.SetFormLayout(WindowState);
            }
        }

        public void SetControlEnableInRunMode(bool b)//Enable Buttons and Forms When Set at run time...
        {
            Invoke(new Action(() =>
            {
                _frmEdit.RunModeControlEnable(b);
                SetToolStripEnbale(b);
                Ts_FastAccess.Enabled = b;
                MS.Enabled = b;
            }));
        }

        void SetToolStripEnbale(bool enable)
        {
            toolBar_Production.SetControlEnableInRunMode(enable);
            toolBar_Config.SetControlEnableInRunMode(enable);
            toolBar_System.SetControlEnableInRunMode(enable);
        }

        private void FrmPrimary_FormClosing(object sender, FormClosingEventArgs e)//程序关闭时
        {
            if (MessageBox.Show("是否退出软件？", "系统消息", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            if (ProjectIsChange)
            {
                if (MessageBox.Show("方案已更改，是否保存？", "系统消息", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    SavePublicData();
                }
            }
            foreach (ICamerable item in CameraIDObjectDict.Values)//关闭连接的所有相机
            {
                item.StopAcquisition();
                item.DisposeCamera();
            }
            foreach (SerialPort item in SerialDict.Values)
            {
                item.Close();
                item.Dispose();
            }
            Timer_Disp.Stop();
            Timer_Disp.Dispose();
            Process.GetCurrentProcess().Kill();
        }

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            _downPoint = new Point(e.X, e.Y);
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(Location.X + e.X - _downPoint.X, Location.Y + e.Y - _downPoint.Y);
            }
        }

        private void Ts_FastAccess_Paint(object sender, PaintEventArgs e)//快速访问工具栏重绘
        {
            if ((sender as ToolStrip).RenderMode == ToolStripRenderMode.System)
            {
                Rectangle rectangle = new Rectangle(0, 0, Ts_FastAccess.Width - 2, Ts_FastAccess.Height - 2);
                e.Graphics.SetClip(rectangle);
            }
        }

        #region 最小化
        private void Lbl_Min_MouseEnter(object sender, EventArgs e)
        {
            Lbl_Min.BackColor = Color.FromArgb(18, 64, 120);
        }

        private void Lbl_Min_MouseLeave(object sender, EventArgs e)
        {
            Lbl_Min.BackColor = Color.Transparent;
        }

        private void Lbl_Min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region 最大化
        private void Lbl_Max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)//如果当前是最大化  重置最大化图标
            {
                WindowState = FormWindowState.Normal;
                Lbl_Max.Image = Properties.Resources.最小化;
            }
            else
            {
                //防止遮挡任务栏 重置最大化图标
                MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                WindowState = FormWindowState.Maximized;
                Lbl_Max.Image = Properties.Resources.最大化;
            }
            Lbl_Title.Location = new Point(panel_Title.Width / 2 - Lbl_Title.Width / 2, Lbl_Title.Location.Y);
        }

        private void Max_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Lbl_Max_Click(sender, new EventArgs());
            }
        }

        private void Lbl_Max_MouseEnter(object sender, EventArgs e)
        {
            Lbl_Max.BackColor = Color.FromArgb(18, 64, 120);
        }

        private void Lbl_Max_MouseLeave(object sender, EventArgs e)
        {
            Lbl_Max.BackColor = Color.Transparent;
        }
        #endregion

        #region 关闭按钮
        private void Lbl_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Lbl_Close_MouseEnter(object sender, EventArgs e)
        {
            Lbl_Close.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void Lbl_Close_MouseLeave(object sender, EventArgs e)
        {
            Lbl_Close.BackColor = Color.Transparent;
        }
        #endregion
        #endregion

        #region 项目管理
        public void SetCurrentProjectName()
        {
            CurrentProjectPath = StaticPublicData.SystemSetData.软件名称;
            if (StaticPublicData.SystemData.LastFilePath != null)
            {
                CurrentProjectPath += "  当前文件：" + StaticPublicData.SystemData.LastFilePath;
            }
        }
        #endregion

        #region About statuStrip
        Dictionary<ToolStripStatusLabel, ICamerable> StatusLableCameraDict = new Dictionary<ToolStripStatusLabel, ICamerable>();//存放相机和状态栏
        List<DispAxisState> dispAxisStatesList = new List<DispAxisState>();

        void AddToolstripItem(string text, Color color)//向状态栏中添加项
        {
            ToolStripStatusLabel toolStripStatusLabel = new ToolStripStatusLabel
            {
                DisplayStyle = ToolStripItemDisplayStyle.Text,
                Text = text + " ",
                ForeColor = color
            };
            Ss_State.Items.Add(toolStripStatusLabel);
        }

        void InitialCameraStatu()//初始化相机
        {
            foreach (KeyValuePair<string, ICamerable> item in CameraIDObjectDict)
            {
                CameraDataItem cameraData = StaticPublicData.CameraDataItems[item.Key];
                ToolStripStatusLabel toolStripStatusLabel = new ToolStripStatusLabel
                {
                    DisplayStyle = ToolStripItemDisplayStyle.Text,
                    Text = item.Key.Split(':')[0] + ":" + cameraData.CustomName + " ",
                    ForeColor = item.Value.ConnectState == true ? Color.Green : Color.Red,
                };
                Ss_State.Items.Add(toolStripStatusLabel);
                StatusLableCameraDict.Add(toolStripStatusLabel, item.Value);
            }
        }
        #endregion

        #region Timer
        private void Timer_Disp_Tick(object sender, EventArgs e)//该定时器用于显示  这里不考虑异常情况
        {
            foreach (KeyValuePair<ToolStripStatusLabel, ICamerable> item in StatusLableCameraDict)//更新相机的状态
            {
                if (item.Value.ConnectState == true)
                {
                    item.Key.ForeColor = Color.Green;
                }
                else
                {
                    item.Key.ForeColor = Color.Red;
                }
            }
        }
        #endregion

        #region about toolStrip
        private void Tsmi_Click(object sender, EventArgs e)//点击菜单栏
        {
            foreach (ToolStripItem item in MS.Items)
            {
                item.BackColor = Color.FromArgb(43, 87, 154);
                item.ForeColor = Color.FromArgb(255, 255, 255);
            }
            if (sender is ToolStripItem toolStripItem)
            {
                toolStripItem.BackColor = SystemColors.Control;
                toolStripItem.ForeColor = Color.FromArgb(43, 87, 154);
                SwitchToolBarControl(toolStripItem.Name);
            }
        }

        void SwitchToolBarControl(string text)//执行切换控件
        {
            switch (text)
            {
                case "tsmiProduct":
                    ControlClass.AddControlToPanel(toolBar_Production, pnlTool);
                    break;
                case "tsmiConfig":
                    ControlClass.AddControlToPanel(toolBar_Config, pnlTool);
                    break;
                case "tsmiSystem":
                    ControlClass.AddControlToPanel(toolBar_System, pnlTool);
                    break;
            }
        }
        #endregion

        #region About File

        private void Tsbtn_Save_Click(object sender, EventArgs e)//保存
        {
            Invoke(new Action<bool>(SetControlEnableInRunMode), false);
            MS.Enabled = false;
            SavePublicData();
            ProjectIsChange = false;
            Invoke(new Action<bool>(SetControlEnableInRunMode), true);
            MS.Enabled = true;
        }

        private void Tsbtn_NewFile_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void Tsbtn_FastSet_MouseEnter(object sender, EventArgs e)
        {
            (sender as ToolStripButton).BackColor = Color.FromArgb(18, 64, 120);
        }

        private void Tsbtn_FastSet_MouseLeave(object sender, EventArgs e)
        {
            (sender as ToolStripButton).BackColor = Color.Transparent;
        }

        #region About Preview
        private void FrmPrimary_Shown(object sender, EventArgs e)//当窗体第一次显示时  显示登录界面
        {
            FrmLogin frmLogin = new FrmLogin(StaticPublicData.SystemData.LastLoginUser);
            frmLogin.ShowDialog();
            SetPreviewAbout();
        }

        void SetPreviewAbout()//设置权限控件
        {
            Tsmi_操作员.Visible = true;
            Tsmi_管理员.Visible = true;
            Tsmi_程序员.Visible = true;
            switch (CurrentUserType)
            {
                case UserTypeEnum.操作员:
                    Tsmi_操作员.Visible = false;
                    CurrentUser = StaticUserParamClass.Operator;
                    break;
                case UserTypeEnum.管理员:
                    Tsmi_管理员.Visible = false;
                    CurrentUser = StaticUserParamClass.Administrator;
                    break;
                case UserTypeEnum.程序员:
                    Tsmi_程序员.Visible = false;
                    CurrentUser = StaticUserParamClass.Programmer;
                    break;
            }
            Lbl_User.Text = "当前用户：" + CurrentUserType.ToString() + "▼";
            _frmEdit.SetPurviewControl();
            toolBar_Production.SetPurviewControl();
            SetPurviewControl(CurrentUserType == UserTypeEnum.未登录 ? false : true);
        }

        void SetPurviewControl(bool state)//设置权限对应的控件
        {
            pnlTool.Enabled = state;
            Ts_FastAccess.Enabled = state;
            MS.Enabled = state;
            panel_FrmEditRun.Enabled = state;
        }

        private void Lbl_User_MouseDown(object sender, MouseEventArgs e)//点击当前用户
        {
            if (e.Button == MouseButtons.Left)
            {
                CM_User.Show(PointToScreen(new Point(Lbl_User.Location.X, Lbl_User.Location.Y + Lbl_User.Size.Height)));
            }
        }

        private void Tsmi_操作员_Click(object sender, EventArgs e)
        {
            if (new FrmLogin(UserTypeEnum.操作员, true).ShowDialog() == DialogResult.OK)
            {
                CurrentUserType = UserTypeEnum.操作员;
                SetPreviewAbout();
            }
        }

        private void Tsmi_管理员_Click(object sender, EventArgs e)
        {
            if (new FrmLogin(UserTypeEnum.管理员, true).ShowDialog() == DialogResult.OK)
            {
                CurrentUserType = UserTypeEnum.管理员;
                SetPreviewAbout();
            }
        }

        private void Tsmi_程序员_Click(object sender, EventArgs e)
        {
            if (new FrmLogin(UserTypeEnum.程序员, true).ShowDialog() == DialogResult.OK)
            {
                CurrentUserType = UserTypeEnum.程序员;
                SetPreviewAbout();
            }
        }
        #endregion

    }

    public class DispAxisState
    {
        public ToolStripStatusLabel TSS_Label { get; set; } = null;


        public string AxisName { get; set; } = null;
    }
}
