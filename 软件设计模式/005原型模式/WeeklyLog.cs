using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005原型模式
{
    public class WeeklyLog:BaseWeeklyLog,ICloneable
    {
        //private string name;
        //private string data;
        //private string content;
        
        public string Name
        {
            set { this.name = value; }
            get { return name; }
        }
        public string Data
        {
            set { this.data = value; }
            get { return data; }
        }
        public string Content
        {
            set { this.content = value; }
            get { return content; }
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
