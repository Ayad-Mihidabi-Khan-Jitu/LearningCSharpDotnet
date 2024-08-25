/*
Operators                                                      Description
1.  +, -, !, ~, ++, --                                        These unary operators take one operand and can be overloaded.
2.  +, -, *, /, %                                              These binary operators take one operand and can be overloaded.
3.	  ==, !=, <, >, <=, >=                                 The comparison operators can be overloaded.
4.  &&, ||                                                         The conditional logical operators cannot be overloaded directly.
5.	 +=, -=, *=, /=, %=                                  The assignment operators cannot be overloaded.
6.  =, ., ? :, ->, new, is, sizeof, typeof    These operators cannot be overloaded. 
Syntex of Operator Overloading:
access specifier  ClassName  operator Operator_symbol (parameters)
{
    // Code
}
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Operators
    {
    class Matrix
        {
        internal int a1;
        internal int a2;
        internal int a3;
        internal int a4;
       public Matrix(int i,int j,int k,int l)
            {
            this.a1 = i;
            this.a2 = j; 
            this.a3 = k; 
            this.a4 = l;
            }

        ///Overloading + operator for two operand that is when + is binary + operator
        public static Matrix operator +(Matrix A, Matrix B)
            {
            Matrix PAB = new Matrix(A.a1 + B.a1, A.a2 + B.a2, A.a3 + B.a3, A.a4 + B.a4);
            return PAB;
            }

        ///Overloading - operator for two operand that is when - is binary - operator
        public static Matrix operator -(Matrix A, Matrix B)
            {
            Matrix MAB = new Matrix(A.a1 - B.a1, A.a2 - B.a2, A.a3 - B.a3, A.a4 - B.a4);
            return MAB;
            }

        ///Overloading - operator for one operand that is when - is unary - operator
        public static Matrix operator -(Matrix M)
            {
            Matrix InverOfM = new Matrix(-M.a1, -M.a2 , -M.a3 ,- M.a4 );
            return InverOfM;
            }

        ///Overriding ToString() method for Printing the value of Matrix Class
        public override string ToString()
            {
            string Mprint = $"{a1} {a2} {a3} {a4}\n";
            return Mprint;
            }

        }
    class Cb_OperatorOverloading
        {
        static void Main()
            {
            Matrix A = new Matrix(40, 50, 60, 10);
            Matrix B = new Matrix(20, 30, 40, 50);
            /*
            ///Process-1
            Matrix APlusB = new Matrix(A.a1+B.a1, A.a2 + B.a2,A.a3 + B.a3,A.a4 + B.a4);
            Console.WriteLine("Value of Matrix A : ");
            Console.WriteLine("{0}  {1}  {2}  {3}", A.a1,  A.a2,  A.a3,  A.a4);
            
            Console.WriteLine("Value of Matrix B : ");
            Console.WriteLine("{0}  {1}  {2}  {3}", B.a1, B.a2, B.a3, B.a4);

            Console.WriteLine("Value of Matrix A+B : ");
            Console.WriteLine("{0}  {1}  {2}  {3}", APlusB.a1, APlusB.a2, APlusB.a3, APlusB.a4);
            */

            ///Ghotona holo abave duita matrix er jogfol ber kora khub painful so jodi nicher moto kora jay taile valo hoto
            ///Process-2 (A+B) //but ata wrong and karon + operator Matrix class er er dui ta object jog korte pare na

            //Pprocress-1
            /*
            //Values of Matrix A and B
            Console.WriteLine("Value of Matrix A : ");
            Console.WriteLine("{0}  {1}  {2}  {3}", A.a1, A.a2, A.a3, A.a4);
            Console.WriteLine("Value of Matrix B : ");
            Console.WriteLine("{0}  {1}  {2}  {3}", B.a1, B.a2, B.a3, B.a4);

            Matrix APlusB = A + B;
            Console.WriteLine("Value of Matrix A+B : ");
            Console.WriteLine("{0}  {1}  {2}  {3}", APlusB.a1, APlusB.a2, APlusB.a3, APlusB.a4);

            Matrix AMinusB = A - B;
            Console.WriteLine("Value of Matrix A+B : ");
            Console.WriteLine("{0}  {1}  {2}  {3}", AMinusB.a1, AMinusB.a2, AMinusB.a3, AMinusB.a4);
            */

            /*
            //Pprocress-2
            Console.WriteLine("Value of Matrix A :");
            Console.WriteLine(A);
            Console.WriteLine("Value of Matrix B :");
            Console.WriteLine(B);

            Matrix APlusB = A + B;
            Console.WriteLine("Value of Matrix A+B :");
            Console.WriteLine(APlusB);

            Matrix AMinusB = A - B;
            Console.WriteLine("Value of Matrix A-B :");
            Console.WriteLine(AMinusB);

            Matrix InvetOfA = -A;
            Console.WriteLine("Value of Matrix -A :");
            Console.WriteLine(InvetOfA);

            Matrix InvetOfB = -B;
            Console.WriteLine("Value of Matrix -B :");
            Console.WriteLine(InvetOfB);
            */

            /*
            ///Math Class ti amader jonno khub upokari nicher akta udahoron theke amara dekhi cholo
            int a = 8, b = 2;
            Console.WriteLine(Math.Log(a, b));
            */
            }
        }
    }
