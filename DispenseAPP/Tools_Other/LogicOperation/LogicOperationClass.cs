using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using static DispenseAPP.CommonClass;
using DispenseAPP.AboutData;

namespace DispenseAPP.Tools_Other.LogicOperation
{
    [Serializable]
    public class LogicOperationClass : ITools
    {
        public LogicOperationClass()
        {
            ToolsKitName = ToolsKitNameEnum.Other;
            ToolsName = ToolsNameEnum.LogicOperation;
        }
        public override void Execute(UC_Image imageWindow)
        {
            try
            {
                object o = AnalysisExpress(Expression).ToString();//执行逻辑运算 如果这一步失败 那么逻辑结果为Invalid 
                LogicResult = o.ToString();
            }
            catch
            {
                ExecuteState = ExecuteStateEnum.NG;
                StepState = false;
                LogicResult = "Invalid";
            }
            ExecuteState = ExecuteStateEnum.OK;
            StepState = true;
            ExecuteResult = LogicResult;
        }

        [ConditionJudge]
        public string LogicResult { get; set; }

        public object AnalysisExpress(string express)//解析表达式
        {
            List<int> leftList = AnalysisDataClass.GetCharAllIndex(express, '{');//左中括号集合
            List<int> rightList = AnalysisDataClass.GetCharAllIndex(express, '}');//右中括号结合 
            List<string> propertyList = new List<string>();//形参列表
            List<object> valueList = new List<object>();//实参列表     
            string newExpress = null;
            for (int i = 0; i < leftList.Count; i++)//通过遍历获得形参和实参
            {
                string name = express.Substring(leftList[i] + 1, rightList[i] - leftList[i] - 1);//获得中括号中的内容
                if (i == 0)
                {
                    newExpress = express;
                }
                string blockName = name.Split('.')[0];//获得算子名
                string propertyName = null;
                string propertyType = null;
                if (name.Contains('['))//如果包含 [ 则代表该数据为数组类型
                {
                    string str = name.Split('.')[1];
                    propertyName = str.Substring(0, str.IndexOf('['));
                    int arrayIndex = Convert.ToInt32(str.Substring(str.IndexOf('[') + 1, (str.IndexOf(']') - str.IndexOf('[') - 1)));
                    PropertyInfo propertyInfo = SelectedNormalBlock.ToolsList.Find(d => d.BlockName == blockName).GetType().GetProperty(propertyName);
                    if (propertyInfo.PropertyType.Name == "Double[]")
                    {
                        propertyType = "System.Double";
                        valueList.Add(propertyInfo.GetValue(SelectedNormalBlock.ToolsList.Find(c => c.BlockName == blockName)));
                    }
                    else if (propertyInfo.PropertyType.Name == "PointF[]")
                    {
                        propertyType = "System.Single";
                        object o = propertyInfo.GetValue(SelectedNormalBlock.ToolsList.Find(c => c.BlockName == blockName));
                        System.Drawing.PointF[] point = o as System.Drawing.PointF[];
                        if (name.Substring(name.LastIndexOf('.') + 1) == "X")
                        {
                            valueList.Add(point[arrayIndex].X);
                        }
                        else if (name.Substring(name.LastIndexOf('.') + 1) == "Y")
                        {
                            valueList.Add(point[arrayIndex].Y);
                        }
                    }
                }
                else//为普通类型
                {
                    propertyName = name.Split('.')[1];//获得属性名
                    PropertyInfo proInfo = SelectedNormalBlock.ToolsList.Find(c => c.BlockName == blockName).GetType().GetProperty(propertyName);
                    propertyType = proInfo.PropertyType.ToString();//得到参数的类型
                    valueList.Add(proInfo.GetValue(SelectedNormalBlock.ToolsList.Find(c => c.BlockName == blockName)));
                }
                propertyList.Add(propertyType + " " + blockName + "_" + propertyName);
                newExpress = newExpress.Replace("{" + name + "}", blockName + "_" + propertyName);
            }
            string formatParam = null;
            for (int i = 0; i < propertyList.Count; i++)
            {
                if (i == propertyList.Count - 1)
                {
                    formatParam += propertyList[i];
                }
                else
                {
                    formatParam += propertyList[i] + ",";
                }
            }
            string code = @"public class TestComputer 
           { 
             public static object Computer (" + formatParam + ") { return @exp;}}";
            code = code.Replace("@exp", newExpress);
            CSharpCodeProvider cshapeCodeprovider = new CSharpCodeProvider();//提供对C#代码生成器和编译器的访问       
            CompilerParameters compilerParameters = new CompilerParameters();//编译器参数
            compilerParameters.GenerateExecutable = false;//是否生成可执行文件
            compilerParameters.GenerateInMemory = true;//在内存中生成输出
            //compilerParameters.ReferencedAssemblies.Add("System.dll");
            //compilerParameters.ReferencedAssemblies.Add("System.Core.dll");
            //compilerParameters.ReferencedAssemblies.Add("System.Drawing.dll");
            CompilerResults compilerResult = cshapeCodeprovider.CompileAssemblyFromSource(compilerParameters, code);
            if (compilerResult.Errors.Count > 0)//没有错误
            {
                string errorMessage = null;
                for (int i = 0; i < compilerResult.Errors.Count; i++)
                {
                    if (i == compilerResult.Errors.Count - 1)
                    {
                        errorMessage += "错误[" + i.ToString() + "]:" + compilerResult.Errors[i].ErrorText;
                    }
                    else
                    {
                        errorMessage += "错误[" + i.ToString() + "]:" + compilerResult.Errors[i].ErrorText + Environment.NewLine;
                    }
                }
                return errorMessage;
            }
            else //没有错误则执行
            {
                Assembly assembly = compilerResult.CompiledAssembly;//获取已编译的程序集
                Type type = assembly.GetType("TestComputer");
                return type.GetMethod("Computer").Invoke(null, valueList.ToArray());
            }
        }

        public string Expression { get; set; }
    }
}
