using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002工厂方法模式
{
    class HisenceTVFactory:Factory
    {
        public override TV Production()
        {
            Console.WriteLine("正在生产海信电视");
 	         return new HisenceTV();
        }
    }
}
