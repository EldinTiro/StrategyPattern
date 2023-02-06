using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class FlyWithWings: FlyBehaviour
    {
        public void fly(){
            Console.WriteLine("I am the duck who can fly with WINGS");
        }
    }
}