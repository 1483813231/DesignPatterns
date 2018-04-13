using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003抽象工厂模式
{
    public class HaierTV:TV
    {
        public void Play()
        {
            Console.WriteLine("海尔电视正在播放");
        }
    }
}
