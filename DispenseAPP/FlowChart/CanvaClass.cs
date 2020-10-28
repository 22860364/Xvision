using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{

    public enum SelectShape { Null, Block, Arrow, Line, Selected }
    public class CanvaClass
    {
        public CanvaClass(ProjectParamClass projectParam)
        {
            _canvas_ProjectParam = projectParam;
        }

        private ProjectParamClass _canvas_ProjectParam;
        public event EditConfirmDelegate SelectedNormalChange;//定义当前选择的普通算子块发生变化
        public Element _currentSelectNormalBlock = null;//当前选择的普通算子块 
        public ElementType _elementType;
        private FlowChartCommand _receiverCommand;//流程图命令
        private bool _mouseLeftIsDown = false;//鼠标左键是否被按下
        private Point _oldPosition;
        private Point _mouseLeftDownPosition;//鼠标左键按下的位置
        private Point _leftDownMovePosition;//释放鼠标时的位置
        private Rectangle _currentRectangle;
        private bool _isDrawRectangle = false;
        private bool _isDrawArrowLine = false;
        public List<Element> _selectedBlockList = new List<Element>();//选择的算子块集合
        public List<Element> _pastCheckedBlockList = new List<Element>();//存储复制的算子块
        private SelectShape _selectShape = SelectShape.Null;//当前选择的形状
        private Element _arrowElement = null;//鼠标左键按下箭头所对应的算子块
        private ArrowClass _arrow = null;//鼠标左键按下所对应的箭头
        public ChartLine _selectedChartLine = null;
        public ArrowClass _doubleClickArrow;
        private int x;
        private int y;
        public static PointF PictureBoxLocation { get; set; }
        public static PointF PictureBoxBottomRight { get; set; }

        public Element RightMouseSelectedBlock { get; set; }

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
                        ExecuteDrawBlock();
                        break;
                    case "MouseDown":
                        ExecuteMouseDown();
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

        private void ExecuteAddPort()//添加端口
        {
            RightMouseSelectedBlock.AddPort();
        }

        private void ExecuteDeletePort()//删除端口
        {
            ArrowClass arrow = RightMouseSelectedBlock._arrowList[RightMouseSelectedBlock._arrowList.Count - 1];
            ChartLine chartLine = _canvas_ProjectParam._chartLineList.Find(c => c.StartArrow == arrow);
            if (chartLine != null)
            {
                _canvas_ProjectParam._chartLineList.Remove(chartLine);
            }
            RightMouseSelectedBlock.DeletePort();
        }

        private void ExecuteMouseDoubleClick()//执行双击鼠标事件
        {
            _selectedChartLine = null;
            _doubleClickArrow = null;
            foreach (ChartLine item in _canvas_ProjectParam._chartLineList)
            {
                if (item.IsOverFun(x, y) == true)
                {
                    _selectedChartLine = item;
                }
            }
            foreach (Element item in _canvas_ProjectParam._flowChartList)
            {
                if (item is SwitchBlock)
                {
                    for (int i = 0; i < item._arrowList.Count; i++)
                    {
                        if (item._arrowList[i].ArrowType == ArrowEnum.ouput && i != (item._arrowList.Count - 1) && item._arrowList[i].isOver(x, y) == true)
                        {
                            _doubleClickArrow = item._arrowList[i];
                            _doubleClickArrow._ifSwitchJudgeClass.Port = i;
                            return;
                        }
                    }
                }
                else if (item is IfElseBlock)
                {
                    for (int i = 0; i < item._arrowList.Count; i++)
                    {
                        if (item._arrowList[i].ArrowType == ArrowEnum.ouput && item._arrowList[i].PortID == 1 && item._arrowList[i].isOver(x, y) == true)
                        {
                            _doubleClickArrow = item._arrowList[i];
                            _doubleClickArrow._ifSwitchJudgeClass.Port = 1;
                            return;
                        }
                    }
                }
            }
        }

        private void ExecuteDrawBlock()// 执行画算子块
        {
            Element element = null;
            switch (_elementType)
            {
                case ElementType.StartBlock:
                    element = new StartBlock(new Rectangle(x, y, 100, 60), _canvas_ProjectParam)
                    {
                        IsStartBlock = true,
                        Name = "Start"
                    };
                    _canvas_ProjectParam._flowChartList.Add(element);
                    break;
                case ElementType.NormalBlock:
                    element = new NormalBlock(new Rectangle(x, y, 100, 60), _canvas_ProjectParam);
                    foreach (Element item in _canvas_ProjectParam._flowChartList)
                    {
                        item.NormalIsSelected = false;
                    }
                    element.NormalIsSelected = true;
                    NormalBlock normalBlock = element as NormalBlock;
                    if (normalBlock != null)
                    {
                        SelectedNormalChange(normalBlock);//触发普通算子块改变事件
                    }
                    normalBlock.WindowIndex = 1.ToString();
                    _currentSelectNormalBlock = element;
                    for (int i = 1; i < int.MaxValue; i++)
                    {
                        string name = "Block" + i.ToString();
                        if (QueryFlowChartExitsName(name) == false)
                        {
                            element.Name = name;
                            break;
                        }
                    }
                    _canvas_ProjectParam._flowChartList.Add(element);
                    break;
                case ElementType.IfElseBlock:
                    element = new IfElseBlock(new Rectangle(x, y, 130, 60), _canvas_ProjectParam);
                    for (int i = 1; i < int.MaxValue; i++)
                    {
                        string name = "If" + i.ToString();
                        if (QueryFlowChartExitsName(name) == false)
                        {
                            element.Name = name;
                            break;
                        }
                    }
                    _canvas_ProjectParam._flowChartList.Add(element);
                    break;
                case ElementType.SwitchBlock:
                    element = new SwitchBlock(new Rectangle(x, y, 130, 60), _canvas_ProjectParam);
                    for (int i = 1; i < int.MaxValue; i++)
                    {
                        string name = "Switch" + i.ToString();
                        if (QueryFlowChartExitsName(name) == false)
                        {
                            element.Name = name;
                            break;
                        }
                    }
                    _canvas_ProjectParam._flowChartList.Add(element);
                    break;
                case ElementType.ThreadStartBlock:
                    element = new ThreadStartBlock(new Rectangle(x, y, 130, 60), _canvas_ProjectParam);
                    for (int i = 1; i < int.MaxValue; i++)
                    {
                        string name = "StartThread" + i.ToString();
                        if (QueryFlowChartExitsName(name) == false)
                        {
                            element.Name = name;
                            break;
                        }
                    }
                    _canvas_ProjectParam._flowChartList.Add(element);
                    break;
                case ElementType.ThreadStopBlock:
                    element = new ThreadEndBlock(new Rectangle(x, y, 130, 60), _canvas_ProjectParam);
                    for (int i = 1; i < int.MaxValue; i++)
                    {
                        string name = "EndThread" + i.ToString();
                        if (QueryFlowChartExitsName(name) == false)
                        {
                            element.Name = name;
                            break;
                        }
                    }
                    _canvas_ProjectParam._flowChartList.Add(element);
                    break;
            }
        }

        private bool QueryFlowChartExitsName(string name)// 查询流程图集合中是否已经存在该名称
        {
            foreach (Element item in _canvas_ProjectParam._flowChartList)
            {
                if (item.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void ExecuteMouseDown()// 执行鼠标按下事件
        {
            bool _isSelectedNormalBlock = false;//是否有选择到普通普通算子块
            _selectShape = SelectShape.Null;
            _arrowElement = null;
            _arrow = null;
            foreach (Element item in _canvas_ProjectParam._flowChartList)//遍历存放算子块的集合
            {
                if (item.IsIn(x, y) == true)
                {
                    _selectShape = SelectShape.Block;
                    if (item is NormalBlock)//普通算子块
                    {
                        _isSelectedNormalBlock = true;
                        _currentSelectNormalBlock = item;
                        SelectedNormalChange(item);//触发普通算子块改变事件 
                        item.NormalIsSelected = true;
                    }
                }
                else
                {
                    item.NormalIsSelected = false;
                }
                if(IsRunState == false )
                {
                    for (int i = 0; i < item._arrowList.Count; i++)
                    {
                        if (item._arrowList[i].isOver(x, y) == true)
                        {
                            if (item._arrowList[i].ArrowType == ArrowEnum.ouput && item._arrowList[i]._connectElement == null)
                            {
                                if (item is IfElseBlock)
                                {
                                    IfElseBlock ifElseBlock = item as IfElseBlock;
                                    if (item._arrowList[i] == ifElseBlock._arrowList[2] && ifElseBlock._arrowList[3]._connectElement != null || item._arrowList[i] == ifElseBlock._arrowList[3] && ifElseBlock._arrowList[2]._connectElement != null)
                                    {
                                        _selectShape = SelectShape.Null;
                                        break;
                                    }
                                }
                                _selectShape = SelectShape.Arrow;
                                _arrow = item._arrowList[i];//鼠标按下选择的箭头
                                _arrowElement = item;//鼠标按下的箭头对应的算子块
                            }
                            else//当前鼠标按下的位置是箭头的位置但是该箭头不是输出类型或者该箭头已经连接其它的算子块了
                            {
                                _selectShape = SelectShape.Null;
                            }
                        }
                    }
                }
            }
            if(IsRunState == false)
            {
                foreach (ChartLine item in _canvas_ProjectParam._chartLineList)
                {
                    foreach (LineParent items in item.subLineList)
                    {
                        if (!(items is StartLine) && !(items is EndLine))
                        {
                            if (items.IsOver(x, y) == true)
                            {
                                items.IsDrag = true;
                                _oldPosition = new Point(x, y);
                                _selectShape = SelectShape.Line;
                            }
                            else
                            {
                                items.IsDrag = false;
                            }
                        }
                    }
                }
            }
            if (_isSelectedNormalBlock == false)//确保选中一个普通算子块
            {
                if (_currentSelectNormalBlock != null)
                {
                    _currentSelectNormalBlock.NormalIsSelected = true;
                    SelectedNormalChange(_currentSelectNormalBlock);//触发普通算子块改变事件 
                }
            }
            if(IsRunState == false)
            {
                if (_selectShape == SelectShape.Null)//没有选中任何块
                {
                    _selectShape = SelectShape.Selected;
                    _selectedBlockList.Clear();
                }
            }
        }

        private void ExecuteMouseLeftDown()// 执行鼠标左键按下
        {
            _mouseLeftDownPosition = new Point(x, y);
            _mouseLeftIsDown = true;//按下鼠标左键拖拽时不显示箭头        
            foreach (Element item in _canvas_ProjectParam._flowChartList)
            {
                if (item.IsIn(x, y) == true)
                {
                    if (_selectedBlockList.Count == 0)
                    {
                        item.IsDragSelected = true;
                    }
                    _oldPosition = new Point(x, y);
                }
                else
                {
                    if (_selectedBlockList.Count == 0)
                    {
                        item.IsDragSelected = false;
                    }
                }
            }
        }

        private void ExecuteMouseRightDown()// 执行鼠标右键按下
        {
            RightMouseSelectedBlock = null;
            foreach (var item in _canvas_ProjectParam._flowChartList)
            {
                if (item.IsIn(x, y) == true)
                {
                    RightMouseSelectedBlock = item;
                    break;
                }
            }
        }

        private void ExecuteMouseLeftMove()// 执行按下鼠标左键移动
        {
            _leftDownMovePosition = new Point(_receiverCommand.MouseInfo.X, _receiverCommand.MouseInfo.Y);
            if (_selectShape == SelectShape.Selected)//当选择的为空时 画选择矩形
            {
                _isDrawRectangle = true;
            }
            else if (_selectShape == SelectShape.Arrow)//当选择的箭头时 画直线
            {
                _isDrawArrowLine = true;
            }
            else if (_selectShape == SelectShape.Block) //当选择的位块时  移动选择的块
            {
                _isDrawRectangle = false;//移动算子块
                if (_receiverCommand.MouseInfo.X > PictureBoxLocation.X + 5 && _receiverCommand.MouseInfo.Y > PictureBoxLocation.Y + 5)
                {
                    int dx = _receiverCommand.MouseInfo.X - _oldPosition.X;
                    int dy = _receiverCommand.MouseInfo.Y - _oldPosition.Y;
                    foreach (Element item in _canvas_ProjectParam._flowChartList)
                    {
                        if (item.IsDragSelected == true)
                        {
                            item._rectangleRegion.X += dx;
                            item._rectangleRegion.Y += dy;
                            item.ChangePosition();
                            ProjectIsChange = true;
                        }
                    }
                    _oldPosition.X += dx;
                    _oldPosition.Y += dy;
                }
            }
            else if (_selectShape == SelectShape.Line)//执行移动  当鼠标按键按下的位置为可移动的直线时
            {
                ProjectIsChange = true;//移动直线
                if (_receiverCommand.MouseInfo.X > PictureBoxLocation.X + 3 && _receiverCommand.MouseInfo.Y > PictureBoxLocation.Y + 3 && _receiverCommand.MouseInfo.X < PictureBoxBottomRight.X - 3 && _receiverCommand.MouseInfo.Y < PictureBoxBottomRight.Y - 3)
                {
                    int dx = _receiverCommand.MouseInfo.X - _oldPosition.X;
                    int dy = _receiverCommand.MouseInfo.Y - _oldPosition.Y;
                    foreach (var item in _canvas_ProjectParam._chartLineList)
                    {
                        foreach (LineParent items in item.subLineList)
                        {
                            if (items.IsDrag == true)
                            {
                                if (items is FirstLine)
                                {
                                    item.FirstOffset += dy;
                                }
                                else if (items is SecondLine)
                                {
                                    item.SecondOffset += dx;
                                }
                                else if (items is ThirdLine)
                                {
                                    item.ThirdOffset += dy;
                                }
                            }
                        }
                    }
                    _oldPosition.X += dx;
                    _oldPosition.Y += dy;
                }
            }
        }

        private void ExecuteMouseUp()// 执行释放鼠标按钮
        {
            _mouseLeftIsDown = false;
            if (_isDrawRectangle == true)
            {
                foreach (Element item in _canvas_ProjectParam._flowChartList)
                {
                    if (!(item is StartBlock))
                    {
                        if (item.QueryIsChecked(_currentRectangle) == true)
                        {
                            _selectedBlockList.Add(item);
                            item.IsDragSelected = true;
                        }
                        else
                        {
                            item.IsDragSelected = false;
                        }
                    }
                }
            }
            _isDrawRectangle = false;
            if (_isDrawArrowLine == true)
            {
                foreach (Element item in _canvas_ProjectParam._flowChartList)
                {
                    for (int i = 0; i < item._arrowList.Count; i++)
                    {
                        if (item._arrowList[i].ArrowType == ArrowEnum.input)
                        {
                            if (item._arrowList[i].isOver(x, y) == true)
                            {
                                ProjectIsChange = true;//画直线
                                ChartLine line = new ChartLine
                                {
                                    StartArrow = _arrow,
                                    EndArrow = item._arrowList[i],
                                    StartBlock = _arrowElement,
                                    EndBlock = item
                                };
                                _arrow._connectElement = item;
                                _canvas_ProjectParam._chartLineList.Add(line);
                                break;
                            }
                        }
                    }
                }
            }
            _isDrawArrowLine = false;
        }

        private void ExecuteMouseMove()// 执行鼠标移动
        {
            if (_mouseLeftIsDown == false)
            {
                foreach (Element item in _canvas_ProjectParam._flowChartList)
                {
                    if (item.IsIn(x, y) == true)
                    {
                        item.IsOver = true;
                    }
                    else
                    {
                        item.IsOver = false;
                    }
                }
                foreach (ChartLine item in _canvas_ProjectParam._chartLineList)
                {
                    if (item.IsOverFun(x, y) == true)
                    {
                        item.IsOver = true;
                    }
                    else
                    {
                        item.IsOver = false;
                    }
                }
            }
            foreach (var item in _canvas_ProjectParam._flowChartList)
            {
                for (int i = 0; i < item._arrowList.Count; i++)
                {
                    if (item._arrowList[i].isOver(x, y) == true)
                    {
                        item._arrowList[i].IsOver = true;
                    }
                    else
                    {
                        item._arrowList[i].IsOver = false;
                    }
                }
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Element item in _canvas_ProjectParam._flowChartList)// 画图形
            {
                item.Draw(item.Name, g);
            }
        }

        public void DrawArrows(Graphics g)// 画箭头
        {
            foreach (Element item in _canvas_ProjectParam._flowChartList)
            {
                if (item.IsOver == true)
                {
                    item.DrawArrow(g);
                }
                for (int i = 0; i < item._arrowList.Count; i++)
                {
                    if (item._arrowList[i].IsOver == true)
                    {
                        item._arrowList[i].FillArrow(g);
                    }
                }
            }
        }

        public void DrawRectangle(Graphics g)// 画选择的矩形
        {
            if (_isDrawRectangle == true)
            {
                Pen myPen = new Pen(Color.Black, 1)
                {
                    DashStyle = DashStyle.Custom,
                    DashPattern = new float[] { 1f, 1f }
                };
                if (_mouseLeftDownPosition.X <= _leftDownMovePosition.X && _mouseLeftDownPosition.Y >= _leftDownMovePosition.Y)//第一象限
                {
                    _currentRectangle = new Rectangle(_mouseLeftDownPosition.X, _leftDownMovePosition.Y, Math.Abs(_leftDownMovePosition.X - _mouseLeftDownPosition.X), Math.Abs(_leftDownMovePosition.Y - _mouseLeftDownPosition.Y));
                }
                else if (_mouseLeftDownPosition.X > _leftDownMovePosition.X && _mouseLeftDownPosition.Y > _leftDownMovePosition.Y)//第二象限
                {
                    _currentRectangle = new Rectangle(_leftDownMovePosition.X, _leftDownMovePosition.Y, Math.Abs(_leftDownMovePosition.X - _mouseLeftDownPosition.X), Math.Abs(_leftDownMovePosition.Y - _mouseLeftDownPosition.Y));
                }
                else if (_mouseLeftDownPosition.X > _leftDownMovePosition.X && _mouseLeftDownPosition.Y < _leftDownMovePosition.Y)//第三象限
                {
                    _currentRectangle = new Rectangle(_leftDownMovePosition.X, _mouseLeftDownPosition.Y, Math.Abs(_leftDownMovePosition.X - _mouseLeftDownPosition.X), Math.Abs(_leftDownMovePosition.Y - _mouseLeftDownPosition.Y));
                }
                else if (_mouseLeftDownPosition.X <= _leftDownMovePosition.X && _mouseLeftDownPosition.Y < _leftDownMovePosition.Y)//第四象限
                {
                    _currentRectangle = new Rectangle(_mouseLeftDownPosition.X, _mouseLeftDownPosition.Y, Math.Abs(_leftDownMovePosition.X - _mouseLeftDownPosition.X), Math.Abs(_leftDownMovePosition.Y - _mouseLeftDownPosition.Y));
                }
                g.DrawRectangle(myPen, _currentRectangle);
            }
        }

        public void DrawSelectedBlock(Graphics g)// 画选择的块
        {
            foreach (Element item in _selectedBlockList)
            {
                if (!(item is StartBlock))
                {
                    item.DrawSelectedRectangle(g);
                }
            }
        }

        public void DrawArrowLine(Graphics g)// 画带箭头的直线
        {
            if (_isDrawArrowLine == true)
            {
                Pen pen = new Pen(Color.Black);
                AdjustableArrowCap acc = new AdjustableArrowCap(7, 4);
                pen.CustomEndCap = acc;
                g.DrawLine(pen, _mouseLeftDownPosition, _leftDownMovePosition);
            }
            foreach (ChartLine item in _canvas_ProjectParam._chartLineList)
            {
                item.DrawLine(g);
            }
        }
    }
}
