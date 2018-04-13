using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008组合模式
{
    public abstract class AbstractFile
    {
        public abstract void Add(AbstractFile element);
        public abstract void Remove(AbstractFile element);
        public abstract void display();
        
    }
}
