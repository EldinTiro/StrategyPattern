using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class Duck
    {
        public FlyBehaviour flyBehaviour;
        public QuackBehaviour quackBehaviour;
        public Duck(){
        } 

        public void setFlyBehaviour(FlyBehaviour fb){
            this.flyBehaviour = fb;
        }
        public void setQuackBehaviour(QuackBehaviour qb){
            this.quackBehaviour = qb;
        }
        public abstract void display();
        public void swim(){
            Console.WriteLine("All ducks can SWIM!");
        }
        public void perfromFly(){
            flyBehaviour.fly();
        }
        public void perfromQuack(){
            quackBehaviour.quack();
        }
    }
}