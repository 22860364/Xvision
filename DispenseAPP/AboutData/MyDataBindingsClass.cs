﻿using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace DispenseAPP.AboutData
{
    public static class MyDataBindingsClass
    {
        private static readonly object obj = new object();
        public static void NotifyPropertyChanged<T>(object dataClass, Expression<Func<T>> property, PropertyChangedEventHandler PropertyChanged)//属性改变后通知控件的属性
        {
            if (PropertyChanged == null)
            {
                return;
            }
            if (!(property.Body is MemberExpression memberExpression))
            {
                return;
            }
            PropertyChanged.Invoke(dataClass, new PropertyChangedEventArgs(memberExpression.Member.Name));//这个地方内存泄漏
        }
    }
}
