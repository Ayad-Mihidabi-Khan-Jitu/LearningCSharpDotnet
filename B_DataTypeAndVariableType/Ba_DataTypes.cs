/*
C# holo strongly typed language : that is kono kichu use korar age seta obossoi declare(variables) korte hobe/define(methods) korte hobe
Example : 1. explicitly typed local variables
                    int num;
                    num =12;
                    int num1 = 13;
*implicitly typed local variables ai bishoy ta o c# support kore
Example :  var num; // unknown type
                    num = 12; 
                    var num2 = 14.5; 
                    is equivalent to int num2 = 14;

C# e data type mainly 3 dhoroner
1. Primative(Value) Data Types : assign values to the memory directly
    Example : sbyte(m- 8 bits ),byte(8 bits),short(16 bits),ushort(16 bits),int(32 bits),uint(32 bits),long(64 bits),ulong(64 bits),
                        float(32 bits),double(64 bits),decimal(128 bits),char(16 bits),bool(1 bit)
      
2. Reference Data Types : memory te directly value assign kore na, variable er address assign kore, 
     Example :  built-in reference types are string, object.
                          dynamic : ata early bounding na, runtime e kaj kore.
                          string : amar chatri ra string er boss ami jani  
                          object : all types of data types come from an object
                          
3. Pointer Data Type : memory te variable address shongrokkhon kore
     Example : & and *
                         & : to see the memory address of the variable using "unsafe block" 
                         * : to show the value of the memory address 

 */
using System;
using System.Dynamic;

namespace B_DataTypeAndVariableType
    {
    class Ba_DataTypes
        {
         //int IDD = 10;
         int ID = 28;
        public static void Main(string[] args)
            {
            Console.WriteLine("Data Types");
            Console.WriteLine("------------");
            /*
            Console.WriteLine("Value Data Types(Primative) as below");
            Console.WriteLine("_______________________");
            byte vbyte = 126; //-127 0 127 2^8
            sbyte uvbyte = 127; 
            short vshort = 6100;
            ushort uvshort = 6101;
            int vint = 400000000;
            uint uvint = 400000001;
            long vlong = 1800000000000000000;
            ulong uvlong = 1800000000000000001;
            float vfloat = 400000001.400000F;
            double vdouble = 1000000000000000000000000000000000000000000000000000000000000000000000.12000000000000000000000D;
            decimal vdecimal = 100000000000000000000.999999999999999999999999999999999999999999999999999999999999999999999M;
            char vchar = 'c';
            bool vbool = true;
            Console.WriteLine("byte : " + vbyte);
            Console.WriteLine("sbyte : " + uvbyte);
            Console.WriteLine("short : " + vshort);
            Console.WriteLine("ushort : " + uvshort);
            Console.WriteLine("int : " + vint);
            Console.WriteLine("uint : " + uvint);
            Console.WriteLine("long : " + vlong);
            Console.WriteLine("ulong : " + uvlong);
            Console.WriteLine("float : " + vfloat);
            Console.WriteLine("double : " + vdouble);
            Console.WriteLine("decimal : " + vdecimal);
            Console.WriteLine("char : " + vchar);
            Console.WriteLine("bool : " + vbool);
            Console.WriteLine("All the variables are explicitly typed in the above");
            var variaInt = 123456789;
            var variaChar = 'A';
            var variaBool = false;
            var variaString = "String type";
            Console.WriteLine("All the variables are implicitly typed in the below");
            Console.WriteLine("implicitly typed int : " + variaInt);
            Console.WriteLine("implicitly typed char : " + variaChar);
            Console.WriteLine("implicitly typed bool : " + variaBool);
            Console.WriteLine("implicitly typed string :" + variaString);
            */

            /*
            Console.WriteLine("Reference Data Types as below");
            Console.WriteLine("_____________________________");
            string vstring = "this is string";
            String vvstring = "this is String";
            object vobjectOfint = 123; 
            object vobjectOfchar = 'd';
            object vobjectOfString = "this is a string of object";
            Console.WriteLine("string :" + vstring);
            Console.WriteLine("String :" + vvstring);
            Console.WriteLine("int (object) :" + vobjectOfint);
            Console.WriteLine("Type of the object is " + vobjectOfint.GetType());
            Console.WriteLine("char (object) :" + vobjectOfchar);
            Console.WriteLine("Type of the object is " + vobjectOfchar.GetType());
            Console.WriteLine("string (object) :" + vobjectOfString);
            Console.WriteLine("Type of the object is :" + vobjectOfString.GetType());
            */
            
            Console.WriteLine("Pointer Data Types as below");
            Console.WriteLine("_____________________________");
            int n = 10; //declare and store variable n address  
            //DataTypes i = new DataTypes();
            //int h = i.IDD;
            unsafe
                {
                //int* id = *IDD;
                int* p = &n;  // *p er moddhe assign holo memory address &n er value ta  
                Console.WriteLine("Value of n : "+ n);
                Console.WriteLine("Value of n using pointer : " + *p);
                Console.WriteLine("Address of n : "+ (int)p);
                } 
            
            /*
            ///akhon primative data type and reference data typer moddhe difference dekhbo
            //Primative Datatype
            int i = 47;
            int j = i; //creating new momory location
            Console.WriteLine("Value i and j before : "+ i+" "+j);
            i = 50;
            Console.WriteLine("Value i(updated) and j after : " + i + " " + j);
            j = 34;
            Console.WriteLine("Value i and j(updated) after : " + i + " " + j);
            ///That means primative types are independent of each other
            */
            //Reference Datatype(using array)
            int[] ii = new int[3] {1,2,3}; //ii[0]=1  ii[1]=2  ii[2]=3
            //int[] jj = new int [3]; //creating new momory location
            int[] jj = ii; //refering a momory location
            //jj[0] = ii[0];
            Console.WriteLine("Value ii[0] and jj[0] before : " + ii[0] + " " + jj[0]); // 1 1
            ii[0] = 256;
            Console.WriteLine("Value ii[0](updated) and jj[0] after : " + ii[0] + " " + jj[0]); // 256 1
            jj[0] = 376;
            Console.WriteLine("Value ii[0] and jj[0](updated) after : " + ii[0] + " " + jj[0]); // 256 376
            ///That means reference types are dependent of each other
            
            
            //Reference Datatype(using object)
            Ba_DataTypes ob1, ob2;
            ob1 = new Ba_DataTypes(); //obj1.ID=0
            ob2 = new Ba_DataTypes(); //creating new momory location
            //ob2 = ob1; //refering a momory location
            ob2.ID = ob1.ID;
            Console.WriteLine("Value of ob1.ID and ob2.ID before : " + ob1.ID+" "+ ob2.ID);
            ob1.ID = 55;
            Console.WriteLine("Value of ob1.ID(updated) and ob2.ID before : " + ob1.ID + " " + ob2.ID);
            ob2.ID = 11;
            Console.WriteLine("Value of ob1.ID and ob2.ID(updated) before : " + ob1.ID + " " + ob2.ID);
            
            }
        }
    }
