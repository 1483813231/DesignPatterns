using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004建造者模式
{
    public class Actor
    {
        private string type;
        private string sex;
        private string face;
        private string costume;
        private string hairstyle;
        public string Type { set; get; }
        public string Sex { set; get; }
        public string Face { set; get; }
        public string Constume { set; get; }
        public string Hairstyle { set; get; }

    }
}
