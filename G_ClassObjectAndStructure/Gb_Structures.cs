//////A Structure is a user defined datatype
using System;
namespace D_ClassObjectAndStructure
    {
    struct Gb_Structures
        {
        ///Instance Variables
        //public int varible1=10; //in struct instance variables can only be initialized in constructor or after creating an object
        public int varible1;
        public string welcomeMsg;

        ///Constructor

        /*
        //Structures can not use parameterless constructor more specificly there is always a default constructor in struct which cannot be overriden
        public Structures()
            {
            this.varible1 = 256;
            this.welcomeMsg = "This is a Variable";
            }
        */

        //Structures can use parameterized constructor
        public Gb_Structures(int i,string s)
            {
            this.varible1 = i;
            this.welcomeMsg = s;
            }


        ///Methods
        public void Display()
            {
            Console.WriteLine(this.welcomeMsg);
            Console.WriteLine(this.varible1);
            }


        }
    }
