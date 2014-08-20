namespace DesignPatterns.Singleton
{
    public sealed class EagerSingleton
    {
        // Eager singleton
        public static readonly EagerSingleton Instance = new EagerSingleton();

        private EagerSingleton()
        {

        }
    }
}
