/*
# We will use .net framework project for this project because "thread.Abort()" method ti .net core e nai 
Threading .Net framework er 3.5 e release hoyeche.
Prottekta program e akta thread thake seta holo main thread. 
By default prottek ra program single threaded hoye thake. 
*/

using System;
using System.Threading;
namespace Threading
    {
    class Xa_SingleThread
        {
        static void Task1()
            {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nTask 1");
            for (int i = 1; i <= 50; i++)
                Console.Write(i + " ");
            }
        static void Task2()
            {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\nTask 2");
            for (int i = 1; i <= 50; i++)
                {
                Console.Write(i + " ");
                if (i == 25)
                    {
                    //Console.Write("sleeping for 5 second ");
                    //Thread.Sleep(5000);
                    }
                }
            }

        static void Task3()
            {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTask 3 : ");
            for (int i = 1; i <= 50; i++)
                Console.Write(i + " ");
            }

        static void Main(string[] args)
            {
            Thread T1 = Thread.CurrentThread;
            T1.Name = "Main";
            Console.WriteLine("Current Thread Name : " + Thread.CurrentThread.Name);

            /*
            //CurrentThread is a static property tai akta class er jonno thread atka nam e thakbe
            T1.Name = "Main";
            Console.WriteLine("Current Thread Name : " + Thread.CurrentThread.Name);
            */

            Task1();
            Task2();
            Task3();



            Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
