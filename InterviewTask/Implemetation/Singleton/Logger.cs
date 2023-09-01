namespace InterviewTask.Implemetation.Singleton
{
    /// <summary>
    /// Sealed class can be inherited
    /// </summary>
    public sealed class Logger
    {
        private static object threadSyncLogger = new object();
        private Logger()
        {

        }

        public static Logger Logger_Instance
        {
            get
            {
                lock (threadSyncLogger)
                {
                    logger = new Logger();
                }

                return logger;
            }
        }

        private static Logger? logger;

        public void Log()
        {
            Console.WriteLine("Log");
        }
    }
}
