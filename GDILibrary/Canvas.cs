using System.Drawing;
using System.Windows.Forms;

namespace GDILibrary
{

    public class Canvas
    {
        public Canvas(Form frm)
        {
            _frm = frm;
        }

        private Form _frm;

        private DrawCommand _receiveCommand;

        public DrawType DrawShapeType { get; set; }

        private bool _mouseLeftDown;

        public Element _element;//当前界面上的实体

        private Point _mouseLeftDownPosition;

        private bool _elementIsSelected;//实体被选中

        private RectanglePoint _rectanglePoint = null;

        private bool _isDrawRectPoint;

        public DrawCommand ReceiveCommand
        {
            set
            {
                _receiveCommand = value;
                switch (value.CommandText)
                {
                    case CommandType.MouseLeftDown:
                        ExecuteMouseDown();
                        break;
                    case CommandType.MouseUp:
                        ExecuteMouseUp();
                        break;
                    case CommandType.MouseMove:
                        ExecuteMouseMove();
                        break;
                }
            }
        }

        private void ExecuteMouseDown()//执行鼠标按下事件
        {
            int x = _receiveCommand.MouseInfo.X;
            int y = _receiveCommand.MouseInfo.Y;
            _mouseLeftDownPosition = new Point(x, y);//鼠标左键按下的位置
            _mouseLeftDown = true;
            if (_element != null)//当有实体对象时才遍历当前实体
            {
                foreach (RectanglePoint item in _element._rectanglPointList)//遍历当前实体所有的矩形点
                {
                    if (item.IsInRectanglePoint(x, y) == true)
                    {
                        _rectanglePoint = item;//获得鼠标按下的实心矩形
                        _elementIsSelected = false;
                        break;
                    }
                }
            }
            if (DrawShapeType == DrawType.Rectangle )//判断当前有没有画图形
            {
                _element = new DrawRectangle(new Rectangle(x, y, 0, 0));
                _isDrawRectPoint = true;
            }
            else if(DrawShapeType == DrawType.Rectangle2)
            {
                _element = new DrawRectangle2(new Rectangle(x, y, 0, 0));
                _isDrawRectPoint = true;
            }
            else if(_rectanglePoint == null)//当不画图像 并且当前选择的矩形为空时 
            {
                if (_element.IsOver(x, y))
                {
                    _elementIsSelected = true;
                    _isDrawRectPoint = true;
                }
                else
                {
                    _isDrawRectPoint = false;
                    _elementIsSelected = false;
                    DrawShapeType = DrawType.Null;
                }
            }
        }

        private void ExecuteMouseUp()//执行释放鼠标事件
        {
            _mouseLeftDown = false;
            _rectanglePoint = null;
            DrawShapeType = DrawType.Null;//当释放鼠标后则画的类型为null
        }

        private void ExecuteMouseMove()//执行鼠标移动事件
        {
            int x = _receiveCommand.MouseInfo.X;
            int y = _receiveCommand.MouseInfo.Y;
            if (_mouseLeftDown == true)//鼠标左键被按下
            {
                int dx = _receiveCommand.MouseInfo.X - _mouseLeftDownPosition.X;
                int dy = _receiveCommand.MouseInfo.Y - _mouseLeftDownPosition.Y;//鼠标按下的位置和当前位置的差值
                if (DrawShapeType == DrawType.Rectangle || DrawShapeType == DrawType.Rectangle2)//画矩形
                {
                    _element._rectangle.Width = dx;
                    _element._rectangle.Height = dy;
                    _element.ChangePosition();
                    _elementIsSelected = true;//第一次画实体时默认选中状态 
                }
                else if (_elementIsSelected)//移动实体
                {
                    _element._rectangle.X += dx;
                    _element._rectangle.Y += dy;
                    _mouseLeftDownPosition.X = _receiveCommand.MouseInfo.X;
                    _mouseLeftDownPosition.Y = _receiveCommand.MouseInfo.Y;
                    _element.ChangePosition();
                }
                else if (_rectanglePoint!=null)
                {
                    _element.ChangeSize(_rectanglePoint.RectangleType, new PointF(dx, dy));
                    _mouseLeftDownPosition.X = _receiveCommand.MouseInfo.X;
                    _mouseLeftDownPosition.Y = _receiveCommand.MouseInfo.Y;
                    _element.ChangePosition();
                }
            }
            if (_mouseLeftDown == false)
            {
                _frm.Cursor = Cursors.Default;
                if (_isDrawRectPoint == true)//只要当前实体被选中的状态下才会改变鼠标的形状
                {
                    foreach (RectanglePoint item in _element._rectanglPointList)
                    {
                        if (item.IsInRectanglePoint(x, y) == true)
                        {
                            switch (item.RectangleType)
                            {
                                case RectanglePointType.LeftBottom://左上
                                    _frm.Cursor = Cursors.SizeNESW;
                                    break;
                                case RectanglePointType.LeftMid://左中
                                    _frm.Cursor = Cursors.SizeWE;
                                    break;
                                case RectanglePointType.LeftTop://左下
                                    _frm.Cursor = Cursors.SizeNWSE;
                                    break;
                                case RectanglePointType.MidBottom://中上
                                    _frm.Cursor = Cursors.SizeNS;
                                    break;
                                case RectanglePointType.MidTop://中下
                                    _frm.Cursor = Cursors.SizeNS;
                                    break;
                                case RectanglePointType.RightBottom://右上
                                    _frm.Cursor = Cursors.SizeNWSE;
                                    break;
                                case RectanglePointType.RightMid://右中
                                    _frm.Cursor = Cursors.SizeWE;
                                    break;
                                case RectanglePointType.RightTop://右下
                                    _frm.Cursor = Cursors.SizeNESW;
                                    break;
                                case RectanglePointType.Top:
                                    _frm.Cursor = Cursors.Cross;
                                    break;
                            }
                            break;
                        }
                    }
                }
            }
        }

        public void Draw(Graphics g)
        {
            if (_element != null)
            {
                _element.Draw(g);//画形状
                if (_isDrawRectPoint == true)
                {
                    _element.DrawRectanglePoint(g);//画圆点
                }
            }
        }
    }
}
