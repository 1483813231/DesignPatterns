using System.Diagnostics;

namespace _010外观模式
{
    public class CipherMachine
    {
        public string Encrypt(string plainText)
        {
            char ch;
            string text = null;
            for (int i = plainText.Length-1; i >-1; i--)
            {
                ch = plainText[i];
                text += ch;
            }

            return text;
        }
    }
}