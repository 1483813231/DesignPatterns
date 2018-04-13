using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004建造者模式
{
    public abstract class ActorBuilder
    {
        public Actor actor = new Actor();
        public abstract void BuildType();
        public abstract void BuildSex();
        public abstract void BuildFace();
        public abstract void BuildCostume();
        public abstract void BuildHairstyle();
        public abstract Actor CreateActor();
    }
}
