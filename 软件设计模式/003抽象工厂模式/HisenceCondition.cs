using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003抽象工厂模式
{
    public class HisenceCondition:AirCondition
    {
        public void Refirgeration()
        {
            Console.WriteLine("海信空调正在制冷");
        }
    }
}
