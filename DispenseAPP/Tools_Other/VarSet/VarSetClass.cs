using DispenseAPP.OtherTools.VariableSetTools;
using System;
using System.Collections.Generic;
using System.Drawing;
using DispenseAPP.AboutData;

namespace DispenseAPP.Tools_Other.VarSet
{
    [Serializable]
    public class VarSetClass : ITools
    {
        public dynamic Vars { get; set; }

        public List<SetVarClass> setVarList = new List<SetVarClass>();

        public VarSetClass()
        {
            ExecuteResult = "None";
            ExecuteState = CommonClass.ExecuteStateEnum.OK;
            ToolsName = ToolsNameEnum.VarSet;
            ToolsKitName = ToolsKitNameEnum.Other;
        }

        public override void Execute(UC_Image imageWindow)//执行
        {
            foreach (SetVarClass item in setVarList)
            {
                int startIndex, endIndex;
                string[] str = null;
                switch (item.ExecuteOper)
                {
                    case ExecuteOperationEnum.SetMeasurement:
                        Vars.GetVarClass(item.VarName).VarValue = item.Operation.Split(' ')[2];//这里还需要将之前得到的值传入
                        break;
                    case ExecuteOperationEnum.SetInitialValue:
                        Vars.SetVarInitialValue(item.VarName);
                        break;
                    case ExecuteOperationEnum.SetConstant:
                        switch (item.Type)
                        {
                            case "N":
                                Vars.GetVarClass(item.VarName).VarValue = Convert.ToDecimal(item.Operation.Split(' ')[2]);
                                break;
                            case "S":
                                Vars.GetVarClass(item.VarName).VarValue = item.Operation.Split(' ')[2];
                                break;
                            case "B":
                                Vars.GetVarClass(item.VarName).VarValue = Convert.ToBoolean(item.Operation.Split(' ')[2]);
                                break;
                            case "P":
                                startIndex = item.Operation.IndexOf('(');//获取左括号的位置
                                endIndex = item.Operation.IndexOf(')');//获取右括号的位置
                                float x = Convert.ToSingle(item.Operation.Substring(startIndex + 1, endIndex - startIndex - 1).Split(',')[0]);
                                float y = Convert.ToSingle(item.Operation.Substring(startIndex + 1, endIndex - startIndex - 1).Split(',')[1]);
                                Vars.GetVarClass(item.VarName).VarValue = new PointF(x, y);
                                break;
                            case "N[]":
                                startIndex = item.Operation.IndexOf('{');//获取左括号的位置
                                endIndex = item.Operation.IndexOf('}');//获取右括号的位置
                                str = item.Operation.Substring(startIndex + 1, endIndex - startIndex - 1).Split(',');
                                for (int i = 0; i < str.Length; i++)
                                {
                                    Vars.GetVarClass(item.VarName).VarValue.Add(Convert.ToDecimal(str[i]));
                                }
                                break;
                            case "S[]":
                                startIndex = item.Operation.IndexOf('{');//获取左括号的位置
                                endIndex = item.Operation.IndexOf('}');//获取右括号的位置
                                str = item.Operation.Substring(startIndex + 1, endIndex - startIndex - 1).Split(',');
                                for (int i = 0; i < str.Length; i++)
                                {
                                    Vars.GetVarClass(item.VarName).VarValue.Add(str[i]);
                                }
                                break;
                            case "B[]":
                                startIndex = item.Operation.IndexOf('{');//获取左括号的位置
                                endIndex = item.Operation.IndexOf('}');//获取右括号的位置
                                str = item.Operation.Substring(startIndex + 1, endIndex - startIndex - 1).Split(',');
                                for (int i = 0; i < str.Length; i++)
                                {
                                    Vars.GetVarClass(item.VarName).VarValue.Add(Convert.ToBoolean(str[i]));
                                }
                                break;
                            case "P[]":
                                startIndex = item.Operation.IndexOf('[');
                                endIndex = item.Operation.IndexOf(']');
                                int count = Convert.ToInt32(item.Operation.Substring(startIndex + 1, endIndex - startIndex - 1));
                                int[] startArr = AnalysisDataClass.GetCharAllIndex(item.Operation, '(').ToArray();
                                int[] endArr = AnalysisDataClass.GetCharAllIndex(item.Operation, ')').ToArray();
                                for (int i = 0; i < count; i++)
                                {
                                    string s = item.Operation.Substring(startArr[i] + 1, endArr[i] -startArr[i] - 1);
                                    float px = Convert.ToSingle(s.Split(',')[0]);
                                    float py = Convert.ToSingle(s.Split(',')[1]);
                                    Vars.GetVarClass(item.VarName).VarValue.Add(new PointF(px, py));
                                }
                                break;
                        }

                        break;
                    case ExecuteOperationEnum.Invalid:
                        break;
                    case ExecuteOperationEnum.Increment:
                        Vars.GetVarClass(item.VarName).VarValue++;
                        break;
                    case ExecuteOperationEnum.Decrement:
                        Vars.GetVarClass(item.VarName).VarValue--;
                        break;
                }
            }
        }
    }

    [Serializable]
    public class SetVarClass
    {
        public string Type { get; set; }

        public string VarName { get; set; }

        public string Operation { get; set; }

        public ExecuteOperationEnum ExecuteOper { get; set; }
    }
}
