namespace InterviewTask.Implemetation.Singleton
{
    /// <summary>
    /// Sealed class can be inherited
    /// </summary>
    public sealed class Logger
    {
        private static object threadSyncLogger = new object();

        /// <summary>
        /// Making constructor, Private constructor will be there in caser of Single ton class.
        /// </summary>
        private Logger()
        {

        }

        /// <summary>
        /// The single ton logger instance
        /// </summary>
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
