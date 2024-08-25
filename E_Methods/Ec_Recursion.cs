using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
    {
    class Ec_Recursion
        {
        static int Factrorial(int n) /// 3! = 3*2*1 = 3*(3-1)!
            {
            int result;
            if (n >= 1) ///recursive condition 3! = 3*2! 
                {
                result = n* Factrorial(n-1);
                return result;
                }
            else ///recursive conditionn when 0! = 1  
                {
                return 1;
                }
            }

        static int Fibonacchi(int n)
            {
            int result; ///0 1 1 2 3 5 
            if (n >= 3) ///recursive condition fib 3 = 3-1 + 3-2 = 3 
                {
                result = Fibonacchi(n - 1) + Fibonacchi(n - 2);
                return result;
                }
            else if(n==2)
                {
                return 1;
                }
            else 
                {
                return 0;
                }
            }
        public static void Main()
            {
            Console.WriteLine(Factrorial(4)); 
            Console.WriteLine(Fibonacchi(5)); 
            }
            }
    }
