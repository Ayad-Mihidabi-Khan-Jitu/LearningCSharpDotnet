using System;

namespace Constructor
{
    public class ImplecitConstructor
    {
        string name;
        int battarybackup;
        bool controllable;
        string feature;
        
        //Default constructor (bolod constructor)
     
        ImplecitConstructor(){
            string name;
            int battarybackup;
            bool controllable;
            string feature;
            }
        
        
        /*
        //explecit constructor (intelligent constructor)
        ImplecitConstructor(string s, string f, bool t, int n)
            {
              name = s;
             battarybackup = n;
             controllable = t;
             feature = f;
            }
        */
        
        public static void Main(string[] args)
        {
            ImplecitConstructor robot = new ImplecitConstructor();
            //Constructor.ImplecitConstructor tom = new Constructor.ImplecitConstructor(); //valid
            // ImplecitConstructor tom = new Constructor.ImplecitConstructor(); //also valid
            
            //jokhon default constructor call kore robot object banailam tokhon ai obj er jonno shob default value dia initialize
            Console.WriteLine("This is "+robot.name);
            Console.WriteLine(robot.feature);
            Console.WriteLine("This is kotha shone "+robot.controllable);
            Console.WriteLine("Battary backup "+robot.battarybackup+"hours");
            

            /* 
            //after assigning value on the perticular obj to its variables
            robot.name = "Tom";
            robot.feature = "He takes care of Jerry";
            robot.controllable = true;
            robot.battarybackup = 12;
            
            Console.WriteLine("This is "+robot.name);
            Console.WriteLine(robot.feature);
            Console.WriteLine("This is kotha shone "+robot.controllable);
            Console.WriteLine("Battary backup "+robot.battarybackup+"hours");
            */

            /*
            ImplecitConstructor robot = new ImplecitConstructor("Tom", "He takes care of Jerry", true,12);
            Console.WriteLine("This is "+robot.name);
            Console.WriteLine(robot.feature);
            Console.WriteLine("This is kotha shone "+robot.controllable);
            Console.WriteLine("Battary backup "+robot.battarybackup+" hours");
            */
            }

    }

}
