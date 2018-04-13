namespace _013命令模式
{
    public class TvOpenCommend:AbstractCommand
    {
        //private Television Tv;

        public TvOpenCommend(Television Tv) : base(Tv)
        {

        }
        public override void Excute()
        {
            Tv.OpenTv();
        }
    }
}