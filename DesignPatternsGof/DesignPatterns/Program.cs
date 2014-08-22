namespace DesignPatterns
{
    using Decorator;
    using Template;
    using Singleton;
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Singleton
            var singleton = EagerSingleton.Instance;
            var lazySingleton = AnotherLazySingleton.Instance;

            Console.WriteLine("Calling test method");
            AnotherLazySingleton.TestMethod();
            Console.WriteLine("Called test method");

            // Decorator
            var blancSandwich = new BlancSandwich();
            var blancSaladeSandwich = new SaladeToppingDecorator(blancSandwich);
            var blancSaladeTomateSandwich = new TomateToppingDecorator(blancSaladeSandwich);

            var sandwichOneLine = new SaladeToppingDecorator(new TomateToppingDecorator(new BlancSandwich()));

            Console.WriteLine(sandwichOneLine.Make());

            // Template
            var commandeFrance = new CommandeFrance(1000);
            var commandeLuxembourg = new CommandeLuxembourg(1000);

            Console.WriteLine("Commande France TTC : " + commandeFrance.Calculer());
            Console.WriteLine("Commande Luxembourg TTC : " + commandeLuxembourg.Calculer());

            Console.ReadLine();
        }
    }
}
