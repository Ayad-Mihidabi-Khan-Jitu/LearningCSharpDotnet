/*
 amra jani object create korte gele constructor lage infact akta nirdisto object er 
 instance vairable guli k nirdisto value akmatro constructor diye thake.
 taile amra ektu govire jai : amra jani akta child class tar parent class er shob kichu contain kore- instence variables, methods shob.
                                                     prosno hocche kivabe access korte pare??
                                                     uttor : jehetu akmatro constructor sei bekti e instance variable initialize korte pare tai jokhon child class er kono
                                                     object create kora hoy tokhon child class tar nijer constructor call korar sathe sathei age parent class er contructor
                                                     call kore.
Claim: je constructor er maddhome child class object create korbo sei rokom constructor parent class e thakte hobe 
*/
using System;
using System.Security.Cryptography;

namespace Inheritance
    {
    class Ob_baseKeywordAndConstructors
        {
        public static void Main()
            {
            //creating a object using default constructor
            //C c1 = new C(); //
            //creating a object using amar create kora constructor
            C c2 = new C(1,2,3);
            
            /*
            C c3 = c1;
            Console.WriteLine("Type of c1 = "+c1.GetType()+"    Type of c3 = "+c3.GetType());
            B bc = c3;
            Console.WriteLine("Type of bc = " + bc.GetType() ) ;
            */

            }
        }
    class A
        {
         int a = 10;
        
        public A()
            {
            Console.WriteLine("This is Class A (Default Constructor) and a = "+a);   
            }
       
        public A(int x)
            {
            this.a = x;
            Console.WriteLine("This is Class A : a = " + this.a);
            }
        
        }

    class B:A
        {
          int b = 20;
        
        public B()//:base()
            {
            Console.WriteLine("This is Class B (Default Constructor) and b = "+b);
            }
        

        public B(int x, int y):base(x) //A(1)
            {
            this.b = y;
            Console.WriteLine("This is Class B : b = " + this.b);
            }
        
        }

    class C:B
        {
        int c = 30;

        public C()
            {
            Console.WriteLine("This is Class C (Default Constructor) and c = "+c);
            }
        
        //C(1,2,3);
        
        public C(int x,int y, int z):base(x,y) // public B(x,y) public B(1,2) 
            {
            this.c = z;
            Console.WriteLine("This is Class C : c = " + this.c);
            }
        }
    }
