using System;
using HalconDotNet;
using System.Drawing;

namespace DispenseAPP.Tools_Location.CreateROI
{
    [Serializable]
    [ReviseROI]
    public class ReviseROIClass : ITools
    {
        public ReviseROIClass()
        {
            ToolsKitName = ToolsKitNameEnum.Location;
            ToolsName = ToolsNameEnum.ReviseROI;
        }

        public override void Execute(UC_Image imageWindow)
        {
            if (AnalysisReferenceAngleAndPoint("参考点", ReferencePointName) == true)//只有当寻找到了设定的参考点和参考角度时  才进行下一步
            {
                switch (ReviseMode)
                {
                    case "水平":
                        ExecuteResult = "Horizontal";
                        ReferencePoint.Y = 0;
                        ReferenceAngle = 0;
                        break;
                    case "垂直":
                        ExecuteResult = "Vertical";
                        ReferencePoint.X = 0;
                        ReferenceAngle = 0;
                        break;
                    case "水平&垂直":
                        ExecuteResult = "H&V";
                        ReferenceAngle = 0;
                        break;
                    case "水平&垂直&角度":
                        ExecuteResult = "H&V&A";
                        if (AnalysisReferenceAngleAndPoint("参考角度", ReferenceAngleName) == false)
                        {
                            SetResult();
                            return;
                        }
                        break;
                    case "水平&角度":
                        ReferencePoint.Y = 0;
                        ExecuteResult = "H&A";
                        if (AnalysisReferenceAngleAndPoint("参考角度", ReferenceAngleName) == false)
                        {
                            SetResult();
                            return;
                        }
                        break;
                    case "垂直&角度":
                        ReferencePoint.X = 0;
                        ExecuteResult = "V&A";
                        if (AnalysisReferenceAngleAndPoint("参考角度", ReferenceAngleName) == false)
                        {
                            SetResult();
                            return;
                        }
                        break;
                }
                ReviseMatrix.VectorAngleToRigid(0, 0, 0, ReferencePoint.Y, ReferencePoint.X, ReferenceAngle);//生成防射矩阵    
                ExecuteState = CommonClass.ExecuteStateEnum.OK;
                StepState = true;
            }
            else
            {
                SetResult();
            }
        }

        public void SetResult()
        {
            ReviseMatrix = null;
            ExecuteResult = "Invalid";
            StepState = false;
            ExecuteState = CommonClass.ExecuteStateEnum.NG;
        }

        private bool AnalysisReferenceAngleAndPoint(string type, string referenceName)
        {
            try
            {
                string blockName = referenceName.Split('-')[0].Trim();
                ITools tools = SelectedNormalBlock.ToolsList.Find(c => c.BlockName == blockName);
                if (tools != null)
                {
                    int index = referenceName.Split('-')[1].Trim().IndexOf('[');//查询是否有中括号
                    if (index != -1)//代表为数组
                    {
                        string propertyName = referenceName.Split('-')[1].Trim().Substring(0, index);
                        int endIndex = referenceName.Split('-')[1].Trim().IndexOf(']');
                        int arrayIndex = Convert.ToInt32(referenceName.Split('-')[1].Trim().Substring(index + 1, endIndex - index - 1));
                        object o = tools.GetType().GetProperty(propertyName).GetValue(tools);
                        if (type == "参考点")
                        {
                            PointF[] point = o as PointF[];
                            ReferencePoint = point[arrayIndex];
                        }
                        else
                        {
                            double[] douArray = o as double[];
                            ReferenceAngle = douArray[arrayIndex];
                        }
                    }
                    else//非数组
                    {
                        if (type == "参考点")
                        {
                            ReferencePoint = (PointF)tools.GetType().GetProperty(referenceName.Split('-')[1].Trim()).GetValue(tools);
                        }
                        else
                        {
                            ReferenceAngle = Convert.ToDouble(tools.GetType().GetProperty(referenceName.Split('-')[1].Trim()).GetValue(tools));
                        }
                    }
                }
                else
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string ReviseMode { get; set; }//校正模式

        public string ReferencePointName { get; set; }//参考点名称

        public string ReferenceAngleName { get; set; }//参考角度名称

        public PointF ReferencePoint;//参考点坐标

        public double ReferenceAngle;//参考点角度

        private HHomMat2D _reviseMatrix = new HHomMat2D();

        [ReviseROI]
        public HHomMat2D ReviseMatrix
        {
            get
            {
                return _reviseMatrix;
            }
            set
            {
                _reviseMatrix = value;
            }
        }
    }
}
