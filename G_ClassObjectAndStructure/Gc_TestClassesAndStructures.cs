/*
CLASS	                                                                                                                                          STRUCTURE
 1.                           Classes are of reference types.	                                                                                                                 Structs are of value types.
 2.     All the reference types are allocated on heap memory.	                                                                All the value types are allocated on stack memory.
 3. Allocation of large reference type is cheaper than allocation of large value type.	Allocation and de-allocation is cheaper in value type as compare 
                                                                                                                                                                                                                           to reference type.
 4.                                     Class has limitless features.	                                                                                                              Struct has limited features.
 5.                      Class is generally used in large programs.	                                                                                                  Struct are used in small programs.
 6.                 Classes can contain constructor or destructor.                                                  	Structure does not contain parameter less constructor or destructor, 
                                                                                                                                                                        but can contain Parameterized constructor or static constructor.
 7.             Classes used new keyword for creating instances.	                                                          Struct can create an instance, with or without new keyword.
 8.                        A Class can inherit from another class.                                                                  	A Struct is not allowed to inherit from another struct or class.
 9.                  The data member of a class can be protected.	                                                                                 The data member of struct can’t be protected.
 10.      Function member of the class can be virtual or abstract.	                                                      Function member of the struct cannot be virtual or abstract.
 11.  Two variable of class can contain the reference of the same 	                                   Each variable in struct contains its own copy of data(except in ref and out parameter
          object and any operation on one variable can affect another variable.                   variable) and any operation on one variable can not effect another variable.
 */
using System;
using System.Collections.Generic;
using System.Text;
namespace D_ClassObjectAndStructure
    {
    class Gc_TestClassesAndStructures
        {
        public static void Main()
            {
            Ga_Classes c1 = new Ga_Classes();
            c1.Display();

            Gb_Structures s1 = new Gb_Structures();
            s1.Display();

            Gb_Structures s2 = new Gb_Structures(500,"This is a variabel in structure");
            s2.Display();
            }
        }
    }
