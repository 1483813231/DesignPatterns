using System;

namespace _013命令模式
{
    public class Television
    {
        public void OpenTv()
        {
            Console.WriteLine("电视机开机了");
        }

        public void CloseTv()
        {
            Console.WriteLine("电视机关闭了");
        }

        public void ChangeChannel()
        {
            Console.WriteLine("电视机换台了");
        }
    }
}