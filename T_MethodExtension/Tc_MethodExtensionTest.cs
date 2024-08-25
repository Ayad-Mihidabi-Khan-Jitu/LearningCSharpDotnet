using System;
namespace T_MethodExtension
    {
    class Tc_MethodExtensionTest
        {
        static void Main(string[] args)
            {
            ///Method Extension on classes
            Ta_OldClass old = new Ta_OldClass();
            old.Method1();
            old.Method2();
            old.Method3();
            old.Method4(4);

            ///Method Extension on structure
            int n = 5;
            long f = n.Factorial();
            Console.WriteLine("Factorial of {0} is {1}",n,f);

            int a=9, b=9, sum = 0;
            sum = sum.AddAB(a,b);
            Console.WriteLine("{0} + {1} = {2}",a,b,sum);

            ///Method Extension on sealed classes
            string s =" mY name is Jitu ";
            Console.WriteLine("Orginal String : "+s);
            string ps = s.ToProper();
            Console.WriteLine("Proper Case    :  "+ps);

            /*
            ///Have a look of these Trim()
            string p = "   jitu is   ";
            Console.WriteLine(p.Trim());
            Console.WriteLine(p.TrimStart());
            Console.WriteLine(p.TrimEnd());
            */
            }
        }
    }
