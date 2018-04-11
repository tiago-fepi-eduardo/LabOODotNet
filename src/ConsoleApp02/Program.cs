using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BlueHeadDuck obj = new BlueHeadDuck();
            obj.Swim();
            obj.Display();

            RedHeadDuck obj2 = new RedHeadDuck();
            obj2.Swim();
            obj2.Display();

            PlasticDuck obj3 = new PlasticDuck();
            obj3.Swim();
            obj3.Display();
            obj3.PerformFly();


            Console.Read();
        }
    }
}
