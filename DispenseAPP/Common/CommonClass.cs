using System.Collections.Generic;
using DispenseAPP.AboutData;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing;
using CameraLibrary;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using VisionWindow;
using System.IO;
using System.Text;
using System;
using DispenseAPP.UserManagement;
using DispenseAPP.MyStyleControl;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.Xml.Serialization;

namespace DispenseAPP
{
    public enum ToolsKitNameEnum : int
    {
        ImageIO = 0,
        Location = 1,
        Measure = 2,
        Other = 3,
        Barcode = 4,
        Commun = 5,
        MotionControl = 6,
        Enhancement = 7,
    }

    public enum Language
    {
        English,
        Chinese,
    }

    public enum NameType
    {
        SystemName,
        CustomName,
    }

    /// <summary>
    /// 算子块类型
    /// </summary>
    public enum LineBlockType
    {
        StartBlock,
        EndBlock,
    }

    /// <summary>
    /// 箭头类型
    /// </summary>
    public enum LineArrowType
    {
        StartArrow,
        EndArrow,
    }

    /// <summary>
    /// 当前界面
    /// </summary>
    public enum CurrentFrmEnum
    {
        FrmEdit,
        FrmWorkFlow,
    }

    /// <summary>
    /// Mark点类型
    /// </summary>
    public enum MarkTypeEnum
    {
        无Mark点,
        双Mark点,
        双Mark点多次拍多个产品,
        单Mark点一次只拍一个产品,
        单Mark点多次拍多个产品,
        单Mark点一次拍多个产品_小范围,
        单Mark点一次拍多个产品_中范围,
        单Mark点一次拍多个产品_大范围,
    }

    public static class CommonClass
    {
        /// <summary>
        /// 是否在运行状态
        /// </summary>
        public static bool IsRunState = false;

        /// <summary>
        /// 平台数量
        /// </summary>
        public static ushort PlatformCount = 2;

        /// <summary>
        /// 存储相机对象的键值对集合  键：相机厂商：相机序列号 值：相机对象
        /// </summary>
        public static Dictionary<string, ICamerable> CameraIDObjectDict = new Dictionary<string, ICamerable>();


        /// <summary>
        /// 存储串口名称和串口对象的键值对集合
        /// </summary>
        public static Dictionary<string, SerialPort> SerialDict = new Dictionary<string, SerialPort>();

        /// <summary>
        /// 本地参数路径
        /// </summary>
        public static string LocalDataPath = Application.StartupPath + "\\LocalData\\";

        /// <summary>
        /// 项目参数路径
        /// </summary>
        public static string ProjectDataPath = Application.StartupPath + "\\Files\\";

        /// <summary>
        /// 相机的标定文件路径
        /// </summary>
        public static string CalibFilePath = Application.StartupPath + "\\项目文件\\CCDConfing.ini";

        /// <summary>
        /// 项目文件的扩展名
        /// </summary>
        public static string ProjectFileExtension = ".xml";

        /// <summary>
        /// 静态公共参数
        /// </summary>
        public static PublicData StaticPublicData;

        /// <summary>
        /// 静态用户参数
        /// </summary>
        public static UserParamClass StaticUserParamClass;

        /// <summary>
        /// 点胶命令
        /// </summary>
        public static List<string> DispenseCommandList = new List<string>() { "起点", "直线", "单点", "圆弧", "圆弧终点", "整圆终点", "矩形填充", "圆形填充" };

        /// <summary>
        /// 轨迹命令
        /// </summary>
        public static List<string> TrackCommandList = new List<string>() { "直线", "圆弧", "圆弧", "圆弧终点", "整圆终点", "矩形填充", "圆形填充" };

        /// <summary>
        /// 搜索对象 搜索范围 屏蔽范围的区域种类
        /// </summary>
        public static List<string> RegionTypes = new List<string>() { "矩形", "旋转矩形", "圆", "椭圆" };

        /// <summary>
        /// 存储图像窗口索引和图像窗口对象
        /// </summary>
        public static Dictionary<int, UC_MyWindow> ImageWindowIndexDic = new Dictionary<int, UC_MyWindow>();

