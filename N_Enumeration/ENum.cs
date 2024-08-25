///A Enumeration is a user defined datatype
/*
 An enumeration is a complete, ordered listing of all the items in a collection.
 It is a value type catagory likewise structure
 Directly namespace er vitore enum type declare kora valo. 
 Class or Structure er vitoreo declare kora jay
 NOTE : enum typer data guli by default int, echara byte,sbyte,short,ushort,uint,int,long,ulong
Syntex: access_modifier     enum      enumName      { elements,elements,... }
*/

using System;
namespace Enumeration
    {
     public enum Day //:int
        {
        Friday, Saterday, Sunday, Monday, Tuesday
        }

    public enum Portfolio : byte
        {
        Manager = 3 , Chairman = 2, Director = 5, CEO = 4, Founder = 1
        }

    class ENum
        {
        ///these are all automatic properties
        public static Day ImportantMeetingDate
            {
            get; set;
            } = 0;

        public static Day CasualMeetingDate
            {
            get; set;
            } = (Day)4;

        public static Day FormalMeetingDate
            {
            get; set;
            } = Day.Monday;
        static void Main(string[] args)
            {
            Console.WriteLine("Enumeration");

            Day day1=0; // index 0 initialize kora jay without casting 
            Day day2 = (Day)1; //baki index duli initialize korar khetre cast must
            Day day3 = (Day)2; //baki index duli initialize korar khetre cast must
            Day day4 = (Day)3; //baki index duli initialize korar khetre cast must
            Day day5 = (Day)4; //baki index duli initialize korar khetre cast must
            Day day6 = (Day)5; //baki index duli initialize korar khetre cast must, index 5 bolte kichui nai so 5 ta e print korbe

            Console.WriteLine(day1);
            Console.WriteLine((int)day2); //
            Console.WriteLine(day3);
            Console.WriteLine(day4);
            Console.WriteLine(day5);
            Console.WriteLine(day6); //5

            Console.WriteLine(ImportantMeetingDate);
            Console.WriteLine(CasualMeetingDate);
            Console.WriteLine(FormalMeetingDate);

            foreach( byte role in Enum.GetValues(typeof(Portfolio)))
                {
                Console.WriteLine(role+" : "+(Portfolio)role);
                }

            foreach ( string role in Enum.GetNames(typeof(Portfolio)) )
                {
                Console.WriteLine(role);
                }
            }
        
        }
    }