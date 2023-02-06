using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Quack: QuackBehaviour
    {
        public void quack(){
            System.Console.WriteLine("QUACK QUACK QUACK!!!");
        }
    }
}