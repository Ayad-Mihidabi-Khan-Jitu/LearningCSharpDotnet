/*
Lets understand Literals !!
int i = 12 ;
here, "int" is datatype 
            "i" is vairabel name
            "12" is the value of variable "i"
            "12" is called is "int literal"
string s = "jitu" ;
here, "string" is datatype 
            "s" is vairabel name
            "jitu" is the value of variable "s"
            "jitu" is called is "string literal"

Literal bujhlam akta special reason e. Lets see why!!!
Literals can be of following types:
    1. Integer Literals       
    2. Floating-point Literals
    3. Character Literals
    4. String Literals
    5. Null Literals
    6. Boolean Literals
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace B_DataTypeAndVariableType
    {
    class Bc_LiteralsAndDigitSeparators
        {
        static void Main()
            {

            /* Digit Saperators*/
            int n = 1000000;
            Console.WriteLine(n);

            ///Bangladeshi style  10,00,000 
            n = 10_00_000;
            Console.WriteLine(n);

            ///International style  1,000,000
            n = 1_000_000;
            Console.WriteLine(n);

            /*Literals*/
            ///1.Integer Literals
            //Decimal literals -> contains : 0-9, starts except 0. 
            int a = 101;
            Console.WriteLine(a);

            //Octal literals -> contains : 0-6, starts with 0. 
            int b = 0101;
            Console.WriteLine(b);

            //Hexa-decimal literals -> contains : 0-9 and a-f, starts with 0x or  0X. 
            int c = 0X0101;
            int d = 0x0101;
            Console.WriteLine(c);
            Console.WriteLine(d);

            // Binary literals -> contains : 0s and 1s, starts except 0b. 
            int e = 0b101;
            Console.WriteLine(e);

            int f = 0b1000001;
            Console.WriteLine(f);
            Console.WriteLine(Convert.ToChar(f)); 
            Console.WriteLine(f.GetType());
            
            // int f = 0b102    //  invalid: 2 is not a binary digit
            // int f =  07778     // invalid: 8 is not an octal digit 
            // uint f = 045uu    // invalid: suffix (u) is repeated


            ///2. Floating-point Literals
            //Double literal -> contains integers and floating point ends with d or D
            double g = 3.14145; //by default it is double
            //double g = 3.14145d; 
            Console.WriteLine(g);

            //Float literal -> contains integers and floating point ends with f or F
            double h = 784f;
            Console.WriteLine(h);

            //Float literal -> contains integers and floating point ends with e or E
            double i = 312569E-5;  
            double j = 312569e6;     
            Console.WriteLine(i);
            Console.WriteLine(j);
            //double i = 125E;              // invalid: Incomplete exponent 
            //double k = .e45;               // invalid: missing integer or fraction


            ///3. Character Literals
            //Single quote -> using single quote
            char ch = 'a';
            Console.WriteLine(ch);

            //Unicode Representation -> using Unicode representation 
            // ‘\uxxxx’. Here xxxx represents 4 hexadecimal numbers.
            char ch1 = '\u0061';
            Console.WriteLine(ch1);

            //Escape Sequence -> using back slash '\'
            char ch2 = '\\'; //  \ character
            Console.WriteLine(ch2);
            char ch3 = '\''; //  ' character
            Console.WriteLine(ch3);
            char ch4 = '"'; //  " character
            Console.WriteLine(ch4);
            char ch5 = '\b'; //  Backspace
            Console.WriteLine(ch5);
            char ch6 = '\a'; //  Alert
            Console.WriteLine(ch6);
            char ch7 = '\n'; //  Backspace
            Console.Write(ch7);
            char ch8 = '\f'; //  Form Feed
            Console.WriteLine(ch8);
            char ch9 = '\r'; //  Carriage Return
            Console.WriteLine(ch9);
            char ch10 = '\v'; //  Vertical Tab
            Console.WriteLine(ch10);
            char ch11 = '\t'; //  Horizontal Tab
            Console.WriteLine(ch11);
            char ch12 = '\x12A'; //  Horizontal Tab
            Console.WriteLine(ch12);

            ///4. String Literals
            //enclosed in double quotes "" or @""
            string str = "jitu";
            Console.WriteLine(str);
            string str1 = @"jitu";
            Console.WriteLine(str1);

            ///4. Boolean Literals
            //Only two values are allowed for Boolean literals i.e. true and false.
            bool state = true;
            Console.WriteLine(state);
            bool state1 = false;
            Console.WriteLine(state1);

            }
  
        }
    }
