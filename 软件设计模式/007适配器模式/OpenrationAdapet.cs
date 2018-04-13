using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007适配器模式
{
    public class OpenrationAdapet:Dataopenration
    {
        private QuickSort sortobj = new QuickSort();
        private Binarysearch searchobj = new Binarysearch();
        public void Sort(int[] array)
        {
            sortobj.Sort(array);
        }
        public void Search(int[] array, int key)
        {
            searchobj.Search(array, key);
        }

        public OpenrationAdapet(QuickSort sortobj,Binarysearch searchobj)
        {
            this.sortobj = sortobj;
            this.searchobj = searchobj;
        }
    }
}
