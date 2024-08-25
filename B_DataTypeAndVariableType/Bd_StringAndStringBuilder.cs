/*
                    String                                                                                                  StringBuilder
1. Strings are immutable                                                           1. StringBuilder is mutable
- mane Sting class holo oporibortonio                                  - StringBuilder class holo poribortonio
- string er khetre value jotobar poriborton kora hoy        - StringBuilder er khetre value jotobar poriborton kora hoy 
   heep memory te totobar storage allocate kore                  oi ager memory address ei value over write hoy.
- jodi komshongkhok bar change hoy taile string             - jodi komshongkhok bar change hoy taile StringBuilder
- String jehetu copy create kore tai ata slower                 - StringBuilder jehetu copy create kore na tai ata faster
                                                                                                          - Capacity by default 16 byte. jodi size dei tahole limit er por seta double hoy
*/
using System;
using System.Diagnostics;
using System.Text;
namespace B_DataTypeAndVariableType
    {
    class Bd_StringAndStringBuilder
        {
        static void Main()
            {
            ///Akhon amra dekhbo string ar StringBuilder er memory fact
            string str = "Hello Jitu"; //str = "Hello Jitu" that is 1 copy
            str = str + " How are you"; //str = "Hello Jitu",  //str = "Hello Jitu How are you" that is 2 copies

            StringBuilder SB = new StringBuilder("Hello Jitu"); //SB = "Hello Jitu" that is 1 copy 
            SB.Append(" How are you"); //SB = "Hello Jitu How are you" that is 1 only copy

            ///Akhon amra dekhbo string ar StringBuilder er Capacity by default thake 16 byte
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Capacity of sb " + sb.Capacity);
            Console.WriteLine("Length of sb " + sb.Length);

            StringBuilder sb1 = new StringBuilder(20);
            Console.WriteLine("Capacity of sb1 " + sb1.Capacity);
            Console.WriteLine("Length of sb1 " + sb1.Length);

            sb1.Append("123456789abcdefghijkl");
            Console.WriteLine("Capacity of sb1 " + sb1.Capacity);
            Console.WriteLine("Length of sb1 " + sb1.Length);

            StringBuilder sb2 = new StringBuilder("123456789abcdefgh");
            Console.WriteLine("Capacity of sb2 " + sb2.Capacity);
            Console.WriteLine("Length of sb2 " + sb2.Length);

            ///Akhon amra dekhbo string ar StringBuilder er performance
            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();

            string s = "";
            //string s = null;
            //string s = "\0";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("s = ");
            s1.Start();
            for (int i = 1; i <= 10000; i++)
                {
                s = s + i + " ";
                }
            s1.Stop();
            Console.WriteLine(s);

            StringBuilder stb = new StringBuilder();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("stb = ");
            s2.Start();
            for (int i = 1; i <= 10000; i++)
                {
                stb.Append(i + " ");
                }
            s2.Stop();
            Console.WriteLine(stb);

            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Time taken by string s = " + s1.ElapsedMilliseconds + "ms");
            Console.WriteLine("Time taken by StringBuilder stb = " + s2.ElapsedMilliseconds + "ms");

            }
        }
    }