        /// <summary>
        /// 存储消息窗口索引和消息窗口对象
        /// </summary>
        public static Dictionary<int, DgvDisplayMessage> MessageWindowIndexDic = new Dictionary<int, DgvDisplayMessage>();

        public static string LogPath = Application.StartupPath + "\\Log\\" + DateTime.Now.Year.ToString() + "\\" + DateTime.Now.Month.ToString().PadLeft(2).Replace(" ", "0") + "MONTH" + "\\" + DateTime.Now.Day.ToString().PadLeft(2).Replace(" ", "0") + "DAY.txt";//日志文件每个月一个文件夹  每天一个文件

        /// <summary>
        /// 是否过期
        /// </summary>
        public static bool isExpried = false;

        /// <summary>
        /// 当前方案是否已经更改
        /// </summary>
        public static bool ProjectIsChange { get; set; }

        public enum SignalTypeEnum : short
        {
            DI,
            DO,
        }

        /// <summary>
        /// 坐标系类型枚举
        /// </summary>
        public enum CoordinateType
        {
            X,
            XY,
            XYZ,
            XYZR,
            XYZR1R2,
        }

        /// <summary>
        ///阵列类型枚举
        /// </summary>
        public enum ArrayTypeEnum
        {
            /// <summary>
            /// 内部阵列
            /// </summary>
            InSideArray,
            /// <summary>
            /// 外部阵列
            /// </summary>
            OutSideArray,
        }

        public enum CommunModeEnum
        {
            AD通道,
            串口,
        }

        /// <summary>
        /// 选择的数据行
        /// </summary>
        public enum SelectDataLineEnum
        {
            AllLine,
            SelectLine,
        }

        /// <summary>
        /// 用户类型枚举
        /// </summary>
        public enum UserTypeEnum
        {
            操作员,
            管理员,
            程序员,
            未登录
        }

        /// <summary>
        /// 当前用户类型
        /// </summary>
        public static UserTypeEnum CurrentUserType = UserTypeEnum.未登录;

        /// <summary>
        /// 当前登录的用户对象
        /// </summary>
        public static User CurrentUser;

        /// <summary>
        /// 比较两个数组
        /// </summary>
        /// <typeparam name="T">数组类型</typeparam>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public static bool CompareArray<T>(T[] array1, T[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i].Equals(array2[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 获得本机的IP地址
        /// </summary>
        /// <returns></returns>
        public static List<string> GetLocalIPAddress()
        {
            List<string> ipAddressList = new List<string>();
            NetworkInterface[] NetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();//获得本地计算机上网络接口的对象
            foreach (NetworkInterface NetworkIntf in NetworkInterfaces)
            {
                IPInterfaceProperties IPInterfaceProperties = NetworkIntf.GetIPProperties();
                UnicastIPAddressInformationCollection UnicastIPAddressInformationCollection = IPInterfaceProperties.UnicastAddresses;
                foreach (UnicastIPAddressInformation UnicastIPAddressInformation in UnicastIPAddressInformationCollection)
                {
                    if (UnicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        ipAddressList.Add(UnicastIPAddressInformation.Address.ToString());
                    }
                }
            }
            return ipAddressList;
        }

        /// <summary>
        /// 根据前缀和已存在的数据集获得自定义名称
        /// </summary>
        /// <param name="nameList">已存在的数据集</param>
        /// <param name="prefix">前缀</param>
        /// <returns>自定义名称</returns>
        public static string GetCustomName(List<string> nameList, string prefix)
        {
            int index = 1;
            for (int i = 0; i < int.MaxValue; i++)
            {
                if (!nameList.Contains(prefix + i.ToString()))
                {
                    index = i;
                    break;
                }
            }
            return prefix + index.ToString();
        }

        /// <summary>
        /// 获得系统的自动名称
        /// </summary>
        /// <param name="prefix">名称前缀</param>
        /// <param name="nameList">已存在的名称的集合</param>
        /// <returns></returns>
        public static void GetCustomName(string prefix, List<string> nameList, out string name)
        {
            int index = 1;
            for (int i = 0; i < int.MaxValue; i++)
            {
                if (!nameList.Contains(prefix + i.ToString().PadLeft(0, '3')))
                {
                    index = i;
                    break;
                }
            }
            name = prefix + index.ToString().PadLeft(0, '3');
        }

