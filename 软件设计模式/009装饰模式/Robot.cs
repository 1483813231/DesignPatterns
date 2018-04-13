using System;

namespace _009装饰模式
{
    public class Robot:Changer
    {
        public Robot(Transform transform):base(transform)
        {
            Console.WriteLine("变成机器人");
        }

        public void move()
        {
            Console.WriteLine("机器人正在移动");
        }

        public void say()
        {
            Console.WriteLine("机器人正在说话");
        }

    }
}