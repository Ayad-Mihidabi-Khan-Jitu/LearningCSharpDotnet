using System;
namespace U_PartialClassesAndMethods
    {
     class CircleTest : Circle
        {
        CircleTest() : base(5.5) { }
        static void Main(string[] args)
            {
            Console.WriteLine("Circle");
            Circle c1 = new Circle(6.5);
            Console.WriteLine("Radius "+c1.radius);
            c1.GetArea();
            c1.GetPerimeter();

            CircleTest c2 = new CircleTest();
            Console.WriteLine("Radius " + c2.radius);
            c2.GetArea();
            c2.GetPerimeter();
            }
        }
    }
