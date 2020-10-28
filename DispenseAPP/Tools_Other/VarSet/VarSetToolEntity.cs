using DispenseAPP.OtherTools.VariableSetTools;
using System;
using System.Collections.Generic;
using System.Drawing;
using DispenseAPP.AboutData;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_Other.VarSet
{
    [Serializable]
    public class VarSetToolEntity : IToolable
    {
        public List<SetVarClass> setVarList = new List<SetVarClass>();

        public VarSetToolEntity()
        {
        }

        public override ToolsKitNameEnum ToolKitName => ToolsKitNameEnum.Other;

        public override string ToolName => "变量设置";

        public override void Execute()//执行
        {
            try
            {
                foreach (SetVarClass item in setVarList)
                {
                    int startIndex, endIndex;
                    string[] str = null;
                    string varName = item.VarName;
                    switch (item.ExecuteOper)
                    {
                        case ExecuteOperationEnum.SetMeasurement:
                            break;
                        case ExecuteOperationEnum.SetInitialValue:
                            StaticPublicData.VariableData.SetVarInitialValue(item.VarName);
                            break;
                        case ExecuteOperationEnum.SetConstant:
                            switch (item.Type)
                            {
                                case "N":
                                    StaticPublicData.VariableData.SetValue(item.VarName, Convert.ToDecimal(item.Operation.Split(' ')[2]));
                                    break;
                                case "S":
                                    StaticPublicData.VariableData.SetValue(item.VarName, item.Operation.Split(' ')[2]);
                                    break;
                                case "B":
                                    StaticPublicData.VariableData.SetValue(item.VarName, Convert.ToBoolean(item.Operation.Split(' ')[2].ToLower()));
                                    break;
                                case "P":
                                    startIndex = item.Operation.IndexOf('(');//获取左括号的位置
                                    endIndex = item.Operation.IndexOf(')');//获取右括号的位置
                                    float x = Convert.ToSingle(item.Operation.Substring(startIndex + 1, endIndex - startIndex - 1).Split(',')[0]);
                                    float y = Convert.ToSingle(item.Operation.Substring(startIndex + 1, endIndex - startIndex - 1).Split(',')[1]);
                                    StaticPublicData.VariableData.SetValue(item.VarName, new PointF(x, y));
                                    break;
                                case "N[]": //数组待验证
                                    startIndex = item.Operation.IndexOf('{');//获取左括号的位置
                                    endIndex = item.Operation.IndexOf('}');//获取右括号的位置
                                    str = item.Operation.Substring(startIndex + 1, endIndex - startIndex - 1).Split(',');
                                    StaticPublicData.VariableData.varName.Clear();
                                    for (int i = 0; i < str.Length; i++)
                                    {
                                        StaticPublicData.VariableData.varName.Add(Convert.ToDecimal(str[i]));
                                    }
                                    break;
                                case "S[]":
                                    startIndex = item.Operation.IndexOf('{');//获取左括号的位置
                                    endIndex = item.Operation.IndexOf('}');//获取右括号的位置
                                    str = item.Operation.Substring(startIndex + 1, endIndex - startIndex - 1).Split(',');
                                    for (int i = 0; i < str.Length; i++)
                                    {
                                        StaticPublicData.VariableData.varName.Add(str[i]);
                                    }
                                    break;
                                case "B[]":
                                    startIndex = item.Operation.IndexOf('{');//获取左括号的位置
                                    endIndex = item.Operation.IndexOf('}');//获取右括号的位置
                                    str = item.Operation.Substring(startIndex + 1, endIndex - startIndex - 1).Split(',');
                                    for (int i = 0; i < str.Length; i++)
                                    {
                                        StaticPublicData.VariableData.varName.Add(Convert.ToBoolean(str[i]));
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
                                        string s = item.Operation.Substring(startArr[i] + 1, endArr[i] - startArr[i] - 1);
                                        float px = Convert.ToSingle(s.Split(',')[0]);
                                        float py = Convert.ToSingle(s.Split(',')[1]);
                                        StaticPublicData.VariableData.varName.Add(new PointF(px, py));
                                    }
                                    break;
                            }
                            break;
                        case ExecuteOperationEnum.Invalid:
                            break;
                        case ExecuteOperationEnum.Increment:
                            VarCollectionClass var2 = StaticPublicData.VariableData.GetVarClass(item.VarName);
                            if (var2 != null)
                            {
                                decimal value = Convert.ToDecimal(var2.VarValue);
                                value++;
                                var2.VarValue = value;
                            }
                            break;
                        case ExecuteOperationEnum.Decrement:
                            VarCollectionClass var1 = StaticPublicData.VariableData.GetVarClass(item.VarName);
                            if (var1 != null)
                            {
                                decimal value = Convert.ToDecimal(var1.VarValue);
                                value--;
                                var1.VarValue = value;
                            }
                            break;
                    }
                }
                SetOK("执行成功！");
            }
            catch (Exception ex)
            {
                SetNG("执行失败：" + ex.Message);
            }
        }

        public override bool RunAgoCheck()
        {
            ErrorList.Clear();
            return ErrorList.Count == 0;
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
