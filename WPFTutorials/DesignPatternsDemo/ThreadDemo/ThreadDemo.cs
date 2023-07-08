using System;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatternsDemo.ThreadDemo
{
    /// <summary>
    /// Thread Demo class
    /// </summary>
    internal class ThreadDemo
    {

        public ThreadDemo()
        {
           _=  DoTaskRunAsyn();
        }

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
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write(i); ;
                }

                Console.WriteLine();
            }

            // resetEvent.Set();
        }

        public async Task DoTaskRunAsyn()
        {
            Console.WriteLine("Start");

            await Task.WhenAll(
                Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("First Long Run");
                    // throw new Exception("Fuck Off");
                }),

                Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("Second Long Run");
                }),

                Task.Run(() =>
              {
                  Thread.Sleep(2000);
                  Console.WriteLine("Third Long Run");
              })
            );
        }
    }
}

