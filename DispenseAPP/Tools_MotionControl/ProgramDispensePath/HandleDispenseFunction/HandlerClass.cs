using DispenseAPP.Tools_MotionControl.ProgrammingDispensePath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispenseAPP.Tools_MotionControl.ProgramDispensePath.HandleDispenseFunction
{
    public abstract class HandlerClass//请求处理者类
    {
        public abstract void HandleRequest(DispenseRequestClass request);//抽象的处理方法 在此处是对源数据进行处理
    }
}
