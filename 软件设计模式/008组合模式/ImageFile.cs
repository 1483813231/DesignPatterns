using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008组合模式
{
    public class ImageFile:AbstractFile
    {
        private string name;
        public ImageFile(string name)
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
            Console.WriteLine("Image文件");
        }
    }
}
