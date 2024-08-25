/*
 Operator : Opetaror holo akta symbol seta akta specific methematical or logical manipulation perform kore
 C# er operator onk enrich rather than anyother language.
 List of  built-in operators in c#:
 1. Arithmetic Operators : +, -, *, /, %, ++, --      ; ata datatype onujayi arithmetic operation er value return kore
 2. Relational Operators : ==, !=, >, <, >=, <=      ; ata just true/false return kore
 3. Logical Operators : ||, &&, !                                ; ata just value nia kaj kore and and true/false return kore
 5. Bitwise Operators : |, &, ~, ^, >>, <<               ; ata datatype onujayi bitwise operation er value return kore
 6. Assignment Operators : =, +=, -=, *=, /=, %=, |=, &= ; ata datatype onujayi right side theke value ta left e assign kore 
 7. Misc Operators : sizeof(), typeof(), &(address operator), *(pointer), ? : (Conditional operator;if,else er compact), is, as 
 OPERATOR PRECWDENCE : 
 Unary            ---->   +, -, !, ~, ++, --, (type)*, &, sizeof()                  |
 Conditional ----> 	 ? :                                                                                |     ------>    Right to left
 Assignment ---->	=, +=, -=, *=, /=, %=,>>=, <<=, &=, ^=, |=        |
 Baki Sob       ----> Left to right 
 NOTE: Operand er opor base kore Opetaror 3 proker: 
               1. Uniary : 1 ta operand er opor operate kore -->  +,-,&,*,!,~   Example: +x, -y, 
               2. Binary :  2 ta operand er opor operate kore --> 
               3. Ternary : 
 */
