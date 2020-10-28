using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using static DispenseAPP.CommonClass;

namespace DispenseAPP.Tools_Other.Script
{
    [Serializable]
    public class Tools_ScriptClass : IToolable
    {
        private string ScriptText { get; set; } = "";//脚本内容

        public override ToolsKitNameEnum ToolKitName => ToolsKitNameEnum.Other;

        public override string ToolName => "脚本";

        public Tools_ScriptClass()
        {
        }

        public override void Execute()
        {

        }

        public bool ExecuteCompile(string textValue,bool IsRun,out string[] error)//执行编译
        {
            List<string> errorList = new List<string>();
            CSharpCodeProvider objCSharpCodeProvider = new CSharpCodeProvider();//提供对C#代码 生成器和代码编译器的实例的访问 
            CodeDomProvider provider = CodeDomProvider.CreateProvider("C#");
            CompilerParameters objCompilerParameters = new CompilerParameters();
            objCompilerParameters.ReferencedAssemblies.Add("System.dll");//添加引用的dll
            objCompilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");//添加引用的dll
            objCompilerParameters.ReferencedAssemblies.Add("System.Data.dll");
            objCompilerParameters.ReferencedAssemblies.Add("System.Xml.dll");
            objCompilerParameters.ReferencedAssemblies.Add("Microsoft.CSharp.dll");
            objCompilerParameters.ReferencedAssemblies.Add("System.Core.dll");
            objCompilerParameters.ReferencedAssemblies.Add("System.Drawing.dll");
            objCompilerParameters.GenerateExecutable = false;//不生成可执行文件
            objCompilerParameters.GenerateInMemory = true;//是否生成在内存中
            CompilerResults cr = provider.CompileAssemblyFromSource(objCompilerParameters, textValue);
            if (cr.Errors.Count > 0)
            {
                for (int i = 0; i < cr.Errors.Count; i++)
                {
                     errorList.Add("[错误" + i.ToString() + "]:" + cr.Errors[i].ErrorText);
                }
                error = errorList.ToArray();
                return false;
            }
            else
            {
                errorList.Add("编译成功");
            }
            error = errorList.ToArray(); 
            if (IsRun)
            {
                Assembly assembly = cr.CompiledAssembly;//获取已编译的程序集
                object objHelloWorld = assembly.CreateInstance("Test");
                MethodInfo methodInfo = objHelloWorld.GetType().GetMethod("Hello");
                methodInfo.Invoke(objHelloWorld, new object[] { StaticPublicData.VariableData});
                errorList.Add("执行成功");
            }
            return true;
        }

        public override bool RunAgoCheck()
        {
            ErrorList.Clear();
            return ErrorList.Count == 0;
        }
    }
}
