using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using static DispenseAPP.CommonClass;
using System.Drawing;
using System.Text.RegularExpressions;

namespace DispenseAPP.AboutData
{
    public class AnalysisDataClass //解析数据类
    {
        public static string AnalysisBracketsData(string SendText, List<ITools> tools)//解析中括号中的数据 用于：【TCP/IP通讯】【三菱Q系列通讯】
        {
            Regex regex = new Regex("<[^<>]*>");
            MatchCollection matchCollection = regex.Matches(SendText);
            for (int i = 0; i < matchCollection.Count; i++)
            {
               string value = GetPropertyValue(matchCollection[i].Value.Replace('<', ' ').Replace('>', ' ').Trim(), tools);
               SendText =  SendText.Replace(matchCollection[i].Value, value);
            }
            return SendText;
        }

        public static string GetPropertyValue(string name,List<ITools> tools)
        {
            string value = null;
            string blockName = name.Split('-')[0].Trim();
            string varName = name.Split('-')[1].Trim();
            string propertyName = null;
            if (blockName == "Vars")//变量
            {
                value= StaticProjectParamClass.Vars.GetVarClass(varName).VarValue.ToString();
            }
            else//算子块
            {
                tools.Find(c => c.BlockName == blockName);
                if (varName.Contains('['))//如果包含 [ 则代表该数据为数组类型
                {
                    propertyName = varName.Substring(0, varName.IndexOf('['));//得到属性名称
                    int arrayIndex = Convert.ToInt32(varName.Substring(varName.IndexOf('[') + 1, varName.IndexOf(']') - varName.IndexOf('[') - 1));//得到数组索引
                    PropertyInfo propertyInfo = tools.GetType().GetProperty(propertyName);
                    if (propertyInfo.PropertyType.Name == "Double[]") //这里可能存在隐患  是否需要Decimal类型 
                    {
                        object ob = propertyInfo.GetValue(tools);
                        double[] dd = ob as double[];
                        value = dd[arrayIndex].ToString();
                    }
                    else if (propertyInfo.PropertyType.Name == "PointF[]")
                    {
                        object o = propertyInfo.GetValue(tools);
                        PointF[] point = o as PointF[];
                        if (varName.Split('.')[1] == "X")
                        {
                            value = point[arrayIndex].X.ToString();
                        }
                        else if (varName.Split('.')[1] == "Y")
                        {
                            value = point[arrayIndex].Y.ToString();
                        }
                    }
                }
                else if (varName.Contains('.'))//为Point类型
                {
                    propertyName = varName.Substring(0, varName.IndexOf('.'));//获得属性名称
                    PropertyInfo propertyInfo = tools.GetType().GetProperty(propertyName);
                    object o = propertyInfo.GetValue(tools);
                    if (varName.Substring(varName.LastIndexOf('.') + 1) == "X")
                    {
                        value = ((PointF)o).X.ToString();
                    }
                    else if (varName.Substring(varName.LastIndexOf('.') + 1) == "Y")
                    {
                        value = ((PointF)o).Y.ToString();
                    }
                }
                else//为普通类型
                {
                    PropertyInfo proInfo = tools.GetType().GetProperty(varName);
                    value = proInfo.GetValue(tools).ToString();
                }
            }
            return value;
        }

        public static List<string> QueryReferenceVar(string type = "NSBPN[]S[]B[]P[]")//查询引用的变量
        {
            List<string> strValue = new List<string>();
            foreach (VarCollectionClass item in StaticProjectParamClass.Vars.varList)//初始化变量引用
            {
                if (type.Contains(item.VarType))
                {
                    switch (item.VarType)
                    {
                        case "N":
                        case "S":
                        case "B":
                            strValue.Add("Vars-" + item.VarName);
                            break;
                        case "P":
                            strValue.Add("Vars-" + item.VarName + ".Y");
                            strValue.Add("Vars-" + item.VarName + ".X");
                            break;
                        case "N[]":
                        case "S[]":
                        case "B[]":
                        case "P[]":
                                for (int i = 0; i < StaticProjectParamClass.Vars.GetVarClass(item.VarName).VarValue.Count; i++)
                                {
                                    if (item.VarType == "P[]")
                                    {
                                        strValue.Add("Vars-" + item.VarName + "[" + i.ToString() + "].X");
                                        strValue.Add("Vars-" + item.VarName + "[" + i.ToString() + "].Y");
                                    }
                                    else
                                    {
                                        strValue.Add("Vars-" + item.VarName + "[" + i.ToString() + "]");
                                    }
                                }
                            break;
                    }
                }
            }
            return strValue;
        }

        public static List<string> QueryReferenceTools(List<ITools> toolsList)//查询引用的工具
        {
            List<string> strValue = new List<string>();
            foreach (ITools tools in toolsList)
            {
                foreach (PropertyInfo items in tools.GetType().GetProperties())//遍历获得当前工具中所有的属性
                {
                    if (items.GetCustomAttributes(typeof(ReferenceAttribute), true).Length > 0)
                    {
                        object obj = items.GetValue(tools, null);
                        if (obj is Array array)//当前数据为数组
                        {
                            if (obj is PointF[])
                            {
                                for (int i = 0; i < array.Length; i++)
                                {
                                    strValue.Add(tools.BlockName + "-" + items.Name + "[" + i.ToString() + "].X");
                                    strValue.Add(tools.BlockName + "-" + items.Name + "[" + i.ToString() + "].Y");
                                }
                            }
                            else
                            {
                                for (int i = 0; i < array.Length; i++)
                                {
                                    strValue.Add(tools.BlockName + "-" + items.Name + "[" + i.ToString() + "]");
                                }
                            }
                        }
                        else//不是数组
                        {
                            if (obj is PointF point)
                            {
                                strValue.Add(tools.BlockName + "-" + items.Name + ".X");
                                strValue.Add(tools.BlockName + "-" + items.Name + ".Y");
                            }
                            else
                            {
                                strValue.Add(tools.BlockName + "-" + items.Name);
                            }
                        }
                    }
                }
            }
            return strValue;
        }

        public static List<int> GetCharAllIndex(string str, char c)//获得字符串中某个字符的所有索引
        {
            List<int> list = new List<int>();
            int index = 0;
            foreach (char item in str)
            {
                if (item == c)
                {
                    list.Add(index);//从0开始
                }
                index++;
            }
            return list;
        }
    }
}
