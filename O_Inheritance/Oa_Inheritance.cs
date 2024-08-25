/*
Inheritance bojhar jonno amra duita relation bujhbo age
1. is relatoin : A person is a teacher, A person is a business man. is ralation thakle inheritance kora jay
2. has relation :  A Bank has Customer. tai ekhane Bank and Customer er moddhe inheritance kora jabe na.
Inheritance : Jodi dui ta class er moddhe same boisisto thake tahole jetar moddhe kom boisisto thakbe seta k
                          Super class ar jeta te beshi seta k Sub class. Infact je class ta sobar jonnoi common features dharon korbe setai Super Class
                          ar baki shob guli Sub Class.
Claims of Interitance : i) obossoi 2 BA TOTODHIK class lagbe 
                                            ii) class duitar moddhe obossoi IS RELATION thakte hobe
                                            iii) je class ta shokol class er moddhei common seta SUPER Class
                                            iv) Sub class ti super class er shob kichu,instance variable and methods inherit kore amonki Super Class er constructor o
                                                  Sub Class call kore. Constructor!! koya chillanor kono mane nai, amra jani constructor er maddhomei instance variable 
                                                  value prapto hoy that is kono instance variable access korte pare manei holo constructor er maddhomei access kore.
Syntex: class Sub_Class : Super_Class
NOTE : INHERITANCE OFF korao jay -> sealed class ClassName{ } 
               je class ti scaled hobe se class k kew ar inherit korte parbe na
               C# multi inheritance allow kore na. multi inheriance mane holo akta child er aker odhik parent. bastobew jeta sombov na.
               C++ multi inheritance allow kore.
*/
using System;
namespace Inheritance
    {
    class Oa_Inheritance
        { 
        static void Main(string[] args)
            {
            Console.WriteLine("Inheritance");
            GovtTeacher t1 = new GovtTeacher();
            t1.personName(); //ata super class er method
            t1.salaryInstitution(); //ata super class er method
            t1.eidBonus(); //ata super class er method
            t1.penofins(); //akmatro ata class er method
             
            People p1 = new People(); 
            }
        }

    class People 
        {
        public string name = "Jitu";
        public void personName()
            {
            Console.WriteLine("Name of the person : " + name);
            }
        }
    class Teacher:People
        {   
        public int salary = 100000;
        public string institution = "PSTU";
        public void salaryInstitution() {
        Console.WriteLine("Salary : "+salary);
        Console.WriteLine("Institution : "+ institution);

        }
    }
     class PrivateTeacher:Teacher
        {
        public int eeidi=50000;
        public void eidBonus()
            {
            Console.WriteLine("Eid bonus "+eeidi);
            }
        }
     sealed class GovtTeacher:PrivateTeacher
        {
        public int pension=3000000;
        public void penofins()
            {
            Console.WriteLine("Pension : "+ pension);
            }
        }
    
    /// ata compile time ei wrong dekhbe je can't inherit GovtTeacher
    /*
    class Professor : GovtTeacher
        {

        }
    */
    
    /*
    /// ata thik thak asbe 
    class Professor:PrivateTeacher
        {

        }*/
 
    }