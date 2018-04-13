using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009装饰模式
{
    public abstract class Changer:Transform
    {
        private Transform transform;

        public Changer(Transform transform)
        {
            this.transform = transform;
        }
        public void move()
        {
        }

    }
}
