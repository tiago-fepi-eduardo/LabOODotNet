using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp02
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.Write("I can fly with wings! FlyNoWay");
        }
    }
}
