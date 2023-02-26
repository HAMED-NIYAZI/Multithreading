using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleThreadCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Thread t1 = new Thread(() => myFun("t1"));
            Thread t2 = new Thread(() => myFun("t2"));
            Thread t3 = new Thread(() => myFun("t3"));
            Thread t4 = new Thread(() => myFun("t4"));
            Thread t5 = new Thread(() => myFun("t5"));
            Thread t6 = new Thread(() => myFun("t6"));
            Thread t7 = new Thread(() => myFun("t7"));
            Thread t8 = new Thread(() => myFun("t8"));
            Thread t9 = new Thread(() => myFun("t9"));
            Thread t10 = new Thread(() => myFun("t10"));

            t1.IsBackground = true;
            t2.IsBackground = true;
            t3.IsBackground = true;
            t4.IsBackground = true;
            t5.IsBackground = true;
            t6.IsBackground = true;
            t7.IsBackground = true;
            t8.IsBackground = true;
            t9.IsBackground = true;
            t10.IsBackground = true;
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();
            t7.Start();
            t8.Start();
            t9.Start();
            t10.Start();

            Console.WriteLine("Main thread Running");
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
        }

        public static Task myFun(string threadName)
        {
           // Task.Delay(1000);
      Thread.Sleep(1000);
            Console.WriteLine($"Running other Thread {threadName}");
            return Task.CompletedTask;
        }
    }
}
