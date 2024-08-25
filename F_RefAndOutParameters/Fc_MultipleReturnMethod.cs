/*
 ref and out parameter guli method theke kono value baire pass korte bebohar hoy. 
 Etipurbe amra dekhechi je akta method er akta return e thakte pare
 C# er ref and out er maddhome amra akta method theke amra akadhik return er moto kaj korte pari
 ref and out er moddhe akta tofat ache seta holo:
    - out er khetre initialize kora lage na, initialize korle lav nai seta method er vitore jeye destroy hoye jay
    - out parameter gulite obossoi method er vitore value assign kore hobe      
    - ref er khetre initialize kora lage.
    - ref parameter gulite method er vitore value assign korlew hoy, tokhon ref paramter guli "0" return kore. 
NOTE : Tuple er maddhome amra akta method theke ekhadhik return pete pari 
*/
using System;
using System.Collections.Generic;
using System.Text;
namespace RefAndOutParameters
{
    class Fc_MultipleReturnMethod
     {
        /*
        ///tothagotito niom e amra akta method theke dui ta return pai na
        int AdditionMultiplication(int a, int b)
            {
            int add = a + b;
            int mul = a * b;
            return add;
            return mul;
            }
        */

        /*
        ///1. Using ref
        void AdditionMultiplication(int a, int b,ref int add,ref int mul)
            {
            add = a + b; // ref er khetre na dile 0
            mul = a * b; // ref er khetre na dile 0
            }
        */

        /*
        /// 2.Using out
        void AdditionMultiplication(int a, int b, out int add, out int mul)
            {
            add = a + b; // out er khetre must assign korte hobe
            mul = a * b; // out er khetre must assign korte hobe
            }
        */

        /*
        ///2.1 Using out method returns int
        int AddSubMul(int a, int b, out int add, out int sub)
            {
            add = a + b;
            sub = a - b;
            return a * b;
            }
        */

        static void Main()
        {
            Fc_MultipleReturnMethod ob = new Fc_MultipleReturnMethod();
            /*
            ///1. Using ref
            int num1 = 10, num2 = 2, add=100,mul=0;
            ob.AdditionMultiplication(num1, num2, ref add, ref mul);
            Console.WriteLine("Addition = " +add+" , "+"Multiplication "+mul);
           */

            /*
            ///2. Using out where method is void
           int num1 = 10, num2 = 2, add =100, mul=100; //out variable initialized
           ob.AdditionMultiplication(num1, num2, out add, out mul);
           Console.WriteLine("Addition = " +add+" , "+"Multiplication "+mul);
            
            int num3 = 10, num4 = 2; //out is variable initialized
            ob.AdditionMultiplication(num3, num4, out int add1, out int mul1);
            Console.WriteLine("Addition = " + add + " , " + "Multiplication " + mul);
            */

            /*
            //2.1 Using out where method is int hence we get three outout from the method!!!!!!
            int a = 9, b = 8;
            int multi = ob.AddSubMul(a, b, out int ad, out int su);
            Console.WriteLine("Addition = " + ad);
            Console.WriteLine("Substraction = " + su);
            Console.WriteLine("Multiplication " + multi);
            */



            }
        }
}
