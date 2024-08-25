/*
ref ar out duita parameter e value and reference pass kore
BUT only difference holo
 - ref parameter er khetre caller and function callee dui jaiga tei value change hoy
    -- callee theke caller value pass hoy at the same time caller theke callee value pass hoy
 - out parameter er khetre caller and function callee dui jaiga tei value change hoy 
    --caller theke callee value pass hoy
    --more specifically o just output dey, parameter holew kono input se nite pare na method call kora somoy 
         
 
*/
using System;
namespace RefAndOutParameters
    {
    class Fa_RefAndOut
        {
        /*
        void Display(int i)
            {
            i = 10;
            i = i + 10;
            }
        */

        /*
        void Display(ref int i)
            {
            i = i + 10;
            }
        */

        
        void Display(out int i)
            {
            i = 10;
            i = i + 10;
            }
        
        
        static void Main(string[] args)
            {
            
            Fa_RefAndOut ob1 = new Fa_RefAndOut();
            /*
            Console.WriteLine("Normal");
            int n = 10;
            Console.WriteLine(n);
            ob1.Display(n);
            Console.WriteLine(n);
            */

            /*
            Console.WriteLine("Ref");
            int n = 10;
            Console.WriteLine(n);
            ob1.Display(ref n);
            Console.WriteLine(n);
            */

            /*
            Console.WriteLine("Out");
            int n = 10;
            Console.WriteLine(n);
            ob1.Display(out n);
            Console.WriteLine(n);
            */

            /*
            Console.WriteLine("Out");
            ob1.Display(out int n);
            Console.WriteLine(n);
            */
            }
        }
    }
