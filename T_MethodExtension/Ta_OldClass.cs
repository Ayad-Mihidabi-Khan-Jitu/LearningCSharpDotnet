using System;
namespace T_MethodExtension
    {
    class Ta_OldClass
        {
        internal void Method1()
            {
            Console.WriteLine("This is Method 1");
            }
        internal void Method2()
            {
            Console.WriteLine("This is Method 2");
            }
        static void Main(string[] args)
            {
            Console.WriteLine("This is old class");
            Ta_OldClass m = new Ta_OldClass();

            m.Method1();
            m.Method2();
            }
        }
    }
