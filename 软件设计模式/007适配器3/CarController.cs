using System;

namespace _007适配器3
{
    public abstract class CarController
    {
        public void Move()
        {
            Console.WriteLine("小车在移动！");
        }

        public abstract void Lamp();
        public abstract void Sound();
    }
}