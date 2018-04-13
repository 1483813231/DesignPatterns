namespace _013命令模式
{
    public class TvChangeChannelCommend:AbstractCommand
    {
        public TvChangeChannelCommend(Television Tv): base(Tv)
        {

        }

        public override void Excute()
        {
            Tv.ChangeChannel();
        }
    }
}