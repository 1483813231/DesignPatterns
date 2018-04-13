using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010外观模式
{
    class Program
    {
        static void Main(string[] args)
        {
            EncryptFacade myEncryptFacade=new EncryptFacade();
            myEncryptFacade.FileEncrypt(@"E:\vs workspace\c#\text.txt");
            Console.ReadKey();
        }
    }
}
