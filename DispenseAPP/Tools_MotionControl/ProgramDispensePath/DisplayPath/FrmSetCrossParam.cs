using DispenseAPP.CustomControl;
using System;
using System.Windows.Forms;

namespace DispenseAPP.Tools_Location.ProgramDispensePath.DisplayImagePath
{
    public partial class FrmSetCrossParam : FormM
    {
        public event Action ClickApplyEvent; //点击应用按钮
        private CrossParamClass _crossParamClass;

        public FrmSetCrossParam(CrossParamClass crossParamClass)
        {
            InitializeComponent();
            _crossParamClass = crossParamClass;
            SetControl();
        }

        private void SetControl()
        {
            Cb_ShowCross.Checked = _crossParamClass.ShowCross;
            Lbl_Color.BackColor = _crossParamClass.CrossColor;
            Num_LineScaleNum.Value = _crossParamClass.LineScaleNumber;
            Num_CircleScaleNum.Value = _crossParamClass.CircleScaleNumber;
            Num_ScaleGap.Value = (decimal)_crossParamClass.ScaleGap;
            Num_ScaleLineWidth.Value = (decimal)_crossParamClass.ScaleLineWidth;
        }

        private void SetValue()
        {
            _crossParamClass.ShowCross = Cb_ShowCross.Checked;
            _crossParamClass.CrossColor = Lbl_Color.BackColor;
            _crossParamClass.LineScaleNumber = (ushort)Num_LineScaleNum.Value;
            _crossParamClass.CircleScaleNumber = (ushort)Num_CircleScaleNum.Value;
            _crossParamClass.ScaleGap = (float)Num_ScaleGap.Value;
            _crossParamClass.ScaleLineWidth = (float)Num_ScaleLineWidth.Value;
        }

        private void Lbl_Color_Click(object sender, EventArgs e)//单击颜色标签 弹出选择颜色对话框
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                Lbl_Color.BackColor = colorDialog.Color;
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            SetValue();
            Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Apply_Click(object sender, EventArgs e)
        {
            SetValue();
            ClickApplyEvent?.Invoke();
        }
    }  
}
