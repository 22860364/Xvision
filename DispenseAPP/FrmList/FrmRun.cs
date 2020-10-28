using System;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    public partial class FrmRun : Form
    {
        private ProjectParamClass _projectparam;
        public FrmRun(ProjectParamClass projectParam)
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); //禁止擦除背景
            SetStyle(ControlStyles.DoubleBuffer, true); //双缓冲     
            _projectparam = projectParam;
            for (int i = 0; i < _projectparam.windowCount; i++)
            {
                if(!WindowIndexDic.ContainsKey(i+1))
                {
                    UC_Image uc_Image = new UC_Image();
                    WindowIndexDic.Add(i + 1, uc_Image);
                }
            }
        }

        public void SetPanelLayout()
        {
            TLPanel_Window.ColumnStyles.Clear();
            TLPanel_Window.RowStyles.Clear();
            TLPanel_Window.Controls.Clear();
            ComputerPanelLayoutRowColCount(_projectparam.windowCount, out int rowCount, out int colCount);
            TLPanel_Window.RowCount = rowCount;
            TLPanel_Window.ColumnCount = colCount;//设置行数和列数
            for (int i = 0; i < TLPanel_Window.ColumnCount; i++)
            {
                TLPanel_Window.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Convert.ToSingle((100f / colCount))));
            }
            for (int i = 0; i < TLPanel_Window.RowCount; i++)
            {
                TLPanel_Window.RowStyles.Add(new ColumnStyle(SizeType.Percent, Convert.ToSingle((100f / rowCount))));
            }
            int times = 0;
            for (int i = 0; i < TLPanel_Window.RowCount; i++)//遍历行
            {
                for (int j = 0; j < TLPanel_Window.ColumnCount; j++)//遍历列
                {
                    times++;
                    if (WindowIndexDic.ContainsKey(times))
                    {
                        WindowIndexDic[times].Dock = DockStyle.None;
                        WindowIndexDic[times].Dock = DockStyle.Fill;
                        TLPanel_Window.Controls.Add(WindowIndexDic[times], j, i);            
                    }
                }
            }
        }

        private void ComputerPanelLayoutRowColCount(int windowCount, out int rowCount, out int colCount)//计算布局
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
