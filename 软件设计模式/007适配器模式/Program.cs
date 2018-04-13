using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int key = 0;
            Dataopenration dataopenreation;
            QuickSort sortobj = new QuickSort();
            Binarysearch searchobj = new Binarysearch();
            //OpenrationAdapet adapet = new OpenrationAdapet(sortobj, searchobj);
            dataopenreation = new OpenrationAdapet(sortobj, searchobj);
            dataopenreation.Sort(array);
            dataopenreation.Search(array, key);
            Console.ReadKey();
        }
    }
}
