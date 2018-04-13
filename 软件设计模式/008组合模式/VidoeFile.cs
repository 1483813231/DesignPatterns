using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008组合模式
{
    public class VidoeFile:AbstractFile
    {
        private string name;
        public VidoeFile(string name)
        {
            this.name = name;
        }
        public override void Add(AbstractFile element)
        {
            throw new NotImplementedException();
        }
        public override void Remove(AbstractFile element)
        {
            throw new NotImplementedException();
        }
        public override void display()
        {
            Console.WriteLine("Vidoe文件");
        }
    }
}
