﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004建造者模式
{
    public class AngelBuilder:ActorBuilder
    {
        public override void BuildType()
        {
            this.actor.Type = "神仙姐姐";
            //throw new NotImplementedException();
        }
        public override void BuildSex()
        {
            this.actor.Sex = "女人";
            //throw new NotImplementedException();
        }
        public override void BuildFace()
        {
            this.actor.Face = "倾国倾城";
            //throw new NotImplementedException();
        }
        public override void BuildCostume()
        {
            this.actor.Constume = "素衣长裙";
            //throw new NotImplementedException();
        }
        public override void BuildHairstyle()
        {
            this.actor.Hairstyle = "长发飘飘";
            //throw new NotImplementedException();
        }
        public override Actor CreateActor()
        {
            return this.actor;
        }
    }
}
