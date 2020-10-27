using System;
using System.Collections.Generic;
using System.Dynamic;

namespace DispenseAPP.AboutData
{
    [Serializable]
    public class VarClass : DynamicObject
    {

        public List<VarCollectionClass> varList = new List<VarCollectionClass>();
       
        public bool ContainsProperty(string propertyName)//是否包含变量名
        {
            if(varList.Find(c => c.VarName == propertyName) != null)
            {
                return true;
            }
            else
            {
                return false;
            }     
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)//得到成员
        {
            VarCollectionClass varCollectionClass = varList.Find(c => c.VarName == binder.Name);
            result = varCollectionClass.VarValue;
            return true; 
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)//设置成员
        {
            VarCollectionClass varCollectionClass = (VarCollectionClass)value;
            if (binder.Name == "Property")
            {
                varList.Add(varCollectionClass);
            }
            return true;
        }

        public override bool TrySetIndex(SetIndexBinder binder, object[] indexes, object value)
        {
            return base.TrySetIndex(binder, indexes, value);
        }

        public override bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result)
        {
            return base.TryGetIndex(binder, indexes, out result);
        }


        public bool DeleteProperty(string propertyName)//删除属性
        {
            return varList.Remove(varList.Find(c => c.VarName == propertyName));
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

        public object GetVarInitialValue(string name)
        {
            Type t = varList.Find(c => c.VarName == name).GetType();
            return t.IsValueType ? Activator.CreateInstance(t) : null;
        }
    }


    [Serializable]
    public class VarCollectionClass:ICloneable
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
