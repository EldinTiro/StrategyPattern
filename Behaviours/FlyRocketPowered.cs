using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class FlyRocketPowered : FlyBehaviour
    {
        public void fly()
        {
            System.Console.WriteLine("LOOK! I can now fly... using a ROCKET!");
        }
    }
}