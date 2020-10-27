using DispenseAPP.MultiLanguage;
using DispenseAPP.Tools_CommunControl;
using DispenseAPP.Tools_CommunControl.PLC;
using DispenseAPP.Tools_CommunControl.Serial;
using DispenseAPP.Tools_CommunControl.TCP;
using DispenseAPP.Tools_Image_IO;
using DispenseAPP.Tools_Image_IO.AutoCalib;
using DispenseAPP.Tools_Image_IO.CacheImage;
using DispenseAPP.Tools_Image_IO.ExportImage;
using DispenseAPP.Tools_Image_IO.ImportImage;
using DispenseAPP.Tools_Location;
using DispenseAPP.Tools_Location.CalibROI;
using DispenseAPP.Tools_Location.ContourMatchin;
using DispenseAPP.Tools_Location.CreateROI;
using DispenseAPP.Tools_Location.FindLine;
using DispenseAPP.Tools_Measure;
using DispenseAPP.Tools_Measure.GeometricalRelation;
using DispenseAPP.Tools_MotionControl;
using DispenseAPP.Tools_MotionControl.MeasureHeight;
using DispenseAPP.Tools_MotionControl.ProgrammingDispensePath;
using DispenseAPP.Tools_Other;
using DispenseAPP.Tools_Other.DelayTime;
using DispenseAPP.Tools_Other.LogicOperation;
using DispenseAPP.Tools_Other.Script;
using DispenseAPP.Tools_Other.VarSet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    public partial class FrmEdit : Form
    {
        UC_FlowChart _workFlow;

        FrmDebug _frmDebug = new FrmDebug();

        ProjectParamClass _edit_ProjectParam;

        UC_Image_IO_Tools uc_ImageIO_Tools = new UC_Image_IO_Tools();//图像输入和输出

        UC_Location_Tools uc_Location_Tools = new UC_Location_Tools();//定位

        UC_Other_Tools uc_Other_Tools = new UC_Other_Tools();//其它工具

        UC_Commun_Tools uc_Commun_Tools = new UC_Commun_Tools();//通讯控制

        UC_Measure_Tools uc_Measure_Tools = new UC_Measure_Tools();//测量

        UC_MotionControl_Tools uc_MotionControl_Tools = new UC_MotionControl_Tools();//运动控制

        ToolsKitNameEnum _clickToolsListName;

        private NormalBlock normalBlock = null;

        public event ClickOKDelegate JumpToDebug;

        public bool EditState { get; set; }//表示当前的工具处于编辑状态 

        public FrmEdit(ProjectParamClass projectParam)
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); //禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); //双缓冲     
            _edit_ProjectParam = projectParam;
            _workFlow = new UC_FlowChart(_edit_ProjectParam);
            Initial();
        }

        private void Initial()//初始化控件
        {
            DG_Edit.AutoGenerateColumns = false;
            LanguageHelper.SetControlLanguageText(this);
            ControlClass.AddControlToPanel(uc_ImageIO_Tools, Panel_Tools);
            Tsbtn_Image_IO.CheckState = CheckState.Checked;
            _workFlow.ChangeSelectedNormalBolck += WorkFlow_ChangeSelectedNormalBolck;
            uc_ImageIO_Tools.ClickToolsEvent += Uc_ImageIO_Tools_ClickToolsEvent;
            uc_Location_Tools.ClickToolsEvent += Uc_Location_Tools_ClickToolsEvent;
            uc_Commun_Tools.ClickToolsEvent += Uc_Commun_Tools_ClickToolsEvent;
            uc_Other_Tools.ClickToolsEvent += Uc_Other_Tools_ClickToolsEvent;
            uc_Measure_Tools.ClickToolsEvent += Uc_Measure_Tools_ClickToolsEvent;
            uc_MotionControl_Tools.ClickToolsEvent += Uc_MotionControl_Tools_ClickToolsEvent;
            List<Element> element = _edit_ProjectParam._flowChartList.FindAll(c => c is NormalBlock);
            foreach (Element item in element)
            {
                NormalBlock normalBlock = item as NormalBlock;
                foreach (ITools tools in normalBlock.ToolsList)
                {
                    tools.ExecuteTime = "None";
                    tools.StepState = false;
                    tools.ExecuteState = ExecuteStateEnum.OK;
                    tools.ExecuteResult = "None";
                }
            }
        }



        public void RunModeControlEnable(bool b)
        {
            DG_Edit.Enabled = b;
            Panel_Tools.Enabled = b;
            ts_Tools.Enabled = b;
        }

        #region 工具箱相关
        private bool Tools_Common() //工具的公共方法
        {
            if (normalBlock == null)
            {
                MessageBox.Show("未选中算子块，请先选中算子块后执行相应的操作", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (_currentControlType != ToPanelControl.ImageControl)
            {
                JumpToDebug();//跳转到图像界面
            }
            return true;
        }

        private void Uc_MotionControl_Tools_ClickToolsEvent(ToolsNameEnum toolsName, ITools tools)//运动控制
        {
            if (Tools_Common() == true)
            {
                _clickToolsListName = ToolsKitNameEnum.MotionControl;
                tools.SelectedNormalBlock = normalBlock;
                switch (toolsName)
                {
                    case ToolsNameEnum.PathProgram:
                        if (EditState == false)
                        {
                            tools.BlockName = GetToolsName("点胶标准三轴_");
                        }
                        Tools_PathProgramming tools_PathProgramming = new Tools_PathProgramming(tools as PathProgramClass);
                        tools_PathProgramming._clickOKButton += Tools_clickOKButton;
                        tools_PathProgramming._clickCancelButton += Tools_clickCancelButton;
                        ControlClass.AddControlToPanel(tools_PathProgramming, Panel_Tools);
                        break;
                    case ToolsNameEnum.LaserMeasureHeight:
                        if (EditState == false)
                        {
                            tools.BlockName = GetToolsName("激光测高_");
                        }
                        Tools_MeasureHeight tools_MeasureHeight = new Tools_MeasureHeight(tools as MeasureHeightClass);
                        tools_MeasureHeight._clickOKButton += Tools_clickOKButton;
                        tools_MeasureHeight._clickCancelButton += Tools_clickCancelButton;
                        ControlClass.AddControlToPanel(tools_MeasureHeight, Panel_Tools);
                        break;
                }
            }
        }

        private void Uc_Measure_Tools_ClickToolsEvent(ToolsNameEnum toolsName, ITools tools)//测量工具
        {
            if (Tools_Common() == true)
            {
                _clickToolsListName = ToolsKitNameEnum.Measure;
                tools.SelectedNormalBlock = normalBlock;
                switch (toolsName)
                {
                    case ToolsNameEnum.GeometericalRelation://几何关系
                        if (EditState == false)
                        {
                            tools.BlockName = GetToolsName("几何关系_");
                        }
                        Tools_GeometricalRelation tools_GeometricalRelation = new Tools_GeometricalRelation(tools as GeometericalRelationClass);
                        tools_GeometricalRelation._clickOKButton += Tools_clickOKButton;
                        tools_GeometricalRelation._clickCancelButton += Tools_clickCancelButton;
                        ControlClass.AddControlToPanel(tools_GeometricalRelation, Panel_Tools);
                        break;
                }
            }
        }

        private void Uc_Commun_Tools_ClickToolsEvent(ToolsNameEnum toolsName, ITools tools)//通讯工具
        {
            Tools_Common();
            _clickToolsListName = ToolsKitNameEnum.Commun;
            tools.SelectedNormalBlock = normalBlock;
            switch (toolsName)
            {
                case ToolsNameEnum.TCP_IP:
                    if (EditState == false)
                    {
                        tools.BlockName = GetToolsName("TCPIP_");
                    }
                    Tools_TCP_IP tools_TCP_IP = new Tools_TCP_IP(tools as TCP_IP_Class);
                    tools_TCP_IP._clickOKButton += Tools_clickOKButton;
                    tools_TCP_IP._clickCancelButton += Tools_clickCancelButton;
                    ControlClass.AddControlToPanel(tools_TCP_IP, Panel_Tools);
                    break;
                case ToolsNameEnum.PLC:
                    if (EditState == false)
                    {
                        tools.BlockName = GetToolsName("PLC_");
                    }
                    Tools_PLC tools_PLC = new Tools_PLC(tools as PLC_CommunClass);
                    tools_PLC._clickOKButton += Tools_clickOKButton;
                    tools_PLC._clickCancelButton += Tools_clickCancelButton;
                    ControlClass.AddControlToPanel(tools_PLC, Panel_Tools);
                    break;
                case ToolsNameEnum.Serial:
                    if (EditState == false)
                    {
                        tools.BlockName = GetToolsName("串口_");
                    }
                    Tools_Serial tools_Serial = new Tools_Serial(tools as SerialClass);
                    tools_Serial._clickOKButton += Tools_clickOKButton;
                    tools_Serial._clickCancelButton += Tools_clickCancelButton;
                    ControlClass.AddControlToPanel(tools_Serial, Panel_Tools);
                    break;
            }
        }
        private void Uc_Location_Tools_ClickToolsEvent(ToolsNameEnum toolsName, ITools tools)//定位工具
        {
            if (Tools_Common() == true)
            {
                _clickToolsListName = ToolsKitNameEnum.Location;
                tools.SelectedNormalBlock = normalBlock;
                switch (toolsName)
                {
                    case ToolsNameEnum.FindLine:
                        if (EditState == false)
                        {
                            tools.BlockName = GetToolsName("找直线_");
                        }
                        Tools_FindLine tools_FindLine = new Tools_FindLine(tools as FindLineClass);
                        tools_FindLine._clickOKButton += Tools_clickOKButton;
                        tools_FindLine._clickCancelButton += Tools_clickCancelButton;
                        ControlClass.AddControlToPanel(tools_FindLine, Panel_Tools);
                        break;
                    case ToolsNameEnum.FindCircle:
                        break;
                    case ToolsNameEnum.ContourMatching:
                        if (EditState == false)
                        {
                            tools.BlockName = GetToolsName("形状匹配_");
                        }
                        Tools_ContourMatching tools_ContourMatching = new Tools_ContourMatching(tools as ContourMatchingClass);
                        tools_ContourMatching._clickOKButton += Tools_clickOKButton;
                        tools_ContourMatching._clickCancelButton += Tools_clickCancelButton;
                        ControlClass.AddControlToPanel(tools_ContourMatching, Panel_Tools);
                        break;
                    case ToolsNameEnum.ReviseROI:
                        if (EditState == false)
                        {
                            tools.BlockName = GetToolsName("ROI校正_");
                        }
                        Tools_CalibROI tools_CalibROI = new Tools_CalibROI(tools as ReviseROIClass);
                        tools_CalibROI._clickOKButton += Tools_clickOKButton;
                        tools_CalibROI._clickCancelButton += Tools_clickCancelButton;
                        ControlClass.AddControlToPanel(tools_CalibROI, Panel_Tools);
                        break;
                    case ToolsNameEnum.CreateROI:
                        if (EditState == false)
                        {
                            tools.BlockName = GetToolsName("创建ROI_");
                        }
                        Tools_CreateROI tools_CreateROI = new Tools_CreateROI(tools as CreateROIClass);
                        tools_CreateROI._clickOKButton += Tools_clickOKButton;
                        tools_CreateROI._clickCancelButton += Tools_clickCancelButton;
                        ControlClass.AddControlToPanel(tools_CreateROI, Panel_Tools);
                        break;
                }
            }
        }

        private void Uc_ImageIO_Tools_ClickToolsEvent(ToolsNameEnum toolsName, ITools tools)//图像输入和输出工具
        {
            if (Tools_Common() == true)
            {
                _clickToolsListName = ToolsKitNameEnum.ImageIO;
                tools.SelectedNormalBlock = normalBlock;
                switch (toolsName)
                {
                    case ToolsNameEnum.AcqSet:
                        if (EditState == false)
                        {
                            tools.BlockName = GetToolsName("采集设置_");
                        }
                        Tools_AcqSet tools_AcqSet = new Tools_AcqSet(tools as AcqSetClass);
                        tools_AcqSet._clickOKButton += Tools_clickOKButton;
                        tools_AcqSet._clickCancelButton += Tools_clickCancelButton;
                        ControlClass.AddControlToPanel(tools_AcqSet, Panel_Tools);
                        break;
                    case ToolsNameEnum.AcqImage:
                        if (EditState == false)
                        {
                            tools.BlockName = GetToolsName("图像采集_");
                        }
                        Tools_AcqImage tools_AcqImage = new Tools_AcqImage(tools as AcqImageClass);
                        tools_AcqImage._clickOKButton += Tools_clickOKButton;
                        tools_AcqImage._clickCancelButton += Tools_clickCancelButton;
                        ControlClass.AddControlToPanel(tools_AcqImage, Panel_Tools);
                        break;
                    case ToolsNameEnum.ImportImage:
                        if (EditState == false)
                        {
                            tools.BlockName = GetToolsName("导入图像_");
                        }
                        Tools_ImportImage tools_ImportImage = new Tools_ImportImage(tools as ImportImageClass);
                        tools_ImportImage._clickOKButton += Tools_clickOKButton;
                        tools_ImportImage._clickCancelButton += Tools_clickCancelButton;
                        ControlClass.AddControlToPanel(tools_ImportImage, Panel_Tools);
                        break;
                    case ToolsNameEnum.CacheImage:
                        if (EditState == false)
                        {
                            tools.BlockName = GetToolsName("图像缓存_");
                        }
                        Tools_CacheImage tools_CacheImage = new Tools_CacheImage(tools as ImageCacheClass, _edit_ProjectParam);
                        tools_CacheImage._clickOKButton += Tools_clickOKButton;
                        tools_CacheImage._clickCancelButton += Tools_clickCancelButton;
                        ControlClass.AddControlToPanel(tools_CacheImage, Panel_Tools);
                        break;
                    case ToolsNameEnum.ExportImage:
                        if (EditState == false)
                        {
                            tools.BlockName = GetToolsName("导出图像_");
                        }
                        Tools_ExportImage tools_ExportImage = new Tools_ExportImage(tools as ExportImageClass);
                        tools_ExportImage._clickOKButton += Tools_clickOKButton;
                        tools_ExportImage._clickCancelButton += Tools_clickCancelButton;
                        ControlClass.AddControlToPanel(tools_ExportImage, Panel_Tools);
                        break;
                    case ToolsNameEnum.AutoCalib:
                        if (EditState == false)
                        {
                            tools.BlockName = GetToolsName("自动标定_");
                        }
                        Tools_AutoCalib tools_AutoCalib = new Tools_AutoCalib(tools as AutoCalibClass);
                        tools_AutoCalib._clickOKButton += Tools_clickOKButton;
                        tools_AutoCalib._clickCancelButton += Tools_clickCancelButton;
                        ControlClass.AddControlToPanel(tools_AutoCalib, Panel_Tools);
                        break;
                }
            }
        }

        private void Uc_Other_Tools_ClickToolsEvent(ToolsNameEnum toolsName, ITools tools)//其它工具
        {
            if (Tools_Common() == true)
            {
                tools.SelectedNormalBlock = normalBlock;
                _clickToolsListName = ToolsKitNameEnum.Other;
                switch (toolsName)
                {
                    case ToolsNameEnum.VarSet:
                        if (EditState == false)
                        {
                            tools.BlockName = GetToolsName("变量设置_");
                        }
                        Tools_VarSet tools_VarSet = new Tools_VarSet(tools as VarSetClass, _edit_ProjectParam);
                        tools_VarSet._clickOKButton += Tools_clickOKButton;
                        tools_VarSet._clickCancelButton += Tools_clickCancelButton;
                        ControlClass.AddControlToPanel(tools_VarSet, Panel_Tools);
                        break;
                    case ToolsNameEnum.DelayTime:
                        if (EditState == false)
                        {
                            tools.BlockName = GetToolsName("延时_");
                        }
                        Tools_DelayTime tools_DelayTime = new Tools_DelayTime(tools as DelayTimeClass);
                        tools_DelayTime._clickOKButton += Tools_clickOKButton;
                        tools_DelayTime._clickCancelButton += Tools_clickCancelButton;
                        ControlClass.AddControlToPanel(tools_DelayTime, Panel_Tools);
                        break;
                    case ToolsNameEnum.Script:
                        if (EditState == false)
                        {
                            tools.BlockName = GetToolsName("脚本_");
                        }
                        Tools_Script tools_Script = new Tools_Script(tools as ScriptClass);
                        tools_Script._clickOKButton += Tools_clickOKButton;
                        tools_Script._clickCancelButton += Tools_clickCancelButton;
                        ControlClass.AddControlToPanel(tools_Script, Panel_Tools);
                        break;
                    case ToolsNameEnum.LogicOperation:
                        if (EditState == false)
                        {
                            tools.BlockName = GetToolsName("逻辑运算_");
                        }
                        Tools_Logic_Operation tools_LogicOperation = new Tools_Logic_Operation(tools as LogicOperationClass);
                        tools_LogicOperation._clickOKButton += Tools_clickOKButton;
                        tools_LogicOperation._clickCancelButton += Tools_clickCancelButton;
                        ControlClass.AddControlToPanel(tools_LogicOperation, Panel_Tools);
                        break;
                }
            }
        }
        #endregion

        private string GetToolsName(string name)
        {
            string _name = null;
            for (int i = 1; i < int.MaxValue; i++)
            {
                if (normalBlock.ToolsList.Find(c => c.BlockName == name + i.ToString()) == null)
                {
                    _name = name + i.ToString();
                    break;
                }
            }
            return _name;
        }

        private void Tools_clickOKButton(ITools confirmParam)//点击确定按钮
        {
            Change_PanelTools_Panel();
            if (EditState == false)
            {
                ITools _tools = (ITools)confirmParam.Clone();
                confirmParam = null;
                normalBlock.ToolsList.Insert(_currentRowIndex + 1, _tools);//在指定位置插入一行
                _tools.SelectedNormalBlock = normalBlock;
                _tools.ProjectParamClass = _edit_ProjectParam;
                if (!_tools.GetType().IsDefined(typeof(UnAbleManualExecuteAttribute), false))
                {
                    _tools.ComputerExecuteTime(WindowIndexDic[CurrentWindowIndex]);
                }
            }
            DG_Edit.DataSource = new BindingList<ITools>(normalBlock.ToolsList);
            if (EditState == true)//如果为编辑则编辑哪一行设定哪一行
            {
                EditState = false;
                DG_Edit.CurrentCell = DG_Edit[0, _currentRowIndex];
            }
            else
            {
                DG_Edit.CurrentCell = DG_Edit[0, _currentRowIndex + 1];
                _currentRowIndex += 1;
            }
        }

        private void Tsmi_Delete_Click(object sender, EventArgs e)//删除
        {
            normalBlock.ToolsList.RemoveAt(_currentRowIndex);
            DG_Edit.DataSource = new BindingList<ITools>(normalBlock.ToolsList);
            if (_currentRowIndex != 0)
            {
                DG_Edit.CurrentCell = DG_Edit[0, _currentRowIndex - 1];
            }
            _currentRowIndex -= 1;
        }

        private void Tools_clickCancelButton()//点击取消按钮
        {
            Change_PanelTools_Panel();
            if (EditState == true)
            {
                EditState = false;
            }
        }

        private void Change_PanelTools_Panel()//切换Panel_Tools中的Panel
        {
            Panel_Tools.Controls.Clear();
            switch (_clickToolsListName)
            {
                case ToolsKitNameEnum.ImageIO:
                    ControlClass.AddControlToPanel(uc_ImageIO_Tools, Panel_Tools);
                    break;
                case ToolsKitNameEnum.Location:
                    ControlClass.AddControlToPanel(uc_Location_Tools, Panel_Tools);
                    break;
                case ToolsKitNameEnum.Measure:
                    ControlClass.AddControlToPanel(uc_Measure_Tools, Panel_Tools);
                    break;
                case ToolsKitNameEnum.Commun:
                    ControlClass.AddControlToPanel(uc_Commun_Tools, Panel_Tools);
                    break;
                case ToolsKitNameEnum.Other:
                    ControlClass.AddControlToPanel(uc_Other_Tools, Panel_Tools);
                    break;
                case ToolsKitNameEnum.MotionControl:
                    ControlClass.AddControlToPanel(uc_MotionControl_Tools, Panel_Tools);
                    break;
            }
        }

        private void WorkFlow_ChangeSelectedNormalBolck(object anyType)//选择的普通算子块发生改变后
        {
            if (anyType is NormalBlock _normal && (normalBlock == null || (!_normal.Equals(normalBlock))))
            {
                normalBlock = _normal;
                DG_Edit.DataSource = new BindingList<ITools>(normalBlock.ToolsList);
                if (normalBlock.ToolsList.Count > 0)
                {
                    _currentRowIndex = 0;
                }
                else
                {
                    _currentRowIndex = -1;
                }
            }
        }

        private ToPanelControl _currentControlType;
        public ToPanelControl AddControlType //往Panel中添加控件的属性
        {
            get { return _currentControlType; }
            set
            {
                _currentControlType = value;
                if (value == ToPanelControl.WorkFlowControl)
                {
                    ControlClass.AddControlToPanel(_workFlow, Panel_ImageWorkFlow);
                }
                else if (value == ToPanelControl.ImageControl)
                {
                    _frmDebug.AddWindow();
                    ControlClass.AddControlToPanel(_frmDebug, Panel_ImageWorkFlow);

                }
            }
        }

        private void Panel_ImageWorkFlow_ControlAdded(object sender, ControlEventArgs e)
        {
            LanguageHelper.SetControlLanguageText(this);
        }

        private void Tsbtn_ImageEnhancement_Click(object sender, EventArgs e)//图像增强
        {
            Cancel_TS_Tools_CheckedState();
            Tsbtn_ImageEnhancement.CheckState = CheckState.Checked;
            Panel_Tools.Controls.Clear();
        }

        private void Tsbtn_MotionControl_Click(object sender, EventArgs e)
        {
            Cancel_TS_Tools_CheckedState();
            Tsbtn_MotionControl.CheckState = CheckState.Checked;
            ControlClass.AddControlToPanel(uc_MotionControl_Tools, Panel_Tools);
        }

        private void Cancel_TS_Tools_CheckedState()//清除工具栏中的所有按钮的选中状态
        {
            foreach (ToolStripButton item in ts_Tools.Items)
            {
                item.CheckState = CheckState.Unchecked;
            }
        }

        private void Tsbtn_Image_IO_Click(object sender, EventArgs e)//图像输入和输出
        {
            Cancel_TS_Tools_CheckedState();
            Tsbtn_Image_IO.CheckState = CheckState.Checked;
            ControlClass.AddControlToPanel(uc_ImageIO_Tools, Panel_Tools);
        }

        private void Tsbtn_Location_Click(object sender, EventArgs e)//定位工具
        {
            Cancel_TS_Tools_CheckedState();
            Tsbtn_Location.CheckState = CheckState.Checked;
            ControlClass.AddControlToPanel(uc_Location_Tools, Panel_Tools);
        }

        private void Tsbtn_Measure_Click(object sender, EventArgs e)//测量工具
        {
            Cancel_TS_Tools_CheckedState();
            Tsbtn_Measure.CheckState = CheckState.Checked;
            ControlClass.AddControlToPanel(uc_Measure_Tools, Panel_Tools);
        }

        private void Tsbtn_Other_Click(object sender, EventArgs e)//其它工具
        {
            Cancel_TS_Tools_CheckedState();
            Tsbtn_Other.CheckState = CheckState.Checked;
            ControlClass.AddControlToPanel(uc_Other_Tools, Panel_Tools);
        }

        private void Tsbtn_ImageDetectionAndAnalysis_Click(object sender, EventArgs e)//检测分析
        {
            Cancel_TS_Tools_CheckedState();
            Tsbtn_ImageDetectionAndAnalysis.CheckState = CheckState.Checked;
            ControlClass.AddControlToPanel(uc_Other_Tools, Panel_Tools);
        }

        private void Tsbtn_BarcodeRecognition_Click(object sender, EventArgs e)//条码识别
        {
            Cancel_TS_Tools_CheckedState();
            Tsbtn_Other.CheckState = CheckState.Checked;
            ControlClass.AddControlToPanel(uc_Other_Tools, Panel_Tools);
        }

        private void Tsbtn_CommunControl_Click(object sender, EventArgs e)//通讯控制
        {
            Cancel_TS_Tools_CheckedState();
            Tsbtn_CommunControl.CheckState = CheckState.Checked;
            ControlClass.AddControlToPanel(uc_Commun_Tools, Panel_Tools);
        }

        public void SetFormLayout(FormWindowState windowState)
        {
            if (windowState == FormWindowState.Maximized || windowState == FormWindowState.Normal)
            {
                DG_Edit.Size = new Size(DG_Edit.Width, ts_Tools.Location.Y - DG_Edit.Location.Y - 2);
                Panel_Tools.Location = new Point(Panel_Tools.Location.X, ts_Tools.Location.Y + ts_Tools.Size.Height + 2);
                Panel_Tools.Size = new Size(Panel_Tools.Width, this.Height - ts_Tools.Location.Y - ts_Tools.Size.Height - 2);
            }
        }

        #region 操作DG_Edit

        private void Tsmi_Edit_Click(object sender, EventArgs e)//编辑
        {
            EditState = true;
            switch (normalBlock.ToolsList[_currentRowIndex].ToolsKitName)
            {
                case ToolsKitNameEnum.ImageIO:
                    Uc_ImageIO_Tools_ClickToolsEvent(normalBlock.ToolsList[_currentRowIndex].ToolsName, normalBlock.ToolsList[_currentRowIndex]);
                    break;
                case ToolsKitNameEnum.Location:
                    Uc_Location_Tools_ClickToolsEvent(normalBlock.ToolsList[_currentRowIndex].ToolsName, normalBlock.ToolsList[_currentRowIndex]);
                    break;
                case ToolsKitNameEnum.Other:
                    Uc_Other_Tools_ClickToolsEvent(normalBlock.ToolsList[_currentRowIndex].ToolsName, normalBlock.ToolsList[_currentRowIndex]);
                    break;
                case ToolsKitNameEnum.Commun:
                    Uc_Commun_Tools_ClickToolsEvent(normalBlock.ToolsList[_currentRowIndex].ToolsName, normalBlock.ToolsList[_currentRowIndex]);
                    break;
            }

        }

        private void Tsmi_Execute_Click(object sender, EventArgs e)//执行此工具
        {
            normalBlock.ToolsList.Find(c => c.BlockName == DG_Edit.Rows[_currentRowIndex].Cells[0].Value.ToString()).ComputerExecuteTime(WindowIndexDic[CurrentWindowIndex]);
        }

        private void Tsmi_Forbidden_Click(object sender, EventArgs e)//禁用
        {

        }

        private void Tsmi_Copy_Click(object sender, EventArgs e)//复制
        {

        }

        private void Tsmi_Past_Click(object sender, EventArgs e)//粘贴
        {

        }

        private void Tsmi_Cut_Click(object sender, EventArgs e)//剪切
        {

        }

        public static int _currentRowIndex = -1;
        private void DG_Edit_MouseDown(object sender, MouseEventArgs e)
        {
            _currentRowIndex = DG_Edit.HitTest(e.X, e.Y).RowIndex;
            if (e.Button == MouseButtons.Right)
            {
                if (_currentRowIndex >= 0)
                {
                    if (DG_Edit.Rows[_currentRowIndex].Selected == false)//如果该行已经是选中状态 则不设置
                    {
                        DG_Edit.ClearSelection();
                        DG_Edit.Rows[_currentRowIndex].Selected = true;
                    }
                    DG_Edit.CurrentCell = DG_Edit.Rows[_currentRowIndex].Cells[0];
                    foreach (ToolStripMenuItem item in CM_Operation.Items)
                    {
                        item.Enabled = true;
                    }
                    CM_Operation.Show(MousePosition.X, MousePosition.Y);
                }
                else
                {
                    foreach (ToolStripMenuItem item in CM_Operation.Items)
                    {
                        item.Enabled = false;
                    }
                    CM_Operation.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }
        #endregion
    }
}
