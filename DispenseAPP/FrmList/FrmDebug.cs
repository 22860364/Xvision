using System;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    public partial class FrmDebug : Form
    {
        public FrmDebug()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            ChangeLayout();
        }

        public void ChangeLayout()//设置布局
        {
            for (int i = 0; i < StaticPublicData.SystemData.ImageWindowCount; i++)//添加图像窗口
            {
                if (!ImageWindowIndexDic.ContainsKey(i))
                {
                    ImageWindowIndexDic.Add(i, new VisionWindow.UC_MyWindow());
                }
            }
            for (int i = 0; i < StaticPublicData.SystemData.MessageWindowCount; i++)
            {
                if (!MessageWindowIndexDic.ContainsKey(i))
                {
                    MessageWindowIndexDic.Add(i, new MyStyleControl.DgvDisplayMessage());
                }
            }
            SetPanelLayout(Panel_Image, StaticPublicData.SystemData.ImageWindowCount);
            SetPanelLayout(Panel_Message, StaticPublicData.SystemData.MessageWindowCount);
            AddImageWindow();
            AddMessageWindow();
        }

        void SetPanelLayout(TableLayoutPanel tableLayoutPanel,int count)//设置图像控件和消息控件的布局
        {
            tableLayoutPanel.ColumnStyles.Clear();
            tableLayoutPanel.RowStyles.Clear();
            tableLayoutPanel.Controls.Clear();
            ComputerPanelLayoutRowColCount(count, out int rowCount, out int colCount);
            tableLayoutPanel.RowCount = rowCount;
            tableLayoutPanel.ColumnCount = colCount;//设置行数和列数
            for (int i = 0; i < tableLayoutPanel.ColumnCount; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Convert.ToSingle((100f / colCount))));
            }
            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                tableLayoutPanel.RowStyles.Add(new ColumnStyle(SizeType.Percent, Convert.ToSingle((100f / rowCount))));
            }

        }

        void AddImageWindow()//添加图像窗口
        {
            int times = 0;
            for (int i = 0; i < Panel_Image.RowCount; i++)//遍历行
            {
                for (int j = 0; j < Panel_Image.ColumnCount; j++)//遍历列
                {
                    if (ImageWindowIndexDic.ContainsKey(times))
                    {
                        ImageWindowIndexDic[times].Dock = DockStyle.None;
                        ImageWindowIndexDic[times].Dock = DockStyle.Fill;
                        Panel_Image.Controls.Add(ImageWindowIndexDic[times], j, i);
                    }
                    times++;
                }
            }
        }

        void AddMessageWindow()//添加消息窗口
        {
            int times = 0;
            for (int i = 0; i < Panel_Message.RowCount; i++)//遍历行
            {
                for (int j = 0; j < Panel_Message.ColumnCount; j++)//遍历列
                {
                    if (MessageWindowIndexDic.ContainsKey(times))
                    {
                        MessageWindowIndexDic[times].Dock = DockStyle.None;
                        MessageWindowIndexDic[times].Dock = DockStyle.Fill;
                        Panel_Message.Controls.Add(MessageWindowIndexDic[times], j, i);
                    }
                    times++;
                }
            }
        }

        void ComputerPanelLayoutRowColCount(int windowCount, out int rowCount, out int colCount)//计算布局
        {
            rowCount = 0;
            colCount = 0;
            for (int i = 1; i < 5; i++)//遍历行
            {
                for (int j = 1; j < 5; j++)//遍历列
                {
                    if (i * j >= windowCount)
                    {
                        if (Math.Abs(i - j) > 1)
                        {
                            break;
                        }
                        rowCount = i;
                        colCount = j;
                        return;
                    }
                }
            }
        }
    }
}
