using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009装饰模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Transform transform =new Car();
            transform.move();
            Console.WriteLine("===============");
            AirPlane airplane = new AirPlane(transform);
            airplane.move();
            airplane.fly();
            Console.ReadKey();
        }
    }
}
