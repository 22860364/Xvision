using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using static DispenseAPP.CommonClass;
using HalconDotNet;
using DispenseAPP.Tools_Location.CreateROI;

namespace DispenseAPP.Tools_Location.CalibROI
{
    public partial class Tools_CalibROI : UserControl, IEvent
    {
        private ReviseROIClass _calibROIClass;

        private Dictionary<string, PointF> pointList = new Dictionary<string, PointF>();//参考点集合

        private Dictionary<string, double> angleList = new Dictionary<string, double>();//参考角度集合

        public event ClickOKButtonDelegate _clickOKButton;

        public event ClickCancelDelegate _clickCancelButton;

        public Tools_CalibROI(ReviseROIClass calibROIClass)
        {
            InitializeComponent();
            cmb_CalibMode.SelectedItem = "水平&垂直";
            _calibROIClass = calibROIClass;
            txt_Name.Text = _calibROIClass.BlockName;
        }

        private void InitialReferenceData()//初始化引用数据
        {
            int index = _calibROIClass.SelectedNormalBlock.ToolsList.FindIndex(c => c.BlockName == _calibROIClass.BlockName);//通过当前出入的名称来判断当前的工具集合中是否包含该工具 如果包含则是编辑 如果不包含 则是创建
            if (index == -1)//代表当前是新建 
            {
                index = _calibROIClass.SelectedNormalBlock.ToolsList.Count;
            }
            for (int i = 0; i < index; i++)
            {
                ITools tools = _calibROIClass.SelectedNormalBlock.ToolsList[i];
                if (tools.GetType().IsDefined(typeof(ReferenceAngleAttribute), true) && tools.StepState)//该工具类被标记为该特性并且执行成功 如果为真，则遍历其属性，找到被标记的属性 
                {
                    foreach (PropertyInfo item in _calibROIClass.SelectedNormalBlock.ToolsList[i].GetType().GetProperties())
                    {
                        object objs = item.GetValue(tools, null);
                        if (item.IsDefined(typeof(ReferencePointAttribute)))//参考角度
                        {
                            if (objs is Array)//表示为数组
                            {
                                PointF[] pointF = objs as PointF[];
                                for (int j = 0; j < pointF.Length; j++)
                                {
                                    pointList.Add(tools.BlockName + "-" + item.Name + "[" + j + "]", pointF[j]);
                                }
                            }
                        }
                        else if (item.IsDefined(typeof(ReferenceAngleAttribute)))//参考点
                        {
                            if (objs is Array)//表示为数组
                            {
                                double[] doubleAngle = objs as double[];
                                for (int a = 0; a < doubleAngle.Length; a++)
                                {
                                    angleList.Add(tools.BlockName + "-" + item.Name + "[" + a + "]", doubleAngle[a]);
                                }
                            }
                        }
                    }
                }
            }
            foreach (KeyValuePair<string, PointF> item in pointList)
            {
                clb_Point.Items.Add(item.Key, false);
                WindowIndexDic[CurrentWindowIndex].Window.SetColor("green");
                WindowIndexDic[CurrentWindowIndex].Window.DispCross(item.Value.Y, (double)item.Value.X, 15, 0);
            }
            foreach (string item in angleList.Keys)
            {
                clb_Angle.Items.Add(item, false);
            }
        }

