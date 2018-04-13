using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003抽象工厂模式
{
    public class HaierCondition:AirCondition
    {
        public void Refirgeration()
        {
            Console.WriteLine("海尔空调正在制冷");
        }
    }
}
