// See https://aka.ms/new-console-template for more information
using DesignPatternsDemo.ThreadDemo;
using System.Diagnostics;
using System.Threading;

Console.WriteLine("***********************Thread Demo");
ThreadDemo demo = new ThreadDemo();
Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();
// Sync Way
////demo.PrintNumbers();


////var threads = new Thread[100];
////for (int threadCounter = 0; threadCounter < 100; threadCounter++)
////{
////    Thread printerThread = new(new ThreadStart(demo.PrintNumbers))
////    {
////        Name = $"Thread{threadCounter}",
////        IsBackground = false
////    };

////    threads[threadCounter] = printerThread;
////    printerThread.Start();
////}



////foreach (var thread in threads.ToList())
////{
////    thread.Join();
////}

for (int threadCounter = 0; threadCounter < 100; threadCounter++)
{
    demo.PrintNumbers();
}


// demo.resetEvent.WaitOne();



stopwatch.Stop();
Console.WriteLine($"Hemant = {stopwatch.Elapsed}");
Console.ReadLine();