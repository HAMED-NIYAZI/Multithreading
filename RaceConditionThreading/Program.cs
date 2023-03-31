using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RaceConditionThreading
{
    public class Test
    {
        public void Calculation()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(new Random().Next(5));
                Console.Write(" {0},", i);
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            Thread[] tr = new Thread[5];

            for (int i = 0; i < 5; i++)
            {
                tr[i] = new Thread(new ThreadStart(t.Calculation));
                tr[i].Name = String.Format("Working Thread: {0}", i);
            }

            //Start each thread  
            foreach (Thread x in tr)
            {
                x.Start();
            }
            Console.ReadKey();
        }
    }
}
