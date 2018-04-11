using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BlueHeadDuck obj = new BlueHeadDuck();
            obj.Quack();
            obj.Swim();
            obj.Display();
            obj.Fly();

            RedHeadDuck obj2 = new RedHeadDuck();
            obj2.Quack();
            obj2.Swim();
            obj2.Display();
            obj2.Fly();

            PlasticDuck obj3 = new PlasticDuck();
            obj3.Swim();
            obj3.Display();


            Console.Read();
        }
    }
}
