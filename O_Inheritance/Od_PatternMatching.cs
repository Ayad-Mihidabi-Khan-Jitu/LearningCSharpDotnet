/*
This is how the pattern matching works in prior to C# 6 
*/
using System;
namespace O_Inheritance
    {
    class Shape
        {
        internal const double PI = 3.1416;
        }
    class Choturvuj : Shape
        {
        internal int width { get; set; }
        internal int height { get; set; }
        }
    class Britto : Shape
        {
        internal int radius { get; set; }
        }

    class ShapeTest
        {
        static internal void GetArea(Shape s)
            {
            if (s is Choturvuj)
                {
                Choturvuj c = s as Choturvuj;
                if (c.height == c.width)
                    {
                    Console.WriteLine("Area of Choturvuj = " + c.height * c.width);
                    }
                else
                    {
                    Console.WriteLine("Area of Choturvuj = " + c.height * c.width);
                    }
                }
            else if (s is Britto)
                {
                Britto c = s as Britto;
                Console.WriteLine("Area of the Britto = " + (Shape.PI * (c.radius * c.radius)));
                }

            }
        static void Main(string[] args)
            {

            Console.WriteLine("Test Shape");
            Choturvuj ayotokhetro = new Choturvuj { height = 12, width = 5 };
            Choturvuj borgo = new Choturvuj { height = 5, width = 5 };
            Britto britto = new Britto { radius = 4 };

            GetArea(ayotokhetro);
            GetArea(borgo);
            GetArea(britto);



            }
        }
    }
