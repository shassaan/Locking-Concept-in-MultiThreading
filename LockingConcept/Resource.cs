using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LockingConcept
{
    class Resource
    {
        int box;
        //public static volatile object limit;
        public Resource()
        {
            box = 0;
        }

        public void Calculate(int limit)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} is Waiting at {DateTime.Now.Second}");
            Console.WriteLine();

            lock (this)
            {
                    box = 0;
                    for (int i = 1; i <= limit; i++)
                    {
                        box += i;
                        Console.WriteLine($"Calculating for {Thread.CurrentThread.Name}");
                        Thread.Sleep(1000);
                    }

                    Console.WriteLine($"{Thread.CurrentThread.Name}  Ans From {1} - {limit} is {box}");
                }
            
            
            Console.WriteLine();
            Console.WriteLine($"{Thread.CurrentThread.Name} is Released at {DateTime.Now.Second}");
            Console.WriteLine();

        }
    }
}
