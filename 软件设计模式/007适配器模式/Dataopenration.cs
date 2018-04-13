using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007适配器模式
{
    interface Dataopenration
    {
        void Sort(int[] array);
        void Search(int[] array,int key);
    }
}
