using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackgroundThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(myFun);
            t.Name = "Thread1";
            t.IsBackground = true;
            t.Start();
            Console.WriteLine("Main thread Running");
        }

        static void myFun()
        {
            Console.WriteLine("Thread {0} started", Thread.CurrentThread.Name);
            Thread.Sleep(2000);
            Console.WriteLine("Thread {0} completed", Thread.CurrentThread.Name);
        }
    }
}
