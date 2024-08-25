/*
 Static keyword ti jokhon kono method er age use kora hoy tokhon seti "static mathod" 
 static method er boisosto static variable er motoi tobe aro kichu boisistho ache
Orthat : static mathod static variable directly use kore
                static mathod non-static vairable directly use korte pare na, object er maddhome pare
NOTE : non static method non static variable directly use kore and static variable k directly use korte pare 
When to use static mathod ??? jodi kono method toiri korte kono instance variable na lage taile  
 */
using System;
namespace Methods
    {
    class Eg_StaticMethod
        {
        int gu = 90;
        public static void Main()
            { 
            /*
            Manus s1 = new Manus();
            s1.nonStaicMethod();
            Manus.staticMethod();
           */

            
            //When to use static
            Manus m1 = new Manus();
            m1.name = "Jitu";
            Console.WriteLine("Name of the person "+m1.name);
            Console.Write("Current age ");
            Manus.calculateage(2020, 1996);

            //When to use static
            Manus m2 = new Manus();
            m2.name = "Eshita";
            Console.WriteLine("Name of the person "+m2.name);
            Console.Write("Current age ");
            Manus.calculateage(2020, 1997);
            
            }
        
        }
    
    class Manus
        {
        /*
        int nonStaicVariable=50;
        static int staicVariable=70;

        internal void nonStaicMethod()
            {
            Console.WriteLine("Non-static variable er vitore");
            Console.WriteLine("Aije nonStatic Variable "+ nonStaicVariable);
            Console.WriteLine("Aije static Variable " + staicVariable);
            Console.WriteLine();
            }
        internal static void staticMethod()
            {
            Console.WriteLine("Static variable er vitore");
            //non-static variable use kora jay na
            //Console.WriteLine("Aije nonStatic Variable " + nonStaicVariable);
            Console.WriteLine("Aije static Variable " + staicVariable);
            }
        */
   
        //When to use static mathod
        internal string name; 
        internal static void calculateage(int currentdate, int birthdate)
            {
            Console.WriteLine(currentdate-birthdate);
            }
        
        }
   
    }
