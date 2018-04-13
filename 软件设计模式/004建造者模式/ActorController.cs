using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004建造者模式
{
    public class ActorController
    {
        public Actor Construct(ActorBuilder ab)
        {
            Actor actor;
            ab.BuildType();
            ab.BuildSex();
            ab.BuildHairstyle();
            ab.BuildFace();
            ab.BuildCostume();
            actor = ab.CreateActor();
            return actor;
        }
    }
}
