/*
variable holo akta nam jeta memory location e dewa hoy, variable is mortal.
jokhon variable er opor kono operation kora hoy seta mainly oi memory location er opor hoy
#Types of Variables
1. Local variables : je variable kono block,mathod or constructor er vitore declare kora hoy
2. Instance variables(Non–Static Variables) : instance variables guli class er vitore kintu jekono block or mathods er baire declare kora hoy
     soja kotha directly class er moddhe declare kor hoy, instance variable guli k object er maddhome access korte koy.
     joto guli object toto guli alada alada instance variable er copy toiri hobe.
     instance variable guli compiler dara created hoy only tokhon e jokhon oi class er object create kora hoy
     and instance variable guli destroy o hoy like local variable, jokhon object ti destroy kora hoy tokhon instance variable guli o nai hoye jay
     NOTE : amra intance variable er khettre access specifiers use kori jeta kina local variable re khettre use kori na

3. Static Variables(Class Variables) : jokhon instance variable er age "static" keyword thake tokhon 
     sei instance variable k "static variable or class variable" bole. static variable kono object er under e thake na
     ata class er under e thake tai static variable er ONLY ONE COPY thake. static variable guli program execution er somoy ram e create hoy
     and program execution end howar somoy nai hoye jay.
     NOTE : static variable obossoi create hobe and only one time but instance variable possibly akbar o naw create hote pare if not obj is created 

4. Constant Variables : jodi kono variable er age "const" keyword thake tokhon sei variable k "constant variable" bole
     const variable static variable er motoi akbar create hoy and access korar jonno obj dorkar hoy na
     NOTE :  const variable declare korar somoy e assign korte hoy and kokkhono VALUE change kora jay na

5. Readonly Variables : jodi kono variable er age "readonly" keyword thake tokhon sei variable k "readonly variable" bole
     readonly variable instance variable er motoi class block e declare korar somoy value assign korte hoy ba contructor er dia value assign
     korte hoy. 
     NOTE : but the only difference holo akta object er moddhe ata akbar initialized hoye gele seta ar change kora jay na. that is oi nirdistho
                   object er jonno ata fixed.
 */

using System;
using System.Threading;

namespace B_DataTypeAndVariableType
    {
    class Bb_VariableTypes
        {
        //2. Instance Variable
        int instanN;
        //3. Static(Class) Variable
        //static int instanS;
        static int count = 0;
        //int count=0;
        //4. Constant Variable
        const double PI = 3.1416;
        //5. Readonly Variable
        readonly char rdonlVar = 'J';

        Bb_VariableTypes()
            {
            count++;
            //this.rdonlVar = 'T';
            instanN = 123;
            //Console.WriteLine("Constructor Called without paramater");
            }
        Bb_VariableTypes(int n) //n is also local variable
            {
            count++;//count = count+1;
            //Console.WriteLine("Constructor Called with a parameter");
            instanN = n;
            }
        Bb_VariableTypes(char t)
            {
            rdonlVar = t;
            }

        public static void Main()
            {
            Console.WriteLine("Variable Types");
            Console.WriteLine("--------------------");
            /*
            Console.WriteLine("1. Local Variable ");
            int locaM = 90;
            Console.WriteLine(locaM);
            if (true)
                {
                int locaN = 9;
                Console.WriteLine(locaN);
                }
            */

            /*
            Console.WriteLine("2.Instance Variable ");
            VariableTypes obv1 = new VariableTypes();  
            Console.WriteLine(obv1.instanN);
            VariableTypes obv2;
            obv2 = new VariableTypes(699);
            VariableTypes obv3 = new VariableTypes(700);
            Console.WriteLine(obv2.instanN);
            Console.WriteLine(obv3.instanN);
            */

            /*
            Console.WriteLine("3.Static Variable ");
            Console.WriteLine(VariableTypes.instanS);
            Console.WriteLine(instanS);
            */

            /*
            Console.WriteLine("Difference Between Instance Variable and Static Variable");
            ///amra aita bujhbo akta prblm solve korar maddhome
            //pblm : count ta number of object created of this class
            //solu : amra jani je prottek ta object create korar somoy constructor call hoy so constructor er vitor e akta count bosaya delei hoy
            VariableTypes noOfObj1 = new VariableTypes(223);
            //VariableTypes v1 = new VariableTypes();
            Console.WriteLine("No of Object : "+ VariableTypes.count + " Value of instance variable noOfObj1.instanN = " + noOfObj1.instanN);
            //Console.WriteLine("No of Object : " + v1.count + " Value of instance variable noOfObj1.instanN = " + noOfObj1.instanN);
            VariableTypes noOfObj2 = new VariableTypes(224);
            //VariableTypes v2 = new VariableTypes();
            Console.WriteLine("No of Object : " + count + " Value of instance variable noOfObj2.instanN = " + noOfObj2.instanN);
            //Console.WriteLine("No of Object : " + v2.count + " Value of instance variable noOfObj1.instanN = " + noOfObj1.instanN);
            VariableTypes noOfObj3 = new VariableTypes(225);
            //VariableTypes v3 = new VariableTypes();
            Console.WriteLine("No of Object : " + count + " Value of instance variable noOfObj3.instanN = " + noOfObj3.instanN);
            //Console.WriteLine("No of Object : " + v3.count + " Value of instance variable noOfObj1.instanN = " + noOfObj1.instanN);
            */

            /*
             Console.WriteLine("4. Constant Variable");
            //const double ConsC; //value must be initialized
            const double ConsC = 76243435;
             //ConsC = 123; // akbar initialized korar por kono value assign kora jabe na
             Console.WriteLine("value of the constant variable(local) ConsC = "+ ConsC);
             Console.WriteLine("value of the constant variable(instance) PI = " + PI);
            */


            Console.WriteLine("5. Readonly Variable");
            Bb_VariableTypes robj1 = new Bb_VariableTypes();
            //robj1.rdonlVar = 'e'; // cz notun kore assign kora jay na 
            //karon readonly akta object er moddhe akbar value assign hoye gele oi object er jonno ta change kora jay na
            Console.WriteLine("Value of readonly variable (initialized while declared) = " + robj1.rdonlVar);
            Bb_VariableTypes robj2 = new Bb_VariableTypes('U');
            Console.WriteLine("Value of readonly variable (initialized in the constructor) = " + robj2.rdonlVar);


            }
        }

    }
