using System.IO;

namespace _010外观模式
{
    public class FileWrite
    {

        public void Write(string path,string encryptText)
        {
            //@"E:\vs workspace\c#\text.txt"
            FileStream fs = new FileStream(path,FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw=new StreamWriter(fs);
            sw.Write(encryptText);
            sw.Close();
            
        }
    }
}