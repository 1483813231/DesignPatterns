using System;
using System.IO;

namespace _010外观模式
{
    public class FileReader
    {
        public string read(string path)
        {
            StreamReader s = File.OpenText(path);
            string text = null;
            while ((text = s.ReadLine()) == null) { }
            s.Close();
            //Console.WriteLine(text);
            //Console.ReadKey();
            return text;
        }
    }
}