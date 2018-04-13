using System;
using System.Runtime.CompilerServices;

namespace _009装饰模式
{
    public class AirPlane:Changer
    {
        public AirPlane(Transform transform):base(transform)
        {
            Console.WriteLine("变成飞机");
        }

        public void move()
        {
            Console.WriteLine("飞机正在移动");
        }

        public void fly()
        {
            Console.WriteLine("正在飞翔");
        }
    }
}