///C# does not support macros in preprocessors like C,C++
///So amra function create kore pari
//ja ja dekhbo: Console.WriteLine() -> cout()

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_CSharpCodingStandard
    {
    static class Ab_MacrosAndPreProcessors
        {
        public static void cout(this string str, params object[] args)
            {
            Console.WriteLine(str, args);
            }

        static void Main(string[] args)
            {
            Console.WriteLine("This is WriteLine() ");

            //1. Console.WriteLine() -> cout()
            cout("This is cout({0})", 1);
            }
        }
    }
