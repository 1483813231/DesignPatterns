using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            WeeklyLog week = new WeeklyLog();
            week.Name = "tom";
            week.Data = "第一周";
            week.Content = "工作进度即将完成";
            WeeklyLog obj = (WeeklyLog)week.Clone();
            Console.WriteLine("姓名：" + week.Name + "\n时间：" + week.Data + "\n内容：" + week.Content);
            Console.WriteLine("姓名：" + obj.Name + "\n时间：" + obj.Data + "\n内容：" + obj.Content);
            if (obj == week) ;
            Console.WriteLine("true");
            Console.ReadKey();
        }
    }
}
