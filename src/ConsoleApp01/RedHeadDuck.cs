using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp01
{
    public class RedHeadDuck : Duck, IQuackable, IFlyable
    {
        public void Quack()
        {
            Console.Write("I can quack! RedHeadDuck \n");
        }

        public void Fly()
        {
            Console.Write("I can fly! RedHeadDuck \n");
        }
    }
}
