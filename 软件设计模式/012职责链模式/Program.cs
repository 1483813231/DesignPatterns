using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012职责链模式
{
    class Program
    {
        static void Main(string[] args)
        {
            LeaverRequest myleacLeaverRequest=new LeaverRequest("tom",5);
            Leader director=new Director("狗子");
            Leader manager=new Manager("铁柱");

            director.Successor = manager;
            director.HandleRequest(myleacLeaverRequest);
            Console.ReadKey();

        }
    }
}
