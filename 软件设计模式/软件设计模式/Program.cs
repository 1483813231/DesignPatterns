using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 软件设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            TVFactory factory=new TVFactory();
            try
            {
                TV tv = factory.Production("hisence");
                tv.Play();
            }
            catch
            {
                Console.WriteLine("错误");
            }
            Console.ReadKey();
            
        }

    }
}
