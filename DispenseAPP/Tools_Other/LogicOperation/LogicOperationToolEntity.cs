using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using static DispenseAPP.CommonClass;
using DispenseAPP.AboutData;
using System.Xml.Serialization;

namespace DispenseAPP.Tools_Other.LogicOperation
{
    [Serializable]
    public class LogicOperationToolEntity : IToolable
    {
        public LogicOperationToolEntity()
        {
        }

        public override ToolsKitNameEnum ToolKitName => ToolsKitNameEnum.Other;

        public override string ToolName => "逻辑运算";

        public override void Execute()//执行这个方法1000 需要7000ms
        {
            List<object> valueList = AnalysisExpress(Expression, out string code);//首先获得解析完成的类
            if (executor == null)
            {
                if (!GetResult(valueList, code, out object message))
                {
                    SetNG("表达式编译错误！");
                }
            }
            LogicResult = executor.Execute(objectInstance, valueList.ToArray()).ToString();
            SetOK(LogicResult);
        }

        public void Execute1(string expression,out object message)
        {
            message = null;
            List<object> valueList = AnalysisExpress(expression, out string code);//首先获得解析完成的类
            if (executor == null)
            {
                GetResult(valueList, code, out message);
            }
            message = executor.Execute(objectInstance, valueList.ToArray()).ToString();
        }

        [ConditionJudge]
        public string LogicResult { get; set; }

        [NonSerialized]
        [XmlIgnore]
        public DynamicMethodExecute executor = null;

        [XmlIgnore]
        object objectInstance = null;

        public List<object> AnalysisExpress(string express, out string code)//解析表达式  
        {
            code = null;
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
                    int arrayIndex = Convert.ToInt32(str.Substring(str.IndexOf('[') + 1, str.IndexOf(']') - str.IndexOf('[') - 1));
                    PropertyInfo propertyInfo = SelectedOperatorBlock.ToolList.Find(d => d.StepCustomName == blockName).GetType().GetProperty(propertyName);
                    if (propertyInfo.PropertyType.Name == "Double[]")
                    {
                        propertyType = "System.Double";
                        valueList.Add(propertyInfo.GetValue(SelectedOperatorBlock.ToolList.Find(c => c.StepCustomName == blockName)));
                    }
                    else if (propertyInfo.PropertyType.Name == "PointF[]")
                    {
                        propertyType = "System.Single";
                        object o = propertyInfo.GetValue(SelectedOperatorBlock.ToolList.Find(c => c.StepCustomName == blockName));
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
                    if (name.Split('.')[0] == "Vars")
                    {
                        VarCollectionClass varCollection = StaticPublicData.VariableData.GetVarClass(propertyName);
                        switch(varCollection.VarType)//这里的N还需要多考虑一下 因为可能是
                        {
                            case "N":
                                propertyType = "System.Int32";
                                break;
                            case "S":
                                propertyType = "System.String";
                                break;
                            case "B":
                                propertyType = "System.Boolean";
                                break;
                            case "P":
                                break;
                        }
                        valueList.Add(varCollection.VarValue);
                    }
                    else
                    {
                        PropertyInfo proInfo = SelectedOperatorBlock.ToolList.Find(c => c.StepCustomName == blockName).GetType().GetProperty(propertyName);
                        propertyType = proInfo.PropertyType.ToString();//得到参数的类型
                        valueList.Add(proInfo.GetValue(SelectedOperatorBlock.ToolList.Find(c => c.StepCustomName == blockName)));
                    }
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
            code = @"public class TestComputer 
           { 
             public object Computer (" + formatParam + ") { return @exp;}}";
            code = code.Replace("@exp", newExpress);
            return valueList;
        }

        private bool GetResult(List<object> valueList, string code, out object obj)
        {
            obj = null;
            try
            {
                CSharpCodeProvider cshapeCodeprovider = new CSharpCodeProvider();//提供对C#代码生成器和编译器的访问                
                CompilerParameters compilerParameters = new CompilerParameters
                {
                    GenerateExecutable = false,//是否生成可执行文件
                    GenerateInMemory = false//在内存中生成输出
                };//编译器参数
                CompilerResults compilerResult = cshapeCodeprovider.CompileAssemblyFromSource(compilerParameters, code);
                if (compilerResult.Errors.Count > 0)//没有错误
                {
                    string errorMessage = null;
                    for (int i = 0; i < compilerResult.Errors.Count; i++)
                    {
                        if (i == compilerResult.Errors.Count - 1)
                        {
                            errorMessage += "[错误" + i.ToString() + "]:" + compilerResult.Errors[i].ErrorText;
                        }
                        else
                        {
                            errorMessage += "[错误" + i.ToString() + "]:" + compilerResult.Errors[i].ErrorText + Environment.NewLine;
                        }
                    }
                    obj = errorMessage;
                }
                else //没有错误则执行
                {
                    Assembly assembly = compilerResult.CompiledAssembly;//获取已编译的程序集
                    MethodInfo methodInfo = assembly.GetType("TestComputer").GetMethod("Computer");
                    objectInstance = assembly.CreateInstance(assembly.GetType("TestComputer").FullName);
                    executor = new DynamicMethodExecute(methodInfo);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public override bool RunAgoCheck()
        {
            ErrorList.Clear();
            return ErrorList.Count == 0;
        }

        public string Expression { get; set; }
    }
}
