/*
This is how the pattern matching works in C# 7.0 
Here, "if(s is Choturvuj1 c1)"  is  equivanlent  to  "if(s is Choturvuj) {Choturvuj c = s as Choturvuj;}"
*/

using System;
namespace O_Inheritance
    {
    class Shape1
        {
        internal const double PI = 3.1416;
        }
    class Choturvuj1 : Shape1
        {
        internal int width { get; set; }
        internal int height { get; set; }
        }
    class Britto1 : Shape1
        {
        internal int radius { get; set; }
        }

    class ShapeTest1
        {
        static internal void GetArea(Shape1 s)
            {

            ///1. with if else control
            if (s is Choturvuj1 c1)
                {
                if (c1.height == c1.width)
                    {
                    Console.WriteLine("Area of Choturvuj = " + c1.height * c1.width);
                    }
                else
                    {
                    Console.WriteLine("Area of Choturvuj = " + c1.height * c1.width);
                    }
                }
            else if (s is Britto1 b1)
                {
                Console.WriteLine("Area of the Britto = " + (Shape.PI * (b1.radius * b1.radius)));
                }


            /*
            ///2. with switch control
            switch (s)
                {
                case Choturvuj1 c1 when c1.height==c1.width:
                    Console.WriteLine("Area of Choturvuj = " + c1.height * c1.width);
                    break;
                case Choturvuj1 c1:
                    Console.WriteLine("Area of Choturvuj = " + c1.height * c1.width);
                    break;
                case Britto1 b1:
                    Console.WriteLine("Area of the Britto = " + (Shape1.PI * (b1.radius * b1.radius)));
                    break;
                }
            */
            }
        static void Main(string[] args)
            {

            Console.WriteLine("Test Shape");
            Choturvuj1 ayotokhetro1 = new Choturvuj1 { height = 4, width = 3 };
            Choturvuj1 borgo1 = new Choturvuj1 { height = 2, width = 2 };
            Britto1 britto1 = new Britto1 { radius = 5 };

            GetArea(ayotokhetro1);
            GetArea(borgo1);
            GetArea(britto1);



            }
        }
    }
