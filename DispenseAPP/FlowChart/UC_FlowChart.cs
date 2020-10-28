using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    public partial class UC_FlowChart : UserControl
    {
        public event Action<OperatorBlock> ChangeSelectedNormalBolck;//定义所选择的普通算子块发生改变时事件 
        MouseEventArgs _e;
        Canva canvaClass;//画布

        public void ChangePBControlEnable(bool enable)//改变PictureBox控件的使能状态
        {
            BeginInvoke(new Action(() => { picFlowChart.Enabled = enable; }));
        }

        #region 初始化
        public UC_FlowChart()
        {
            InitializeComponent();
            canvaClass = new Canva();
            canvaClass.SelectedNormalChange += CanvaClass_SelectedNormalChange;//注册画布触发的普通算子块改变的事件  
            CreateInitialBlock();
            InitialLastSelectedBlock();
        }

        /// <summary>
        /// 初始化上一次选择的算子块
        /// </summary>
        void InitialLastSelectedBlock()
        {
            if (StaticPublicData.SystemData.LastSelectedBlockName != null)
            {
                if (StaticPublicData.BlockItems[NameType.CustomName,StaticPublicData.SystemData.LastSelectedBlockName] is OperatorBlock block)
                {
                    canvaClass.mouseDownSelectBlock = block;
                    CanvaClass_SelectedNormalChange(block);
                }
            }
        }

        /// <summary>
        /// 创建初始化算子块
        /// </summary>
        public void CreateInitialBlock()
        {
            if(StaticPublicData.BlockItems.FindIndex(c=>c is StartBlock) == -1)
            {
                _e = new MouseEventArgs(MouseButtons.Left, 1, 500, 100, 0);
                canvaClass._elementType = BlockType.StartBlock;
                canvaClass.ReceiverCommand = new FlowChartCommand("DrawBlock", _e, 0);
                picFlowChart.Invalidate();
            }
        }

        private void CanvaClass_SelectedNormalChange(OperatorBlock operatorBlock )
        {
            ChangeSelectedNormalBolck?.Invoke(operatorBlock);
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
            picFlowChart.Focus();
            _e = new MouseEventArgs(e.Button, 1, e.X, e.Y, 0);
            if (IsRunState == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    canvaClass.ReceiverCommand = new FlowChartCommand("MouseLeftDown", _e, 0);
                }
                else if (e.Button == MouseButtons.Right)
                {
                    canvaClass.ReceiverCommand = new FlowChartCommand("MouseRightDown", _e, 0);
                    SetContextMenuStripEnableVisible();
                }
            }
            picFlowChart.Invalidate();
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
                }
                picFlowChart.Invalidate();
            }
        }
        public void SetScrollMinSize()//设置自动滚动区域的最小逻辑大小
        {
            //当释放鼠标后如果移动的算子块中超出了工作区域 则需要设置自动滚动区域的最小逻辑大小
            float x1 = 0, y1 = 0;
            int i = 0;
            foreach (BlockItem item in StaticPublicData.BlockItems)
            {
                float clientX = item.Region.X + item.Region.Width;
                float clientY = item.Region.Y + item.Region.Height;
                if (i == 0)
                {
                    x1 = item.Region.X + item.Region.Width;
                    y1 = item.Region.Y + item.Region.Height;
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
            Panel_FlowChart.AutoScrollMinSize = new Size((int)x1 + 20, (int)y1 + 20);
        }

        private void PictureBox_FlowChart_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsRunState == false)
            {
                MouseEventArgs mouseArgs = new MouseEventArgs(e.Button, 1, e.X, e.Y, 0);
                canvaClass.ReceiverCommand = new FlowChartCommand("MouseUp", mouseArgs, 0);
                picFlowChart.Invalidate();
                if (e.Button == MouseButtons.Left)
                {
                    SetScrollMinSize();
                }
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
                    if (canvaClass.mouseDoubleClickSelectLine != null)
                    {
                        picFlowChart.ContextMenuStrip = CM_Delete;
                        picFlowChart.ContextMenuStrip.Show(picFlowChart, e.X, e.Y);
                    }
                    if (canvaClass._doubleClickArrow != null)
                    {
                        FrmIfSwitchPort frmIfSwitchPort = new FrmIfSwitchPort(canvaClass._doubleClickArrow.ConditionalJudgmentInstance);
                        frmIfSwitchPort.ShowDialog();
                    }
                    picFlowChart.Invalidate();
                }
            }
        }

        private void PictureBox_FlowChart_Paint(object sender, PaintEventArgs e)//重绘事件
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(picFlowChart.BackColor);
            canvaClass.DrawSelectedBlock(e.Graphics);
            canvaClass.Draw(e.Graphics);
            canvaClass.DrawRectangle(e.Graphics);
            canvaClass.DrawArrowLine(e.Graphics);
        }
        #endregion

        /// <summary>
        /// 设置菜单栏的使能和隐藏
        /// </summary>
        private void SetContextMenuStripEnableVisible()
        {
            if(canvaClass.selectedBlockList.Count >0 )//表示
            {
                picFlowChart.ContextMenuStrip = CM_Selected;
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
                else if(canvaClass.MouseRightSelectBlock is OperatorBlock)//如果是普通算子块
                {
                    picFlowChart.ContextMenuStrip = CM_Set;
                    tsmi_添加连接端口.Visible = false;
                    tsmi_删除连接端口.Visible = false;
                }
                else if(canvaClass.MouseRightSelectBlock is IfBlock)//如果是单条件判断算子块
                {
                    picFlowChart.ContextMenuStrip = CM_Set;
                    tsmi_添加连接端口.Visible = false;
                    tsmi_删除连接端口.Visible = false;
                }
                else if(canvaClass.MouseRightSelectBlock is SwitchBlock || canvaClass.MouseRightSelectBlock is MultiThreadStartBlock || canvaClass.MouseRightSelectBlock is MultiThreadEndBlock)
                {
                    picFlowChart.ContextMenuStrip = CM_Set;
                    tsmi_添加连接端口.Visible = true;
                    tsmi_添加连接端口.Enabled = canvaClass.MouseRightSelectBlock.OutputPortCount >= 10 ? false : true; 
                    tsmi_删除连接端口.Visible = true;
                    tsmi_删除连接端口.Enabled = canvaClass.MouseRightSelectBlock.OutputPortCount <= 3 ? false : true;
                }
            else if(canvaClass.MouseRightSelectBlock == null)
            {
                if (canvaClass._pastCheckedBlockList.Count > 0)
                {
                    picFlowChart.ContextMenuStrip = CM_Selected;
                    tsmi_粘贴.Enabled = true;
                    if (canvaClass.selectedBlockList.Count <= 0)
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
                    picFlowChart.ContextMenuStrip = CM_Add;
                }
            }
        }

        #region 创建算子块
        private void 创建普通算子块ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            canvaClass._elementType = BlockType.NormalBlock;
            canvaClass.ReceiverCommand = new FlowChartCommand("DrawBlock", _e, 0);
            picFlowChart.Invalidate();
            SetScrollMinSize();
        }

        private void 创建单条件算子块ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            canvaClass._elementType = BlockType.IfElseBlock;
            canvaClass.ReceiverCommand = new FlowChartCommand("DrawBlock", _e, 0);
            picFlowChart.Invalidate();
            SetScrollMinSize();
        }

        private void 创建多条件算子块ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            canvaClass._elementType = BlockType.SwitchBlock;
            canvaClass.ReceiverCommand = new FlowChartCommand("DrawBlock", _e, 0);
            picFlowChart.Invalidate();
            SetScrollMinSize();
        }

        private void 创建开始线程算子块ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            canvaClass._elementType = BlockType.ThreadStartBlock;
            canvaClass.ReceiverCommand = new FlowChartCommand("DrawBlock", _e, 0);
            picFlowChart.Invalidate();
            SetScrollMinSize();
        }

        private void 创建结束线程算子块ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            canvaClass._elementType = BlockType.ThreadStopBlock;
            canvaClass.ReceiverCommand = new FlowChartCommand("DrawBlock", _e, 0);
            picFlowChart.Invalidate();
            SetScrollMinSize();
        }
        #endregion

        #region 设置算子块
        private void 设置名称ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            FrmRenameBlock frmRenameBlock = new FrmRenameBlock(canvaClass.MouseRightSelectBlock.CustomName);
            frmRenameBlock.EditConfirmEvent += FrmRenameBlock_EditConfirmEvent;
            frmRenameBlock.ShowDialog();
        }

        private void FrmRenameBlock_EditConfirmEvent(object anyType)//重命名事件
        {
            canvaClass.MouseRightSelectBlock.CustomName = (string)anyType;
            if(canvaClass.MouseRightSelectBlock is OperatorBlock normalBlock)//如果是普通算子块 则需要修改普通算子块中的所有工具的选择的普通算子块的名称
            {
                foreach (IToolable item in normalBlock.ToolList)
                {
                    item.OperatorBlockName = (string)anyType;
                }
            }
        }

        private void 删除算子ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除此算子块？", "删除算子块", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                List<LineItem> ChartLineList = new List<LineItem>();
                foreach (LineItem chartLine in StaticPublicData.LineItems)
                {
                    if (chartLine.StartBlock == canvaClass.MouseRightSelectBlock || chartLine.EndBlock == canvaClass.MouseRightSelectBlock)//清除箭头的_connectElment
                    {
                        chartLine.StartArrow.ConnectBlockName = null;
                        chartLine.EndArrow.ConnectBlockName = null;
                        ChartLineList.Add(chartLine);
                    }
                }
                foreach (LineItem item in ChartLineList)
                {
                    StaticPublicData.LineItems.Remove(item);
                }
                StaticPublicData.BlockItems.Remove(canvaClass.MouseRightSelectBlock);
                picFlowChart.Invalidate();
                ProjectIsChange = true;
                ChangeSelectedNormalBolck(null);
            }
        }

        private void 添加连接端口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            _e = new MouseEventArgs(MouseButtons.Right, 1, 500, 100, 0);
            canvaClass.ReceiverCommand = new FlowChartCommand("AddPort", _e, 0);
            picFlowChart.Invalidate();
            SetScrollMinSize();
        }

        private void 删除连接端口ToolStripMenuItem_Click(object sender, EventArgs e)//删除端口时要同时将端口连接的线删除
        {
            ProjectIsChange = true;
            _e = new MouseEventArgs(MouseButtons.Right, 1, 500, 100, 0);
            canvaClass.ReceiverCommand = new FlowChartCommand("DeletePort", _e, 0);
            picFlowChart.Invalidate();
            SetScrollMinSize();
        }
        #endregion

        #region 编辑算子块
        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            canvaClass._pastCheckedBlockList.Clear();
            foreach (BlockItem item in canvaClass.selectedBlockList)
            {
                canvaClass._pastCheckedBlockList.Add(item);
            }
            canvaClass.selectedBlockList.Clear();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            for (int i = 0; i < canvaClass._pastCheckedBlockList.Count; i++)
            {
                canvaClass._pastCheckedBlockList[i].IsDrag = false;
                BlockItem _element = canvaClass._pastCheckedBlockList[i].Clone();
                foreach (Arrow item in _element.ArrowList)
                {
                    item.ConnectBlockName = null;
                }
                if (canvaClass._pastCheckedBlockList[i] is OperatorBlock operatorBlock)
                {
                    _element.CustomName = GetBlockCustomName("Block");
                    _element.SystemName = GetBlockSystemName("O");
                }
                else if (canvaClass._pastCheckedBlockList[i] is IfBlock ifBlock)
                {
                    _element.CustomName = GetBlockCustomName("If");
                    _element.SystemName = GetBlockSystemName("I");
                }
                else if (canvaClass._pastCheckedBlockList[i] is SwitchBlock)
                {
                    _element.CustomName = GetBlockCustomName("Switch");
                    _element.SystemName = GetBlockSystemName("SW");
                }
                else if (canvaClass._pastCheckedBlockList[i] is MultiThreadStartBlock)
                {
                    _element.CustomName = GetBlockCustomName("ThreadStart");
                    _element.SystemName = GetBlockSystemName("TS");
                }
                else if (canvaClass._pastCheckedBlockList[i] is MultiThreadEndBlock)
                {
                    _element.CustomName = GetBlockCustomName("ThreadEnd");
                    _element.SystemName = GetBlockSystemName("TE");
                }
                _element.IsDrag = false;
                _element.Region = new RectangleF(_e.X + canvaClass._pastCheckedBlockList[i].Region.X - canvaClass._pastCheckedBlockList[0].Region.X, _e.Y + canvaClass._pastCheckedBlockList[i].Region.Y - canvaClass._pastCheckedBlockList[0].Region.Y, _element.Region.Width, _element.Region.Height);
                StaticPublicData.BlockItems.Add(_element);
            }
            canvaClass._pastCheckedBlockList.Clear();
            picFlowChart.Invalidate();
            SetScrollMinSize();
        }

        private void 删除所有ToolStripMenuItem_Click(object sender, EventArgs e)//删除时要将算子连接的直线也删除
        {
            if (MessageBox.Show("确认删除此算子块？", "删除算子块", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                foreach (BlockItem item in canvaClass.selectedBlockList)
                {
                    foreach (LineItem chartLine in StaticPublicData.LineItems)
                    {
                        if (chartLine.StartBlock.SystemName == item.SystemName || chartLine.EndBlock.SystemName == item.SystemName)
                        {
                            chartLine.StartArrow.ConnectBlockName = null;
                            chartLine.EndArrow.ConnectBlockName = null;
                            StaticPublicData.LineItems.Remove(chartLine);
                            break;
                        }
                    }
                    if (!(item is StartBlock))
                    {
                        StaticPublicData.BlockItems.Remove(item);
                    }                   
                }
                canvaClass.selectedBlockList.Clear();
                picFlowChart.Invalidate();
                ProjectIsChange = true;
                SetScrollMinSize();
            }
        }
        #endregion

        #region 编辑直线
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectIsChange = true;
            canvaClass.mouseDoubleClickSelectLine.StartArrow.ConnectBlockName = null;
            canvaClass.mouseDoubleClickSelectLine.EndArrow.ConnectBlockName = null;
            StaticPublicData.LineItems.Remove(canvaClass.mouseDoubleClickSelectLine);
            canvaClass.mouseDoubleClickSelectLine = null;
        }
        #endregion

        private bool QueryFlowChartExitsName(string name)// 查询流程图集合中是否已经存在该名称
        {
            foreach (BlockItem item in StaticPublicData.BlockItems)
            {
                if (item.CustomName == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void UC_FlowChart_Load(object sender, EventArgs e)
        {

        }

        private void Panel_FlowChart_Resize(object sender, EventArgs e)
        {
            Canva.PictureBoxLocation = picFlowChart.Location;
            //Canva.PictureBoxBottomRight = new PointF(picFlowChart.Location.X + picFlowChart.Size.Width, picFlowChart.Location.Y + picFlowChart.Size.Height);
        }

        #region 滚动条相关
        [DllImport("user32.dll")]
        static extern int SetScrollPos(IntPtr hwnd, int nBar, int nPos, bool bRedraw);
        [DllImport("user32.dll")]
        static extern int GetScrollPos(IntPtr hwnd, int nBar);
        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, int nBar, int wParam, int lParam);
        [DllImport("user32", CharSet = CharSet.Auto)]
        static extern bool GetScrollRange(IntPtr hWnd, int nBar, out int lpMinPos, out int lpMaxPos);

        const int SB_HORZ = 0x0;
        const int SB_VERT = 0x1;
        const int WM_HSCROLL = 0x114;
        const int WM_VSCROLL = 0x115;
        const int SB_THUMBPOSITION = 4;
        #endregion
    }
}
