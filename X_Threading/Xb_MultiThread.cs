/*
Operataing System : ata holo akta boro dhoroner software jete shokol software guli ke colaborate kore.
    Operating system e thake
     - Process
            - Thread
                -single or multi
#Prottekta application er akta thread theke jake bole MAIN THREAD 
    Every program by holo akta single threaded model.
Multiple Thread: it is time-sharing fact to obtain the maximum utilization of CPU. 
NOTE: akta thread start hoye complete hoye gele or start hole seta k punoray abar start kora jay na. mul kotha THREAD RESTARTING INVALID.
*/
using System;
using System.Threading;
namespace Threading
    {
    class Xb_MultiThread
        {
        /*
       ///Method 1
       static void Task1()
           {Console.BackgroundColor = ConsoleColor.Blue;

           Console.WriteLine("Task 1 Entered");
           for (int i = 1; i <= 100; i++)
               Console.WriteLine("Task 1: "+i);
           }

       ///Method 2
       static void Task2()
           {Console.BackgroundColor = ConsoleColor.Red;

           Console.WriteLine("Task 2 Entered");
           for (int i = 1; i <= 100; i++)
               {
               Console.WriteLine("Task 2: " + i);
               if (i == 25)
                   {
                   int t = 5000;
                   Console.WriteLine("Task 2 is sleeping for {0} seconds", (t/1000));
                   Thread.Sleep(t);
                   }
               }
           Console.WriteLine("Task 2 Finished");
           }

       ///Method 3
       static void Task3()
           {
           Console.BackgroundColor = ConsoleColor.Green;

           Console.WriteLine("Task 3 Entered");
           for (int i = 1; i <= 100; i++)
               Console.WriteLine("Task 3: " + i);
           Console.WriteLine("Task 3 Finished");
           }
       */
        
        ///Method 4
        static void Task4()
            {
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine("Task 4 Entered");
            for (int i = 1; i <= 100; i++)
                Console.WriteLine("Task 4: " + i);
            Console.WriteLine("Task 4 Finished");
            }
        ///Method 5
        static void Task5(object m)
            {Console.BackgroundColor = ConsoleColor.Red;
                int max = Convert.ToInt32(m);
            Console.WriteLine("Task 5 Entered");
            for (int i = 1; i <= max; i++)
                Console.WriteLine("Task 5: " + i);
            Console.WriteLine("Task 5 Finished");
            }
        

        /*
        ///Method 6
         void Display1 ()
            {
            //lock (this)
                //{
                Console.Write("My name is ");
                Thread.Sleep(5000);
                Console.WriteLine("Ayad Mihidabi Khan");
                //}
            }

        ///Method 7
        void Display2()
            {
            //lock (this)
                //{
                Console.Write("My name is ");
                Thread.Sleep(5000);
                Console.WriteLine("Doctor Eshita Khan");
                //}
            }
        */

        /*
        static int num1 = 0, num2 = 0;
        static void CountingNumbers1()
            {
            while (true)
                {
                num1++;
                }
            }

        static void CountingNumbers2()
            {
            while (true)
                {
                num2++;
                }
            }
        */

        static void Main(string[] args)
            {
            /*
            Thread T = Thread.CurrentThread;
            T.Name = "Main";
            Console.WriteLine("Current Thread Name : " + Thread.CurrentThread.Name+" Started");
            //Thread.Sleep(5000);

            ///3 threads in a main thread
            Thread t1 = new Thread(Task1); //invoked Task 1 in thread 1
            Thread t2 = new Thread(Task2); //invoked Task 2 in thread 2
            Thread t3 = new Thread(Task3); //invoked Task 3 in thread 3

            ///starting the 3 threads at a time and they will share their time of excution
            t1.Start();
            t2.Start();
            t3.Start();
            //t1.Suspend();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            //Console.WriteLine("Main Thread is finished");

            //Ekhane akta ghotona ache seta holo main thread o time share koretese
            //that is thread guli start hole main thread o tar sub thread gulir execute howar agei sesh hocche but ata amra chai na
            //amra chai sub thread guli sesh howar por main thread sesh houk;
            //t1.Join(); t2.Join(); t3.Join(); //tinta thread join kore dilam, main thread wait korbe jotokkhon na child thread sesh hoy;
            //main thread 3 second wait korbe thread 2 er jonno jodi 3 sec er moddhe thread 2 complete hoy taile to holoi ar na hole 3 sec por main thread tar execution complete kore felbe;
            t1.Join(); t2.Join(3000); t3.Join(); 
            Console.WriteLine("Main Thread is finished");

            /*
            ///Tasks directly on Main thread 
            //Task1();
            //Task2();
            //Task3();
            //Console.WriteLine("Task 1 2 3 Finished");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            */

            
            ///Now will see different overloads of Thread constructor
            ///1. ThreadStart(); //This is a delegate

            //ThreadStart threadStart = new ThreadStart(Task4); // dhoron 1
            //ThreadStart threadStart = delegate() { Task4(); }; // dhoron 2
            /* // dhoron 3
            ThreadStart threadStart = delegate() 
            { 
                for (int i = 1; i <= 100; i++)
                Console.WriteLine("Task 4: " + i);
            };
            */
            /*
            //ThreadStart threadStart = () => Task4(); // dhoron 4
            // dhoron 5
            ThreadStart threadStart = () => 
                {   
                    for (int i = 1; i <= 100; i++)
                    Console.WriteLine("Task 4: " + i);
                };
            
            //Thread t4 = new Thread(threadStart);
            //t4.Start();
            */

            ///2. ParameterizedThreadStart(); This is a delegate
            //Oporer ThreadStart er motoi 5 rokom vabe thread start kora jay but akhne simplicityr jonno 2 ta dekhalam

            //Thread t5 = new Thread(Task5);
            //t5.Start(50);

            //ParameterizedThreadStart parameterizedThread = new ParameterizedThreadStart(Task5);
            //Thread t5 = new Thread(parameterizedThread);
            //t5.Start(51);
            //t5.Start("51"); //restart invalid
            //t5.Start('5');
            //t5.Start('a');
            //t5.Start("ab"); // runtime error asbe "ParameterizedThreadStart" type safe na jar jonno "string" theke int convert ghotona ghotbe na
           

            /*
            ///Akhon amra dekhbo kivabe akta method lock kora jay akta thread er jonno, 
            ///method lock kore dile oi method er jonno je thread se chara arkew enter korte pare na
            MultiThreading theadLock1 = new MultiThreading();
            Thread d1 = new Thread(theadLock1.Display1);
            Thread d2 = new Thread(theadLock1.Display2);
            d1.Start();
            d2.Start();
            */

            /*
            ///Akhon amra dekhbo kivabe thread er moddhe priority set kora jay, 
            ///prority set korar uddessho holo jodi amon hoy je kono akta method er onk kaj korte hobe
            Console.WriteLine("Main thread Started");
            Thread p1 = new Thread(CountingNumbers1);
            Thread p2 = new Thread(CountingNumbers2);

            ///By default prority Normal thake jar jonno count er value onekta soman soman e thake.
            //p1.Priority = ThreadPriority.Highest; // tar mane p1 thread beshi somoy consume korbe CPU er kach theke
            //p2.Priority = ThreadPriority.Lowest; // tar mane p2 thread kom somoy consume korbe CPU er kach theke

            Console.WriteLine("Thread 1 started");
            p1.Start();
            Console.WriteLine("Thread 1 ended");

            Console.WriteLine("Thread 2 started");
            p2.Start();
            Console.WriteLine("Thread 2 ended");

            Console.WriteLine("Main thread going to sleep for 3 seconds");
            Thread.Sleep(3000);
            Console.WriteLine("Main thread woke up");

            p1.Abort();
            p2.Abort();

            p1.Join(); 
            p2.Join();

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine("Main thread ended");
            */
            }
        }
    }
