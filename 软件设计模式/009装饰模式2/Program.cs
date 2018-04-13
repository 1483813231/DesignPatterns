using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009装饰模式2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "abcd";
            Cipher cipher=new SimpleCipher();
            string result=cipher.encrypt(text);
            ComplexCipher complex=new ComplexCipher(cipher);
            string result1=complex.encrypt(text);
            Console.WriteLine("result:" + result);
            Console.WriteLine("result1:" + result1);
            Console.ReadKey();
        }
    }
}
