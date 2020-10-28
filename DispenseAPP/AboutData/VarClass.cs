using System;
using System.Collections.Generic;
using System.Dynamic;

namespace DispenseAPP.AboutData
{
    [Serializable]
    public class VarClass : DynamicObject
    {
        public List<VarCollectionClass> varList = new List<VarCollectionClass>();

        public bool ContainsProperty(string propertyName)//变量是否已经存在
        {
            if (varList.Find(c => c.VarName == propertyName) != null) { return true; }
            else { return false; }
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)//得到成员
        {
            VarCollectionClass varCollectionClass = varList.Find(c => c.VarName == binder.Name);
            result = varCollectionClass.VarValue;
            return true;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)//设置成员
        {
            VarCollectionClass varExits = varList.Find(c => c.VarName == binder.Name);
            if (varExits != null)//代表该变量已经存在 否则不存在
            {
                varExits.VarValue = value;
                return true;
            }
            return false;
        }

        public bool SetValue(string varName,object value)
        {
            VarCollectionClass varExits = varList.Find(c => c.VarName == varName);
            if (varExits != null)//代表该变量已经存在 否则不存在
            {
                varExits.VarValue = value;
                return true;
            }
            return false;
        }

        public bool DeleteProperty(string propertyName)//删除属性
        {
            return varList.Remove(varList.Find(c => c.VarName == propertyName));
        }

        public void AddProperty(VarCollectionClass varCollectionClass)//添加属性
        {
            varList.Add(varCollectionClass);
        }

        public VarCollectionClass GetVarClass(string varName)
        {
            return varList.Find(c => c.VarName == varName);
        }

        public void SetVarInitialValue(string varName)//设为初始值
        {
            VarCollectionClass getVar = varList.Find(c => c.VarName == varName);
            Type t = getVar.VarValue.GetType();
            getVar.VarValue = t.IsValueType ? Activator.CreateInstance(t) : null;
        }

        public void SetVarValue(Dictionary<string,string> varNameValue)
        {
            foreach (KeyValuePair<string,string> item in varNameValue)
            {
                VarCollectionClass varCollectionClass = varList.Find(c => c.VarName == item.Key);
                switch(varCollectionClass.VarType)
                {
                    case "N":
                        varCollectionClass.VarValue = Convert.ToDecimal(item.Value);
                        break;
                    case "S":
                        varCollectionClass.VarValue = item.Value;
                        break;
                    case "B":
                        varCollectionClass.VarValue = Convert.ToBoolean(item.Value);
                        break;
                    case "P":
                        break;
                    case "N[]":
                        break;
                    case "S[]":
                        break;
                    case "B[]":
                        break;
                    case "P[]":
                        break;
                }
            }
        }
    }

    [Serializable]
    public class VarCollectionClass : ICloneable
    {
        public string VarName { get; set; }
        public string VarType { get; set; }
        public string VarRemark { get; set; }
        public object VarValue { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
