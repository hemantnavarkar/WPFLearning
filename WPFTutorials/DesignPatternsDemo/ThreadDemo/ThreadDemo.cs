namespace DesignPatternsDemo.ThreadDemo
{
    /// <summary>
    /// Thread Demo class
    /// </summary>
    internal class ThreadDemo
    {
        /// <summary>
        /// This prints 1-1000 numbers
        /// </summary>

        // public AutoResetEvent resetEvent = new AutoResetEvent(false);
        private object threadlock = new object();
        public void PrintNumbers()
        {
            lock (threadlock)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}");

                ////Parallel.For(1, 1000, (x) =>
                ////{
                ////    Console.Write(x);
                ////});


                for (int i = 0; i < 1000; i++)
                {
                    Console.Write(i);
                    // Thread.Sleep(10);
                }

                Console.WriteLine();
            }

            // resetEvent.Set();
        }
    }
}
