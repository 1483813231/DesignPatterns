using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003抽象工厂模式
{
    public class HaierFactory:Factory
    {
        public override TV ProductionTV()
        {
            Console.WriteLine("正在生产海尔电视机");
            return new HaierTV();
        }
        public override AirCondition ProductionCondition()
        {
            Console.WriteLine("正在生产海尔空调");
            return new HaierCondition();
        }
    }
}
