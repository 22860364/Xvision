using DispenseAPP.AboutData;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using static DispenseAPP.CommonClass;

namespace DispenseAPP
{
    public class InitialHelper
    {
        public static void LogicOperationInitialReference(List<IToolable> tools, ListBox listBox, Dictionary<string, List<BlockNameValue>> dictionary, int index, bool IsLogicOperation = true)//初始化变量引用
        {
            List<IToolable> toolsList = tools.GetRange(0, index + 1);
            if (toolsList != null)
            {
                foreach (var item in toolsList)//遍历当前普通算子块中的工具
                {
                    listBox.Items.Add(item.StepCustomName);
                    List<BlockNameValue> blockList = new List<BlockNameValue>();
                    foreach (PropertyInfo items in item.GetType().GetProperties())//获得当前遍历到的工具的所有的属性
                    {
                        if (items.IsDefined(typeof(ReferenceAttribute), true))
                        {
                            if (item.StepState == true || (item.StepState == false && (items.GetCustomAttribute(typeof(ReferenceAttribute)) as ReferenceAttribute).ExecuteState == true))//进入if的条件是 执行结果为true 或者 执行结果为false && 标记的特性为true 
                            {
                                object obj = items.GetValue(item, null);
                                if (obj != null)
                                {
                                    if (obj is Array)//当前数据为数组
                                    {
                                        if (obj is PointF[] pointF)
                                        {
                                            if (IsLogicOperation)
                                            {
                                                for (int i = 0; i < pointF.Length; i++)
                                                {
                                                    BlockNameValue PointFNameValueX = new BlockNameValue
                                                    {
                                                        Name = items.Name + "[" + i.ToString() + "].X",
                                                        Type = "N",
                                                        Value = pointF[i].X.ToString("f3")
                                                    };
                                                    blockList.Add(PointFNameValueX);
                                                    BlockNameValue PointFNameValueY = new BlockNameValue
                                                    {
                                                        Name = items.Name + "[" + i.ToString() + "].Y",
                                                        Type = "N",
                                                        Value = pointF[i].Y.ToString("f3")
                                                    };
                                                    blockList.Add(PointFNameValueY);
                                                }
                                            }
                                            else
                                            {
                                                BlockNameValue PointFNameValue = new BlockNameValue
                                                {
                                                    Name = items.Name,
                                                    Type = "P[]",
                                                };
                                                if (pointF.Length > 0)
                                                {
                                                    PointFNameValue.Value = "((" + pointF[0].X.ToString("f3") + "," + pointF[0].Y.ToString("f3") + ")...)[" + pointF.Length + "]";
                                                }
                                                else
                                                {
                                                    PointFNameValue.Value = "[0]";
                                                }
                                                blockList.Add(PointFNameValue);
                                            }
                                        }
                                        else if (obj is double[] d)
                                        {
                                            if (IsLogicOperation)
                                            {
                                                for (int i = 0; i < d.Length; i++)
                                                {
                                                    BlockNameValue PointFNameValueD = new BlockNameValue
                                                    {
                                                        Name = items.Name + "[" + i.ToString() + "]",
                                                        Type = "N",
                                                        Value = d[i].ToString("f3")
                                                    };
                                                    blockList.Add(PointFNameValueD);
                                                }
                                            }
                                            else
                                            {
                                                BlockNameValue PointFNameValueD = new BlockNameValue
                                                {
                                                    Name = items.Name,
                                                    Type = "N[]",
                                                };
                                                if (d.Length > 0)
                                                {
                                                    PointFNameValueD.Value = "((" + d[0].ToString("f3") + ")...)[" + d.Length + "]";
                                                }
                                                else
                                                {
                                                    PointFNameValueD.Value = "[0]";
                                                }
                                                blockList.Add(PointFNameValueD);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        BlockNameValue blockNameVlaue = new BlockNameValue
                                        {
                                            Name = items.Name,
                                            Value = items.GetValue(item).ToString()
                                        };
                                        switch (items.PropertyType.ToString())
                                        {
                                            case "System.Int32":
                                            case "System.Int16":
                                                blockNameVlaue.Type = "N";
                                                break;
                                            case "System.String":
                                                blockNameVlaue.Type = "S";
                                                break;
                                            case "System.Boolean":
                                                blockNameVlaue.Type = "B";
                                                break;
                                        }
                                        blockList.Add(blockNameVlaue);
                                    }
                                }

                            }
                        }
                    }
                    dictionary.Add(item.StepCustomName, blockList);
                }
            }
            List<BlockNameValue> varList = new List<BlockNameValue>();
            foreach (VarCollectionClass item in StaticPublicData.VariableData.varList)//遍历变量列表
            {
                BlockNameValue blockNameValue = new BlockNameValue
                {
                    Name = item.VarName,
                    Type = item.VarType,
                    Value = item.VarValue.ToString()
                };
                varList.Add(blockNameValue);
            }
            listBox.Items.Add("Vars");
            dictionary.Add("Vars", varList);//添加变量
        }

        /// <summary>
        /// 向下拉框中添加连接成功的相机的用户自定义名称
        /// </summary>
        /// <param name="comboBox">下拉框对象</param>
        public static void InitialCamera(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (string item in CameraIDObjectDict.Keys)//将连接成功的相机添加到下拉框中 
            {
                comboBox.Items.Add(StaticPublicData.CameraDataItems[item].CustomName);//这里不需要判断Find的结果是否为空的情况 因为在相机每次初始化时做了判断  默认情况下 系统名称和用户名称是相同的
            }
        }

        /// <summary>
        /// 初始化下拉框的值
        /// </summary>
        /// <param name="comboBox">下拉框对象</param>
        /// <param name="value">传入的值 如果传入的值为null 则默认为第一项</param>
        public static void InitialComboBoxValue(ComboBox comboBox, string value)
        {
            if (value != null)
            {
                if (comboBox.Items.Contains(value))
                {
                    comboBox.SelectedIndex = comboBox.Items.IndexOf(value);
                }
                else
                {
                    comboBox.Items.Add("???");
                    comboBox.SelectedIndex = comboBox.Items.IndexOf("???");//设置索引
                }
            }
            else
            {
                if (comboBox.Items.Count > 0)
                {
                    comboBox.SelectedIndex = 0;
                }
            }
        }

        public static void InitialComboBoxValue(ComboBox[] comboBoxes,string[] values)
        {
            if(comboBoxes.Length != values.Length)
            {
                return;
            }
            for (int i = 0; i < comboBoxes.Length; i++)
            {
                InitialComboBoxValue(comboBoxes[i], values[i]);
            }
        }

        public static Dictionary<string, List<string>> InitialBlockAndToolsContainAttribute(ComboBox comboBox, Type type)
        {
            Dictionary<string, List<string>> BlockNameAndToolNameFields = new Dictionary<string, List<string>>();//存放算子名（键）工具名+字段名
            foreach (BlockItem item in StaticPublicData.BlockItems)//遍历所有的算子块 如果是普通算子块 则继续遍历
            {
                if (item is OperatorBlock normalBlock)
                {
                    List<IToolable> toolList = normalBlock.ToolList.FindAll(c => c.GetType().IsDefined(type, false));//查找该工具类是否被标记了可以校正XY的特性
                    List<string> fieldList = new List<string>();//存放字段的集合
                    foreach (IToolable items in toolList)
                    {
                        foreach (FieldInfo itemss in items.GetType().GetFields())//遍历工具的所有字段
                        {
                            if (itemss.IsDefined(type, false))//如果该字段被标记了校正XY的特性 则添加
                            {
                                fieldList.Add(items.StepCustomName + "-" + itemss.Name);
                            }
                        }
                    }
                    if (fieldList.Count > 0)
                    {
                        comboBox.Items.Add(item.CustomName);//普通算子块名称
                        BlockNameAndToolNameFields.Add(item.CustomName, fieldList);
                    }
                }
            }
            return BlockNameAndToolNameFields;
        }
    }
    public class BlockNameValue
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}
