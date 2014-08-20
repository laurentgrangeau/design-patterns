namespace DesignPatterns.Singleton
{
    public sealed class LazySingleton
    {
        private static LazySingleton instance;

        private LazySingleton()
        {

        }

        public LazySingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LazySingleton();
                }

                return instance;
            }
        }
    }
}
