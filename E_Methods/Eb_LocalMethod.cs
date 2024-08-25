/*
C# 7.0 er boisisto ata
Local Method : Main class er vitore e method define kora hole sei method k local method bole
 - local method er khetre kno object kore call kora lage na directly static er moto kore call kora jay.
 - local method k Main er baire access kora jay na.
 - local method e param,ref,out and generic use kora jay
NOTE : anonymous method o kintu main er vitore define kora hoto but nam bihin method
              kintu sekhane just normal paramter use kora jeto ["param,ref,out and generic" na]
 "params" is a keyword in C# jeta method paramter e use hoy jokhon parameter er shogkha ojana thakbe 
*/
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
namespace Methods
    {
    class Eb_LocalMethod
        {
        static void Main()
            {

            ///1. Local method
             int DisplayAdd(int a,int b)
                {
                return a + b;
                }
            int apb = DisplayAdd(1, 2); //calling here like a static method
            Console.WriteLine("a+b = "+apb);

            ///2. Local method with ref
            int DisplayAddSub(int a, int b,ref int ad,ref int su)
                {
                ad = a + b; // ref er khetre na dile 0
                su = a - b; // // ref er khetre na dile 0 
                return a * b;
                }
            int x = 12, y = 3, p = 0, q = 0; //ref er khetre ref variable guli must initialize korte hoy
            int mul = DisplayAddSub(x, y,ref p,ref q); //calling here like a static method
            Console.WriteLine("a+b = "+p+" a-b = "+q+" a*b = "+mul);

            ///3. Local method with out
            void DisplayMulDiv(int a, int b, out int mul, out int div)
                {
                mul = a * b; // out er khetre must assign korte hobe
                div = a / b; // out er khetre must assign korte hobe
                }
             DisplayMulDiv(4, 2,out int f,out int g); //calling here like a static method
             Console.WriteLine("a*b = "+f);
             Console.WriteLine("a/b = "+g);

            ///4. Local method with param
            void SeriesSum(params int[] n)
                {
                int sum = 0;
                foreach(int i in n)
                    {
                    sum = sum + i;
                    }
                Console.WriteLine("Sum of the numbers = " +sum);
                }
            SeriesSum(10, 20, 10);
            SeriesSum(10, 20, 10, 20);

            ///5. Local method with generic
            void Sum<Type>(Type a,Type b) ///"Type" just akta nam ata changable
                {
                dynamic variable1 = a;
                dynamic variable2 = b;
                Console.WriteLine(variable1+variable2);
                }
            Sum<int>(4, 5);
            Sum<double>(4.5, 5.6);
            Sum<string>("Jitu"," Khan");

            }
        }
    }
