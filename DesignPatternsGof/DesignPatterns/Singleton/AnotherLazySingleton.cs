namespace DesignPatterns.Singleton
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class AnotherLazySingleton
    {
        private static readonly Lazy<AnotherLazySingleton> lazySingleton = new Lazy<AnotherLazySingleton>(() => new AnotherLazySingleton());

        public static AnotherLazySingleton Instance
        {
            get
            {
                Console.WriteLine("Before singleton retrieval");
                return lazySingleton.Value;
            }
        }

        private AnotherLazySingleton()
        {
            Console.WriteLine("I'm the ctor()");
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void TestMethod()
        {
            Console.WriteLine("I'm the test method");
        }
    }
}
