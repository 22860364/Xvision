using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    public enum SelectShape { Null, Block, Arrow, Line, Select }
    public class Canva
    {
        /// <summary>
        /// 当选择的普通算子块发生变化时触发 1.添加普通算子块时 2.鼠标左键选中普通算子块时
        /// </summary>
        public event Action<OperatorBlock> SelectedNormalChange;

        /// <summary>
        /// 算子块类型
        /// </summary>
        public BlockType _elementType;

        /// <summary>
        /// 流程图窗体发送给画布的命令
        /// </summary>
        FlowChartCommand _receiverCommand;
        
        /// <summary>
        /// 当用户鼠标按下的位置（旧）
        /// </summary>
        Point _oldPosition;

        /// <summary>
        /// 鼠标左键按下的位置（当前）
        /// </summary>
        Point mouseDownPosition;

        /// <summary>
        /// 鼠标释放的位置
        /// </summary>
        Point _leftDownMovePosition;

        /// <summary>
        /// 选择矩形
        /// </summary>
        Rectangle selectRectangle;

        /// <summary>
        /// 画选择矩形
        /// </summary>
        bool drawSelectRectangle = false;

        /// <summary>
        /// 画直线
        /// </summary>
        bool drawLine = false;

        /// <summary>
        /// 移动直线
        /// </summary>
        bool moveLine = false;

        /// <summary>
        /// 选择矩形的算子块集合
        /// </summary>
        public List<BlockItem> selectedBlockList = new List<BlockItem>();

        /// <summary>
        /// 复制的算子块的集合
        /// </summary>
        public List<BlockItem> _pastCheckedBlockList = new List<BlockItem>();

        /// <summary>
        /// 鼠标左键按下的模式
        /// </summary>
        SelectShape _selectShape = SelectShape.Null;

        /// <summary>
        /// 鼠标左键按下选择的箭头
        /// </summary>
        Arrow _arrow = null;

        /// <summary>
        /// 双击鼠标选择的箭头
        /// </summary>
        public Arrow _doubleClickArrow;

        int x;
        int y;

        public static PointF PictureBoxLocation { get; set; }

        /// <summary>
        /// 鼠标左键按下选择的直线
        /// </summary>
        LineItem mouseDownSelectLine = null;

        /// <summary>
        /// 鼠标双击选择的直线
        /// </summary>
        public LineItem mouseDoubleClickSelectLine = null;

        /// <summary>
        /// 鼠标左键按下选择的算子块
        /// </summary>
        public BlockItem mouseDownSelectBlock = null;

        /// <summary>
        /// 鼠标左键按下箭头对应的算子块
        /// </summary>
        BlockItem ArrowBlock = null;

        /// <summary>
        /// 鼠标右键按下选择的算子块
        /// </summary>
        public BlockItem MouseRightSelectBlock = null;

        public FlowChartCommand ReceiverCommand// 接收的命令
        {
            set
            {
                _receiverCommand = value;
                x = value.MouseInfo.X;
                y = value.MouseInfo.Y;
                switch (value.CommandText)
                {
                    case "DrawBlock":
                        AddDrawBlock();
                        break;
                    case "MouseLeftDown":
                        ExecuteMouseLeftDown();
                        break;
                    case "MouseRightDown":
                        ExecuteMouseRightDown();
                        break;
                    case "MouseMove":
                        ExecuteMouseMove();
                        break;
                    case "MouseLeftMove":
                        ExecuteMouseLeftMove();
                        break;
                    case "MouseUp":
                        ExecuteMouseUp();
                        break;
                    case "MouseDoubleClick":
                        ExecuteMouseDoubleClick();
                        break;
                    case "AddPort":
                        ExecuteAddPort();
                        break;
                    case "DeletePort":
                        ExecuteDeletePort();
                        break;
                }
            }
        }

        void ExecuteAddPort()//添加端口
        {
            MouseRightSelectBlock.AddPort();
        }

        void ExecuteDeletePort()//删除端口
        {
            Arrow arrow = MouseRightSelectBlock.ArrowList[MouseRightSelectBlock.ArrowList.Count - 1];
            LineItem chartLine = StaticPublicData.LineItems[LineArrowType.StartArrow,arrow];
            if (chartLine != null)
            {
                StaticPublicData.LineItems.Remove(chartLine);
            }
            MouseRightSelectBlock.DeletePort();
        }

        /// <summary>
        /// 鼠标的双击事件
        /// </summary>
        void ExecuteMouseDoubleClick()
        {
            mouseDoubleClickSelectLine = null;
            _doubleClickArrow = null;
            foreach (LineItem item in StaticPublicData.LineItems)
            {
                if (item.IsOverFun(x, y) == true)
                {
                    mouseDoubleClickSelectLine = item;
                    return;
                }
            }
            foreach (BlockItem item in StaticPublicData.BlockItems)
            {
                if (item is SwitchBlock)
                {
                    for (int i = 0; i < item.ArrowList.Count; i++)
                    {
                        if (item.ArrowList[i].Type == ArrowEnum.ouput && i != (item.ArrowList.Count - 1) && item.ArrowList[i].IsOver(x, y))
                        {
                            _doubleClickArrow = item.ArrowList[i];
                            if (_doubleClickArrow.ConditionalJudgmentInstance == null)
                            {
                                _doubleClickArrow.ConditionalJudgmentInstance = new FlowChart.ConditionalJudgment();
                            }
                            _doubleClickArrow.ConditionalJudgmentInstance.Port = i;
                            return;
                        }
                    }
                }
                else if (item is IfBlock)
                {
                    for (int i = 0; i < item.ArrowList.Count; i++)
                    {
                        if (item.ArrowList[i].Type == ArrowEnum.ouput && item.ArrowList[i].Port == 1 && item.ArrowList[i].IsOver(x, y))
                        {
                            _doubleClickArrow = item.ArrowList[i];
                            if (_doubleClickArrow.ConditionalJudgmentInstance == null)
                            {
                                _doubleClickArrow.ConditionalJudgmentInstance = new FlowChart.ConditionalJudgment();
                            }
                            _doubleClickArrow.ConditionalJudgmentInstance.Port = 1;
                            return;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 添加算子块
        /// </summary>
        void AddDrawBlock()
        {
            BlockItem element = null;
            switch (_elementType)
            {
                case BlockType.StartBlock:
                    element = new StartBlock(new Rectangle(x, y, 100, 60), "Start", GetBlockSystemName("ST"));
                    break;
                case BlockType.NormalBlock:
                    element = new OperatorBlock(new Rectangle(x, y, 100, 60), GetBlockCustomName("Operation"),GetBlockSystemName("O"));
                    SelectedNormalChange(element as OperatorBlock);
                    break;
                case BlockType.IfElseBlock:
                    element = new IfBlock(new Rectangle(x, y, 130, 60), GetBlockCustomName("If"),GetBlockSystemName("I"));
                    break;
                case BlockType.SwitchBlock:
                    element = new SwitchBlock(new Rectangle(x, y, 130, 60), GetBlockCustomName("Switch"),GetBlockSystemName("SW"));
                    break;
                case BlockType.ThreadStartBlock:
                    element = new MultiThreadStartBlock(new Rectangle(x, y, 130, 60), GetBlockCustomName("ThreadStart"),GetBlockSystemName("TS"));
                    break;
                case BlockType.ThreadStopBlock:
                    element = new MultiThreadEndBlock(new Rectangle(x, y, 130, 60), GetBlockCustomName("ThreadStop"), GetBlockSystemName("TE"));
                    break;
            }
            StaticPublicData.BlockItems.Add(element);
        }

        /// <summary>
        /// 执行鼠标按下事件  1.选中的是算子块 2.选中的是直线 3.选中的是箭头 4.选中的是空
        /// </summary>
        private void ExecuteMouseLeftDown()
        {
            mouseDownPosition = new Point(x, y);
            _selectShape = SelectShape.Select;
            ArrowBlock = null;
            _arrow = null;
            mouseDownSelectLine = null;
            _oldPosition = new Point(x, y);
            foreach (BlockItem item in StaticPublicData.BlockItems)
            {
                if (item.MousetheAbove(x, y))
                {
                    _selectShape = SelectShape.Block;
                    if (mouseDownSelectBlock != null && selectedBlockList.Count == 0)//首先将上次选中的算子的拖动设置为false
                    {
                        mouseDownSelectBlock.IsDrag = false;
                    }
                    mouseDownSelectBlock = item;
                    mouseDownSelectBlock.IsDrag = true;
                    if (item is OperatorBlock operatorBlock)//如果当前鼠标选中的算子块是普通算子块 则触发普通算子块改变事件
                    {
                        SelectedNormalChange(operatorBlock);
                        StaticPublicData.SystemData.LastSelectedBlockName = operatorBlock.CustomName;//记录当前选择的普通算子块的名称
                    }
                    return;
                }
                for (int i = 0; i < item.ArrowList.Count; i++)
                {
                    if (item.ArrowList[i].Type == ArrowEnum.ouput && item.ArrowList[i].ConnectBlock == null && item.ArrowList[i].InAbove)
                    {
                        if (item is IfBlock ifBlock)
                        {
                            if ((item.ArrowList[i].Equals(ifBlock.ArrowList[2]) && ifBlock.ArrowList[3].ConnectBlock != null) || (item.ArrowList[i].Equals(ifBlock.ArrowList[3]) && ifBlock.ArrowList[2].ConnectBlock != null))
                            {
                                _selectShape = SelectShape.Null;
                                return;
                            }
                        }
                        _selectShape = SelectShape.Arrow;
                        _arrow = item.ArrowList[i];//鼠标按下选择的箭头
                        ArrowBlock = item;//鼠标按下的箭头对应的算子块
                        return;
                    }
                }
            }
            foreach (LineItem item in StaticPublicData.LineItems)
            {
                foreach (LineBase items in item.SubLineList)
                {
                    if (!(items is StartLine) && !(items is EndLine) && items.IsOver(x, y))
                    {
                        mouseDownSelectLine = item;
                        foreach (LineBase itemss in mouseDownSelectLine.SubLineList)
                        {
                            if (itemss.Equals(items))
                            {
                                itemss.IsDrag = true;
                                break;
                            }
                        }
                        _selectShape = SelectShape.Line;
                        return;
                    }
                }
            }
            if (_selectShape == SelectShape.Null || _selectShape == SelectShape.Select)//没有选中任何块
            {
                foreach (BlockItem item in selectedBlockList)
                {
                    item.IsDrag = false;
                }
                selectedBlockList.Clear();
            }
        }

        /// <summary>
        /// 执行鼠标右键按下事件
        /// </summary>
        void ExecuteMouseRightDown()
        {
            MouseRightSelectBlock = null;
            foreach (BlockItem item in StaticPublicData.BlockItems)
            {
                if (item.MousetheAbove(x, y) == true)
                {
                    MouseRightSelectBlock = item;
                    break;
                }
            }
        }

        /// <summary>
        /// 执行鼠标左键按下移动事件
        /// </summary>
        void ExecuteMouseLeftMove()
        {
            _leftDownMovePosition = new Point(_receiverCommand.MouseInfo.X, _receiverCommand.MouseInfo.Y);
            if (_selectShape == SelectShape.Select)//当选择的为空时 画选择矩形
            {
                drawSelectRectangle = true;
            }
            else if (_selectShape == SelectShape.Arrow)//当选择的箭头时 画直线
            {
                drawLine = true;
            }
            else if (_selectShape == SelectShape.Block) //当选择的位块时  移动选择的块
            {
                drawSelectRectangle = false;//移动算子块
                if (_receiverCommand.MouseInfo.X > PictureBoxLocation.X + 5 && _receiverCommand.MouseInfo.Y > PictureBoxLocation.Y + 5)
                {
                    int dx = _receiverCommand.MouseInfo.X - _oldPosition.X;
                    int dy = _receiverCommand.MouseInfo.Y - _oldPosition.Y;
                    foreach (BlockItem item in StaticPublicData.BlockItems)
                    {
                        if (item.IsDrag == true)
                        {
                            item.Region = new RectangleF(item.Region.X + dx, item.Region.Y + dy, item.Region.Width, item.Region.Height);
                            ProjectIsChange = true;
                        }
                    }
                    _oldPosition.X += dx;
                    _oldPosition.Y += dy;
                }
            }
            else if (_selectShape == SelectShape.Line)//执行移动  当鼠标按键按下的位置为可移动的直线时
            {
                moveLine = true;
                ProjectIsChange = true;//移动直线
                int dx = _receiverCommand.MouseInfo.X - _oldPosition.X;
                int dy = _receiverCommand.MouseInfo.Y - _oldPosition.Y;
                if (mouseDownSelectLine != null)
                {
                    foreach (LineBase item in mouseDownSelectLine.SubLineList)
                    {
                        if (item.IsDrag)
                        {
                            if (item is FirstLine)
                            {
                                mouseDownSelectLine.FirstOffset += dy;
                            }
                            else if (item is SecondLine)
                            {
                                mouseDownSelectLine.SecondOffset += dx;
                            }
                            else if (item is ThirdLine)
                            {
                                mouseDownSelectLine.ThirdOffset += dy;
                            }
                        }
                    }
                }
                _oldPosition.X += dx;
                _oldPosition.Y += dy;
            }
        }

        /// <summary>
        /// 执行鼠标弹起事件
        /// </summary>
        private void ExecuteMouseUp()
        {
            if (drawSelectRectangle)//画选择矩形
            {
                drawSelectRectangle = false;
                if(mouseDownSelectBlock != null)
                {
                    mouseDownSelectBlock.IsDrag = false;
                }
                foreach (BlockItem item in StaticPublicData.BlockItems)
                {
                    if (!(item is StartBlock))
                    {
                        if (item.IsSelectedBySelectRectangle(selectRectangle))
                        {
                            selectedBlockList.Add(item);
                            item.IsDrag = true;
                        }
                        else
                        {
                            item.IsDrag = false;
                        }
                    }
                }
            }
            else if (drawLine)//画直线
            {
                drawLine = false;
                foreach (BlockItem item in StaticPublicData.BlockItems)
                {
                    for (int i = 0; i < item.ArrowList.Count; i++)
                    {
                        if (item.ArrowList[i].Type == ArrowEnum.input)
                        {
                            if (item.ArrowList[i].IsOver(x, y))
                            {
                                ProjectIsChange = true;
                                LineItem line = new LineItem
                                {
                                    StartBlockPort = _arrow.Port,
                                    EndBlockPort = item.ArrowList[i].Port,
                                    StartBlockName = ArrowBlock.SystemName,
                                    EndBlockName = item.SystemName,
                                };
                                line.AddSubLines();
                                _arrow.ConnectBlockName = item.SystemName;
                                StaticPublicData.LineItems.Add(line);
                                return;
                            }
                        }
                    }
                }
            }
            else if (moveLine)//代表鼠标按下是移动直线
            {
                moveLine = false;
                foreach (LineBase item in mouseDownSelectLine.SubLineList)
                {
                    if (item.IsDrag)//如果在鼠标按下移动的时候该直线被选中 那么当鼠标释放后 选中的直线恢复未选中状态
                    {
                        item.IsDrag = false;
                        break;
                    }
                }
            }
        }

        private void ExecuteMouseMove()// 执行鼠标移动
        {
            foreach (BlockItem item in StaticPublicData.BlockItems)
            {
                item.IsOver = item.MousetheAbove(x, y) ? true : false;
            }
            foreach (LineItem item in StaticPublicData.LineItems)
            {
                item.IsOver = item.IsOverFun(x, y) ? true : false;
            }
            foreach (BlockItem item in StaticPublicData.BlockItems)
            {
                foreach (Arrow items in item.ArrowList)
                {
                    items.IsOver(x, y);
                }
            }
        }

        public void Draw(Graphics g)
        {
            foreach (BlockItem item in StaticPublicData.BlockItems)//画图形
            {
                item.Draw(g, mouseDownSelectBlock as OperatorBlock);              
            }
        }

        public void DrawRectangle(Graphics g)//画选择的矩形
        {
            if (drawSelectRectangle == true)
            {
                Pen myPen = new Pen(Color.LimeGreen, 1)
                {
                    DashStyle = DashStyle.Custom,
                    DashPattern = new float[] { 1f, 1f }
                };
                if (mouseDownPosition.X <= _leftDownMovePosition.X && mouseDownPosition.Y >= _leftDownMovePosition.Y)//第一象限
                {
                    selectRectangle = new Rectangle(mouseDownPosition.X, _leftDownMovePosition.Y, Math.Abs(_leftDownMovePosition.X - mouseDownPosition.X), Math.Abs(_leftDownMovePosition.Y - mouseDownPosition.Y));
                }
                else if (mouseDownPosition.X > _leftDownMovePosition.X && mouseDownPosition.Y > _leftDownMovePosition.Y)//第二象限
                {
                    selectRectangle = new Rectangle(_leftDownMovePosition.X, _leftDownMovePosition.Y, Math.Abs(_leftDownMovePosition.X - mouseDownPosition.X), Math.Abs(_leftDownMovePosition.Y - mouseDownPosition.Y));
                }
                else if (mouseDownPosition.X > _leftDownMovePosition.X && mouseDownPosition.Y < _leftDownMovePosition.Y)//第三象限
                {
                    selectRectangle = new Rectangle(_leftDownMovePosition.X, mouseDownPosition.Y, Math.Abs(_leftDownMovePosition.X - mouseDownPosition.X), Math.Abs(_leftDownMovePosition.Y - mouseDownPosition.Y));
                }
                else if (mouseDownPosition.X <= _leftDownMovePosition.X && mouseDownPosition.Y < _leftDownMovePosition.Y)//第四象限
                {
                    selectRectangle = new Rectangle(mouseDownPosition.X, mouseDownPosition.Y, Math.Abs(_leftDownMovePosition.X - mouseDownPosition.X), Math.Abs(_leftDownMovePosition.Y - mouseDownPosition.Y));
                }
                g.DrawRectangle(myPen, selectRectangle);
            }
        }

        /// <summary>
        /// 画选择阴影
        /// </summary>
        /// <param name="g"></param>
        public void DrawSelectedBlock(Graphics g)
        {
            foreach (BlockItem item in selectedBlockList)
            {
                item.DrawSelectedRectangle(g);
            }
        }

        public void DrawArrowLine(Graphics g)// 画带箭头的直线
        {
            if (drawLine == true)
            {
                Pen pen = new Pen(Color.Black);
                AdjustableArrowCap acc = new AdjustableArrowCap(7, 4);
                pen.CustomEndCap = acc;
                g.DrawLine(pen, mouseDownPosition, _leftDownMovePosition);
            }
            foreach (LineItem item in StaticPublicData.LineItems)
            {
                item.DrawLine(g);
            }
        }
    }
}
