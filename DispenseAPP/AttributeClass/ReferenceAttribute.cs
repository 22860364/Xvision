using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP
{
    [AttributeUsage(AttributeTargets.Property)]//规定特性类的用途（用于属性）
    public class ReferenceAttribute:Attribute 
    {
        public ReferenceAttribute(bool b)
        {
            ExecuteState = b;
        }

        public bool ExecuteState { get; set; }
    }
}
