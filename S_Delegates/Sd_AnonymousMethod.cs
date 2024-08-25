/*
1. In C# 2.0 Anonymous Method was first introduced.
     Anonymous Method : A method without a method body, a delegate is used to contain the code of the method's body
    -Delegates knows the parameter/parameters' type and return type
     Syntex: NameOfDelegate nameofOject = delegate(parameter/paramaters){code what was inside in the methods};
     NOTE: Instance variables er jonno jemon auto property thik temon method er jonno delegate  
2. In C# 3.0 Lambda Expression was first introduced.
     Lambda Expression : It is a short hand for writing Anonymous Methods. 
     -    "=>"   is called Lambda Operator 
    Syntex: NameOfDelegate nameofOject = (parameter/paramaters) => {code what was inside in the methods};
    NOTE : Anonymous Method can't use : param, ref, out and generic.
*/
using System;
namespace S_Delegate
    {
    ///Step-1:  Define
    internal delegate string DNameOfProduc(string name);
    internal delegate void DPriceOfProduc(double price);
    class Sd_AnonymousMethod
        {
            static void Main()
            {
            /*
            ///Process-1

            ///Step-2 Instantiate
                DNameOfProduc dNameOfProduct = delegate (string name)
                 {
                return name;
                 };
                DPriceOfProduc dPriceOfProduct = delegate (double price)
                {
                 Console.WriteLine("The price of the product is " + price);
                };
             
            ///Step-3 Call
            Console.WriteLine(dNameOfProduct.Invoke("Amm")); 
            dPriceOfProduct.Invoke(90.99);
            */

            /*
            ///Process-2 (Using Lambda Expression)

            ///Step-2 Instantiate
            DNameOfProduc dNameOfProduct = (name) =>
                {
                    return name;
                    };
            DPriceOfProduc dPriceOfProduct =  (price) =>
                {
                    Console.WriteLine("The price of the product is " + price);
                    };

            ///Step-3 Call
            Console.WriteLine(dNameOfProduct.Invoke("Amm"));
            dPriceOfProduct.Invoke(90.99);
            */
            }
        }
    }
