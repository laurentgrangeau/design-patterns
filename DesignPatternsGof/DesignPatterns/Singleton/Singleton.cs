namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        public static readonly Singleton Instance = new Singleton();

        private Singleton()
        {

        }
    }
}
