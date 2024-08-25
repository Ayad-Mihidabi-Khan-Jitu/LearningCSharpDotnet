/*
 For VARIABLE -> Property   METHOD -> Delegate
 Akta method k amra dui vabe call korte pari 1: directing calling   2 : creating a delegate 
 Delegate is a type safe pointer.
 -Delegate akta function er reference hold kore abong function take call kore
 -Delegate is a reference type
 -Deleagte ti je method k refer korbe se method er sathe delegate er signature same hote hobe
 -Delegates knows the parameter/parameters' type and return type
 NOTE: joto dhoroner user defined type ache shob guli k namespace er under e declare kora valo
 Syntex: access_modifier    delegate   dataType    delegateName (parameters,...);
 */
using System;
using System.Reflection;

namespace S_Delegate
    {
    ///Step-1:  Define
    internal delegate string DNameOfProduct(string s);
    internal delegate void DPriceOfProduct(double p);
    class Sa_Delegates
        {
        string NameOfProduct(string s)
            {
            return s;
            }
        internal static void PriceOfProduct(double p)
            {
            Console.WriteLine("The price of the product is "+p);
            }
        
        ///1. When methods and Main methods are in the same class
        static void Main(string[] args)
            {
            Console.WriteLine("Delegate");
            Sa_Delegates d1 = new Sa_Delegates();
            Console.WriteLine(d1.NameOfProduct("Banana"));
            PriceOfProduct(40.12);

            ///Step-2:  Instantiate
            DNameOfProduct dNameOfProduct = new DNameOfProduct(d1.NameOfProduct);
            ///Step-3:  Call delegate by passing required parameter value
            string Product = dNameOfProduct("Jam");
            Console.WriteLine(Product);

            ///Step-2:  Instantiate
            DPriceOfProduct dNameOfPrice = new DPriceOfProduct(PriceOfProduct);
            ///Step-3:  Call delegate by passing required parameter value
            dNameOfPrice(20.10);
            dNameOfPrice.Invoke(100.99);//Same as above
            }
        
        }

    /*
    ///2. Deeper look when methods are private
    class TestDelegate
        {
        static void Main(string[] args)
            {
            Console.WriteLine("Delegate");
            Delegates d1 = new Delegates();
            Console.WriteLine(d1.NameOfProduct("Banana"));
            Delegates.PriceOfProduct(40.12);

            ///Step-2:  Instantiate
            DNameOfProduct dNameOfProduct = new DNameOfProduct(d1.NameOfProduct);
            ///Step-3:  Call delegate by passing required parameter value
            string Product = dNameOfProduct("Jam");
            Console.WriteLine(Product);

            ///Step-2:  Instantiate
            DPriceOfProduct dNameOfPrice = new DPriceOfProduct(Delegates.PriceOfProduct);
            ///Step-3:  Call delegate by passing required parameter value
            dNameOfPrice(20.10);
            dNameOfPrice.Invoke(100.99);//Same as above
            }
        }
   */
    }
