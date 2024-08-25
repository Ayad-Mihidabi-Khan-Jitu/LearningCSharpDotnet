/*
 Polymorphism er je basic concept seta Abstract er kkhetrew applicable
 */
using System;
namespace Abstract
    {
    class Pb_PolymorphismInAbstract
        {
        public static void Main()
            {

            //Measurement m0 = new Measurement(); abstract class er kono object create kora jay na
            //Measurement m0 = new Square();
            ///Perimeter() method override kora hoyeche
            Measurement m1 = new Ractangle();
            
            double periOfRac = m1.Perimeter(4,5);
            Console.WriteLine(periOfRac);

            double periOfSqu = m1.Perimeter(4);
            Console.WriteLine(periOfSqu);
            m1.display();

            //Ractangle r1 = new Ractangle();
            //double periOfSqu = r1.PerimeterOfSqu(3);
            //Console.WriteLine(periOfSqu);

            ///display() method override kora hoy ni so method hide hobe mane holo object onujayi method asbe na
            Square r1 = new Ractangle();
            
            double periOfRac1 = r1.Perimeter(4, 5);
            Console.WriteLine(periOfRac);
            r1.display();

            double periOfSqu1 = r1.Perimeter(4);
            Console.WriteLine(periOfSqu);
            r1.display();


            }
        }
    abstract class Measurement
        {
        string measu="Measurement";
        protected double lenght;
        protected double width;
        public void display()
            {
            Console.WriteLine("This is : " + this.measu);
            }
        abstract public double Perimeter(double L, double W);
        abstract public double Perimeter(double L);
        }
    abstract class Square : Measurement
        {
        string measu = "Square";
        
        public new void display()
            {
            Console.WriteLine("This is : " + this.measu);
            }
        public override double Perimeter(double l)
            {
            base.lenght = l;
            double perimeter = Math.Pow(base.lenght, 2);
            return perimeter;
            }

        }
    class Ractangle : Square
        {
        string measu = "Ractangle";
        public new void display()
            {
            Console.WriteLine("This is : " + this.measu);
            }
        public override double Perimeter(double l, double w)
            {
            base.lenght = l;
            base.width = w;
            double perimeter = base.lenght*base.width;
            return perimeter;
            }

        /*
        public double PerimeterOfSqu(int l)
            {
            double squ= base.Perimeter(l);
            return squ;
            }
        */

        }

    }
