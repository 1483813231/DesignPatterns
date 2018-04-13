using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ActorBuilder myBuilder = new AngelBuilder();
            ActorController myActor = new ActorController();
            Actor actor=myActor.Construct(myBuilder);
            Console.WriteLine(actor.Type);
            Console.WriteLine(actor.Sex);
            Console.WriteLine(actor.Face);
            Console.WriteLine(actor.Constume);
            Console.WriteLine(actor.Hairstyle);

            Console.ReadKey();
        }
    }
}
