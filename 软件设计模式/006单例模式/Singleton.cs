using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006单例模式
{
    public class Singleton
    {
        //懒汉式加线程锁
        private static Singleton singleton;
        private static object _lock=new object();
        private Singleton()
        {
        }
        public static Singleton Instance()
        {
            if (null == singleton)
            {
                lock (_lock)
                {
                    if (null == singleton)
                    {
                        singleton=new Singleton();
                    }
                }
                
            }
            return singleton;
        }

        public static void play()
        {
            Console.WriteLine("hello world");
        }
    }
}
