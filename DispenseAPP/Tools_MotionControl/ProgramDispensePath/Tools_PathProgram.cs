using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DispenseAPP.AboutData;
using DispenseAPP.AboutMotionCard;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_MotionControl.ProgrammingDispensePath
{
    public partial class Tools_PathProgramming : UserControl, IEvent
    {
        private PathProgramClass _dispensePathProgramClass;
        public event ClickOKButtonDelegate _clickOKButton;
        public event ClickCancelDelegate _clickCancelButton;

        public Tools_PathProgramming(PathProgramClass dispensePathProgramClass)
        {
            InitializeComponent();
            _dispensePathProgramClass = dispensePathProgramClass;
            txt_Name.Text = dispensePathProgramClass.BlockName;
            InitialControl();
        }

        private void InitialControl()//将控件中添加数据
        {
            #region 运动控制卡
            foreach (MCDataClass item in StaticLocalParamClass.MCDataList)
            {
                Cmb_SelectCard.Items.Add(item.Name);//添加卡名称
            }
            if (_dispensePathProgramClass.SelectCardName == "")//如果是编辑状态 则需要选择对应的卡名称
            {
                Cmb_SelectCard.SelectedIndex = 0;
            }
            else
            {
                if (Cmb_SelectCard.Items.Contains(_dispensePathProgramClass.SelectCardName))
                {
                    Cmb_SelectCard.SelectedIndex = Cmb_SelectCard.Items.IndexOf(_dispensePathProgramClass.SelectCardName);
                }
                else
                {
                    Cmb_SelectCard.Items.Add("???");
                    Cmb_SelectCard.SelectedIndex = Cmb_SelectCard.Items.IndexOf("???");
                }
            }
            #endregion
            #region 轴
            if (_dispensePathProgramClass.SelectAxisArray != null)//轴数组不为空
            {
                for (int i = 0; i < _dispensePathProgramClass.SelectAxisArray.Length; i++)
                {
                    string value = _dispensePathProgramClass.SelectAxisArray[i];
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
                if(Cmb_AxisY.Items.Count >1)
                {
                    Cmb_AxisY.SelectedIndex = 1;
                }
                if(Cmb_AxisZ.Items.Count >2)
                {
                    Cmb_AxisZ.SelectedIndex = 2;
                }
            }
            #endregion
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            _clickOKButton(_dispensePathProgramClass);
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
            if(strList.GroupBy(i=>i).Where(g=>g.Count()>1).Count()>0)
            {
                MessageBox.Show("不可以用重复轴！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            FrmDispenseSet frmDispenseSet = new FrmDispenseSet(_dispensePathProgramClass.DispensePathList, strList.ToArray(), Cmb_SelectCard.Text);
            frmDispenseSet.ShowDialog();
        }

        private void Cmb_SelectCard_SelectedIndexChanged(object sender, EventArgs e)//当卡的下拉框的索引发生变化时
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
