using DispenseAPP.MyStyleControl;
using DispenseAPP.Tools_Image_IO;
using DispenseAPP.Tools_ImageIO.AcqImage;
using DispenseAPP.Tools_ImageIO.AcqSet;
using DispenseAPP.Tools_ImageIO.ImportImage;
using DispenseAPP.Tools_Location;
using DispenseAPP.Tools_Location.ContourMatchin;
using DispenseAPP.Tools_Location.SearchingOfContour;
using DispenseAPP.Tools_Other;
using DispenseAPP.Tools_Other.DelayTime;
using DispenseAPP.Tools_Other.LogicOperation;
using DispenseAPP.Tools_Other.ShowMessageBox;
using DispenseAPP.Tools_Other.VarSet;
using DispenseAPP.UserManagement;
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
        UC_Image_IO_Tools uc_ImageIO_Tools = new UC_Image_IO_Tools();//图像输入和输出
        UC_Location_Tools uc_Location_Tools = new UC_Location_Tools();//定位
        UC_Other_Tools uc_Other_Tools = new UC_Other_Tools();//其它工具
        ToolsKitNameEnum _clickToolsListName;
        OperatorBlock normalBlock = null;
        public event Action JumpToDebug;
        public event Action<bool> Tools_Add_Edit_Event;//添加或编辑工具
        public BindingList<IToolable> bList = null;

        /// <summary>
        /// 存储复制或剪切的工具集合
        /// </summary>
        List<IToolable> CopyCutTool { get; set; } = new List<IToolable>();
        OperatorBlock cutNormalBlock = null;//存储剪切的工具所在的算子块 
        BindingList<IToolable> toolsBindingList = null;
        UserControlTool userControlTool = null; 

        public bool EditState { get; set; }//表示当前的工具处于编辑状态 

        public FrmEdit()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); //禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); //双缓冲     
            _workFlow = new UC_FlowChart();
            Initial();
            DG_Edit.AutoGenerateColumns = false;
        }

        private void Initial()//初始化控件
        {
            ControlClass.AddControlToPanel(uc_ImageIO_Tools, Panel_Tools);
            Tsbtn_Image_IO.CheckState = CheckState.Checked;
            _workFlow.ChangeSelectedNormalBolck += WorkFlow_ChangeSelectedNormalBolck;//当选择的算子块更改时发生
            uc_ImageIO_Tools.ClickToolsEvent += Uc_ImageIO_Tools_ClickToolsEvent;
            uc_Location_Tools.ClickToolsEvent += Uc_Location_Tools_ClickToolsEvent;
            uc_Other_Tools.ClickToolsEvent += Uc_Other_Tools_ClickToolsEvent;
            List<BlockItem> element = StaticPublicData.BlockItems.GetAllOperator();
            foreach (BlockItem item in element)
            {
                OperatorBlock normalBlock = item as OperatorBlock;
                foreach (IToolable tools in normalBlock.ToolList)
                {
                    tools.ExecutionTime = "None";
                    tools.StepState = false;
                    tools.ExecutionResult = "None";
                }
            }
        }

        public void SetPurviewControl()
        {
            if (CurrentUser != null && CurrentUser.PurviewList.Find(c => c.PurviewTypeName == "显示") is DisplayPurview displayPurview && displayPurview != null)
            {
                _currentControlType = ToPanelControl.ImageControl;//无论是什么权限都显示图像界面
                DG_Edit.Visible = displayPurview.显示流程图界面;
                Panel_Tools.Visible = displayPurview.显示流程图界面;
                ts_Tools.Visible = displayPurview.显示流程图界面;
                if (displayPurview.显示流程图界面)
                {
                    Panel_ImageWorkFlow.Dock = DockStyle.None;
                    Panel_ImageWorkFlow.Location = new Point(0, 0);
                    Panel_ImageWorkFlow.Size = new Size(DG_Edit.Location.X - 1, Panel_Tools.Location.Y + Panel_Tools.Height);
                    Panel_ImageWorkFlow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                }
                else
                {
                    Panel_ImageWorkFlow.Dock = DockStyle.Fill;
                }
            }
            else
            {
                DG_Edit.Visible = false;
                Panel_Tools.Visible = false;
                ts_Tools.Visible = false;
                Panel_ImageWorkFlow.Dock = DockStyle.Fill;
            }
        }

        public void RunModeControlEnable(bool b)
        {
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
            _workFlow.ChangePBControlEnable(false);
            ts_Tools.Enabled = false;//工具栏设为不可用状态
            DG_Edit.Enabled = false;
            Tools_Add_Edit_Event(false);
            return true;
        }

        /// <summary>
        /// 定位工具箱
        /// </summary>
        /// <param name="toolsName"></param>
        /// <param name="tools"></param>
        private void Uc_Location_Tools_ClickToolsEvent(string toolsName, IToolable tools)
        {
            if (Tools_Common() == true)
            {
                userControlTool = null;
                _clickToolsListName = ToolsKitNameEnum.Location;
                tools.OperatorBlockName = normalBlock.CustomName;
                if (EditState == false)
                {
                    tools.StepCustomName = GetToolName(toolsName.ToString() + "_", normalBlock);
                }
                switch (toolsName)
                {
                    case "轮廓匹配":
                        userControlTool = new SeachOfContourToolControl(tools as SearchOfContourToolEntity);
                        break;
                }
                if (userControlTool != null)
                {
                    userControlTool.ClickOKEvent += Tools_clickOKButton;
                    userControlTool.ClickCancelEvent += Tools_clickCancelButton;
                    ControlClass.AddControlToPanel(userControlTool, Panel_Tools);
                }
            }
        }

        /// <summary>
        /// 图像输入输出工具箱
        /// </summary>
        /// <param name="toolsName"></param>
        /// <param name="tools"></param>
        private void Uc_ImageIO_Tools_ClickToolsEvent(string toolsName, IToolable tools)
        {
            if (Tools_Common() == true)
            {
                _clickToolsListName = ToolsKitNameEnum.ImageIO;
                tools.OperatorBlockName = normalBlock.CustomName;
                userControlTool = null;
                if (EditState == false)
                {
                    tools.StepCustomName = GetToolName(toolsName.ToString() + "_", normalBlock);
                }
                switch (toolsName)
                {
                    case "采集设置":
                        userControlTool = new AcqSetToolControl(tools as AcqSetToolEntity);
                        break;
                    case "采集图像":
                        userControlTool = new AcqImageToolControl(tools as AcqImageToolEntity);
                        break;
                    case "导入图像":
                        userControlTool = new ImportImageToolControl(tools as ImportImageToolEntity);
                        break;
                    case "自动标定":
                        //userControlTool = new Tools_AutoCalib(tools as AutoCalibClass);
                        break;
                }
                if (userControlTool != null)
                {
                    userControlTool.ClickOKEvent += Tools_clickOKButton;
                    userControlTool.ClickCancelEvent += Tools_clickCancelButton;
                    ControlClass.AddControlToPanel(userControlTool, Panel_Tools);
                }
            }
        }

        /// <summary>
        /// 其它工具箱
        /// </summary>
        /// <param name="toolsName"></param>
        /// <param name="tools"></param>
        private void Uc_Other_Tools_ClickToolsEvent(string toolsName, IToolable tools)
        {
            if (Tools_Common() == true)
            {
                tools.OperatorBlockName = normalBlock.CustomName;
                _clickToolsListName = ToolsKitNameEnum.Other;
                userControlTool = null;
                if (EditState == false)
                {
                    tools.StepCustomName = GetToolName(toolsName.ToString() + "_", normalBlock);
                }
                switch (toolsName)
                {
                    case "变量设置":
                        userControlTool = new VarSetToolControl(tools as VarSetToolEntity);
                        break;
                    case "延时":
                        userControlTool = new DelayTimeToolControl(tools as DelayTimeToolEntity);
                        break;
                    case "脚本":
                        //userControlTool = new Tools_Script(tools as Tools_ScriptClass);
                        break;
                    case "逻辑运算":
                        userControlTool = new LogicOperationToolControl(tools as LogicOperationToolEntity);
                        break;
                    case "读写变量":
                        //userControlTool = new Tools_ReadWriteVar(tools as Tools_ReadWriteVarClass);
                        break;
                    case "弹出对话框":
                        userControlTool = new ShowMessageBoxToolControl(tools as ShowMessageBoxToolEntity);
                        break;
                }
                if (userControlTool != null)
                {
                    userControlTool.ClickOKEvent += Tools_clickOKButton;
                    userControlTool.ClickCancelEvent += Tools_clickCancelButton;
                    ControlClass.AddControlToPanel(userControlTool, Panel_Tools);
                }
            }
        }
        #endregion

        /// <summary>
        /// 点击确定按钮
        /// </summary>
        /// <param name="tool"></param>
        private void Tools_clickOKButton(IToolable tool)
        {
            Change_PanelTools_Panel();
            if (EditState == false)
            {
                IToolable _tools = (IToolable)tool.Clone();
                int index = GetInsertIndex();
                toolsBindingList.Insert(index, _tools);//在指定位置插入一行
                DG_Edit.CurrentCell = DG_Edit[0, index];
                _tools.ExecutionResult = "None";
                _tools.ExecutionTime = "0";
                if (!_tools.GetType().IsDefined(typeof(UnableManualExecuteAttribute), false))
                {
                    _tools.ComputerExecuteTime();
                }
            }
            else
            {
                normalBlock.ToolList[DG_Edit.CurrentCell.RowIndex] = (IToolable)tool.Clone();
                if (!normalBlock.ToolList[DG_Edit.CurrentCell.RowIndex].GetType().IsDefined(typeof(UnableManualExecuteAttribute), false))
                {
                    normalBlock.ToolList[DG_Edit.CurrentCell.RowIndex].ComputerExecuteTime();
                }
            }
            if (EditState == true)
            {
                EditState = false;
            }
            ts_Tools.Enabled = true;//工具栏设为可用状态
            DG_Edit.Enabled = true;
            Tools_Add_Edit_Event(true);
            _workFlow.ChangePBControlEnable(true);
        }

        int GetInsertIndex()
        {
            if(DG_Edit.SelectedRows.Count > 0)//单选或者多选 获得选择的最后一行 然后添加一行
            {
                return DG_Edit.Rows.GetLastRow(DataGridViewElementStates.Selected) + 1;
            }
            else
            {
                return DG_Edit.Rows.Count;
            }
        }

        /// <summary>
        /// 点击取消按钮
        /// </summary>
        void Tools_clickCancelButton()
        {
            Change_PanelTools_Panel();
            if (EditState == true)
            {
                EditState = false;
            }
            ts_Tools.Enabled = true;//工具栏设为可用状态
            DG_Edit.Enabled = true;
            Tools_Add_Edit_Event(true);
            _workFlow.ChangePBControlEnable(true);
        }

        void Change_PanelTools_Panel()//切换Panel_Tools中的Panel
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
                case ToolsKitNameEnum.Other:
                    ControlClass.AddControlToPanel(uc_Other_Tools, Panel_Tools);
                    break;
            }
        }

        void WorkFlow_ChangeSelectedNormalBolck(object anyType)//选择的普通算子块发生改变后
        {
            if (anyType is OperatorBlock _normal && (normalBlock == null || (!_normal.Equals(normalBlock))))
            {
                normalBlock = _normal;
                toolsBindingList = new BindingList<IToolable>(normalBlock.ToolList);
                DG_Edit.DataSource = toolsBindingList;
                if (DG_Edit.Columns.Count > 4)
                {
                    DG_Edit.Columns[4].Visible = false;
                }
            }
        }

        ToPanelControl _currentControlType;
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
                    ControlClass.AddControlToPanel(_frmDebug, Panel_ImageWorkFlow);
                }
            }
        }

        void Cancel_TS_Tools_CheckedState()//清除工具栏中的所有按钮的选中状态
        {
            foreach (ToolStripButton item in ts_Tools.Items)
            {
                item.CheckState = CheckState.Unchecked;
            }
        }

        void Tsbtn_Image_IO_Click(object sender, EventArgs e)//图像输入和输出
        {
            Cancel_TS_Tools_CheckedState();
            Tsbtn_Image_IO.CheckState = CheckState.Checked;
            ControlClass.AddControlToPanel(uc_ImageIO_Tools, Panel_Tools);
        }

        void Tsbtn_Location_Click(object sender, EventArgs e)//定位工具
        {
            Cancel_TS_Tools_CheckedState();
            Tsbtn_Location.CheckState = CheckState.Checked;
            ControlClass.AddControlToPanel(uc_Location_Tools, Panel_Tools);
        }

        void Tsbtn_Measure_Click(object sender, EventArgs e)//测量工具
        {
        }

        void Tsbtn_Other_Click(object sender, EventArgs e)//其它工具
        {
            Cancel_TS_Tools_CheckedState();
            Tsbtn_Other.CheckState = CheckState.Checked;
            ControlClass.AddControlToPanel(uc_Other_Tools, Panel_Tools);
        }

        void Tsbtn_ImageDetectionAndAnalysis_Click(object sender, EventArgs e)//检测分析
        {
            Cancel_TS_Tools_CheckedState();
            Tsbtn_ImageDetectionAndAnalysis.CheckState = CheckState.Checked;
            ControlClass.AddControlToPanel(uc_Other_Tools, Panel_Tools);
        }

        void Tsbtn_BarcodeRecognition_Click(object sender, EventArgs e)//条码识别
        {
            Cancel_TS_Tools_CheckedState();
            Tsbtn_Other.CheckState = CheckState.Checked;
            ControlClass.AddControlToPanel(uc_Other_Tools, Panel_Tools);
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
            ExecuteEdit(normalBlock.ToolList[DG_Edit.CurrentCell.RowIndex]);
        }

        public void ExecuteEdit(IToolable _tools)
        {
            DG_Edit.Enabled = false;
            EditState = true;
            switch (_tools.ToolKitName)
            {
                case ToolsKitNameEnum.ImageIO:
                    Uc_ImageIO_Tools_ClickToolsEvent(_tools.ToolName, _tools);
                    break;
                case ToolsKitNameEnum.Location:
                    Uc_Location_Tools_ClickToolsEvent(_tools.ToolName, _tools);
                    break;
                case ToolsKitNameEnum.Other:
                    Uc_Other_Tools_ClickToolsEvent(_tools.ToolName, _tools);
                    break;
            }
        }
        void Tsmi_Execute_Click(object sender, EventArgs e)//执行此工具
        {
            cms.Enabled = false;
            ts_Tools.Enabled = false;
            DG_Edit.Enabled = false;
            Tools_Add_Edit_Event(false);
            IToolable tools = normalBlock.ToolList[DG_Edit.Rows.GetFirstRow(DataGridViewElementStates.Selected)];
            if (tools.ToolName == "点胶轨迹编程" && _currentControlType != ToPanelControl.ImageControl)
            {
                JumpToDebug();//跳转到图像界面         
            }
            BGWrok.RunWorkerAsync(tools);//这里要异步进行是为了不使用主线程去执行耗时的工作 如果使用主线程可能会造成内存泄漏 比如相机的实时采集 采集到了图像但是主线程被占用 无法显示的情况下就会造成内存泄漏
        }

        /// <summary>
        /// 执行禁用操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsmi_Forbidden_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in DG_Edit.SelectedRows)
            {
                if (!normalBlock.ToolList[item.Index].Disable)
                {
                    normalBlock.ToolList[item.Index].Disable = true;
                    normalBlock.ToolList[item.Index].ExecutionTime = "Disable";
                    tsmiForbidden.Text = "启用";
                    tsmiForbidden.Image = Properties.Resources.启用;
                }
                else
                {
                    normalBlock.ToolList[item.Index].Disable = false;
                    normalBlock.ToolList[item.Index].ExecutionTime = "None";
                    tsmiForbidden.Text = "禁用";
                    tsmiForbidden.Image = Properties.Resources.禁用;
                }
            }
        }

        /// <summary>
        /// 执行复制操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsmi_Copy_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in DG_Edit.SelectedRows)
            {
                CopyCutTool.Add((IToolable)normalBlock.ToolList[item.Index].Clone());
            }
        }

        /// <summary>
        /// 执行粘贴操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiPast_Click(object sender, EventArgs e)
        {
            int index;
            if(DG_Edit.SelectedRows.Count == 0)//分两种情况：1.当前列表中没有任何元素  2.当前列表中有元素 但是没有选中任何元素 
            {
                index = DG_Edit.RowCount;
            }
            else
            {
                index = DG_Edit.Rows.GetLastRow(DataGridViewElementStates.Selected) + 1;
            }
            foreach (IToolable item in CopyCutTool)
            {
                item.StepCustomName = GetToolName(item.ToolName.ToString() + "_", normalBlock);//先修改算子名
                toolsBindingList.Insert(index, item);
                DG_Edit.Rows[index].Selected = true;
                index++;
            }            
            cutNormalBlock = null;
            CopyCutTool.Clear();//完成一次粘贴后 清楚集合中的工具
        }

        /// <summary>
        /// 执行剪切操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiCut_Click(object sender, EventArgs e)
        {
            cutNormalBlock = normalBlock;
            foreach (DataGridViewRow item in DG_Edit.SelectedRows)
            {
                CopyCutTool.Add(normalBlock.ToolList[item.Index]);
            }
            foreach (DataGridViewRow item in DG_Edit.SelectedRows)
            {
                toolsBindingList.RemoveAt(item.Index);
            }
        }

        /// <summary>
        /// 删除操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Tsmi_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in DG_Edit.SelectedRows)
            {
                toolsBindingList.RemoveAt(item.Index);
            }
        }

        /// <summary>
        /// 上移操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Tsmi_MoveUp_Click(object sender, EventArgs e)
        {
            int firstIndex = DG_Edit.Rows.GetFirstRow(DataGridViewElementStates.Selected);//获得第一个选择项的索引
            int lastIndex = DG_Edit.Rows.GetLastRow(DataGridViewElementStates.Selected);//获得最后一个选择项的索引
            IToolable tools = normalBlock.ToolList[firstIndex - 1];//先拿到要上移的工具的地址
            toolsBindingList.RemoveAt(firstIndex - 1);//然后删除这一行 
            toolsBindingList.Insert(lastIndex, tools);
            DG_Edit.CurrentCell = DG_Edit[0, firstIndex - 1];
        }

        /// <summary>
        /// 下移操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Tsmi_MoveDown_Click(object sender, EventArgs e)
        {
            int firstIndex = DG_Edit.Rows.GetFirstRow(DataGridViewElementStates.Selected);//获得第一个选择项的索引
            int lastIndex = DG_Edit.Rows.GetLastRow(DataGridViewElementStates.Selected);//获得最后一个选择项的索引
            IToolable tools = normalBlock.ToolList[lastIndex + 1];//先拿到要上移的工具的地址
            toolsBindingList.RemoveAt(lastIndex + 1);//然后删除这一行 
            toolsBindingList.Insert(firstIndex, tools);
            DG_Edit.CurrentCell = DG_Edit[0, lastIndex + 1];
        }

        /// <summary>
        /// 鼠标按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DG_Edit_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ChangeCMOperationEnable();
                cms.Show(MousePosition.X, MousePosition.Y);
            }
        }

        void ChangeCMOperationEnable()
        {
            foreach (ToolStripItem item in cms.Items)
            {
                item.Enabled = false;
            }
            if (DG_Edit.SelectedRows.Count == 0)
            {
                tsmiPast.Enabled = CopyCutTool.Count > 0 ? true : false;
            }
            else
            {
                if (DG_Edit.SelectedRows.Count == 1)
                {
                    tsmiExecute.Enabled = true;
                    tsmiEdit.Enabled = true;
                }
                tsmiDelete.Enabled = true;
                tsmiPast.Enabled = CopyCutTool.Count > 0 ? true : false;//如果复制和剪切的
                tsmiCopy.Enabled = true;
                tsmiCut.Enabled = true;
                tsmiMoveUp.Enabled = DG_Edit.SelectedRows.Contains(DG_Edit.Rows[0]) ? false : true;
                tsmiMoveDown.Enabled = DG_Edit.SelectedRows.Contains(DG_Edit.Rows[DG_Edit.RowCount - 1]) ? false : true;
                if (SelectedRowForbiddenUnanimous())
                {
                    if (normalBlock.ToolList[DG_Edit.Rows.GetFirstRow(DataGridViewElementStates.Selected)].Disable)
                    {
                        tsmiForbidden.Text = "启用";
                        tsmiForbidden.Image = Properties.Resources.启用;
                    }
                    else
                    {
                        tsmiForbidden.Text = "禁用";
                        tsmiForbidden.Image = Properties.Resources.禁用;
                    }
                    tsmiForbidden.Enabled = true;
                }
            }
        }

        /// <summary>
        /// 当前选择的所有工具的禁用属性是否保持一致
        /// </summary>
        /// <returns></returns>
        bool SelectedRowForbiddenUnanimous()
        {
            bool state = normalBlock.ToolList[DG_Edit.Rows.GetFirstRow(DataGridViewElementStates.Selected)].Disable;//获得满足条件的第一个工具的状态
            foreach (DataGridViewRow item in DG_Edit.SelectedRows)
            {
                if (!state.Equals(normalBlock.ToolList[item.Index].Disable))
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        void DG_Edit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//用户双击单元格的任意部分编辑该工具
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                ExecuteEdit(normalBlock.ToolList[DG_Edit.CurrentCell.RowIndex]);
            }
        }

        void BGWrok_DoWork(object sender, DoWorkEventArgs e)
        {
            if (e.Argument is IToolable toolable && toolable != null)
            {
                toolable.ComputerExecuteTime();
            }
        }

        void BGWrok_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                cms.Enabled = true;
                ts_Tools.Enabled = true;
                DG_Edit.Enabled = true;
                Tools_Add_Edit_Event(true);
            }));
        }

        public void SetLayout()
        {
            _frmDebug.ChangeLayout();
        }
    }
}
