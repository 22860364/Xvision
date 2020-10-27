using DispenseAPP.AboutData;
using DispenseAPP.CustomControl;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System;
using static DispenseAPP.CommonClass;
using System.Text;
using DispenseAPP.Tools_Location.ProgramDispensePath.DisplayImagePath;
using HalconDotNet;
using DispenseAPP.CommandClass;
using System.Drawing.Drawing2D;
using DispenseAPP.MathTools;

namespace DispenseAPP.AboutMotionCard
{
    public partial class FrmDispenseSet : FormM
    {
        private CommandPool commandPool = new CommandPool(100);//命令池对象
        private string clickCommand = "";//点击更多命令之前的文本
        private string commandStr;//命令下拉框的数据源
        private bool IsEditState = false;//是否在编辑状态
        private string[] valueArray;
        private string[] AxisNameArray;
        private string CardName;
        private string editBeforeValue;
        Dictionary<string, ToolStripMenuItem> SetColumnVisibleDict = new Dictionary<string, ToolStripMenuItem>();
        private List<int> editList = new List<int>();
        private Bitmap bitmap;
        private Graphics g;
        public List<string> PathCommandList = new List<string>();
        private Pen roadPen = new Pen(Color.White, 1);//画轨迹路线的笔
        private SolidBrush coordinatePointBrush = new SolidBrush(Color.White);//画坐标点的刷子
        private float coordinatePointSize;//坐标点尺寸
        private List<ValueClass> CopyCutValueList = new List<ValueClass>();//剪切和复制的值
        private List<DispensePath> _dispensePathList;
        private Point _mouseDownPosition;
        private Point _leftDownMovePosition;
        private Rectangle _currentRectangle;
        private bool _drawRectangle;//画选择矩形

        public FrmDispenseSet(List<DispensePath> dispensePathList, string[] axisName, string cardName)
        {
            InitializeComponent();
            _dispensePathList = dispensePathList;
            DG_Motion.TopLeftHeaderCell.Value = "行号";
            AxisNameArray = axisName;
            CardName = cardName;
            valueArray = new string[4 + axisName.Length];
            Cmb_DefaultCommand.SelectedIndex = 0;
            Command.AxisCount = AxisNameArray.Length;
            PictureBox_RoadMap.BackColor = StaticLocalParamClass.roadMapParamClass.BackColor;
            for (int i = 0; i < AxisNameArray.Length + 1; i++)
            {
                editList.Add(i);
            }
            PathCommandList.AddRange(new string[] { "起点", "直线", "圆弧", "圆弧终点", "整圆终点", "单点" });
        }

        private void FrmDispenseSet_Load(object sender, EventArgs e)
        {
            InitialDG_Motion(AxisNameArray);
            RegisterEvent();//这句话要在下一句话之前 先注册 然后再触发事件
            UC_AxisState.InitialDG_Position(CardName, AxisNameArray);
            Command.DG_Motion = DG_Motion;
            Cmb_SelectCamera.Items.Clear();
            foreach (string item in CameraIDObjectDict.Keys)//添加相机
            {
                Cmb_SelectCamera.Items.Add(item);
            }
        }

        private void RegisterEvent()//注册事件
        {
            commandPool.ReboStateChangeEvent += CommandPool_ReboStateChangeEvent;
            commandPool.UndoStateChangeEvent += CommandPool_UndoStateChangeEvent;
        }

        private void CommandPool_UndoStateChangeEvent(bool obj)//重做状态发生变化
        {
            Tsmi_Undo.Enabled = obj;
            Tssbtn_Undo.Enabled = obj;
        }

        private void CommandPool_ReboStateChangeEvent(bool obj)//撤销状态发生变化
        {
            Tsmi_Redo.Enabled = obj;
            Tssbtn_Redo.Enabled = obj;
        }

        private void InitialDG_Motion(string[] axisArray)//初始化表格
        {
            for (int i = 0; i < axisArray.Length; i++)//添加列
            {
                DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = axisArray[i]
                };
                dataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//设置默认单元格格式
                DG_Motion.Columns.Insert(1 + i, dataGridViewTextBoxColumn);
                ToolStripMenuItem dispTSMI = new ToolStripMenuItem
                {
                    Text = "显示[" + axisArray[i] + "]列"
                };
                dispTSMI.Click += ToolStripMenuItem_Click;
                dispTSMI.Checked = true;
                CM_Operation.Items.Add(dispTSMI);
                SetColumnVisibleDict.Add(axisArray[i], dispTSMI);
                ToolStripMenuItem modifTSMI = new ToolStripMenuItem
                {
                    Text = "修改[" + axisArray[i] + "]坐标"
                };
                modifTSMI.Click += ModifTSMI_Click;
                modifTSMI.AutoSize = false;
                modifTSMI.DisplayStyle = ToolStripItemDisplayStyle.Text;
                modifTSMI.BackColor = SystemColors.Control;
                modifTSMI.Size = new Size(150, 22);
                Tssbtn_ModifPosition.DropDownItems.Add(modifTSMI);
            }
        }

        public int GetColumnIndex(string headText)//根据列头获得列索引
        {
            foreach (DataGridViewColumn item in DG_Motion.Columns)
            {
                if (item.HeaderText == headText)
                {
                    return item.Index;
                }
            }
            return -1;
        }

        private string GetAxisName(object sender)
        {
            if (sender is ToolStripMenuItem toolStripMenuItem)
            {
                int startIndex = toolStripMenuItem.Text.IndexOf('[') + 1;
                int endIndex = toolStripMenuItem.Text.IndexOf(']');
                return toolStripMenuItem.Text.Substring(startIndex, endIndex - startIndex);//截取列名
            }
            return "";
        }

