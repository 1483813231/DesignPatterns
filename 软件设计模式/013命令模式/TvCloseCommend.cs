namespace _013命令模式
{
    public class TvCloseCommend:AbstractCommand
    {
        public TvCloseCommend(Television Tv) : base(Tv)
        {

        }

        public override void Excute()
        {
            Tv.CloseTv();
        }
    }
}