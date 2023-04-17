using System;
using System.Threading;

namespace Threadpooling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program tpd = new Program();

            for (int i = 0; i < 2; i++)
            {
                // Queued work assignments
                ThreadPool.QueueUserWorkItem(tpd.Task1);
                ThreadPool.QueueUserWorkItem(tpd.Task2);
            }

            Console.ReadKey();
        }

        // Method with a loop that runs a string

        public void Task1(object obj)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Task 1 is being executed");
            }
        }

        // Method with a loop that runs a string

        public void Task2(object obj)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Task 2 is being executed");
            }
        }


    }
}
