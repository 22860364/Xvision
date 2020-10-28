using System;
using System.Collections.Generic;

namespace DispenseAPP
{
    public class CommandPool
    {
        public event Action<bool> UndoStateChangeEvent;//撤销按钮状态改变事件

        public event Action<bool> ReboStateChangeEvent;//重做按钮状态改变事件

        /// <summary>
        /// 待重做栈
        /// </summary>
        private Stack<Command> undidStack;

        /// <summary>
        /// 允许存放命令的最大次数
        /// </summary>
        private int maxCommandCount;

        /// <summary>
        /// 带撤销双端队列
        /// </summary>
        private Deque<Command> didDeque;

       /// <summary>
       /// 构造函数
       /// </summary>
       /// <param name="maxCommandCount"></param>
        public CommandPool(int maxCommandCount)
        {
            didDeque = new Deque<Command>(maxCommandCount);
            undidStack = new Stack<Command>();
            this.maxCommandCount = maxCommandCount;
        }

        /// <summary>
        /// 记录
        /// </summary>
        /// <param name="command"></param>
        public void Register(Command command)
        {
            undidStack.Clear();//将待重做栈清空
            if(didDeque.Count == maxCommandCount)
            {
                didDeque.RemoveHead();
            }
            didDeque.AddTail(command);
            UndoStateChangeEvent(didDeque.Count > 0); //撤销图标变化事件    
            ReboStateChangeEvent(undidStack.Count > 0);//重做图标
        }

        /// <summary>
        /// 撤销
        /// </summary>
        public void Undo()
        {
            if(didDeque.Count ==0)
            {
                return;
            }
            Command command = didDeque.RemoveTail();         
            command.Undo();
            undidStack.Push(command);
            ReboStateChangeEvent(undidStack.Count > 0);//重做图标
            UndoStateChangeEvent(didDeque.Count > 0);//撤销图标变化事件  
        }

       /// <summary>
       /// 重做
       /// </summary>
        public void Rebo()
        {
            if(undidStack.Count==0)
            {              
                return;
            }
            Command command = undidStack.Pop();
            command.Excute();
            didDeque.AddTail(command);
            UndoStateChangeEvent(didDeque.Count > 0);//撤销图标变化事件  
            ReboStateChangeEvent(undidStack.Count > 0);//重做图标
        }

        public void Clear()
        {
            didDeque.Clear();
            undidStack.Clear();
            UndoStateChangeEvent(didDeque.Count > 0);//撤销图标变化事件  
            ReboStateChangeEvent(undidStack.Count > 0);//重做图标
        }
    }
}
