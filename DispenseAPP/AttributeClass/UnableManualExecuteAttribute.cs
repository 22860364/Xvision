using System;

namespace DispenseAPP
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    public class UnableManualExecuteAttribute:Attribute //可以手动执行的特性
    {

    }
}
