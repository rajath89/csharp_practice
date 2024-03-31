class Singleton
    {
        static readonly Singleton _instance = new Singleton();

        public static Singleton Instance { get { return _instance; } }

        private Singleton()
        {
            Console.WriteLine("Instance Constructor");
        }

        static Singleton()
        {
            Console.WriteLine("Static Constructor");
        }
    }