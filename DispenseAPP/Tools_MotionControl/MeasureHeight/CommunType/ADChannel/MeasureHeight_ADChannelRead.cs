using DispenseAPP.Tools_MotionControl.MeasureHeight.Commun.ADChannel;
using System;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_MotionControl.MeasureHeight
{
    public partial class MeasureHeight_ADChannelRead : UserControl
    {
        public MeasureHeight_ADChannelRead()
        {
            InitializeComponent();
            InitialControl();
        }

        public ADChannelReadClass AdChannelRead { get; set; }

        private void InitialControl()//初始化控件
        {
            Cmb_SelectCard.Items.Clear();
            foreach (string item in MotionCardDict.Keys)//向控制卡的下拉框中添加卡名称
            {
                Cmb_SelectCard.Items.Add(item);
            }
            if (AdChannelRead != null)
            {
                if (AdChannelRead.SelectCard != "")//代表是编辑
                {
                    int index = Cmb_SelectCard.Items.IndexOf(AdChannelRead.SelectCard);
                    if (index != -1)//代表下拉框中有设定项
                    {
                        Cmb_SelectCard.SelectedIndex = index;
                    }
                    else
                    {
                        Cmb_SelectCard.Items.Add("???");
                        Cmb_SelectCard.SelectedIndex = Cmb_SelectCard.Items.IndexOf("???");
                    }
                }          
            }
            else
            {
                if (Cmb_SelectCard.Items.Count > 0)
                {
                    Cmb_SelectCard.SelectedIndex = 0;
                }
            }
        }

        private void Cb_LimitVoltage_CheckedChanged(object sender, EventArgs e)//限制电压的选中状态发生变化
        {
            Num_LowVoltage.Enabled = Num_HeightVoltage.Enabled = Cb_LimitVoltage.Checked;
        }
    }
}
