using System;
using System.Data;

namespace _011代理模式
{
    public class LoggerProxy:IAbstractLog
    {
        private BusinessClass businessClass;

        public LoggerProxy()
        {
            this.businessClass = businessClass;
        }
        public void Method()
        {
            Console.WriteLine("当前系统时间为"+DateTime.Now.ToString());
        }
    }
}