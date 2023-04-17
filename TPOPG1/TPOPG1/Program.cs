using System;
using System.Threading;
using System.Diagnostics;


namespace TPOPG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a stop watch 
            Stopwatch mywatch = new Stopwatch();
            Console.WriteLine("Threat Pool Executeion");

            
            mywatch.Start();


            //Calling method
            ProcessWithThreadPoolMethod();

            // Stops stopwatch
            mywatch.Stop();

            // Counts ticks to perform code execution for threadpool
            Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + mywatch.ElapsedTicks.ToString());
            mywatch.Restart();
            Console.WriteLine("Thread Execution");

            // Counts ticks to perform code execution for thread
            mywatch.Start();
            ProcessWithThreadMethod();
            mywatch.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + mywatch.ElapsedTicks.ToString());

            Console.ReadKey();
        }

        // 4 for loops that the code have to pass through
        static void Process(object callBack)
        {
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 100000; j++)
                {
                    for (int n = 0; n < 100000; n++)
                    {
                        for (int k = 0; k < 100000; k++)
                        {
                        }
                    }
                }
            }

        }

        // Method with the Thread Process
        static void ProcessWithThreadMethod()
        {
            for (int i = 0; i <= 1000; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
            }
        }

        // Method with the Threadpool Process
        static void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i <= 1000; i++)
            {
                ThreadPool.QueueUserWorkItem(Process);
            }
        }
    }
}
