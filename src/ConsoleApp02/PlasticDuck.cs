﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp02
{
    public class PlasticDuck : Duck
    {
        public PlasticDuck()
        {
            flyBehavior = new FlyNoWay();
        }
    }
}