        private void Cmb_CalibMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_CalibMode.SelectedItem.ToString() == "水平" || cmb_CalibMode.SelectedItem.ToString() == "垂直" || cmb_CalibMode.SelectedItem.ToString() == "水平&垂直")
            {
                gb_ReferenceAngle.Enabled = false;
            }
            else
            {
                gb_ReferenceAngle.Enabled = true;
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            switch (cmb_CalibMode.SelectedItem.ToString())
            {
                case "水平":
                    if (clb_Point.CheckedItems.Count > 0)
                    {
                        _calibROIClass.ReferencePointName = clb_Point.SelectedItem.ToString();
                        _calibROIClass.ReferencePoint = pointList[clb_Point.SelectedItem.ToString()];
                    }
                    _calibROIClass.ReferenceAngle = 0;
                    _calibROIClass.ReferencePoint.Y = 0;
                    break;
                case "垂直":
                    if (clb_Point.CheckedItems.Count > 0)
                    {
                        _calibROIClass.ReferencePointName = clb_Point.SelectedItem.ToString();
                        _calibROIClass.ReferencePoint = pointList[clb_Point.SelectedItem.ToString()];
                    }
                    _calibROIClass.ReferencePoint.X = 0;
                    _calibROIClass.ReferenceAngle = 0;
                    break;
                case "水平&垂直":
                    if (clb_Point.CheckedItems.Count > 0)
                    {
                        _calibROIClass.ReferencePointName = clb_Point.SelectedItem.ToString();
                        _calibROIClass.ReferencePoint = pointList[clb_Point.SelectedItem.ToString()];
                    }
                    _calibROIClass.ReferenceAngle = 0;
                    break;
                case "水平&垂直&角度":
                    if (clb_Point.CheckedItems.Count > 0 && clb_Angle.CheckedItems.Count > 0)
                    {
                        _calibROIClass.ReferencePointName = clb_Point.SelectedItem.ToString();
                        _calibROIClass.ReferenceAngleName = clb_Angle.SelectedItem.ToString();
                        _calibROIClass.ReferencePoint = pointList[clb_Point.SelectedItem.ToString()];
                        _calibROIClass.ReferenceAngle = angleList[clb_Angle.SelectedItem.ToString()];
                    }
                    break;
                case "水平&角度":
                    if (clb_Point.CheckedItems.Count > 0 && clb_Angle.CheckedItems.Count > 0)
                    {
                        _calibROIClass.ReferencePoint = pointList[clb_Point.SelectedItem.ToString()];
                        _calibROIClass.ReferenceAngle = angleList[clb_Angle.SelectedItem.ToString()];
                        _calibROIClass.ReferencePointName = clb_Point.SelectedItem.ToString();
                        _calibROIClass.ReferenceAngleName = clb_Angle.SelectedItem.ToString();
                    }
                    _calibROIClass.ReferencePoint.Y = 0;
                    break;
                case "垂直&角度":
                    if (clb_Point.CheckedItems.Count > 0 && clb_Angle.CheckedItems.Count > 0)
                    {
                        _calibROIClass.ReferencePoint = pointList[clb_Point.SelectedItem.ToString()];
                        _calibROIClass.ReferenceAngle = angleList[clb_Angle.SelectedItem.ToString()];
                        _calibROIClass.ReferencePointName = clb_Point.SelectedItem.ToString();
                        _calibROIClass.ReferenceAngleName = clb_Angle.SelectedItem.ToString();
                    }
                    _calibROIClass.ReferencePoint.X = 0;
                    break;
            }
            _calibROIClass.ReviseMode = cmb_CalibMode.SelectedItem.ToString();
            WindowIndexDic[CurrentWindowIndex].DispImage(WindowIndexDic[CurrentWindowIndex].Image);
            _clickOKButton(_calibROIClass);
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            WindowIndexDic[CurrentWindowIndex].DispImage(WindowIndexDic[CurrentWindowIndex].Image);
            _clickCancelButton();
        }

        private void Clb_Point_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clb_Point.CheckedItems.Count > 0)
            {
                for (int i = 0; i < clb_Point.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        clb_Point.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }
            }
        }

        private void Clb_Angle_ItemCheck(object sender, ItemCheckEventArgs e)//选中状态将要更改时发生
        {
            if (clb_Angle.CheckedItems.Count > 0)
            {
                for (int i = 0; i < clb_Angle.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        clb_Angle.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }
            }
        }

        private void Clb_Point_SelectedIndexChanged(object sender, EventArgs e)
        {
            WindowIndexDic[CurrentWindowIndex].hobjectList.Clear();//清除集合中的对象
            foreach (KeyValuePair<string, PointF> item in pointList)
            {
                HXLDCont greenCross = new HXLDCont();
                greenCross.GenCrossContourXld(item.Value.Y, (double)item.Value.X, 15, 0);
                WindowIndexDic[CurrentWindowIndex].DispObject(greenCross);
            }
            HXLDCont redCross = new HXLDCont();
            redCross.GenCrossContourXld(pointList[clb_Point.SelectedItem.ToString()].Y, (double)pointList[clb_Point.SelectedItem.ToString()].X, 15, 0);
            WindowIndexDic[CurrentWindowIndex].DispObject(redCross, false, "red");
        }

        private void Tools_CalibROI_Load(object sender, EventArgs e)
        {
            WindowIndexDic[CurrentWindowIndex].DispImage(WindowIndexDic[CurrentWindowIndex].Image);
            InitialReferenceData();
        }
    }
}
