using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003抽象工厂模式
{
    public class HisenceFactory:Factory
    {
        public override TV ProductionTV()
        {
            Console.WriteLine("正在生产海信电视机");
            return new HisenceTV();
        }
        public override AirCondition ProductionCondition()
        {
            Console.WriteLine("正在生产海信空调");
            return new HisenceCondition();
        }
    }
}
