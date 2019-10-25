using System;
using System.Diagnostics;
using System.Threading;
using Core;

namespace TestConsole
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            //Display logging messages in console
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));

            new Thread(() =>
            {
                CPUCore.Start(tokenSource.Token);
            }).Start();

            Console.WriteLine("Press 'A' to abort");

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

                if (keyInfo.Key == ConsoleKey.A)
                {
                    tokenSource.Cancel();
                    break;
                }
            }
            
            Console.WriteLine("Terminated");
            Thread.Sleep(1000);

            Debug.Write("Terminated");
        }
    }
}
