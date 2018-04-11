using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp02
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;

        public Duck() {
            Console.Write(":: Duck Family :: \n");
        }

        public void Swim()
        {
            Console.Write("I can swim! Duck \n");
        }

        public void Display()
        {
            Console.Write("I can show! Duck \n");
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }
    }
}
