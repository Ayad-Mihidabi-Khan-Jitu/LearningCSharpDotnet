/*
Destructors in C# are methods inside the class used to destroy instances of that class when they are no longer needed. 
The Destructor is called implicitly by the .NET Framework’s Garbage collector and therefore programmer has no control 
as when to invoke the destructor. An instance variable or an object is eligible for destruction when it is no longer reachable.

Important Points:
A Destructor is unique to its class i.e. there cannot be more than one destructor in a class.
A Destructor has no return type and has exactly the same name as the class name (Including the same case).
It is distinguished apart from a constructor because of the Tilde symbol (~) prefixed to its name.
A Destructor does not accept any parameters and modifiers.
It cannot be defined in Structures. It is only used with classes.
It cannot be overloaded or inherited.
It is called when the program exits.
Internally, Destructor called the Finalize method on the base class of object.
*/
using System;
namespace Destructor
    {
    class Person
        {
        internal int houseNo;
        internal string address;
        internal Person(int h, string a)
            {
            houseNo = h;
            address = a;
            }
        ~Person()
            {
            Console.WriteLine("Destructor Called");
            }
        }
    class PeopleTest
        {
        static void Main(string[] args)
            {
            Console.WriteLine("Hello People");
            Person p1 = new Person(38, "canada");
            Console.WriteLine(p1.houseNo);
            Console.WriteLine(p1.address);
            } 
        }///Instance scope sesh
    }
///OUTPUt e            38           canada           Destructor is called           ashar kotha