/*
            Static Constructor                                                                  |                                               NonStatic Constructor 
            1. Main function call howar por e call hoy implicitly    1.  Main function call howar por jodi exciplitly call kori then execute hoy 
            2. Overloading allowed na                                                     2. Overloading possible
            3. jehetu overload nai so parameter e ney na                  3. jehetu overload hoy tar mane parameter ney
            4. static variable initialize korar jonno                             4. static / non static dui dhoroner variable e initialize kora jay 
 
*/
using System;
namespace Constructor
    {
    class Kf_StaticConstructor
        {
        int id;
        static string faculty;
        const string name = "jitu";

        Kf_StaticConstructor(int i,string f)
            {
            Console.WriteLine("This is NonStatic Constructor");
            this.id = i;
            faculty = f;
            }

        static Kf_StaticConstructor()
            {
            Console.WriteLine("This is static Constructor");
            faculty = "CSE";
            //id = 90; //can't initialize bacause it is nonstatic
            }
        void DisplayInfo()
            {
            Console.WriteLine("ID : "+this.id);
            Console.WriteLine("Faculty : "+faculty);
            }
        static void DisplayInfo1()
            {
            //Console.WriteLine("ID : " + this.id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Faculty : " + faculty);
            }

        public static void Main()
            {
            Console.WriteLine("Entering into the Main method");
            //StaticConstructor s1 = new StaticConstructor(28, "NFS");
            //s1.DisplayInfo();
            DisplayInfo1();

            }
        }
    }
