using System;

namespace _009装饰模式2
{
    public abstract class CipherDecorator : Cipher
    {
        protected Cipher cipher;

        public CipherDecorator(Cipher cipher)
        {
            this.cipher = cipher;
        }

        public abstract string encrypt(String plainText);

    }
}