using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007适配器3
{
    class Program
    {
        static void Main(string[] args)
        {
            CarController mycar=new CarAdapter();
            mycar.Move();
            mycar.Lamp();
            mycar.Sound();
            Console.ReadKey();
        }
    }
}
