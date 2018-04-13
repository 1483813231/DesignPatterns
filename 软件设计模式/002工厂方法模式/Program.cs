using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002工厂方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new HisenceTVFactory();
            TV tv= factory.Production();
            tv.Play();
            Console.ReadKey();
        }
    }
}
