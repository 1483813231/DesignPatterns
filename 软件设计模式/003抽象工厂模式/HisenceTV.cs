using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003抽象工厂模式
{
    public class HisenceTV:TV
    {
        public void Play()
        {
            Console.WriteLine("海信电视正在播放");
        }
    }
}
