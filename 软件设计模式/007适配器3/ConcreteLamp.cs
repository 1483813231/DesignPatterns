using System;

namespace _007适配器3
{
    public class ConcreteLamp:Lamp
    {
        public override void Twinkle()
        {
            Console.WriteLine("发出耀眼的光芒");
        }
    }
}