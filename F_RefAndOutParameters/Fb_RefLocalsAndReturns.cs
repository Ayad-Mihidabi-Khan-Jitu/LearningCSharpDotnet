/*
ref keyword ti shudhu paramter hisebe use kora hoto
kintu akhon mane C# 7.0 te ati local variable e use kora jay abong return eo use kora jay
ref use korar uddhessho holo akta change korle jate onnotaw change hoy.
niche local vairable er khetre abong return er khetre dekhano holo.
*/
using System;
namespace RefAndOutParameters
    {
    class Fb_RefLocalsAndReturns
        {
        ///normal 
        public static string GetColor(string []s,int index)
            {
            return s[index];
            }

        ///ref
        public static ref string GetColor1(string[] s, int index)
            {
             return ref s[index];
            }
        static void Main()
            {
            
            ///ref as local vairable
            string[] Colors = { "Red", "Green", "Blue" };
            Console.WriteLine("The colors : "+String.Join(" ",Colors));
            string changedcolor = Colors[0];

            Console.WriteLine(changedcolor);
            Console.WriteLine(String.Join(" ", Colors));

            changedcolor = "black";
            Console.WriteLine(changedcolor);
            Console.WriteLine(String.Join(" ", Colors));

            //Local ref implemented
            string[] Colors1 = { "Red", "Green", "Blue" };
            Console.WriteLine("The colors : " + String.Join(" ", Colors1));
            ref string changedcolor1 = ref Colors1[0]; /// it will be a reference

            Console.WriteLine(changedcolor1);
            Console.WriteLine(String.Join(" ", Colors1));

            changedcolor1 = "black"; /// so value will be changed
            Console.WriteLine(changedcolor1);
            Console.WriteLine(String.Join(" ", Colors1));

            Colors1 = null;
            Console.WriteLine(changedcolor1); /// changedcolor1 will remain as before
            

            /*
            ///ref as return
            string[] Colors = { "Red", "Green", "Blue" };
            Console.WriteLine("The colors : " + String.Join(" ", Colors));
            string color = GetColor(Colors, 1);
            Console.WriteLine(color);

            color = "black";
            Console.WriteLine("The colors : " + String.Join(" ", Colors));
            Console.WriteLine(color);
            
            //return ref implemented
            string[] Colors1 = { "Red", "Green", "Blue" };
            Console.WriteLine("The colors : " + String.Join(" ", Colors1));
            ref string color1 = ref GetColor1(Colors1, 1); /// it will be a reference
            Console.WriteLine(color1);

            color1 = "black";
            Console.WriteLine("The colors : " + String.Join(" ", Colors1)); /// so value will be changed
            Console.WriteLine(color1);
            */
            }
        }
    }
