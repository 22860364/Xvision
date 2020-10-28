using DispenseAPP.AboutData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_MotionControl.MeasureHeight
{
    public partial class Tools_MeasureHeight : UserControl,IEvent 
    {
        private MeasureHeight_ADChannelRead ADChannelRead = new MeasureHeight_ADChannelRead();
        private MeasureHeightClass _measureHeightClass;
        public event ClickOKButtonDelegate _clickOKButton;
        public event ClickCancelDelegate _clickCancelButton;

        public Tools_MeasureHeight(MeasureHeightClass measureHeightClass)
        {
            InitializeComponent();
            _measureHeightClass = measureHeightClass;
            InitialControl();
        }

        private void InitialControl()
        {
            Panel_CommunParam.Controls.Add(ADChannelRead);
            ADChannelRead.Visible = false;
            ADChannelRead.Dock = DockStyle.Top;
            txt_Name.Text = _measureHeightClass.BlockName;
            Cmb_CalibMode.SelectedIndex = Cmb_CalibMode.Items.IndexOf(_measureHeightClass.CalibMode);
            Num_DelayTime.Value = _measureHeightClass.DelayTime;
            Num_AllowDeviation.Value = (decimal)_measureHeightClass.AllowDeviation;
            Num_DeformationRadius.Value = _measureHeightClass.DeformationRadius;
            #region 运动控制卡
            foreach (string item in MotionCardDict.Keys)
            {
                Cmb_SelectCard.Items.Add(item);
            }
            if(_measureHeightClass.SelectCard != "")//编辑状态
            {
                int index = Cmb_SelectCard.Items.IndexOf(_measureHeightClass.SelectCard);
                if(index !=-1)
                {
                    Cmb_SelectCard.SelectedIndex = index;
                }
                else
                {
                    Cmb_SelectCard.Items.Add("???");
                    Cmb_SelectCard.SelectedIndex = Cmb_SelectCard.Items.IndexOf("???");
                }
            }
            else
            {
                if(Cmb_SelectCard.Items.Count >0)
                {
                    Cmb_SelectCard.SelectedIndex = 0;
                }
            }
            #endregion
            #region 轴
            if(_measureHeightClass.SelecectAxisArray != null)//编辑状态
            {
                for (int i = 0; i < _measureHeightClass.SelecectAxisArray.Length; i++)
                {
                    string value = _measureHeightClass.SelecectAxisArray[i];
                    int index = Cmb_AxisX.Items.IndexOf(value);
                    switch (i)
                    {
                        case 0:
                            if (index != -1)
                            {
                                Cmb_AxisX.SelectedIndex = Cmb_AxisX.Items.IndexOf(value);
                            }
                            else
                            {
                                Cmb_AxisX.Items.Add("???");
                                Cmb_AxisX.SelectedIndex = Cmb_AxisX.Items.IndexOf("???");
                            }
                            break;
                        case 1:
                            if (index != -1)
                            {
                                Cmb_AxisY.SelectedIndex = Cmb_AxisY.Items.IndexOf(value);
                            }
                            else
                            {
                                Cmb_AxisY.Items.Add("???");
                                Cmb_AxisY.SelectedIndex = Cmb_AxisY.Items.IndexOf("???");
                            }
                            break;
                        case 2:
                            if (index != -1)
                            {
                                Cmb_AxisZ.SelectedIndex = Cmb_AxisZ.Items.IndexOf(value);
                            }
                            else
                            {
                                Cmb_AxisZ.Items.Add("???");
                                Cmb_AxisZ.SelectedIndex = Cmb_AxisZ.Items.IndexOf("???");
                            }
                            break;
                    }
                }
            }
            else
            {
                if(Cmb_AxisX.Items.Count >0)
                {
                    Cmb_AxisX.SelectedIndex = 0;
                }
                if (Cmb_AxisY.Items.Count > 1)
                {
                    Cmb_AxisY.SelectedIndex = 1;
                }
                if (Cmb_AxisZ.Items.Count > 2)
                {
                    Cmb_AxisZ.SelectedIndex = 2;
                }
            }
            #endregion
            Cmb_CommunMode.SelectedIndex = Cmb_CommunMode.Items.IndexOf(_measureHeightClass.CommunMode);
            Num_InitialDigits.Value = _measureHeightClass.InitialDigits;
            Num_ExtractCharNum.Value = _measureHeightClass.ExtractCharNum;
            Num_DecimalPlaces.Value = _measureHeightClass.DecimalPlaces;
            Num_SamplingPeriod.Value = _measureHeightClass.SamplingPeriod;
            Cmb_ReadMode.SelectedIndex = Cmb_ReadMode.Items.IndexOf(_measureHeightClass.ReadMode);
        }

        private void Cmb_CommunMode_SelectedIndexChanged(object sender, EventArgs e)//通信方式的索引发生变化
        {
            switch(Cmb_CommunMode.Text)
            {
                case "AD通道":
                    ADChannelRead.Visible = true;
                    break;
                case "串口":
                    break;
            }       
        }

        private void Btn_OK_Click(object sender, EventArgs e)//需要加判断
        {
            _measureHeightClass.BlockName = txt_Name.Text;
            _measureHeightClass.CalibMode = Cmb_CalibMode.Text;
            _measureHeightClass.DelayTime =(ushort)Num_DelayTime.Value;
            _measureHeightClass.AllowDeviation = (float)Num_AllowDeviation.Value;
            _measureHeightClass.DeformationRadius =(ushort)Num_DeformationRadius.Value;
            _measureHeightClass.SelectCard = Cmb_SelectCard.Text;
            _measureHeightClass.SelecectAxisArray = new string[] { Cmb_AxisX.Text, Cmb_AxisY.Text, Cmb_AxisZ.Text };
            _clickOKButton(_measureHeightClass);
            _measureHeightClass.CommunMode = Cmb_CommunMode.Text;
            _measureHeightClass.InitialDigits = (ushort)Num_InitialDigits.Value;
            _measureHeightClass.ExtractCharNum = (ushort)Num_ExtractCharNum.Value;
            _measureHeightClass.DecimalPlaces = (ushort)Num_DecimalPlaces.Value;
            _measureHeightClass.SamplingPeriod = (ushort)Num_SamplingPeriod.Value;
            _measureHeightClass.ReadMode = Cmb_ReadMode.Text;

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            _clickCancelButton();
        }

        private void Btn_Set_Click(object sender, EventArgs e)
        {
            if (Cmb_SelectCard.SelectedIndex < 0)
            {
                MessageBox.Show("请选择运动控制卡！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            if (MotionCardDict[Cmb_SelectCard.Text].CardConnectState == false)
            {
                MessageBox.Show("选择的运动控制卡连接失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            if (Cmb_AxisX.SelectedIndex < 0 && Cmb_AxisY.SelectedIndex < 0 && Cmb_AxisZ.SelectedIndex < 0)
            {
                MessageBox.Show("必须选择对应的轴！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            List<string> strList = new List<string>
            {
                Cmb_AxisX.Text,
                Cmb_AxisY.Text,
                Cmb_AxisZ.Text,
            };
            if (strList.GroupBy(i => i).Where(g => g.Count() > 1).Count() > 0)
            {
                MessageBox.Show("不可以用重复轴！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            FrmMeasureHeightSet frmMeasureHeightSet = new FrmMeasureHeightSet(Cmb_SelectCard.SelectedText,strList.ToArray());
            frmMeasureHeightSet.ShowDialog();
        }

        private void Cmb_SelectCard_SelectedIndexChanged(object sender, EventArgs e)//当控制卡的索引发生变化
        {
            MCDataClass mCDataClassList = StaticLocalParamClass.MCDataList.Find(c => c.Name == Cmb_SelectCard.Text);//根据卡名称获得对应的卡对象
            if (mCDataClassList != null)//找到了卡对应的轴List
            {
                List<string> axisList = new List<string>();
                foreach (ConfigAxis item in mCDataClassList.AxisConfigList)
                {
                    axisList.Add(item.AxisName);
                }
                Cmb_AxisX.Items.Clear();
                Cmb_AxisY.Items.Clear();
                Cmb_AxisZ.Items.Clear();
                Cmb_AxisX.Items.AddRange(axisList.ToArray());
                Cmb_AxisY.Items.AddRange(axisList.ToArray());
                Cmb_AxisZ.Items.AddRange(axisList.ToArray());
            }
        }
    }
}
