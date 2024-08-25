/*
 Polymorphism er je basic concept seta Interface er kkhetrew applicable
*/
using System;
namespace Interface
    {
    class Qb_PolymorphismInInterface
        {
        public static void Main()
            {
            //Measurement m1 = new Measurement();
            Measurement m1 = new Circle(12);
            double arOfCir = m1.Area();
            Console.WriteLine(arOfCir);

            Measurement m2 = new Triangle(12,6);
            double arOfTri = m2.Area();
            Console.WriteLine(arOfTri);
            
            /// using interface as method actual parameter
            addArea(m1, m2);
            }
        public static void addArea(Measurement m1, Measurement m2)
            {
            double addArea = m1.Area() + m2.Area();
            Console.WriteLine(addArea);
            }

        }

    interface Measurement
        {
          const double PI = 3.1416;
          double Area();
        }
    class Circle : Measurement
        {
        internal int radius;
        internal Circle(int r)
            {
            this.radius = r;
            }
       public double  Area()
            {
            double a = Measurement.PI*Math.Pow(this.radius, 2);
            return a;
            }
        }
    class Triangle : Measurement
        {
        int bbase,height;
        internal Triangle(int b, int h)
            {
            this.bbase = b;
            this.height = h;
            }
        public double Area()
            {
            double a = 0.5 * this.bbase * this.height;
            return a;
            }
        }
    }

