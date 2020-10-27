using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace DispenseAPP.AboutData
{
    public static class MyDataBindingsClass
    {
        public static void NotifyPropertyChanged<T>(object dataClass, Expression<Func<T>> property,PropertyChangedEventHandler PropertyChanged)//属性改变后通知控件的属性
        {
            if(PropertyChanged == null)
            {
                return;
            }
            var memberExpression = property.Body as MemberExpression;
            if(memberExpression == null)
            {
                return;
            }
            PropertyChanged.Invoke(dataClass, new PropertyChangedEventArgs(memberExpression.Member.Name));
        }
    }
}
