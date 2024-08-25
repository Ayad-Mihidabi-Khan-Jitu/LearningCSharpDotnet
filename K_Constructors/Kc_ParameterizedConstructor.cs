using System;

namespace Constructor
{
    public class Kc_ParameterizedConstructor
    {
        int i,j;
        public Kc_ParameterizedConstructor(int i,double j)
        {
            this.j = (int)j;
            this.i = i;
            Console.WriteLine("First Number is : " + i);
            Console.WriteLine("Second Number is : " + this.j);
          }

        public Kc_ParameterizedConstructor(int num1,int num2)
        {
            i = num1; 
            j = num2;
            Console.WriteLine("First Number and Second Number is : " + num1+" and "+num2);
        }
        public void Display()
        {
            Console.WriteLine("The value of i :" + i);
        }

        public void Display(int num)
        {
            int disNum = num;
            Console.WriteLine("The value of disNum:" + disNum);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Parameterized");
            Kc_ParameterizedConstructor FirstPrint =new Kc_ParameterizedConstructor(15,10.56);
            Kc_ParameterizedConstructor SecondPrint = new Kc_ParameterizedConstructor(20,100); //construcotr overloading
            /*
            // FirstPrint = SecondPrint;
            FirstPrint.Display();
            SecondPrint.Display();
            SecondPrint.Display(50);//method overloading
            //Console.WriteLine(FirstPrint);
            //Console.WriteLine(SecondPrint);
            ParameterizedConstructor jhan;
            jhan = FirstPrint;
            jhan.Display();
            */
        }
    }
}
