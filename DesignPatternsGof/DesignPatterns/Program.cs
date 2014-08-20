namespace DesignPatterns
{
    using Decorator;
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
            Console.ReadLine();
        }
    }
}
