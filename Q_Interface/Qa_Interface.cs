/*
 Interface : Interface kono class na. Interface is interface.
 Interface er boisisto : 
  1. Interface er SHOB METHOD E ABSTRACT hoy abong VARIABLE GULI CONTANT hoy
  2. Interface er METHODS and VARIABLE guli PUBLIC by default.
  3. Abstract class er motoi INTERFACE  er o kono object create kora jay na. Abstract er motoi Interface k inherit kore sekhane method guli k 
       implement korte hoy.
 Difference   Between          Abstract Class               and            Interface :
  i)    minumum akta abstract method                            |              shob guli method e abstract
  ii)   abstract method guli by default overriden na   |              interface er method guli by default abstract and overriden
  iii) abstract method guli private by default              |              method public thake
  iv)  variable guli private non static                              |              variable guli constant        
  v) multiple inhertence not allowed                             |              multiple inhertence allowed          
  
  In broad sense INTERFACE k full abstract bola jay, kivabe seta niche dekhacchi. Abstract er oi Business ta extend korsi.
  interface er maddhome keno kaj ta korlam karon abstract class e je sellRate guli chilo oguli chailei ami change korte pari jar jonno business e
  agun lagse abar but ai interface er kkhtre seta o string security pai karom interface e vairable guli constant hoy
 */

using System;
namespace Interface
    {
    class Qa_Interface
        {
        static void Main(string[] args)
            {
            Console.WriteLine("_________________________________");
            Console.WriteLine("| Welcome to JSA Restaurant Ltd.|");
            Console.WriteLine("| Daily Sale Ammount : " + DateTime.Now.ToShortDateString() + " |");
            Console.WriteLine("|_______________________________|");
            Console.WriteLine("");

            JSA jsa = new JSA();

            Console.Write("JSA Dhaka Enter Sale Ammount  : ");
            int sDha = Convert.ToInt32(Console.ReadLine());
            int saleDhaka = jsa.CalculateSaleDhaka(sDha);
            Console.WriteLine("JSA Restaurant LTD,Dhaka");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Today's Sale : " + saleDhaka);
            Console.WriteLine("");


            Console.Write("JSA Pabna Enter Sale Ammount  : ");
            int sPab = Convert.ToInt32(Console.ReadLine());
            int salePabna = jsa.CalculateSalePabna(sPab);
            Console.WriteLine("JSA Restaurant LTD,Pabna");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Today's Sale : " + salePabna);
            Console.WriteLine("");


            Console.Write("JSA Barishal Enter Sale Ammount  : ");
            int sBar = Convert.ToInt32(Console.ReadLine());
            int saleBarishal = jsa.CalculateSaleBarishal(sBar);
            Console.WriteLine("JSA Restaurant LTD,Barishal");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Today's Sale : " + saleBarishal);
            Console.WriteLine("");
            }
        }

    interface JSA_Dhaka
        {
        const int saleRateDhaka = 20;
         int CalculateSaleDhaka(int s1);
        }

    interface JSA_Pabna
        {
        const int saleRatePabna = 20;
        int CalculateSalePabna(int s2);
        }

    interface JSA_Barishal
        {
        const int saleRateBarishal = 20;
        int CalculateSaleBarishal(int s3);
        }

    class JSA : JSA_Dhaka, JSA_Pabna, JSA_Barishal
        {
        public int CalculateSaleDhaka(int s1)
            {
            int totalSale;
            totalSale = s1 * JSA_Dhaka.saleRateDhaka;
            return totalSale;
            }

        public int CalculateSalePabna(int s2)
            {
            int totalSale;
            totalSale = s2 * JSA_Pabna.saleRatePabna;
            return totalSale;
            }

        public int CalculateSaleBarishal(int s3)
            {
            int totalSale;
            totalSale = s3 * JSA_Pabna.saleRatePabna;
            return totalSale;
            }

        }
    }
