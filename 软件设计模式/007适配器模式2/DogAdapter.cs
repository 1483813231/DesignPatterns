using System;
using Microsoft.SqlServer.Server;

namespace _007适配器模式2
{
    public class DogAdapter:Dog,Robot
    {
        //适配器类
        public void Cry()
        {
            Console.WriteLine("机器人模仿！");
            base.Wang();
        }

        public void Move()
        {
            Console.WriteLine("机器人模仿！");
            base.Run();
        }
    }
}