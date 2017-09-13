namespace DesignPatterns.Construct.Singleton
{
    public class Logger
    {
        private static Logger _instance;
        private static readonly object _locker = new object();

        private Logger()
        { }

        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        if(_instance == null) // double check locking
                        {
                            _instance = new Logger();
                        }
                    }
                }

                return _instance;
            }
        }

        public void Log(string text)
        {
            // log something here
        }
    }
}
