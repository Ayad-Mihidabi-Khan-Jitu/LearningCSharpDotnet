using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading
    {
    class Xc_PerformanceOfThreading
        {
        static void Task1(object n)
            {
            long count1 = 0; long nn = Convert.ToInt64(n);
            for (long i = 0; i <= nn; i++)
                {
                count1++;
                }
            Console.WriteLine(count1);
            }
        static void Task2(object n)
            {
            long count2 = 0; long nn = Convert.ToInt64(n);
            for (long i = 0; i <= nn; i++)
                {
                count2++;
                }
            Console.WriteLine(count2);
            }
        static void Main()
            {

            Thread t1 = new Thread(Task2);

            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();

            s1.Start();
            Task1(1000000000);
            s1.Stop();

            s2.Start();
            t1.Start(1000000000);
            s2.Stop();

            t1.Join();

            Console.WriteLine("Time taken by task1 using single thread: "+s1.ElapsedMilliseconds +"ms");
            Console.WriteLine("Time taken by task2 using multi thread: " + s2.ElapsedMilliseconds+"ms");


            }
        }
    }
