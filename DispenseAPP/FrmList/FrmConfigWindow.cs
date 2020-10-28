using DispenseAPP.CustomControl;
using DispenseAPP.MyStyleControl;
using System;
using VisionWindow;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.FrmList
{
    public partial class FrmConfigWindow : FormM
    {
        public FrmConfigWindow()
        {
            InitializeComponent();
            InitialControl();
        }

        private void InitialControl()
        {
            Num_ImageWindowNum.Value = StaticPublicData.SystemData.ImageWindowCount;//默认为1个图像窗口数目 
            Num_MessageWindowNum.Value = StaticPublicData.SystemData.MessageWindowCount;//默认为1个消息窗口数目
            foreach (BlockItem item in StaticPublicData.BlockItems)//遍历所有的算子
            {
                if (item is OperatorBlock)
                {
                    OperatorBlock normalBlock = item as OperatorBlock;
                    int index = DG_WindowIndex.Rows.Add();
                    DG_WindowIndex.Rows[index].Cells[0].Value = normalBlock.CustomName;
                    DG_WindowIndex.Rows[index].Cells[1].Value = normalBlock.ImageWindowIndex;
                    DG_WindowIndex.Rows[index].Cells[2].Value = normalBlock.MessageWindowIndex;
                }
            }
        }

        void Num_WindowNum_ValueChanged(object sender, EventArgs e)//当窗口数目发生变化时 要重新设置DG_WindowIndex中的下拉框Item
        {
            Col_ImageWindow.Items.Clear();
            Col_ImageWindow.Items.Add("不显示");
            for (int i = 0; i < Num_ImageWindowNum.Value; i++)
            {
                Col_ImageWindow.Items.Add(i.ToString());
            }
        }

        void Num_MessageWindowNum_ValueChanged(object sender, EventArgs e)
        {
            Col_MessageWindow.Items.Clear();
            Col_MessageWindow.Items.Add("不显示");
            for (int i = 0; i < Num_MessageWindowNum.Value; i++)
            {
                Col_MessageWindow.Items.Add(i.ToString());
            }
        }

        void Btn_OK_Click(object sender, EventArgs e)//点击确定按钮后要重新调整界面的窗体布局
        {
            for (int i = 0; i < DG_WindowIndex.Rows.Count; i++)
            {
                foreach (BlockItem item in StaticPublicData.BlockItems)
                {
                    if (item is OperatorBlock && item.CustomName == DG_WindowIndex.Rows[i].Cells[0].EditedFormattedValue.ToString())
                    {
                        OperatorBlock normalBlock = item as OperatorBlock;
                        normalBlock.ImageWindowIndex = DG_WindowIndex.Rows[i].Cells[1].EditedFormattedValue.ToString();
                        normalBlock.MessageWindowIndex = DG_WindowIndex.Rows[i].Cells[2].EditedFormattedValue.ToString();
                        break;
                    }
                }
            }
            //对键值对中多余的进行删除
            for (int i = 1; i < ImageWindowIndexDic.Count; i++)
            {
                ImageWindowIndexDic.Remove(i);//必须留一个窗口哦
            }
            for (int i = 1; i < Num_ImageWindowNum.Value; i++)
            {
                if(!ImageWindowIndexDic.ContainsKey(i))
                {
                    UC_MyWindow uc_Image = new UC_MyWindow();
                    ImageWindowIndexDic.Add(i, uc_Image);
                }
            }
            for (int i = 1; i < MessageWindowIndexDic.Count; i++)
            {
                MessageWindowIndexDic.Remove(i);//必须留一个窗口哦
            }
            for (int i = 1; i < Num_MessageWindowNum.Value; i++)
            {
                if(MessageWindowIndexDic.ContainsKey(i))
                {
                    DgvDisplayMessage uc_Image = new DgvDisplayMessage();
                    MessageWindowIndexDic.Add(i, uc_Image);
                }
            }
            StaticPublicData.SystemData.ImageWindowCount = (int)Num_ImageWindowNum.Value;
            StaticPublicData.SystemData.MessageWindowCount = (int)Num_MessageWindowNum.Value;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
