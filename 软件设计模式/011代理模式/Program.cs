using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            IAbstractLog loggerProxy = new LoggerProxy();
            loggerProxy.Method();
            Console.ReadKey();
        }
    }
}
