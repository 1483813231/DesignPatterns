using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008组合模式
{
    public class TextFile:AbstractFile
    {
        private string name;
        public TextFile(string name)
        {
            this.name = name;
        }
        public override void Add(AbstractFile element)
        {
            
        }
        public override void Remove(AbstractFile element)
        {

        }

        public override void display()
        {
            Console.WriteLine("Text文件");
        }
    }
}
