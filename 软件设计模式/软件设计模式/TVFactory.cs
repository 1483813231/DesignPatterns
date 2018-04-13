using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 软件设计模式
{
    class TVFactory
    {
        public TV Production(string brand)
        {
            if("haier"==brand)
            {
                Console.WriteLine("正在生产haier电视");
                return new HaierTV();
            }
            else if("hisence"==brand)
            {
                Console.WriteLine("正在生产hisence电视");
                return new HisenceTV();
            }
            else 
            {
                Console.WriteLine("暂不支持生产此型号电脑");
                return null;
            }
        }
    }
}