        /// <summary>
        /// 获得Block名称
        /// </summary>
        /// <param name="prefix">前缀</param>
        public static string GetBlockCustomName(string prefix)
        {
            int index = 1;
            for (int i = 1; i < int.MaxValue; i++)
            {
                if (StaticPublicData.BlockItems.FindIndex(c => c.CustomName == prefix + i.ToString()) == -1)
                {
                    index = i;
                    break;
                }
            }
            return prefix + index.ToString();
        }

        public static string GetBlockSystemName(string prefix)
        {
            int index = 1;
            for (int i = 1; i < int.MaxValue; i++)
            {
                if (StaticPublicData.BlockItems.FindIndex(c => c.SystemName == prefix + i.ToString().PadLeft(3, '0')) == -1)
                {
                    index = i;
                    break;
                }
            }
            return prefix + index.ToString().PadLeft(3, '0');
        }

        public static string GetRubbleValveSystemName(List<string> rubbleValveParams)
        {
            int index = 1;
            for (int i = 1; i < int.MaxValue; i++)
            {
                if (rubbleValveParams.FindIndex(c => c == "V" + i.ToString().PadLeft(3, '0')) == -1)
                {
                    index = i;
                    break;
                }
            }
            return "V" + index.ToString().PadLeft(3, '0');
        }

        public static void ExecuteToToolStripInsertOrAddToolStripItem(ToolStripItem item, string name, ToolStrip ts_Station, MouseEventHandler mouseEventHandler)
        {
            ToolStripLabel tsLable = new ToolStripLabel
            {
                Text = name,
                DoubleClickEnabled = true,
                DisplayStyle = ToolStripItemDisplayStyle.Text,
                ForeColor = Color.Green,
                Font = new Font("微软雅黑", 8f, FontStyle.Bold, GraphicsUnit.Point, 134),
            };
            tsLable.MouseDown += mouseEventHandler;
            ToolStripSeparator tsSeparator = new ToolStripSeparator();
            if (item == null)
            {
                ts_Station.Items.Add(tsLable);
                ts_Station.Items.Add(tsSeparator);
            }
            else
            {
                ts_Station.Items.Insert(ts_Station.Items.IndexOf(item), tsLable);
                ts_Station.Items.Insert(ts_Station.Items.IndexOf(item), tsSeparator);
            }
        }

        public static void SetToolstripLableForeColor(ToolStrip toolStrip, Color color)//设置ToolStripLable颜色
        {
            foreach (ToolStripItem item in toolStrip.Items)
            {
                if (item is ToolStripLabel)
                {
                    item.ForeColor = color;
                }
            }
        }

        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="Message"></param>
        public static void WriteLog(string Message)
        {
            if (!Directory.Exists(Path.GetDirectoryName(LogPath))) Directory.CreateDirectory(Path.GetDirectoryName(LogPath));
            StreamWriter sw = new StreamWriter(LogPath, true, Encoding.Default);
            sw.WriteLine(Message);
            sw.Flush();
            sw.Close();
            sw.Dispose();
        }

        public static string GetToolName(string name, OperatorBlock normalBlock)
        {
            string _name = null;
            for (int i = 1; i < int.MaxValue; i++)
            {
                if (normalBlock.ToolList.Find(c => c.StepCustomName == name + i.ToString()) == null)
                {
                    _name = name + i.ToString();
                    break;
                }
            }
            return _name;
        }

        public static void GetNormalBlock(string blockName, out OperatorBlock normalBlock)//通过算子名获得普通算子块对象
        {
            normalBlock = null;
            if (StaticPublicData.BlockItems[NameType.CustomName, blockName] is OperatorBlock normalBlock1)
            {
                normalBlock = normalBlock1;
            }
        }

        public static IToolable FindTools(string blockName, string toolsName)
        {
            IToolable tools = null;
            if (StaticPublicData.BlockItems[NameType.CustomName, blockName] is OperatorBlock normalBlock && normalBlock != null)
            {
                tools = normalBlock.ToolList.Find(c => c.StepCustomName == toolsName);
            }
            return tools;
        }

