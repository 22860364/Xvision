using DispenseAPP.CustomControl;
using System;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.FrmList
{
    public partial class FrmConfigWindow : FormM
    {
        private ProjectParamClass _projectParam;

        public FrmConfigWindow(ProjectParamClass projectParam)
        {
            InitializeComponent();
            _projectParam = projectParam;
            InitialControl();
        }

        private void InitialControl()
        {
            num_WindowNum.Value = _projectParam.windowCount;//窗口数目
            foreach (Element item in _projectParam._flowChartList)//遍历所有的算子
            {
                if (item is NormalBlock)
                {
                    NormalBlock normalBlock = item as NormalBlock;
                    int index = DG_WindowIndex.Rows.Add();
                    DG_WindowIndex.Rows[index].Cells[0].Value = normalBlock.Name;
                    DG_WindowIndex.Rows[index].Cells[1].Value = normalBlock.WindowIndex;              
                }
            }
        }

        public event ClickOKDelegate _clickOkButton;

        private void Num_WindowNum_ValueChanged(object sender, EventArgs e)//当窗口数目发生变化时  要重新设置DG_WindowIndex中的下拉框Item
        {
            ColIndex.Items.Clear();
            ColIndex.Items.Add("不显示");
            for (int i = 1; i <= num_WindowNum.Value; i++)
            {
                ColIndex.Items.Add(i.ToString());
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)//点击确定按钮后要重新调整Run界面的窗体布局
        {
            for (int i = 0; i < DG_WindowIndex.Rows.Count; i++)
            {
                string name = DG_WindowIndex.Rows[i].Cells[0].Value.ToString();
                foreach (Element item in _projectParam._flowChartList)
                {
                    if (item is NormalBlock && item.Name == name)
                    {
                        NormalBlock normalBlock = item as NormalBlock;
                        normalBlock.WindowIndex = DG_WindowIndex.Rows[i].Cells[1].Value.ToString();
                        break;
                    }
                }
            }
            for (int i = 1; i <= WindowIndexDic.Count; i++)
            {
                WindowIndexDic.Remove(i+1);//必须留一个窗口哦
            }
            for (int i = 1; i < num_WindowNum.Value; i++)
            {             
                UC_Image uc_Image = new UC_Image();
                WindowIndexDic.Add(i+1, uc_Image);
            }
            _projectParam.windowCount = (int)num_WindowNum.Value;
            _clickOkButton();
            Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
