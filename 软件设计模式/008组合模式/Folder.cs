using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008组合模式
{
    public class Folder:AbstractFile
    {
        private List<AbstractFile> list=new List<AbstractFile>();
        private string name;

        public Folder(string name)
        {
            this.name = name;
        }
        public override void Add(AbstractFile element)
        {
            list.Add(element);
        }
        public override void Remove(AbstractFile element)
        {
            list.Remove(element);
        }
        public override void display()
        {
            foreach(AbstractFile temp in list)
            {
                temp.display();
            }
        }
    }
}
