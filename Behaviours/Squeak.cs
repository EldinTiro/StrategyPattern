using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviours
{
    public class Squeak : QuackBehaviour
    {
        public void quack()
        {
            System.Console.WriteLine("SQUEAK!!!");
        }
    }
}