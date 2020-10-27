using DispenseAPP.FlowChart;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    public partial class UC_FlowChart : UserControl
    {

        public event EditConfirmDelegate ChangeSelectedNormalBolck;//定义所选择的普通算子块发生改变时事件 

        MouseEventArgs _e;

        CanvaClass canvaClass;//画布

        private ProjectParamClass _flowChart_ProjectParam;

        #region 初始化
        public UC_FlowChart(ProjectParamClass projectParam)
        {
            InitializeComponent();
            _flowChart_ProjectParam = projectParam;
            canvaClass = new CanvaClass(_flowChart_ProjectParam);
            canvaClass.SelectedNormalChange += CanvaClass_SelectedNormalChange;//注册画布触发的普通算子块改变的事件  
        }

        public void DrawStartBlock()//画初始算子块 （一个开始算子块和一个普通算子块）
        {
            //画开始算子块
            _e = new MouseEventArgs(MouseButtons.Left, 1, 500, 100, 0);
            canvaClass._elementType = ElementType.StartBlock;
            canvaClass.ReceiverCommand = new FlowChartCommand("DrawBlock", _e, 0);
            //画普通算子块
            _e = new MouseEventArgs(MouseButtons.Left, 1, 500, 200, 0);
            canvaClass._elementType = ElementType.NormalBlock;
            canvaClass.ReceiverCommand = new FlowChartCommand("DrawBlock", _e, 0);
            PictureBox_FlowChart.Invalidate();
        }

        private void CanvaClass_SelectedNormalChange(object anyType)
        {
            ChangeSelectedNormalBolck(anyType);
        }
        #endregion

        #region PictureBox事件
        private void PictureBox_FlowChart_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)//控件有焦点并按下某个键触发
        {
            if (e.KeyData == Keys.Escape)
            {
                canvaClass._pastCheckedBlockList.Clear();
            }
        }

        private void PictureBox_FlowChart_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox_FlowChart.Focus();
            _e = new MouseEventArgs(e.Button, 1, e.X, e.Y, 0);
            canvaClass.ReceiverCommand = new FlowChartCommand("MouseDown", _e, 0);
            if (IsRunState == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    canvaClass.ReceiverCommand = new FlowChartCommand("MouseLeftDown", _e, 0);
                }
                else if (e.Button == MouseButtons.Right)
                {
                    canvaClass.ReceiverCommand = new FlowChartCommand("MouseRightDown", _e, 0);
                    BindPictureBoxFlowChartCM();
                }
            }
            PictureBox_FlowChart.Invalidate();
        }

        private void PictureBox_FlowChart_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsRunState == false)
            {
                MouseEventArgs mouseArgs = new MouseEventArgs(e.Button, 1, e.X, e.Y, 0);
                canvaClass.ReceiverCommand = new FlowChartCommand("MouseMove", mouseArgs, 0);
                if (e.Button == MouseButtons.Left)//按下左键拖动所选择的形状
                {
                    canvaClass.ReceiverCommand = new FlowChartCommand("MouseLeftMove", mouseArgs, 0);
                    SetScrollMinSize();
                }
                PictureBox_FlowChart.Invalidate();
            }
        }
        public void SetScrollMinSize()//设置自动滚动区域的最小逻辑大小
        {
            //当释放鼠标后如果移动的算子块中超出了工作区域 则需要设置自动滚动区域的最小逻辑大小
            float x1 = 0, y1 = 0;
            int i = 0;
            foreach (Element item in _flowChart_ProjectParam._flowChartList)
            {
                float clientX = item._rectangleRegion.X + item._rectangleRegion.Width;
                float clientY = item._rectangleRegion.Y + item._rectangleRegion.Height;
                if (i == 0)
                {
                    x1 = item._rectangleRegion.X + item._rectangleRegion.Width;
                    y1 = item._rectangleRegion.Y + item._rectangleRegion.Height;
                }
                if (clientX > x1)
                {
                    x1 = clientX;
                }
                if (clientY > y1)
                {
                    y1 = clientY;
                }
                i++;
            }
            Panle_FlowChart.AutoScrollMinSize = new Size((int)x1 + 20, (int)y1 + 20);
        }

        private void PictureBox_FlowChart_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsRunState == false)
            {
                MouseEventArgs mouseArgs = new MouseEventArgs(e.Button, 1, e.X, e.Y, 0);
                canvaClass.ReceiverCommand = new FlowChartCommand("MouseUp", mouseArgs, 0);
                PictureBox_FlowChart.Invalidate();
            }
        }

        private void PictureBox_FlowChart_MouseDoubleClick(object sender, MouseEventArgs e)// 用鼠标双击控件时发生
        {
            if (IsRunState == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    MouseEventArgs mouseArgs = new MouseEventArgs(e.Button, 1, e.X, e.Y, 0);
                    canvaClass.ReceiverCommand = new FlowChartCommand("MouseDoubleClick", mouseArgs, 0);
                    if (canvaClass._selectedChartLine != null)
                    {
                        PictureBox_FlowChart.ContextMenuStrip = CM_Delete;
                        PictureBox_FlowChart.ContextMenuStrip.Show(PictureBox_FlowChart, e.X, e.Y);
                    }
                    if (canvaClass._doubleClickArrow != null)
                    {
                        FrmIfSwitchPort frmIfSwitchPort = new FrmIfSwitchPort(canvaClass._doubleClickArrow._ifSwitchJudgeClass, _flowChart_ProjectParam);
                        frmIfSwitchPort.ShowDialog();
                    }
                    PictureBox_FlowChart.Invalidate();
                }
            }
        }

        private void PictureBox_FlowChart_Paint(object sender, PaintEventArgs e)//重绘事件
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(PictureBox_FlowChart.BackColor);
            canvaClass.DrawSelectedBlock(e.Graphics);
            canvaClass.Draw(e.Graphics);
            canvaClass.DrawArrows(e.Graphics);
            canvaClass.DrawRectangle(e.Graphics);
            canvaClass.DrawArrowLine(e.Graphics);
        }
        #endregion

        private void BindPictureBoxFlowChartCM()
        {
            if (canvaClass.RightMouseSelectedBlock is StartBlock)
            {
                PictureBox_FlowChart.ContextMenuStrip = null;
            }
            else if (canvaClass._selectedBlockList.Count > 0)
            {
                PictureBox_FlowChart.ContextMenuStrip = CM_Selected;
                tsmi_复制.Enabled = true;
                tsmi_删除所有.Enabled = true;
                if (canvaClass._pastCheckedBlockList.Count <= 0)
                {
                    tsmi_粘贴.Enabled = false;
                }
                else
                {
                    tsmi_粘贴.Enabled = true;
                }
            }
            else if (canvaClass.RightMouseSelectedBlock is NormalBlock)
            {
                PictureBox_FlowChart.ContextMenuStrip = CM_Set;
                tsmi_添加连接端口.Visible = false;
                tsmi_删除连接端口.Visible = false;
                tsmi_设为开始算子.Visible = true;
                tsmi_设为运行一次.Visible = true;
            }
            else if (canvaClass.RightMouseSelectedBlock is IfElseBlock)
            {
                PictureBox_FlowChart.ContextMenuStrip = CM_Set;
                tsmi_添加连接端口.Visible = false;
                tsmi_删除连接端口.Visible = false;
                tsmi_设为开始算子.Visible = false;
                tsmi_设为运行一次.Visible = false;
            }
            else if (canvaClass.RightMouseSelectedBlock is SwitchBlock || canvaClass.RightMouseSelectedBlock is ThreadStartBlock || canvaClass.RightMouseSelectedBlock is ThreadEndBlock)
            {
                PictureBox_FlowChart.ContextMenuStrip = CM_Set;
                tsmi_设为开始算子.Visible = false;
                tsmi_设为运行一次.Visible = false;
                tsmi_添加连接端口.Visible = true;
                if (canvaClass.RightMouseSelectedBlock.portCount >= 10)
                {
                    tsmi_添加连接端口.Enabled = false;
                }
                else
                {
                    tsmi_添加连接端口.Enabled = true;
                }
                tsmi_删除连接端口.Visible = true;
                if (canvaClass.RightMouseSelectedBlock.portCount <= 3)
                {
                    tsmi_删除连接端口.Enabled = false;
                }
                else
                {
                    tsmi_删除连接端口.Enabled = true;
                }
            }
            else if (canvaClass.RightMouseSelectedBlock == null)
            {
                if (canvaClass._pastCheckedBlockList.Count > 0)
                {
                    PictureBox_FlowChart.ContextMenuStrip = CM_Selected;
                    tsmi_粘贴.Enabled = true;
                    if (canvaClass._selectedBlockList.Count <= 0)
                    {
                        tsmi_复制.Enabled = false;
                        tsmi_删除所有.Enabled = false;
                    }
                    else
                    {
                        tsmi_复制.Enabled = true;
                        tsmi_删除所有.Enabled = true;
                    }
                }
                else
                {
                    PictureBox_FlowChart.ContextMenuStrip = CM_Add;
                }
            }
        }

        #region 创建算子块
        private void 创建普通算子块ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            canvaClass._elementType = ElementType.NormalBlock;
            canvaClass.ReceiverCommand = new FlowChartCommand("DrawBlock", _e, 0);
            PictureBox_FlowChart.Invalidate();
            SetScrollMinSize();
        }

        private void 创建单条件算子块ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            canvaClass._elementType = ElementType.IfElseBlock;
            canvaClass.ReceiverCommand = new FlowChartCommand("DrawBlock", _e, 0);
            PictureBox_FlowChart.Invalidate();
            SetScrollMinSize();
        }

        private void 创建多条件算子块ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            canvaClass._elementType = ElementType.SwitchBlock;
            canvaClass.ReceiverCommand = new FlowChartCommand("DrawBlock", _e, 0);
            PictureBox_FlowChart.Invalidate();
            SetScrollMinSize();
        }

        private void 创建开始线程算子块ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            canvaClass._elementType = ElementType.ThreadStartBlock;
            canvaClass.ReceiverCommand = new FlowChartCommand("DrawBlock", _e, 0);
            PictureBox_FlowChart.Invalidate();
            SetScrollMinSize();
        }

        private void 创建结束线程算子块ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            canvaClass._elementType = ElementType.ThreadStopBlock;
            canvaClass.ReceiverCommand = new FlowChartCommand("DrawBlock", _e, 0);
            PictureBox_FlowChart.Invalidate();
            SetScrollMinSize();
        }
        #endregion

        #region 设置算子块
        private void 设置名称ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            FrmRenameBlock frmRenameBlock = new FrmRenameBlock(canvaClass.RightMouseSelectedBlock.Name, _flowChart_ProjectParam);
            frmRenameBlock.EditConfirmEvent += FrmRenameBlock_EditConfirmEvent;
            frmRenameBlock.ShowDialog();
        }

        private void FrmRenameBlock_EditConfirmEvent(object anyType)//重命名事件
        {
            canvaClass.RightMouseSelectedBlock.Name = (string)anyType;
        }

        private void 删除算子ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除此算子块？", "删除算子块", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                List<ChartLine> ChartLineList = new List<ChartLine>();
                foreach (ChartLine chartLine in _flowChart_ProjectParam._chartLineList)
                {
                    if (chartLine.StartBlock == canvaClass.RightMouseSelectedBlock || chartLine.EndBlock == canvaClass.RightMouseSelectedBlock)//清除箭头的_connectElment
                    {
                        chartLine.StartArrow._connectElement = null;
                        chartLine.EndArrow._connectElement = null;
                        ChartLineList.Add(chartLine);
                    }
                }
                foreach (ChartLine item in ChartLineList)
                {
                    _flowChart_ProjectParam._chartLineList.Remove(item);
                }
                _flowChart_ProjectParam._flowChartList.Remove(canvaClass.RightMouseSelectedBlock);
                PictureBox_FlowChart.Invalidate();
                ProjectIsChange = true;
                ChangeSelectedNormalBolck(null);
            }
        }

        private void 添加连接端口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            _e = new MouseEventArgs(MouseButtons.Right, 1, 500, 100, 0);
            canvaClass.ReceiverCommand = new FlowChartCommand("AddPort", _e, 0);
            PictureBox_FlowChart.Invalidate();
            SetScrollMinSize();
        }

        private void 删除连接端口ToolStripMenuItem_Click(object sender, EventArgs e)//删除端口时要同时将端口连接的线删除
        {
            ProjectIsChange = true;
            _e = new MouseEventArgs(MouseButtons.Right, 1, 500, 100, 0);
            canvaClass.ReceiverCommand = new FlowChartCommand("DeletePort", _e, 0);
            PictureBox_FlowChart.Invalidate();
            SetScrollMinSize();
        }

        private void 设为开始算子ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            if (canvaClass.RightMouseSelectedBlock is NormalBlock)
            {
                canvaClass.RightMouseSelectedBlock.IsStartBlock = true;
            }
        }

        private void 设为运行一次ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
        }
        #endregion

        #region 编辑算子块
        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            canvaClass._pastCheckedBlockList.Clear();
            foreach (Element item in canvaClass._selectedBlockList)
            {
                canvaClass._pastCheckedBlockList.Add(item);
            }
            canvaClass._selectedBlockList.Clear();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            string name = null;
            for (int i = 0; i < canvaClass._pastCheckedBlockList.Count; i++)
            {
                Element _element = null;
                if (canvaClass._pastCheckedBlockList[i] is NormalBlock)//普通算子块
                {
                    name = "Block";
                }
                else if (canvaClass._pastCheckedBlockList[i] is IfElseBlock)
                {
                    name = "If";
                }
                else if (canvaClass._pastCheckedBlockList[i] is SwitchBlock)
                {
                    name = "Switch";
                }
                else if (canvaClass._pastCheckedBlockList[i] is ThreadStartBlock)
                {
                    name = "ThreadStart";
                }
                else if (canvaClass._pastCheckedBlockList[i] is ThreadEndBlock)
                {
                    name = "ThreadEnd";
                }
                _element = canvaClass._pastCheckedBlockList[i].Clone();
                for (int j = 1; j < int.MaxValue; j++)
                {
                    if (QueryFlowChartExitsName(name + j.ToString()) == false)
                    {
                        _element.Name = name + j.ToString();
                        break;
                    }
                }
                _element.NormalIsSelected = false;
                _element._rectangleRegion.X = _e.X + canvaClass._pastCheckedBlockList[i]._rectangleRegion.X - canvaClass._pastCheckedBlockList[0]._rectangleRegion.X;
                _element._rectangleRegion.Y = _e.Y + canvaClass._pastCheckedBlockList[i]._rectangleRegion.Y - canvaClass._pastCheckedBlockList[0]._rectangleRegion.Y;
                _element.ChangePosition();
                _flowChart_ProjectParam._flowChartList.Add(_element);
            }
            canvaClass._pastCheckedBlockList.Clear();
            PictureBox_FlowChart.Invalidate();
            SetScrollMinSize();
        }

        private void 删除所有ToolStripMenuItem_Click(object sender, EventArgs e)//删除时要将算子连接的直线也删除
        {
            if (MessageBox.Show("确认删除此算子块？", "删除算子块", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                foreach (Element item in canvaClass._selectedBlockList)
                {
                    if (!(item is StartBlock))
                    {
                        _flowChart_ProjectParam._flowChartList.Remove(item);
                    }
                    foreach (ChartLine chartLine in _flowChart_ProjectParam._chartLineList)
                    {
                        if (chartLine.StartBlock == item || chartLine.EndBlock == item)
                        {
                            chartLine.StartArrow._connectElement = null;
                            chartLine.EndArrow._connectElement = null;
                            _flowChart_ProjectParam._chartLineList.Remove(chartLine);
                            break;
                        }
                    }
                }
                canvaClass._selectedBlockList.Clear();
                PictureBox_FlowChart.Invalidate();
                ProjectIsChange = true;
                SetScrollMinSize();
            }
        }
        #endregion

        #region 编辑直线
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            canvaClass._selectedChartLine.StartArrow._connectElement = null;
            canvaClass._selectedChartLine.EndArrow._connectElement = null;
            _flowChart_ProjectParam._chartLineList.Remove(canvaClass._selectedChartLine);
            canvaClass._selectedChartLine = null;
        }
        #endregion

        private bool QueryFlowChartExitsName(string name)// 查询流程图集合中是否已经存在该名称
        {
            foreach (Element item in _flowChart_ProjectParam._flowChartList)
            {
                if (item.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void UC_FlowChart_Load(object sender, EventArgs e)
        {
            if (CurrentWhetherNewProject == true)//如果当前是新建项目 则需要画开始算子块
            {
                DrawStartBlock();
            }
            else//打开之前的项目
            {
                foreach (var item in _flowChart_ProjectParam._flowChartList)
                {
                    if (item.NormalIsSelected == true)
                    {
                        canvaClass._currentSelectNormalBlock = item;
                        ChangeSelectedNormalBolck(item);//需注意：如果这个触发事件放在构造函数中会有问题 原因是：在类中事件的初始化在构造函数之后
                        break;
                    }
                }
            }
        }

        private void Panle_FlowChart_Resize(object sender, EventArgs e)
        {
            CanvaClass.PictureBoxLocation = PictureBox_FlowChart.Location;
            CanvaClass.PictureBoxBottomRight = new PointF(PictureBox_FlowChart.Location.X + PictureBox_FlowChart.Size.Width, PictureBox_FlowChart.Location.Y + PictureBox_FlowChart.Size.Height);
        }
    }
}
