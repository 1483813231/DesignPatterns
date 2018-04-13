using System.Net.Mime;

namespace _009装饰模式2
{
    public class ComplexCipher:CipherDecorator
    {
        public ComplexCipher(Cipher cipher):base(cipher)
        {
        }

        public override string encrypt(string plainText)
        {
            string result = cipher.encrypt(plainText);
            result = this.reverse(result);
            return result;

        }

        private string reverse(string result)
        {
            string str = "";
            for (int i = result.Length-1; i > -1; i--)
            {
                //str += result.Substring(i - 1, i);
                str += result[i];
            }

            return str;
        }
    }
}