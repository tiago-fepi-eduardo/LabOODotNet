using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp01
{
    public class BlueHeadDuck : Duck, IQuackable, IFlyable
    {
        public void Quack()
        {
            Console.Write("I can quack! BlueHeadDuck \n");
        }

        public void Fly()
        {
            Console.Write("I can fly! BlueHeadDuck \n");
        }
    }
}
