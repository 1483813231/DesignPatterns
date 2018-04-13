using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance();
            Singleton.play();
            Console.ReadKey();
        }
    }
}
