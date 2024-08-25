/*
 LINQ : Language Integrated Query
 1. LINQ -> Objects : Arrays,Collections, etc.
 2. LINQ -> Databases : DataTables, Relational Database Table. 
                                       -LINQ to ADO.Net
                                       -LINQ to SQL (C# 3.5) : For only SQL server
                                       -LINQ to Entities : For Oracle server, SQL server etc.
3. LINQ -> XML
*/
using System;
using System.Linq;
namespace LINQ
    {
    class Va_LINQINCSharp
        {
        /// 1. LINQ to Objects
        static void Main(string[] args)
            {
            Console.WriteLine("LINQ");

            /*
            Akta problem face kori age:
            num[] = {1,2,3,4,5,6,7,8,9}
            ai arrayr moddho theke 5 er theke boro elements guli k ascending order e sajaw.
            */
            //int countOfF = 0,indx=0;
            int [] num = new int[] { 1, 9, 3, 6, 5, 4, 7, 8, 2 };
            /*
            for (int i = 0; i < num.Length ; i++)
                {
                if (num[i] > 5)
                    {
                    countOfF++;
                    }
                }
            int[] newNum = new int[countOfF];
            for (int i = 0; i < num.Length; i++)
                {
                if (num[i] > 5)
                    {
                    newNum[indx] = num[i];
                    indx++;
                    }
                }
            Array.Sort(newNum);
            Array.Reverse(newNum);
            for (int i = 0; i < newNum.Length; i++)
                {
                Console.WriteLine(newNum[i]);
                }
            */
            var newNum1 = from i in num select i; ///select all from num
            var newNum2 = from i in num where i > 5 select i; /// select i  where num > 5 
            var newNum4 = from i in num where i > 5 orderby i select i; /// select i  where num > 5 and ordered by acsending 
            var newNum3 = from i in num where i > 5 orderby i descending select i; /// select i  where num > 5 and ordered by decending 

            foreach (var v in newNum1)
                {
                Console.Write(v+" ");
                }Console.WriteLine();

            foreach (var v in newNum2)
                {
                Console.Write(v + " ");
                }Console.WriteLine();

            foreach (var v in newNum3)
                {
                Console.Write(v + " ");
                }Console.WriteLine();

            foreach (var v in newNum4)
                {
                Console.Write(v + " ");
                }Console.WriteLine();
            }
        }
    }
