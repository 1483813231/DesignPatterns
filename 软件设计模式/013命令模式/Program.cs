using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013命令模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Television Tv=new Television();
            TvCloseCommend tvCloseCommend = new TvCloseCommend(Tv);
            TvOpenCommend tvOpenCommend = new TvOpenCommend(Tv);
            TvChangeChannelCommend tvChangeChannelCommend = new TvChangeChannelCommend(Tv);
            Controler myControler = new Controler(tvCloseCommend, tvOpenCommend, tvChangeChannelCommend);
            myControler.Open();
            myControler.ChangeChannel();
            myControler.Close();
            Console.ReadKey();
        }
    }
}
