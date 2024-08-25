using System;
using System.Collections.Generic;
using System.Text;
namespace Collection
    {
    class Dc_GenericClassesAndMethods
        {
        /*
        ///Timeline-1 (overloading procecc)
        public static bool Comparing(int a,int b)
            {
            if (a == b) return true;
            else return false;
            }
        public static bool Comparing(float a, float b)
            {
            if (a == b) return true;
            else return false;
            }
        public static bool Comparing(string a, string b)
            {
            if (a == b) return true;
            else return false;
            }
        */

       /*
        ///Timeline-2 (Boxing/Unboxing process and not type safe)
        public static bool Comparing(object a, object b)
            {
            //if (a == b) return true;// "==" operator object compare korte pare na but korte parto jodi Comparing(dynamic a, dynamic b)
            //dynamic aa = a; dynamic bb = b;
            //if (aa == bb) return true; // akhon kaj korbe
            
            if (a.Equals(b)) return true;
            else return false;
            }
        */

        /*
        ///Timeline-3 (GenericMethod Process, type safe and noBoxing/Unboxing)
        public static bool Comparing<T>(T a, T b)
            {
            //if (a == b) return true;// "==" operator T typer operand e kaj kore na
            //dynamic aa = a; dynamic bb = b;
            //if (aa == bb) return true; // akhon kaj korbe
            if (a.Equals(b)) return true; 
            else return false;
            }
        */

        /*
        ///Timeline-4 (Generic Process, type safe and noBoxing/Unboxing)
        public static T add<T>(T a, T b)
            {
            //dynamic is used for determining the type on runtime
            dynamic num1 = a;
            dynamic num2 = b;
            return (num1 + num2);
            }
        public static T sub<T>(T a, T b)
            {
            //dynamic is used for determining the type on runtime
            dynamic num1 = a;
            dynamic num2 = b;
            return (num1 - num2);
            }
        */

        static void Main(string[] args)
            {
            Console.WriteLine("Generic Classes and Methods");
            Console.WriteLine("---------------------------------");
            /*
            ///Timeline-1
            Console.WriteLine(Comparing(12,2));
            Console.WriteLine(Comparing(12.5f, 12.5f));
            Console.WriteLine(Comparing("jitu", "eshita"));
            Console.WriteLine();
            */

            /*
            ///Timeline-2
            //version-1
            Console.WriteLine(Comparing(12, 2));
            Console.WriteLine(Comparing(12.5f, 12.5)); ///object compare korlo ar dekhlo object same na bes false, no value comparsion
            Console.WriteLine(Comparing("Eshita", "eshita"));
            Console.WriteLine();
            //version-2
            Console.WriteLine(Comparing(12, 2));
            Console.WriteLine(Comparing(12.56f, 12.56f)); ///object compare korlo ar dekhlo object same so value comparsion must
            Console.WriteLine(Comparing("jitu", "eshita"));
            Console.WriteLine();
            */

            /*
            ///Timeline-3
            //version-1
            Console.WriteLine(Comparing(2, '2'));
            Console.WriteLine(Comparing(12.5f, 12.5));
            Console.WriteLine(Comparing("jitu", "Jitu"));
            Console.WriteLine();
            //version-2
            Console.WriteLine(Comparing<int>(2, 2)); //Console.WriteLine(Comparing<int>(2, 2.3));//show error
            Console.WriteLine(Comparing<double>(12.5, 12.5)); //
            Console.WriteLine(Comparing<string>("eshita", "eshita"));
            Console.WriteLine();
            */

            /*
            ///Timeline-4
            Console.WriteLine(add<int>(2, 2));
            Console.WriteLine(sub<int>(4, 2));
            Console.WriteLine(add<double>(2.4, 2.2));
            Console.WriteLine(sub<double>(4.4, 2.2));
            Console.WriteLine();
            */

            /*
            ///Timeline-5
            //version-1
            GenericClass<int> gn1 = new GenericClass<int>();
            Console.WriteLine(gn1.add(2, 2));
            Console.WriteLine(gn1.sub(4, 2));
            Console.WriteLine();
            //version-2
            GenericClass<double> gn2 = new GenericClass<double>();
            Console.WriteLine(gn2.add(2.4, 2.2));
            Console.WriteLine(gn2.sub(4.4, 2.2));
            Console.WriteLine();
            */
            } 
        }

    /*
    ///Timeline-5 (GenericClass Process, type safe and noBoxing/Unboxing)
    class GenericClass<T>
        {
        public T add(T a, T b)
            {
            //dynamic is used for determining the type on runtime
            dynamic num1 = a; 
            dynamic num2 = b;
            return (num1 + num2);
            }
        public T sub(T a, T b)
            {
            //dynamic is used for determining the type on runtime
            dynamic num1 = a;
            dynamic num2 = b;
            return (num1 - num2);
            }
        }
    */

    }