using System;
namespace Operators
    {
    class Ca_BuiltinOperators
        {
        unsafe static void Main(string[] args)
            {
            Console.WriteLine("Operators in c#");
            Console.WriteLine("1. Arithmetic Operators : +, -, *, /, %, ++, --");
            int a = 10, b = 5, c = 2, d = 2;
            Console.WriteLine("a = {0},  b = {1}  a + b = {2}",a,b,a+b);
            Console.WriteLine("a = {0},  b = {1}  a - b = {2}",a,b,a-b);
            Console.WriteLine("a = {0},  b = {1}  a * b = {2}",a,b,a*b);
            Console.WriteLine("a = {0},  b = {1}  a / b = {2}",a,b,a/b);
            Console.WriteLine("a = {0},  b = {1}  a % b = {2}",a,b,a%b);

            Console.WriteLine("2.Relational Operators: ==, !=, >, <, >=, <=");
            if(c==d)
                Console.WriteLine("c = {0},  d = {1}  c ==  d", c, d);
            if (a != b)
                Console.WriteLine("a = {0},  b = {1}  a !=  b", a, b);
            if (a > b)
                Console.WriteLine("a = {0},  b = {1}  a >  b", a, b);
            if (b < a)
                Console.WriteLine("b = {0},  a = {1}  b <  a", b, a);
            if (a >= b)
                Console.WriteLine("a = {0},  b = {1}  a >=  b", a, b);
            if (c <= d)
                Console.WriteLine("c = {0},  d = {1}  c <=  d", c, d);
            
            Console.WriteLine("3. Logical Operators : ||, &&, !  ");
            if((a>b) && (c==d))
                Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}   (a>b)&&(c==d)",a,b,c,d);
            if ((a == b) || (c == d))
                Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}   (a==b)||(c==d)", a, b, c, d);
            if (!(a == b))
                Console.WriteLine("a = {0}, b = {1}   !(a==b)", a, b);

            Console.WriteLine("5.Bitwise Operators: |, &, ~, ^, >>, <<");
            Console.WriteLine("a = {0},  b = {1}  a | b that is a OR b = {2}", a, b,a|b);
            Console.WriteLine("a = {0},  b = {1}  a &  b that is a AND b = {2}", a, b, a&b);
            Console.WriteLine("a = {0},  ~a that is NOT a = {1}", a, ~a);
            Console.WriteLine("a = {0},  b = {1}  a ^ b that is a XOR b = {2}", a, b, a^b);
            Console.WriteLine("c = {0},  d = {1}  c >> d  that is 2 ke 2 bit right e shift = {2}", c, d, c >> d);
            Console.WriteLine("c = {0},  d = {1}  c << d  that is 2 ke 2 bit left e shift = {2}", c, d, c << d);

            Console.WriteLine("6. Assignment Operators : =, +=, -=, *=, /=, %=, |=, &=");
            Console.WriteLine("a = {0} ,b = {1} a = b that is b er value a te assign a = {2}",a,b,a=b);
            Console.WriteLine("a = {0} ,b = {1} a += b that is a = a + b so a = {2}",a,b,a+=b);
            Console.WriteLine("a = {0} ,b = {1} a -= b that is a = a - b so a = {2}",a,b,a-=b);
            Console.WriteLine("a = {0} ,b = {1} a *= b that is a = a * b so a = {2}",a,b,a*=b);
            Console.WriteLine("a = {0} ,b = {1} a /= b that is a = a / b so a = {2}",a,b,a/=b);
            Console.WriteLine("a = {0} ,b = {1} a %= b that is a = a % b so a = {2}",a,b,a%=b);
            Console.WriteLine("a = {0} ,b = {1} a |= b that is a = a | b so a = {2}",a,b,a|=b);
            Console.WriteLine("a = {0} ,b = {1} a &= b that is a = a & b so a = {2}",a,b,a&=b);

            Console.WriteLine("7. Misc Operators : sizeof(), typeof(), &(address operator), *(pointer), ? : (Conditional operator;if,else er compact), is, as ");
            Console.WriteLine("sizeof(byte) = {0} byte and typeof(byte) = {1}", sizeof(byte),typeof(byte));
            Console.WriteLine("sizeof(sbyte) = {0} bytes and typeof(sbyte) = {1}", sizeof(sbyte), typeof(sbyte));
            Console.WriteLine("sizeof(short) = {0} bytes and typeof(short) = {1}", sizeof(short), typeof(short));
            Console.WriteLine("sizeof(ushort) = {0} bytes and typeof(ushort) = {1}", sizeof(ushort), typeof(ushort));
            Console.WriteLine("sizeof(int) = {0} bytes and typeof(int) = {1}", sizeof(int), typeof(int));
            Console.WriteLine("sizeof(uint) = {0} bytes and typeof(uint) = {1}", sizeof(uint), typeof(uint));
            Console.WriteLine("sizeof(float) = {0} bytes and typeof(float) = {1}", sizeof(float), typeof(float));
            Console.WriteLine("sizeof(double) = {0} bytes and typeof(double) = {1}", sizeof(double), typeof(double));
            Console.WriteLine("sizeof(long) = {0} bytes and typeof(long) = {1}", sizeof(long), typeof(long));
            Console.WriteLine("sizeof(decimal) = {0} bytes and typeof(decimal) = {1}", sizeof(decimal), typeof(decimal));
            Console.WriteLine("sizeof(char) = {0} bytes and typeof(char) = {1}", sizeof(char), typeof(char));
            Console.WriteLine("sizeof(bool) = {0} byte and typeof(bool) = {1}", sizeof(bool), typeof(bool));
            
            ///Address and pointer operator er jonno must unsafe block use korte hobe
            int *addresofa=&a;
            int* valueofa = addresofa;
            int* copyofa = &a;
            Console.WriteLine("Address of a = {0}",(int)addresofa);
            Console.WriteLine("Value of a = {0}", *valueofa);
            
            a = 100;
            Console.WriteLine("Value of a = {0} copyofa= {1}", a, *copyofa);
            a = 300;
            Console.WriteLine("Value of a = {0} copyofa = {1}", a, *copyofa);

            int va = a;
            Console.WriteLine("value of a = {0} and va = {1}",a,va);
            a = 500;
            Console.WriteLine("value of a = {0} and va = {1}", a, va);

            ///Conditional operator  ? :
            int greaterNum;
            greaterNum = (a > b) ? a : b;
            Console.WriteLine("Greater of a = {0} and b = {1} is {2}",a,b,greaterNum);

            ///is, as
            //is : Determines whether an object is of a certain type.
            if (a is int) Console.WriteLine("Yes a is int type");

            //as : Cast without raising an exception if the cast fails.
            object ob1 = "jitu";
            string str1 = ob1 as string;
            Console.WriteLine(str1);

            }
        }
    }
