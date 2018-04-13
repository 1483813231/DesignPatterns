using System;

namespace _011代理模式
{
    public class BusinessClass:IAbstractLog
    {
        public void Method()
        {
            Console.WriteLine("真实业务方法！");
        }
    }
}