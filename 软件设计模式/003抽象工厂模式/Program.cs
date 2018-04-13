using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003抽象工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new HaierFactory();
            TV tv = factory.ProductionTV();
            tv.Play();
            AirCondition condition = factory.ProductionCondition();
            condition.Refirgeration();
            Console.ReadKey();
        }
    }
}
