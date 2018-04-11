using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp02
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.Write("I cant fly no wings! FlyNoWay");
        }
    }
}
