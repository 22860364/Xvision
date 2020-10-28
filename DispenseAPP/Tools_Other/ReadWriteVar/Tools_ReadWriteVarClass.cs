using DispenseAPP.AboutData;
using System;
using System.Collections.Generic;
using static DispenseAPP.CommonClass;
using System.Drawing;

namespace DispenseAPP.Tools_Other.ReadWriteVar
{
    /// <summary>
    /// 读写变量工具
    /// </summary>
    [UnableManualExecute]
    [Serializable]
    public class ReadWriteVarToolEntity : IToolable
    {
        /// <summary>
        /// 构造函数 用于序列化
        /// </summary>
        public ReadWriteVarToolEntity()
        {
        }

        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePath { get; set; } = null;

        /// <summary>
        /// 读
        /// </summary>
        public bool Read { get; set; } = true;

        /// <summary>
        /// 写
        /// </summary>
        public bool Write { get; set; } = false;

        /// <summary>
        /// 要操作的变量名的集合
        /// </summary>
        public List<string> VarNameList { get; set; } = new List<string>();

        /// <summary>
        /// 工具箱名称
        /// </summary>
        public override ToolsKitNameEnum ToolKitName => ToolsKitNameEnum.Other;

        /// <summary>
        /// 工具名称
        /// </summary>
        public override string ToolName => "读写变量";

        public override void Execute()
        {      
            List<VarCollectionClass> VarList = StaticPublicData.VariableData.varList;
            foreach (string item in VarNameList)
            {
                string value = null;
                VarCollectionClass varCollectionClass = VarList.Find(c => c.VarName == item);
                if (varCollectionClass != null)
                {
                    switch (varCollectionClass.VarType)
                    {
                        case "N":
                        case "S":
                        case "B":
                            if (Read)
                            {
                                varCollectionClass.VarValue = INIClass.ReadString("Generic", item, "", FilePath);
                            }
                            else//写
                            {
                                INIClass.WriteString("Generic", item, VarList.Find(c => c.VarName == item).VarValue.ToString(), FilePath);
                            }
                            break;
                        case "P":
                            if (Read)
                            {
                                value = INIClass.ReadString("Generic", item, "0,0", FilePath);
                                varCollectionClass.VarValue = new PointF(Convert.ToSingle(value.Split(',')[0]), Convert.ToSingle(value.Split(',')[1]));
                            }
                            else//写
                            {
                                PointF point = (PointF)varCollectionClass.VarValue;
                                INIClass.WriteString("Generic", item, point.X + "," + point.Y, FilePath);
                            }
                            break;
                    }
                }
            }
            SetOK("执行成功...");
        }

        public override bool RunAgoCheck()
        {
            ErrorList.Clear();
            if (Read && !System.IO.File.Exists(FilePath))//如果文件不存在 直接返回
            {
                ErrorList.Add("文件不存在...");
            }
            return ErrorList.Count == 0;
        }
    }
}
