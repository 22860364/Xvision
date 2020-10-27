using DispenseAPP.AboutData;
using DispenseAPP.AboutMotionCard.ConfigCardClass;
using DispenseAPP.AboutMotionCard.ConfigCardClass.GTS;
using DispenseAPP.AboutMotionCard.ConfigCardClass.ZMotion;
using DispenseAPP.AboutMotionCard.ConfigMotionCard;
using DispenseAPP.CustomControl;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    public partial class FrmConfigMotionCard : FormM
    {
        private List<MCDataClass> mcDataCloneList = new List<MCDataClass>();

        private MCDataClass _currentCardData = null;

        public FrmConfigMotionCard()
        {
            InitializeComponent();
            foreach (MCDataClass item in StaticLocalParamClass.MCDataList)
            {
                mcDataCloneList.Add((MCDataClass)item.Clone());
            }
            InitialControl();
        }

        private void InitialControl()
        {
            foreach (MCDataClass item in mcDataCloneList)
            {
                Lb_MotionCard.Items.Add(item.Name);
            }
            if (mcDataCloneList.Count > 0)
            {
                Lb_MotionCard.SelectedIndex = 0;
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)//点击确定后 
        {
            StaticLocalParamClass.MCDataList.Clear();
            foreach (MCDataClass item in mcDataCloneList)
            {
                StaticLocalParamClass.MCDataList.Add((MCDataClass)item.Clone());
            }
            Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Lb_MotionCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lb_MotionCard.SelectedIndex >= 0)
            {
                Btn_Delete.Enabled = true;
                Btn_Config_Axis.Enabled = true;
                Btn_Config_Card.Enabled = true;
                Btn_Config_IO.Enabled = true;
                Btn_Config_Limit.Enabled = true;
                Btn_Save.Enabled = true;
                _currentCardData = mcDataCloneList.Find(c => c.Name == Lb_MotionCard.SelectedItem.ToString());
                Num_HomeOrder.Value = _currentCardData.HomeOrder;
            }
            else
            {
                Btn_Delete.Enabled = false;
                Btn_Config_Axis.Enabled = false;
                Btn_Config_Card.Enabled = false;
                Btn_Config_IO.Enabled = false;
                Btn_Config_Limit.Enabled = false;
                Btn_Save.Enabled = false;
            }
        }

        private void Btn_Config_Card_Click(object sender, EventArgs e)
        {
            string cardName = Lb_MotionCard.SelectedItem.ToString().Split('_')[0];
            switch (cardName)
            {
                case "ZMotion":
                    IPAddressClass iPAddressClass = _currentCardData.CardConfig as IPAddressClass;
                    FrmConfigIPAddress frmConfigZMotionCard = new FrmConfigIPAddress(ref iPAddressClass);
                    if(frmConfigZMotionCard.ShowDialog() == DialogResult.OK)
                    {
                        _currentCardData.CardConfig = iPAddressClass;
                    }
                    break;
                case "GTS":
                    FrmConfigFileAndID frmGTSCard = new FrmConfigFileAndID(_currentCardData.CardConfig as ConfigFileIDClass, "固高配置文件|*.cfg;*.CFG");
                    frmGTSCard.ShowDialog();
                    break;
                case "ADLINK":
                    FrmConfigFileAndID frmAdlinkCard = new FrmConfigFileAndID(_currentCardData.CardConfig as ConfigFileIDClass, "凌华配置文件|*.xml;*.XML");
                    frmAdlinkCard.ShowDialog();
                    break;
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (Lb_MotionCardType.SelectedIndex >= 0)
            {
                MCDataClass motionCardDataClass = new MCDataClass();
                switch (Lb_MotionCardType.SelectedItem.ToString())
                {
                    case "正运动":
                        motionCardDataClass.Name = GetName("ZMotion_");
                        break;
                    case "固高":
                        motionCardDataClass.Name = GetName("GTS_");
                        break;
                    case "凌华":
                        motionCardDataClass.Name = GetName("ADLINK_");
                        break;
                    case "研华":
                        motionCardDataClass.Name = GetName("ADVANTECH_");
                        break;
                    case "雷赛":
                        motionCardDataClass.Name = GetName("DMC_");
                        break;
                }
                motionCardDataClass.HomeOrder = Convert.ToUInt16(Num_HomeOrder.Value);
                if (motionCardDataClass.Name != null)
                {
                   int index =Lb_MotionCard.Items.Add(motionCardDataClass.Name);

                    mcDataCloneList.Add(motionCardDataClass);
                    Lb_MotionCard.SelectedIndex = index;
                }
            }
            else
            {
                MessageBox.Show("请选择运动控制卡类型！");
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Lb_MotionCard.SelectedIndex >= 0)
            {
                mcDataCloneList.Remove(_currentCardData);
                Lb_MotionCard.Items.RemoveAt(Lb_MotionCard.SelectedIndex);
            }
            else
            {
                MessageBox.Show("请选择要删除的运动控制卡！");
            }
        }

        public string GetName(string name)
        {
            string _name = null;
            for (int i = 1; i < int.MaxValue; i++)
            {
                if (!Lb_MotionCard.Items.Contains(name + i.ToString()))
                {
                    _name = name + i.ToString();
                    break;
                }
            }
            return _name;
        }

        private void Lb_MotionCardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lb_MotionCardType.SelectedIndex >= 0)
            {
                Btn_Add.Enabled = true;
            }
            else
            {
                Btn_Add.Enabled = false;
            }
        }

        private void Btn_Config_Axis_Click(object sender, EventArgs e)
        {
            FrmAxisSet frmAxisSet = new FrmAxisSet(_currentCardData.AxisConfigList);
            frmAxisSet.ShowDialog();
        }

        private void Btn_Config_IO_Click(object sender, EventArgs e)
        {
            FrmIOSet frmIOSet = new FrmIOSet(_currentCardData.DIConfigList, _currentCardData.DOConfigList, Lb_MotionCard.SelectedItem.ToString());
            frmIOSet.ShowDialog();
        }

        private void Btn_Config_Limit_Click(object sender, EventArgs e)
        {
            if (_currentCardData.AxisConfigList.Count > 0)
            {
                FrmLimitSet frmLimitSet = new FrmLimitSet(_currentCardData.LimitConfigList, _currentCardData.AxisConfigList);
                frmLimitSet.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先配置轴参数", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            _currentCardData.HomeOrder = Convert.ToUInt16(Num_HomeOrder.Value);
        }
    }
}
