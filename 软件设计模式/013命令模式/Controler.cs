namespace _013命令模式
{
    public class Controler
    {
        private TvCloseCommend tvCloseCommend;
        private TvOpenCommend tvOpenCommend;
        private TvChangeChannelCommend tvChangeChannelCommend;

        public Controler(TvCloseCommend tvCloseCommend, TvOpenCommend tvOpenCommend,
            TvChangeChannelCommend tvChangeChannelCommend)
        {
            this.tvChangeChannelCommend = tvChangeChannelCommend;
            this.tvCloseCommend = tvCloseCommend;
            this.tvOpenCommend = tvOpenCommend;
        }

        public void Open()
        {
            tvOpenCommend.Excute();
        }

        public void Close()
        {
            tvCloseCommend.Excute();
        }

        public void ChangeChannel()
        {
            tvChangeChannelCommend.Excute();
        }
    }
}