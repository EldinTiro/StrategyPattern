using StrategyPattern;
internal class Program
{
    private static void Main(string[] args)
    {
        Duck mallardDuck = new MallardDuck();
        mallardDuck.display();
        mallardDuck.perfromFly();
        mallardDuck.perfromQuack();

        Duck rubberDuck = new RubberDuck();
        rubberDuck.display();
        rubberDuck.perfromFly();
        rubberDuck.perfromQuack();

        //We are now able to change the behaviours of the duck
        rubberDuck.setFlyBehaviour(new FlyRocketPowered());
        rubberDuck.perfromFly();

    }
}
