namespace _013命令模式
{
    public abstract class AbstractCommand
    {
        protected Television Tv;

        public AbstractCommand(Television Tv)
        {
            this.Tv = Tv;
        }
        public abstract void Excute();
    }
}