using DispenseAPP.AboutData;
using DispenseAPP.接口;
using System;
using System.Drawing;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    public partial class UC_AxisPositionState : UserControl
    {
        public string CardName;//卡名称
        private int CurrentRowIndex { get; set; }//当前行索引
        ConfigAxis configAxis = null;
        public string AxisName { get; set; }

        public UC_AxisPositionState()
        {
            InitializeComponent();
        }

        public void InitialDG_Position(string cardName, string[] axisNameArray)//初始化坐标表格
        {
            CardName = cardName;
            DG_Position.RowCount = axisNameArray.Length;
            for (int i = 0; i < axisNameArray.Length; i++)
            {
                DG_Position.Rows[i].Cells[0].Value = axisNameArray[i];
                if(i == 0)
                {
                    AxisName = DG_Position.Rows[0].Cells[0].EditedFormattedValue.ToString();
                    DG_Position.CurrentCell = DG_Position[0, 0];
                    configAxis = StaticLocalParamClass.MCDataList.Find(c => c.Name == CardName).AxisConfigList.Find(c => c.AxisName == AxisName);
                }
            }
            if (CardName != null && MotionCardDict.ContainsKey(CardName) && MotionCardDict[CardName].CardConnectState == true)//只有连接成功 才可以点击运动 否则为只读列
            {
                Timer_Read.Start();
            }
        }

        public float GetAxisPosition(string axisName)//获得轴位置
        {
            if(MotionCardDict[CardName].AxisStateList != null)
            {
                AxisStateClass axisStateClass = MotionCardDict[CardName].AxisStateList.Find(c => c.AxisName == axisName);
                if(axisStateClass != null)
                {
                    return axisStateClass.AxisPosition;
                }
            }
            return 0f;
        }

        private void Timer_Read_Tick(object sender, EventArgs e)//定时器执行的事件
        {
            foreach (DataGridViewRow item in DG_Position.Rows)
            {
                AxisStateClass axisState = MotionCardDict[CardName].AxisStateList.Find(c => c.AxisName == item.Cells[0].Value.ToString());
                item.Cells[1].Value = axisState.AxisPosition;
                item.Cells[2].Value = axisState.PEl;
                item.Cells[3].Value = axisState.ORG;
                item.Cells[4].Value = axisState.MEL;
                item.Cells[5].Value = axisState.Alarm;
            }
        }
        
        private void DG_Position_MouseDown(object sender, MouseEventArgs e)//鼠标在组件上方并按下时发生
        {
            CurrentRowIndex = DG_Position.HitTest(e.X, e.Y).RowIndex;       
            if(CurrentRowIndex >= 0)
            {
                AxisName = DG_Position.Rows[CurrentRowIndex].Cells[0].EditedFormattedValue.ToString();//获得轴名称
                configAxis = StaticLocalParamClass.MCDataList.Find(c => c.Name == CardName).AxisConfigList.Find(c => c.AxisName == AxisName);
                if (configAxis.PosIcon != null && configAxis.PosIcon != "" && configAxis.NegIcon != null && configAxis.NegIcon != "")
                {
                    Btn_Pos.Image = new Bitmap(configAxis.PosIcon);
                    Btn_Neg.Image = new Bitmap(configAxis.NegIcon);
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                if(CurrentRowIndex >= 0)
                {                    
                    foreach (ToolStripItem item in CM_Operation.Items)
                    {
                        item.Enabled = true;
                    }
                }
                else
                {
                    foreach (ToolStripItem item in CM_Operation.Items)
                    {
                        item.Enabled = false;
                    }
                }
                CM_Operation.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void Tsmi_SetPosIcon_Click(object sender, EventArgs e)//设置正方向图标
        {
            string icon = ""; //指向同一个地址
            if (SetIcon(ref icon) == true)//触发事件
            {
                StaticLocalParamClass.MCDataList.Find(c => c.Name == CardName).AxisConfigList.Find(b => b.AxisName == AxisName).PosIcon = icon;
                Btn_Pos.Image = new Bitmap(configAxis.PosIcon);
            }
        }

        private bool SetIcon(ref string icon)
        {         
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "选择图标",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "图像文件（*.png）|*.png",
                InitialDirectory = Application.StartupPath + "\\ArrowIcon\\"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                icon  = openFileDialog.FileName;
                return true;
            }
            return false;
        }

        private void Tsmi_SetNegIcon_Click(object sender, EventArgs e)//设置负方向图标
        {
            string icon = "";
            if (SetIcon(ref icon) == true)
            {
                StaticLocalParamClass.MCDataList.Find(c => c.Name == CardName).AxisConfigList.Find(b => b.AxisName == AxisName).NegIcon = icon;
                Btn_Neg.Image = new Bitmap(configAxis.NegIcon);
            }
        }

        private void Rbtn_Continue_CheckedChanged(object sender, EventArgs e)
        {
            Lbl_Distance.Visible = false;
            Num_Distance.Visible = false;
        }

        private void Rbtn_FixedLength_CheckedChanged(object sender, EventArgs e)
        {
            Lbl_Distance.Visible = true;
            Num_Distance.Visible = true;
        }

        private void Btn_Pos_MouseDown(object sender, MouseEventArgs e)//正方向按下
        {
            if (Rbtn_Continue.Checked)
            {
                if (!MotionCardDict[CardName].JOG(configAxis.AxisID, (float)Num_Speed.Value, configAxis.AccDec, configAxis.AccDec, JOGMotionDir.Positive, out string error))
                {
                    MessageBox.Show(error, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            else if (Rbtn_FixedLength.Checked)
            {
                if (!MotionCardDict[CardName].PTP(configAxis.AxisID, (float)Num_Speed.Value, configAxis.AccDec, configAxis.AccDec, MotionMode.Relaitve, (float)Num_Distance.Value, out string error))
                {
                    MessageBox.Show(error, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void Btn_Pos_MouseUp(object sender, MouseEventArgs e)//正方向弹起
        {
            if (Rbtn_Continue.Checked)
            {
                MotionCardDict[CardName].StopMotion(configAxis.AxisID, out string error);
            }
        }

        private void Btn_Neg_MouseDown(object sender, MouseEventArgs e)//负方向按下
        {
            if (Rbtn_Continue.Checked)
            {
                if (!MotionCardDict[CardName].JOG(configAxis.AxisID, (float)Num_Speed.Value, configAxis.AccDec, configAxis.AccDec, JOGMotionDir.Negative, out string error))
                {
                    MessageBox.Show(error, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            else if (Rbtn_FixedLength.Checked)
            {
                if (!MotionCardDict[CardName].PTP(configAxis.AxisID, (float)Num_Speed.Value, configAxis.AccDec, configAxis.AccDec, MotionMode.Relaitve, (float)-Num_Distance.Value, out string error))
                {
                    MessageBox.Show(error, "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void Btn_Neg_MouseUp(object sender, MouseEventArgs e)//负方向弹起
        {
            if (Rbtn_Continue.Checked)
            {
                MotionCardDict[CardName].StopMotion(configAxis.AxisID, out string error);
            }
        }
    }
}