        /// <summary>
        /// 保存本地参数
        /// </summary>
        public static void SavePublicData()
        {
            SerializerToXML(LocalDataPath + "CameraData.xml", StaticPublicData.CameraDataItems);
            SerializerToXML(LocalDataPath + "SystemData.xml", StaticPublicData.SystemData);
            SerializerToXML(LocalDataPath + "SystemSetData.xml", StaticPublicData.SystemSetData);
            SerializerToXML(LocalDataPath + "BlockData.xml", StaticPublicData.BlockItems);
            SerializerToXML(LocalDataPath + "LineData.xml", StaticPublicData.LineItems);
            SerializerToBinary(LocalDataPath + "VarsData.sec", StaticPublicData.VariableData);
        }

        public static string GetNewFileName(string filePath)//当将一个文件复制到一个文件夹下 获得所要复制到新文件夹的名称
        {
            string directory = Path.GetDirectoryName(filePath);//获得文件所在路径
            string fileName = Path.GetFileNameWithoutExtension(filePath);//文件名
            string extension = Path.GetExtension(filePath);
            string newFileName = string.Format("{0}{1}", fileName, extension);//文件名+后缀
            string newFullPath = Path.Combine(directory, newFileName);
            int counter = 1;
            while (File.Exists(newFullPath))
            {
                newFileName = string.Format("{0}-{1}{2}", fileName, counter, extension);
                newFullPath = Path.Combine(directory, newFileName);
                counter++;
            }
            return newFullPath;
        }

        public static void SetNormalEnableOrDisable(string startBlock, string endBlock, bool isDisable)//设置普通算子块的启用或禁用 可以一次性设置多个算子块 只需输入起始和结束算子块  如果遇到单条件算子块 默认走[1]箭头分支 该方法的起始算子块和终止算子块都必须为普通算子块
        {
            if (!(StaticPublicData.BlockItems[NameType.CustomName, startBlock] is OperatorBlock startNormalBlock))
            {
                return;
            }
            if (!(StaticPublicData.BlockItems[NameType.CustomName, endBlock] is OperatorBlock endNormalBlock))
            {
                return;
            }
            OperatorBlock normalBlock = startNormalBlock;
            while (true)
            {
                foreach (IToolable item in normalBlock.ToolList)
                {
                    item.Disable = isDisable;//是否禁用
                }
                if (normalBlock.Equals(endNormalBlock))
                {
                    break;
                }
                BlockItem _element = StaticPublicData.LineItems[LineBlockType.StartBlock, normalBlock].EndBlock;
                if (_element is OperatorBlock _normalBlock)
                {
                    normalBlock = _normalBlock;
                }
                else if (_element is IfBlock ifElseBlock)
                {
                    normalBlock = ifElseBlock.ArrowList[1].ConnectBlock as OperatorBlock;
                }
            }
        }

        public static bool FindStartBlockChartLine(OperatorBlock normalBlock, out LineItem chartLine)
        {
            chartLine = StaticPublicData.LineItems[LineBlockType.StartBlock, normalBlock];
            return chartLine == null ? false : true;
        }

        /// <summary>
        /// 加载项目数据
        /// </summary>
        /// <param name="path"></param>
        public static void LoadProjectData(string path)
        {
            foreach (BlockItem item in StaticPublicData.BlockItems)//遍历算子块集合
            {
                if (item is OperatorBlock operatorBlock && operatorBlock.CustomName.Contains("点胶"))
                {
                    operatorBlock.ToolList.Clear();//清除该普通算子块中的所有工具
                }
            }
        }

        public static void Draw_DGV_LineNumber(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;//执行强制转换
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgv.RowHeadersWidth - 4, e.RowBounds.Height);//先获取要画行号的矩形
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgv.RowHeadersDefaultCellStyle.Font, rectangle, dgv.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        public static void SetComboBoxToMyStyle(ComboBox[] comboBoxs)
        {
            foreach (ComboBox item in comboBoxs)
            {
                item.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
                item.Visible = false;
                item.DropDownStyle = ComboBoxStyle.DropDownList;
                item.FlatStyle = FlatStyle.Popup;
            }
        }

