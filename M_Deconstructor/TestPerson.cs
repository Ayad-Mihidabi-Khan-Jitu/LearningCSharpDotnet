/*
Properties er motoi Deconstructor mul uddsho holo akta class er private instance variable guli k access kora onno class theke
NOTE: constructor er maddhomeo private instance variables guli set kora jay but get korte pari na
Syntex: public void Deconstruct(out int parameter, out string parameter)
                {
                 parameters = oi private instance variables;
                }
*/
using System;
namespace Deconstructor
    {
    class Person
        {
        int _houseNo;
        string _address;
        internal Person(int houseNo, string address)
            {
            _houseNo = houseNo;
            _address = address;
            }
        public void Deconstruct(out int houseNo, out string address)
            {
            houseNo = _houseNo;
            address = _address;
            }

        /*
         ///overloading is not necessary
        public void Deconstruct(out int houseNo)
            {
            houseNo = _houseNo;
            }
        */

        }
    class TestPerson
        {
        static void Main(string[] args)
            {
            Console.WriteLine("TestPerson");
            Person p1 = new Person(34,"dhaka");
            //(int house, string addre) = p1;
            //(var house, var addre) = p1;
            var(house,addre) = p1;
            Console.WriteLine("House No : "+house);
            Console.WriteLine("Address  : "+addre);

            Person p2 = new Person(36, "london");
            (int house1, _) = p1; ///overload is not necessary aijonnoi
            //(var house1, _) = p1; ///overload is not necessary aijonnoi
            //var (house1,_) = p1; ///overload is not necessary aijonnoi
            Console.WriteLine("House No : " + house1);

            }
        }
    }
