/*
 C# e 3 ta builtin generic delegate ache:
 1. Func           ->  when method RETURNS A VALUE
 2. Action        -> when method IS VOID
 3. Predicate  -> when method RETURNS A BOOL VALUE 
 INFO: Method calling er 2 ta upay : 1. Using user defined delegate 2. Using predefined generic delegate
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace S_Delegate
    {
    class Sb_PredefinedDelegates
        {
        
        //Process-1,2
        ///Traditional Delegates
        public delegate double AddDelegate(double a, double b);
        public delegate void SubDelegate(double a, double b);
        public delegate bool CKNumDelegate(int n);
        
        
        //Process-1
        static double add(double a,double b)
            {
            return a + b;
            }
        static void sub(double a, double b)
            {
            Console.WriteLine(a - b);
            }
        static bool cknum(int n)
            {
            if (n % 2 == 0) return true;
            else return false;
            }
        

        ///Process-3
        //No method mane holo Anonymous Methods
        static void Main()
            {
            
            ///Process-1
            ///Traditional Delegates
            AddDelegate addDele = add; 
            SubDelegate subDele = sub; 
            CKNumDelegate ckDele = cknum;

            Console.WriteLine(addDele(4.6,4.4));
            subDele(4.5,4);
            Console.WriteLine(ckDele(5));
            

            /*
            ///Process-2
            ///Generic Delegates
            //Func<double,double,double> addFC = new Func<double, double, double> (add); 
            Func<double,double,double> addFC = add; // for add() method
            Action<double,double> subAC = sub; // for sub() method
            //Predicate<int> cknumPT = cknum; // for cknum() method
            Func<int,bool> cknumPT = cknum; // for cknum() method

            Console.WriteLine(addFC(4.6,4.4));
            subAC(4.5,4);
            Console.WriteLine(cknumPT(5));
            */

            /*
            ///Process-3
            ///Generic Delegates and anonymous methods 
            // for add() method
            Func<double, double, double> addFC = (a, b) =>
              {
                  return a + b;
              };

            // for sub() method
            Action<double, double> subAC = (a, b) =>
             {
                 Console.WriteLine(a-b);
             };

            // for cknum() method
            Predicate<int> cknumPT = n =>
            {
              if (n % 2 == 0) return true;
              else return false;
            }; 

            
            // for cknum() method
            //Func<int,bool> cknumPT = n=> 
            //{
              //if (n % 2 == 0) return true;
              //else return false;
            //}; 
           

          Console.WriteLine(addFC(4.6,4.4));
          subAC(4.5,4);
          Console.WriteLine(cknumPT(5));
          */

            }
        }
    }
