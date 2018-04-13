using System;

namespace _009装饰模式2
{
    public class SimpleCipher:Cipher
    {
        public string encrypt(string planinText)
        {
            string str = "";
            for (int i = 0; i < planinText.Length; i++)
            {
                char ch = planinText[i];
                if (ch >='a' && ch <= 'z')
                {
                    ch = (char) (ch + 6);
                    if (ch > 'z') ch = (char) (ch - 26);
                    //if (ch < 'a') c += 26;
                    //Console.WriteLine(ch);
                }

                if (ch >= 'A' && ch <= 'Z')
                {
                    ch = (char)(ch + 6);
                    if (ch > 'Z') ch = (char)(ch - 26);
                }

                str += ch;
            }

            return str;
        }
    }
}