using System;
using System.Runtime.CompilerServices;

namespace _009装饰模式
{
    public class Car:Transform
    {
        public Car()
        {
            Console.WriteLine("变形金刚是一辆车");
        }

        public void move()
        {
            Console.WriteLine("正在陆地上移动");
        }

    }
}