        private string GetRowsValue(int index)//获得某一行的值 返回字符串 可分割的
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < DG_Motion.ColumnCount; i++)
            {
                if (i == DG_Motion.ColumnCount - 1)
                {
                    sb.Append(DG_Motion.Rows[index].Cells[i].EditedFormattedValue.ToString());
                }
                else
                {
                    sb.Append(DG_Motion.Rows[index].Cells[i].EditedFormattedValue.ToString() + ",");
                }
            }
            return sb.ToString();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)//点击隐藏事件 这里需要判断
        {
            string axisName = GetAxisName(sender);
            int columnIndex = GetColumnIndex(axisName);//获得列索引
            if (columnIndex != -1)
            {
                if (DG_Motion.Columns[columnIndex].Visible)//如果是显示的状态 则隐藏
                {
                    DG_Motion.Columns[columnIndex].Visible = false;
                    SetColumnVisibleDict[axisName].Checked = false;
                }
                else
                {
                    DG_Motion.Columns[columnIndex].Visible = true;
                    SetColumnVisibleDict[axisName].Checked = true;
                }
            }
        }

        #region DG_Motion事件
        private void DG_Motion_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)//执行行级绘制时引发的事件
        {
            Rectangle rct = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, DG_Motion.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), DG_Motion.RowHeadersDefaultCellStyle.Font, rct, DG_Motion.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

        private void DG_Motion_CurrentCellDirtyStateChanged(object sender, EventArgs e)//单元格状态因其内容更改而更改时发生
        {
            if (sender is DataGridView dataGridView)
            {
                if (dataGridView.CurrentCell.ColumnIndex == 0)
                {
                    DG_Motion.EndEdit();
                }
            }
        }

        private void DG_Motion_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)//单元格开始编辑
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                clickCommand = DG_Motion.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString();//获得点击前的命令
                for (int i = 0; i < DG_Motion.ColumnCount; i++)
                {
                    valueArray[i] = DG_Motion.Rows[DG_Motion.CurrentCell.RowIndex].Cells[i].EditedFormattedValue.ToString();
                }
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < valueArray.Length; i++)
                {
                    if (i == valueArray.Length - 1)
                    {
                        sb.Append(valueArray[i]);
                    }
                    else
                    {
                        sb.Append(valueArray[i] + ",");
                    }
                }
                editBeforeValue = sb.ToString();
            }
        }

        private void DG_Motion_CellEndEdit(object sender, DataGridViewCellEventArgs e)//单元格的编辑模式停止
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.ColumnIndex == 0 && DG_Motion.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString() == "更多命令")
                {
                    DG_Motion.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = clickCommand;
                    FrmSelectCommand frmSelectCommand = new FrmSelectCommand(ref commandStr);
                    if (frmSelectCommand.ShowDialog() == DialogResult.OK)//如果点击确定  则需要改变命令下拉框中的值
                    {
                        Col_Command.Items.Clear();
                        Col_Command.Items.AddRange(commandStr.Split(','));
                    }
                }
                for (int i = 0; i < DG_Motion.ColumnCount; i++)
                {
                    valueArray[i] = DG_Motion.Rows[DG_Motion.CurrentCell.RowIndex].Cells[i].EditedFormattedValue.ToString();
                }
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < valueArray.Length; i++)
                {
                    if (i == valueArray.Length - 1)
                    {
                        sb.Append(valueArray[i]);
                    }
                    else
                    {
                        sb.Append(valueArray[i] + ",");
                    }
                }
                if (editBeforeValue != sb.ToString())
                {
                    EditCommand editCommand = new EditCommand(DG_Motion.CurrentCell.RowIndex, editBeforeValue, sb.ToString());
                    editCommand.Excute();
                    commandPool.Register(editCommand);
                }
                PictureBox_RoadMap.Invalidate();
            }
        }

        private void DG_Motion_MouseDown(object sender, MouseEventArgs e)//在组件上方并按下鼠标时触发
        {
            int CurrentIndex = DG_Motion.HitTest(e.X, e.Y).RowIndex;
            if (e.Button == MouseButtons.Right && IsEditState == false)
            {
                CM_Operation.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void DG_Motion_MouseUp(object sender, MouseEventArgs e)//鼠标在组件上方并释放按钮时发生
        {
            ChangeTsbtnEnable();
            PictureBox_RoadMap.Invalidate();
        }
        #endregion

        #region 操作表格

        #region 添加
        private void Tssbtn_Add_Click(object sender, EventArgs e)
        {
            string value;
            if (DG_Motion.Rows.Count == 0)
            {
                value = null;
            }
            else
            {
                value = DG_Motion.Rows[DG_Motion.Rows.Count - 1].Cells[0].EditedFormattedValue.ToString();
            }
            Common(GetSystemName(value), DG_Motion.Rows.Count);
        }

        private void Tsmi_Add_直线_Click(object sender, EventArgs e)
        {
            Common("直线", DG_Motion.Rows.Count);
        }

        private void Tsmi_Add_单点_Click(object sender, EventArgs e)
        {
            Common("单点", DG_Motion.Rows.Count);
        }

        private void Tsmi_Add_圆弧_Click(object sender, EventArgs e)
        {
            Common("圆弧", DG_Motion.Rows.Count);
        }

        private string GetSystemName(string text)//系统自动命名
        {
            if (text == null)
            {
                return "起点";
            }
            string command = null;
            switch (text)
            {
                case "圆弧":
                    command = "圆弧终点";
                    break;
                default:
                    command = "直线";
                    break;
            }
            return command;
        }

        private void Tsmi_Add_起点_Click(object sender, EventArgs e)
        {
            Common("起点", DG_Motion.Rows.Count);
        }

        private void Tsmi_Add_取反端口_Click(object sender, EventArgs e)
        {
            Common("取反端口", DG_Motion.Rows.Count);
        }

        private void Tsmi_Add_关闭端口_Click(object sender, EventArgs e)
        {
            Common("关闭端口", DG_Motion.Rows.Count);
        }

        private void Tsmi_Add_打开端口_Click(object sender, EventArgs e)
        {
            Common("打开端口", DG_Motion.Rows.Count);
        }

        private void Tsmi_Add_延时_Click(object sender, EventArgs e)
        {
            Common("延时", DG_Motion.Rows.Count);
        }

        private string GetPositionRowIndexAxisIndex(int rowIndex, int axisIndex)//根据行索引和轴索引获得位置
        {
            return DG_Motion.Rows[rowIndex].Cells[axisIndex + 1].EditedFormattedValue.ToString();
        }

        private string GetCurrentPosition(int axisIndex)//根据轴索引获得位置
        {
            return UC_AxisState.GetAxisPosition(AxisNameArray[axisIndex]).ToString();
        }

        private void Tsmi_Add_矩形顺_Click(object sender, EventArgs e)
        {
            Common("直线", DG_Motion.Rows.Count, GetPositionRowIndexAxisIndex(DG_Motion.RowCount - 1, 0) + "," + GetCurrentPosition(1) + ",");
            Common("直线", DG_Motion.Rows.Count, GetCurrentPosition(0) + "," + GetCurrentPosition(1));
            Common("直线", DG_Motion.Rows.Count, GetCurrentPosition(0) + "," + GetPositionRowIndexAxisIndex(DG_Motion.RowCount - 3, 1));
            Common("直线", DG_Motion.Rows.Count, GetPositionRowIndexAxisIndex(DG_Motion.RowCount - 4, 0) + "," + GetPositionRowIndexAxisIndex(DG_Motion.RowCount - 4, 1));
        }

        private void Tsmi_Add_矩形逆_Click(object sender, EventArgs e)
        {
            Common("直线", DG_Motion.Rows.Count, GetCurrentPosition(0) + "," + GetPositionRowIndexAxisIndex(DG_Motion.RowCount - 1, 1) + "," + GetCurrentPosition(2));
            Common("直线", DG_Motion.Rows.Count, GetCurrentPosition(0) + "," + GetCurrentPosition(1) + "," + GetCurrentPosition(2));
            Common("直线", DG_Motion.Rows.Count, GetPositionRowIndexAxisIndex(DG_Motion.RowCount - 3, 0) + "," + GetCurrentPosition(1) + "," + GetCurrentPosition(2));
            Common("直线", DG_Motion.Rows.Count, GetPositionRowIndexAxisIndex(DG_Motion.RowCount - 4, 0) + "," + GetPositionRowIndexAxisIndex(DG_Motion.RowCount - 4, 1) + "," + GetCurrentPosition(2));
        }

        private void Tsmi_Add_矩形填充_Click(object sender, EventArgs e)
        {

        }

        private void Tsmi_Add_圆形填充_Click(object sender, EventArgs e)
        {

        }

        private void Common(string commandString, int index, string position = null)
        {
            valueArray[0] = commandString;
            for (int i = 0; i < AxisNameArray.Length; i++)
            {
                string value = "";
                if (PathCommandList.Contains(commandString))//如果是轨迹命令 则添加坐标 否则为""
                {
                    if (i == AxisNameArray.Length - 1)//Z坐标缺省
                    {
                        if (index == 0 || !PathCommandList.Contains(DG_Motion.Rows[index - 1].Cells[0].EditedFormattedValue.ToString()))
                        {
                            value = UC_AxisState.GetAxisPosition(AxisNameArray[i]).ToString();
                        }
                    }
                    else
                    {
                        if (position == null)
                        {
                            value = UC_AxisState.GetAxisPosition(AxisNameArray[i]).ToString();
                        }
                        else
                        {
                            value = position.Split(',')[i];
                        }
                    }
                }
                valueArray[i + 1] = value;
            }
            if (PathCommandList.Contains(commandString))
            {
                if ((index == 0 || !PathCommandList.Contains(DG_Motion.Rows[index - 1].Cells[0].EditedFormattedValue.ToString())) && Cb_WriteSpeed.Checked)//自动写入速度
                {
                    valueArray[AxisNameArray.Length + 2] = 30.ToString();
                }
                else
                {
                    valueArray[AxisNameArray.Length + 2] = "";
                }
                if ((index == 0 || !PathCommandList.Contains(DG_Motion.Rows[index - 1].Cells[0].EditedFormattedValue.ToString())) && Cb_WriteParam.Checked)//自动写入参数
                {
                    valueArray[AxisNameArray.Length + 1] = 1.ToString();
                }
                else
                {
                    valueArray[AxisNameArray.Length + 1] = "";
                }
            }
            valueArray[AxisNameArray.Length + 3] = "";//其它
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < valueArray.Length; i++)
            {
                if (i == valueArray.Length - 1)
                {
                    sb.Append(valueArray[i]);
                }
                else
                {
                    sb.Append(valueArray[i] + ",");
                }
            }

            InsertCommand insertCommand = new InsertCommand(sb.ToString(), index);
            insertCommand.Excute();
            commandPool.Register(insertCommand);
            PictureBox_RoadMap.Invalidate();
            ChangeTsbtnEnable();
        }
        #endregion

        #region 插入 默认是一行
        private void Tsmi_Insert_Click(object sender, EventArgs e)//插入 在选中行之前插入
        {
            Common(Cmb_DefaultCommand.Text, DG_Motion.CurrentCell.RowIndex);
        }

        private void Tssbtn_Insert_起点_Click(object sender, EventArgs e)
        {
            Common("起点", DG_Motion.CurrentCell.RowIndex);
        }

        private void Tssbtn_Insert_直线_Click(object sender, EventArgs e)
        {
            Common("直线", DG_Motion.CurrentCell.RowIndex);
        }

        private void Tssbtn_Insert_单点_Click(object sender, EventArgs e)
        {
            Common("单点", DG_Motion.CurrentCell.RowIndex);
        }

        private void Tssbtn_Insert_圆弧_Click(object sender, EventArgs e)
        {
            Common("圆弧", DG_Motion.CurrentCell.RowIndex);
        }

        private void Tssbtn_Insert_圆弧终点_Click(object sender, EventArgs e)
        {
            Common("圆弧终点", DG_Motion.CurrentCell.RowIndex);
        }

        private void Tssbtn_Insert_整圆终点_Click(object sender, EventArgs e)
        {
            Common("整圆终点", DG_Motion.CurrentCell.RowIndex);
        }

        private void Tssbtn_Insert_延时_Click(object sender, EventArgs e)
        {
            Common("延时", DG_Motion.CurrentCell.RowIndex);
        }

        private void Tssbtn_Insert_打开端口_Click(object sender, EventArgs e)
        {
            Common("打开端口", DG_Motion.CurrentCell.RowIndex);
        }

        private void Tssbtn_Insert_关闭端口_Click(object sender, EventArgs e)
        {
            Common("关闭端口", DG_Motion.CurrentCell.RowIndex);
        }

        private void Tssbtn_Insert_取反端口_Click(object sender, EventArgs e)
        {
            Common("取反端口", DG_Motion.CurrentCell.RowIndex);
        }
        #endregion

        #region 删除行
        private void DeleteCutCopyGetRowValue(List<ValueClass> valueClasses)
        {
            foreach (DataGridViewRow item in DG_Motion.SelectedRows)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < DG_Motion.ColumnCount; i++)
                {
                    if (i == DG_Motion.ColumnCount - 1)
                    {
                        sb.Append(DG_Motion.Rows[item.Index].Cells[i].EditedFormattedValue.ToString());
                    }
                    else
                    {
                        sb.Append(DG_Motion.Rows[item.Index].Cells[i].EditedFormattedValue.ToString() + ",");
                    }
                }
                ValueClass deleteValueClass = new ValueClass
                {
                    RowIndex = item.Index,
                    Value = sb.ToString()
                };
                valueClasses.Add(deleteValueClass);
            }
        }

        private void Tsmi_Delete_Click(object sender, EventArgs e)//删除
        {
            List<ValueClass> deleteValueList = new List<ValueClass>();
            DeleteCutCopyGetRowValue(deleteValueList);
            deleteValueList.Sort();
            DelCommand delCommand = new DelCommand(deleteValueList);
            delCommand.Excute();
            commandPool.Register(delCommand);
            PictureBox_RoadMap.Invalidate();
        }
        #endregion

        #region 修改坐标
        private void Tssbtn_InputPosition_ButtonClick(object sender, EventArgs e)//修改所有轴的坐标
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < DG_Motion.ColumnCount; i++)
            {
                valueArray[i] = DG_Motion.Rows[DG_Motion.CurrentCell.RowIndex].Cells[i].EditedFormattedValue.ToString();
            }
            for (int i = 0; i < AxisNameArray.Length; i++)
            {
                valueArray[i + 1] = UC_AxisState.GetAxisPosition(AxisNameArray[i]).ToString();
            }
            for (int i = 0; i < valueArray.Length; i++)
            {
                if (i == valueArray.Length - 1)
                {
                    sb.Append(valueArray[i]);
                }
                else
                {
                    sb.Append(valueArray[i] + ",");
                }
            }
            if (sb.ToString() != GetRowsValue(DG_Motion.CurrentCell.RowIndex))
            {
                ModifCommon(DG_Motion.CurrentCell.RowIndex, sb.ToString(), GetRowsValue(DG_Motion.CurrentCell.RowIndex));
            }
        }

        private void ModifTSMI_Click(object sender, EventArgs e)//修改单个轴的坐标
        {
            if (sender is ToolStripMenuItem modifTSMI)
            {
                int startIndex = modifTSMI.Text.IndexOf('[') + 1;
                int endIndex = modifTSMI.Text.IndexOf(']');
                string axisName = modifTSMI.Text.Substring(startIndex, endIndex - startIndex);
                int index = GetColumnIndex(axisName);
                for (int i = 0; i < DG_Motion.ColumnCount; i++)
                {
                    valueArray[i] = DG_Motion.Rows[DG_Motion.CurrentCell.RowIndex].Cells[i].EditedFormattedValue.ToString();
                }
                valueArray[index] = UC_AxisState.GetAxisPosition(axisName).ToString();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < valueArray.Length; i++)
                {
                    if (i == valueArray.Length - 1)
                    {
                        sb.Append(valueArray[i]);
                    }
                    else
                    {
                        sb.Append(valueArray[i] + ",");
                    }
                }
                if (sb.ToString() != GetRowsValue(DG_Motion.CurrentCell.RowIndex))
                {
                    ModifCommon(DG_Motion.CurrentCell.RowIndex, sb.ToString(), GetRowsValue(DG_Motion.CurrentCell.RowIndex));
                }
            }
        }

        private void ModifCommon(int index, string newValue, string oldValue)
        {
            EditCommand editCommand = new EditCommand(index, oldValue, newValue);
            editCommand.Excute();
            commandPool.Register(editCommand);
            PictureBox_RoadMap.Invalidate();
        }
        #endregion

        #region 剪切 复制 粘贴
        private void Tsmi_Cut_Click(object sender, EventArgs e)//剪切  
        {
            CopyCutValueList.Clear();
            DeleteCutCopyGetRowValue(CopyCutValueList);
            CopyCutValueList.Sort();
            CutCommand cutCommand = new CutCommand(CopyCutValueList);
            cutCommand.Excute();
            commandPool.Register(cutCommand);
            Tsmi_Past.Enabled = true;
            Tssbtn_Past.Enabled = true;
            ChangeTsbtnEnable();
        }

        private void Tsmi_Copy_Click(object sender, EventArgs e)//复制
        {
            CopyCutValueList.Clear();
            DeleteCutCopyGetRowValue(CopyCutValueList);
            CopyCutValueList.Sort();
            Tsmi_Past.Enabled = true;
            Tssbtn_Past.Enabled = true;
        }

        private void Tsmi_Past_Click(object sender, EventArgs e)//粘贴
        {
            List<ValueClass> PastBeforeValueList = new List<ValueClass>();
            DeleteCutCopyGetRowValue(PastBeforeValueList);
            PastBeforeValueList.Sort();
            PastCommand pastCommand = new PastCommand(CopyCutValueList, PastBeforeValueList);
            pastCommand.Excute();
            commandPool.Register(pastCommand);
        }
        #endregion

        private void Tsmi_Undo_Click(object sender, EventArgs e)//撤销
        {
            commandPool.Undo();
            PictureBox_RoadMap.Invalidate();
            ChangeTsbtnEnable();
        }

        private void Tsmi_Redo_Click(object sender, EventArgs e)//重做
        {
            commandPool.Rebo();
            PictureBox_RoadMap.Invalidate();
            ChangeTsbtnEnable();
        }

        private void Tsmi_Up_Click(object sender, EventArgs e)//上移 将当前选中的单行或者多行与上一行交换 动上一行
        {
            int firstIndex = DG_Motion.Rows.GetFirstRow(DataGridViewElementStates.Selected);//获得第一行索引
            int lastIndex = DG_Motion.Rows.GetLastRow(DataGridViewElementStates.Selected);//获得最后一行索引
            MoveUpCommand moveUpCommand = new MoveUpCommand(firstIndex - 1, lastIndex, GetRowsValue(firstIndex - 1));
            moveUpCommand.Excute();
            commandPool.Register(moveUpCommand);
            PictureBox_RoadMap.Invalidate();
            ChangeTsbtnEnable();
        }

        private void Tsmi_Down_Click(object sender, EventArgs e)//下移 当前选中的单行或者多行与下一行交换 动下一行
        {
            int firstIndex = DG_Motion.Rows.GetFirstRow(DataGridViewElementStates.Selected);//获得第一行索引
            int lastIndex = DG_Motion.Rows.GetLastRow(DataGridViewElementStates.Selected);//获得最后一行索引
            MoveDownCommand moveDownCommand = new MoveDownCommand(lastIndex + 1, firstIndex, GetRowsValue(lastIndex + 1));
            moveDownCommand.Excute();
            commandPool.Register(moveDownCommand);
            PictureBox_RoadMap.Invalidate();
            ChangeTsbtnEnable();
        }

        private void Tsmi_CheckAll_Click(object sender, EventArgs e)//全选
        {
            DG_Motion.SelectAll();
        }

        private void Tsmi_InvertSelect_Click(object sender, EventArgs e)//反选
        {
            foreach (DataGridViewRow item in DG_Motion.Rows)
            {
                if (item.Selected)
                {
                    item.Selected = false;
                }
                else
                {
                    item.Selected = true;
                }
            }
        }

        private void Tsbtn_InvertOrder_Click(object sender, EventArgs e)//倒序
        {
            List<ValueClass> InvertOrderValueList = new List<ValueClass>();
            DeleteCutCopyGetRowValue(InvertOrderValueList);
            InvertOrderValueList.Sort();
            CommandInvertOrder commandInvertOrder = new CommandInvertOrder(InvertOrderValueList);
            commandInvertOrder.Excute();
            commandPool.Register(commandInvertOrder);
            PictureBox_RoadMap.Invalidate();
        }
        #endregion

        private void GetDG_MotionData()//获得表格中的数据
        {
            for (int i = 0; i < DG_Motion.Rows.Count; i++)
            {
                DispensePath dispensePath = new DispensePath
                {
                    Command = DG_Motion.Rows[i].Cells[0].EditedFormattedValue.ToString(),
                    Position = new string[AxisNameArray.Length],
                    Speed = DG_Motion.Rows[i].Cells[AxisNameArray.Length + 2].EditedFormattedValue.ToString(),
                    Other = DG_Motion.Rows[i].Cells[AxisNameArray.Length + 3].EditedFormattedValue.ToString(),
                };
                for (int j = 0; j < AxisNameArray.Length; j++)
                {
                    dispensePath.Position[i] = DG_Motion.Rows[i].Cells[j + 1].EditedFormattedValue.ToString();
                }
                if (DG_Motion.Rows[i].Cells[AxisNameArray.Length + 1].EditedFormattedValue.ToString() == "")
                {

                }
                else
                {

                }
            }
        }

        private void OperationLaterExecute()//每次操作表格后要执行的操作 首先是检查错误 然后绘制轨迹
        {
            for (int i = 0; i < DG_Motion.Rows.Count; i++)//以行作为检查的单元
            {
                for (int j = 0; j < DG_Motion.ColumnCount; j++)
                {
                    DG_Motion.Rows[i].Cells[j].ErrorText = null;
                }
                switch (DG_Motion.Rows[i].Cells[0].EditedFormattedValue.ToString())
                {
                    case "起点":
                        break;
                    case "直线":
                    case "圆弧":
                        if (i == 0 || (DG_Motion.Rows[i - 1].Cells[0].EditedFormattedValue.ToString() != "起点" && DG_Motion.Rows[i - 1].Cells[0].EditedFormattedValue.ToString() != "直线"))
                        {
                            DG_Motion.Rows[i].Cells[0].ErrorText = "[" + DG_Motion.Rows[i].Cells[0].EditedFormattedValue.ToString() + "]前一行必须为起点或直线";
                        }
                        break;
                    case "圆弧终点":
                    case "整圆终点":
                        if (i == 0 || DG_Motion.Rows[i - 1].Cells[0].EditedFormattedValue.ToString() != "圆弧")
                        {
                            DG_Motion.Rows[i].Cells[0].ErrorText = "[" + DG_Motion.Rows[i].Cells[0].EditedFormattedValue.ToString() + "]前一行必须为圆弧";
                        }
                        break;
                    case "延时":
                        if (DG_Motion.Rows[i].Cells[AxisNameArray.Length + 3].EditedFormattedValue.ToString() == "")
                        {
                            DG_Motion.Rows[i].Cells[AxisNameArray.Length + 3].ErrorText = "请设置延时时间";
                        }
                        break;
                }
                if (PathCommandList.Contains(DG_Motion.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    if (DG_Motion.Rows[i].Cells[1].EditedFormattedValue.ToString() == "")
                    {
                        DG_Motion.Rows[i].Cells[1].ErrorText = "X坐标不能为空";
                    }
                    if (DG_Motion.Rows[i].Cells[2].EditedFormattedValue.ToString() == "")
                    {
                        DG_Motion.Rows[i].Cells[2].ErrorText = "Y坐标不能为空";
                    }
                }
                SetPenBrush(DG_Motion.Rows[i].Selected);
                DrawBaseType(DG_Motion.Rows[i].Cells[0].EditedFormattedValue.ToString(), i);
            }
        }

        private void SetPenBrush(bool IsSelect)
        {
            if (IsSelect)//选中状态
            {
                roadPen.Color = StaticLocalParamClass.roadMapParamClass.SelectRoadColor;
                roadPen.Width = StaticLocalParamClass.roadMapParamClass.SelectRoadWidth;
                coordinatePointBrush.Color = StaticLocalParamClass.roadMapParamClass.SelectPointColor;
                coordinatePointSize = StaticLocalParamClass.roadMapParamClass.SelectPointSize;
            }
            else//未选中状态
            {
                roadPen.Color = StaticLocalParamClass.roadMapParamClass.NoSelectRoadColor;
                roadPen.Width = StaticLocalParamClass.roadMapParamClass.NoSelectRoadWidth;
                coordinatePointBrush.Color = StaticLocalParamClass.roadMapParamClass.NoSelectPointColor;
                coordinatePointSize = StaticLocalParamClass.roadMapParamClass.NoSelectPointSize;
            }
        }

        private void DrawBaseType(string type, int i)
        {
            if (type == "") return;
            string x = DG_Motion.Rows[i].Cells[1].EditedFormattedValue.ToString();
            string y = DG_Motion.Rows[i].Cells[2].EditedFormattedValue.ToString();

            if (x == "" || y == "" || float.TryParse(x, out float xPosition) == false || float.TryParse(y, out float yPosition) == false)
            {
                return;
            }
            switch (type)
            {
                case "起点": DrawPoint(xPosition, yPosition); break;
                case "直线": DrawPoint(xPosition, yPosition); DrawLine(i); break;
                case "单点": DrawPoint(xPosition, yPosition); break;
                case "圆弧": DrawPoint(xPosition, yPosition); break;
                case "圆弧终点": DrawPoint(xPosition, yPosition); break;
            }
        }

        private void DrawPoint(float x, float y)
        {
            if (StaticLocalParamClass.roadMapParamClass.ShowPoint)//显示节点
            {
                g.FillRectangle(coordinatePointBrush, x - coordinatePointSize / 2, y - coordinatePointSize / 2, coordinatePointSize, coordinatePointSize);
            }
        }

        public void DrawLine(int i)
        {
            if (i >= 1)
            {
                float x1, y1, x2, y2;
                if (DG_Motion.Rows[i].Cells[1].EditedFormattedValue.ToString() != "" && DG_Motion.Rows[i].Cells[2].EditedFormattedValue.ToString() != "" && DG_Motion.Rows[i - 1].Cells[1].EditedFormattedValue.ToString() != "" && DG_Motion.Rows[i - 1].Cells[2].EditedFormattedValue.ToString() != "")
                {
                    x1 = Convert.ToSingle(DG_Motion.Rows[i - 1].Cells[1].EditedFormattedValue.ToString());
                    y1 = Convert.ToSingle(DG_Motion.Rows[i - 1].Cells[2].EditedFormattedValue.ToString());
                    x2 = Convert.ToSingle(DG_Motion.Rows[i].Cells[1].EditedFormattedValue.ToString());
                    y2 = Convert.ToSingle(DG_Motion.Rows[i].Cells[2].EditedFormattedValue.ToString());
                    g.DrawLine(roadPen, x1, y1, x2, y2);
                }
            }
        }

        public void DrawArc(PointF pt1, PointF pt2, PointF pt3)
        {
            if (Math_GeometryClass.GetTwoPointDistance(pt1, pt2) + Math_GeometryClass.GetTwoPointDistance(pt1, pt3) > Math_GeometryClass.GetTwoPointDistance(pt2, pt3))//首先判断三点不共线  判断方法：两边之和大于第三边
            {
            }
        }

        #region 路径图
        private void PictureBox_RoadMap_Paint(object sender, PaintEventArgs e)//重绘路径图
        {
            if (bitmap == null)
            {
                bitmap = new Bitmap(PictureBox_RoadMap.Width, PictureBox_RoadMap.Height);
            }
            if (g == null)
            {
                g = Graphics.FromImage(bitmap);
                g.SmoothingMode = SmoothingMode.AntiAlias;
            }
            g.Clear(PictureBox_RoadMap.BackColor);
            DrawGrid();
            OperationLaterExecute();
            DrawRectangle(g);
            e.Graphics.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
        }

        private void PictureBox_RoadMap_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
               
            }
            else if (e.Button == MouseButtons.Right)
            {
                Cursor = Cursors.Hand;
            }
            _mouseDownPosition = new Point(e.X, e.Y);
        }

        private void PictureBox_RoadMap_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _leftDownMovePosition = new Point(e.X, e.Y);
                _drawRectangle = true;
            }
            else if (e.Button == MouseButtons.Right)
            {

            }
            PictureBox_RoadMap.Invalidate();
            Tslb_X_Pos.Text = e.X.ToString();
            Tslb_Y_Pos.Text = e.Y.ToString();
        }

        private void PictureBox_RoadMap_MouseUp(object sender, MouseEventArgs e)//当鼠标左键松开后 判断有哪些和矩形相交
        {
            if(e.Button == MouseButtons.Left)
            {
                _drawRectangle = false;
                DG_Motion.ClearSelection();
                for (int i = 0; i < DG_Motion.Rows.Count; i++)
                {
                    if (JudgeValue(i) == false)
                    {
                        continue; //只要有一个坐标为空 或者无法尝试转换为float类型 就进入下一次循环
                    }
                    float.TryParse(DG_Motion.Rows[i].Cells[1].EditedFormattedValue.ToString(), out float x);
                    float.TryParse(DG_Motion.Rows[i].Cells[2].EditedFormattedValue.ToString(), out float y);
                    switch (DG_Motion.Rows[i].Cells[0].EditedFormattedValue.ToString())
                    {
                        case "起点":
                        case "单点":
                            RectangleF rectangle = new RectangleF(x - coordinatePointSize / 2, y - coordinatePointSize / 2, coordinatePointSize, coordinatePointSize);
                            if (QueryIsChecked(rectangle) == true)
                            {
                                DG_Motion.Rows[i].Selected = true;
                            }
                            break;
                        case "直线":
                            if (DG_Motion.Rows[i - 1].Cells[0].EditedFormattedValue.ToString() != "" && (DG_Motion.Rows[i - 1].Cells[0].EditedFormattedValue.ToString() == "起点" || DG_Motion.Rows[i - 1].Cells[0].EditedFormattedValue.ToString() == "直线") && float.TryParse(DG_Motion.Rows[i - 1].Cells[1].EditedFormattedValue.ToString(), out float x1) && float.TryParse(DG_Motion.Rows[i - 1].Cells[2].EditedFormattedValue.ToString(), out float y1))
                            {

                            }
                            else
                            {
                                RectangleF rectangle1 = new RectangleF(x - coordinatePointSize / 2, y - coordinatePointSize / 2, coordinatePointSize, coordinatePointSize);
                                if (QueryIsChecked(rectangle1) == true)
                                {
                                    DG_Motion.Rows[i].Selected = true;
                                }
                            }
                            break;
                    }
                }
            }      
            else if(e.Button == MouseButtons.Right)
            {
                Cursor = Cursors.Default;
            }
            PictureBox_RoadMap.Invalidate();
        }

        private bool JudgeValue(int i)
        {
            if (DG_Motion.Rows[i].Cells[1].EditedFormattedValue.ToString() == "" || DG_Motion.Rows[i].Cells[2].EditedFormattedValue.ToString() == "" || float.TryParse(DG_Motion.Rows[i].Cells[1].EditedFormattedValue.ToString(), out float x) == false || float.TryParse(DG_Motion.Rows[i].Cells[2].EditedFormattedValue.ToString(), out float y) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool QueryIsChecked(RectangleF rectangleF)//查询是否被选择矩形选中
        {
            GraphicsPath myPath12 = new GraphicsPath();
            myPath12.AddRectangle(rectangleF);
            Region myregion12 = new Region(myPath12);
            return myregion12.IsVisible(_currentRectangle);
        }


        public void DrawRectangle(Graphics g)// 画选择的矩形
        {
            if (_drawRectangle)
            {
                Pen myPen = new Pen(Color.LightYellow, 1)
                {
                    DashStyle = DashStyle.DashDot
                };
                if (_mouseDownPosition.X <= _leftDownMovePosition.X && _mouseDownPosition.Y >= _leftDownMovePosition.Y)//第一象限
                {
                    _currentRectangle = new Rectangle(_mouseDownPosition.X, _leftDownMovePosition.Y, Math.Abs(_leftDownMovePosition.X - _mouseDownPosition.X), Math.Abs(_leftDownMovePosition.Y - _mouseDownPosition.Y));
                }
                else if (_mouseDownPosition.X > _leftDownMovePosition.X && _mouseDownPosition.Y > _leftDownMovePosition.Y)//第二象限
                {
                    _currentRectangle = new Rectangle(_leftDownMovePosition.X, _leftDownMovePosition.Y, Math.Abs(_leftDownMovePosition.X - _mouseDownPosition.X), Math.Abs(_leftDownMovePosition.Y - _mouseDownPosition.Y));
                }
                else if (_mouseDownPosition.X > _leftDownMovePosition.X && _mouseDownPosition.Y < _leftDownMovePosition.Y)//第三象限
                {
                    _currentRectangle = new Rectangle(_leftDownMovePosition.X, _mouseDownPosition.Y, Math.Abs(_leftDownMovePosition.X - _mouseDownPosition.X), Math.Abs(_leftDownMovePosition.Y - _mouseDownPosition.Y));
                }
                else if (_mouseDownPosition.X <= _leftDownMovePosition.X && _mouseDownPosition.Y < _leftDownMovePosition.Y)//第四象限
                {
                    _currentRectangle = new Rectangle(_mouseDownPosition.X, _mouseDownPosition.Y, Math.Abs(_leftDownMovePosition.X - _mouseDownPosition.X), Math.Abs(_leftDownMovePosition.Y - _mouseDownPosition.Y));
                }
                g.DrawRectangle(myPen, _currentRectangle);
            }
        }

        private void DrawGrid()
        {
            if (StaticLocalParamClass.roadMapParamClass.ShowGrid)//显示网格
            {
                Pen gridPen = new Pen(Color.DimGray, 1)
                {
                    DashStyle = DashStyle.DashDot
                };
                for (int i = 0; i < PictureBox_RoadMap.Height; i += 25)//画横线
                {
                    g.DrawLine(gridPen, new PointF(0, i), new PointF(PictureBox_RoadMap.Width, i));
                }
                for (int i = 0; i < PictureBox_RoadMap.Width; i += 25)//画竖线
                {
                    g.DrawLine(gridPen, new PointF(i, 0), new PointF(i, PictureBox_RoadMap.Height));
                }
            }
        }

        private void Tsbtn_ShowPoint_Click(object sender, EventArgs e)//显示坐标点
        {
            if (Tsbtn_ShowPoint.Checked)
            {
                Tsbtn_ShowPoint.Checked = false;
                StaticLocalParamClass.roadMapParamClass.ShowPoint = false;
            }
            else
            {
                Tsbtn_ShowPoint.Checked = true;
                StaticLocalParamClass.roadMapParamClass.ShowPoint = true;
            }
            PictureBox_RoadMap.Invalidate();
        }

        private void Tsbtn_ShowCoordinate_Click(object sender, EventArgs e)//显示坐标轴
        {
            if (Tsbtn_ShowCoordinate.Checked)
            {
                Tsbtn_ShowCoordinate.Checked = false;
                StaticLocalParamClass.roadMapParamClass.ShowCoordinate = false;
            }
            else
            {
                Tsbtn_ShowCoordinate.Checked = true;
                StaticLocalParamClass.roadMapParamClass.ShowCoordinate = true;
            }
        }

        private void Tsbtn_SetCanvasParam_Click(object sender, EventArgs e)//设置画布参数
        {
            FrmSetRoadMapParam frmSetRoadMapParam = new FrmSetRoadMapParam(StaticLocalParamClass.roadMapParamClass);
            frmSetRoadMapParam.ClickApplyButtonEvent += FrmSetRoadMapParam_ClickApplyButtonEvent;
            frmSetRoadMapParam.ShowDialog();
            Execute();
        }

        private void FrmSetRoadMapParam_ClickApplyButtonEvent()//点击应用按钮事件
        {
            Execute();
        }

        private void Execute()
        {
            PictureBox_RoadMap.BackColor = StaticLocalParamClass.roadMapParamClass.BackColor;
            PictureBox_RoadMap.Invalidate();
        }

        private void ChangeTsbtnEnable()//改变操作表格按钮的使能状态
        {
            if (DG_Motion.SelectedRows.Count < 1)
            {
                Tssbtn_ModifPosition.Enabled = false;
                Tssbtn_Delete.Enabled = false;
                Tssbtn_Insert.Enabled = false;
                Tssbtn_Cut.Enabled = false;
                Tssbtn_Copy.Enabled = false;
                Tssbtn_Past.Enabled = false;
                Tsbtn_Up.Enabled = false;
                Tsbtn_Down.Enabled = false;
                Tssbtn_InvertOrder.Enabled = false;
                Tsmi_CheckAll.Enabled = false;
                Tsmi_InvertCheck.Enabled = false;
            }
            else
            {
                Tsmi_CheckAll.Enabled = true;
                Tsmi_InvertCheck.Enabled = true;
                Tsmi_Delete.Enabled = true;
                Tssbtn_Delete.Enabled = true;
                if (DG_Motion.SelectedRows.Count > 1)//选择的行数大于1行
                {
                    Tssbtn_Insert.Enabled = false;
                    Tsmi_Insert.Enabled = false;
                    Tssbtn_ModifPosition.Enabled = false;
                    if (DG_Motion.SelectedRows.Count == DG_Motion.Rows.GetLastRow(DataGridViewElementStates.Selected) - DG_Motion.Rows.GetFirstRow(DataGridViewElementStates.Selected) + 1)//表示选择的为连续的
                    {
                        if (DG_Motion.SelectedRows.Contains(DG_Motion.Rows[0]))//包含索引为0的行
                        {
                            Tsbtn_Up.Enabled = false;
                            Tsmi_Up.Enabled = false;
                        }
                        else { Tsbtn_Up.Enabled = true; Tsmi_Up.Enabled = true; }
                        if (DG_Motion.SelectedRows.Contains(DG_Motion.Rows[DG_Motion.RowCount - 1]))
                        {
                            Tsbtn_Down.Enabled = false;
                            Tsmi_Down.Enabled = false;
                        }
                        else { Tsbtn_Down.Enabled = true; Tsmi_Down.Enabled = true; }
                        Tssbtn_InvertOrder.Enabled = true;
                        Tssbtn_Copy.Enabled = true;
                        Tsmi_Copy.Enabled = true;
                        Tssbtn_Cut.Enabled = true;
                        Tsmi_Cut.Enabled = false;
                    }
                    else//选择的行为不连续状态
                    {
                        Tsbtn_Down.Enabled = false;
                        Tsmi_Down.Enabled = false;
                        Tsbtn_Up.Enabled = false;
                        Tsmi_Up.Enabled = false;
                        Tssbtn_InvertOrder.Enabled = false;
                        Tssbtn_Copy.Enabled = false;
                        Tsmi_Copy.Enabled = false;
                        Tssbtn_Cut.Enabled = false;
                        Tsmi_Cut.Enabled = false;
                        Tssbtn_Past.Enabled = false;
                        Tsmi_Past.Enabled = false;
                    }
                }
                else
                {
                    Tssbtn_Insert.Enabled = true;
                    Tsmi_Insert.Enabled = true;
                    Tssbtn_ModifPosition.Enabled = true;
                    Tssbtn_Copy.Enabled = true;
                    Tsmi_Copy.Enabled = true;
                    Tssbtn_Cut.Enabled = true;
                    Tsmi_Cut.Enabled = true;
                    Tssbtn_InvertOrder.Enabled = false;
                    if (DG_Motion.SelectedRows.Contains(DG_Motion.Rows[0]))//包含索引为0的行
                    {
                        Tsbtn_Up.Enabled = false;
                        Tsmi_Up.Enabled = false;
                    }
                    else { Tsbtn_Up.Enabled = true; Tsmi_Up.Enabled = true; }
                    if (DG_Motion.SelectedRows.Contains(DG_Motion.Rows[DG_Motion.RowCount - 1]))
                    {
                        Tsbtn_Down.Enabled = false;
                        Tsmi_Down.Enabled = false;
                    }
                    else { Tsbtn_Down.Enabled = true; Tsmi_Down.Enabled = true; }
                }
            }
        }

        private void Tsbtn_ShowGrid_Click(object sender, EventArgs e)
        {
            if (Tsbtn_ShowGrid.Checked)
            {
                Tsbtn_ShowGrid.Checked = false;
                StaticLocalParamClass.roadMapParamClass.ShowGrid = false;
            }
            else
            {
                Tsbtn_ShowGrid.Checked = true;
                StaticLocalParamClass.roadMapParamClass.ShowGrid = true;
            }
            PictureBox_RoadMap.Invalidate();
        }
        #endregion

        private void Cmb_SelectCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_SelectCamera.SelectedIndex >= 0)
            {
                if (Cmb_SelectCamera.SelectedIndex >= 0)
                {
                    if (CameraIDObjectDict.ContainsKey(Cmb_SelectCamera.SelectedText))
                    {
                        CameraIDObjectDict[Cmb_SelectCamera.SelectedText].ImageCallBackEvent += FrmDispenseSet_ImageCallBackEvent;
                    }
                }
            }
        }

        private void FrmDispenseSet_ImageCallBackEvent(HImage image)
        {
            UC_Image.DispImage(image);
        }

        private void Btn_SingleFrame_Click(object sender, EventArgs e)//单帧
        {
            if (Cmb_SelectCamera.SelectedIndex > -1)
            {
                if (CameraIDObjectDict.ContainsKey(Cmb_SelectCamera.SelectedText))
                {
                    CameraIDObjectDict[Cmb_SelectCamera.SelectedText].SingleFrameAcquisiton();
                }
            }
        }

        private void Btn_ContinueFrame_Click(object sender, EventArgs e)//连续
        {
            if (Cmb_SelectCamera.SelectedIndex > -1)
            {
                if (CameraIDObjectDict.ContainsKey(Cmb_SelectCamera.SelectedText))
                {
                    CameraIDObjectDict[Cmb_SelectCamera.SelectedText].ContinuousAcquisition();
                }
            }
        }

        private void Btn_ShowSet_Click(object sender, EventArgs e)//显示设置
        {
            FrmSetCrossParam frmSetCrossParam = new FrmSetCrossParam(StaticLocalParamClass.crossParamClass);
            frmSetCrossParam.ClickApplyEvent += FrmSetCrossParam_ClickApplyEvent;
            frmSetCrossParam.ShowDialog();
            ApplySet();
        }

        private void FrmSetCrossParam_ClickApplyEvent()
        {
            ApplySet();
        }

        private void ApplySet()
        {
            if (StaticLocalParamClass.crossParamClass.ShowCross)
            {
                UC_Image.Window.SetLineWidth(StaticLocalParamClass.crossParamClass.ScaleLineWidth);
                UC_Image.Window.SetColor(StaticLocalParamClass.crossParamClass.CrossColor.Name.ToLower());
                UC_Image.Window.DispCross((double)UC_Image.Height, UC_Image.Width, 500d, 0d);
            }
        }

        private void Tssbtn_Add_DropDownOpening(object sender, EventArgs e)//添加按钮的DropDown正在打开时发生
        {
            if (DG_Motion.Rows.Count == 0)
            {
                Tsmi_Add_直线.Visible = false;
                Tsmi_Add_圆弧.Visible = false;
                Tsmi_Add_矩形顺.Visible = false;
                Tsmi_Add_矩形逆.Visible = false;
                Tsmi_Add_矩形填充.Visible = false;
                Tsmi_Add_圆形填充.Visible = false;

            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            GetDG_MotionData();
            Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region 绘图工具
        private void Tsbtn_DrawStartPoint_Click(object sender, EventArgs e)//画起点
        {

        }

        private void Tsbtn_DrawSinglePoint_Click(object sender, EventArgs e)//画单点
        {

        }

        private void Tsbtn_DrawLine_Click(object sender, EventArgs e)//画直线
        {

        }

        private void Tsbtn_DrawArc_Click(object sender, EventArgs e)//画圆弧
        {

        }

        private void Tsbtn_DrawCircle_Click(object sender, EventArgs e)//画圆
        {

        }

        private void Tsbtn_DrawCWRectangle_Click(object sender, EventArgs e)//画矩形(逆)
        {

        }

        private void Tsbtn_DrawCCWRectangle_Click(object sender, EventArgs e)//画矩形(顺)
        {

        }

        private void Tsbtn_FillRectangle_Click(object sender, EventArgs e)//画填充矩形
        {
            
        }
        #endregion
    }
    public class ValueClass : IComparable
    {
        public int RowIndex { get; set; }//行索引

        public string Value { get; set; }//行索引对应的值

        public int CompareTo(object obj)
        {
            ValueClass deleteValueClass = (ValueClass)obj;
            return RowIndex.CompareTo(deleteValueClass.RowIndex);
        }
    }
}
