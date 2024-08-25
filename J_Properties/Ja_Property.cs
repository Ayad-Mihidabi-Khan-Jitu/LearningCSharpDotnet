/*
Properties er mul uddsho holo akta class er private instance variable guli k access korar mechanism 
NOTE: constructor er maddhomeo private instance variables guli set kora jay but get korte pari na
Syntex: access_modifier    dataType        property_name {  get{}; set;  }
*/
using System;
namespace Properties
    {
    class PrivateClass
        {
        //int houseNo = 53;
        //int _houseNo = 53; //jokhon kono vairable er property hobe tokhon seta _NameOfTheVariable ata industrial notation

        /*
        ///Process-1
        ///houseNo vairable er value ta get korar jonno
        public int getHouseNo()
            {
            return houseNo;
            }

        ///houseNo vairable er value ta set korar jonno
        public void setHouseNo(int s)
            {
            houseNo=s;
            }
        */

        ///Process-2
        /*
        public int GetSetHouseNo //houseNo hobe property name orthat se variable er property tar age just '_' ta nai
            {
            get { return houseNo; }
            set { houseNo = value; }
            }
        */

        /*
        //amra chaile properties guli te condition o arop korte pari
        public int houseNo //houseNo hobe property name orthat se variable er property tar age just '_' ta nai
         {
            get { return _houseNo; }
            set
                {
                if (value > 200)
                    _houseNo = value;
                }
         }
        */

        public string houseName
            {get;set;}
    }

    class Ja_Property
        {
            static void Main(string[] args)
                {
                Console.WriteLine("Properties");
                PrivateClass p1 = new PrivateClass();
            //p1. //access korte pari na coz houseNo private
            // jodi access kortei hoy tahole akta encamsulation process use korte hobe that is get,set method create korte hobe

            /*
            ///Using process-1
            ///getting the vaule of that private variable
            Console.WriteLine(p1.getHouseNo());

            ///setting the vaule of that private variable
            p1.setHouseNo(100);

            ///getting the vaule of that private variable
            Console.WriteLine(p1.getHouseNo());
            */

            /* 
            ///Using process-2
            ///getting the vaule of that private variable
            Console.WriteLine(p1.GetSetHouseNo);

             ///setting the vaule of that private variable
             p1.GetSetHouseNo = 100 ;

            ///getting the vaule of that private variable
            Console.WriteLine(p1.GetSetHouseNo);
          */

            /*
            Console.WriteLine(p1.houseNo); //default value
            
            p1.houseNo = 100; //value that does not fulfil condition
            Console.WriteLine(p1.houseNo);
            
            p1.houseNo = 201; //value that fulfils condition
            Console.WriteLine(p1.houseNo);
            */
            }

        }
}
