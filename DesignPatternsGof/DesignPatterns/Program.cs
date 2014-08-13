namespace DesignPatterns
{
    using DesignPatterns.Decorator;
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Singleton
            var singleton = Singleton.Singleton.Instance;

            // Decorator
            var blancSandwich = new BlancSandwich();
            var blancSaladeSandwich = new SaladeToppingDecorator(blancSandwich);
            var blancSaladeTomateSandwich = new TomateToppingDecorator(blancSaladeSandwich);

            Console.WriteLine(blancSaladeTomateSandwich.Make());
            Console.ReadLine();
        }
    }
}
