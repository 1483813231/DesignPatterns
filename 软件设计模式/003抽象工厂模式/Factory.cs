using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003抽象工厂模式
{
    public abstract class Factory
    {
        public abstract TV ProductionTV();
        public abstract AirCondition ProductionCondition();
    }
}
