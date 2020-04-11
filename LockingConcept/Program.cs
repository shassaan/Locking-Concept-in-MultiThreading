using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LockingConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Resource resource = new Resource();
            for (int i = 10; i >=5 ; i--)
            {
                var v = i;
                var ts = new ThreadStart(delegate () {

                    resource.Calculate(v);
                });

                var t = new Thread(ts);
                t.Name = "P"+i;
                t.Start();

            }
            Console.ReadKey();     
        }
    }
}
