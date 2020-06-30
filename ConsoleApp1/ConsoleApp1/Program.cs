using ConsoleApplication1;
using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Performing some task... ");
            using (var progress = new ProgressBar())
            {
                for (int i = 0; i <= 1000; i++)
                {
                    progress.Report((double)i / 100);
                    Thread.Sleep(20);
                }
            }
            Console.WriteLine("Done.");
        }
    }
}