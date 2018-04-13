namespace _010外观模式
{
    public class EncryptFacade
    {
        private FileReader myFileReader;
        private CipherMachine mycCipherMachine;
        private FileWrite myFileWrite;

        public EncryptFacade()
        {
            myFileReader = new FileReader();
            mycCipherMachine = new CipherMachine();
            myFileWrite = new FileWrite();
        }

        public void FileEncrypt(string path)
        {
            string text1 = myFileReader.read(path);
            string text2 = mycCipherMachine.Encrypt(text1);
            myFileWrite.Write(path, text2);
        }
    }
}