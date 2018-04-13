using System;

namespace _007适配器3
{
    public class ConcreteSound:Sound
    {
        public override void Phonate()
        {
            Console.WriteLine("哇呜哇呜哇呜");
        }
    }
}