/*
 Tuple er maddhome amra akta method theke ekhadhik return pete pari 
*/
using System;
namespace Tuples
    {

    class Fd_TupleClass
        {
        /*
      ///Using TupleClass
      Tuple<int,int> AdditionMultiplication(int a, int b)
          {
          int add = a + b;
          int mul = a * b;
          Tuple<int, int> Tuaddmul = Tuple.Create(add, mul);
          return Tuaddmul;
          }
        */

        /*
        ///Using tothagotito methods kintu ata implicit tuple
        (int, int) AdditionMultiplication(int a, int b)
            {
            int add = a + b;
            int mul = a * b;
            return (add,mul);
            }
        */

        
        ///Using tothagotito methods kintu ata implicit tuple with name of the elements
        (int readd, int remul) AdditionMultiplication(int a, int b)
            {
            int add = a + b;
            int mul = a * b;
            return (add, mul);
            }
        

        static void Main(string[] args)
            {
            /*
            ///Tuple in C# prior 7.0
            TupleClass ob = new TupleClass();
            Console.WriteLine("Tuple in C# prior 7.0");
            Tuple <int,int> Tuob = ob.AdditionMultiplication(2, 3);
            Console.WriteLine(Tuob);
            Console.WriteLine(Tuob.Item1);
            Console.WriteLine(Tuob.Item2);
            */

            /*
            //Tuple in C# 7.0
            TupleClass ob1 = new TupleClass();
            Console.WriteLine("Tuple in C# 7.0");
            var addmul = ob1.AdditionMultiplication(2, 3);
            Console.WriteLine(addmul);
            Console.WriteLine(addmul.Item1);
            Console.WriteLine(addmul.Item2);
   
            //Tuple in C# 7.0
            TupleClass ob2 = new TupleClass();
            Console.WriteLine("Tuple in C# 7.0");
            var (addi,mult) = ob2.AdditionMultiplication(2, 3);
            Console.WriteLine(addi);
            Console.WriteLine(mult);
            */

            //Tuple in C# 7.0 with element name
            Fd_TupleClass ob3 = new Fd_TupleClass();
            Console.WriteLine("Tuple in C# 7.0");
            var admul = ob3.AdditionMultiplication(2, 3);
            Console.WriteLine(admul);
            Console.WriteLine(admul.readd);
            Console.WriteLine(admul.remul);
            Console.WriteLine(admul.Item1);
            Console.WriteLine(admul.Item2);

            var (a,b) = ob3.AdditionMultiplication(2, 3);
            Console.WriteLine(a);
            Console.WriteLine(b); 
            }
        }
    }