        public static void SetNumericUpDownToMyStyle(NumericUpDown numericUpDown, int places, decimal max, decimal min)
        {
            numericUpDown.Font = new Font("微软雅黑", 10.3F, FontStyle.Regular, GraphicsUnit.Point, 134);
            numericUpDown.Visible = false;
            numericUpDown.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown.DecimalPlaces = places;
            numericUpDown.Maximum = max;
            numericUpDown.Minimum = min;
            numericUpDown.AutoSize = false;
        }

        /// <summary>
        /// 判断一个字符串是否是合法IP
        /// </summary>
        /// <param name="text">传入的文本</param>
        /// <returns>true 是 false 不是</returns>
        public static bool IsLegalIP(string text)
        {
            return IPAddress.TryParse(text, out IPAddress iPAddress);
        }

        /// <summary>
        /// 查找工具栏中的第一个ToolStripLable的文本
        /// </summary>
        /// <returns>查找到的ToolStripLable的Text</returns>
        public static string FindFirstToolStripLableText(ToolStrip toolStrip, out ToolStripLabel _toolStripLabel)
        {
            _toolStripLabel = null;
            foreach (ToolStripItem item in toolStrip.Items)
            {
                if (item is ToolStripLabel toolStripLabel)
                {
                    _toolStripLabel = toolStripLabel;
                    return item.Text;
                }
            }
            return null;
        }

        /// <summary>
        /// XML序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="t"></param>
        public static void SerializerToXML<T>(string path, T t) where T : class
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");
                XmlSerializer xs = new XmlSerializer(typeof(T));
                xs.Serialize(fs, t, ns);
                fs.Flush();
                fs.Close();
                fs.Dispose();
            }

        }

        /// <summary>
        /// 二进制序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="t"></param>
        public static void SerializerToBinary<T>(string path, T t) where T : class
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, t);
                fs.Flush();
                fs.Close();
                fs.Dispose();
            }
        }

        /// <summary>
        /// XML反序列化 如果该文件不存在 则创建该类型的实例然后返回
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="path">文件路径</param>
        /// <returns></returns>
        public static T DeserializerToXML1<T>(string path) where T : class
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(T));
                    return xs.Deserialize(sr) as T;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// XML反序列化 如果该文件不存在 则返回null
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="path">文件路径</param>
        /// <returns></returns>
        public static T DeserializerToXML<T>(string path) where T : class
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(T));
                    return xs.Deserialize(sr) as T;
                }
            }
            else
            {
                return typeof(T).Assembly.CreateInstance(typeof(T).FullName) as T;
            }
        }

        /// <summary>
        /// 二进制反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="t"></param>
        public static void DeserializerToBinary<T>(string path, ref T t) where T : class
        {
            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    t = binaryFormatter.Deserialize(fs) as T;
                    fs.Flush();
                    fs.Close();
                    fs.Dispose();
                }
            }
        }

        /// <summary>
        /// 执行二进制克隆
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static T ExecuteClone<T>(T t) where T : class
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, t);
            stream.Position = 0;
            return formatter.Deserialize(stream) as T;
        }

        /// <summary>
        /// 设置CheckedListBox的AllItem的状态
        /// </summary>
        /// <param name="checkedListBox">具体的CheckedListBox</param>
        /// <param name="state">状态</param>
        public static void SetCheckedListBoxAllState(CheckedListBox checkedListBox, bool state)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, state);
            }
        }


        /// <summary>
        /// 检查表格的错误状态 如果有错误 则无法点击确定按钮
        /// </summary>
        public static bool CheckErrorState(DataGridView dgv)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    if (!string.IsNullOrWhiteSpace(dgv.Rows[i].Cells[j].ErrorText))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 检查下拉框当前的Text是否是问号 检查的前提是当前下拉框的索引 >= 0
        /// </summary>
        /// <param name="comboBoxes">检查的下拉框数组</param>
        /// <returns>true 表示文本为问号 false 表示当前文本不为问号</returns>
        public static bool CheckComboBoxContainsQuestion(ComboBox[] comboBoxes)
        {
            foreach (ComboBox item in comboBoxes)
            {
                if (item.Text == "???")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
