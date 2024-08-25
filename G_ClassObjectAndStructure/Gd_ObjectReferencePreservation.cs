using System;
namespace D_ClassObjectAndStructure
    {
     class Gd_ObjectReferencePreservation
        {
            public static void Main()
            {
            AB ob1 = new AB();
            ob1.number = 34;
            Console.WriteLine("Before Method Call Number = " + ob1.number);
            
            CD obj2 = new CD();
            //CD.changNumber(ob1) ;
            obj2.changNumber(ob1) ;
            Console.WriteLine("After Method Call Number = " + ob1.number);
            }
        }
     class AB
        {
        public int number;
        }
    class CD
        {
            //public static void changNumber(AB a)
            public void changNumber(AB ob)
            {
            Console.WriteLine("Inside Method Call Before Modification, Number = " + ob.number);
            ob.number = 500;
            Console.WriteLine("Inside Method Call After Modification, Number = " + ob.number);
            ob = null;
           // ob = obj2;
            Console.WriteLine("Inside Method Call when ob = NULL, Number = " + ob);
            }
        }

    }
