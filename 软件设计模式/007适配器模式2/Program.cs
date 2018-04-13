using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007适配器模式2
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot=new DogAdapter();
            robot.Cry();
            robot.Move();
            
            Console.ReadKey();
        }
    }
}
