/*
Function amon akta jinish
jeta akta input nitew pare othoba na nite pare
kichu output ditew pare othoba na o dite pare
Function create er dhap:    1. function define  2. function call 

1. function declare korar syntex : 
[int main funciton er pore jodi function ti define kora hoy tahole funciton declare korte hoy]
access_specifier    return_type    functionName (data_type  vairableName);

=>    public                         int                      addtion    (int a, int b);

1. function define korar syntex : 
access_specifier    return_type    functionName (formal parameter/parameters)

access_specifier    return_type    functionName (data_type  vairableName)
{
    codes
}

=>   public                         int                          addition (int a,int b)
       {
            int sum;
            sum = a + b;
            return sum;
       }

2. functionName (actual parameter/parameters);
[function call korle program er control int main theke ber hoye 
jekhane function define kora ache sekhane chole jay]
=>   addition (2,3);

#function ke tar prokritir dik theke 2 vabe vag kora jay:
1. Parameterized/non-parameterize function
2. With Returned/Non returned(void) function

=> ai dui dhoroner prokriti k niye function 4 rokom rup e thake
1. with_returned function(parameterized)
2. non_returned function(non-parameterized)
3. with_returned function(non-parameterized)
4. non_returned function(parameterized)
*/

using System;
namespace Methods
{
   public class Ea_Methods
    {
   
        // 1. with_returned function(parameterized)
        public static double addtion(double a,double b)
        {
            Console.WriteLine("1. with_returned function(parameterized)");
            double sum;
            sum = a + b;
            return sum;
        }
        
        /*
        // 2. non_returned function(non-parameterized)
        public static void addtion()
        {
            Console.WriteLine("2. non_returned function (non-parameterized)");
            double sum,a=9,b=9;
            sum = a + b;
            Console.WriteLine(sum);
        }
        */

        /*
        // 3. with_returned function(non-parameterized)
        public static double Addtion()
        {
            Console.WriteLine("3. with_returned function(non-parameterized)");
            double sum, a = 9.7, b = 9.1;
            sum = a + b;
            return sum;
        }
        
        
        // 4. non_returned function(parameterized)
        public static void Addtion(double a, double b)
        {
            Console.WriteLine("4. non_returned function(parameterized)");
            double sum;
            sum = a + b;
            Console.WriteLine(sum);
        }
        */

        /*
        // 5. with_returned_array function(parameterized with array)
        public static int [] arrAddtion(int [] n, int s)
        {
            Console.WriteLine("5. with_returned array function parameterized with array)");
            int[] presum = new int[s];
            presum[0] = n[0];
            for (int i = 1; i < s; i++)
            {
                presum[i] = presum[i - 1] + n[i];
            }
            return presum;
        }
        */

        /*
        // 6. int_returned function(parameterized with array)
        public static int arrOdd(int[] n, int s) //1 2 3 4 5
        {
            Console.WriteLine("6. with_returned function parameterized with array)");
            int noOfodds = 0;
            for (int i = 0; i < s; i++)
            {
                if (n[i] % 2 != 0) noOfodds++;
            }
            return noOfodds;
        }
        */

        /*
        // 7. returned_array function(parameterized)
        public static int[] TwosPower(int two,int mrange) //(2,2) 0 1
        {
            Console.WriteLine("7. with_returned_array function parameterized)");
            int[] multi = new int[mrange];
            //int k = 0;
            //multi[0] = 2;
            for (int k=0 ; k < mrange; k++)///          0010
            {
                multi[k] = 1 << k;        
            }
            return multi;  
        }
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Methods");
            Console.WriteLine("----------");
            double num1, num2;
            //string n1 = Console.ReadLine(); 
            //int num1 = Convert.ToInt32(n1);  
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());

            /// 1. with_returned function(parameterized)
            /// calling additon function having return value taking two parameters
            //double result = addtion(num1, num2); // function calling 
            //Console.WriteLine(addtion(num1, num2));// function calling and printing
            //Console.WriteLine(result); 


            /// 2. non_returned function(non-parameterized)
            /// calling additon function having no return value taking no parameters
            ///addtion();



            /// 3. with_returned function(non-parameterized)
            /// calling additon function having return value taking no parameters
            //double result2 = Addtion();
            //  Console.WriteLine(result2);



            /// 4. non_returned function(parameterized)
            /// calling additon function having no return value taking two parameters
            //Addtion(num1,num2);


            /*
            /// 5. with_returned_array function(parameterized with array)
            /// calling additon function having return array value taking parameters as array
            int[] Nums = {1, 2, 3, 4, 5 }; //c/c++
            int[] Nums = new int [5];
            int[] Nums = new int [] {1, 2, 3, 4,5 };
            int[] Nums = new int [5] { 1, 2, 3, 4, 5 };
            string name;
            int sizeofNums = Nums.Length;
            int [] sum = arrAddtion(Nums, sizeofNums);
            for (int j = 0; j < sizeofNums; j++)
            {
                Console.Write(sum[j] + " ");
            } Console.WriteLine();
            */

            /// 6. with_returned function(parameterized with array)
            /// calling additon function having return array value taking parameters as array
            // int[] Nums = { 1, 2, 3, 4, 5 };
            //int sizeofNums = Nums.Length;
            //int odds = arrOdd(Nums, sizeofNums);
            //Console.WriteLine(odds);

            /*
            /// 7. with_returned_array function(parameterized)
            /// calling additon function having return array value taking parameters
            int po = Convert.ToInt32(Console.ReadLine());
            int[] powto =TwosPower(2, po); // (2,2)
            for(int k = 0; k < po; k++)
            {
                Console.Write(powto[k] + " ");
            }
            Console.WriteLine();
            */
            }
    }
}