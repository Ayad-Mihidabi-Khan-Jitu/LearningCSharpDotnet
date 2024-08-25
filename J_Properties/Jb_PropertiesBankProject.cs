using Microsoft.VisualBasic;
using System;
namespace Properties
    {
       ///Part-2
        public enum Month {January,February,March,April,May,June,July,August,September,October,November,December}


    class Customer
        {
        string _BankName = "AM Bank Ltd.";
        string _name;
        double _balance;
        public bool status = false;
        Month _month; //Part-2

        /*
        internal Customer(string name, double balance)
            {
            this._name = name;
            this._balance = balance;
            this.status = true;
            }
        */

       
        ///Part-2
        internal Customer(string name, double balance, Month month)
            {
            this._name = name;
            this._balance = balance;
            this.status = true;
            this._month = month;
            this.year = year;
            }

        //with automatic property in the constructor
        internal Customer(string name, double balance, Month month, string year)
            {
            this._name = name;
            this._balance = balance;
            this.status = true;
            this._month = month;
            this.year = year;
            }
        ///P2


        internal string BankName
            {
            get { return _BankName; }
            }
        internal string name
            {
            get { return _name; }
            set
                {
                if (status == true)
                    {
                    _name = value;
                    }
                }
            }
        internal double balance
            {
            get
                { return _balance; }

            set
                {
                if (status)
                    {
                    if (value >= 100)
                        {
                        _balance = value;
                        }
                    }
                }
            }

        ///Part-2
        public Month month
            {
            get { return _month; }
            protected set {
                if(status) _month = value; 
                    } 
          }

        //automatic property (jekhane kono instance variable nai)
        public string year
            {
            get;
            set;
            } = "2020";



    }


    class Jb_PropertiesBankProject
        {
        static void Main()
            {

            ///Part-1
            /*
            Customer c1 = new Customer("Jitu", 500);
            Console.WriteLine(c1.BankName);
            Console.WriteLine("Name : "+c1.name);
            Console.WriteLine("Balance : "+c1.balance);
            Console.WriteLine("Account Status : "+c1.status);
            */

            /*
            c1.status = true;
            c1.name = c1.name + " PhD";
            c1.balance = c1.balance - 400;
            Console.WriteLine("--After Modification of Name and balance--");
            Console.WriteLine(c1.BankName);
            Console.WriteLine("Name : " + c1.name);
            Console.WriteLine("Balance : " + c1.balance);
            Console.WriteLine("Account Status : " + c1.status);
            */

            /*
            c1.status = true;
            c1.name = c1.name + " PhD";
            //c1.balance = c1.balance - 450;
            c1.balance = c1.balance + 100;
            Console.WriteLine("--After Modification of Name and balance--");
            Console.WriteLine(c1.BankName);
            Console.WriteLine("Name : " + c1.name);
            Console.WriteLine("Balance : " + c1.balance);
            Console.WriteLine("Account Status : " + c1.status);
            */

            ///Part-2
            Console.BackgroundColor = ConsoleColor.Cyan;
            Customer c1 = new Customer("Jitu", 500, Month.January);
            Console.WriteLine("Today is : " + c1.month);
            Console.WriteLine(c1.BankName);
            Console.WriteLine("Name : "+c1.name);
            Console.WriteLine("Balance : "+c1.balance);
            Console.WriteLine("Account Status : "+c1.status);

            Console.BackgroundColor = ConsoleColor.Blue;
            //c1.day = Day.Saterday; //can not assign value that we cannot set value without being child class
            Console.WriteLine("Today is : " + c1.month + " " + c1.year);
            Console.WriteLine(c1.BankName);
            Console.WriteLine("Name : " + c1.name);
            Console.WriteLine("Balance : " + c1.balance);
            Console.WriteLine("Account Status : " + c1.status);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Customer c2 = new Customer("Jitu", 500, Month.December,"2022");
            Console.WriteLine("Today is : " + c2.month + " "+c2.year);
            Console.WriteLine(c2.BankName);
            Console.WriteLine("Name : " + c2.name);
            Console.WriteLine("Balance : " + c2.balance);
            Console.WriteLine("Account Status : " + c2.status);
            Console.BackgroundColor = ConsoleColor.White;
            }
        }
    }
