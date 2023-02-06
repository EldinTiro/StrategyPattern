using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class FlyNoWay : FlyBehaviour
    {
        public void fly()
        {
            System.Console.WriteLine("I am NOT able to fly!");
        }
    }
}