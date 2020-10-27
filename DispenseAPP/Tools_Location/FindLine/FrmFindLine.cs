using DispenseAPP.CustomControl;
using HalconDotNet;
using System;
using System.Drawing;
using VisionLibrary;
using VisionLibrary.ROI;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_Location.FindLine
{
    public partial class FrmFindLine : FormM
    {
        private FindLineClass _findLineClass;

        private LineDetection lineDetection = new LineDetection();

        private EdgePolarEnum edgePolar;//边缘极性

        private EdgeTypeEnum edgeType;//边缘类型

        private double angle;

        private HRegion _region = null;

        private bool _initial = false;

        DrawRectangle2 _drawRectangle2;
        private void cmb_EdgeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_initial == true)
            {
                switch (cmb_EdgeType.SelectedItem.ToString())
                {
                    case "第一条边缘":
                        edgeType = EdgeTypeEnum.first;
                        break;
                    case "最后一条边缘":
                        edgeType = EdgeTypeEnum.last;
                        break;
                    case "所有边缘":
                        edgeType = EdgeTypeEnum.all;
                        break;
                }
                FindLineMethod();
            }
        }

        private void cmb_EdgePolar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_initial == true)
            {
                switch (cmb_EdgePolar.SelectedItem.ToString())
                {
                    case "从白到黑":
                        edgePolar = EdgePolarEnum.negative;
                        break;
                    case "从黑到白":
                        edgePolar = EdgePolarEnum.positive;
                        break;
                    case "所有":
                        edgePolar = EdgePolarEnum.all;
                        break;
                }
                FindLineMethod();
            }          
        }

        public FrmFindLine(FindLineClass findLineClass)
        {
            InitializeComponent();
            uC_Image.StartDrawEvent += UC_Image_StartDrawEvent;
            uC_Image.DrawFinshEvent += UC_Image_DrawFinshEvent;
            _findLineClass = findLineClass;
            InitialControlDefaultValue();
            _initial = true;
        }

        private void UC_Image_DrawFinshEvent(DrawROIable rectangle2)
        {
            SetControlEnable(true);
            _drawRectangle2 = rectangle2 as DrawRectangle2;
            _region = new HRegion();
            _region.GenRectangle2(_drawRectangle2.Row, _drawRectangle2.Colulmn, _drawRectangle2.Phi, _drawRectangle2.Length1, _drawRectangle2.Length2);
            uC_Image.DispObject(_region, true, "blue");
            FindLineMethod();
        }

        private void UC_Image_StartDrawEvent()//开始画ROI事件
        {
            SetControlEnable(false);
        }

        private void SetControlEnable(bool b )//设置控件使能状态
        {
            panel_Param.Enabled = b;
            btn_OK.Enabled = b;
            btn_Cancel.Enabled =b;
        }

        private void FrmFindLine_Load(object sender, EventArgs e)
        {
            uC_Image.DispImage(WindowIndexDic[CurrentWindowIndex].Image, true);
        }

        private void InitialControlDefaultValue()//初始化控件默认值
        {
            switch(_findLineClass.EdgePolar)
            {
                case EdgePolarEnum.positive://从黑到白
                    edgePolar = EdgePolarEnum.positive;
                    cmb_EdgePolar.SelectedItem = "从黑到白";
                    break;
                case EdgePolarEnum.negative://从白到黑
                    edgePolar = EdgePolarEnum.negative;
                    cmb_EdgePolar.SelectedItem = "从白到黑";
                    break;
                case EdgePolarEnum.all:
                    edgePolar = EdgePolarEnum.all;
                    cmb_EdgePolar.SelectedItem = "所有";
                    break;
            }
            switch(_findLineClass.EdgeType)
            {
                case EdgeTypeEnum.first:
                    edgeType = EdgeTypeEnum.first;
                    cmb_EdgeType.SelectedItem = "第一条边缘";
                    break;
                case EdgeTypeEnum.last:
                    edgeType = EdgeTypeEnum.last;
                    cmb_EdgeType.SelectedItem = "最后一条边缘";
                    break;
                case EdgeTypeEnum.all:
                    edgeType = EdgeTypeEnum.all;
                    cmb_EdgeType.SelectedItem = "所有边缘";
                    break;
            }
            num_EdgeThresold.Value = _findLineClass.EdgeThreshold;//边缘强度
            num_PointNum.Value = _findLineClass.SearchPointNum;
            num_EdgeWidth.Value = _findLineClass.EdgeWidth;
            _drawRectangle2 = new DrawRectangle2(_findLineClass.Row, _findLineClass.Column, _findLineClass.Phi, _findLineClass.Length1, _findLineClass.Length2);
            if (_findLineClass.Length1 != 0 && _findLineClass.Length2 != 0 )
            {
                _region = new HRegion();
                _region.GenRectangle2(_findLineClass.Row, _findLineClass.Column, _findLineClass.Phi, _findLineClass.Length1, _findLineClass.Length2);
            }
            FindLineMethod(); 
        }

        private void FindLineMethod()
        {
            if(_region != null && _region.IsInitialized())
            {
                uC_Image.DispImage(WindowIndexDic[CurrentWindowIndex].Image, true);
                lineDetection.FindLine(uC_Image.Image, _drawRectangle2.Row, _drawRectangle2.Colulmn, _drawRectangle2.Phi, _drawRectangle2.Length1, _drawRectangle2.Length2,(ushort)num_PointNum.Value, (ushort)num_EdgeWidth.Value, (ushort)num_EdgeThresold.Value, edgePolar, edgeType, out PointF FirstPoint, out PointF EndPoint, out double angle, out HXLDCont[] cross, out HXLDCont line);
                HSystem.SetSystem("flush_graphic", "false");
                uC_Image.Window.SetDraw("margin");
                uC_Image.DispObject(_region, true, "blue");
                if (cross != null)
                {
                    foreach (HXLDCont item in cross)
                    {
                        uC_Image.DispObject(item, false, "green");
                    }
                }
                if (line != null && line.IsInitialized())
                {
                    uC_Image.DispObject(line, false, "green");                 
                }
                HSystem.SetSystem("flush_graphic", "true");
                txt_Point1X.Text = FirstPoint.X.ToString();
                txt_Point1Y.Text = FirstPoint.Y.ToString();
                txt_Point2X.Text = EndPoint.X.ToString();
                txt_Point2Y.Text = EndPoint.Y.ToString();
                txt_PointAngle.Text = angle.ToString();
            }         
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            _findLineClass.EdgePolar = edgePolar;
            _findLineClass.EdgeType = edgeType;
            _findLineClass.EdgeThreshold = Convert.ToUInt16(num_EdgeThresold.Value);
            _findLineClass.SearchPointNum = Convert.ToUInt16(num_PointNum.Value);
            _findLineClass.EdgeWidth = Convert.ToUInt16(num_EdgeWidth.Value);
            if(_region != null && _region.IsInitialized())
            {
                _findLineClass.Row = _drawRectangle2.Row;
                _findLineClass.Column = _drawRectangle2.Colulmn;
                _findLineClass.Phi = _drawRectangle2.Phi;
                _findLineClass.Length1 = _drawRectangle2.Length1;
                _findLineClass.Length2 = _drawRectangle2.Length2;
            }
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void num_EdgeThresold_ValueChanged(object sender, EventArgs e)//边缘强度发生变化
        {
            FindLineMethod();
        }

        private void num_PointNum_ValueChanged(object sender, EventArgs e)//搜索点数量发生变化
        {
            FindLineMethod();
        }

        private void num_EdgeWidth_ValueChanged(object sender, EventArgs e)//边缘宽度变化
        {
            FindLineMethod();
        }

        private void cmb_SearchDir_SelectedIndexChanged(object sender, EventArgs e)//搜索方向发生变化时重新找直线
        {
            FindLineMethod();
        }
    }
}
