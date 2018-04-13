using System.Net.Security;

namespace _009装饰模式2
{
    public interface Cipher
    {
        string encrypt(string plainText);
    }
}